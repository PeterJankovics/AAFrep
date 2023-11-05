// bekeni egy szot vegignezni betunkent minden betut ellenorzunk hogy betu e
// ha igen akkor folytatjuk a kovetkezovel ha nincs bennen akkor kiirjuk hogy nem szo.

using Microsoft.Win32.SafeHandles;
using System.Reflection;

string szavak = "";
Console.WriteLine("kerek egy szot!! ");
string betuk = "qwertzuiopőúöüóasdfghjkléáűíyxcvbnmQWERTZUIOPÖÜÓŐÚŰÁÉLKJHGFDSAÍYXCVBNM";
bool joE = true;
while (szavak == "")
{
    szavak = Console.ReadLine();
    for (int i = 0; i < szavak.Length; i++)
    {
        if (betuk.IndexOf(szavak[i]) < 0)
        {
            Console.WriteLine("nem szo");
            joE = false;
            break;
        }
    }
    if (joE)
    {
        Console.WriteLine("{0} jo szó", szavak);
    }
    string ujSzo = "";
    for (int i = szavak.Length-1; i <= 0; i--)
    {
        ujSzo += szavak[i];
    }
    Console.WriteLine(ujSzo);
    ujSzo = "";
    for (int i = 0; i < szavak.Length; i++)
    { 
        ujSzo += szavak[szavak.Length - 1 - i];
    }
    Console.WriteLine(ujSzo);
    ujSzo = "";
    for (int i = 0; i < szavak.Length; i++)
    {
        ujSzo+= szavak[i] + ujSzo;
    }
    Console.WriteLine(ujSzo);
    ujSzo = "";
    for(int i = 0; i < szavak.Length; i+=2)
    {
        ujSzo += szavak.Substring(szavak.Length - 1 - 1 - i, 2);
    }
    Console.WriteLine(ujSzo);
}

//hf melyik betubol hany darab van a kis es nagybetuk egyenloek. 