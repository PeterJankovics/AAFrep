// See https://aka.ms/new-console-template for more information
using System.Security.Claims;

Console.Write("kerek 3 jegyu szamot: ");
int szam = Convert.ToInt32(Console.ReadLine());

while (szam < 100 || szam > 1000)
{
    Console.Write("kerek 3 jegyu szamot: ");
    szam = Convert.ToInt32(Console.ReadLine());
}


for (int i = 1; i < szam; i++)
{
    if (szam % i == 0)
    {
        Console.WriteLine(i);
    }
}

int szam1 = 0;
int szam2 = 0;
while (szam1 < 100 || szam1 > 1000)
while (szam2 < 100 || szam2 > 1000)
    {
    Console.Write("kerek 3 jegyu szamot: ");
    szam1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("kerek 3 jegyu szamot: ");
    szam2 = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1; i < szam1; i++)
        {
            if (szam1 % i == 0 && szam2 % i == 0)
            {
                Console.WriteLine(i);
            }
        }

    }
/*
for (int i = -100000; i < -10000; i++)
{
    if (i % 620 == 0)
    {
        Console.Write(i + " ");
    }
}
for (int i = 10000; i < 100000; i++)
{
    if (i % 620 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();



for (int i = 100000; i > 10000; i--)
{
    if (i % 620 == 0)
    {
        Console.Write(i + " ");
    }
}
for (int i = -10000; i > -100000; i--)
{
    if (i % 620 == 0)
    {
        Console.Write(i + " ");
    }
}
*/


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

int szam4 = 0;
Console.Write("kerek egy szamot: ");
szam4= Convert.ToInt32(Console.ReadLine());
int p = 0;
for (int i = 100000; i > 10000; i--)
{
    if (i % szam4 == 0)
    {
        Console.Write(i + "\t ");
        p+= 1;
        if (p % 10 == 0)
        {
            Console.WriteLine();
        }
    }
}
/*for (int i = -10000; i > -100000; i--)
{
    if (i % szam4 == 0)
    {
        Console.Write(i + " ");
        i += 1;
        if (i % 10 == 0)
        {
            Console.WriteLine();
        }

    }
}
*/
