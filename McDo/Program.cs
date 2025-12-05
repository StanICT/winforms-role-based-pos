using DotNetEnv;

namespace McDo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Load Environment Variables
            Env.Load();

            // Run the McDo Main File
            McDoMain.Run();
        }
    }
}