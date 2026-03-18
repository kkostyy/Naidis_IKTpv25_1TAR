using System;
using System.Collections.Generic;

namespace Naidis_IKTpv_1TAR._3OSAFunktsioon
{
    public class OSA3Funktsioon
    {
        static Random rnd = new Random();

        // Teooria: while tsükkel
        public static void TeooriaMatkajadWhile()
        {
            int nr = 1;
            while (nr <= 5)
            {
                Console.WriteLine("Tere, " + nr + ". matkaja!");
                nr = nr + 1;
            }
        }

        // Teooria: for tsükkel
        public static void TeooriaMatkajadFor()
        {
            for (int nr = 1; nr <= 5; nr++)
            {
                Console.WriteLine("Tere, " + nr + ". matkaja!");
            }
        }

        // Teooria: do-while tsükkel
        public static void TeooriaMatkajadDoWhile()
        {
            int nr = 1;
            do
            {
                Console.WriteLine("Tere, " + nr + ". matkaja!");
                nr = nr + 1;
            } while (nr <= 5);
        }

        // Teooria: Isik klass + List
        public static void TeooriaIsikKlassJaList()
        {
            List<OSA3Isik> inimesed = new List<OSA3Isik>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Sisesta nimi: ");
                string nimi = Console.ReadLine();

                Console.Write("Sisesta vanus: ");
                int vanus = int.Parse(Console.ReadLine());

                OSA3Isik uusIsik = new OSA3Isik();
                uusIsik.Nimi = nimi;
                uusIsik.Vanus = vanus;
                inimesed.Add(uusIsik);
            }

            foreach (OSA3Isik isik in inimesed)
            {
                isik.Tervita();
            }
        }

        // Teooria: massiivid
        public static void TeooriaMassiivid()
        {
            string[] nimed = new string[8] { "A", "B", "C", "D", "E", "F", "G", "H" };
            nimed[2] = "Anna";

            Console.WriteLine("while:");
            int nr = 0;
            while (nr < nimed.Length)
            {
                Console.WriteLine("Tere, " + nimed[nr]);
                nr = nr + 1;
            }

            Console.WriteLine("for:");
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine("Tere, " + nimed[i]);
            }

            Console.WriteLine("foreach:");
            foreach (string nimi in nimed)
            {
                Console.WriteLine("Tere, " + nimi);
            }

