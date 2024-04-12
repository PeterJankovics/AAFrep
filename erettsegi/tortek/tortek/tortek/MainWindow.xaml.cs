using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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

namespace tortek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /*Függvény lnko(a, b : egész számok) : egész szám
    ha a = b akkor lnko := a
    ha a<b akkor lnko := lnko(a, b-a)
    ha a>b akkor lnko := lnko(a-b, b)*/
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int lnko(int a, int b)
        {
            if (a == b) {return a;}
            else if (a < b) {return lnko(a, b-a);}
            else if (a > b) {return lnko(a-b, b);}
            return 1;

        }
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int szamlalo = 0;
            try 
            {
                szamlalo = Convert.ToInt32(textBox.Text);
            }
            catch 
            {
                
            }
            textBlock2.Text = "" + szamlalo;
            int nevezo = 0;
            try
            {
                nevezo = Convert.ToInt32(textBox1.Text);
            }
            catch
            {

            }
            if (nevezo != 0 && szamlalo % nevezo == 0)
            {
                textBlock2.Text = (szamlalo / nevezo).ToString();
            }
            else if (nevezo != 0 && szamlalo % nevezo != 0)
            {
                textBlock2.Text = "Nem egész";
            }
            else 
            {
                textBlock2.Text = "Nullával való osztás";
            }

            textBlock.Text = szamlalo.ToString();
            textBlock1.Text = nevezo.ToString();

            if (nevezo != 0 && szamlalo != 0)
            {
                int oszto = lnko(nevezo, szamlalo);
                textBlock_Copy.Text = (szamlalo / oszto).ToString();
                textBlock1_Copy.Text = (nevezo / oszto).ToString();

                tab4.IsEnabled = true;
            }
            else
            {
                tab4.IsEnabled = false;
            }


        }

        private void textBox_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            int szamlalo = 0;
            try
            {
                szamlalo = Convert.ToInt32(textBox_Copy.Text);
            }
            catch
            {
            }
            int nevezo = 0;
            try
            {
                nevezo = Convert.ToInt32(textBox1_Copy.Text);
            }
            catch
            {
            }
            textBlock_Copy1.Text = szamlalo.ToString();
            textBlock1_Copy1.Text = nevezo.ToString();
        }
    }
}
