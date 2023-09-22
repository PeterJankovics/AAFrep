// See https://aka.ms/new-console-template for more information


//harom szam bekeres ird ki a legnagyobbat.
//bekers egy szam es egy betu ,betu annyiszor kiiratas ahanyszor ahany a szam
//ket szam negyzetenek osszegeinek osszeget 
//ket szam kozti szam negyzeteinek osszege
//hogyan kell negyzetgyokot vonni

Console.Write("kerek egy szamot: ");
int szma1 = Convert.ToInt32(Console.ReadLine());

Console.Write("kerek egy szamot: ");
int szma2 = Convert.ToInt32(Console.ReadLine());

Console.Write("kerek egy szamot: ");
int szma3= Convert.ToInt32(Console.ReadLine());

int x = szma1, y = szma2, z = szma3;
Console.WriteLine(Math.Max(Math.Max(x, y), z));



Console.Write("kerek egy szamot: ");
int szam4 = Convert.ToInt32(Console.ReadLine());

Console.Write("kerek egy betut: ");
char betu = Convert.ToChar(Console.ReadLine());

for (int i = 0; i < szam4; i++)
{
    Console.Write(betu + "; ");
}
Console.WriteLine();


Console.Write("kerek egy szamot: ");
int szam5 = Convert.ToInt32(Console.ReadLine());
Console.Write("kerek egy szamot: ");
int szam6 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((szam5 * szam5) + (szam6 * szam6));


Console.Write("kerek egy szamot: ");
int szam7 = Convert.ToInt32(Console.ReadLine());

Console.Write("kerek egy szamot: ");
int szam8 = Convert.ToInt32(Console.ReadLine());
if (szam7 < szam8)
{
    for (int i = szam7; i < szam8; i++)
    {
        Console.Write(i * i + "; ");
    }
}
else
{
    for (int i = szam8; i < szam7; i++)
    {
        Console.Write(i * i + "; ");
    }
}

Console.WriteLine();

for (double i = -10; i <= 10; i += 0.1)
{
    Console.Write((i*i + i*i*i) / 9-(5 * i * i)-6*(9-i)*2+12+6*(1/((i*i-1)*2)-12*i));
}