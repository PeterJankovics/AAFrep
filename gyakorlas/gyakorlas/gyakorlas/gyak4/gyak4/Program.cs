// See https://aka.ms/new-console-template for more information
Console.WriteLine("kerek egy szamot: ");
int szam = Convert.ToInt32(Console.ReadLine());

while (szam % 5 != 0)
{
    Console.WriteLine("kerek egy szamot: ");
    szam = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(szam + " oszthato 5 tel");
    
}
if (szam % 10 == 0)
{
    Console.WriteLine(szam + " oszthato 10-zel");
}