using System;
using System.Text;
using Naidis_IKTpv_1TAR._1OSAFunktsioon;
using Naidis_IKTpv_1TAR._2OSAFunktsioon;
using Naidis_IKTpv_1TAR._3OSAFunktsioon;
using Naidis_IKTpv_1TAR._4OSAFunktsioon;
using Naidis_IKTpv_1TAR._5OSAFunktsioon;

namespace Naidis_IKTpv_1TAR
{
    public class GlobalMenu
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n===== GLOBAALNE MENU =====");
                Console.WriteLine("1. OSA 1 - Pohikonstruktsioonid");
                Console.WriteLine("2. OSA 2 - Valikute konstruktsioonid");
                Console.WriteLine("3. OSA 3 - Kordused, massiivid ja klassid");
                Console.WriteLine("4. OSA 4 - Failitootlus");
                Console.WriteLine("5. OSA 5 - Kollektsioonid");
                Console.WriteLine("0. Välju");
                Console.Write("Vali OSA: ");

                string osa = Console.ReadLine();

                if (osa == "1")
                    Menu1.Main(null);
                else if (osa == "2")
                    Menu2.Main(null);
                else if (osa == "3")
                    Menu3.Main(null);
                else if (osa == "4")
                    Menu4.Main(null);
                else if (osa == "5")
                    Menu5.Main(null);
                else if (osa == "0")
                {
                    Console.WriteLine("Nagemist!");
                    break;
                }
                else
                    Console.WriteLine("Palun vali 0-5");
            }
        }
    }
}
