using System;

class Ülesanded
{
    public static void ArvuTöötlus()
    {
        Console.Write("Minimaalne väärtus: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Maksimaalne väärtus: ");
        int max = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        int N = rnd.Next(min, max + 1);
        int M = rnd.Next(min, max + 1);
        if (N > M) { int t = N; N = M; M = t; }

        for (int i = N; i <= M; i++)
            Console.WriteLine(i + " * " + i + " = " + (i * i));
    }

    public static void ArvuAnalüüs()
    {
        double summa = 0, korrutis = 1;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Sisesta " + (i + 1) + ". arv: ");
            double arv = double.Parse(Console.ReadLine());
            summa += arv;
            korrutis *= arv;
        }
        Console.WriteLine("Summa: " + summa);
        Console.WriteLine("Keskmine: " + (summa / 5));
        Console.WriteLine("Korrutis: " + korrutis);
    }

    public static void NimedVanused()
    {
        string[] nimed = new string[5];
        int[] vanused = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write((i + 1) + ". nimi: ");
            nimed[i] = Console.ReadLine();
            Console.Write((i + 1) + ". vanus: ");
            vanused[i] = int.Parse(Console.ReadLine());
        }

        int summa = 0, vanimIdx = 0, noorimIdx = 0;
        for (int i = 0; i < 5; i++)
        {
            summa += vanused[i];
            if (vanused[i] > vanused[vanimIdx]) vanimIdx = i;
            if (vanused[i] < vanused[noorimIdx]) noorimIdx = i;
        }

        Console.WriteLine("Summa: " + summa);
        Console.WriteLine("Keskmine: " + (summa / 5.0));
        Console.WriteLine("Vanim: " + nimed[vanimIdx] + " (" + vanused[vanimIdx] + ")");
        Console.WriteLine("Noorim: " + nimed[noorimIdx] + " (" + vanused[noorimIdx] + ")");
    }

    public static void ElevantMäng()
    {
        string vastus = "";
        while (vastus != "JAH")
        {
            Console.WriteLine("Kas soovid elevanti osta? (JAH/EI)");
            vastus = Console.ReadLine();
        }
        Console.WriteLine("Tubli! Elevant on sinu oma!");
    }

    public static void ArvamisMäng()
    {
        string mängib = "jah";
        while (mängib == "jah")
        {
            Random rnd = new Random();
            int salajane = rnd.Next(1, 101);
            bool arvati = false;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Katse " + i + "/5 – arva arv [1-100]: ");
                int arv = int.Parse(Console.ReadLine());

                if (arv == salajane) { Console.WriteLine("Õige!"); arvati = true; break; }
                else if (arv > salajane) Console.WriteLine("Liiga suur!");
                else Console.WriteLine("Liiga väike!");
            }

            if (!arvati) Console.WriteLine("Kaotasid! Arv oli " + salajane);

            Console.Write("Kas soovid uuesti mängida? (jah/ei): ");
            mängib = Console.ReadLine().ToLower();
        }
    }

    public static void NeliarSuurim()
    {
        int[] arvud = new int[4];
        for (int i = 0; i < 4; i++)
        {
            Console.Write("Sisesta " + (i + 1) + ". number (0-9): ");
            arvud[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arvud);
        Array.Reverse(arvud);
        int tulemus = arvud[0] * 1000 + arvud[1] * 100 + arvud[2] * 10 + arvud[3];
        Console.WriteLine("Suurim nelikohaline arv: " + tulemus);
    }

    public static void Korrutustabel()
    {
        Console.Write("Ridade arv: ");
        int read = int.Parse(Console.ReadLine());
        Console.Write("Veergude arv: ");
        int veerud = int.Parse(Console.ReadLine());

        Console.WriteLine();
        for (int r = 1; r <= read; r++)
        {
            for (int v = 1; v <= veerud; v++)
                Console.Write((r * v).ToString().PadLeft(4));
            Console.WriteLine();
        }
    }

    public static void Õpilased()
    {
        string[] nimed = { "Anna", "Peeter", "Mari", "Jaan", "Aino",
                           "Karl", "Liis", "Tiit", "Kalle", "Eevi" };
        nimed[2] = "Kati";
        nimed[5] = "Mati";

        Console.WriteLine("A-ga algavad:");
        foreach (string nimi in nimed)
            if (nimi.StartsWith("A")) Console.WriteLine("  Tere, " + nimi + "!");

        Console.WriteLine("\nKõik nimed:");
        for (int i = 0; i < nimed.Length; i++)
            Console.WriteLine("  [" + i + "] " + nimed[i]);

        Console.WriteLine("\nVäikeste tähtedega:");
        foreach (string nimi in nimed)
            Console.WriteLine("  " + nimi.ToLower());
    }

    public static void ArvudeRuudud()
    {
        int[] arvud = { 2, 4, 6, 8, 10, 12 };
        foreach (int a in arvud)
            Console.WriteLine(a + " * " + a + " = " + (a * a));
    }

    public static void PosNeg()
    {
        int[] arvud = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };
        int pos = 0, neg = 0, null_ = 0;

        foreach (int a in arvud)
        {
            if (a > 0) pos++;
            else if (a < 0) neg++;
            else null_++;
        }

        Console.WriteLine("Positiivseid: " + pos);
        Console.WriteLine("Negatiivseid: " + neg);
        Console.WriteLine("Nulle: " + null_);
    }

    public static void KeskmisestSuuremad()
    {
        Random rnd = new Random();
        int[] arvud = new int[15];
        double summa = 0;

        for (int i = 0; i < 15; i++)
        {
            arvud[i] = rnd.Next(1, 101);
            summa += arvud[i];
        }

        double keskmine = summa / 15;
        Console.WriteLine("Arvud: " + string.Join(", ", arvud));
        Console.WriteLine("Keskmine: " + keskmine);
        Console.Write("Keskmisest suuremad: ");
        foreach (int a in arvud)
            if (a > keskmine) Console.Write(a + " ");
        Console.WriteLine();
    }

    public static void SuurimArv()
    {
        int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };
        int suurim = numbrid[0];
        int suurimIdx = 0;

        for (int i = 1; i < numbrid.Length; i++)
        {
            if (numbrid[i] > suurim)
            {
                suurim = numbrid[i];
                suurimIdx = i;
            }
        }

        Console.WriteLine("Arvud: " + string.Join(", ", numbrid));
        Console.WriteLine("Suurim arv: " + suurim);
        Console.WriteLine("Selle indeks: " + suurimIdx);
    }

    public static void PaarLoendus()
    {
        Random rnd = new Random();
        int[] arvud = new int[20];
        long paarSumma = 0, paarituSumma = 0;
        int paarituArv = 0;

        for (int i = 0; i < 20; i++)
        {
            arvud[i] = rnd.Next(1, 101);
            if (arvud[i] % 2 == 0) paarSumma += arvud[i];
            else { paarituSumma += arvud[i]; paarituArv++; }
        }

        Console.WriteLine("Arvud: " + string.Join(", ", arvud));
        Console.WriteLine("Paarisarvude summa: " + paarSumma);
        if (paarituArv > 0)
            Console.WriteLine("Paaritute keskmine: " + (double)paarituSumma / paarituArv);
    }
}