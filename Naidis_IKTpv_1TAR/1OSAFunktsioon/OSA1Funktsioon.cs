using System;

namespace Naidis_IKTpv_1TAR._1OSAFunktsioon
{
    public class OSA1Funktsioon
    {
        public static void Tervitus()
        {
            Console.WriteLine("Tere tulemast!");
        }

        public static void TervitusNimega()
        {
            Console.WriteLine("Tere tulemast!");
            Console.Write("Sisesta oma nimi: ");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);
        }

        public static void Korrutamine()
        {
            Console.Write("Sisesta oma nimi: ");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);

            Console.Write("Sisesta esimene arv: ");
            int arv1 = int.Parse(Console.ReadLine());

            Console.Write("Sisesta teine arv: ");
            int arv2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);
        }

        public static void Liitmine()
        {
            Console.Write("Sisesta esimene arv: ");
            float arv1 = float.Parse(Console.ReadLine());

            Console.Write("Sisesta teine arv: ");
            float arv2 = float.Parse(Console.ReadLine());

            float tulemus = Arvutaja.Liida(arv1, arv2);
            Console.WriteLine(arv1 + " + " + arv2 + " = " + tulemus);
        }

        public static void Lahutamine()
        {
            Console.Write("Sisesta esimene arv: ");
            float arv1 = float.Parse(Console.ReadLine());

            Console.Write("Sisesta teine arv: ");
            float arv2 = float.Parse(Console.ReadLine());

            float tulemus = Arvutaja.Lahuta(arv1, arv2);
            Console.WriteLine(arv1 + " - " + arv2 + " = " + tulemus);
        }

        public static void Jagamine()
        {
            Console.Write("Sisesta esimene arv: ");
            float arv1 = float.Parse(Console.ReadLine());

            Console.Write("Sisesta teine arv: ");
            float arv2 = float.Parse(Console.ReadLine());

            if (arv2 == 0)
            {
                Console.WriteLine("Viga: nulliga jagamine ei ole võimalik!");
            }
            else
            {
                float tulemus = Arvutaja.Jaga(arv1, arv2);
                Console.WriteLine(arv1 + " / " + arv2 + " = " + tulemus);
            }
        }

        public static void IsikuLoomine()
        {
            Console.Write("Sisesta nimi: ");
            string nimi = Console.ReadLine();

            Console.Write("Sisesta vanus: ");
            int vanus = int.Parse(Console.ReadLine());

            Isik uusIsik = new Isik(nimi, vanus);
            uusIsik.Tervita();
            uusIsik.KuvaInfo();
        }
    }
}
