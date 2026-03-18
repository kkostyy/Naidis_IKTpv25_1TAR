using System;
using System.Collections.Generic;

namespace Naidis_IKTpv_1TAR._3OSAFunktsioon
{
    // Teooria näide – Isik klass
    public class Isik
    {
        public string Nimi;
        public int Vanus;

        public void Tervita()
        {
            Console.WriteLine("Tere, minu nimi on " + Nimi);
        }
    }

    // Ülesanne 3 – Inimene klass
    public class Inimene
    {
        public string Nimi;
        public int Vanus;

        public Inimene(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
    }

    // Ülesanne 1 – ArvuTootlus klass
    public class ArvuTootlus
    {
        static Random rnd = new Random();

        public static int[] GenereeriRuudud(int min, int max)
        {
            int N = rnd.Next(min, max + 1);
            int M = rnd.Next(min, max + 1);

            Console.WriteLine("Genereeritud N = " + N + ", M = " + M);

            int algus = Math.Min(N, M);
            int lopp = Math.Max(N, M);

            int suurus = lopp - algus + 1;
            int[] massiiv = new int[suurus];

            for (int i = algus; i <= lopp; i++)
            {
                massiiv[i - algus] = i * i;
            }

            return massiiv;
        }
    }
}
