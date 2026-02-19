using System;
using System.Text;

namespace Naidis_IKTpv_1TAR._1OSAFunktsioon
{
    public class Menu1
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n1. OSA - Pohikonstruktsioonid");
                Console.WriteLine("vali funktsioon:");
                Console.WriteLine("1. Tervitus");
                Console.WriteLine("2. Tervitus nimega");
                Console.WriteLine("3. Korrutamine (2 arvu)");
                Console.WriteLine("4. Liitmine (kasutab Arvutaja klassi)");
                Console.WriteLine("5. Lahutamine (kasutab Arvutaja klassi)");
                Console.WriteLine("6. Jagamine (kasutab Arvutaja klassi)");
                Console.WriteLine("7. Isiku loomine (kasutab Isik klassi)");
                Console.WriteLine("8. exit");

                string valik = Console.ReadLine();

                if (valik == "1")
                {
                    OSA1Funktsioon.Tervitus();
                }
                else if (valik == "2")
                {
                    OSA1Funktsioon.TervitusNimega();
                }
                else if (valik == "3")
                {
                    OSA1Funktsioon.Korrutamine();
                }
                else if (valik == "4")
                {
                    OSA1Funktsioon.Liitmine();
                }
                else if (valik == "5")
                {
                    OSA1Funktsioon.Lahutamine();
                }
                else if (valik == "6")
                {
                    OSA1Funktsioon.Jagamine();
                }
                else if (valik == "7")
                {
                    OSA1Funktsioon.IsikuLoomine();
                }
                else if (valik == "8")
                {
                    Console.WriteLine("Nägemist!");
                    break;
                }
                else
                {
                    Console.WriteLine("Palun vali 1-8");
                }
            }
        }
    }
}
