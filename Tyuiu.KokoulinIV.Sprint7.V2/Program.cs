using Tyuiu.KokoulinIV.Sprint7.V2;

namespace Tyuiu.KokoulinIV.Sprint6.V2
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
            ApplicationConfiguration.Initialize();
            Application.Run(new Entrance());
        }
    }
}