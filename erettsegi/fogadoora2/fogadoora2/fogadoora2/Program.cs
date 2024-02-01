using fogadoora2;

List<adatok> foglalasok = new List<adatok>();

StreamReader olvas = new StreamReader("fogado.txt");

while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    foglalasok.Add(new adatok(sor));

}
olvas.Close();

Console.WriteLine("2. Feladat: Foglalasok szama: {0}",foglalasok.Count);

Console.WriteLine("3. Feladat:");
Console.Write("Adjon meg egy nevet: ");
string tanar = Console.ReadLine();
int idopont = 0;
for (int i = 0; i < foglalasok.Count; i++)
{
    if (foglalasok[i].nev == tanar)
    {
        idopont++;
    }
}
if (idopont != 0)
{
    Console.WriteLine("{0} neven {1} foglalas van.", tanar, idopont);
}
else
{
    Console.WriteLine("Ezen a neven nincs meg foglalas.");
}

Console.WriteLine("4. Feladat: ");
Console.Write("Adjon meg egy érvényes időpontot (pl. 17:10): ");
string ido = Console.ReadLine();

List<string> tanarnevek = new List<string>();

for (int i = 0; i != foglalasok.Count; i++)
{
    if (foglalasok[i].idopont == ido)
    {
        tanarnevek.Add(foglalasok[i].nev);

    }
}

tanarnevek.Sort();

for (int i = 0; i < tanarnevek.Count; i++)
{
    //Console.WriteLine(tanarnevek[i]);
    File.WriteAllLines( ido.Replace(":","")+".txt", tanarnevek);
}


adatok min = foglalasok[0];

for (int i = 1; i < foglalasok.Count; i++)
{
    if (foglalasok[i].foglalas > min.foglalas)
    {
        min = foglalasok[i];
    }
}
Console.WriteLine(min);


List<string> idopontjai = new List<string>();
for (int i = 0; i < foglalasok.Count; i++)
{
    if (foglalasok[i].nev == "Barna Eszter")
    {
        idopontjai.Add(foglalasok[i].idopont);
    }
}

/*for (int i = 0; i < idopontjai.Count; i++)
{
    Console.WriteLine(idopontjai[i]);
}*/

List<string> osszidopont = new List<string>() { "16:10", "16:20", "16:30", "16:40", "16:50", "17:00", "17:10", "17:20", "17:30", "17:40", "17:50" };
for (int i = 0; i <= foglalasok.Count; i++)
{
    if ()
}