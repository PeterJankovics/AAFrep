class Auto
{
    public int kerekszam = 4;
    public void dudal()
    {
        Console.WriteLine("tututttttttuuuuuuu");
    }
    private string _tulaj;
    public string tulajdonos
    {
        get
        {
            return _tulaj;
        }
        set
        {
            _tulaj = value;
        }
    }
}
class Program
{
    static void Main()
    {
        Auto kocsi = new Auto();
        Console.WriteLine(kocsi.kerekszam);
        kocsi.dudal();
        kocsi.tulajdonos = "Gabi";
        Console.WriteLine(kocsi.tulajdonos);
        kocsi.tulajdonos = "Bence";
        Console.WriteLine(kocsi.tulajdonos);

    }
}
