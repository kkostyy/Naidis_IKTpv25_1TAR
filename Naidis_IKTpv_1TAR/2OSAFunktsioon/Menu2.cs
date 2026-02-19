using System;
using System.Text;

namespace Naidis_IKTpv_1TAR._2OSAFunktsioon
{
    public class Menu2
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n2. OSA - Valikute konstruktsioonid");
                Console.WriteLine("vali funktsioon:");
                Console.WriteLine("1. Juku (if/else)");
                Console.WriteLine("2. Kuu nimetus (switch)");
                Console.WriteLine("3. Hooaeg (if/else if)");
                Console.WriteLine("4. Juku kinno + piletiliik (sisestatud vanus)");
                Console.WriteLine("5. Pinginaabrid");
                Console.WriteLine("6. Ristküliku pindala ja remondi hind");
                Console.WriteLine("7. 30% soodustusega alghind");
                Console.WriteLine("8. Temperatuur (toasoojus)");
                Console.WriteLine("9. Pikkuse hindamine");
                Console.WriteLine("10. Pikkus ja sugu");
                Console.WriteLine("11. Pood (piim, sai, leib)");
                Console.WriteLine("12. exit");

                string valik = Console.ReadLine();

                if (valik == "1")
                {
                    OSA2Funktsioon.JukuIfElse();
                }
                else if (valik == "2")
                {
                    OSA2Funktsioon.KuuNimetusDemo();
                }
                else if (valik == "3")
                {
                    OSA2Funktsioon.HooaegDemo();
                }
                else if (valik == "4")
                {
                    OSA2Funktsioon.JukuKinno();
                }
                else if (valik == "5")
                {
                    OSA2Funktsioon.Pinginaabrid();
                }
                else if (valik == "6")
                {
                    OSA2Funktsioon.Pindala();
                }
                else if (valik == "7")
                {
                    OSA2Funktsioon.Soodus();
                }
                else if (valik == "8")
                {
                    OSA2Funktsioon.Temperatuur();
                }
                else if (valik == "9")
                {
                    OSA2Funktsioon.Pikkus();
                }
                else if (valik == "10")
                {
                    OSA2Funktsioon.PikkusJaSugu();
                }
                else if (valik == "11")
                {
                    OSA2Funktsioon.Pood();
                }
                else if (valik == "12")
                {
                    Console.WriteLine("Nägemist!");
                    break;
                }
                else
                {
                    Console.WriteLine("Palun vali 1-12");
                }
            }
        }
    }
}
