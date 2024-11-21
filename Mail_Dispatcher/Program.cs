namespace Mail_Dispatcher
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

            // Dont forget to uncomment this jaba setUp Garxau
            //Task.Run(() => DBandSchemaManager.Instance.DbSetUp().Wait());

            Application.Run(new authForm(new Output())); // suiii haneko
        }
    }
}