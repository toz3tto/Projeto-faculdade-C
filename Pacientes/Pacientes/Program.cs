namespace Pacientes
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
            //Application.Run(new lblPacientes());
            //Application.Run(new FormExercicios());
            Application.Run(new Form_Principal());
            //Application.Run(new TelaCadastros());
        }
    }
}