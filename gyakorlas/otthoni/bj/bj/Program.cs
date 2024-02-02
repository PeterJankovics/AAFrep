List <string> kartyak =  new List<string>();
List <string> szimbol = new List<string>() { "cœur", "trèfles" , "carreaux", "piques" };
List<string> ertek = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9","bubi","dáma","király","ász"};
Random random = new Random();

// osszevonas
for (int i = 0; i < szimbol.Count; i++)
{
    for (int j = 0; j < ertek.Count; j++)
    {
        kartyak.Add($"{szimbol[i]} {ertek[j]}");
    }
}

// ertekadas
Dictionary<string, int> ertek = new Dictionary<string, int>();

if  (kartyak.IndexOf("bubi") || kartyak.IndexOf("dáma") || )