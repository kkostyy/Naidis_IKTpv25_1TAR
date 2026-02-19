using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_IKTpv_1TAR._1OSAFunktsioon
{
    // Klass Arvutaja sisaldab staatilisi meetodeid matemaatiliste tehete jaoks
    public class Arvutaja
    {
        public static float Liida(float arv1, float arv2)
        {
            return arv1 + arv2;
        }

        public static float Lahuta(float arv1, float arv2)
        {
            return arv1 - arv2;
        }

        public static float Korruta(float arv1, float arv2)
        {
            return arv1 * arv2;
        }

        public static float Jaga(float arv1, float arv2)
        {
            return arv1 / arv2;
        }
    }
}

