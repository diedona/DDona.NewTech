using DDona.NewTech.WpfApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DDona.NewTech.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PessoaViewModel Pessoa;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Pessoa = new PessoaViewModel();
            grdForm.DataContext = Pessoa;
            txtNomeCompleto.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Pessoa.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Pessoa = new PessoaViewModel();
        }
    }

    public class DateTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null)
            {
                return null;
            }

            if (DateTime.TryParse(value.ToString(), out DateTime converted))
            {
                return converted.ToShortDateString();
            }
            else
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }

            if(DateTime.TryParse(value.ToString(), out DateTime converted))
            {
                return converted;
            }
            else
            {
                return null;
            }
        }
    }
}
