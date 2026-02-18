using System;
using System.Collections.Generic;

//  Ülesanne 1 – Juhuslike arvude ruudud
class ArvuTöötlus
{
    public static (int start, int[] ruudud) GenereeriRuudud(int min, int max)
    {
        Random rnd = new Random();
        int N = rnd.Next(min, max + 1);
        int M = rnd.Next(min, max + 1);
        if (N > M) { int tmp = N; N = M; M = tmp; }

        int[] ruudud = new int[M - N + 1];
        for (int i = 0; i <= M - N; i++)
            ruudud[i] = (N + i) * (N + i);

        return (N, ruudud);
    }

    public static void Käivita()
    {
        Console.Write("Minimaalne väärtus: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Maksimaalne väärtus: ");
        int max = int.Parse(Console.ReadLine());

        var (start, ruudud) = GenereeriRuudud(min, max);
        Console.WriteLine("\nTulemused:");
        for (int i = 0; i < ruudud.Length; i++)
            Console.WriteLine($"  {start + i} → {ruudud[i]}");
    }
}

//  Ülesanne 2 – Viie arvu analüüs
class ArvuAnalüüs
{
    public static Tuple<double, double, double> AnalüüsiArve(double[] arvud)
    {
        double summa = 0, korrutis = 1;
        foreach (double a in arvud) { summa += a; korrutis *= a; }
        return new Tuple<double, double, double>(summa, summa / arvud.Length, korrutis);
    }

    public static void Käivita()
    {
        double[] arvud = new double[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"  Sisesta {i + 1}. arv: ");
            arvud[i] = double.Parse(Console.ReadLine());
        }
        var t = AnalüüsiArve(arvud);
        Console.WriteLine($"\n  Summa:    {t.Item1:F2}");
        Console.WriteLine($"  Keskmine: {t.Item2:F2}");
        Console.WriteLine($"  Korrutis: {t.Item3:F2}");
    }
}

//  Ülesanne 3 – Nimed ja vanused
class Inimene
{
    public string Nimi;
    public int Vanus;
}

class NimedVanused
{
    public static Tuple<int, double, Inimene, Inimene> Statistika(List<Inimene> inimesed)
    {
        int summa = 0;
        Inimene vanim = inimesed[0], noorim = inimesed[0];
        foreach (Inimene i in inimesed)
        {
            summa += i.Vanus;
            if (i.Vanus > vanim.Vanus) vanim = i;
            if (i.Vanus < noorim.Vanus) noorim = i;
        }
        return new Tuple<int, double, Inimene, Inimene>(summa, (double)summa / inimesed.Count, vanim, noorim);
    }

    public static void Käivita()
    {
        List<Inimene> nimekiri = new List<Inimene>();
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"  {i + 1}. nimi: ");
            string nimi = Console.ReadLine();
            Console.Write($"  {i + 1}. vanus: ");
            int vanus = int.Parse(Console.ReadLine());
            nimekiri.Add(new Inimene { Nimi = nimi, Vanus = vanus });
        }
        var s = Statistika(nimekiri);
        Console.WriteLine($"\n  Vanuste summa:  {s.Item1}");
        Console.WriteLine($"  Keskmine vanus: {s.Item2:F1}");
        Console.WriteLine($"  Vanim:          {s.Item3.Nimi} ({s.Item3.Vanus})");
        Console.WriteLine($"  Noorim:         {s.Item4.Nimi} ({s.Item4.Vanus})");
    }
}

//  Ülesanne 4 – "Osta elevant ära!"
class ElevantMäng
{
    public static List<string> KuniMärksõnani(string märksõna, string fraas)
    {
        List<string> sisestused = new List<string>();
        string sisend;
        do
        {
            Console.WriteLine("  " + fraas);
            Console.Write("  > ");
            sisend = Console.ReadLine();
            sisestused.Add(sisend);
        } while (sisend != märksõna);
        return sisestused;
    }

    public static void Käivita()
    {
        var kõik = KuniMärksõnani("JAH", "Kas soovid elevanti osta? (JAH/EI)");
        Console.WriteLine("\n  Kõik sisestused:");
        foreach (string s in kõik)
            Console.WriteLine("    " + s);
    }
}

