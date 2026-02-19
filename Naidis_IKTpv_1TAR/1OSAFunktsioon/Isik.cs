using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_IKTpv_1TAR._1OSAFunktsioon
{
    // Klass Isik esindab inimest koos nime ja vanusega
    public class Isik
    {
        // Väljad (fields)
        public string Nimi;
        public int Vanus;

        // Konstruktor – luuakse uus Isik nimega ja vanusega
        public Isik(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }

        // Tühi konstruktor – vaikimisi
        public Isik()
        {
            Nimi = "Tundmatu";
            Vanus = 0;
        }

        // Meetod: tervitab isikut
        public void Tervita()
        {
            Console.WriteLine("Tere, minu nimi on " + Nimi + "!");
        }

        // Meetod: kuvab kogu info
        public void KuvaInfo()
        {
            Console.WriteLine("Nimi: " + Nimi + ", Vanus: " + Vanus + " aastat");
        }
    }
}

