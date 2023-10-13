/*Console.Write("Kerek egy szamot: ");
int szam = Convert.ToInt32(Console.ReadLine());

string[] szoveg = new string[szam]; 
for (int i = 0; i < szam; i++)
{
    Console.Write("kerek egy szoveget: ");
    string beker = Console.ReadLine();
    szoveg[i] = beker;
 

}
string max = "";
for (int i = 0; i < szoveg.Length; i++) 
{
    if (szoveg[i].Length > max.Length)
    {
        max = szoveg[i];
    }
}*/

/*Console.WriteLine(max);
int maxIndex = 0;
for (int i = 0; i < szoveg.Length; i++)
{
    if (szoveg[i] == max)
    {
        maxIndex = i;
    }
}
Console.Write(maxIndex);*/

/*string max = "";
int maxIndex = 0;
for (int i = 0; i < szoveg.Length; i++)
{
    if (szoveg[i].Length > max.Length)
    { 
        max = szoveg[i];
        maxIndex = i;
    }
}*/

/*int MaxIndex = 0;
for (int i = 0; i < szoveg.Length; i++)
{
    if (szoveg[i].Length > szoveg[MaxIndex].Length)
    {
       MaxIndex = i;
    }
}
Console.WriteLine(MaxIndex);*/

/*string[] szavak = new string[] {"alma", "korte", "banan", "dio", "dinnye", "barac"};

string[] rovid = new string[szavak.Length];
string[] hosszu = new string[szavak.Length];
int rovidIndex = 0;
int hosszuIndex = 0;
for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length <= 5)
    {
        rovid[rovidIndex] = szavak[i];
        rovidIndex++;
    }
    else
    {
        hosszu[hosszuIndex++] = szavak[i];
    }
}
for (int i = 0; i < rovid.Length; i++)
{
    Console.WriteLine(rovid[i]);
}
for (int i = 0; i < hosszu.Length; i++)
{
    Console.WriteLine(hosszu[i]);
}*/

int[] random = new int[1000];
for (int i = 0; i < 1000; i++)
{
    Random random1 = new Random();
    random[i] = random1.Next(100, 1000);
}
