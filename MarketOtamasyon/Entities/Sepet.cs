using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtamasyon.Entities
{
    public class Sepet
    { public int SepetID { get; set; }
        public int UrunBarkodNo { get; set; }
        public string UrunAdi { get; set; }
        public double tutar { get; set; }
        public int miktar { get; set; }
       
     //public virtual Satis Satis { get; set; }
        
        public virtual ICollection<Urun> Uruns { get; set; }

    }
}
