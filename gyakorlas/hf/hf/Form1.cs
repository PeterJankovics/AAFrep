using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("kerek egy szoveget");
            string szoveg = Console.ReadLine();
            string[] szavak = szoveg.Split(' ');
            for (int i = 0; i < szavak.Length; i++)
            {
                if (szavak[i] != "")
                {
                    szavak[i] = char.ToUpper(szavak[i][0]) + szavak[i].Substring(1);
                }
            }

        }
    }
}
