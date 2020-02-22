using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace DDona.NewTech.WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            try
            {
                Configure();
                var frmLogin = new frmLogin();
                if (frmLogin.ShowDialog().GetValueOrDefault())
                {
                    new MainWindow().ShowDialog();
                    Shutdown();
                }
            }
            finally
            {
                Shutdown();
            }
        }

        private void Configure()
        {
            CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("pt-BR");
            CultureInfo.DefaultThreadCurrentUICulture = new System.Globalization.CultureInfo("pt-BR");
        }
    }
}
