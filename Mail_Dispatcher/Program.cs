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
            Task.Run(() => DBandSchemaManager.Instance.DbSetUp().Wait());

            Dashboard dashboard = new Dashboard();
            Output printer = new(); 

            var authForm = new authForm(() => dashboard, printer);
            // bichamaa yedi addition kam garnu parda on Auth Validation
            //authForm.AuthenticationSuccessful += (sender, e) =>
            //{
            //};

            //Application.Run(authForm); // suiii haneko
            Application.Run(new Dashboard()); // test
        }
    }
}