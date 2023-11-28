
/*static List<string> beol();
{
    List<string> adatok = new List<string>();
    StreamReader beolvas = new StreamReader("adathalmaz.csv");
    string sor = "";
    while ((sor = beolvas.ReadLine()) != null)
    {
        Console.WriteLine(sor);
    }
    //beolvas.Close();
    return adatok;
}
*/
/*StreamReader beolvas = new StreamReader("adathalmaz.csv");
List<string> adatok = new List<string>();
string sor = "";
while ((sor = beolvas.ReadLine()) != null)
{
    //Console.WriteLine(sor);
    for (int i = 0; i < adatok.Count; i++)
    {
        sor.Split(";");
        adatok.Add(sor);
        Console.WriteLine(sor);
    }

}
*/
/*
for (int i = 0; i < adatok.Count; i++)
{
    sor.Split(",");
    Console.WriteLine(sor);
}
*/

using System.Globalization;

StreamReader olvas = new StreamReader("adathalmaz.csv");
olvas.ReadLine();
List<int> perc = new List<int>();
List<float> homero1 = new List<float>();
List<string> homero2 = new List<string>();
List<string> homero3 = new List<string>();
List<string> homero4 = new List<string>();
List<int> darab = new List<int>();

while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    //Console.WriteLine(sor);
    string[] vag = sor.Split(";");
    //Console.WriteLine(vag[0]);
    perc.Add(Convert.ToInt32(vag[0]));
    //Console.WriteLine(vag[1]);
    homero1.Add(Convert.ToSingle(vag[1]));
    homero2.Add(vag[2]);
    homero3.Add(vag[3]);
    homero4.Add(vag[4]);
    darab.Add(Convert.ToInt32(vag[5]));
    
}
olvas.Close();

Console.WriteLine("2. feladat: {0} időpont adatai szerepelnek az adatok között", perc.Count);

//3 feladat:


int ora = 0;
int oraa = ora / 60;

int darabja = 0;

for (int i = 0; i < perc.Count; i++)
{
    ora += perc[i];
    darabja = darab[i];
    //Console.WriteLine(darabja);

}
//Console.WriteLine(ora / 60);

Console.WriteLine(darabja / (ora / 60));
int magas = 0;
int mikor = 0;
for (int i = 0; i < homero1.Count; i++)
{
    int szam = (Convert.ToInt32(homero1[i]));
    //Console.WriteLine(szam);
    //Console.WriteLine(szam);
    if (magas < szam)
    {
        magas = szam;
        mikor = perc[i];
        //magas == homero1[i];
    }
}
Console.WriteLine("5. feladat: {0} C fok magas volt {1} percnél a hőmérséklet", magas, mikor);
int fok = 0;
for (int i = 0; i < homero2.Count; i++)
{
    int hom = Convert.ToInt32(homero1[i]);
    
    fok += hom;
    
}
Console.WriteLine("ez volt az átlaghőmérséklet az elsonel: "+ fok / homero1.Count);
int fok1 = 0;
/*for (int i = 0; i < homero2.Count; i++)
{
    int hom1 = Convert.ToInt32(homero2[i]);

    fok1 += hom1;

}
Console.WriteLine("ez volt az átlaghőmérséklet a masodiknal: " + fok / homero1.Count);*/