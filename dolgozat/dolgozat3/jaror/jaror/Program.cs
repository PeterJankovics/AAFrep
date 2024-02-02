using jaror;
using System.Globalization;
using System.Runtime.Serialization.Formatters;

List<adatok> jarmuvek = new List<adatok> ();

StreamReader olvas= new StreamReader("jarmu.txt");

while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    jarmuvek.Add(new adatok(sor));
}
olvas.Close();


int utolso = 0;
for (int i = 0; i < jarmuvek.Count; i++)
{
    utolso = jarmuvek[i].ora;
}
int orat = (utolso - jarmuvek[0].ora);

Console.WriteLine("2. Feladat: {0} órát dolgoztak", orat);
//Console.WriteLine(jarmuvek[-1].ora - jarmuvek[0].ora);

int oraszamol = jarmuvek[0].ora;
List<string> teszt= new List<string> ();
for (int i = 0; i < jarmuvek.Count; i++)
{
    if (jarmuvek[i].ora == oraszamol)
    {
        teszt.Add(oraszamol + "óra: " + jarmuvek[i].rendszam);
        oraszamol++;
    }
}
Console.WriteLine("3. Feladat: ");

for (int i = 0; i < teszt.Count; i++)
{
    Console.WriteLine(teszt[i]);
}

int b = 0;
int k = 0;
int m = 0;
int tobbi = 0;

for (int i = 0; i < jarmuvek.Count; i++)
{
    if (jarmuvek[i].rendszam.Substring(0, 1) == "B")
    {
        b++;
    }
    else if (jarmuvek[i].rendszam.Substring(0, 1) == "K")
    {
        k++;
    }
    else if (jarmuvek[i].rendszam.Substring(0, 1) == "M")
    {
        m++;
    }
    else
    {
        tobbi++;
    }
}

Console.WriteLine("4. Feladat:\nautóbuszból: {0}\nkamionból: {1}\nmotorból: {2}\nszemélygépkocsi: {3}",b,k,m,tobbi);
List<int> szamolas = new List<int>();

for (int i = 0; i < jarmuvek.Count; i++)
{
    int szamol = jarmuvek[i].ora * 3600 + jarmuvek[i].perc * 60 + jarmuvek[i].masodperc;
    szamolas.Add(szamol);
    
}

int elso = szamolas[0];

int kulonbseg = 0;

for (int i = 1; i < szamolas.Count; i++)
{
    int kul = szamolas[i] -= szamolas[i-1];
    if (kul >= kulonbseg)
    {
        kulonbseg = kul;
    }
}
//Console.WriteLine(kulonbseg);