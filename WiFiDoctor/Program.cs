using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WiFiDoctor
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ВЫШЕ ЭТОГО КОДА НИЧЕГО НЕ СТАВИТЬ!!!
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException, true);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.SetCompatibleTextRenderingDefault(false);
            //ВЫШЕ ЭТОГО КОДА НИЧЕГО НЕ СТАВИТЬ!!!
            SetAppStartupPath();

            SetAutoRun();
            Application.Run(new Form1());
        }
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            //var mf = (Form1) Application.OpenForms[0];
            // mf.Log(e.Exception.Message);
          
            Debug.Fail(e.Exception.Message, e.Exception.StackTrace);
        }
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var o = e.ExceptionObject as Exception;
            if (o != null)
            {
              
                Debug.Fail(o.Message, o.StackTrace);
                // var mf = (Form1) Application.OpenForms[0];
                //  mf.Log(o.Message);

            }
        }
        public static void SetAutoRun()
        {
            try
            {
                // Открываем нужную ветку в реестре   
                // @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\"  
                var key = Registry.LocalMachine.OpenSubKey(
                    "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", true);
                //добавляем первый параметр - название ключа  
                // Второй параметр - это путь к   
                // исполняемому файлу нашей программы.  
                // ReSharper disable PossibleNullReferenceException
                key.SetValue(Application.ProductName, ExecutablePath);
                // ReSharper restore PossibleNullReferenceException
                key.Close();
            }
            catch (Exception e)
            {
              
                Debug.Fail(e.Message, e.StackTrace);
            }
        }

        public static void TryResetAutoRun()
        {
            try
            {
                //удаляем  
                var key = Registry.LocalMachine.OpenSubKey(
                    "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                // ReSharper disable PossibleNullReferenceException
                key.DeleteValue(Application.ProductName, false);
                // ReSharper restore PossibleNullReferenceException
                key.Close();
            }
            catch (Exception e)
            {
                
                Debug.Fail(e.Message, e.StackTrace);
            }
        }
       
        private static string _executablePath;
        public static string ExecutablePath
        {
            get { return _executablePath; }
        }
        private static void SetAppStartupPath()
        {
            _executablePath = Assembly.GetExecutingAssembly().Location;
            _startupPath = Path.GetDirectoryName(_executablePath);

        }
        private static string _startupPath;
        public static string StartupPath
        {
            get { return _startupPath; }
        }

    }
}
