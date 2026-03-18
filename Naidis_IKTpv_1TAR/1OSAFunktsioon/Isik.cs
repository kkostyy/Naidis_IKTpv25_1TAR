using System;

namespace Naidis_IKTpv_1TAR._1OSAFunktsioon
{
    public class Isik
    {
        public string Nimi;
        public int Vanus;

        public Isik(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }

        public Isik()
        {
            Nimi = "Tundmatu";
            Vanus = 0;
        }

        public void Tervita()
        {
            Console.WriteLine("Tere, minu nimi on " + Nimi + "!");
        }

        public void KuvaInfo()
        {
            Console.WriteLine("Nimi: " + Nimi + ", Vanus: " + Vanus + " aastat");
        }
    }
}
