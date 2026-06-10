using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
    public class EmptyFieldException : CustomerDataException
    {
        public string FieldName { get; set; }

        public EmptyFieldException(string fieldName)
            : base($"Field '{fieldName}' cannot be empty")
        {
            FieldName = fieldName;
        }
    }
}
