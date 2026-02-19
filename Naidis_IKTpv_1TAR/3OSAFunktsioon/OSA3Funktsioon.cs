using System;
using System.Collections.Generic;
using System.Linq;

namespace Naidis_IKTpv_1TAR._3OSAFunktsioon
{
    public class OSA3Funktsioon
    {
        static Random rnd = new Random();

        // ═════════════════════════════════════════════════════════════
        // TEOORIA NÄITED (otse teoriaraamatust)
        // ═════════════════════════════════════════════════════════════

        // Teooria: while tsükkel – 5 matkajat
        public static void TeooriaMatkajadWhile()
        {
            Console.WriteLine("--- while tsükkel ---");
            int nr = 1;
            while (nr <= 5)
            {
                Console.WriteLine("Tere, {0}. matkaja!", nr);
                nr = nr + 1;
            }
        }

        // Teooria: for tsükkel – 5 matkajat
        public static void TeooriaMatkajadFor()
        {
            Console.WriteLine("--- for tsükkel ---");
            for (int nr = 1; nr <= 5; nr++)
            {
                Console.WriteLine("Tere, {0}. matkaja!", nr);
            }
        }

        // Teooria: do-while tsükkel – 5 matkajat
        public static void TeooriaMatkajadDoWhile()
        {
            Console.WriteLine("--- do-while tsükkel ---");
            int nr = 0;
            do
            {
                Console.WriteLine("Tere, {0}. matkaja!", nr);
                nr = nr + 1;
            } while (nr != 5);
        }

        // Teooria: Isik klass + List (teoriaraamatust)
        public static void TeooriaIsikKlassJaList()
        {
            Console.WriteLine("--- Isik klass + List ---");
            List<Isik> inimesed = new List<Isik>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Sisesta nimi: ");
                string nimi = Console.ReadLine();

                Console.Write("Sisesta vanus: ");
                int vanus = int.Parse(Console.ReadLine());

                Isik uusIsik = new Isik();
                uusIsik.Nimi = nimi;
                uusIsik.Vanus = vanus;
                inimesed.Add(uusIsik);
            }

            Console.WriteLine("\nKõik inimesed tervitavad:\n");
            foreach (Isik isik in inimesed)
            {
                isik.Tervita();
            }
        }

        // Teooria: massiivid – while/for/foreach/do-while
        public static void TeooriaMassiivid()
        {
            Console.WriteLine("--- Massiivid ---");
            string[] nimed = new string[8] { "A", "B", "C", "D", "E", "F", "G", "H" };
            nimed[2] = "Anna";

            Console.WriteLine("while:");
            int nr = 0;
            while (nr < 8)
            {
                Console.WriteLine("Tere, {0} opilane", nimed[nr]);
                nr = nr + 1;
            }

            Console.WriteLine("for:");
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine("Tere, {0} opilane", nimed[i]);
            }

            Console.WriteLine("foreach:");
            foreach (var nimi in nimed)
            {
                Console.WriteLine("Tere, {0} opilane", nimi);
            }

