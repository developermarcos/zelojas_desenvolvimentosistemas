using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;
using System.Globalization;

namespace ControleEstoqueDoZe
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(ConfigurationManager.AppSettings.Get("Cultura"));
            //CultureInfo cultureInfo = new CultureInfo(ConfigurationManager.AppSettings.Get("Cultura"));
            //Thread.CurrentThread.CurrentUICulture = cultureInfo;
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("es");

            MessageBoxManager.Yes = "Simmmm";
            MessageBoxManager.No = "Noo";
            MessageBoxManager.Cancel = "Cancelarr";
            MessageBoxManager.Retry = "Refazerr";
            MessageBoxManager.Ignore = "Ignorarr";
            MessageBoxManager.OK = "Okk";
            MessageBoxManager.Register();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLoginSistema());
        }
    }
}
