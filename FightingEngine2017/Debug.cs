using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine2017
{
    public static class Debug
    {
        static string messageLog = "";

        public static void Log(string message)
        {
            Console.WriteLine(message);
        }

        public static void Warning(string message)
        {
            Console.WriteLine(string.Format("[WARNING]{0}", message));
            // TODO: Add some extra stuff for warnings.
        }

        public static void Error(string message)
        {
            Console.WriteLine(string.Format("[ERROR]{0}", message));
            throw new Exception(message);
        }

        public static void Dump(string path = "")
        {
            if (path == "")
                path = System.IO.Directory.GetCurrentDirectory();

            System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.OpenOrCreate);
            fs.Write(new UTF8Encoding().GetBytes(messageLog), 0, messageLog.Length);
        }
    }
}