using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Naidis_IKTpv_1TAR._4OSAFunktsioon
{
    public class OSA4Funktsioon
    {
        static string KuudPath       = FailiAbi.Tee("Kuud.txt");
        static string RetseptidPath  = FailiAbi.Tee("Retseptid.txt");
        static string KoostisosadPath = FailiAbi.Tee("Koostisosad.txt");

        // Teooria 1 – Faili kirjutamine StreamWriter
        public static void FailiKirjutamine()
        {
            try
            {
                StreamWriter sw = new StreamWriter(KuudPath, true);
                Console.Write("Sisesta tekst: ");
                sw.WriteLine(Console.ReadLine());
                sw.Close();
                Console.WriteLine("Salvestatud.");
            }
            catch (Exception)
            {
                Console.WriteLine("Viga faili kirjutamisel!");
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
                Console.WriteLine("Viga faili lugemisel!");
            }
        }

        // Teooria 3 – Ridade lugemine listi
        public static void ReadAllLinesNaide()
        {
            LooKuudTxt();
            List<string> list = new List<string>();
            try
            {
                foreach (string rida in File.ReadAllLines(KuudPath))
                    list.Add(rida);
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
                return;
            }
            foreach (string kuu in list)
                Console.WriteLine(kuu);
        }

        // Teooria 4 – Listi muutmine
        public static void ListiMuutmine()
        {
            LooKuudTxt();
            List<string> list = new List<string>();
            try
            {
                foreach (string rida in File.ReadAllLines(KuudPath))
                    list.Add(rida);
            }
            catch (Exception)
            {
                Console.WriteLine("Viga faili lugemisel!");
                return;
            }

            Console.WriteLine("--- Algne nimekiri ---");
            foreach (string kuu in list)
                Console.WriteLine(kuu);

            list.Remove("Juuni");
            if (list.Count > 0)
                list[0] = "Veeel kuuu";

            Console.WriteLine("--- Pärast muutmist ---");
            foreach (string kuu in list)
                Console.WriteLine(kuu);
        }

        // Teooria 5 – Otsing listist
        public static void OtsigListist()
        {
            LooKuudTxt();
            List<string> list = new List<string>();
            try
            {
                foreach (string rida in File.ReadAllLines(KuudPath))
                    list.Add(rida);
            }
            catch (Exception)
            {
                Console.WriteLine("Viga faili lugemisel!");
                return;
            }

            Console.Write("Sisesta kuu nimi: ");
            string otsitav = Console.ReadLine();

            if (list.Contains(otsitav))
                Console.WriteLine("Kuu " + otsitav + " on olemas.");
            else
                Console.WriteLine("Sellist kuud pole.");
        }

        // Teooria 6 – Listi salvestamine faili
        public static void ListiSalvestamine()
        {
            List<string> list = new List<string>()
            {
                "Jaanuar", "Veebruar", "Märts", "Aprill", "Mai",
                "Juuli", "August", "September", "Oktoober", "November", "Detsember"
            };
            try
            {
                File.WriteAllLines(KuudPath, list);
                Console.WriteLine("Andmed on salvestatud.");
            }
            catch (Exception)
            {
                Console.WriteLine("Viga salvestamisel!");
            }
        }

        // Ülesanne 1 – Lemmiktoidu salvestamine
        public static void LemmiktoiduSalvestamine()
        {
            try
            {
                StreamWriter sw = new StreamWriter(RetseptidPath, true);
                Console.Write("Sisesta Itaalia toidu nimi: ");
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

        // Ülesanne 2 – Menüü kuvamine
        public static void MenüüKuvamine()
        {
            try
            {
                StreamReader sr = new StreamReader(RetseptidPath);
                string sisu = sr.ReadToEnd();
                sr.Close();
                Console.WriteLine("--- Retseptid.txt ---");
                Console.WriteLine(sisu);
            }
            catch (Exception)
            {
                Console.WriteLine("Viga faili lugemisel!");
            }
        }

        // Ülesanne 3 – Koostisosade muutmine
        public static void KoostisosadeMuutmine()
        {
            LooKoostisosadTxt();
            Retsept retsept = new Retsept("Minu retsept");
            retsept.LaeFailed("Koostisosad.txt");

            Console.WriteLine("--- Algne ---");
            retsept.Kuva();

            if (retsept.Koostisosad.Count > 0)
                retsept.Koostisosad[0] = "Kvaliteetne oliiviõli";

            retsept.Eemalda("Ketsup");

            Console.WriteLine("--- Uuendatud ---");
            retsept.Kuva();
        }

        // Ülesanne 4 – Külmkapi kontroll
        public static void KülmkapiKontroll()
        {
            LooKoostisosadTxt();
            Retsept retsept = new Retsept("Minu retsept");
            retsept.LaeFailed("Koostisosad.txt");

            Console.Write("Sisesta koostisosa nimi: ");
            string otsitav = Console.ReadLine();

            if (retsept.OnOlemas(otsitav))
                Console.WriteLine("Koostisosa on olemas!");
            else
                Console.WriteLine("Seda koostisosa meil retseptis ei ole.");
        }

        // Ülesanne 5 – Salvestamine tagasi faili
        public static void UuendatudSalvestamine()
        {
            LooKoostisosadTxt();
            Retsept retsept = new Retsept("Minu retsept");
            retsept.LaeFailed("Koostisosad.txt");

            if (retsept.Koostisosad.Count > 0)
                retsept.Koostisosad[0] = "Kvaliteetne oliiviõli";
            retsept.Eemalda("Ketsup");
            retsept.Salvesta("Koostisosad.txt");
        }

        // Ülesanne 6 – Itaalia restorani menüü
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
                        string roaNimi    = osad[0].Trim();
                        string koostisosad = osad[1].Trim();
                        double hind       = double.Parse(osad[2].Trim(), CultureInfo.InvariantCulture);
                        menyyList.Add(Tuple.Create(roaNimi, koostisosad, hind));
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga faili lugemisel!");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("  ITAALIA RESTORAN");
            Console.WriteLine();

            foreach (Tuple<string, string, double> roog in menyyList)
            {
                Console.WriteLine("  " + roog.Item1.PadRight(33) + roog.Item3.ToString("F2") + " EUR");
                Console.WriteLine("    " + roog.Item2);
                Console.WriteLine("  " + new string('-', 45));
            }

            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Vajuta Backspace väljumiseks");
                key = Console.ReadKey();
            }
            while (key.Key != ConsoleKey.Backspace);
            Console.WriteLine();
        }

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

        static void LooMenuTxt()
        {
            string path = FailiAbi.Tee("Menuu.txt");
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, new string[]
                {
                    "Margherita pitsa;San Marzano tomatid, mozzarella, basiilik;8.50",
                    "Pasta Carbonara;Spagetid, guanciale, pecorino juust, muna;12.00",
                    "Tiramisu;Mascarpone, espresso, savoiardi küpsised;6.50"
                });
                Console.WriteLine("Loodud Menuu.txt.");
            }
        }
    }
}
