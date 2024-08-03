namespace SearchMemoDatabase
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

            //---â∫ãLã{ìáçÏê¨
            Action act = () => 
            { 
                ClsLibrary da = new();
                da.InitApp(); 
            };

            act();
            //---Ç±Ç±Ç‹Ç≈çÏê¨

            Application.Run(new Form1_MainMenu());
        }
    }
}