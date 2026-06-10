using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
    public class FileReadException : CustomerDataException
    {
        public string FilePath { get; set; }

        public FileReadException(string filePath, string message, Exception innerException)
            : base(message, innerException)
        {
            FilePath = filePath;
        }
    }
}
