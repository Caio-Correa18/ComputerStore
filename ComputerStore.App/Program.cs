using ComputerStore.App.Base;
using ComputerStore.App.Others;
using ComputerStore.App.Register;
using System.Runtime.CompilerServices;
using ComputerStore.App.Infra;

namespace ComputerStore.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ConfigureDI.ConfigureServices();
            ApplicationConfiguration.Initialize();          
            Application.Run(new MainForm());
            
            
        }
    }
}