//  Ülesanne 5 – Arvamise mäng
class ArvamisMäng
{
    public static void ArvaArv()
    {
        string mängib;
        do
        {
            Random rnd = new Random();
            int salajane = rnd.Next(1, 101);
            bool arvati = false;

            for (int katse = 1; katse <= 5; katse++)
            {
                Console.Write($"  Katse {katse}/5 – arva arv [1–100]: ");
                int arv = int.Parse(Console.ReadLine());
                if (arv == salajane) { Console.WriteLine("  ✓ Õige! Arvasid ära!"); arvati = true; break; }
                else if (arv > salajane) Console.WriteLine("  ↓ Liiga suur!");
                else Console.WriteLine("  ↑ Liiga väike!");
            }
            if (!arvati) Console.WriteLine($"  Kaotasid! Arv oli {salajane}.");

            Console.Write("\n  Kas soovid uuesti mängida? (jah/ei): ");
            mängib = Console.ReadLine();
        } while (mängib.ToLower() == "jah");
    }

    public static void Käivita() => ArvaArv();
}

//  Ülesanne 6 – Suurim neliarvuline arv
class NeliarSuurim
{
    public static int SuurimNeliarv(int[] arvud)
    {
        foreach (int a in arvud)
            if (a < 0 || a > 9)
                throw new ArgumentException("Arv peab olema vahemikus 0–9!");

        int[] sort = (int[])arvud.Clone();
        Array.Sort(sort);
        Array.Reverse(sort);
        return sort[0] * 1000 + sort[1] * 100 + sort[2] * 10 + sort[3];
    }

    public static void Käivita()
    {
        int[] sisend = new int[4];
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"  Sisesta {i + 1}. arv (0–9): ");
            sisend[i] = int.Parse(Console.ReadLine());
        }
        try
        {
            Console.WriteLine($"\n  Suurim nelikohaline arv: {SuurimNeliarv(sisend)}");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine("  Viga: " + e.Message);
        }
    }
}

//  Ülesanne 7 – Korrutustabel
class Korrutustabel
{
    public static int[,] GenereeriKorrutustabel(int ridadeArv, int veergudeArv)
    {
        int[,] tabel = new int[ridadeArv, veergudeArv];
        for (int r = 0; r < ridadeArv; r++)
            for (int v = 0; v < veergudeArv; v++)
                tabel[r, v] = (r + 1) * (v + 1);

        for (int r = 0; r < ridadeArv; r++)
        {
            for (int v = 0; v < veergudeArv; v++)
                Console.Write(tabel[r, v].ToString().PadLeft(4));
            Console.WriteLine();
        }
        return tabel;
    }

    public static void Käivita()
    {
        Console.Write("  Ridade arv: ");
        int read = int.Parse(Console.ReadLine());
        Console.Write("  Veergude arv: ");
        int veerud = int.Parse(Console.ReadLine());

        Console.WriteLine();
        int[,] tabel = GenereeriKorrutustabel(read, veerud);

        Console.Write("\n  Otsi tulemus (1. tegur): ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("  Otsi tulemus (2. tegur): ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"  {a} × {b} = {tabel[a - 1, b - 1]}");
    }
}

//  Ülesanne 8 – Õpilastega mängimine
class Õpilased
{
    public static void Käivita()
    {
        string[] nimed = { "Anna", "Peeter", "Mari", "Jaan", "Aino",
                           "Karl", "Liis", "Tiit", "Kalle", "Eevi" };

        nimed[2] = "Kati";
        nimed[5] = "Mati";

        Console.WriteLine("\n  [while] A-ga algavad:");
        int i = 0;
        while (i < nimed.Length)
        {
            if (nimed[i].StartsWith("A")) Console.WriteLine("    Tere, " + nimed[i] + "!");
            i++;
        }

        Console.WriteLine("\n  [for] Kõik nimed indeksitega:");
        for (int j = 0; j < nimed.Length; j++)
            Console.WriteLine($"    [{j}] {nimed[j]}");

        Console.WriteLine("\n  [foreach] Väikeste tähtedega:");
        foreach (string nimi in nimed)
            Console.WriteLine("    " + nimi.ToLower());

        Console.WriteLine("\n  [do-while] Kuni 'Mati':");
        int k = 0;
        do
        {
            Console.WriteLine("    Tere, " + nimed[k] + "!");
            k++;
        } while (k < nimed.Length && nimed[k - 1] != "Mati");
    }
}

