using Naidis_IKTpv_1TAR;
using System;
using System.Text;

namespace Naidis_IKTpv25_1TAR
{
    public class StartPage()
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Osa Andmetüübid");
            Console.ForegroundColor = ConsoleColor.Green;
            string tekst = "Tere tulemast";
            Console.WriteLine($":{tekst}");
            /*Console.Write("Mis on sinu nimi?: ");
            string nimi = Console.ReadLine();
            Console.Write("Kui vana sa oled?: ");
            try
            {
                int vanus = int.Parse(Console.ReadLine());
                Console.WriteLine($"Tere {nimi}! Sa oled {vanus} aastad vana");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                Console.Write("Arv 1: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Arv 2: ");
                float b = float.Parse(Console.ReadLine());
                float vastus = Naidis_functsioon.Summa(a, b);
                Console.WriteLine($"Summa {a} ja {b} võrdub {vastus}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            0*/
            Random rnd = new Random();
            int juhuslik_arv = rnd.Next(-5, 25);
            Console.WriteLine(Naidis_functsioon.Kuu_nimetus(juhuslik_arv));
            juhuslik_arv = rnd.Next(-5, 25);
            tekst = Naidis_functsioon.Kuu_nimetus(juhuslik_arv);
            Console.WriteLine(tekst);
            //juku ja kinno
            Console.Write(_2OSAFunktsioon.Juku()
        }
    }
}
	
