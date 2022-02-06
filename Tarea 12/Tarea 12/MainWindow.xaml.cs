using System;
using System.Collections.Generic;
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

namespace Tarea_12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            txtmostrar.Clear();
            int con = 0;
            int num = int.Parse(txtnumero.Text);
            if(num >= 1)
            {
                while (num != 1)
                {
                    txtmostrar.AppendText("El valor es: " + num + "\n");
                    if (num % 2 == 0)
                    {
                        num = num / 2;
                    }
                    else
                    {
                        num = (num * 3) + 1;
                    }
                    con++;
                }
                lblrespuesta.Content = "El numero de operaciones fueron: " + con;
            }
            else
            {
                MessageBox.Show("El numero no es valido", "Error");
            }
            txtnumero.Clear();
        }
    }
}
