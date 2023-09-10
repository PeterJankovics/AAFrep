using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            int szam = 6; Console.WriteLine(szam);
            int mszam = -6; Console.WriteLine(mszam);
            double tszam = 12.5; Console.WriteLine(tszam);
            char betu = 'v'; Console.WriteLine(betu);
            Console.WriteLine((char)(betu + 2));
            string szo = "asd"; Console.WriteLine(szo);
            Console.WriteLine(3 / 1.12);
            int i = 0;
            Console.WriteLine(++i);

            double szam2 = 1;
            while (szam2 < 5)
            {
                Console.WriteLine(szam2);
                szam2 += .1;
            }
            do
            {
                szam2 -= .2;
                Console.WriteLine(szam2);
            }
            while (szam2 > 1);
            char botu = 'a';
            while (botu <= 'z') 
            {

                Console.Write(botu);
                botu = (char)(botu + 1);

            }
            Console.WriteLine();
            
            int szam3 = 32; 
            while (szam3 < 256)
            {
                Console.Write((char)(szam3) + "  ");
                szam3 += 1;
                if (szam3 % 8 == 0)
                {
                    Console.WriteLine();
                }
            }
            for (int e = 0; e < 10; e++)
            {
                //Console.Write(e + " ");       
            }
            //Console.WriteLine();

            int szamlalo = 0;
            for (int e = 100; e < 1000; e++)
            {
                szamlalo += e;
                
            }
            Console.WriteLine(szamlalo);
            for (int x = 9; x > 0; x--)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            for (int z = 0; z < 10; z++)
            {
                Console.WriteLine(9 - z);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int e = 10; e < 100; e++)
            {
                if (e % 5 == 0)
                {
                    Console.WriteLine(e);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            int szam5 = 10;
            while (szam5 <= 99)
            {
                if (szam5 % 5 == 0)
                {
                    Console.WriteLine(szam5);
                }
                szam5++;

            }




        }
    }
}