            Console.WriteLine("do-while:");
            nr = 0;
            do
            {
                Console.WriteLine("Tere, {0} opilane", nimed[nr]);
                nr++;
            } while (nr != nimed.Length);
        }

        // Teooria: Tuple näide
        public static void TeooriaTuple()
        {
            Console.WriteLine("--- Tuple näide ---");
            Tuple<float, char, string> minuTuple =
                new Tuple<float, char, string>(3.14f, 'A', "Programmeerimine");

            Console.WriteLine("Esimene: " + minuTuple.Item1); // 3.14
            Console.WriteLine("Teine: " + minuTuple.Item2); // A
            Console.WriteLine("Kolmas: " + minuTuple.Item3); // Programmeerimine
        }

        // ═════════════════════════════════════════════════════════════
        // ÜLESANNE 1 – Juhuslike arvude ruudud
        // Klass ArvuTootlus on eraldi failis ArvuTootlus.cs
        // ═════════════════════════════════════════════════════════════
        // (kutsutakse välja Menu3-s otse ArvuTootlus.GenereeriRuudud kaudu)

        // ═════════════════════════════════════════════════════════════
        // ÜLESANNE 2 – Viie arvu analüüs
        // ═════════════════════════════════════════════════════════════

        // Abimeetod: kasutaja sisestab n arvu
        public static double[] TekstistArvud(int arve)
        {
            double[] arvud = new double[arve];
            for (int i = 0; i < arve; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Sisesta " + (i + 1) + ". arv: ");
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

        // Tagastab Tuple: summa, keskmine, korrutis
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

        // ═════════════════════════════════════════════════════════════
        // ÜLESANNE 3 – Nimed ja vanused
        // Klass Inimene on eraldi failis Inimene.cs
        // ═════════════════════════════════════════════════════════════

        // Tagastab Tuple: summa, keskmine, vanim, noorim
        public static Tuple<int, double, Inimene, Inimene> Statistika(List<Inimene> inimesed)
        {
            int summa = 0;
            foreach (Inimene i in inimesed)
            {
                summa += i.Vanus;
            }

            double keskmine = (double)summa / inimesed.Count;

            Inimene vanim = inimesed[0];
            Inimene noorim = inimesed[0];

            foreach (Inimene i in inimesed)
            {
                if (i.Vanus > vanim.Vanus) vanim = i;
                if (i.Vanus < noorim.Vanus) noorim = i;
            }

            return Tuple.Create(summa, keskmine, vanim, noorim);
        }

        // ═════════════════════════════════════════════════════════════
        // ÜLESANNE 4 – "Osta elevant ära!"
        // ═════════════════════════════════════════════════════════════
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
                {
                    Console.WriteLine("Vale! Proovi uuesti.");
                }
            }
            while (vastus != marksõna);

            Console.WriteLine("\nKõik sisestused:");
            foreach (string s in sisestused)
            {
                Console.WriteLine("  - " + s);
            }
            Console.WriteLine("Märksõna leitud: " + marksõna + "!");
        }

        // ═════════════════════════════════════════════════════════════
        // ÜLESANNE 5 – Arvamise mäng
        // ═════════════════════════════════════════════════════════════
        public static void ArvaArv()
        {
            bool uuesti;
            do
            {
                int arv = rnd.Next(1, 101);
                bool oige = false;

                Console.WriteLine("Arva ära arv 1-100! Sul on 5 katset.");

                for (int katse = 1; katse <= 5; katse++)
                {
                    Console.WriteLine("Katse " + katse + "/5: ");
                    int arvamine;

                    if (!int.TryParse(Console.ReadLine(), out arvamine))
                    {
                        Console.WriteLine("Palun sisesta täisarv!");
                        katse--;
                        continue;
                    }

                    if (arvamine == arv)
                    {
                        Console.WriteLine("Oige! Arvasid ära " + katse + ". katsega!");
                        oige = true;
                        break;
                    }
                    else if (arvamine < arv)
                    {
                        Console.WriteLine("Liiga väike!");
                    }
                    else
                    {
                        Console.WriteLine("Liiga suur!");
                    }
                }

                if (!oige)
                {
                    Console.WriteLine("Kahjuks ei arvanud. Oige vastus oli " + arv + ".");
                }

                Console.WriteLine("Kas soovid uuesti mängida? (jah/ei): ");
                uuesti = Console.ReadLine().ToLower() == "jah";

            } while (uuesti);
        }

        // ═════════════════════════════════════════════════════════════
        // ÜLESANNE 6 – Suurim neliarvuline arv
        // ═════════════════════════════════════════════════════════════
        public static void SuurimNeliarv()
        {
            int[] arvud = new int[4];

            for (int i = 0; i < 4; i++)
            {
                while (true)
                {
                    Console.WriteLine("Sisesta " + (i + 1) + ". arv (0-9): ");
                    int a;
                    if (int.TryParse(Console.ReadLine(), out a) && a >= 0 && a <= 9)
                    {
                        arvud[i] = a;
                        break;
                    }
                    Console.WriteLine("Palun sisesta ühekohaline arv (0-9)!");
                }
            }

            // Sorteerime kahanevas järjekorras -> suurim number
            Array.Sort(arvud);
            Array.Reverse(arvud);

            int tulemus = arvud[0] * 1000 + arvud[1] * 100 + arvud[2] * 10 + arvud[3];
            Console.WriteLine("Suurim võimalik neljakohaline arv: " + tulemus);
        }

        // ═════════════════════════════════════════════════════════════
        // ÜLESANNE 7 – Korrutustabel
        // ═════════════════════════════════════════════════════════════
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

        // ═════════════════════════════════════════════════════════════
        // ÜLESANNE 8 – Opilastega mängimine
        // ═════════════════════════════════════════════════════════════
        public static void OpilastegaMängimine()
        {
            string[] nimed = { "Andres", "Birgit", "Celia", "Diana", "Eleri",
                                "Fanny",  "Grete",  "Heidi", "Irena", "Jaanika" };

            // Asenda 3. (indeks 2) ja 6. (indeks 5)
            nimed[2] = "Kati";
            nimed[5] = "Mati";
            Console.WriteLine("Asendatud: indeks 2 -> Kati, indeks 5 -> Mati");

            // while – ainult A-ga algavad
            Console.WriteLine("\nwhile - tervitame A-ga algavaid:");
            int nr = 0;
            while (nr < nimed.Length)
            {
                if (nimed[nr].StartsWith("A"))
                {
                    Console.WriteLine("Tere, " + nimed[nr] + "!");
                }
                nr++;
            }

            // for – kõik nimed ja indeksid
            Console.WriteLine("\nfor - kõik nimed ja indeksid:");
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine("[" + i + "] " + nimed[i]);
            }

            // foreach – väikeste tähtedega
            Console.WriteLine("\nforeach - väikeste tähtedega:");
            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi.ToLower());
            }

            // do-while – kuni "Mati"
            Console.WriteLine("\ndo-while - tervitame kuni Mati:");
            int j = 0;
            do
            {
                Console.WriteLine("Tere, " + nimed[j] + "!");
                j++;
            }
            while (j < nimed.Length && nimed[j - 1] != "Mati");
        }

        // ═════════════════════════════════════════════════════════════
        // ÜLESANNE 9 – Arvude ruudud
        // ═════════════════════════════════════════════════════════════
        public static void ArvudeRuudud()
        {
            int[] arvud = { 2, 4, 6, 8, 10, 12 };
            Console.WriteLine("Massiiv: { " + string.Join(", ", arvud) + " }");

            // for – ruudud
            Console.WriteLine("\nfor - iga arvu ruut:");
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine(arvud[i] + "^2 = " + (arvud[i] * arvud[i]));
            }

            // foreach – kahekordne väärtus
            Console.WriteLine("\nforeach - kahekordne väärtus:");
            foreach (int arv in arvud)
            {
                Console.WriteLine(arv + " x 2 = " + (arv * 2));
            }

            // while – 3-ga jaguvate loendus
            Console.WriteLine("\nwhile - 3-ga jaguvate arvude loendus:");
            int loendur = 0;
            int idx = 0;
            while (idx < arvud.Length)
            {
                if (arvud[idx] % 3 == 0)
                {
                    loendur++;
                }
                idx++;
            }
            Console.WriteLine("3-ga jaguvaid arve: " + loendur);
        }

        // ═════════════════════════════════════════════════════════════
        // ÜLESANNE 10 – Positiivsed ja negatiivsed
        // ═════════════════════════════════════════════════════════════
        public static void PositiivsedJaNegatiivsed()
        {
            int[] arvud = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };
            Console.WriteLine("Massiiv: { " + string.Join(", ", arvud) + " }");

            int positiivsed = 0;
            int negatiivsed = 0;
            int nullid = 0;

            // foreach tsükkel (ülesande nõue)
            foreach (int arv in arvud)
            {
                if (arv > 0)
                {
                    positiivsed++;
                }
                else if (arv < 0)
                {
                    negatiivsed++;
                }
                else
                {
                    nullid++;
                }
            }

            Console.WriteLine("Positiivseid arve: " + positiivsed);
            Console.WriteLine("Negatiivseid arve: " + negatiivsed);
            Console.WriteLine("Nulle:             " + nullid);
        }

        // ═════════════════════════════════════════════════════════════
        // ÜLESANNE 11 – Keskmisest suuremad
        // ═════════════════════════════════════════════════════════════
        public static void KeskmisestSuuremad()
        {
            int[] arvud = new int[15];
            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = rnd.Next(1, 101);
            }
            Console.WriteLine("Genereeritud: " + string.Join(", ", arvud));

            // Leiame keskmise (foreach)
            int summa = 0;
            foreach (int arv in arvud)
            {
                summa += arv;
            }
            double keskmine = (double)summa / arvud.Length;
            Console.WriteLine("Keskmine: " + Math.Round(keskmine, 2));

            // Keskmisest suuremad (foreach)
            Console.WriteLine("Keskmisest suuremad arvud:");
            foreach (int arv in arvud)
            {
                if (arv > keskmine)
                {
                    Console.Write(arv + " ");
                }
            }
            Console.WriteLine();

            // do-while – kuni kohtame arvu < 10
            Console.WriteLine("do-while - väljastame kuni kohtame arvu < 10:");
            int i2 = 0;
            do
            {
                Console.Write(arvud[i2] + " ");
                i2++;
            }
            while (i2 < arvud.Length && arvud[i2 - 1] >= 10);
            Console.WriteLine();
        }

        // ═════════════════════════════════════════════════════════════
        // ÜLESANNE 12 – Suurima arvu otsing + indeks
        // ═════════════════════════════════════════════════════════════
        public static void SuurimJaIndeks()
        {
            int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };
            Console.WriteLine("Massiiv: { " + string.Join(", ", numbrid) + " }");

            int max = numbrid[0];
            int maxIndeks = 0;

            // for tsükkel (ilma Max() kasutamata)
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

        // ═════════════════════════════════════════════════════════════
        // ÜLESANNE 13 – Paari- ja paaritud (List<int>)
        // ═════════════════════════════════════════════════════════════
        public static void PaaridJaPaaritud()
        {
            List<int> arvud = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                arvud.Add(rnd.Next(1, 101));
            }
            Console.WriteLine("Genereeritud: " + string.Join(", ", arvud));

            // for – paarisarvude kogusumma
            int paarissumma = 0;
            for (int i = 0; i < arvud.Count; i++)
            {
                if (arvud[i] % 2 == 0)
                {
                    paarissumma += arvud[i];
                }
            }
            Console.WriteLine("Paarisarvude kogusumma (for): " + paarissumma);

            // foreach – paaritute arvude keskmine
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
            double paaritudKeskmine = paaritudArv > 0
                ? (double)paaritudSumma / paaritudArv
                : 0;
            Console.WriteLine("Paaritute arvude keskmine (foreach): "
                + Math.Round(paaritudKeskmine, 2));

            // while – üle 50 loendus
            int loendur = 0;
            int idx = 0;
            while (idx < arvud.Count)
            {
                if (arvud[idx] > 50)
                {
                    loendur++;
                }
                idx++;
            }
            Console.WriteLine("50-st suuremaid arve (while): " + loendur);
        }
    }
}
