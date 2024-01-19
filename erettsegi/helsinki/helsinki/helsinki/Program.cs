using helsinki;

List<adatok> eredmenyerek = new List<adatok>();

StreamReader olvas = new StreamReader("helsinki.txt");

while (!olvas.EndOfStream)
{
    string sor = olvas.ReadLine();
    eredmenyerek.Add(new adatok(sor));
}

olvas.Close();

Console.WriteLine("3. feladat: ");
Console.WriteLine("Pontszerzo helyezesek szama: {0}", eredmenyerek.Count());

int[] ermekszama = new int[7];

for (int i = 0; i < eredmenyerek.Count; i++)
{
    ermekszama[eredmenyerek[i].helyezes]++;
}
Console.WriteLine("arany: {0}", ermekszama[1]);
Console.WriteLine("ezust: {0}", ermekszama[2]);
Console.WriteLine("bronz: {0}", ermekszama[3]);
Console.WriteLine("osszesen: {0}", ermekszama[1] + ermekszama[2] + ermekszama[3]);