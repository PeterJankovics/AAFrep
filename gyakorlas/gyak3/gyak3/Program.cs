﻿// See https://aka.ms/new-console-template for more information
//1.
/*Console.Write("kerek egy szamot: ");
int szam = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(szam);*/

//2.
/*Console.Write("kerek egy szamot: ");
int szam2 = Convert.ToInt32(Console.ReadLine());
Console.Write("kerek egy szamot: ");
int szam3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(szam2 - szam3);*/

//3.
/*Console.Write("kerek egy szamot: ");
double szam4 = Convert.ToDouble(Console.ReadLine());
Console.Write("kerek egy szamot: ");
double szam5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(szam4 * szam5);*/

//4.
/*Console.Write("kerek egy szamot: ");
int szam6 = Convert.ToInt32(Console.ReadLine());
Console.Write("kerek egy szamot: ");
int szam7 = Convert.ToInt32(Console.ReadLine());
int x = szam6, y = szam7;
Console.WriteLine(Math.Max(x, y));*/

//5.
/*Console.Write("kerek egy szamot: ");
double szam8 = Convert.ToDouble(Console.ReadLine());
Console.Write("kerek egy szamot: ");
double szam9 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(szam8 + "/" + szam9 + " = " + (szam8 / szam9));*/

//6.
/*Console.Write("kerek egy szamot: ");
int szam10 = Convert.ToInt32(Console.ReadLine());
Console.Write("kerek egy szamot: ");
int szam11 = Convert.ToInt32(Console.ReadLine());
for (int i = szam10; i < szam11; i++)
{
    Console.WriteLine(i);
}*/

//7
/*Console.Write("kerek egy szamot: ");
int szam12 = Convert.ToInt32(Console.ReadLine());
Console.Write("kerek egy szamot: ");
int szam13 = Convert.ToInt32(Console.ReadLine());
for (int i = szam12; i <= szam13; i++)
{
    Console.WriteLine(i);
}*/

//8
/*Console.Write("kerek egy szamot: ");
int szam14 = Convert.ToInt32(Console.ReadLine());
Console.Write("kerek egy szamot: ");
int szam15 = Convert.ToInt32(Console.ReadLine());
for (int i = szam14; i <= szam15; i++)
{
    Console.WriteLine(i * i);
}*/

//9
/*Console.Write("kerek egy szamot: ");
int szam16 = Convert.ToInt32(Console.ReadLine());
Console.Write("kerek egy szamot: ");
int szam17 = Convert.ToInt32(Console.ReadLine());
Console.Write("kerek egy szamot: ");
int szam18 = Convert.ToInt32(Console.ReadLine());

int x = szam16, y = szam17, z = szam18;
Console.WriteLine(Math.Max(Math.Max(x, y), z));*/

//10
/*Console.Write("kerek egy szamot: ");
int szam19 = Convert.ToInt32(Console.ReadLine());
Console.Write("kerek egy szamot: ");
int szam20 = Convert.ToInt32(Console.ReadLine());

for (int i = szam19; i <= szam20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}*/

//11
/*Console.Write("kerek egy szamot: ");
int szam19 = Convert.ToInt32(Console.ReadLine());
Console.Write("kerek egy szamot: ");
int szam20 = Convert.ToInt32(Console.ReadLine());*/


/*Console.WriteLine("szoveg {0%} szoveg {1}",12,3.4);

int a = 10;
double b = 2.3;
Console.WriteLine($"szoveg {a/2} szoveg {b}");


Console.Write("Kérek egy befogót(a):");
int szam1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Kérek még egy befogót(b):");
int szam2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ez az átfogó(c):" + szam1 * szam2);*/

int a = 3;
int b = 4;
double c = Math.Sqrt(a*a+b+b);
//Console.WriteLine(c);
Console.WriteLine("{0,5} {1,5} {2,5}", "a","b","c");
for (int i = 1; i < 50; i++)
{
    for (int k = i; k < 50; k++)
    {
        c = Math.Sqrt(i*i+k*k);
        if(c % 1 == 0)
        {
            Console.WriteLine("{0,5} {1,5} {2,5}", i,k,c);
        }
    }
}
//elso 10 szam negyzetgyoke ke tizedes jegyig

for (int i = 0; i < 11; i++)
{
    Console.WriteLine("{0:0.00}",Math.Sqrt(i));
}