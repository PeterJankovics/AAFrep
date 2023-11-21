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

StreamWriter ir = new StreamWriter("bevetel.txt");
for (int i = 0;i < sorszamok.Count;i++)
{
    ir.WriteLine("{0}:{1}", sorszamok[i], 
        fizetendo(erkezesnapja[i], tavozasnapja[i], vendegszam[i], etkezes[i]));
}

ir.Close();