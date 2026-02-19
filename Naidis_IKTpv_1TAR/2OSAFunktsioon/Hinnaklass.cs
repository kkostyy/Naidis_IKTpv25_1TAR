namespace Naidis_IKTpv_1TAR._2OSAFunktsioon
{
    // Klass Hinnaklass – arvutab alghinna soodustuse põhjal
    // Näide: 30% soodustus => soodushind = alghind * 0.70
    //                      => alghind    = soodushind / 0.70
    public class Hinnaklass
    {
        public double Soodushind;
        public double SoodustusProtsent;

        public Hinnaklass(double soodushind, double soodustusProtsent)
        {
            Soodushind = soodushind;
            SoodustusProtsent = soodustusProtsent;
        }

        // Leiab alghinna soodustuse põhjal
        public double Alghind()
        {
            double koefitsient = 1.0 - (SoodustusProtsent / 100.0);
            return Soodushind / koefitsient;
        }

        // Soodustuse summa eurodes
        public double SoodustuseSumma()
        {
            return Alghind() - Soodushind;
        }
    }
}
