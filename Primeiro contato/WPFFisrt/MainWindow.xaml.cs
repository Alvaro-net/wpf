using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFFisrt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txterro.Visibility = Visibility.Hidden;
            lblresultado.Visibility = Visibility.Hidden;
            txtresultado.Visibility = Visibility.Hidden;

            //txterro.Text = txtresultado.Text = "";
        }

        private void txtnome_MouseLeave(object sender, MouseEventArgs e)
        {
           ValidadeNome();
        }

        private void txthoras_MouseLeave(object sender, MouseEventArgs e)
        {
            ValidateHoras();
        }
        private void txthoras_GotFocus(object sender, RoutedEventArgs e)
        {
            ValidateHoras();
        }

        private void txtVHT_MouseLeave(object sender, MouseEventArgs e)
        {
            
        }
        private void txtVHT_GotFocus(object sender, RoutedEventArgs e)
        {
            ValidateVHT();
        }

        private void btnexecutar_Click(object sender, RoutedEventArgs e)
        {
            txtresultado.Text = (Int32.Parse(txtVHT.Text) * Int32.Parse(txthoras.Text)).ToString();
            lblresultado.Visibility = Visibility.Visible;
            txtresultado.Visibility = Visibility.Visible;
        }

        private void ValidadeNome()
        {
            if (String.IsNullOrEmpty(txtnome.Text))
            {
                txterro.Text = "Nome não informado.";
                txterro.Visibility = Visibility.Visible;
                txtnome.Focus();

            }
            else
            {
                txterro.Text = "";
                txterro.Visibility = Visibility.Hidden;
            }
        }
        private void ValidateHoras()
        {
            if (String.IsNullOrEmpty(txtnome.Text))
            {
                ValidadeNome();

            }
            else if (String.IsNullOrEmpty(txthoras.Text))
            {
                txterro.Text = "horas trabalhadas não informada.";
                txterro.Visibility = Visibility.Visible;
                txthoras.Focus();
            }
            else
            {
                txterro.Text = "";
                txterro.Visibility = Visibility.Hidden;
            }
        }

        private void ValidateVHT()
        {
            if (String.IsNullOrEmpty(txtnome.Text))
            {
                ValidadeNome();

            }
            else if (String.IsNullOrEmpty(txthoras.Text))
            {
                ValidateHoras();

            }
            else if (String.IsNullOrEmpty(txtVHT.Text))
            {
                txterro.Text = "Valor das horas trabalhadas não informada.";
                txterro.Visibility = Visibility.Visible;
                txtVHT.Focus();
            }
            else
            {
                txterro.Text = "";
                txterro.Visibility = Visibility.Hidden;
            }
        }
    }
}
