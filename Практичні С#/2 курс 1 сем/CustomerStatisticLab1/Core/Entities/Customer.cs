using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string Gender { get; set; }  
        public bool IsSeniorCitizen { get; set; }
        public bool HasPartner { get; set; }
        public bool HasDependents { get; set; }
        public int TenureMonths { get; set; }
        public CustomerServices Services { get; set; }
        public CustomerContract Contract { get; set; }
        public decimal MonthlyCharges { get; set; }
        public decimal TotalCharges { get; set; }
        public bool HasChurned { get; set; }

        public Customer()
        {
            Services = new CustomerServices();
            Contract = new CustomerContract();
        }
    }
}
