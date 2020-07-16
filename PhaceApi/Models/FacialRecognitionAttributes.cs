using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhaceApi.Models
{
    public class FacialRecognitionAttributes
    {
        public string url { get; set; }
        public bool ReturnFaceId { get; set; }
        public bool returnFaceLandmarks { get; set; }
        public string ReturnFaceAttributes { get; set; }
        public  RecognitionModel RecognitionModel { get; set;  }
        public bool ReturnRecognitionModel { get; set; }
        public DetectionModel DetectionModel  { get; set; }

    }
}
