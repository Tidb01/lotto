using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkandinavAdat.Models
{
    public class LottoSzam
    {
        public int Id { get; set; }

        public int Szam1 { get; set; }
        public int Szam2 { get; set; }
        public int Szam3 { get; set; }
        public int Szam4 { get; set; }
        public int Szam5 { get; set; }
        public int Szam6 { get; set; }
        public int Szam7 { get; set; }

        public LottoSzam(int[] tomb)
        {
            Szam1 = tomb[0];
            Szam2 = tomb[1];
            Szam3 = tomb[2];
            Szam4 = tomb[3];
            Szam5 = tomb[4];
            Szam6 = tomb[5];
            Szam7 = tomb[6];
        }

        public LottoSzam()
        {
        }

    }
}
