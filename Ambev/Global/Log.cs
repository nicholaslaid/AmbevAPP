using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ambev.Global.Config;

namespace Ambev.Global
{
    public class Log
    {

        public static void Save(string msg)
        {
            //verifica se a pasta existe 
            if (!Directory.Exists(Config.logFolder))
            {
                Directory.CreateDirectory(Config.logFolder);
            }
            //verifica se o arquivo existe
            if (!File.Exists(Config.logName))
            {

                File.Create(Config.logName).Dispose();
            }
            //grava o log no arquivo
            File.AppendAllText(Config.logPath, DateTime.Now.ToString("dd/MM/yyy HH:mm:ss")
                + " - " + msg + Environment.NewLine);
        }

    }

}
