using fogadoora;

List<adatok> foglalasok = new List<adatok>();

StreamReader olvas = new StreamReader("fogado.txt");

while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    foglalasok.Add(new adatok(sor));
}
olvas.Close();
Console.WriteLine("2. Feladat: " +
    "Foglalasdok szama: {0}", foglalasok.Count);

Console.WriteLine("3.Feladat:");
Console.Write("Adjon meg egy nevet: ");

string nev = Console.ReadLine();
int idopontszam = 0;
for (int i = 0; i < foglalasok.Count; i++)
{
    if (foglalasok[i].nev == nev)
    {
        idopontszam++;
    }
}

if (idopontszam == 0)
{
    Console.WriteLine("A megadott néven nincs időpontfoglalás.");
}
Console.WriteLine("{0} néven {1} időpontfoglalás van.", nev, idopontszam);

Console.WriteLine("4. Feladat: ");
Console.Write("Adjon meg egy ervenyes idopontot (pl. 17:10): ");
List<string> nevek = new List<string>();  
string idopont = Console.ReadLine();

for (int i = 0; i < foglalasok.Count; i++)
{
    if (foglalasok[i].idopont == idopont)
    {
        nevek.Add(foglalasok[i].nev);

    }
}

nevek.Sort();
for (int i = 0; i < nevek.Count; i++)
{ 
    Console.WriteLine(nevek[i]);
    File.WriteAllLines(idopont.Replace(":", "") + ".txt", nevek);
}

adatok min = foglalasok[0];
for (int i = 0; i < foglalasok.Count; i++)
{
    if (foglalasok[i].foglalas < min.foglalas)
    {
        min = foglalasok[i];
    }
}
Console.WriteLine("----");
Console.WriteLine(min);