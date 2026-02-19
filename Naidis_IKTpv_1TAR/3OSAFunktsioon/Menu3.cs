
using Naidis_IKTpv_1TAR;
using Naidis_IKTpv_1TAR._3OSAFunktsioon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Naidis_csharp
{
    public class start_page
    {
        public static void Main(string[] args)
        {
            List<Inimene> Inimesed = new List<Inimene>();
            //Inimene inimenel = new Inimene("Vasja", 100);
            //Inimesed.Add(inimenel);
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Mis on sinu nimi?: ");
                string nimi = Console.ReadLine();
                Console.WriteLine($"Mis on {i + 1} Inimese vanus?: ");
                int vanus = int.Parse(Console.ReadLine());
                Inimene inimene = new Inimene(nimi, vanus);
                Inimesed.Add(inimene);
            }
            var analuus = OSA3Funktsioon.Statistika(Inimesed);
            Console.WriteLine($"Vanuste arv: {analuus.Item1}");
            Console.WriteLine($"Vanuste keskmine: {analuus.Item2}");
            Console.WriteLine($"Noorim inimene: {analuus.Item3.Nimi}({analuus.Item3.Vanus} aastat vana)");
            Console.WriteLine($"Vanim inimene: {analuus.Item4.Nimi}({analuus.Item4.Vanus} aastat vana)");
            


            Console.OutputEncoding = Encoding.UTF8;
            /*Console.WriteLine("1. Osa Anmdetüübid");
            string text = "Tere tulemast c#-i mailmaa!";
            Console.WriteLine($"Oli loodud muutuja tekst,mis võrdub: {text}");
            Console.Write("mis on sinu nimi: ");
            string nimi = Console.ReadLine();
            Console.WriteLine("kui vana sa oled?: ");

            try
            {
                int vanus = int.Parse(Console.ReadLine());
                Console.WriteLine($"Tere {nimi}, sa oled {vanus}, aastat vana");

                Console.Write("arv1: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("arv2: ");
                float b = float.Parse(Console.ReadLine());
                float vastus = Naidis_funktsioon.Summa(a, b);
                Console.WriteLine($"{a} + {b} = {vastus}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }



            Random rnd = new Random();
            int juhuslik_arv = rnd.Next(-5, 25);
            Console.WriteLine(Naidis_funktsioon.Kuu_nimetus(juhuslik_arv));
            juhuslik_arv = rnd.Next(-5, 25);
            text = Naidis_funktsioon.Kuu_nimetus(juhuslik_arv);
            Console.WriteLine(text);
            
            List<Isik> inimesed = new List<Isik>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Sisesta nimi: ");
                string nimi = Console.ReadLine();

                Console.Write("Sisesta vanus: ");
                int vanus = int.Parse(Console.ReadLine());

                Isik uusIsik = new Isik();
                uusIsik.Nimi = nimi;
                uusIsik.Vanus = vanus;

                inimesed.Add(uusIsik);
            }

            Console.WriteLine("\nKõik inimesed tervitavad:\n");

            foreach (Isik isik in inimesed)
            {
                isik.Tervita();
            }


            Console.WriteLine("3. Osa. Kordused ja listid; missivid");
            Console.WriteLine("for: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Tere, {i}!");
            }

            Console.WriteLine("while: ");
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine($"Tere, {j + 1}");
                j++;
            }
            Console.WriteLine("Do: ");
            do
            {
                Console.WriteLine($"Tere, {11 - j}!");
                j--;
            } while (j != 0);

            int[] arvud = new int[5];


            for (int i = 1; i <= arvud.Length; i++)
            {

                Console.WriteLine($"sisesta {i}. arv: ");
                try
                {
                    arvud[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

            }



            Console.WriteLine("foreach abil: 0->4");
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine($"sisestatud arv: {arvud[i]}");
            }

            Console.WriteLine("foreach abil: 0<-4");
            for (int i = arvud.Length - 1; i > -1; i--)
            {
                Console.WriteLine($"sisestatud arv: {arvud[i]}");
            }

            // küsi mis pos muuda element ja mis väärtuseks, muuda element ja kuva masiiv

           */
            int[] arvud = new int[5];
            while (true)
            {
                Console.WriteLine("2. Osa Funktsioonid");
                Console.WriteLine("vali funktioon \n1. Juku \n2. pinginabrid\n3. pindala\n4. soodus\n5. tem\n6. pikk\n7. pood\n8. MuudaElement\n9. Täida_massiiv\n10. foreachFunktisoon\n11. GenereeriRuudud\n12. exit ");
                string valik = Console.ReadLine();
                if (valik == "1")
                {
                    osa2.Juku();

                }
                else if (valik == "2")
                {
                    osa2.pinginabrid();

                }
                else if (valik == "3")
                {
                    osa2.pindala();

                }
                else if (valik == "4")
                {
                    osa2.soodus();

                }
                else if (valik == "5")
                {
                    osa2.tem();

                }
                else if (valik == "6")
                {
                    osa2.pikk();

                }
                else if (valik == "7")
                {

                    osa2.pood();

                }

                else if (valik == "8")
                {

                    Naidis_IKTpv_1TAR.MuudaElement(arvud);


                }
                else if (valik == "9")
                {

                    Naidis_funktsioon.Täida_massiiv(arvud);
                }
                else if (valik == "10")
                {
                    Naidis_funktsioon.foreachFunktisoon(arvud);
                }
                else if (valik == "11")
                {

                    int[] masiiv1 = osa3.GenereeriRuudud(1, 10);
                    Naidis_funktsioon.foreachFunktisoon(masiiv1);
                }
                else if (valik == "12")
                {
                    double[] arvudMasiiv = Naidis_funktsioon.Täida_Doublemassiiv(new double[5]);
                    var tulemus = osa3.arvuAnaluus(arvudMasiiv);
                    Console.WriteLine($"summa: {tulemus.Item1}, keskmine: {tulemus.Item2}, Korrutis: {tulemus.Item3}");

                }
                else if (valik == "13")
                {
                    osa3.ostsElevantAra();
                }
                else if (valik == "14")
                {
                    osa3.arvumang();
                }
                else if (valik == "15")
                {
                    osa3.SuurimNeliarv();
                }
                else if (valik == "16")
                {
                    Console.WriteLine("Korrutustabel: ");
                    osa3.GenereeriKorrutustabel(10, 10);

                }
                else

                {
                    Console.WriteLine("vali arv 1-11: ");
                }

            }


        }
    }
}
