using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_csharp
{
    internal class osa2
    {
        public static string Juku(string nimi = "Juku")
        {
            int vanus = 0;
            string vastus = "";
            string pilet = "";
            string ostus = "";

            Console.WriteLine("sisesta oma nimi");
            nimi = Console.ReadLine();
            if (nimi.ToLower() == "juku")
            {
                Console.WriteLine("Lähme kinno!");

                while (true)
                {
                    try
                    {
                        Console.WriteLine("sisesta oma vanus");
                        vanus = int.Parse(Console.ReadLine());
                        if (vanus > 0 && vanus < 100)

                        {
                            if (vanus < 6)
                            {

                                pilet = "sulle on kinopilet on tasuta!";
                                break;
                            }
                            else if (vanus >= 6 && vanus <= 14)
                            {
                                pilet = "sulle on kinopilet on lastepilet!";
                                break;
                            }
                            else if (vanus >= 15 && vanus <= 65)
                            {
                                pilet = "sulle on kinopilet on täispilet!";
                                break;
                            }
                            else
                            {
                                pilet = "sulle on kinopilet on sooduspilet!";
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("vanus peab olema positiivne arv ja kui < 100");
                        }
                    }


                    catch { Console.WriteLine("palun sisesta korrektne vanus"); }

                }
            }
            else
            {
                Console.WriteLine("ma olen võivatud");
            }
            Console.WriteLine(pilet);
            return vastus;
        }
        public static void pinginabrid()
        {
            Console.WriteLine("1. sisesta oma nimi: ");
            string nimi = Console.ReadLine();
            Console.WriteLine("2. sisesta oma nimi: ");
            string nimi2 = Console.ReadLine();

            Console.WriteLine($"{nimi} ja {nimi2} te olete pinginabrid");

        }
        public static void pindala()
        {
            Console.WriteLine("Sisesta ristküliku esimene külg: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta ristküliku teine külg: ");
            float b = float.Parse(Console.ReadLine());
            float pindala = a * b;
            Console.WriteLine($"Ristküliku pindala on {pindala}");
        }
        public static void soodus()
        {
            Console.WriteLine("Sisesta hind:  ");
            float hind = float.Parse(Console.ReadLine());
            hind = hind * 1.3f;
            Console.WriteLine($"Hind on {hind}");
        }
        public static void tem()
        {
            Console.WriteLine("sisesta temperatuur: ");
            float tem = float.Parse(Console.ReadLine());
            if (tem < 18)
            {
                Console.WriteLine("temperatuur on alla 18");
            }
            else
            {
                Console.WriteLine("temperatuur on üle nulli");
            }

        }
        public static void pikk()
        {
            Console.WriteLine("sisesta sinu pikkus: ");
            float pikk = float.Parse(Console.ReadLine());
            if (pikk < 150)
            {
                Console.WriteLine("sa oled lühike");
            }
            else if (pikk >= 150 && pikk <= 180)
            {
                Console.WriteLine("sa oled keskmise pikkusega");
            }
            else
            {
                Console.WriteLine("sa oled pikk");
            }
        }
        public static void pood()
        {

            string[] products = { "piim", "sai", "leib" };
            float[] prices = { 1.2f, 0.8f, 1.5f };
            float tulemus = 0;
            string ost = "";
            int mitu = 0;


            for (int i = 0; i < products.Length; i++)
            {
                try
                {
                    while (true)
                    {
                        Console.WriteLine("vali mida sa tahad ostida (1. piim, 2. sai, 3. leib)");
                        Console.Write("vali (1/2/3):  ");
                        ost = Console.ReadLine();
                        if (ost.ToLower() == "1" || ost == "2" || ost == "3")
                        {
                            Console.WriteLine("kui palju selle toitu sa tahad otsida?:  ");
                            mitu = int.Parse(Console.ReadLine());
                            break;
                        }
                        else
                        {
                            Console.WriteLine("palun vali (1/2/3):  ");
                        }
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine("vale andmetüüp");

                }
                if (ost.ToLower() == "piim" || ost == "sai" || ost == "leib")
                {

                    tulemus += prices[i] * mitu;

                }
                Console.WriteLine($"sa ostsid {products[i]} hinnaga {prices[i] * mitu}");
            }
            Console.WriteLine($"sa ostsid kokku {tulemus}");

        }



    }
}