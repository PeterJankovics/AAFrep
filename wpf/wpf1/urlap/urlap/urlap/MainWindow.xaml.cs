﻿using System;
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

namespace urlap
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nev = textbox.Text;
            string szhely = textbox1.Text;
            string kor = textbox2.Text;

            if (nev == "" || szhely == "" || kor == "")
            {
                MessageBox.Show("toltsd ki mind!");
            }
            else
            {
                if (uzenet == "add vissza az ezresemet.")
                {
                    listbox.Items[listbox.SelectedIndex] = nev + ", " + szhely + ", " + kor;
                    uzenet = "";
                }
                else
                {
                    listbox.Items.Add(nev + ", " + szhely + ", " + kor);
                }

                textbox.Text = "";
                textbox1.Text = "";
                textbox2.Text = "";
            }

            
        }
        string uzenet = "";

        private void listbox_MouseUp(object sender, MouseButtonEventArgs e)
        {
            string szoveg = ((ListBox)sender).SelectedItem.ToString();
            //MessageBox.Show(szoveg);
            string[] vag = szoveg.Split(", ");
            textbox.Text = vag[0];
            textbox1.Text=vag[1];
            textbox2.Text=vag[2];

            uzenet = "add vissza az ezresemet.";
        }
    }
}
