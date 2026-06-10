using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class CustomerServices
    {
        public bool HasPhoneService { get; set; }
        public string MultipleLines { get; set; }  // "Yes", "No", "No phone service"
        public string InternetService { get; set; }  // "DSL", "Fiber optic", "No"
        public string OnlineSecurity { get; set; }  // "Yes", "No", "No internet service"
        public string OnlineBackup { get; set; }
        public string DeviceProtection { get; set; }
        public string TechSupport { get; set; }
        public string StreamingTV { get; set; }
        public string StreamingMovies { get; set; }
    }
}
