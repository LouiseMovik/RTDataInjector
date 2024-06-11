using EvilDICOM.Network;
using EvilDICOM.Network.SCUOps;
using EvilDICOM.Core;
using EvilDICOM.Network.DIMSE;
using EvilDICOM.Network.Enums;
using System.Windows.Forms;
using RTDataInjector.Properties;
using System.Collections.Generic;

namespace RTDataInjector
{
    class Injector
    {
        private Entity daemon;
        private Entity local;
        private CStorer storer;

        /// <summary>
        /// Default constructor that will initialize the default entities.  
        /// </summary>
        public Injector() : this(new Entity(Settings.Default.DaemonAETitle, Settings.Default.DaemonIPAddress, Settings.Default.DaemonPort), Entity.CreateLocal(Settings.Default.LocalAETitle, Settings.Default.LocalPort))
        {
            
        }

        /// <summary>
        /// Overloaded constructor. 
        /// </summary>
        public Injector(Entity daemon, Entity local)
        {
            InitializeEntities(daemon, local);
        }

        /// <summary>
        /// Read and write property.
        /// </summary>
        public Entity Daemon
        {
            get { return daemon; }
            set { daemon = value; }
        }

        /// <summary>
        /// Read and write property.
        /// </summary>
        public Entity Local
        {
            get { return local; }
            set { daemon = value; }
        }

        /// <summary>
        /// Read-only property.
        /// </summary>
        public CStorer Storer
        {
            get { return storer; }
        }



        /// <summary>
        /// Initializes the daemon and local entities. 
        /// </summary>
        private void InitializeEntities(Entity daemon, Entity local)
        {
            // Store the details of the daemon (Ae Title, IP, port)
            this.daemon = daemon;

            // Store the details of the client (Ae Title, port) -> IP address is determined by CreateLocal() method
            this.local = local;
        }

        /// <summary>
        /// Creates a DICOM SCU based on the local entity to get C Storer from the daemon. 
        /// </summary>
        public void CreateCStorer()
        {
            // Set up a client (DICOM SCU = Service Class User)
            DICOMSCU client = new DICOMSCU(local);
            
            // Create a storer 
            storer = client.GetCStorer(daemon);
        }

        /// <summary>
        /// Performs a C-STORE operation using predefined entities.
        /// </summary>
        public Status Store(DICOMObject dicomObject)
        {
            if (storer != null)
            {
                if (dicomObject.AllElements.Count > 0)
                {
                    ushort msgId = 1;

                    // Performs the C-STORE operation
                    CStoreResponse response = storer.SendCStore(dicomObject, ref msgId);

                    return (Status)response.Status;
                }
                MessageBox.Show("An empty DICOMObject cannot be stored.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return Status.FAILURE;
            }
            MessageBox.Show("A storer has to be created.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return Status.FAILURE;
        }

        /// <summary>
        /// Performs the echo operation.
        /// </summary>
        public bool Echo()
        {
            // Set up a client
            DICOMSCU client = new DICOMSCU(local);

            if (client.Ping(daemon, 500))
            {
                return true;
            }
            return false;
        }
    }
}
