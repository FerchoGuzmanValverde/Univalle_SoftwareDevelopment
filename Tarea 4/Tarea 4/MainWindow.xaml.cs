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

namespace Tarea_4
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
            int n = 0;
            int num = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un numero"));
            while(num != 0)
            {
                if(num < 0)
                {
                    MessageBox.Show("El numero es negativo, ingrese numeros positivos", "Lo siento, algo fue mal");
                }
                else
                {
                    if(n<num)
                    {
                        n = num;
                    }
                }
                num = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un numero"));
            }
            lblnuevo.Content = n;
        }
    }
}
