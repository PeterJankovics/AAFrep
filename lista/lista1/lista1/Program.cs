List<string> szavak = new List<string>();
szavak.Add("Kolos");
szavak.Add("Dani");
szavak.Add("Dominik");
szavak.Add("Anna");
Console.WriteLine(szavak);

for (int i = 0; i < szavak.Count; i++)
{
    Console.WriteLine(szavak[i]);
}
Console.WriteLine("--------");
foreach (string s in szavak)
{
    Console.WriteLine(s);
}
Console.WriteLine("-----");
Console.WriteLine(szavak.IndexOf("Kolos"));

Dictionary<string,int> p = new Dictionary<string,int>();
p.Add("Laci", 3);
p.Add("Bence", 0);
Console.WriteLine(p.Count);
p["Tomi"] = 4;
Console.WriteLine(p.Count);

try
{
    p.Add("bence", 10);
}
catch (Exception)
{
    p["Bence"]--;
}
p.Remove("Bence");
//Console.WriteLine(p["Bence"]);
foreach (KeyValuePair e in p)
{
    
}