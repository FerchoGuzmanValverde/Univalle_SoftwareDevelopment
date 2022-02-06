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

namespace Tarea_7
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

        private void btnempezar_Click(object sender, RoutedEventArgs e)
        {
            int a = 0, s = 0, con = 0, pro;
            int num = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero"));
            int b = num;
            while (num != -1)
            {
                s = s + num;
                if (num > a)
                {
                    a = num;
                }
                if (num < b)
                {
                    b = num;
                }
                con++;
                num = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero"));
            }
            pro = s / con;
            MessageBox.Show("El maximo valor es: " + a + "\nEl minimo valor es: " + b + "\nEl promedio es: " + pro + "\nEl total de valores es: " + con, "Los detalles Licen");
        }
    }
}
