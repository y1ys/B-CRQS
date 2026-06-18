using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace WindowsFormsApp5
{
    static class Program
    {
        private static string time = DateTime.Now.ToString("yyyy-MM-dd");
        private static string logFilePath = @"D:\error\"+time +"error_log.txt"; // Specify the path for the log file
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            
                                                                 // 设置未捕获异常处理程序
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);


            bool isAppRunning = false;
            Mutex mutex = new Mutex(true, Process.GetCurrentProcess().ProcessName, out isAppRunning);
            if (!isAppRunning)
            {
                MessageBox.Show("程序已运行，不能再次打开。");
                Environment.Exit(1);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            // 处理线程异常
            //MessageBox.Show("发生了未处理的异常：" + e.Exception.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //MessageBox.Show("发生了未处理的异常：" +e.Exception.Message+"\n"+
            //    e.Exception.StackTrace, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LogExceptionToFile(e.Exception);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // 处理应用程序域中的异常
            //Exception ex = e.ExceptionObject as Exception;
            //if (ex != null)
            //{
            //    MessageBox.Show("发生了未处理的异常：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    MessageBox.Show("发生了未处理的非托管异常", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            // Handle exceptions in the application domain
            if (e.ExceptionObject is Exception ex)
            {
                LogExceptionToFile(ex);
            }
            else
            {
                LogMessageToFile("Unhandled non-managed exception occurred.");
            }
        }
        static void LogExceptionToFile(Exception exception)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"[{DateTime.Now}] Unhandled Exception: {exception.Message}");
                    writer.WriteLine($"StackTrace: {exception.StackTrace}");
                    writer.WriteLine(new string('-', 50)); // Separator
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to log exception to file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static void LogMessageToFile(string message)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"[{DateTime.Now}] {message}");
                    writer.WriteLine(new string('-', 50)); // Separator
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to log message to file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
