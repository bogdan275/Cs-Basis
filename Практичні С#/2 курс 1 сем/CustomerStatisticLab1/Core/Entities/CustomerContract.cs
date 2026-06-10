using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class CustomerContract
    {
        public string ContractType { get; set; }  // "Month-to-month", "One year", "Two year"
        public bool PaperlessBilling { get; set; }
        public string PaymentMethod { get; set; }  // "Electronic check", "Mailed check", etc.
    }
}
