using System;

namespace Naidis_IKTpv_1TAR
{
    public class _2OSAFunktsioon
    {
        public static string Juku(string nimi)
        {
            if (nimi.ToLower() != "juku")
            {
                return "Me ei lähe kinno koos Jukuga";
            }

            Console.Write("Kui vana Juku oled: ");
            string pilet = "";

            try
            {
                int vanus = int.Parse(Console.ReadLine());

                switch (vanus)
                {
                    case < 0:
                    case > 100:
                        pilet = "Viga andmetega!";
                        break;

                    case < 6:
                        pilet = "Pilet on tasuta";
                        break;

                    case <= 14:
                        pilet = "Pilet on lastepilet";
                        break;

                    case <= 65:
                        pilet = "Pilet on täispilet";
                        break;

                    default:
                        pilet = "Pilet on sooduspilet";
                        break;
                }
            }
            catch
            {
                pilet = "Viga andmetega!";
            }

            return pilet;
        }
    }
}
