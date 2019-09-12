using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BatchPlotting
{
    internal class Log
    {
        private static string CleanFileName(string fileName)
        {
            return Path.GetInvalidFileNameChars().Aggregate(fileName, (current, c) => current.Replace(c.ToString(), string.Empty));
        }

        public static void WriteDebugLog(string dwgName, string dwgPath, string userName, DateTime dateTime, string message, bool isStart)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            path = Path.Combine(path, "BatchPlotting\\Log");
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            userName = CleanFileName(userName);
            string logFilePath = Path.Combine(path, "publish_" + userName + "_" + dateTime.Day + dateTime.Month + dateTime.Year + ".txt");
           
            if (!File.Exists(logFilePath))
            {
                using (StreamWriter wrter = File.CreateText(logFilePath))
                {
                    wrter.WriteLine("******************Batch Ploting Debug Log******************");
                }
            }
            using (StreamWriter strmWriter = new StreamWriter(logFilePath, true))
            {
                strmWriter.WriteLine(Environment.NewLine);
                if (isStart)
                    strmWriter.WriteLine("Time Started" + "                 " + dateTime.ToString() + "         ");
                strmWriter.WriteLine("                             " + message + " " + dwgName + "            ");
                strmWriter.WriteLine("File Path" + "                    " + dwgPath + "            ");
                if (!isStart)
                    strmWriter.WriteLine("Time Finished" + "                " + dateTime.ToString() + "            ");
            }
        }

        public static void WriteExceptionLog(string message, string methodName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            path = Path.Combine(path, "BatchPlotting\\Log");
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            string logFilePath = Path.Combine(path, "ExceptionLog.txt");
            if (!File.Exists(logFilePath))
            {
                using (StreamWriter wrter = File.CreateText(logFilePath))
                {
                    wrter.WriteLine("******************Batch Ploting Exception Log******************");
                }
            }

            using (StreamWriter strmWriter = new StreamWriter(logFilePath, true))
            {
                strmWriter.WriteLine(Environment.NewLine);
                strmWriter.WriteLine("Time :         " + DateTime.Now);
                strmWriter.WriteLine("Exception :           " + message);
            }

        }
    }
}