            Console.WriteLine("do-while:");
            int idx = 0;
            do
            {
                Console.WriteLine("Tere, " + nimed[idx]);
                idx++;
            } while (idx < nimed.Length);
        }

        // Teooria: Tuple
        public static void TeooriaTuple()
        {
            Tuple<float, char, string> minuTuple =
                new Tuple<float, char, string>(3.14f, 'A', "Programmeerimine");

            Console.WriteLine("Esimene: " + minuTuple.Item1);
            Console.WriteLine("Teine: "   + minuTuple.Item2);
            Console.WriteLine("Kolmas: "  + minuTuple.Item3);
        }

        // Ülesanne 2 – Viie arvu sisestamine
        public static double[] TekstistArvud(int arve)
        {
            double[] arvud = new double[arve];
            for (int i = 0; i < arve; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Sisesta " + (i + 1) + ". arv: ");
                        arvud[i] = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Palun sisesta number!");
                    }
                }
            }
            return arvud;
        }

        // Ülesanne 2 – Viie arvu analüüs (Tuple: summa, keskmine, korrutis)
        public static Tuple<double, double, double> AnalüüsiArve(double[] arvud)
        {
            double summa = 0;
            double korrutis = 1;

            foreach (double a in arvud)
            {
                summa += a;
                korrutis *= a;
            }

            double keskmine = summa / arvud.Length;
            return Tuple.Create(summa, keskmine, korrutis);
        }

        // Ülesanne 3 – Statistika (Tuple: summa, keskmine, vanim, noorim)
        public static Tuple<int, double, OSA3Inimene, OSA3Inimene> Statistika(List<OSA3Inimene> inimesed)
        {
            int summa = 0;
            foreach (OSA3Inimene i in inimesed)
                summa += i.Vanus;

            double keskmine = (double)summa / inimesed.Count;

            OSA3Inimene vanim  = inimesed[0];
            OSA3Inimene noorim = inimesed[0];

            foreach (OSA3Inimene i in inimesed)
            {
                if (i.Vanus > vanim.Vanus)  vanim  = i;
                if (i.Vanus < noorim.Vanus) noorim = i;
            }

            return Tuple.Create(summa, keskmine, vanim, noorim);
        }

        // Ülesanne 4 – Osta elevant ära!
        public static void KuniMarksõnani(string marksõna, string fraas)
        {
            List<string> sisestused = new List<string>();
            string vastus;

            do
            {
                Console.WriteLine(fraas);
                vastus = Console.ReadLine();
                sisestused.Add(vastus);

                if (vastus != marksõna)
                    Console.WriteLine("Vale! Proovi uuesti.");
            }
            while (vastus != marksõna);

            Console.WriteLine("\nKõik sisestused:");
            foreach (string s in sisestused)
                Console.WriteLine("  - " + s);

            Console.WriteLine("Marksõna leitud: " + marksõna + "!");
        }

        // Ülesanne 5 – Arvamise mäng
        public static void ArvaArv()
        {
            bool uuesti;
            do
            {
                int arv = rnd.Next(1, 101);
                bool oige = false;

                Console.WriteLine("Arva ara arv 1-100! Sul on 5 katset.");

                for (int katse = 1; katse <= 5; katse++)
                {
                    Console.Write("Katse " + katse + "/5: ");
                    int arvamine;

                    if (!int.TryParse(Console.ReadLine(), out arvamine))
                    {
                        Console.WriteLine("Palun sisesta taisarv!");
                        katse--;
                        continue;
                    }

                    if (arvamine == arv)
                    {
                        Console.WriteLine("Oige! Arvasid ara " + katse + ". katsega!");
                        oige = true;
                        break;
                    }
                    else if (arvamine < arv)
                        Console.WriteLine("Liiga vaike!");
                    else
                        Console.WriteLine("Liiga suur!");
                }

                if (!oige)
                    Console.WriteLine("Kahjuks ei arvanud. Oige vastus oli " + arv + ".");

                Console.Write("Kas soovid uuesti mangida? (jah/ei): ");
                uuesti = Console.ReadLine().ToLower() == "jah";
            }
            while (uuesti);
        }

        // Ülesanne 6 – Suurim nelikohaline arv
        public static void SuurimNeliarv()
        {
            int[] arvud = new int[4];

            for (int i = 0; i < 4; i++)
            {
                while (true)
                {
                    Console.Write("Sisesta " + (i + 1) + ". arv (0-9): ");
                    int a;
                    if (int.TryParse(Console.ReadLine(), out a) && a >= 0 && a <= 9)
                    {
                        arvud[i] = a;
                        break;
                    }
                    Console.WriteLine("Palun sisesta uhekohaline arv (0-9)!");
                }
            }

            Array.Sort(arvud);
            Array.Reverse(arvud);

            int tulemus = arvud[0] * 1000 + arvud[1] * 100 + arvud[2] * 10 + arvud[3];
            Console.WriteLine("Suurim võimalik neljakohaline arv: " + tulemus);
        }

        // Ülesanne 7 – Korrutustabel
        public static int[,] GenereeriKorrutustabel(int ridadeArv, int veergudeArv)
        {
            int[,] tabel = new int[ridadeArv, veergudeArv];

            for (int i = 0; i < ridadeArv; i++)
            {
                for (int j = 0; j < veergudeArv; j++)
                {
                    tabel[i, j] = (i + 1) * (j + 1);
                    Console.Write(tabel[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }

            return tabel;
        }

        // Ülesanne 8 – Õpilastega mängimine
        public static void OpilastegaMängimine()
        {
            string[] nimed = { "Andres", "Birgit", "Celia", "Diana", "Eleri",
                                "Fanny",  "Grete",  "Heidi", "Irena", "Jaanika" };

            nimed[2] = "Kati";
            nimed[5] = "Mati";
            Console.WriteLine("Asendatud: indeks 2 -> Kati, indeks 5 -> Mati");

            Console.WriteLine("\nwhile - A-ga algavad:");
            int nr = 0;
            while (nr < nimed.Length)
            {
                if (nimed[nr].StartsWith("A"))
                    Console.WriteLine("Tere, " + nimed[nr] + "!");
                nr++;
            }

            Console.WriteLine("\nfor - kõik nimed ja indeksid:");
            for (int i = 0; i < nimed.Length; i++)
                Console.WriteLine("[" + i + "] " + nimed[i]);

            Console.WriteLine("\nforeach - väikeste tähtedega:");
            foreach (string nimi in nimed)
                Console.WriteLine(nimi.ToLower());

            Console.WriteLine("\ndo-while - tervitame kuni Mati:");
            int j = 0;
            do
            {
                Console.WriteLine("Tere, " + nimed[j] + "!");
                j++;
            }
            while (j < nimed.Length && nimed[j - 1] != "Mati");
        }

        // Ülesanne 9 – Arvude ruudud
        public static void ArvudeRuudud()
        {
            int[] arvud = { 2, 4, 6, 8, 10, 12 };

            Console.WriteLine("for - iga arvu ruut:");
            for (int i = 0; i < arvud.Length; i++)
                Console.WriteLine(arvud[i] + "^2 = " + (arvud[i] * arvud[i]));

            Console.WriteLine("foreach - kahekordne väärtus:");
            foreach (int arv in arvud)
                Console.WriteLine(arv + " x 2 = " + (arv * 2));

            Console.WriteLine("while - 3-ga jaguvate loendus:");
            int loendur = 0;
            int idx = 0;
            while (idx < arvud.Length)
            {
                if (arvud[idx] % 3 == 0)
                    loendur++;
                idx++;
            }
            Console.WriteLine("3-ga jaguvaid arve: " + loendur);
        }

        // Ülesanne 10 – Positiivsed ja negatiivsed
        public static void PositiivsedJaNegatiivsed()
        {
            int[] arvud = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };

            int positiivsed = 0;
            int negatiivsed = 0;
            int nullid = 0;

            foreach (int arv in arvud)
            {
                if (arv > 0)
                    positiivsed++;
                else if (arv < 0)
                    negatiivsed++;
                else
                    nullid++;
            }

            Console.WriteLine("Positiivseid: " + positiivsed);
            Console.WriteLine("Negatiivseid: " + negatiivsed);
            Console.WriteLine("Nulle:        " + nullid);
        }

        // Ülesanne 11 – Keskmisest suuremad
        public static void KeskmisestSuuremad()
        {
            int[] arvud = new int[15];
            for (int i = 0; i < arvud.Length; i++)
                arvud[i] = rnd.Next(1, 101);

            Console.WriteLine("Genereeritud: " + string.Join(", ", arvud));

            int summa = 0;
            foreach (int arv in arvud)
                summa += arv;

            double keskmine = (double)summa / arvud.Length;
            Console.WriteLine("Keskmine: " + Math.Round(keskmine, 2));

            Console.Write("Keskmisest suuremad: ");
            foreach (int arv in arvud)
                if (arv > keskmine)
                    Console.Write(arv + " ");
            Console.WriteLine();

            Console.Write("do-while (kuni arv < 10): ");
            int i2 = 0;
            do
            {
                Console.Write(arvud[i2] + " ");
                i2++;
            }
            while (i2 < arvud.Length && arvud[i2 - 1] >= 10);
            Console.WriteLine();
        }

        // Ülesanne 12 – Suurima arvu otsing
        public static void SuurimJaIndeks()
        {
            int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };
            Console.WriteLine("Massiiv: { " + string.Join(", ", numbrid) + " }");

            int max = numbrid[0];
            int maxIndeks = 0;

            for (int i = 1; i < numbrid.Length; i++)
            {
                if (numbrid[i] > max)
                {
                    max = numbrid[i];
                    maxIndeks = i;
                }
            }

            Console.WriteLine("Suurim arv: " + max);
            Console.WriteLine("Indeks:     " + maxIndeks);
        }

        // Ülesanne 13 – Paarisarvud ja paaritud
        public static void PaaridJaPaaritud()
        {
            List<int> arvud = new List<int>();
            for (int i = 0; i < 20; i++)
                arvud.Add(rnd.Next(1, 101));

            Console.WriteLine("Genereeritud: " + string.Join(", ", arvud));

            int paarissumma = 0;
            for (int i = 0; i < arvud.Count; i++)
                if (arvud[i] % 2 == 0)
                    paarissumma += arvud[i];

            Console.WriteLine("Paarisarvude summa (for): " + paarissumma);

            int paaritudSumma = 0;
            int paaritudArv = 0;
            foreach (int a in arvud)
            {
                if (a % 2 != 0)
                {
                    paaritudSumma += a;
                    paaritudArv++;
                }
            }

            double paaritudKeskmine = paaritudArv > 0 ? (double)paaritudSumma / paaritudArv : 0;
            Console.WriteLine("Paaritute keskmine (foreach): " + Math.Round(paaritudKeskmine, 2));

            int loendur = 0;
            int idx = 0;
            while (idx < arvud.Count)
            {
                if (arvud[idx] > 50)
                    loendur++;
                idx++;
            }
            Console.WriteLine("Ule 50 arve (while): " + loendur);
        }
    }
}
