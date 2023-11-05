// fuggvény amely keszit egy a parametereiben megadott feltételeknek megfelelő tömböt.
/*int[] tombKeszit(int darab, int legkisebb, int legnagyobb)
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
}*/
//valamilyen feltetel szerint egy leghosszab novekvo szakasz megkeresése és kiirasa.
/*void szakasz2(int[] szamTomb)
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
szakasz2(szamok);*/
// hf: fuggveny keszites ami a legnagyobb csokkeno sorozatot adja vissza es nem szigoruan csokkeno tehat ha egyenlo ne allitsa le a fuggvényt.
/*void szakasz3(int[] szamTomb)
{
    int kezd = 0;
    int veg = 0;
    int maxKezd = 0;
    int maxVeg = 0;
    for (int i = 1; i < szamok.Length; i++)
    {
        if (szamTomb[i - 1] >= szamTomb[i])
        {

        }
        else
        {
            veg = i - 1;
            if (veg - kezd + 1 >= maxVeg - maxKezd + 1)
            {
                maxVeg = veg;
                maxKezd = kezd;
            }
            kezd = i;
        }
    }
    Console.WriteLine(maxVeg - maxKezd + 1);
    for (int i = maxKezd; i < maxVeg + 1; i++)
    {
        Console.WriteLine(szamTomb[i]);
    }
}
szakasz3(szamok);*/




// fuggveny keszites mely visszaad egy 10000 tagu negyjegyu pozitiv szamokat tartalmazo tömböt.
// keresni olyan 3 tagu szakaszokat amit egymastol max 10 tavolsagra vannak. a tovvabisaak mellettuk kiesnek.


int[] negytagu()
{
    int[] darab = new int[10000];
    Random random = new Random();
    for (int i = 0; i < darab.Length; i++)
    {
        darab[i] = random.Next(1000, 10000);
    }
    return darab;
}

int[] szakasz(int[] darab)
{
    int[] szakasz2 = new int[darab.Length];
    for (int i = 1; 0 < darab.Length; i++) 
    {
        if (darab[i] - darab[i - 1] <= 10 && darab[i + 1] - darab[i] <= 10 || darab[i - 1] - darab[i] <= 10 && darab[i] - darab[i + 1] <= 10)
        {
            
        }
    }
    return szakasz2;
}
