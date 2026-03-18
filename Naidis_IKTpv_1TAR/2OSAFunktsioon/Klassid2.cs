using System;

namespace Naidis_IKTpv_1TAR._2OSAFunktsioon
{
    public class Hinnaklass
    {
        public double Soodushind;
        public double SoodustusProtsent;

        public Hinnaklass(double soodushind, double soodustusProtsent)
        {
            Soodushind = soodushind;
            SoodustusProtsent = soodustusProtsent;
        }

        public double Alghind()
        {
            double koefitsient = 1.0 - (SoodustusProtsent / 100.0);
            return Soodushind / koefitsient;
        }
    }

    public class Ruum
    {
        public double Pikkus;
        public double Laius;

        public Ruum(double pikkus, double laius)
        {
            Pikkus = pikkus;
            Laius = laius;
        }

        public double Pindala()
        {
            return Pikkus * Laius;
        }

        public double RemondiHind(double ruutmeetrihind)
        {
            return Pindala() * ruutmeetrihind;
        }
    }

    public class Pinginaabriteklass
    {
        public string Nimi1;
        public string Nimi2;

        public Pinginaabriteklass(string nimi1, string nimi2)
        {
            Nimi1 = nimi1;
            Nimi2 = nimi2;
        }

        public void Teata()
        {
            Console.WriteLine("Taana on pinginaabrid " + Nimi1 + " ja " + Nimi2 + "!");
        }
    }

    public class Ostukorv
    {
        private const double PiimHind = 1.20;
        private const double SaiHind = 0.80;
        private const double LeibHind = 1.50;

        private bool onPiim = false;
        private bool onSai = false;
        private bool onLeib = false;

        public void LisaPiim() { onPiim = true; }
        public void LisaSai()  { onSai  = true; }
        public void LisaLeib() { onLeib = true; }

        public double Koguhind()
        {
            double kokku = 0;
            if (onPiim) kokku += PiimHind;
            if (onSai)  kokku += SaiHind;
            if (onLeib) kokku += LeibHind;
            return kokku;
        }

        public void KuvaKokkuvote()
        {
            Console.WriteLine("\n--- Ostukorv ---");
            if (onPiim) Console.WriteLine("Piim:  " + PiimHind + " EUR");
            if (onSai)  Console.WriteLine("Sai:   " + SaiHind  + " EUR");
            if (onLeib) Console.WriteLine("Leib:  " + LeibHind + " EUR");

            if (!onPiim && !onSai && !onLeib)
                Console.WriteLine("Ostukorv on tuhi.");
            else
                Console.WriteLine("Kokku maksta: " + Koguhind() + " EUR");
        }
    }
}
