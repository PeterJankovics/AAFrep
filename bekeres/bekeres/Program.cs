using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bekeres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kerek egy szoveget: ");
            string szoveg = Console.ReadLine();
            Console.WriteLine("A bekért szoveg: " + szoveg);

            szoveg = " ";
            while (szoveg != "")
            {
                Console.Write("Kék egy szavat!: ");
                szoveg = Console.ReadLine();
            }

            //Console.Write("Kerek egy egesz szamot!: ");
            //double szam = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("a szam negyzete " + (szam * szam + 1))

            Console.Write("Kerek egy egesz szamot!!: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            int szamol = 0; 
            for (int e = 0; e < szam2; e++)
            {
                szamol++;
                Console.Write(szamol + " Kerek egy szoveget: ");
                string szoveg2 = Console.ReadLine();
                Console.WriteLine(szoveg2);
            }
            Console.Write("Kerek egy szamot!!!: ");
            int szam3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kerek meg egy szamot!!!: ");
            int szam4 = Convert.ToInt32(Console.ReadLine());

            for (int e = 0; e < szam3; e++)
            {

            }



        }
    }
}
