using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_csharp
{
    public class Isik
    {
        public string Nimi;
        public int Vanus;

        public Isik(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
        public Isik() { }
        public void Tervita()
        {
            Console.WriteLine($"Tere, minu numi on {Nimi}");
        }

    }
}
