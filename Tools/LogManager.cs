using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class LogManager
    {
        private const string PATH = "Log";
        private static string prefix = "\t";

        private static string getThisMonthDir()
        {
            string path = $@"{PATH}\{DateTime.Now.Year}-{DateTime.Now.Month}";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return path;
        }
        private static string getTodayFile()
        {
            string path = $@"{getThisMonthDir()}\{DateTime.Now.Day}.txt";
            if (!File.Exists(path))
                File.Create(path).Close();
            return path;
        }
        public static void WriteToLog(string projectName,string funcName, string message)
        {
            using (StreamWriter sw = new StreamWriter(getTodayFile(), true))
            {
                sw.WriteLine($"{DateTime.Now}{prefix}{projectName}.{funcName}:\t{message}");
            }
        }

        public static void WriteToLogStart(string projectName, string funcName, string message)
        {
            WriteToLog(projectName,funcName,$"{message} start");
            prefix += "\t";
        }
        public static void WriteToLogEnd(string projectName, string funcName, string message)
        {
            prefix = prefix.Substring(1);
            WriteToLog(projectName,funcName,$"{message} end\n");
        }
        public static void DeleteLog()
        {
            string[] directories = Directory.GetDirectories(PATH);

            DateTime now = DateTime.Now;
            DateTime[] lastThreeMonths = new DateTime[3];
            for (int i = 0; i < 3; i++)
            {
                lastThreeMonths[i] = now.AddMonths(-i); 
            }

            foreach (string directory in directories)
            {
                string directoryName = Path.GetFileName(directory);
                string[] parts = directoryName.Split('-');
                int year = int.Parse(parts[0]);
                int month = int.Parse(parts[1]);
                {
                    DateTime folderDate = new DateTime(year, month, 1);
                    if (!Array.Exists(lastThreeMonths, date => date.Year == folderDate.Year && date.Month == folderDate.Month))
                    {
                        Directory.Delete(directory, true);
                    }
                }
            }
        }

    }
}
