using EvilDICOM.Core;
using EvilDICOM.Core.Helpers;
using EvilDICOM.Network.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTDataInjector
{
    class Prioritizer
    {
        private Injector injector;
        private Operations operations;
        private string[] modalities = new string[] { "CT", "MR", "PT", "US", "RTSTRUCT", "RTPLAN", "RTDOSE" };

        /// <summary>
        /// Default constructor that will create an injector using the default entities.  
        /// </summary>
        public Prioritizer() : this(new Injector())
        {

        }

        /// <summary>
        /// Overloaded constructor.
        /// </summary>
        public Prioritizer(Injector injector)
        {
            this.injector = injector;
            this.operations = new Operations();
            InitializeInjector();
        }

        /// <summary>
        /// Read-only property.
        /// </summary>
        public Injector Injector
        {
            get { return injector; }
        }

        /// <summary>
        /// Prioritized C-STORE operations dependant on the Injector.
        /// </summary>
        public List<string> StartPrioritizedStore(IEnumerable<DirectoryInfo> patientDirectories, MainForm mainForm)
        {
            

            // Output array
            List<string> injectedDcmFiles = new List<string>();

            // Counter
            int counter = -1;

            // Loops over patients
            foreach (var patientDirectory in patientDirectories)
            {
                string[] dcmFiles = Directory.GetFiles(patientDirectory.FullName, "*.dcm", SearchOption.AllDirectories);

                // Loops through the modalities in the preferred order
                foreach (string modality in modalities)
                {
                    for (int fileIndex = 0; fileIndex < dcmFiles.Length; fileIndex++)
                    {
                        DICOMObject dicomObject = DICOMObject.Read(dcmFiles[fileIndex]);
                        if (modality.Equals((string)dicomObject.FindFirst(TagHelper.Modality).DData))
                        {
                            // Editing the DICOM files
                            EditDICOMFiles(dicomObject);

                            if (dicomObject == null)
                            {

                            }

                            // Performs the C-STORE operation
                            Status response = injector.Store(dicomObject);
                            counter++;

                            // Handles the DICOM file dependent on the response
                            if (response == Status.SUCCESS)
                            {
                                injectedDcmFiles.Add(dcmFiles[fileIndex]);
                            }
                            else
                            {
                                mainForm.WriteErrorMessage(dcmFiles[fileIndex].Split('\\').Last() + " Failed with status: " + response.ToString());
                            }
                        }
                        else if (modality.Equals(modalities.First()) &&  modalities.Where(r => r.Equals((string)dicomObject.FindFirst(TagHelper.Modality).DData)).Count() == 0)
                        {
                            mainForm.WriteErrorMessage("The DICOM file \"" + dcmFiles[fileIndex].Split('\\').Last() + "\" was not injected. Modality other than " + string.Join(", ", modalities));
                            counter++;
                        }
                        if (counter >= 0)
                        {
                            mainForm.UpdateProgressBar(counter);
                        }
                    }
                }
                mainForm.WriteErrorMessage(patientDirectory.Name + " handled");
            }
            return injectedDcmFiles;
        }

        /// <summary>
        /// Initializes the injector.
        /// </summary>
        private void InitializeInjector()
        {
            injector.CreateCStorer();
        }

        /// <summary>
        /// Counts the number of DICOM files having the modality CT, MR, PT, US, RTSTRUCT, RTPLAN or RTDOSE.
        /// </summary>
        public int CountValidDicomFiles(string[] dcmFiles)
        {
            int counter = 0;
            foreach (string modality in modalities)
            {
                for (int fileIndex = 0; fileIndex < dcmFiles.Length; fileIndex++)
                {
                    DICOMObject dicomObject = DICOMObject.Read(dcmFiles[fileIndex]);
                    if (modality.Equals((string)dicomObject.FindFirst(TagHelper.Modality).DData))
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        /// <summary>
        /// Edits the DICOM files depending on modality. 
        /// </summary>
        private void EditDICOMFiles(DICOMObject dicomObject)
        {
            if ((string)dicomObject.FindFirst(TagHelper.Modality).DData == "RTPLAN")
            {
                operations.Unapprove(dicomObject);
                operations.RemoveReferencedPlan(dicomObject);
                operations.EmptySetupNote(dicomObject);

            }
            else if (dicomObject.FindFirst(TagHelper.Modality).DData.Equals("RTSTRUCT"))
            {
                operations.Unapprove(dicomObject);
            }
        }
    }
}
