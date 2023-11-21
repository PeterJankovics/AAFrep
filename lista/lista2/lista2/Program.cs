// csinalni egy listat amiben véletlen szamokat fogunk generalni. (ket jegyu szamok)
// megszamolni hogy az egyes szamokbol hany darab volt.

List<int> szamok = new List<int>();
 Random rand  = new Random();
int darab = rand.Next(10000, 100000);
for (int i = 0; i < darab; i++)
{
    szamok.Add(rand.Next(10, 100));
}
Console.WriteLine("{0} darab szám", szamok.Count());

Dictionary<int, int> stat= new Dictionary<int, int>();  

for (int i = 0; i < szamok.Count; i++)
{
    //szamok[i] sza aktualis elem.
    if (stat.ContainsKey(szamok[i]))
    {
        
    }
}