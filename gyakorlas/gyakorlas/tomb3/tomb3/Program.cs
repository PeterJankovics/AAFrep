// fuggvény amely keszit egy a parametereiben megadott feltételeknek megfelelő tömböt.
int[] tombKeszit(int darab, int legkisebb, int legnagyobb)
{    
    int[] tomb = new int[darab];
    Random random = new Random();
    for (int i = 0; i < tomb.Length; i++)
    {
        tomb[i] = random.Next(legkisebb,legnagyobb+1);
    }
    return tomb;
}
int[]szamok = tombKeszit(1000, 100, 999);
int paros = 0;
int paratlan = 0;
for (int i = 0; i < szamok.Length; i++)
{
    if (szamok[i] % 2 == 0)
    {
        paros++;
    }
    else
    {
        paratlan++;
    }
}
Console.WriteLine("ennyi paros van: {0}; ennyi paratlan: {1}", paros, paratlan);
// kovetkezo elem viszgalat.
bool vanEgyenloSzomszedos = false;

for (int i = 1; i < szamok.Length; i++)
{
    if (szamok[i] == szamok[i - 1])
    {
        vanEgyenloSzomszedos = true;
        Console.WriteLine("Egyenlo: {0}. és {1}, {2}, = {3}", i-1, i, szamok[i - 1], szamok[i]);
        //break;
    }
}
if (vanEgyenloSzomszedos)
{
    Console.WriteLine("Van egyenlo szomszedos elem.");
}
else 
{
    Console.WriteLine("Nincs szomszédos elem.");
}
//valamilyen feltetel szerint egy leghosszab novekvo szakasz megkeresése és kiirasa.
void szakasz2(int[] szamTomb)
{
    int kezd = 0;
    int veg = 0;
    int maxKezd = 0;
    int maxVeg = 0;
    for (int i = 1; i < szamok.Length; i++)
    {
        if (szamTomb[i - 1] < szamTomb[i])
        {
            
        }
        else
        {
            veg = i-1;
            if (veg - kezd + 1 > maxVeg - maxKezd + 1)
            {
                maxVeg = veg;
                maxKezd = kezd;
            }
            kezd = i;
        }
    }
    Console.WriteLine(maxVeg - maxKezd + 1);
    for (int i = maxKezd; i < maxVeg +1; i++)
    {
        Console.WriteLine(szamTomb[i]);
    }
}
szakasz2(szamok);
// hf: fuggveny keszites ami a legnagyobb csokkeno sorozatot adja vissza es nem szigoruan csokkeno tehat ha egyenlo ne allitsa le a fuggvényt.
