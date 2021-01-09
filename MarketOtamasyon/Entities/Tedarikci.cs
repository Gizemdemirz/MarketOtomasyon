using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtamasyon.Entities
{
    public class Tedarikci
    {
        public int TedarikciId { get; set; }
        public string Ad { get; set; }
        public double AlınacakTutar { get; set; }
        public virtual ICollection<Urun> Uruns { get; set; }
    }
}
