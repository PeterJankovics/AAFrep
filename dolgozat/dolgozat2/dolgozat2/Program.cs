static int parosszam(List<int> szamok)
{
    int paros = 0;
    for (int i = 0; szamok.Count > 0; i++)
    {
        if (szamok[i] % 2 == 0)
        {
            paros++;
        }
    }
    return paros;
}

static int paratlanszam(List<int> szamok)
{
    int paratlan = 0;
    for (int i = 0; i < szamok.Count; i++)
    {
        if (szamok[i] % 2 != 0)
        {
            paratlan++;
        }
    }
    return paratlan;
}

Random rand = new Random();
 List<int> szamok = new List<int>();

for (int i = 0; i < 500; i++)
{
    szamok.Add(rand.Next(10000, 100000));

}
StreamWriter iras = new StreamWriter("szamok.csv");
for (int i = 0; i < szamok.Count; i++)
{
    iras.WriteLine(szamok[i]);
}
/*for (int i = 0; i < 500; i++)
{
   
}*/

//iras.Close();

Console.WriteLine(paratlanszam(szamok)  + " páratlan szám van a listában.");

int elsofele = 0;
for (int i = 0; i < 250; i++)
{
    elsofele += szamok[i];
}
//Console.WriteLine(elsofele);
int masodikfele = 0;
for (int i = 250; i < 500; i++)
{
    masodikfele += szamok[i];
}

if (elsofele < masodikfele)
{
    Console.WriteLine("a második fele nagyobb mint az elso.");
}
else if(elsofele > masodikfele)
{
    Console.WriteLine("az elo fele nagyobb mint a masodik.");
}
int harommalkezdodo = 0;
for (int i = 0; i < szamok.Count; i++)
{
    if (Convert.ToString(szamok[i])[0] == '3')
    {
        harommalkezdodo++;
    }
}
Console.WriteLine(harommalkezdodo + " harommal kezdodo szam van.");

/*List<int> egy = new List<int>();
List<int> ketto = new List<int>();
List<int> harom = new List<int>();
List<int> negy = new List<int>();
List<int> ot = new List<int>();
List<int> hat = new List<int>();
List<int> het = new List<int>();
List<int> nyolc = new List<int>();
List<int> kilenc = new List<int>();

Console.WriteLine("egyesekbol {0}", egy.Count());

for (int i = 0; i < szamok.Count; i++)
{
    if (Convert.ToString(szamok[i])[0] == '1')
    {

        egy.Add(Convert.ToInt32(szamok[i]));
    }
    else if (Convert.ToString(szamok[i])[0] == '2')
    {
        ketto.Add(szamok[i]);
    }
    else if (Convert.ToString(szamok[i])[0] == '3')
    {
        harom.Add(szamok[i]);
    }
    else if (Convert.ToString(szamok[i])[0] == '4')
    {
        negy.Add(szamok[i]);
    }
    else if (Convert.ToString(szamok[i])[0] == '5')
    {
        ot.Add(szamok[i]);
    }
    else if (Convert.ToString(szamok[i])[0] == '6')
    {
        hat.Add(szamok[i]);
    }
    else if (Convert.ToString(szamok[i])[0] == '7')
    {
        het.Add(szamok[i]);
    }
    else if (Convert.ToString(szamok[i])[0] == '8')
    {
        nyolc.Add(szamok[i]);
    }
    else if (Convert.ToString(szamok[i])[0] == '9')
    {
        kilenc.Add(szamok[i]);
    }

}
*/

for (int i = 0; i < szamok.Count; i++)
{
    iras = new StreamWriter(szamok[i] / 10000 + ".csv", true);
    iras.WriteLine();
    iras.Close();
}

List<string>[] szamlista = new List<string>[10];