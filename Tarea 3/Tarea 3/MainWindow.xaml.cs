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

namespace Tarea_3
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
            int con = 0;
            int num = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero"));
            while (num != 0)
            {
                if(num >= 0)
                {
                    con++;
                }
                num = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero"));
            }
            MessageBox.Show("Los positivos son: " + con);
        }
    }
}
