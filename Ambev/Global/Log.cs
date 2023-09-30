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

        public static void Add(LogType type, string message)
        {
            try
            {
                if (type == LogType.success && !Convert.ToBoolean(Config.logSuccessEnabled))
                    return;

                else if (type == LogType.info && !Convert.ToBoolean(Config.logInfoEnabled))
                    return;

                else if (type == LogType.error && !Convert.ToBoolean(Config.logErrorEnabled))
                    return;

                else
                {
                    SaveLogToFile(type, message);
                }
            }
            catch
            { }
        }


        private static void SaveLogToFile(LogType type, string message)
        {
            if (!Directory.Exists(Config.logFolder))
                Directory.CreateDirectory(Config.logFolder);

            if (!File.Exists(Config.logPath))
                File.Create(Config.logPath).Dispose();

            File.AppendAllText(Config.logPath, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " - " + type.ToString() + ": " + message + Environment.NewLine);
        }

    }

}
