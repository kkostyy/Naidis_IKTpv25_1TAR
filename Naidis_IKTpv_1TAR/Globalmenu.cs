using System;
using System.Text;
using System.Collections.Generic;
using Naidis_IKTpv_1TAR._1OSAFunktsioon;
using Naidis_IKTpv_1TAR._2OSAFunktsioon;
using Naidis_IKTpv_1TAR._3OSAFunktsioon;

namespace Naidis_IKTpv_1TAR
{
    public class GlobalMenu
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\nVali funktsioon:");
                Console.WriteLine("--- 1. OSA ---");
                Console.WriteLine("1. Tervitus");
                Console.WriteLine("2. Tervitus nimega");
                Console.WriteLine("3. Korrutamine (2 arvu)");
                Console.WriteLine("4. Liitmine");
                Console.WriteLine("5. Lahutamine");
                Console.WriteLine("6. Jagamine");
                Console.WriteLine("7. Isiku loomine (Isik klass)");
                Console.WriteLine("--- 2. OSA ---");
                Console.WriteLine("8. Juku if/else");
                Console.WriteLine("9. Kuu nimetus (switch)");
                Console.WriteLine("10. Hooaeg (if/else if)");
                Console.WriteLine("11. Juku kinno + piletiliik");
                Console.WriteLine("12. Pinginaabrid");
                Console.WriteLine("13. Ristküliku pindala ja remondi hind");
                Console.WriteLine("14. 30% soodustusega alghind");
                Console.WriteLine("15. Temperatuur");
                Console.WriteLine("16. Pikkuse hindamine");
                Console.WriteLine("17. Pikkus ja sugu");
                Console.WriteLine("18. Pood (piim, sai, leib)");
                Console.WriteLine("--- 3. OSA ---");
                Console.WriteLine("19. Teooria: while (matkajad)");
                Console.WriteLine("20. Teooria: for (matkajad)");
                Console.WriteLine("21. Teooria: do-while (matkajad)");
                Console.WriteLine("22. Teooria: Isik klass + List");
                Console.WriteLine("23. Teooria: massiivid");
                Console.WriteLine("24. Teooria: Tuple naide");
                Console.WriteLine("25. Juhuslike arvude ruudud (ArvuTootlus klass)");
                Console.WriteLine("26. Viie arvu analuus (Tuple)");
                Console.WriteLine("27. Nimed ja vanused (Inimene klass)");
                Console.WriteLine("28. Osta elevant ara!");
                Console.WriteLine("29. Arvamise mang (1-100)");
                Console.WriteLine("30. Suurim neliarvuline arv");
                Console.WriteLine("31. Korrutustabel");
                Console.WriteLine("32. Opilastega mangimine");
                Console.WriteLine("33. Arvude ruudud (for/foreach/while)");
                Console.WriteLine("34. Positiivsed ja negatiivsed");
                Console.WriteLine("35. Keskmisest suuremad");
                Console.WriteLine("36. Suurima arvu otsing + indeks");
                Console.WriteLine("37. Paari- ja paaritud (List 20 arvu)");
                Console.WriteLine("0. exit");

                string valik = Console.ReadLine();

