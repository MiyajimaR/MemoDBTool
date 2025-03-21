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

            //---下記宮島作成
            Action act = () => 
            { 
                ClsLibrary da = new();
                da.InitApp(); 
            };

            act();
            //---ここまで作成

            Application.Run(new Form1_MainMenu());
        }
    }
}