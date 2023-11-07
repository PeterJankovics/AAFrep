
static string szo1(int darab)
{
    Random rand = new Random();
    string betuk = "qwertzuiopőúöüóasdfghjkléáűíyxcvbnm";

    string szo = "";
    for (int i = 0; i < darab; i++)
    {
        int index = rand.Next(betuk.Length);
        szo += betuk[index];
    }
    return szo;
}
static string szo2(int darab)
{
    Random rand = new Random();
    string betuk = "qwertzuiopőúöüóasdfghjkléáűíyxcvbnm";
    string msh = "qwrtzpsdfghjklyxcvbnm";
    string mgh = "euioa";
    string szo = "";
    int fajta = rand.Next(1);
    for (int i = 0; i < darab; i++)
    {
        if (fajta == 0)
        {
            szo += mgh[rand.Next(mgh.Length)];
        }
        else
        {
            szo += msh[rand.Next(msh.Length)];
        }
        fajta = 1 - fajta;
    }
    return szo;
}

string[] sokszo = new string[10000];
Random rand = new Random();
for (int i = 0; i < sokszo.Length; i++)
{
    sokszo[i] = szo2(rand.Next(2, 11));
}
File.WriteAllLines("szavak.txt", sokszo);
string[] szavak = File.ReadAllLines("szavak.txt");

string tobbszoros = "";
for (int i = 0; i < szavak.Length; i++)
{
    for (int k = i+1; k < szavak.Length; k++)
    {
        if (szavak[i] == szavak[k])
        {
            tobbszoros += ","  + szavak[k];
            break;
        }
    }
}
Console.WriteLine("Többször előforduló szavak: " + tobbszoros.Substring(1));

for (int i = 0; i < sokszo.Length; i++)
{
    if (szavak[i].Length == 4)
    {
        szavak[i] = szavak[i].Substring(0, 1).ToUpper() + szavak[i].Substring(1);
        Console.WriteLine(szavak[i]);
    }
}
for (int i = 0; i < sokszo.Length; i++)
{
    if (szavak[i].Length == 4)
    {
        for (int k = i+1; k < szavak.Length; k++)
        {
            if (szavak[k].Length == 6)
            {
                if (szavak[k].IndexOf(szavak[i].ToLower()) > -1)
                {
                    Console.WriteLine("{0} benne van ebben: {1}", szavak[i], szavak[k]);
                }
            }
        }
    }
}
for (int i = 0; i < sokszo.Length; i++)
{
    if (szavak[i].Length == 5)
    {
        szavak[i] = szavak[i].Replace("a", "@").Replace("e", "3").Replace("l", "1").Replace("o", "0");
        Console.WriteLine(szavak[i]);
    }
}

string[] valogat = new string[11];
for (int i = 0; i < valogat.Length; i++)
{
    valogat[szavak[i].Length] += szavak[i] + "kutya";
}
for (int i = 2; i < 11; i++)
{
    string[] darabolt = valogat[4].Substring(0, valogat[4].Length - 1).Split(",");
    Array.Sort(darabolt);
    File.WriteAllLines(i + "betus.txt", darabolt);
}
