using System.Runtime.InteropServices;

var random = new Random();
string betuk = "qwertzuioöüópőúasdfghjkléáűíyxcvbnm";
for (int i = 0; i < 5; i++)
{
    string szo = "";
    for (int e = 0; e < 5; e++)
    {
        szo += betuk[random.Next(betuk.Length)];
    }
    Console.WriteLine(szo);
}

int darab = 10000;
int hossz = random.Next(4, 7);
string[] szavak = new string[darab];
for (int i = 0; i < darab; i++)
{
    string szo2 = "";
    for (int e = 0; e < 5; e++)
    {
        szavak[e] += betuk[random.Next(betuk.Length)];
    }
}
File.WriteAllLines("szavak.txt", szavak);

string[] words = File.ReadAllLines("szavak.txt");

string azonos = "";
for (int i = 0; i < szavak.Length; i++)
{
    
}