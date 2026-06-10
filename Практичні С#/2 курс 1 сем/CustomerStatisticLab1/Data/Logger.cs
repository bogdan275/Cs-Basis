using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public static class Logger
    {
        private static string _logFilePath = "Domain.log"; 
        private static readonly object _lockObject = new object();

        public static void SetLogFilePath(string path)
        {
            _logFilePath = path;
        }

        public static void LogInfo(string message)
        {
            Log("INFO", message);
        }

        public static void LogWarning(string message)
        {
            Log("WARNING", message);
        }

        public static void LogError(string message)
        {
            Log("ERROR", message);
        }

        public static void LogError(string message, Exception ex)
        {
            var fullMessage = $"{message}\nException: {ex.GetType().Name}\nMessage: {ex.Message}";

            if (ex.InnerException != null)
            {
                fullMessage += $"\nInner Exception: {ex.InnerException.Message}";
            }

            Log("ERROR", fullMessage);
        }

        private static void Log(string level, string message)
        {
            try
            {
                var timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                var logEntry = $"[{timestamp}] [{level}] {message}";

                File.AppendAllText(_logFilePath, logEntry + Environment.NewLine);
            }
            catch
            {
            }
        }

        public static void ClearLog()
        {
            try
            {
                if (File.Exists(_logFilePath))
                {
                    File.Delete(_logFilePath);
                }
            }
            catch
            {
            }
        }

        public static string ReadLog()
        {
            try
            {
                if (File.Exists(_logFilePath))
                {
                    return File.ReadAllText(_logFilePath);
                }
                return string.Empty;
            }
            catch
            {
                return "Error reading log file";
            }
        }
    }
}
