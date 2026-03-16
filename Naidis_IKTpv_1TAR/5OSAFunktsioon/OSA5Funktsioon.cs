using System;
using System.Collections;
using System.Collections.Generic;

namespace Naidis_IKTpv_1TAR._5OSAFunktsioon
{
    public class OSA5Funktsioon
    {
        static Random rnd = new Random();

        // ── TEOORIA ─────────────────────────────────────────────────────

        public static void TeooriaArrayList()
        {
            ArrayList nimed = new ArrayList();
            nimed.Add("Kati");
            nimed.Add("Mati");
            nimed.Add("Juku");
            nimed.Insert(1, "Sass");

            Console.WriteLine("Contains Mati: " + nimed.Contains("Mati"));
            Console.WriteLine("Count: " + nimed.Count);
            Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));
            Console.WriteLine("Mari indeks: " + nimed.IndexOf("Mari"));

            foreach (string nimi in nimed)
                Console.WriteLine(nimi);
        }

        public static void TeooriaTuple()
        {
            Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');
            Console.WriteLine("Vahemaa: " + route.Item1 + ", Suund: " + route.Item2);
        }

        public static void TeooriaListT()
        {
            List<string> nimed = new List<string>();
            nimed.Add("Kadi");
            nimed.Add("Mirje");
            nimed.Add("Tonis");
            nimed.Sort();

            foreach (string n in nimed)
                Console.WriteLine(n);

            Console.WriteLine("Kadi indeks: " + nimed.IndexOf("Kadi"));
        }

        public static void TeooriaLinkedList()
        {
            LinkedList<int> loetelu = new LinkedList<int>();
            loetelu.AddLast(5);
            loetelu.AddLast(3);
            loetelu.AddFirst(0);

            Console.WriteLine("Enne:");
            foreach (int arv in loetelu)
                Console.WriteLine(arv);

            loetelu.RemoveFirst();
            loetelu.RemoveLast();
            loetelu.AddLast(555);
            loetelu.Remove(555);

            Console.WriteLine("Parast muudatusi:");
            foreach (int arv in loetelu)
                Console.WriteLine(arv);
        }

        public static void TeooriaDictionary()
        {
            Dictionary<int, string> riigid = new Dictionary<int, string>();
            riigid.Add(1, "Hiina");
            riigid.Add(2, "Eesti");
            riigid.Add(3, "Itaalia");

            foreach (var paar in riigid)
                Console.WriteLine(paar.Key + " - " + paar.Value);

            riigid[2] = "Eestimaa";
            riigid.Remove(3);

            Console.WriteLine("Parast muudatusi:");
            foreach (var paar in riigid)
                Console.WriteLine(paar.Key + " - " + paar.Value);
        }

        // ── ÜLESANDED ───────────────────────────────────────────────────

        // Ülesanne 1 – Kalorite kalkulaator
        public static void KaloriteKalkulaator()
        {
            List<Toode> toidud = new List<Toode>
            {
                new Toode("Riis",       130),
                new Toode("Kana filee", 165),
                new Toode("Oun",         52),
                new Toode("Must leib",  250),
                new Toode("Muna",       155),
                new Toode("Pasta",      371)
            };

            Console.Write("Nimi: ");
            string nimi = Console.ReadLine();
            Console.Write("Vanus: ");
            int vanus = int.Parse(Console.ReadLine());
            Console.Write("Sugu (M/N): ");
            string sugu = Console.ReadLine();
            Console.Write("Pikkus cm: ");
            double pikkus = double.Parse(Console.ReadLine());
            Console.Write("Kaal kg: ");
            double kaal = double.Parse(Console.ReadLine());
            Console.Write("Aktiivsus 1-5: ");
            int aktiivsus = int.Parse(Console.ReadLine());

            Inimene inimene = new Inimene(nimi, vanus, sugu, pikkus, kaal, aktiivsus);
            double vajadus = inimene.ArvutaPaevaneKalorivajadus();

            Console.WriteLine("Tere, " + nimi + "! Paevane kalorivajadus: " + Math.Round(vajadus, 0) + " kcal");
            Console.WriteLine("Paeva jooksul void syya:");
            foreach (Toode t in toidud)
            {
                double kogus = (vajadus / t.Kalorid100g) * 100;
                Console.WriteLine("  " + t.Nimi.PadRight(15) + Math.Round(kogus, 0) + " g");
            }
        }

        // Ülesanne 2 – Maakonnad ja pealinnad
        public static void MaakonnadJaPealinnad()
        {
            Dictionary<string, string> maakonnad = new Dictionary<string, string>
            {
                { "Harjumaa",     "Tallinn"    },
                { "Tartumaa",     "Tartu"      },
                { "Parnumaa",     "Parnu"      },
                { "Ida-Virumaa",  "Johvi"      },
                { "Laane-Virumaa","Rakvere"    },
                { "Viljandimaa",  "Viljandi"   },
                { "Saaremaa",     "Kuressaare" }
            };

            Dictionary<string, string> pealinnad = new Dictionary<string, string>();
            foreach (var paar in maakonnad)
                pealinnad[paar.Value] = paar.Key;

            bool jatka = true;
            while (jatka)
            {
                Console.WriteLine("\n1. Maakond -> pealinn");
                Console.WriteLine("2. Pealinn -> maakond");
                Console.WriteLine("3. Lisa uus");
                Console.WriteLine("4. Mangureziim");
                Console.WriteLine("0. Tagasi");
                Console.Write("Vali: ");
                string v = Console.ReadLine();

                if (v == "1")
                {
                    Console.Write("Maakond: ");
                    string mk = Console.ReadLine();
                    if (maakonnad.ContainsKey(mk))
                        Console.WriteLine("Pealinn: " + maakonnad[mk]);
                    else
                        Console.WriteLine("Ei leitud.");
                }
                else if (v == "2")
                {
                    Console.Write("Pealinn: ");
                    string pl = Console.ReadLine();
                    if (pealinnad.ContainsKey(pl))
                        Console.WriteLine("Maakond: " + pealinnad[pl]);
                    else
                        Console.WriteLine("Ei leitud.");
                }
                else if (v == "3")
                {
                    Console.Write("Maakond: ");
                    string mk = Console.ReadLine();
                    Console.Write("Pealinn: ");
                    string pl = Console.ReadLine();
                    maakonnad[mk] = pl;
                    pealinnad[pl] = mk;
                    Console.WriteLine("Lisatud!");
                }
                else if (v == "4")
                {
                    List<string> votmed = new List<string>(maakonnad.Keys);
                    int oiged = 0;
                    int kokku = 3;
                    for (int i = 0; i < kokku; i++)
                    {
                        string mk = votmed[rnd.Next(votmed.Count)];
                        Console.Write("Mis on " + mk + " pealinn? ");
                        string vastus = Console.ReadLine();
                        if (vastus.Trim().ToLower() == maakonnad[mk].ToLower())
                        {
                            Console.WriteLine("Oige!");
                            oiged++;
                        }
                        else
                        {
                            Console.WriteLine("Vale! Oige: " + maakonnad[mk]);
                        }
                    }
                    Console.WriteLine("Tulemus: " + oiged + "/" + kokku);
                }
                else if (v == "0")
                {
                    jatka = false;
                }
            }
        }

        // Ülesanne 3 – Õpilased ja hinnete analüüs
        public static void OpilasedJaHinded()
        {
            Console.Write("Mitu opilast? ");
            int arv = int.Parse(Console.ReadLine());

            List<Opilane> opilased = new List<Opilane>();

            for (int i = 0; i < arv; i++)
            {
                Console.Write((i + 1) + ". opilase nimi: ");
                Opilane op = new Opilane(Console.ReadLine());

                Console.Write("Mitu hinnet (3-5)? ");
                int hindearv = int.Parse(Console.ReadLine());

                for (int j = 0; j < hindearv; j++)
                {
                    Console.Write("  Hinne " + (j + 1) + ": ");
                    op.Hinded.Add(int.Parse(Console.ReadLine()));
                }

                opilased.Add(op);
            }

            Opilane parim = opilased[0];
            foreach (Opilane op in opilased)
            {
                Console.WriteLine(op.Nimi + " – keskmine: " + Math.Round(op.Keskmine(), 2));
                if (op.Keskmine() > parim.Keskmine())
                    parim = op;
            }

            Console.WriteLine("Parim: " + parim.Nimi + " (" + Math.Round(parim.Keskmine(), 2) + ")");

            // Boonus: sortimine
            opilased.Sort((a, b) => b.Keskmine().CompareTo(a.Keskmine()));
            Console.WriteLine("Pingerida:");
            int koht = 1;
            foreach (Opilane op in opilased)
                Console.WriteLine("  " + koht++ + ". " + op.Nimi + " – " + Math.Round(op.Keskmine(), 2));
        }

        // Ülesanne 4 – Filmide kogu
        public static void FilmideKogu()
        {
            List<Film> filmid = new List<Film>
            {
                new Film("Inception",         2010, "sci-fi"),
                new Film("The Godfather",      1972, "draam"),
                new Film("The Dark Knight",    2008, "action"),
                new Film("Interstellar",       2014, "sci-fi"),
                new Film("Pulp Fiction",       1994, "draam"),
                new Film("Arrival",            2016, "sci-fi")
            };

            Console.Write("Otsi zanri jargi (sci-fi / draam / action): ");
            string zanr = Console.ReadLine();

            foreach (Film f in filmid)
                if (f.Zanr.ToLower() == zanr.ToLower())
                    Console.WriteLine("  " + f.Pealkiri + " (" + f.Aasta + ")");

            // Uusim film
            Film uusim = filmid[0];
            foreach (Film f in filmid)
                if (f.Aasta > uusim.Aasta)
                    uusim = f;
            Console.WriteLine("Uusim: " + uusim.Pealkiri + " (" + uusim.Aasta + ")");

            // Grupeerimine
            Dictionary<string, List<Film>> grupid = new Dictionary<string, List<Film>>();
            foreach (Film f in filmid)
            {
                if (!grupid.ContainsKey(f.Zanr))
                    grupid[f.Zanr] = new List<Film>();
                grupid[f.Zanr].Add(f);
            }

            Console.WriteLine("Zanrite kaupa:");
            foreach (var g in grupid)
            {
                Console.WriteLine("  [" + g.Key + "]");
                foreach (Film f in g.Value)
                    Console.WriteLine("    - " + f.Pealkiri);
            }
        }

        // Ülesanne 5 – Arvude statistika
        public static void ArvudeStatistika()
        {
            Console.Write("Mitu arvu? ");
            int n = int.Parse(Console.ReadLine());

            double[] arvud = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Arv " + (i + 1) + ": ");
                arvud[i] = double.Parse(Console.ReadLine());
            }

            double summa = 0, max = arvud[0], min = arvud[0];
            foreach (double a in arvud)
            {
                summa += a;
                if (a > max) max = a;
                if (a < min) min = a;
            }
            double keskmine = summa / n;

            int suuremaid = 0;
            foreach (double a in arvud)
                if (a > keskmine) suuremaid++;

            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Summa: " + summa);
            Console.WriteLine("Keskmine: " + Math.Round(keskmine, 2));
            Console.WriteLine("Keskmisest suuremaid: " + suuremaid);

            // Boonus
            Array.Sort(arvud);
            Console.Write("Jarjestatult: ");
            foreach (double a in arvud)
                Console.Write(a + " ");
            Console.WriteLine();
        }

        // Ülesanne 6 – Lemmikloomade register
        public static void LemmikloomadeRegister()
        {
            Console.Write("Mitu looma? ");
            int arv = int.Parse(Console.ReadLine());

            List<Lemmikloom> loomad = new List<Lemmikloom>();

            for (int i = 0; i < arv; i++)
            {
                Console.Write((i + 1) + ". nimi: ");
                string n = Console.ReadLine();
                Console.Write("Liik: ");
                string liik = Console.ReadLine();
                Console.Write("Vanus: ");
                int v = int.Parse(Console.ReadLine());
                loomad.Add(new Lemmikloom(n, liik, v));
            }

            Console.WriteLine("Kassid:");
            foreach (Lemmikloom l in loomad)
                if (l.Liik.ToLower() == "kass")
                    Console.WriteLine("  " + l.Nimi + " (" + l.Vanus + " a)");

            double summa = 0;
            foreach (Lemmikloom l in loomad) summa += l.Vanus;
            Console.WriteLine("Keskmine vanus: " + Math.Round(summa / loomad.Count, 1));

            Lemmikloom vanim = loomad[0];
            foreach (Lemmikloom l in loomad)
                if (l.Vanus > vanim.Vanus)
                    vanim = l;
            Console.WriteLine("Vanim: " + vanim.Nimi + " (" + vanim.Vanus + " a)");

            // Boonus: otsi nime jargi
            Console.Write("Otsi nime jargi (Enter = jata): ");
            string otsitav = Console.ReadLine();
            if (otsitav != "")
            {
                bool leitud = false;
                foreach (Lemmikloom l in loomad)
                {
                    if (l.Nimi.ToLower() == otsitav.ToLower())
                    {
                        Console.WriteLine("Leitud: " + l.Nimi + " – " + l.Liik + ", " + l.Vanus + " a");
                        leitud = true;
                    }
                }
                if (!leitud)
                    Console.WriteLine("Ei leitud.");
            }
        }

        // Ülesanne 7 – Valuutakalkulaator
        public static void ValuutaKalkulaator()
        {
            Dictionary<string, Valuuta> valuutad = new Dictionary<string, Valuuta>
            {
                { "USD", new Valuuta("USD", 1.08) },
                { "GBP", new Valuuta("GBP", 0.86) },
                { "JPY", new Valuuta("JPY", 161.5) },
                { "SEK", new Valuuta("SEK", 11.5) }
            };

            Console.WriteLine("Valuutad:");
            foreach (var v in valuutad)
                Console.WriteLine("  " + v.Key + " – 1 EUR = " + v.Value.KurssEurSuhtes + " " + v.Key);

            Console.Write("Summa: ");
            double summa = double.Parse(Console.ReadLine());
            Console.Write("Valuuta (nt USD): ");
            string kood = Console.ReadLine().ToUpper();

            if (valuutad.ContainsKey(kood))
            {
                Valuuta v = valuutad[kood];
                Console.WriteLine(summa + " " + kood + " = " + Math.Round(summa / v.KurssEurSuhtes, 2) + " EUR");
                Console.WriteLine(summa + " EUR = " + Math.Round(summa * v.KurssEurSuhtes, 2) + " " + kood);
            }
            else
            {
                Console.WriteLine("Valuutat ei leitud.");
            }
        }
    }
}
