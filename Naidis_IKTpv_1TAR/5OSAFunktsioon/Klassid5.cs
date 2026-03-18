using System;
using System.Collections.Generic;

namespace Naidis_IKTpv_1TAR._5OSAFunktsioon
{
    // Ülesanne 1
    public class Toode
    {
        public string Nimi;
        public double Kalorid100g;

        public Toode(string nimi, double kalorid100g)
        {
            Nimi = nimi;
            Kalorid100g = kalorid100g;
        }
    }

    public class Inimene
    {
        public string Nimi;
        public int Vanus;
        public string Sugu;
        public double Pikkus;
        public double Kaal;
        public int Aktiivsustase;

        public Inimene(string nimi, int vanus, string sugu, double pikkus, double kaal, int aktiivsustase)
        {
            Nimi = nimi;
            Vanus = vanus;
            Sugu = sugu;
            Pikkus = pikkus;
            Kaal = kaal;
            Aktiivsustase = aktiivsustase;
        }

        // Harris-Benedict valem
        public double ArvutaPaevaneKalorivajadus()
        {
            double bmr;
            if (Sugu.ToUpper() == "M")
                bmr = 88.36 + (13.4 * Kaal) + (4.8 * Pikkus) - (5.7 * Vanus);
            else
                bmr = 447.6 + (9.2 * Kaal) + (3.1 * Pikkus) - (4.3 * Vanus);

            double[] kordajad = { 0, 1.2, 1.375, 1.55, 1.725, 1.9 };
            int tase = Math.Max(1, Math.Min(5, Aktiivsustase));
            return bmr * kordajad[tase];
        }
    }

    // Ülesanne 3
    public class Opilane
    {
        public string Nimi;
        public List<int> Hinded;

        public Opilane(string nimi)
        {
            Nimi = nimi;
            Hinded = new List<int>();
        }

        public double Keskmine()
        {
            if (Hinded.Count == 0) return 0;
            double summa = 0;
            foreach (int h in Hinded)
                summa += h;
            return summa / Hinded.Count;
        }
    }

    // Ülesanne 4
    public class Film
    {
        public string Pealkiri;
        public int Aasta;
        public string Zanr;

        public Film(string pealkiri, int aasta, string zanr)
        {
            Pealkiri = pealkiri;
            Aasta = aasta;
            Zanr = zanr;
        }
    }

    // Ülesanne 6
    public class Lemmikloom
    {
        public string Nimi;
        public string Liik;
        public int Vanus;

        public Lemmikloom(string nimi, string liik, int vanus)
        {
            Nimi = nimi;
            Liik = liik;
            Vanus = vanus;
        }
    }

    // Ülesanne 7
    public class Valuuta
    {
        public string Nimetus;
        public double KurssEurSuhtes;

        public Valuuta(string nimetus, double kurssEurSuhtes)
        {
            Nimetus = nimetus;
            KurssEurSuhtes = kurssEurSuhtes;
        }
    }
}
