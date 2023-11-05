// bekeni egy szot vegignezni betunkent minden betut ellenorzunk hogy betu e
// ha igen akkor folytatjuk a kovetkezovel ha nincs bennen akkor kiirjuk hogy nem szo.

string szavak = "";
Console.WriteLine("kerek egy szot!! ");
string betuk = "qwertzuiopőúöüóasdfghjkléáűíyxcvbnmQWERTZUIOPÖÜÓŐÚŰÁÉLKJHGFDSAÍYXCVBNM";
bool joE; 
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
        Console.Writeline("{0} jo szó", be);
    }
}
