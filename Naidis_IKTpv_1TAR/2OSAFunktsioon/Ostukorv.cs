using System;

namespace Naidis_IKTpv_1TAR._2OSAFunktsioon
{
    // Klass Ostukorv – hoiab poest ostetud tooteid ja arvutab koguhinna
    public class Ostukorv
    {
        // Tooted ja nende hinnad
        private const double PiimHind = 1.20;
        private const double SaiHind = 0.80;
        private const double LeibHind = 1.50;

        // Ostukorvi sisu
        private bool onPiim = false;
        private bool onSai = false;
        private bool onLeib = false;

        public void LisaPiim()
        {
            onPiim = true;
        }

        public void LisaSai()
        {
            onSai = true;
        }

        public void LisaLeib()
        {
            onLeib = true;
        }

        // Arvutab koguhinna
        public double Koguhind()
        {
            double kokku = 0;
            if (onPiim) kokku += PiimHind;
            if (onSai) kokku += SaiHind;
            if (onLeib) kokku += LeibHind;
            return kokku;
        }

        // Kuvab ostukorvi kokkuvõtte
        public void KuvaKokkuvõte()
        {
            Console.WriteLine("\n--- Ostukorv ---");
            if (onPiim) Console.WriteLine("Piim:  " + PiimHind + " €");
            if (onSai) Console.WriteLine("Sai:   " + SaiHind + " €");
            if (onLeib) Console.WriteLine("Leib:  " + LeibHind + " €");
            Console.WriteLine("Kokku maksta: " + Koguhind() + " €");

            if (!onPiim && !onSai && !onLeib)
            {
                Console.WriteLine("Ostukorv on tühi.");
            }
        }
    }
}

