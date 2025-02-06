namespace TravDocGen
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        // Mutex to ensure only one instance runs
        private static Mutex mutex = null;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new mainForm());


            const string appName = "TravDocGen";
            bool createdNew;

            // Create a new mutex and check if it is already created
            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                // If the mutex is already created, it means another instance is running
                MessageBox.Show("An instance of TRAV DOC GEN is already running.");
                return;
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());

            // Release the mutex when the application exits
            GC.KeepAlive(mutex);
        }
    }
}