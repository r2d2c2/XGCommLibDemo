using BMA.ViewModel;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace BMA.Model
{
    public static class FileLogger
    {
        private static readonly ConcurrentQueue<SystemMessageLog> LogQueue = new ConcurrentQueue<SystemMessageLog>();

        private static string LogPath;
        public static void InitializeLogger(string path)
        {
            LogPath = path;

            var logTask = new Task(() =>
            {
                while (true)
                {
                    if (MainWindowViewModel.IsClosed)
                    {
                        return;
                    }

                    while (!LogQueue.IsEmpty)
                    {
                        LogQueue.TryDequeue(out SystemMessageLog tempMsg);

                        Trace.WriteLine($"[{tempMsg.Header}] [{tempMsg.Time}] [{tempMsg.Content}]");

                        SaveSystemLogFile(tempMsg);

                        //SystemMessage = tempMsg;


                        Thread.Sleep(60);
                    }



                    Thread.Sleep(100);
                }
            });

            logTask.Start();

        }

        public static void Log(ELogHeader header, string message)
        {

            LogQueue.Enqueue(new SystemMessageLog
                (
                    header,
                    message
                ));


        }

        private static void SaveSystemLogFile(SystemMessageLog msg)
        {
            if (msg.Header == ELogHeader.DMMREPEAT_A1 ||
                msg.Header == ELogHeader.DMMREPEAT_A2 ||
                msg.Header == ELogHeader.DMMREPEAT_B1 ||
                msg.Header == ELogHeader.DMMREPEAT_B2)
            {
                string path = $"{LogPath}\\DMM_Repeat\\{DateTime.Now:yyyyMM}\\{msg.Header.ToString().Replace("DMMREPEAT_","")}";

                FileLogger.DirectoryCheck(path);

                path = $"{path}\\[{DateTime.Now:yyyy-MM-dd}] ALLDAY_LOG_REPEAT.txt";

                FileLogger.AppendCSV(msg, path);
            }
            else
            {
                string path = $"{LogPath}\\AllDay\\{DateTime.Now:yyyyMM}";

                FileLogger.DirectoryCheck(path);

                path = $"{path}\\[{DateTime.Now:yyyy-MM-dd}] ALLDAY_LOG.txt";

                FileLogger.AppendCSV(msg, path);
            }
        }

        public static void DirectoryCheck(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);



            if (directoryInfo.Exists == false)
            {
                directoryInfo.Create();
            }
        }


        public static bool WriteCSV<T>(T item, string path, string header)
        {
            Type itemType = typeof(T);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            FileStream fileStream;
            StreamWriter writer;

            try
            {
                using (fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
                {

                    using (writer = new StreamWriter(fileStream))
                    {
                        writer.WriteLine(header);

                        var tempValue = string.Join(",", props.Select(
                            p =>
                            {
                                if (p.PropertyType.IsArray)
                                {
                                    StringBuilder sb = new StringBuilder();
                                    Array tempArr = p.GetValue(item, null) as Array;
                                    foreach (var temp in tempArr)
                                    {
                                        if (temp == null)
                                        {
                                            sb.Append("-,");
                                        }
                                        else
                                        {
                                            sb.Append($"{temp},");
                                        }
                                    }
                                    sb.Remove(sb.Length - 1, 1);
                                    return sb.ToString();
                                }

                                if (p.PropertyType.IsGenericType)
                                {
                                    StringBuilder sb = new StringBuilder();
                                    var tempArr = (IList<double>)p.GetValue(item, null);
                                    foreach (var temp in tempArr)
                                    {
                                        sb.Append($"{temp},");
                                    }
                                    sb.Remove(sb.Length - 1, 1);
                                    return sb.ToString();
                                }

                                return p.GetValue(item, null);
                            }
                            ));

                        writer.WriteLine(tempValue);

                        writer.Flush();
                    }
                }
            }
            catch (Exception ex)
            {
                FileLogger.Log(ELogHeader.SYSTEM, $"{MethodBase.GetCurrentMethod()} : {ex.Message}");
            }

            return true;
        }

        public static bool AppendCSV<T>(T item, string path)
        {
            Type itemType = typeof(T);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            FileStream fileStream;
            StreamWriter writer;

            try
            {
                using (fileStream = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
                {
                    //File.OpenWrite(path, F);
                    using (writer = new StreamWriter(fileStream))
                    {

                        var tempValue = string.Join(",", props.Select(
                            p =>
                            {
                                if (p.PropertyType.IsArray)
                                {
                                    StringBuilder sb = new StringBuilder();
                                    Array tempArr = p.GetValue(item, null) as Array;
                                    foreach (var temp in tempArr)
                                    {
                                        if (temp == null)
                                        {
                                            sb.Append("-,");
                                        }
                                        else
                                        {
                                            sb.Append($"{temp},");
                                        }
                                    }
                                    sb.Remove(sb.Length - 1, 1);
                                    return sb.ToString();
                                }

                                if (p.PropertyType.IsGenericType)
                                {
                                    StringBuilder sb = new StringBuilder();
                                    var tempArr = (IList<double>)p.GetValue(item, null);
                                    foreach (var temp in tempArr)
                                    {
                                        sb.Append($"{temp},");
                                    }
                                    sb.Remove(sb.Length - 1, 1);
                                    return sb.ToString();
                                }

                                return p.GetValue(item, null);
                            }
                            ));

                        writer.WriteLine(tempValue);

                        writer.Flush();
                    }
                }
            }
            catch (Exception ex)
            {
                FileLogger.Log(ELogHeader.SYSTEM, $"{MethodBase.GetCurrentMethod()} : {ex.Message}");
            }

            return true;
        }
    }
}
