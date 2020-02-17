using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
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
    }
}
