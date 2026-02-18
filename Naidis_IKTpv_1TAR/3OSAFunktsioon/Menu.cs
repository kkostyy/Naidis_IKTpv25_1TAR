using System;


class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("    Peamenüü        ");
            Console.WriteLine("1.  Juhuslike arvude ruudud         ");
            Console.WriteLine("2.  Viie arvu analüüs               ");
            Console.WriteLine("3.  Nimed ja vanused                ");
            Console.WriteLine("4.  Osta elevant ära!               ");
            Console.WriteLine("5.  Arvamise mäng                   ");
            Console.WriteLine("6.  Suurim neliarvuline arv         ");
            Console.WriteLine("7.  Korrutustabel                   ");
            Console.WriteLine("8.  Õpilastega mängimine            ");
            Console.WriteLine("9.  Arvude ruudud                   ");
            Console.WriteLine("10. Positiivsed ja negatiivsed      ");
            Console.WriteLine("11. Keskmisest suuremad             ");
            Console.WriteLine("12. Kõige suurema arvu otsing       ");
            Console.WriteLine("13. Paari- ja paaritud loendused    ");
            Console.WriteLine("0.  Välju                           ");
            Console.Write("\nVali ülesanne: ");

            string valik = Console.ReadLine();
            Console.WriteLine();

            switch (valik)
            {
                case "1": ArvuTöötlus.Käivita(); break;
                case "2": ArvuAnalüüs.Käivita(); break;
                case "3": NimedVanused.Käivita(); break;
                case "4": ElevantMäng.Käivita(); break;
                case "5": ArvamisMäng.Käivita(); break;
                case "6": NeliarSuurim.Käivita(); break;
                case "7": Korrutustabel.Käivita(); break;
                case "8": Õpilased.Käivita(); break;
                case "9": ArvudeRuudud.Käivita(); break;
                case "10": PosNeg.Käivita(); break;
                case "11": KeskmisestSuuremad.Käivita(); break;
                case "12": SuurimArv.Käivita(); break;
                case "13": PaarLoendus.Käivita(); break;
                case "0": Console.WriteLine("Head aega!"); return;
                default: Console.WriteLine("Vale valik!"); break;
            }

            Console.WriteLine("\nVajuta Enter, et menüüsse naasta...");
            Console.ReadLine();
        }
    }
}

