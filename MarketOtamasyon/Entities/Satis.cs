using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtamasyon.Entities
{
    public class Satis
    {
        public int SatisId { get; set; }
        public int UrunBarkodNo { get; set; }
        public string UrunAdi { get; set; }
        public int UrunMiktarı { get; set; }
        public double tutar { get; set; }
        public DateTime SatisTarihi { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual Sepet Sepet { get; set; }
        

    }
}
