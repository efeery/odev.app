using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    public class KiralikEv : Ev
    {
        public double KiraFiyati { get; set; }
        public double Depozito { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Kira Fiyatı: {KiraFiyati:C}, Depozito: {Depozito:C}";
        }
    }
}
