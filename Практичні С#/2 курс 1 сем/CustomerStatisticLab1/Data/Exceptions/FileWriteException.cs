using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
    public class FileWriteException : CustomerDataException
    {
        public string FilePath { get; set; }

        public FileWriteException(string filePath, string message, Exception innerException)
            : base(message, innerException)
        {
            FilePath = filePath;
        }
    }
}
