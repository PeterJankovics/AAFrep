List<string> adatok1 = new List<string>();
List<string> adatok2 = new List<string>();
string[] olvastomb = File.ReadAllLines("kiserlet.txt");
for (int i = 0; i < olvastomb.Length; i++)
{
    adatok1.Add(olvastomb[i]);
    //Console.Write(olvastomb[i]);

}

StreamReader beol = new StreamReader("kiserlet.txt");
while (!beol.EndOfStream)
{
    adatok2.Add(beol.ReadLine());

}
beol.Close();

for (int i = 0; i < adatok1.Count; i++)
{
    Console.WriteLine("1.{0}, 2.{1}",adatok1[i], adatok2[i]);
}


Random random = new Random();

string fej = "fej";
string iras = "iras";

int fejvagyiras = random.Next(1);
if (fejvagyiras > 0)
{
    Console.WriteLine(fej);
}
else
{
    Console.WriteLine(iras);
}