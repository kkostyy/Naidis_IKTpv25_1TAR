using System;
using System.Collections.Generic;
using System.IO;

namespace Naidis_IKTpv_1TAR._4OSAFunktsioon
{
    public class FailiAbi
    {
        public static string Tee(string failinimi)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, failinimi);
        }

        public static bool OnOlemas(string failinimi)
        {
            return File.Exists(Tee(failinimi));
        }

        public static void LooKuiPuudub(string failinimi, string[] vaikimisiRead)
        {
            string path = Tee(failinimi);
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, vaikimisiRead);
                Console.WriteLine("Loodud: " + failinimi);
            }
        }
    }

    public class Retsept
    {
        public string Nimi;
        public List<string> Koostisosad;

        public Retsept(string nimi)
        {
            Nimi = nimi;
            Koostisosad = new List<string>();
        }

        public void Lisa(string koostisosa)
        {
            Koostisosad.Add(koostisosa);
        }

        public void Eemalda(string koostisosa)
        {
            if (Koostisosad.Contains(koostisosa))
            {
                Koostisosad.Remove(koostisosa);
                Console.WriteLine("\"" + koostisosa + "\" eemaldatud.");
            }
            else
            {
                Console.WriteLine("\"" + koostisosa + "\" ei ole retseptis.");
            }
        }

        public bool OnOlemas(string koostisosa)
        {
            return Koostisosad.Contains(koostisosa);
        }

        public void Kuva()
        {
            Console.WriteLine("Retsept: " + Nimi);
            foreach (string k in Koostisosad)
                Console.WriteLine("  - " + k);
        }

        public void LaeFailed(string failinimi)
        {
            string path = FailiAbi.Tee(failinimi);
            Koostisosad.Clear();
            try
            {
                foreach (string rida in File.ReadAllLines(path))
                    Koostisosad.Add(rida);
                Console.WriteLine("Laetud " + Koostisosad.Count + " koostisosa.");
            }
            catch (Exception)
            {
                Console.WriteLine("Viga faili lugemisel!");
            }
        }

        public void Salvesta(string failinimi)
        {
            string path = FailiAbi.Tee(failinimi);
            try
            {
                File.WriteAllLines(path, Koostisosad);
                Console.WriteLine("Uus retsept on edukalt faili salvestatud!");
            }
            catch (Exception)
            {
                Console.WriteLine("Viga salvestamisel!");
            }
        }
    }
}
