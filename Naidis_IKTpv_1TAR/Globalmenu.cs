using System;
using System.Text;
using Naidis_IKTpv_1TAR._1OSAFunktsioon;
using Naidis_IKTpv_1TAR._2OSAFunktsioon;
using Naidis_IKTpv_1TAR._3OSAFunktsioon;
using Naidis_IKTpv_1TAR._4OSAFunktsioon;

namespace Naidis_IKTpv_1TAR
{
    public class GlobalMenu
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n===== GLOBAALNE MENÜÜ =====");
                Console.WriteLine("1. OSA 1 - Menüü");
                Console.WriteLine("2. OSA 2 - Menüü");
                Console.WriteLine("3. OSA 3 - Menüü");
                Console.WriteLine("4. OSA 4 - Menüü");
                Console.WriteLine("0. Välju");
                Console.Write("Vali OSA: ");

                string osa = Console.ReadLine();

                if (osa == "1")
                {
                    Menu1.Main(null);
                }
                else if (osa == "2")
                {
                    Menu2.Main(null);
                }
                else if (osa == "3")
                {
                    Menu3.Main(null);
                }
                else if (osa == "4")
                {
                    Menu4.Main(null);
                }
                else if (osa == "0")
                {
                    Console.WriteLine("Nägemist!");
                    break;
                }
                else
                {
                    Console.WriteLine("Palun vali 0-4");
                }
            }
        }
    }
}
