using System;

namespace Naidis_IKTpv_1TAR._2OSAFunktsioon
{
    public class OSA2Funktsioon
    {
        // Teooria – Juku if/else
        public static void JukuIfElse()
        {
            Console.Write("Sisesta eesnimi: ");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);

            if (eesnimi.ToLower() == "juku")
                Console.WriteLine("Tule minu juurde kulla!");
            else
                Console.WriteLine("Taana mind kodus pole!");

            Console.Write("Sisesta esimene arv: ");
            int arv1 = int.Parse(Console.ReadLine());

            Console.Write("Sisesta teine arv: ");
            int arv2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);
        }

        // Teooria – Kuu nimetus switch
        public static void KuuNimetusDemo()
        {
            Console.Write("Sisesta kuu number (1-12): ");
            int kuuNr = int.Parse(Console.ReadLine());
            KuuKlass kuu = new KuuKlass(kuuNr);
            Console.WriteLine("Kuu nimetus: " + kuu.Nimetus());
        }

        // Teooria – Hooaeg if/else if
        public static void HooaegDemo()
        {
            Console.Write("Sisesta kuu number (1-12): ");
            int kuuNr = int.Parse(Console.ReadLine());
            KuuKlass kuu = new KuuKlass(kuuNr);
            Console.WriteLine("Kuu: " + kuu.Nimetus());
            Console.WriteLine("Hooaeg: " + kuu.Hooaeg());
        }

        // Ülesanne 1 – Juku kinno
        public static void JukuKinno()
        {
            Console.Write("Sisesta eesnimi: ");
            string nimi = Console.ReadLine();

            if (nimi.ToLower() != "juku")
            {
                Console.WriteLine("Taana mind kodus pole!");
                return;
            }

            Console.WriteLine("Lahme kinno, Juku!");

            while (true)
            {
                try
                {
                    Console.Write("Sisesta Juku vanus: ");
                    int vanus = int.Parse(Console.ReadLine());

                    if (vanus < 0 || vanus > 100)
                        Console.WriteLine("Viga! Vanus peab olema 0-100.");
                    else if (vanus < 6)
                    {
                        Console.WriteLine("Pilet: TASUTA (alla 6 aasta)");
                        break;
                    }
                    else if (vanus <= 14)
                    {
                        Console.WriteLine("Pilet: LASTEPILET (6-14 aastat)");
                        break;
                    }
                    else if (vanus <= 65)
                    {
                        Console.WriteLine("Pilet: TAISPILET (15-65 aastat)");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Pilet: SOODUSPILET (ule 65 aasta)");
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Palun sisesta korrektne taisarv!");
                }
            }
        }

        // Ülesanne 2 – Pinginaabrid
        public static void Pinginaabrid()
        {
            Console.Write("Sisesta 1. inimese nimi: ");
            string nimi1 = Console.ReadLine();

            Console.Write("Sisesta 2. inimese nimi: ");
            string nimi2 = Console.ReadLine();

            Pinginaabriteklass paar = new Pinginaabriteklass(nimi1, nimi2);
            paar.Teata();
        }

        // Ülesanne 3 – Ristküliku pindala ja remondi hind
        public static void Pindala()
        {
            Console.Write("Sisesta toa pikkus (m): ");
            double pikk = double.Parse(Console.ReadLine());

            Console.Write("Sisesta toa laius (m): ");
            double laius = double.Parse(Console.ReadLine());

            Ruum ruum = new Ruum(pikk, laius);
            Console.WriteLine("Poranda pindala: " + ruum.Pindala() + " m2");

            Console.Write("Kas soovid remonti teha? (jah/ei): ");
            string soov = Console.ReadLine();

            if (soov.ToLower() == "jah")
            {
                Console.Write("Porandamaterjali hind (EUR/m2): ");
                double hind = double.Parse(Console.ReadLine());
                Console.WriteLine("Koguhind: " + ruum.RemondiHind(hind) + " EUR");
            }
        }

        // Ülesanne 4 – 30% soodustusega alghind
        public static void Soodus()
        {
            Console.Write("Sisesta soodushind (30% soodustusega) EUR: ");
            double soodushind = double.Parse(Console.ReadLine());

            Hinnaklass hind = new Hinnaklass(soodushind, 30);
            Console.WriteLine("Alghind enne 30% soodustust: " + Math.Round(hind.Alghind(), 2) + " EUR");
        }

        // Ülesanne 5 – Temperatuur
        public static void Temperatuur()
        {
            Console.Write("Sisesta temperatuur (kraadi): ");
            double temp = double.Parse(Console.ReadLine());

            if (temp >= 18)
                Console.WriteLine(temp + " kraadi - tuba on piisavalt soe.");
            else
                Console.WriteLine(temp + " kraadi - liiga kulm! Soovitav minimum on 18 kraadi.");
        }

        // Ülesanne 6 – Pikkuse hindamine
        public static void Pikkus()
        {
            Console.Write("Sisesta pikkus (cm): ");
            double pikk = double.Parse(Console.ReadLine());

            if (pikk < 160)
                Console.WriteLine("Sa oled luhike (alla 160 cm).");
            else if (pikk <= 180)
                Console.WriteLine("Sa oled keskmise pikkusega (160-180 cm).");
            else
                Console.WriteLine("Sa oled pikk (ule 180 cm).");
        }

        // Ülesanne 7 – Pikkus ja sugu
        public static void PikkusJaSugu()
        {
            Console.Write("Sisesta sugu (mees/naine): ");
            string sugu = Console.ReadLine().ToLower();

            Console.Write("Sisesta pikkus (cm): ");
            double pikk = double.Parse(Console.ReadLine());

            if (sugu == "mees")
            {
                if (pikk < 170)
                    Console.WriteLine("Luhike mees (alla 170 cm).");
                else if (pikk <= 185)
                    Console.WriteLine("Keskmise pikkusega mees (170-185 cm).");
                else
                    Console.WriteLine("Pikk mees (ule 185 cm).");
            }
            else if (sugu == "naine")
            {
                if (pikk < 158)
                    Console.WriteLine("Luhike naine (alla 158 cm).");
                else if (pikk <= 172)
                    Console.WriteLine("Keskmise pikkusega naine (158-172 cm).");
                else
                    Console.WriteLine("Pikk naine (ule 172 cm).");
            }
            else
            {
                Console.WriteLine("Tundmatu sugu. Palun sisesta 'mees' voi 'naine'.");
            }
        }

        // Ülesanne 8 – Pood
        public static void Pood()
        {
            Ostukorv korv = new Ostukorv();

            Console.Write("Kas soovid osta piima? (jah/ei): ");
            if (Console.ReadLine().ToLower() == "jah")
                korv.LisaPiim();

            Console.Write("Kas soovid osta saia? (jah/ei): ");
            if (Console.ReadLine().ToLower() == "jah")
                korv.LisaSai();

            Console.Write("Kas soovid osta leiba? (jah/ei): ");
            if (Console.ReadLine().ToLower() == "jah")
                korv.LisaLeib();

            korv.KuvaKokkuvote();
        }
    }
}
