using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    public class SatilikEv : Ev
    {
        public double SatisFiyati { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Satış Fiyatı: {SatisFiyati:C}";
        }
    }
}
