namespace Naidis_IKTpv_1TAR._2OSAFunktsioon
{
    // Klass Ruum – ristkülikukujuline tuba
    // arvutab põranda pindala ja remondi hinna
    public class Ruum
    {
        public double Pikkus;
        public double Laius;

        public Ruum(double pikkus, double laius)
        {
            Pikkus = pikkus;
            Laius = laius;
        }

        // Põranda pindala
        public double Pindala()
        {
            return Pikkus * Laius;
        }

        // Remondi koguhind: pindala * ruutmeetrihind
        public double RemondiHind(double ruutmeetrihind)
        {
            return Pindala() * ruutmeetrihind;
        }
    }
}
