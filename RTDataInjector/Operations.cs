using EvilDICOM.Core;
using EvilDICOM.Core.Element;
using EvilDICOM.Core.Helpers;
using EvilDICOM.Network.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTDataInjector
{
    class Operations
    {
        /// <summary>
        /// Unapproves the DICOM file.
        /// </summary>
        public void Unapprove(DICOMObject dicomObject)
        {
            var appStatus = new CodeString
            {
                DData = "UNAPPROVED",
                Tag = TagHelper.ApprovalStatus
            };
            dicomObject.Replace(appStatus);
        }

        /// <summary>
        /// Removes the DICOM tag ReferencedRTPlanSequence.
        /// </summary>
        public void RemoveReferencedPlan(DICOMObject dicomObjects)
        {
            dicomObjects.Remove(TagHelper.ReferencedRTPlanSequence);
        }
        
        public void EmptySetupNote(DICOMObject dicomObjects)
        {
            dicomObjects.Remove(TagHelper.Setup​Technique​Description);
        }
        
    }
}
