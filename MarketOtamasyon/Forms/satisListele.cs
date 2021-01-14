using MarketOtamasyon.Contexts;
using MarketOtamasyon.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtamasyon.Forms
{
    public partial class satisListele : Form
    {
        public satisListele()
        {
            InitializeComponent();
        }

        OtomasyonContext otomasyonContext = new OtomasyonContext();
        private void btnSatislar_Click(object sender, EventArgs e)
        {
            SatisListele();
         
        }

        private void satisListele_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCariSatis_Click(object sender, EventArgs e)
        {
            CariSatisListele();
        }

        void SatisListele()
        {
            var listele = otomasyonContext.Database.SqlQuery<Satis>("MarketOtomasyon").ToList();

            dataGridView1.DataSource = listele.Select(x =>  new {

                Satıs_Id = x.SatisId,
                Barkod_No = x.UrunBarkodNo,
                Ürün_Adı = x.UrunAdi,
                Miktar = x.UrunMiktarı,
                Tutar = x.tutar,
                Satış_Tarihi = x.SatisTarihi

            }).ToList();
            /*dataGridView1.DataSource = otomasyonContext.Satis.Select(x => new
            {
                Satış_Id = x.SatisId,
                Barkod_No = x.UrunBarkodNo,
                Ürün_Adı = x.UrunAdi,
                Miktar = x.UrunMiktarı,
                Tutar = x.tutar,
                Satış_Tarihi = x.SatisTarihi
            }).ToList();*/
        }
        void CariSatisListele()
        {
            var cari = from x in otomasyonContext.Musteris
                       join y in otomasyonContext.Satis on
            x.MusteriId equals y.Musteri.MusteriId
                       select y;
            dataGridView1.DataSource = cari.Select(x => new
            {
                Satış_Id = x.SatisId,
                Müşteri_Id = x.Musteri.MusteriId,
                Barkod_No = x.UrunBarkodNo,
                Ürün_Adı = x.UrunAdi,
                Miktar = x.UrunMiktarı,
                Tutar = x.tutar,
                Satış_Tarihi = x.SatisTarihi
            }
                ).ToList();

        }
        

        private void btnSatisIptal_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0 & dataGridView1.Columns.Count >= 6)
            {
                SatısSil satısSil = new SatısSil();
                satısSil.ShowDialog();
                if (satısSil.txtSifre.Text == "123456")
                {
                    int satisId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                    var satis = otomasyonContext.Satis.Find(satisId);
                    var urun = from x in otomasyonContext.Uruns where x.barkodNo == satis.UrunBarkodNo select x;
                    foreach (var item in urun)
                    {
                        item.miktar += satis.UrunMiktarı;
                    }
                   
                    
                    MessageBox.Show("Satış kaydı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dataGridView1.Columns.Count == 7)
                    {
                        if (satis.Musteri.borc >= satis.tutar)
                        {
                            satis.Musteri.borc -= satis.tutar;
                        }
                        otomasyonContext.Satis.Remove(satis);
                        otomasyonContext.SaveChanges();
                        CariSatisListele();

                    }
                    else
                    {
                        otomasyonContext.Satis.Remove(satis);
                        otomasyonContext.SaveChanges();
                        SatisListele();
                    }

                }

            }
        }

        private void btnCokSatan_Click(object sender, EventArgs e)
        {
         
            var bul =  from x in  otomasyonContext.Satis.GroupBy(x=> x.UrunAdi).Select(y => new
            {
                Urunadi = y.Key,
                UrunMiktarı = y.Sum(x=> x.UrunMiktarı),
                

            }).ToList() orderby x.UrunMiktarı descending select x;
            dataGridView1.DataSource = bul.Select(x => new
            {
               Ürün_adı= x.Urunadi,
                
               Satış_Adedi= x.UrunMiktarı,
            }).ToList();

             
        }
    }
}
