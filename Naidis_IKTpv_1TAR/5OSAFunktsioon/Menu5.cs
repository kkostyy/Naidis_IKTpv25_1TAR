using System;
using System.Text;

namespace Naidis_IKTpv_1TAR._5OSAFunktsioon
{
    public class Menu5
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n5. OSA - Kollektsioonid: Listid ja sõnastikud");
                Console.WriteLine("vali funktsioon:");
                Console.WriteLine("--- Teooria näited ---");
                Console.WriteLine("1. ArrayList näide");
                Console.WriteLine("2. Tuple näide");
                Console.WriteLine("3. List<T> näide");
                Console.WriteLine("4. LinkedList näide");
                Console.WriteLine("5. Dictionary näide");
                Console.WriteLine("--- Ülesanded ---");
                Console.WriteLine("6. Ülesanne 1: Kalorite kalkulaator");
                Console.WriteLine("7. Ülesanne 2: Maakonnad ja pealinnad (sõnastik + mäng)");
                Console.WriteLine("8. Ülesanne 3: Õpilased ja hinnete analüüs");
                Console.WriteLine("9. Ülesanne 4: Filmide kogu");
                Console.WriteLine("10. Ülesanne 5: Arvude massiivi statistika");
                Console.WriteLine("11. Ülesanne 6: Lemmikloomade register");
                Console.WriteLine("12. Ülesanne 7: Valuutakalkulaator");
                Console.WriteLine("0. exit");
                Console.Write("Vali tegevus: ");

                string valik = Console.ReadLine();

                if (valik == "1")
                {
                    OSA5Funktsioon.TeooriaArrayList();
                }
                else if (valik == "2")
                {
                    OSA5Funktsioon.TeooriaTuple();
                }
                else if (valik == "3")
                {
                    OSA5Funktsioon.TeooriaListT();
                }
                else if (valik == "4")
                {
                    OSA5Funktsioon.TeooriaLinkedList();
                }
                else if (valik == "5")
                {
                    OSA5Funktsioon.TeooriaDictionary();
                }
                else if (valik == "6")
                {
                    OSA5Funktsioon.KaloriteKalkulaator();
                }
                else if (valik == "7")
                {
                    OSA5Funktsioon.MaakonnadJaPealinnad();
                }
                else if (valik == "8")
                {
                    OSA5Funktsioon.OpilasedJaHinded();
                }
                else if (valik == "9")
                {
                    OSA5Funktsioon.FilmideKogu();
                }
                else if (valik == "10")
                {
                    OSA5Funktsioon.ArvudeStatistika();
                }
                else if (valik == "11")
                {
                    OSA5Funktsioon.LemmikloomadeRegister();
                }
                else if (valik == "12")
                {
                    OSA5Funktsioon.ValuutaKalkulaator();
                }
                else if (valik == "0")
                {
                    Console.WriteLine("Nägemist!");
                    break;
                }
                else
                {
                    Console.WriteLine("Palun vali 0-12");
                }
            }
        }
    }
}
