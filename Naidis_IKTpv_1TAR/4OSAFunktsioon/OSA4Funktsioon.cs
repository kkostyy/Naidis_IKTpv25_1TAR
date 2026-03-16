using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Naidis_IKTpv_1TAR._4OSAFunktsioon
{
    public class OSA4Funktsioon
    {
        static string KuudPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
        static string RetseptidPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");
        static string KoostisosadPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Koostisosad.txt");

        // Teooria 1 – Faili kirjutamine StreamWriter
        public static void FailiKirjutamine()
        {
            try
            {
                StreamWriter sw = new StreamWriter(KuudPath, true); // true = lisa lõppu
                Console.WriteLine("Sisesta tekst: ");
                sw.WriteLine(Console.ReadLine());
                sw.Close();
                Console.WriteLine("Salvestatud: " + KuudPath);
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }
        }
        
        // Teooria 2 – Faili lugemine StreamReader
        public static void FailiLugemine()
        {
            try
            {
                StreamReader sr = new StreamReader(KuudPath);
                string sisu = sr.ReadToEnd();
                sr.Close();
                Console.WriteLine(sisu);
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }
        }

        // Teooria 3 – Ridade lugemine List abil
        public static void ReadAllLinesNaide()
        {
            LooKuudTxt();

            List<string> kuude_list = new List<string>();
            try
            {
                foreach (string rida in File.ReadAllLines(KuudPath))
                {
                    kuude_list.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
                return;
            }

            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }
        }

        // Teooria 4 – Listi muutmine ja kuvamine
        public static void ListiMuutmine()
        {
            LooKuudTxt();

            List<string> kuude_list = new List<string>();
            try
            {
                foreach (string rida in File.ReadAllLines(KuudPath))
                    kuude_list.Add(rida);
            }
            catch (Exception)
            {
                Console.WriteLine("Viga faili lugemisel!");
                return;
            }

            Console.WriteLine("--- Algne nimekiri ---");
            foreach (string kuu in kuude_list)
                Console.WriteLine(kuu);

            kuude_list.Remove("Juuni");
            if (kuude_list.Count > 0)
                kuude_list[0] = "Veeel kuuu";

            Console.WriteLine("----- Kustutasime Juuni, muutsime esimest -----");
            foreach (string kuu in kuude_list)
                Console.WriteLine(kuu);
        }

        // Teooria 5 – Otsing listist
        public static void OtsigListist()
        {
            LooKuudTxt();

            List<string> kuude_list = new List<string>();
            try
            {
                foreach (string rida in File.ReadAllLines(KuudPath))
                    kuude_list.Add(rida);
            }
            catch (Exception)
            {
                Console.WriteLine("Viga faili lugemisel!");
                return;
            }

            Console.WriteLine("Sisesta kuu nimi, mida otsida: ");
            string otsitav = Console.ReadLine();

            if (kuude_list.Contains(otsitav))
                Console.WriteLine("Kuu " + otsitav + " on olemas.");
            else
                Console.WriteLine("Sellist kuud pole.");
        }

        // Teooria 6 – Listi salvestamine faili
        public static void ListiSalvestamine()
        {
            List<string> kuude_list = new List<string>()
            {
                "Jaanuar", "Veebruar", "Märts", "Aprill", "Mai",
                "Juuli", "August", "September", "Oktoober", "November", "Detsember"
            };

            try
            {
                File.WriteAllLines(KuudPath, kuude_list);
                Console.WriteLine("Andmed on salvestatud.");
            }
            catch (Exception)
            {
                Console.WriteLine("Viga salvestamisel!");
            }
        }

        // Ülesanne 1 – Lemmiktoidu salvestamine faili
        public static void LemmiktoiduSalvestamine()
        {
            try
            {
                StreamWriter sw = new StreamWriter(RetseptidPath, true);
                Console.WriteLine("Sisesta Itaalia toidu nimi (nt Lasagne, Risotto): ");
                string toit = Console.ReadLine();
                sw.WriteLine(toit);
                sw.Close();
                Console.WriteLine("\"" + toit + "\" salvestatud faili Retseptid.txt");
            }
            catch (Exception)
            {
                Console.WriteLine("Viga faili kirjutamisel!");
            }
        }

        // Ülesanne 2 – Menüü kuvamine StreamReader abil
        public static void MenüüKuvamine()
        {
            try
            {
                StreamReader sr = new StreamReader(RetseptidPath);
                string sisu = sr.ReadToEnd();
                sr.Close();
                Console.WriteLine("--- Retseptid.txt sisu ---");
                Console.WriteLine(sisu);
            }
            catch (Exception)
            {
                Console.WriteLine("Viga faili lugemisel! Kas Retseptid.txt eksisteerib?");
            }
        }

        // Ülesanne 3 – Koostisosade muutmine (kasutab Retsept klassi)
        public static void KoostisosadeMuutmine()
        {
            LooKoostisosadTxt();

            Retsept retsept = new Retsept("Minu retsept");
            retsept.LaeFailed("Koostisosad.txt");

            Console.WriteLine("--- Algne nimekiri ---");
            retsept.Kuva();

            // Muuda esimest elementi
            if (retsept.Koostisosad.Count > 0)
                retsept.Koostisosad[0] = "Kvaliteetne oliiviõli";

            // Eemalda "Ketsup"
            retsept.Eemalda("Ketsup");

            Console.WriteLine("--- Uuendatud nimekiri ---");
            retsept.Kuva();
        }

        // Ülesanne 4 – Külmkapi kontroll (kasutab Retsept.OnOlemas)
        public static void KülmkapiKontroll()
        {
            LooKoostisosadTxt();

            Retsept retsept = new Retsept("Minu retsept");
            retsept.LaeFailed("Koostisosad.txt");

            Console.WriteLine("Sisesta koostisosa nimi, mida otsida: ");
            string otsitav = Console.ReadLine();

            if (retsept.OnOlemas(otsitav))
                Console.WriteLine("Koostisosa on olemas!");
            else
                Console.WriteLine("Seda koostisosa meil retseptis ei ole.");
        }

        // Ülesanne 5 – Uuendatud nimekirja salvestamine (kasutab Retsept.Salvesta)
        public static void UuendatudSalvestamine()
        {
            LooKoostisosadTxt();

            Retsept retsept = new Retsept("Minu retsept");
            retsept.LaeFailed("Koostisosad.txt");

            if (retsept.Koostisosad.Count > 0)
                retsept.Koostisosad[0] = "Kvaliteetne oliiviõli";
            retsept.Eemalda("Ketsup");

            // Salvestame Retsept klassi meetodiga
            retsept.Salvesta("Koostisosad.txt");
        }

        // Abimeetodid – loovad failid kui neid pole
        static void LooKuudTxt()
        {
            if (!File.Exists(KuudPath))
            {
                File.WriteAllLines(KuudPath, new string[]
                {
                    "Jaanuar", "Veebruar", "Märts", "Aprill", "Mai", "Juuni",
                    "Juuli", "August", "September", "Oktoober", "November", "Detsember"
                });
                Console.WriteLine("Loodud Kuud.txt.");
            }
        }

        static void LooKoostisosadTxt()
        {
            if (!File.Exists(KoostisosadPath))
            {
                File.WriteAllLines(KoostisosadPath, new string[]
                {
                    "Oliiviõli", "Küüslauk", "Tomat", "Ketsup", "Basiilik", "Parmesan", "Pasta"
                });
                Console.WriteLine("Loodud Koostisosad.txt.");
            }
        }

        // Ülesanne 6* – Itaalia restorani menüü (Failist Tuple'isse)
        public static void RestoranMenüü()
        {
            LooMenuTxt();

            string path = FailiAbi.Tee("Menuu.txt");

            List<Tuple<string, string, double>> menyyList = new List<Tuple<string, string, double>>();

            try
            {
                string[] read = File.ReadAllLines(path);

                foreach (string rida in read)
                {
                    string[] osad = rida.Split(';');

                    if (osad.Length == 3)
                    {
                        string roaNimi = osad[0].Trim();
                        string koostisosad = osad[1].Trim();
                        double hind = double.Parse(osad[2].Trim(), CultureInfo.InvariantCulture);

                        menyyList.Add(Tuple.Create(roaNimi, koostisosad, hind));
                    }
                    else
                    {
                        Console.WriteLine("Vale formaat real: " + rida);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga faili lugemisel!");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("    ITAALIA RESTORAN");
            Console.WriteLine("    Tere tulemast meie restorani!");
            Console.WriteLine();

            foreach (Tuple<string, string, double> roog in menyyList)
            {
                string roaNimi = roog.Item1;
                string koostisosad = roog.Item2;
                double hind = roog.Item3;

                Console.WriteLine("  " + roaNimi.PadRight(33) + hind.ToString("F2") + " €");
                Console.WriteLine("    " + koostisosad);
                Console.WriteLine("  " + new string('-', 45));
            }

            ConsoleKeyInfo key = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Backspace");
                key = Console.ReadKey();
            }
            while (key.Key != ConsoleKey.Backspace);

            Console.WriteLine("\nMenüü suletud.");
        }

        static void LooMenuTxt()
        {
            string path = FailiAbi.Tee("Menuu.txt");
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, new string[]
                {
                    "Margherita pitsa;San Marzano tomatid, värske mozzarella, basiilik;8.50",
                    "Pasta Carbonara;Spagetid, guanciale, pecorino juust, muna;12.00",
                    "Tiramisu;Mascarpone, espresso, savoiardi küpsised;6.50"
                });
                Console.WriteLine("Loodud Menuu.txt.");
            }
        }
    }
}

