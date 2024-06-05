using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    internal class BingoJatekos
    {
        string szam1, szam2, szam3, szam4, szam5;

        public BingoJatekos(string mezo) {
            var sor = mezo.Split(";");
            szam1 = sor[0];
            szam2 = sor[1];
            szam3 = sor[2];
            szam4 = sor[3];
            szam5 = sor[4];

        
        }

        public BingoJatekos(string szam1, string szam2, string szam3, string szam4, string szam5)
        {
            this.Szam1 = szam1;
            this.Szam2 = szam2;
            this.Szam3 = szam3;
            this.Szam4 = szam4;
            this.Szam5 = szam5;
        }

        public string Szam1 { get => szam1; set => szam1 = value; }
        public string Szam2 { get => szam2; set => szam2 = value; }
        public string Szam3 { get => szam3; set => szam3 = value; }
        public string Szam4 { get => szam4; set => szam4 = value; }
        public string Szam5 { get => szam5; set => szam5 = value; }
    }

    
}
