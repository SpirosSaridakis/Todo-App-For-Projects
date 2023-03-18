using Project_Todo.Data;

namespace Project_Todo
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
            ApplicationDbContext context= new ApplicationDbContext();
            Application.Run(new MainWindow(context));
        }
    }
}