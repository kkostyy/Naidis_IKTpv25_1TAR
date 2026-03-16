using System;
using System.Collections.Generic;
using System.IO;

namespace Naidis_IKTpv_1TAR._4OSAFunktsioon
{
    // Klass Retsept – hoiab retsepti nime ja koostisosade listi
    // Kasutatakse ülesannetes 3, 4, 5
    public class Retsept
    {
        public string Nimi;
        public List<string> Koostisosad;

        public Retsept(string nimi)
        {
            Nimi = nimi;
            Koostisosad = new List<string>();
        }

        // Lisa koostisosa listi
        public void Lisa(string koostisosa)
        {
            Koostisosad.Add(koostisosa);
        }

        // Eemalda koostisosa listist
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

        // Kontrolli kas koostisosa on olemas – ülesanne 4
        public bool OnOlemas(string koostisosa)
        {
            return Koostisosad.Contains(koostisosa);
        }

        // Kuva kogu retsept
        public void Kuva()
        {
            Console.WriteLine("Retsept: " + Nimi);
            foreach (string k in Koostisosad)
            {
                Console.WriteLine("  - " + k);
            }
        }

        // Lae koostisosad failist – ülesanne 3
        public void LaeFailed(string failinimi)
        {
            string path = FailiAbi.Tee(failinimi);
            Koostisosad.Clear();
            try
            {
                foreach (string rida in File.ReadAllLines(path))
                {
                    Koostisosad.Add(rida);
                }
                Console.WriteLine("Laetud " + Koostisosad.Count + " koostisosa.");
            }
            catch (Exception)
            {
                Console.WriteLine("Viga faili lugemisel!");
            }
        }

        // Salvesta koostisosad faili – ülesanne 5
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
