using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
    public class CustomerNotFoundException : CustomerDataException
    {
        public string CustomerID { get; set; }

        public CustomerNotFoundException(string customerID)
            : base($"Customer with ID '{customerID}' not found")
        {
            CustomerID = customerID;
        }
    }
}
