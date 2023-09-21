// See https://aka.ms/new-console-template for more information
using System;

Console.Write("Kerek egy szamot: ");
double szam = Convert.ToDouble(Console.ReadLine());

while (szam % 1.2 > 0.001)
{
    Console.Write("Kerek egy szamot: ");
    szam = Convert.ToDouble(Console.ReadLine());
}

for (double i = 1; i < szam; i++)
{
    if (szam % i == 0)
    {
        szam = Convert.ToInt32(szam);
        Console.Write(i + "; ");
    }
}

for (double i = -10; i <= 10; i += 0.1)
{
    Console.Write((i * *2 + i * *3) / 9(-5 *-i**2));
}