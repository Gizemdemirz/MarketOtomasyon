using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtamasyon.Entities
{
    public class Urun
    {

        public int UrunId { get; set; }
        public int barkodNo { get; set; }
        public string UrunAdi { get; set; }
        public int miktar { get; set; }

        public double alisFiyati { get; set; }
        public double satisFiyati { get; set; }

        public int irsaliyeNo { get; set; }


        public virtual Tedarikci Tedarikci { get; set; }

        public virtual Sepet Sepet { get; set; }

    }
}
