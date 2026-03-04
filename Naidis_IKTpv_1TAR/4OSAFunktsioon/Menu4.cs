using System;
using System.Text;

namespace Naidis_IKTpv_1TAR._4OSAFunktsioon
{
    public class Menu4
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n4. OSA - Failitootlus");
                Console.WriteLine("vali funktsioon:");
                Console.WriteLine("1. Faili kirjutamine (StreamWriter)");
                Console.WriteLine("2. Faili lugemine (StreamReader)");
                Console.WriteLine("3. Ridade lugemine listi (ReadAllLines)");
                Console.WriteLine("4. Listi muutmine ja kuvamine");
                Console.WriteLine("5. Otsing listist (Contains)");
                Console.WriteLine("6. Listi salvestamine faili (WriteAllLines)");
                Console.WriteLine("7. Ülesanne 1: Lemmiktoidu salvestamine");
                Console.WriteLine("8. Ülesanne 2: Menüü kuvamine");
                Console.WriteLine("9. Ülesanne 3: Koostisosade muutmine");
                Console.WriteLine("10. Ülesanne 4: Külmkapi kontroll");
                Console.WriteLine("11. Ülesanne 5: Salvestamine tagasi faili");
                Console.WriteLine("0. exit");

                string valik = Console.ReadLine();

                if (valik == "1")
                {
                    OSA4Funktsioon.FailiKirjutamine();
                }
                else if (valik == "2")
                {
                    OSA4Funktsioon.FailiLugemine();
                }
                else if (valik == "3")
                {
                    OSA4Funktsioon.ReadAllLinesNaide();
                }
                else if (valik == "4")
                {
                    OSA4Funktsioon.ListiMuutmine();
                }
                else if (valik == "5")
                {
                    OSA4Funktsioon.OtsigListist();
                }
                else if (valik == "6")
                {
                    OSA4Funktsioon.ListiSalvestamine();
                }
                else if (valik == "7")
                {
                    OSA4Funktsioon.LemmiktoiduSalvestamine();
                }
                else if (valik == "8")
                {
                    OSA4Funktsioon.MenüüKuvamine();
                }
                else if (valik == "9")
                {
                    OSA4Funktsioon.KoostisosadeMuutmine();
                }
                else if (valik == "10")
                {
                    OSA4Funktsioon.KülmkapiKontroll();
                }
                else if (valik == "11")
                {
                    OSA4Funktsioon.UuendatudSalvestamine();
                }
                else if (valik == "0")
                {
                    Console.WriteLine("Nägemist!");
                    break;
                }
                else
                {
                    Console.WriteLine("Palun vali 0-11");
                }
            }
        }
    }
}
