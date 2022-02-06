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

namespace Tarea_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random num = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnempezar_Click(object sender, RoutedEventArgs e)
        {
            int n = num.Next(1, 20);
            int intent = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingresa tu numero"));
            while(intent != n)
            {
                MessageBox.Show("Es Incorrecto, sigue intentando");
                intent = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingresa tu numero"));
            }
            MessageBox.Show("Acertaste");
        }
    }
}