//  Ülesanne 9 – Arvude ruudud
class ArvudeRuudud
{
    public static void Käivita()
    {
        int[] arvud = { 2, 4, 6, 8, 10, 12 };

        Console.WriteLine("  [for] Ruudud:");
        for (int i = 0; i < arvud.Length; i++)
            Console.WriteLine($"    {arvud[i]}² = {arvud[i] * arvud[i]}");

        Console.WriteLine("  [foreach] Kahekordne väärtus:");
        foreach (int a in arvud)
            Console.WriteLine($"    {a} × 2 = {a * 2}");

        Console.Write("  [while] 3-ga jaguvaid: ");
        int loendur = 0, j = 0;
        while (j < arvud.Length)
        {
            if (arvud[j] % 3 == 0) loendur++;
            j++;
        }
        Console.WriteLine(loendur);
    }
}

//  Ülesanne 10 – Positiivsed ja negatiivsed
class PosNeg
{
    public static void Käivita()
    {
        int[] arvud = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };
        int pos = 0, neg = 0, null_ = 0;
        foreach (int a in arvud)
        {
            if (a > 0) pos++;
            else if (a < 0) neg++;
            else null_++;
        }
        Console.WriteLine($"  Positiivseid: {pos}");
        Console.WriteLine($"  Negatiivseid: {neg}");
        Console.WriteLine($"  Nulle:        {null_}");
    }
}

//  Ülesanne 11 – Keskmisest suuremad
class KeskmisestSuuremad
{
    public static void Käivita()
    {
        Random rnd = new Random();
        int[] arvud = new int[15];
        for (int i = 0; i < 15; i++) arvud[i] = rnd.Next(1, 101);

        Console.WriteLine("  Arvud: " + string.Join(", ", arvud));

        double summa = 0;
        foreach (int a in arvud) summa += a;
        double keskmine = summa / arvud.Length;
        Console.WriteLine($"  Keskmine: {keskmine:F1}");

        Console.Write("  Keskmisest suuremad: ");
        foreach (int a in arvud)
            if (a > keskmine) Console.Write(a + " ");
        Console.WriteLine();

        Console.Write("  [do-while] Kuni arv < 10: ");
        int j = 0;
        do
        {
            Console.Write(arvud[j] + " ");
            j++;
        } while (j < arvud.Length && arvud[j - 1] >= 10);
        Console.WriteLine();
    }
}

//  Ülesanne 12 – Kõige suurema arvu otsing
class SuurimArv
{
    public static void Käivita()
    {
        int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };
        int suurimVal = numbrid[0], suurimIdx = 0;

        for (int i = 1; i < numbrid.Length; i++)
            if (numbrid[i] > suurimVal) { suurimVal = numbrid[i]; suurimIdx = i; }

        Console.WriteLine($"  Arvud: {string.Join(", ", numbrid)}");
        Console.WriteLine($"  Suurim arv:  {suurimVal}");
        Console.WriteLine($"  Selle indeks: {suurimIdx}");
    }
}

//  Ülesanne 13 – Paari- ja paaritud loendused
class PaarLoendus
{
    public static void Käivita()
    {
        Random rnd = new Random();
        List<int> arvud = new List<int>();
        for (int i = 0; i < 20; i++) arvud.Add(rnd.Next(1, 101));
        Console.WriteLine("  Arvud: " + string.Join(", ", arvud));

        long paarSumma = 0;
        for (int i = 0; i < arvud.Count; i++)
            if (arvud[i] % 2 == 0) paarSumma += arvud[i];
        Console.WriteLine($"\n  [for]     Paarisarvude summa:  {paarSumma}");

        long paarituSumma = 0; int paarituArv = 0;
        foreach (int a in arvud)
            if (a % 2 != 0) { paarituSumma += a; paarituArv++; }
        double paarituKesk = paarituArv > 0 ? (double)paarituSumma / paarituArv : 0;
        Console.WriteLine($"  [foreach] Paaritute keskmine:   {paarituKesk:F1}");

        int loendur = 0, j = 0;
        while (j < arvud.Count)
        {
            if (arvud[j] > 50) loendur++;
            j++;
        }
        Console.WriteLine($"  [while]   Arve suuremaid kui 50: {loendur}");
    }
}
