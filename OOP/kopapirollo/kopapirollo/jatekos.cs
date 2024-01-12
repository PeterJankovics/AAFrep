using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kopapirollo
{
    internal class jatekos
    {
        string[] lehetosegek = new string[] {"ko","papir","ollo"};
        public string valasztas;
        public jatekos()
        {
            Random rand = new Random();
            valasztas = lehetosegek[rand.Next(lehetosegek.Length)];
        }
        public void kinyer(jatekos masik)
        {
            if (valasztas == masik.valasztas)
            {
                Console.WriteLine("döntetlen");
            }
            else
            {

            }
        }
    }
}
