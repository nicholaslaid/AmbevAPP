using Ambev.Models;
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
        public static string apiBaseUrl = "http://localhost:5193/api/";
         
        public static string token = string.Empty;
        public static string tokenMemory = string.Empty;
        public static string newToken = string.Empty;

        public static Produtos tempProd = new Produtos();

        public static string key = "3fsdRW24366#$2dAsdfgY3412SD25&aa@!!@@kjsdpi32489mcs@dsf@D34F5¨H";

      

        //Diretório raiz da aplicação
        public static string appRootFolder = AppDomain.CurrentDomain.BaseDirectory;

        //Habilita os logs conforme o tipo
        public static bool logSuccessEnabled = Convert.ToBoolean(ConfigurationManager.AppSettings["logSuccessEnabled"]);
        public static bool logErrorEnabled = Convert.ToBoolean(ConfigurationManager.AppSettings["logErrorEnabled"]);
        public static bool logInfoEnabled = Convert.ToBoolean(ConfigurationManager.AppSettings["logInfoEnabled"]);

        //Nome pasta e caminho do log
        public static string logName = ConfigurationManager.AppSettings["logFileName"];
        public static string logFolder = ConfigurationManager.AppSettings["logFilePath"];
        public static string logPath = Path.Combine(appRootFolder, logFolder, logName);


    }


    public enum LogType
    {
        success = 1,
        info = 2,
        error = 3
    }

    public enum LogSave
    {
        database = 1,
        file = 2
    }
}
