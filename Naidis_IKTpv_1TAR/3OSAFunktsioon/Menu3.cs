using Naidis_csharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_IKTpv_1TAR._3OSAFunktsioon
{
    public class Menu3
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n3. OSA - Kordused, massiivid ja klassid");
                Console.WriteLine("vali funktsioon:");
                Console.WriteLine("1.  Teooria: while tsükkel (matkajad)");
                Console.WriteLine("2.  Teooria: for tsükkel (matkajad)");
                Console.WriteLine("3.  Teooria: do-while tsükkel (matkajad)");
                Console.WriteLine("4.  Teooria: Isik klass + List");
                Console.WriteLine("5.  Teooria: massiivid (while/for/foreach/do-while)");
                Console.WriteLine("6.  Teooria: Tuple näide");
                Console.WriteLine("---");
                Console.WriteLine("7.  Ülesanne 1:  Juhuslike arvude ruudud (ArvuTootlus klass)");
                Console.WriteLine("8.  Ülesanne 2:  Viie arvu analüüs (Tuple)");
                Console.WriteLine("9.  Ülesanne 3:  Nimed ja vanused (Inimene klass + statistika)");
                Console.WriteLine("10. Ülesanne 4:  Osta elevant ära!");
                Console.WriteLine("11. Ülesanne 5:  Arvamise mäng (1-100, 5 katset)");
                Console.WriteLine("12. Ülesanne 6:  Suurim neliarvuline arv");
                Console.WriteLine("13. Ülesanne 7:  Korrutustabel");
                Console.WriteLine("14. Ülesanne 8:  Opilastega mängimine");
                Console.WriteLine("15. Ülesanne 9:  Arvude ruudud (for/foreach/while)");
                Console.WriteLine("16. Ülesanne 10: Positiivsed ja negatiivsed (foreach)");
                Console.WriteLine("17. Ülesanne 11: Keskmisest suuremad (15 juhuslikku)");
                Console.WriteLine("18. Ülesanne 12: Suurima arvu otsing + indeks");
                Console.WriteLine("19. Ülesanne 13: Paari- ja paaritud (List 20 arvu)");
                Console.WriteLine("20. exit");

                string valik = Console.ReadLine();

                if (valik == "1")
                {
                    OSA3Funktsioon.TeooriaMatkajadWhile();
                }
                else if (valik == "2")
                {
                    OSA3Funktsioon.TeooriaMatkajadFor();
                }
                else if (valik == "3")
                {
                    OSA3Funktsioon.TeooriaMatkajadDoWhile();
                }
                else if (valik == "4")
                {
                    OSA3Funktsioon.TeooriaIsikKlassJaList();
                }
                else if (valik == "5")
                {
                    OSA3Funktsioon.TeooriaMassiivid();
                }
                else if (valik == "6")
                {
                    OSA3Funktsioon.TeooriaTuple();
                }
                else if (valik == "7")
                {
                    // Ülesanne 1 - kasutab ArvuTootlus klassi
                    Console.WriteLine("Sisesta minimaalne arv: ");
                    int min = int.Parse(Console.ReadLine());
                    Console.WriteLine("Sisesta maksimaalne arv: ");
                    int max = int.Parse(Console.ReadLine());

                    int[] ruudud = ArvuTootlus.GenereeriRuudud(min, max);
                    Console.WriteLine("Tulemused:");
                    for (int i = 0; i < ruudud.Length; i++)
                    {
                        int algArv = (int)Math.Round(Math.Sqrt(ruudud[i]));
                        Console.WriteLine(algArv + " -> " + ruudud[i]);
                    }
                }
                else if (valik == "8")
                {
                    // Ülesanne 2 - viie arvu analüüs
                    double[] arvud = OSA3Funktsioon.TekstistArvud(5);
                    var tulemus = OSA3Funktsioon.AnalüüsiArve(arvud);
                    Console.WriteLine("--- Analüüs ---");
                    Console.WriteLine("Summa:   " + tulemus.Item1);
                    Console.WriteLine("Keskmine: " + Math.Round(tulemus.Item2, 2));
                    Console.WriteLine("Korrutis: " + tulemus.Item3);
                }
                else if (valik == "9")
                {
                    // Ülesanne 3 - kasutab Inimene klassi
                    List<Inimene> inimesed = new List<Inimene>();
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine((i + 1) + ". inimese nimi: ");
                        string nimi = Console.ReadLine();
                        Console.WriteLine((i + 1) + ". inimese vanus: ");
                        int vanus = int.Parse(Console.ReadLine());
                        inimesed.Add(new Inimene(nimi, vanus));
                    }
                    var stat = OSA3Funktsioon.Statistika(inimesed);
                    Console.WriteLine("--- Statistika ---");
                    Console.WriteLine("Vanuste summa:   " + stat.Item1);
                    Console.WriteLine("Vanuste keskmine: " + Math.Round(stat.Item2, 1));
                    Console.WriteLine("Vanim:  " + stat.Item3.Nimi + " (" + stat.Item3.Vanus + " aastat)");
                    Console.WriteLine("Noorim: " + stat.Item4.Nimi + " (" + stat.Item4.Vanus + " aastat)");
                }
                else if (valik == "10")
                {
                    // Ülesanne 4
                    OSA3Funktsioon.KuniMarksõnani("osta", "Osta elevant ära!");
                }
                else if (valik == "11")
                {
                    // Ülesanne 5
                    OSA3Funktsioon.ArvaArv();
                }
                else if (valik == "12")
                {
                    // Ülesanne 6
                    OSA3Funktsioon.SuurimNeliarv();
                }
                else if (valik == "13")
                {
                    // Ülesanne 7
                    Console.WriteLine("Ridade arv: ");
                    int read = int.Parse(Console.ReadLine());
                    Console.WriteLine("Veergude arv: ");
                    int veerud = int.Parse(Console.ReadLine());
                    int[,] tabel = OSA3Funktsioon.GenereeriKorrutustabel(read, veerud);

                    Console.WriteLine("Kas soovid otsida korrutist? (jah/ei): ");
                    if (Console.ReadLine().ToLower() == "jah")
                    {
                        Console.WriteLine("Sisesta esimene arv: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Sisesta teine arv: ");
                        int b = int.Parse(Console.ReadLine());
                        if (a >= 1 && a <= read && b >= 1 && b <= veerud)
                            Console.WriteLine(a + " x " + b + " = " + tabel[a - 1, b - 1]);
                        else
                            Console.WriteLine("Arvud on tabelist väljas!");
                    }
                }
                else if (valik == "14")
                {
                    // Ülesanne 8
                    OSA3Funktsioon.OpilastegaMängimine();
                }
                else if (valik == "15")
                {
                    // Ülesanne 9
                    OSA3Funktsioon.ArvudeRuudud();
                }
                else if (valik == "16")
                {
                    // Ülesanne 10
                    OSA3Funktsioon.PositiivsedJaNegatiivsed();
                }
                else if (valik == "17")
                {
                    // Ülesanne 11
                    OSA3Funktsioon.KeskmisestSuuremad();
                }
                else if (valik == "18")
                {
                    // Ülesanne 12
                    OSA3Funktsioon.SuurimJaIndeks();
                }
                else if (valik == "19")
                {
                    // Ülesanne 13
                    OSA3Funktsioon.PaaridJaPaaritud();
                }
                else if (valik == "20")
                {
                    Console.WriteLine("Nägemist!");
                    break;
                }
                else
                {
                    Console.WriteLine("Palun vali 1-20");
                }
            }
        }
    }
}