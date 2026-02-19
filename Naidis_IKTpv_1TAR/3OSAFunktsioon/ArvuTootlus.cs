using System;

namespace Naidis_IKTpv_1TAR._3OSAFunktsioon
{
    // Klass ArvuTootlus – ülesanne 1
    // Genereerib 2 juhuslikku arvu N ja M, leiab nende vahel
    // kõik täisarvud ja tagastab massiivi nende ruutudega
    public class ArvuTootlus
    {
        static Random rnd = new Random();

        public static int[] GenereeriRuudud(int min, int max)
        {
            // Genereerime kaks juhuslikku arvu
            int N = rnd.Next(min, max + 1);
            int M = rnd.Next(min, max + 1);

            Console.WriteLine("Genereeritud N = " + N + ", M = " + M);

            // Leiame väiksema ja suurema
            int algus = Math.Min(N, M);
            int lopp = Math.Max(N, M);

            // Loome massiivi: kõik täisarvud algusest lõpuni
            int suurus = lopp - algus + 1;
            int[] massiiv = new int[suurus];

            for (int i = algus; i <= lopp; i++)
            {
                massiiv[i - algus] = i * i;  // ruut
            }

            return massiiv;
        }
    }
}
