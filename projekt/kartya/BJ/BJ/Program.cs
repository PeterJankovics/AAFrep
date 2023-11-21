using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        //barmennyi kartyat kerhetsz,oszto tobb kartyat kaphasson,tét rendszer(ha nyersz akkor 2x,ha buksz levonja amennyit raktal,ha dontetlen visszakapod)
        //,kérdezze meg mennyivel akarsz jatszani,ha nyersz/vesztesz ne dobjon ki hanem kerdezze meg h akarsz e uj jatekot 
        Console.WriteLine("\n\n\tA");
        Console.Beep(220, 250);
        Console.Beep(523, 250);
        Console.Beep(261, 250);
        Console.WriteLine("\t\tBlackjack");
        Console.Beep(294, 250);
        Console.Beep(587, 250);
        Console.Beep(261, 250);
        Console.WriteLine("\t\t\t\tJátékunk");
        Console.Beep(440, 250);
        Console.Beep(523, 250);
        Console.Beep(587, 250);
        Console.Beep(658, 500);
        Console.WriteLine();
        const double kezdoPenz = 1000;
        double penz = kezdoPenz;

        Console.WriteLine($"A kezdő pénzed: {penz}$");
        Console.Write("---------------------\n");
        Console.WriteLine("1. Új játék");
        Console.WriteLine("2. Kilépés");

        Console.WriteLine("\nVálassz egyet és nyomd meg: <Enter>");
        string menu = Console.ReadLine();
        bool jatekmenet = true;
        while (jatekmenet != false)
        {
     
            switch (menu)
            {
                case "1":
                    Console.WriteLine("Kártyák keverése...");
                    Console.Beep(550, 600);
                    Console.WriteLine();
                    Console.WriteLine("Kártyák megkeverve...");
                    Console.Beep(550, 650);
                    Console.WriteLine();
                    Console.WriteLine("Kártya osztása...");
                    Console.Beep(550, 700);
                    Console.WriteLine();

                    var randomGenerator = new Random();
                    var elsoKartya = randomGenerator.Next(1, 12);
                    var masodikKartya = randomGenerator.Next(1, 12);
                    var harmadikKartya = 0;
                    var negyedikKartya = 0;
                    var ototdikKartya = 0;

                    Console.WriteLine($"Az elsö lapod értéke: {elsoKartya}");
                    Console.WriteLine();
                    Console.WriteLine($"A második lapod értéke: {masodikKartya}");
                    var eddigiKartyaErtek = elsoKartya + masodikKartya;
                    Console.WriteLine($"Lapjaid értéke: {eddigiKartyaErtek}");
                    Console.WriteLine();
                    Console.WriteLine($"Szeretnél még lapot?\n1. Igen 2. Nem");
                    var ajanlat = Console.ReadLine();

                    var osszKartya = 0;
                    if (ajanlat == "1")
                    {
                        harmadikKartya = randomGenerator.Next(1, 12);
                        Console.WriteLine($"A harmadik lapod értéke: {harmadikKartya}");
                        osszKartya = elsoKartya + masodikKartya + harmadikKartya;
                        Console.WriteLine($"Lapjaid értéke: {osszKartya}");
                        if (osszKartya > 21)
                            break;
                    }

                    
                    Console.WriteLine();
                    Console.WriteLine($"Szeretnél még lapot?\n1. Igen 2. Nem");
                    var ajanlat2 = Console.ReadLine();

                    if (ajanlat2 == "1")
                    {
                        negyedikKartya= randomGenerator.Next(1, 12);
                        Console.WriteLine($"A negyedik lapod értéke: {negyedikKartya}");
                        osszKartya = elsoKartya + masodikKartya + harmadikKartya + negyedikKartya;
                        Console.WriteLine($"Lapjaid értéke: {osszKartya}");
                        if (osszKartya > 21)
                            break;
                    }

                    
                    Console.WriteLine();
                    Console.WriteLine($"Szeretnél még lapot?\n1. Igen 2. Nem");
                    var ajanlat3 = Console.ReadLine();

                    if (ajanlat3 == "1")
                    {
                        ototdikKartya = randomGenerator.Next(1, 12);
                        osszKartya = elsoKartya + masodikKartya + harmadikKartya + negyedikKartya + ototdikKartya;
                        Console.WriteLine($"A otodik lapod értéke: {ototdikKartya}");
                        Console.WriteLine($"Lapjaid értéke: {osszKartya}");
                        if (osszKartya > 21)
                            break;
                    }      

                    if (osszKartya > 21)
                    {
                        Console.WriteLine("Game over..\n\nnNyomja meg bármelyik gombot a kilépéshez.");
                        Console.ReadKey();
                        jatekmenet = false;
                        return;

                    }

                    var oszto = randomGenerator.Next(10, 21);

                    Console.WriteLine($"Az osztó lapjainak értéke: {oszto}");

                    if (osszKartya < oszto)
                    {
                        Console.WriteLine("Az osztó nyert! Game over..\n\nNyomja meg bármelyik gombot a kilépéshez.");
                        Console.Beep(200, 700);
                        Console.Beep(400, 700);
                        Console.Beep(800, 700);
                        Console.ReadKey();
                        jatekmenet = false;
                        return;
                    }
                    else if (osszKartya == oszto)
                    {
                        Console.WriteLine("Döntetlen,a pénzed a visszakaptad!");
                    }

                    Console.WriteLine("Gratulálunk!!\nNyertél!!\n\nNyomja meg bármelyik gombot a kilépéshez.");
                    Console.ReadKey();
                    jatekmenet = false;
                    return;
                case "2":
                    Console.WriteLine("Kilépés");
                    jatekmenet = false;
                    return;
            }

            Console.ReadKey();
        }
    }

}