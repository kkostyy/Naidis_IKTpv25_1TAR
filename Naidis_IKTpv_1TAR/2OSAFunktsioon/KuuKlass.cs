namespace Naidis_IKTpv_1TAR._2OSAFunktsioon
{
    // Klass KuuKlass – sisaldab kuu nimetust ja hooaega
    // Põhineb otse teoriaraamatu näidetel (Kuu_nimetus + Hooaeg)
    public class KuuKlass
    {
        public int KuuNr;

        public KuuKlass(int kuuNr)
        {
            KuuNr = kuuNr;
        }

        // Kuu_nimetus – switch (teoriaraamatust)
        public string Nimetus()
        {
            string kuu = "";
            switch (KuuNr)
            {
                case 1: kuu = "Jaanuar"; break;
                case 2: kuu = "Veebruar"; break;
                case 3: kuu = "Märts"; break;
                case 4: kuu = "Aprill"; break;
                case 5: kuu = "Mai"; break;
                case 6: kuu = "Juuni"; break;
                case 7: kuu = "Juuli"; break;
                case 8: kuu = "August"; break;
                case 9: kuu = "September"; break;
                case 10: kuu = "Oktoober"; break;
                case 11: kuu = "November"; break;
                case 12: kuu = "Detsember"; break;
                default: kuu = "???"; break;
            }
            return kuu;
        }

        // Hooaeg – if/else if (teoriaraamatust)
        public string Hooaeg()
        {
            string hoo = "";

            if (KuuNr == 1 || KuuNr == 2 || KuuNr == 12) // && - and, || - or
            {
                hoo = "Talv";
            }
            else if (KuuNr > 2 && KuuNr < 6)
            {
                hoo = "Kevad";
            }
            else if (KuuNr > 5 && KuuNr < 9)
            {
                hoo = "Suvi";
            }
            else if (KuuNr > 8 && KuuNr < 12) // 9, 10, 11
            {
                hoo = "Sügis";
            }
            else
            {
                hoo = "???";
            }

            return hoo;
        }
    }
}
