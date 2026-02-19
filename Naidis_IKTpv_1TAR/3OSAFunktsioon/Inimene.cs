using System;

namespace Naidis_IKTpv_1TAR._3OSAFunktsioon
{
    // Klass Inimene – ülesanne 3
    // Sisaldab nime ja vanust
    public class Inimene
    {
        public string Nimi;
        public int Vanus;

        public Inimene(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }

        public void Tervita()
        {
            Console.WriteLine("Tere, minu nimi on " + Nimi
                + " ja ma olen " + Vanus + " aastat vana.");
        }
    }
}
