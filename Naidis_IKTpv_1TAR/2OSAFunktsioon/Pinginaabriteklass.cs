using System;

namespace Naidis_IKTpv_1TAR._2OSAFunktsioon
{
    // Klass Pinginaabriteklass – hoiab kahe inimese nimesid
    // ja teatab, et nad on pinginaabrid
    public class Pinginaabriteklass
    {
        public string Nimi1;
        public string Nimi2;

        public Pinginaabriteklass(string nimi1, string nimi2)
        {
            Nimi1 = nimi1;
            Nimi2 = nimi2;
        }

        public void Teata()
        {
            Console.WriteLine(Nimi1 + " ja " + Nimi2 + " on täna pinginaabrid!");
        }
    }
}