                if (valik == "1")
                {
                    OSA1Funktsioon.Tervitus();
                }
                else if (valik == "2")
                {
                    OSA1Funktsioon.TervitusNimega();
                }
                else if (valik == "3")
                {
                    OSA1Funktsioon.Korrutamine();
                }
                else if (valik == "4")
                {
                    OSA1Funktsioon.Liitmine();
                }
                else if (valik == "5")
                {
                    OSA1Funktsioon.Lahutamine();
                }
                else if (valik == "6")
                {
                    OSA1Funktsioon.Jagamine();
                }
                else if (valik == "7")
                {
                    OSA1Funktsioon.IsikuLoomine();
                }
                else if (valik == "8")
                {
                    OSA2Funktsioon.JukuIfElse();
                }
                else if (valik == "9")
                {
                    OSA2Funktsioon.KuuNimetusDemo();
                }
                else if (valik == "10")
                {
                    OSA2Funktsioon.HooaegDemo();
                }
                else if (valik == "11")
                {
                    OSA2Funktsioon.JukuKinno();
                }
                else if (valik == "12")
                {
                    OSA2Funktsioon.Pinginaabrid();
                }
                else if (valik == "13")
                {
                    OSA2Funktsioon.Pindala();
                }
                else if (valik == "14")
                {
                    OSA2Funktsioon.Soodus();
                }
                else if (valik == "15")
                {
                    OSA2Funktsioon.Temperatuur();
                }
                else if (valik == "16")
                {
                    OSA2Funktsioon.Pikkus();
                }
                else if (valik == "17")
                {
                    OSA2Funktsioon.PikkusJaSugu();
                }
                else if (valik == "18")
                {
                    OSA2Funktsioon.Pood();
                }
                else if (valik == "19")
                {
                    OSA3Funktsioon.TeooriaMatkajadWhile();
                }
                else if (valik == "20")
                {
                    OSA3Funktsioon.TeooriaMatkajadFor();
                }
                else if (valik == "21")
                {
                    OSA3Funktsioon.TeooriaMatkajadDoWhile();
                }
                else if (valik == "22")
                {
                    OSA3Funktsioon.TeooriaIsikKlassJaList();
                }
                else if (valik == "23")
                {
                    OSA3Funktsioon.TeooriaMassiivid();
                }
                else if (valik == "24")
                {
                    OSA3Funktsioon.TeooriaTuple();
                }
                else if (valik == "25")
                {
                    Console.WriteLine("Sisesta minimaalne arv: ");
                    int min = int.Parse(Console.ReadLine());
                    Console.WriteLine("Sisesta maksimaalne arv: ");
                    int max = int.Parse(Console.ReadLine());
                    int[] ruudud = ArvuTootlus.GenereeriRuudud(min, max);
                    for (int i = 0; i < ruudud.Length; i++)
                    {
                        int algArv = (int)Math.Round(Math.Sqrt(ruudud[i]));
                        Console.WriteLine(algArv + " -> " + ruudud[i]);
                    }
                }
                else if (valik == "26")
                {
                    double[] arvud = OSA3Funktsioon.TekstistArvud(5);
                    var tulemus = OSA3Funktsioon.AnalüüsiArve(arvud);
                    Console.WriteLine("Summa:    " + tulemus.Item1);
                    Console.WriteLine("Keskmine: " + Math.Round(tulemus.Item2, 2));
                    Console.WriteLine("Korrutis: " + tulemus.Item3);
                }
                else if (valik == "27")
                {
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
                    Console.WriteLine("Vanuste summa:    " + stat.Item1);
                    Console.WriteLine("Vanuste keskmine: " + Math.Round(stat.Item2, 1));
                    Console.WriteLine("Vanim:  " + stat.Item3.Nimi + " (" + stat.Item3.Vanus + " aastat)");
                    Console.WriteLine("Noorim: " + stat.Item4.Nimi + " (" + stat.Item4.Vanus + " aastat)");
                }
                else if (valik == "28")
                {
                    OSA3Funktsioon.KuniMarksõnani("osta", "Osta elevant ära!");
                }
                else if (valik == "29")
                {
                    OSA3Funktsioon.ArvaArv();
                }
                else if (valik == "30")
                {
                    OSA3Funktsioon.SuurimNeliarv();
                }
                else if (valik == "31")
                {
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
                else if (valik == "32")
                {
                    OSA3Funktsioon.OpilastegaMängimine();
                }
                else if (valik == "33")
                {
                    OSA3Funktsioon.ArvudeRuudud();
                }
                else if (valik == "34")
                {
                    OSA3Funktsioon.PositiivsedJaNegatiivsed();
                }
                else if (valik == "35")
                {
                    OSA3Funktsioon.KeskmisestSuuremad();
                }
                else if (valik == "36")
                {
                    OSA3Funktsioon.SuurimJaIndeks();
                }
                else if (valik == "37")
                {
                    OSA3Funktsioon.PaaridJaPaaritud();
                }
                else if (valik == "0")
                {
                    Console.WriteLine("Nägemist!");
                    break;
                }
                else
                {
                    Console.WriteLine("Palun vali 0-37");
                }
            }
        }
    }
}
