using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
    public class InvalidCustomerDataException : CustomerDataException
    {
        public string FieldName { get; set; }
        public string InvalidValue { get; set; }

        public InvalidCustomerDataException(string fieldName, string invalidValue, string message)
            : base(message)
        {
            FieldName = fieldName;
            InvalidValue = invalidValue;
        }
    }
}
