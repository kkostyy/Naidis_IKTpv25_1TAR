using System;

namespace Naidis_IKTpv_1TAR._3OSAFunktsioon
{
    // Klass Isik – teooria näide (otse teoriaraamatust)
    // Kasutatakse TeooriaIsikKlassJaList() meetodis
    public class Isik
    {
        public string Nimi;
        public int Vanus;

        public void Tervita()
        {
            Console.WriteLine("Tere, minu nimi on " + Nimi);
        }
    }
}
