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

namespace gyak2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool betoltott = false;
        public MainWindow()
        {
            InitializeComponent();
            this.betoltott = true;
        }
        double[] ertekek = new double[4] {1, 1, 1, 1};
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (betoltott) { 
            ertekek[0] = csuszka1.Value;

            kep1.Opacity = (1-ertekek[0]) * ertekek[3];
            kep2.Opacity = ertekek[0] * (1-ertekek[1]);
            }

        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ertekek[1] = csuszka2.Value;

            kep3.Opacity = ertekek[0] * ertekek[1];
            kep4.Opacity = (1 - ertekek[3]) * ertekek[2];
        }

        private void Slider_ValueChanged_2(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ertekek[2] = csuszka3.Value;

            kep3.Opacity = ertekek[1] * (1-ertekek[2]);
            kep2.Opacity = ertekek[3] * (1-ertekek[0]);
        }

        private void Slider_ValueChanged_3(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ertekek[3] = csuszka4.Value;

            kep3.Opacity = ertekek[0] * ertekek[1];
            kep4.Opacity = (1 - ertekek[3]) * ertekek[2];
        }
    }
}
