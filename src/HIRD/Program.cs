using HIRD.ServerUI;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.InteropServices;

namespace HIRD
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Contains("--silent"))
            {
                AppSettings.Instance.MinimizeToTray = true;
                AppSettings.Instance.StartMinimized = true;
                AppSettings.Instance.AutoStartServer = true;
            }

            if (args.Contains("--minimized"))
                AppSettings.Instance.StartMinimized = true;

            if (args.Contains("--autostart"))
                AppSettings.Instance.AutoStartServer = true;

            if (args.Contains("--delayed"))
                Task.Delay(5000).Wait();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

#if DEBUG
            AllocConsole();
#endif
            var form = new ServiceCollection().AddLogging()
                                              .AddSingleton<MainForm>()
                                              .BuildServiceProvider()
                                              .GetRequiredService<MainForm>();

            Application.Run(form);
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
    }
}