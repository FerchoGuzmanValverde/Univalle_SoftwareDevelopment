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

namespace Tarea_8
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

        private void btniniciar_Click(object sender, RoutedEventArgs e)
        {
            int aux = 0, last = 0;
            
            while (aux < 21)
            {
                int num = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero entre 1 y 5"));
                last = num;
                if (num > 0 && num < 6)
                {
                    aux = aux + num;
                }
                else
                    MessageBox.Show("El numero es invalido");
            }
            MessageBox.Show("La suma de los numeros es mas de 21");
            lblsuma.Content = aux; lblultimo.Content = last;
        }
    }
}
