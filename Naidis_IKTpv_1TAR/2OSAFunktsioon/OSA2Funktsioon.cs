using System;

namespace Naidis_IKTpv_1TAR._2OSAFunktsioon
{
    public class OSA2Funktsioon
    {
        // Teooria näide – Juku if/else (otse teoriaraamatust)
        public static void JukuIfElse()
        {
            Console.WriteLine("Tere tulemast!");
            Console.WriteLine("Sisesta eesnimi: ");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);

            if (eesnimi.ToLower() == "juku")
            {
                Console.WriteLine("Tule minu juurde külla!");
            }
            else
            {
                Console.WriteLine("Täna mind kodus pole!");
            }

            Console.WriteLine("Sisesta esimene arv: ");
            int arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta teine arv: ");
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);
        }

        // Teooria näide – Kuu_nimetus switch (otse teoriaraamatust)
        public static void KuuNimetusDemo()
        {
            Console.WriteLine("Sisesta kuu number (1-12): ");
            int kuu_nr = int.Parse(Console.ReadLine());
            KuuKlass kuu = new KuuKlass(kuu_nr);
            Console.WriteLine("Kuu nimetus: " + kuu.Nimetus());
        }

        // Teooria näide – Hooaeg if/else if (otse teoriaraamatust)
        public static void HooaegDemo()
        {
            Console.WriteLine("Sisesta kuu number (1-12): ");
            int kuu_nr = int.Parse(Console.ReadLine());
            KuuKlass kuu = new KuuKlass(kuu_nr);
            Console.WriteLine("Kuu: " + kuu.Nimetus());
            Console.WriteLine("Hooaeg: " + kuu.Hooaeg());
        }

        // Ülesanne 1 – Juku kinno + piletiliik vanuse järgi
        // <6 tasuta | 6-14 lastepilet | 15-65 täispilet | >65 sooduspilet
        // <0 ja >100 viga
        public static void JukuKinno()
        {
            Console.WriteLine("Sisesta eesnimi: ");
            string nimi = Console.ReadLine();

            if (nimi.ToLower() == "juku")
            {
                Console.WriteLine("Lähme kinno, Juku!");

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Sisesta Juku vanus: ");
                        int vanus = int.Parse(Console.ReadLine());

                        if (vanus < 0 || vanus > 100)
                        {
                            Console.WriteLine("Viga andmetega! Vanus peab olema 0-100.");
                        }
                        else if (vanus < 6)
                        {
                            Console.WriteLine("Juku pilet: TASUTA (alla 6 aasta)");
                            break;
                        }
                        else if (vanus >= 6 && vanus <= 14)
                        {
                            Console.WriteLine("Juku pilet: LASTEPILET (6-14 aastat)");
                            break;
                        }
                        else if (vanus >= 15 && vanus <= 65)
                        {
                            Console.WriteLine("Juku pilet: TÄISPILET (15-65 aastat)");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Juku pilet: SOODUSPILET (üle 65 aasta)");
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Palun sisesta korrektne täisarv!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Täna mind kodus pole!");
            }
        }

        // Ülesanne 2 – Kaks inimest on pinginaabrid
        public static void Pinginaabrid()
        {
            Console.WriteLine("Sisesta 1. inimese nimi: ");
            string nimi1 = Console.ReadLine();
            Console.WriteLine("Sisesta 2. inimese nimi: ");
            string nimi2 = Console.ReadLine();

            Pinginaabriteklass paar = new Pinginaabriteklass(nimi1, nimi2);
            paar.Teata();
        }

        // Ülesanne 3 – Ristküliku pindala + remondi hind
        public static void Pindala()
        {
            Console.WriteLine("Sisesta toa pikkus (m): ");
            double pikk = double.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta toa laius (m): ");
            double laius = double.Parse(Console.ReadLine());

            Ruum ruum = new Ruum(pikk, laius);
            Console.WriteLine("Põranda pindala: " + ruum.Pindala() + " m2");

            Console.WriteLine("Kas soovid remonti teha? (jah/ei): ");
            string soov = Console.ReadLine();

            if (soov.ToLower() == "jah")
            {
                Console.WriteLine("Põrandamaterjali hind (€/m2): ");
                double hind = double.Parse(Console.ReadLine());
                Console.WriteLine("Põranda vahetamise koguhind: " + ruum.RemondiHind(hind) + " €");
            }
        }

        // Ülesanne 4 – 30% soodustusega alghind leidmine
        // soodushind = alghind * 0.70  =>  alghind = soodushind / 0.70
        public static void Soodus()
        {
            Console.WriteLine("Sisesta soodushind (30% soodustusega) €: ");
            double soodushind = double.Parse(Console.ReadLine());

            Hinnaklass hind = new Hinnaklass(soodushind, 30);
            Console.WriteLine("Alghind enne 30% soodustust: " + Math.Round(hind.Alghind(), 2) + " €");
        }

        // Ülesanne 5 – Temperatuur vs 18 kraadi (soovitav toasoojus)
        public static void Temperatuur()
        {
            Console.WriteLine("Sisesta temperatuur (°C): ");
            double temp = double.Parse(Console.ReadLine());

            if (temp > 18)
            {
                Console.WriteLine(temp + "°C - temperatuur on üle 18 kraadi. Tuba on soe!");
            }
            else if (temp == 18)
            {
                Console.WriteLine(temp + "°C - täpselt soovitav toatemperatuur.");
            }
            else
            {
                Console.WriteLine(temp + "°C - temperatuur on alla 18 kraadi. Tuba on jahe!");
            }
        }

        // Ülesanne 6 – Pikkuse hindamine (lühike / keskmine / pikk)
        public static void Pikkus()
        {
            Console.WriteLine("Sisesta pikkus (cm): ");
            double pikk = double.Parse(Console.ReadLine());

            if (pikk < 160)
            {
                Console.WriteLine("Sa oled lühike (alla 160 cm).");
            }
            else if (pikk >= 160 && pikk <= 180)
            {
                Console.WriteLine("Sa oled keskmise pikkusega (160-180 cm).");
            }
            else
            {
                Console.WriteLine("Sa oled pikk (üle 180 cm).");
            }
        }

        // Ülesanne 7 – Pikkus ja sugu (tingimusplokid üksteise sees)
        public static void PikkusJaSugu()
        {
            Console.WriteLine("Sisesta sugu (mees/naine): ");
            string sugu = Console.ReadLine().ToLower();
            Console.WriteLine("Sisesta pikkus (cm): ");
            double pikk = double.Parse(Console.ReadLine());

            if (sugu == "mees")
            {
                if (pikk < 170)
                {
                    Console.WriteLine("Lühike mees (alla 170 cm).");
                }
                else if (pikk >= 170 && pikk <= 185)
                {
                    Console.WriteLine("Keskmise pikkusega mees (170-185 cm).");
                }
                else
                {
                    Console.WriteLine("Pikk mees (üle 185 cm).");
                }
            }
            else if (sugu == "naine")
            {
                if (pikk < 158)
                {
                    Console.WriteLine("Lühike naine (alla 158 cm).");
                }
                else if (pikk >= 158 && pikk <= 172)
                {
                    Console.WriteLine("Keskmise pikkusega naine (158-172 cm).");
                }
                else
                {
                    Console.WriteLine("Pikk naine (üle 172 cm).");
                }
            }
            else
            {
                Console.WriteLine("Tundmatu sugu. Palun sisesta 'mees' või 'naine'.");
            }
        }

        // Ülesanne 8 – Pood: piim, sai, leib – hinnad kokku
        public static void Pood()
        {
            Ostukorv korv = new Ostukorv();

            Console.WriteLine("Kas soovid osta piima? (jah/ei): ");
            if (Console.ReadLine().ToLower() == "jah")
            {
                korv.LisaPiim();
            }

            Console.WriteLine("Kas soovid osta saia? (jah/ei): ");
            if (Console.ReadLine().ToLower() == "jah")
            {
                korv.LisaSai();
            }

            Console.WriteLine("Kas soovid osta leiba? (jah/ei): ");
            if (Console.ReadLine().ToLower() == "jah")
            {
                korv.LisaLeib();
            }

            korv.KuvaKokkuvõte();
        }
    }
}
