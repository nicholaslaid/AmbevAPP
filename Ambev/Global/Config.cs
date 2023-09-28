using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.Global
{
    public class Config
    {
        public static string apiBaseUrl = "https://localhost:7058/api/";

        public static string token = string.Empty;
        public static string tokenMemory = string.Empty;
   

        

        public static string appRootFolder = AppDomain.CurrentDomain.BaseDirectory;
        public static string logName = ConfigurationManager.AppSettings["logFileName"];
        public static string logFolder = ConfigurationManager.AppSettings["logFilePath"];
        public static string logPath = Path.Combine(appRootFolder, logFolder, logName);

       
        public enum LogSave
        {
            database = 1,
            file = 2
        }
    }
}
