static int fizetendo(int erkezes, int tavozas, int szemely, bool etkezes)
{
    int szobaar = 0;
    if (erkezes < 121) szobaar = 9000;
    else if (erkezes < 244) szobaar = 10000;
    else szobaar = 8000;

    int ejdb = tavozas - erkezes;
    if (szemely < 2)
    {
        szobaar += 2;
    }
    if (etkezes)
    {
        szobaar += szemely * 1100;
    }
    return szobaar * ejdb;
}
static int melyikhonap(int napdb, List<int> holkezdodik)
{
    for (int i = 0; i< holkezdodik.Count;i++) 
    {
        if (napdb < holkezdodik[i])
        {
            return i + 1;
        }

    }
    return 12;
}

StreamReader olvas = new StreamReader("pitypang.txt");
olvas.ReadLine();
List<int> sorszamok = new List<int>();
List<int> szobaszamok = new List<int>();
List<int> erkezesnapja = new List<int>();
List<int> tavozasnapja = new List<int>();
List<int> vendegszam = new List<int>();
List<bool> etkezes = new List<bool>();
List<string> vendeg = new List<string>();

while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    //"1 5 3 13 1 1 Huszar_Hajnalka"
    string[] vag = sor.Split(" ");
    sorszamok.Add(Convert.ToInt32(vag[0]));
    szobaszamok.Add(Convert.ToInt32(vag[1]));
    erkezesnapja.Add(Convert.ToInt32(vag[2]));
    tavozasnapja.Add(Convert.ToInt32(vag[3]));
    vendegszam.Add(Convert.ToInt32(vag[4]));
    etkezes.Add(vag[5] == "1");
    vendeg.Add(vag[6]);
}
//Console.WriteLine(szobaszamok.Count);

olvas.Close();

// 2. feladat: 
int maxEj = 0;
int maxId = 0;
for (int i = 0; i < sorszamok.Count; i++)
{
    int hossz = tavozasnapja[i] - erkezesnapja[i];
    if (hossz > maxEj)
    {
        maxEj = hossz;
        maxId = i;
    }
}
Console.WriteLine("2. feladat: ");
Console.WriteLine("{0} ({1}) - {2}", vendeg[maxId], erkezesnapja[maxId], maxEj);

int osszeg = 0;
StreamWriter ir = new StreamWriter("bevetel.txt");

for (int i = 0;i < sorszamok.Count;i++)
{
    int fiz = fizetendo(erkezesnapja[i], tavozasnapja[i], vendegszam[i], etkezes[i]);
    ir.WriteLine("{0}:{1}", sorszamok[i], fiz);
    osszeg += fiz;
}

ir.Close();
Console.WriteLine("3. feladat: Az éves bevétel {0:n0} Ft.", osszeg);

olvas = new StreamReader("honapok.txt");
List<string> honapok = new List<string>();
List<int> napszam = new List<int>();
List<int> holKezdoik = new List<int>();
int mutato = 0;
while (olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    if (mutato == 0)
    {
        honapok.Add(sor);
    }
    else if (mutato == 1)
    {
        napszam.Add(Convert.ToInt32(sor));
    }
    else
    {
        holKezdoik.Add(Convert.ToInt32(sor));
        mutato = -1;
    }
    mutato++;
}

olvas.Close();
Dictionary <int, int> vendegejszakak = new Dictionary<int, int>();
for (int i = 0; i < sorszamok.Count; i++)
{
    Console.WriteLine(erkezesnapja[i] + " - " + tavozasnapja[i]);
}
Console.WriteLine(melyikhonap(1,holKezdoik));
