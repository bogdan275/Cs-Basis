using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
    public class CustomerDataException : Exception
    {
        public CustomerDataException(string message) : base(message) { }
        public CustomerDataException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
