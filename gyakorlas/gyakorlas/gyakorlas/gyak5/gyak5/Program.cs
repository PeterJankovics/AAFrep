
string[] hosszusag = { "mm", "cm", "dm", "m", "km" }; 

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
    if (hosszusag.Contains(darab[1]))
    {
    }
    else
    {
        Console.WriteLine("nem jo mertekegyseg!");
        jo = false;
        continue;
    }
}
Console.WriteLine("Mire szeretned atvaltani? ");
for (int i = 0; i < hosszusag.Length; i++)
{
    Console.WriteLine(hosszusag[i]);
}
Console.Write("válasz: ");
string valasz =  Console.ReadLine();