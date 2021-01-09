using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtamasyon.Entities
{
    public class Musteri
    {
    
        public int MusteriId { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }

        public double borc { get; set; }
      
     public virtual ICollection<Satis> Satis { get; set; }
      
    }
}
