using System;
using System.Collections.Generic;

// Ülesanne 1
class ArvuTöötlus
{
    static void Main()
    {
        Random rnd = new Random();
        int N = rnd.Next(1, 10);
        int M = rnd.Next(1, 10);
        if (N > M) { int t = N; N = M; M = t; }

        for (int i = N; i <= M; i++)
            Console.WriteLine(i + " * " + i + " = " + (i * i));
    }
}

// Ülesanne 2
class ArvuAnalüüs
{
    static void Main()
    {
        double summa = 0, korrutis = 1;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Sisesta arv: ");
            double arv = double.Parse(Console.ReadLine());
            summa += arv;
            korrutis *= arv;
        }
        Console.WriteLine("Summa: " + summa);
        Console.WriteLine("Keskmine: " + (summa / 5));
        Console.WriteLine("Korrutis: " + korrutis);
    }
}

// Ülesanne 3
class NimedVanused
{
    static void Main()
    {
        string[] nimed = new string[5];
        int[] vanused = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nimi: ");
            nimed[i] = Console.ReadLine();
            Console.Write("Vanus: ");
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
}

// Ülesanne 4
class ElevantMäng
{
    static void Main()
    {
        string vastus = "";
        while (vastus != "JAH")
        {
            Console.WriteLine("Kas soovid elevanti osta? (JAH/EI)");
            vastus = Console.ReadLine();
        }
        Console.WriteLine("Tubli!");
    }
}

// Ülesanne 5
class ArvamisMäng
{
    static void Main()
    {
        Random rnd = new Random();
        int salajane = rnd.Next(1, 101);
        bool arvati = false;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Arva arv (1-100): ");
            int arv = int.Parse(Console.ReadLine());

            if (arv == salajane) { Console.WriteLine("Õige!"); arvati = true; break; }
            else if (arv > salajane) Console.WriteLine("Liiga suur!");
            else Console.WriteLine("Liiga väike!");
        }

        if (!arvati) Console.WriteLine("Kaotasid! Arv oli " + salajane);
    }
}

// Ülesanne 6
class NeliarSuurim
{
    static void Main()
    {
        int[] arvud = new int[4];
        for (int i = 0; i < 4; i++)
        {
            Console.Write("Sisesta number (0-9): ");
            arvud[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arvud);
        Array.Reverse(arvud);
        int tulemus = arvud[0] * 1000 + arvud[1] * 100 + arvud[2] * 10 + arvud[3];
        Console.WriteLine("Suurim arv: " + tulemus);
    }
}

// Ülesanne 7
class Korrutustabel
{
    static void Main()
    {
        Console.Write("Ridu: ");
        int read = int.Parse(Console.ReadLine());
        Console.Write("Veerge: ");
        int veerud = int.Parse(Console.ReadLine());

        for (int r = 1; r <= read; r++)
        {
            for (int v = 1; v <= veerud; v++)
                Console.Write((r * v).ToString().PadLeft(4));
            Console.WriteLine();
        }
    }
}

// Ülesanne 8
class Õpilased
{
    static void Main()
    {
        string[] nimed = { "Anna", "Peeter", "Mari", "Jaan", "Aino",
                           "Karl", "Liis", "Tiit", "Kalle", "Eevi" };
        nimed[2] = "Kati";
        nimed[5] = "Mati";

        foreach (string nimi in nimed)
            Console.WriteLine(nimi);
    }
}

// Ülesanne 9
class ArvudeRuudud
{
    static void Main()
    {
        int[] arvud = { 2, 4, 6, 8, 10, 12 };
        foreach (int a in arvud)
            Console.WriteLine(a + " * " + a + " = " + (a * a));
    }
}

// Ülesanne 10
class PosNeg
{
    static void Main()
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
}

// Ülesanne 11
class KeskmisestSuuremad
{
    static void Main()
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
        Console.WriteLine("Keskmine: " + keskmine);

        foreach (int a in arvud)
            if (a > keskmine) Console.Write(a + " ");
        Console.WriteLine();
    }
}

// Ülesanne 12
class SuurimArv
{
    static void Main()
    {
        int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };
        int suurim = numbrid[0];

        foreach (int a in numbrid)
            if (a > suurim) suurim = a;

        Console.WriteLine("Suurim: " + suurim);
    }
}

// Ülesanne 13
class PaarLoendus
{
    static void Main()
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

        Console.WriteLine("Paarisarvude summa: " + paarSumma);
        Console.WriteLine("Paaritute keskmine: " + (paarituArv > 0 ? (double)paarituSumma / paarituArv : 0));
    }
}