// szavak bekerese es ezeket szavankent irjuk be egy fileba. (egy azo egy sor.)
using System.Threading.Channels;

string betuk = "qwertzuioöüópőúasdfghjkléáűíyxcvbnm-";
string beSzo = "asdasd";
bool joSzo = true;
string gyujto = "";
while (beSzo != "")
{
    Console.Write("kerek egy szot: ");
    beSzo = Console.ReadLine();
    for (int i = 0; i < beSzo.Length; i++)
    {
        if (betuk.IndexOf(beSzo[i]) == -1)
        {
            joSzo = false;
            Console.WriteLine("Nem jo szo.");
            break;
        }
    }
    if (joSzo)
    {
        gyujto += beSzo + " ";
    }
}
Console.WriteLine(gyujto);
string[] darabok = gyujto.Trim().Split(' ');
StreamWriter ir = new StreamWriter("szavak.txt");
for (int i = 0; i < darabok.Length; i++)
{
    ir.WriteLine(darabok[i]);
}
ir.Close();

File.WriteAllLines("szavak2.txt", darabok);
