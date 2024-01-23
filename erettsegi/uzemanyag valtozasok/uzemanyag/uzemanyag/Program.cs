using Microsoft.Win32.SafeHandles;
using uzemanyag;

List<adatok> valtozasok = new List<adatok>();

StreamReader olvas = new StreamReader("uzemanyag.txt");

while (!olvas.EndOfStream)
{
    valtozasok.Add(new adatok(olvas.ReadLine()));
}

olvas.Close();

Console.WriteLine("3. Feladat: Valtozasok szama: {0}", valtozasok.Count());

Console.WriteLine("4. Feladat:");
adatok minimum = valtozasok[0]; 
int mindarab = 0;


for (int i = 0; i < valtozasok.Count; i++)
{
    if (valtozasok[i].kulonbseg() < minimum.kulonbseg())
    {
        minimum = valtozasok[i];
    }
}

for (int i = 0; i < valtozasok.Count; i++)
{
    if (valtozasok[i].kulonbseg() == minimum.kulonbseg())
    {
        mindarab++;
    }
}

Console.WriteLine("A legkisebb kulonbseg: {0}", minimum.kulonbseg());

Console.WriteLine("5. Feladat: a legkisebb kulonbseg eloforsulasa: {0}", mindarab);

bool volt = false;

for (int i = 0; i < valtozasok.Count; i++)
{
    if (DateTime.IsLeapYear(valtozasok[i].datum.Year))
    {
        if (valtozasok[i].datum.Month == 2 && valtozasok[i].datum.Day == 24)
        {
            volt = true;
            break;
        }
    }
}

if (volt)
{
    Console.WriteLine("6. Feladat: volt valtozas szokonapon.");
}
else
{
    Console.WriteLine("6. Feladat: nem volt valtozas szokonapon.");
}


for (int i = 0; i < valtozasok.Count; i++)
{
    Console.WriteLine(valtozasok[i].fileba());
}