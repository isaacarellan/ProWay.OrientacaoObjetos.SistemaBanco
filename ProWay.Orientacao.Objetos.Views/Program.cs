using ProWay.Orientacao.Objetos.Views.Contas;

namespace ProWay.Orientacao.Objetos.Views
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.Run(new FormPrincipal());
            Application.Run(new FormContaPoupanca());
        }
    }
}