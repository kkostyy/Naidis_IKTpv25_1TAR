using System;
namespace Menu
{
    internal class OSAFunktsioon
    {
        public static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Peamenüü ===");
                Console.WriteLine("1.  Juhuslike arvude ruudud");
                Console.WriteLine("2.  Viie arvu analüüs");
                Console.WriteLine("3.  Nimed ja vanused");
                Console.WriteLine("4.  Osta elevant ära!");
                Console.WriteLine("5.  Arvamise mäng");
                Console.WriteLine("6.  Suurim neliarvuline arv");
                Console.WriteLine("7.  Korrutustabel");
                Console.WriteLine("8.  Õpilastega mängimine");
                Console.WriteLine("9.  Arvude ruudud");
                Console.WriteLine("10. Positiivsed ja negatiivsed");
                Console.WriteLine("11. Keskmisest suuremad");
                Console.WriteLine("12. Kõige suurema arvu otsing");
                Console.WriteLine("13. Paari- ja paaritud loendused");
                Console.WriteLine("0.  Välju");
                Console.Write("\nVali ülesanne: ");
                string valik = Console.ReadLine();
                Console.WriteLine();

                switch (valik)
                {
                    case "1": Ülesanded.ArvuTöötlus(); break;
                    case "2": Ülesanded.ArvuAnalüüs(); break;
                    case "3": Ülesanded.NimedVanused(); break;
                    case "4": Ülesanded.ElevantMäng(); break;
                    case "5": Ülesanded.ArvamisMäng(); break;
                    case "6": Ülesanded.NeliarSuurim(); break;
                    case "7": Ülesanded.Korrutustabel(); break;
                    case "8": Ülesanded.Õpilased(); break;
                    case "9": Ülesanded.ArvudeRuudud(); break;
                    case "10": Ülesanded.PosNeg(); break;
                    case "11": Ülesanded.KeskmisestSuuremad(); break;
                    case "12": Ülesanded.SuurimArv(); break;
                    case "13": Ülesanded.PaarLoendus(); break;
                    case "0": Console.WriteLine("Head aega!"); return;
                    default: Console.WriteLine("Vale valik!"); break;
                }

                Console.WriteLine("\nVajuta Enter, et menüüsse naasta...");
                Console.ReadLine();
            }
        }
    }
}