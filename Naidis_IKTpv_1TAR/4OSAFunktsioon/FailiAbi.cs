using System;
using System.IO;

namespace Naidis_IKTpv_1TAR._4OSAFunktsioon
{
    // Klass FailiAbi – abimeetodid failidega töötamiseks
    // Sarnane Arvutaja klassiga OSA1-s
    public class FailiAbi
    {
        // Tagastab täieliku failitee
        public static string Tee(string failinimi)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, failinimi);
        }

        // Kontrollib kas fail eksisteerib
        public static bool OnOlemas(string failinimi)
        {
            return File.Exists(Tee(failinimi));
        }

        // Loob faili vaikimisi ridadega kui faili pole
        public static void LooKuiPuudub(string failinimi, string[] vaikimisiRead)
        {
            string path = Tee(failinimi);
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, vaikimisiRead);
                Console.WriteLine("Loodud " + failinimi);
            }
        }
    }
}

