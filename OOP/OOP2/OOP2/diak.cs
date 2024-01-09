using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class diak : udvariasember
    {
        private int kor;
        public diak(string vnev, string knev, int kor) : base(vnev, knev)
        {
            this.kor = kor;
        }
        public void iskola()
        {
            if (kor < 2)
            {
                Console.WriteLine("óóóóó ááááá eeee");
            }
            else if (kor > 3)
            {
                Console.WriteLine("Böjcsibe");
            }
            else if (kor < 7)
            {
                Console.WriteLine("Ovodás");
            }
            else if (kor < 11)
            {
                Console.WriteLine("Alsos vagyok");
            }
            else if (kor < 15)
            {
                Console.WriteLine("felsos vagyok");
            }
            else if (kor < 20)
            {
                Console.WriteLine("technikumba jarok");
            }
            else if (kor < 25)
            {
                Console.WriteLine("Egyetem");
            }
            else
            {
                Console.WriteLine("felnott vagyok.");
            }
            
        }
        public void koszon(diak diakValtozo)
        {
            Console.WriteLine("Szia {0}!", diakValtozo.keresztnev);
        }
    }
}
