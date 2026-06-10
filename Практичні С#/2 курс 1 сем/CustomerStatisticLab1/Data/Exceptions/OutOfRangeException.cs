using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
    public class OutOfRangeException : CustomerDataException
    {
        public string FieldName { get; set; }
        public object Value { get; set; }
        public object MinValue { get; set; }
        public object MaxValue { get; set; }

        public OutOfRangeException(string fieldName, object value, object minValue, object maxValue)
            : base($"Field '{fieldName}' value {value} is out of range [{minValue}, {maxValue}]")
        {
            FieldName = fieldName;
            Value = value;
            MinValue = minValue;
            MaxValue = maxValue;
        }
    }
}
