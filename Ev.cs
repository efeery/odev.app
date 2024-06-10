using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    public class Ev
    {
        public string Semt { get; set; }
        public int KatNo { get; set; }
        public int OdaSayisi { get; set; }
        public double Alan { get; set; }

        public override string ToString()
        {
            return $"Semt: {Semt}, Kat No: {KatNo}, Oda Sayısı: {OdaSayisi}, Alan: {Alan} m²";
        }
    }
}
