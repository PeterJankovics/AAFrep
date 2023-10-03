// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
bool jo = false;
double szam = 0;
while (!jo)
{
    jo = true;
    Console.Write("Mit váltsak át? (pl.: 12 kg): ");
    string be = Console.ReadLine();
    string[] darab = be.Split(' ');
    if (darab.Length != 2)
    {
        jo = false;
        continue;
    }
    try
    {
        szam = Convert.ToDouble(darab[0]);
    }
    catch (Exception)
    {
        Console.Write("Nem jo formátum. legyen ilyen: 12,4 kg");
        jo = false;
        continue;
    }
    Console.WriteLine(szam);
}