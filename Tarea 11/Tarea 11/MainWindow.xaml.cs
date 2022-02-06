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

namespace Tarea_11
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
            byte con = 1;
            float a = 0, c = 50, aux = 0, p;
            while(con <= 10)
            {
                p = c * 0.024f;
                c = c - p;
                txtmostrar.AppendText("year " + con + ": " + c+"\n");
                
                con++;
            }
            c = 50;
            while(c>25)
            {
                p = c * 0.024f;
                c = c - p;
                a++;
            }
            txtmostrar.AppendText("La vida media del estrocio 90 es entre: " + a + " y " + (a+1));
        }
    }
}
