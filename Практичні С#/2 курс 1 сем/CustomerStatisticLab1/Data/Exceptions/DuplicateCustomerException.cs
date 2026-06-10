using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
    public class DuplicateCustomerException : CustomerDataException
    {
        public string CustomerID { get; set; }

        public DuplicateCustomerException(string customerID)
            : base($"Customer with ID '{customerID}' already exists")
        {
            CustomerID = customerID;
        }
    }
}
