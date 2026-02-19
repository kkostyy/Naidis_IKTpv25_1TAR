using System;

namespace Naidis_IKTpv_1TAR._1OSAFunktsioon
{
    public class OSA1Funktsioon
    {
        // Lühim tervikprogramm – lihtsalt tervitus
        public static void Tervitus()
        {
            Console.WriteLine("Tere tulemast!");
        }

        // Muutuja tekstilises formaadis – küsime nime ja tervitame
        public static void TervitusNimega()
        {
            Console.WriteLine("Tere tulemast!");
            Console.WriteLine("Sisesta oma nimi: ");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);
        }

        // Arvutamine – küsime 2 arvu ja korrutame
        public static void Korrutamine()
        {
            Console.WriteLine("Tere tulemast!");
            Console.WriteLine("Sisesta oma nimi: ");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);

            Console.WriteLine("Sisesta esimene arv: ");
            int arv1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta teine arv: ");
            int arv2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);
        }

        // Liitmine – kasutab Arvutaja klassi
        public static void Liitmine()
        {
            Console.WriteLine("Sisesta esimene arv: ");
            float arv1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta teine arv: ");
            float arv2 = float.Parse(Console.ReadLine());

            float tulemus = Arvutaja.Liida(arv1, arv2);
            Console.WriteLine(arv1 + " + " + arv2 + " = " + tulemus);
        }

        // Lahutamine – kasutab Arvutaja klassi
        public static void Lahutamine()
        {
            Console.WriteLine("Sisesta esimene arv: ");
            float arv1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta teine arv: ");
            float arv2 = float.Parse(Console.ReadLine());

            float tulemus = Arvutaja.Lahuta(arv1, arv2);
            Console.WriteLine(arv1 + " - " + arv2 + " = " + tulemus);
        }

        // Jagamine – kasutab Arvutaja klassi (kontroll nulliga jagamise vastu)
        public static void Jagamine()
        {
            Console.WriteLine("Sisesta esimene arv: ");
            float arv1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta teine arv: ");
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

        // Isiku loomine – kasutab Isik klassi
        public static void IsikuLoomine()
        {
            Console.WriteLine("Sisesta nimi: ");
            string nimi = Console.ReadLine();

            Console.WriteLine("Sisesta vanus: ");
            int vanus = int.Parse(Console.ReadLine());

            // Loome uue Isik objekti
            Isik uusIsik = new Isik(nimi, vanus);

            // Kutsume välja klassi meetodeid
            uusIsik.Tervita();
            uusIsik.KuvaInfo();
        }
    }
}
