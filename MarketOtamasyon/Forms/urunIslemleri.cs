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
    public partial class urunIslemleri : Form
    {
        public urunIslemleri()
        {
            InitializeComponent();
        }
        OtomasyonContext otomasyonContext = new OtomasyonContext();
        void Listele()
        {
            dataGridView1.DataSource = otomasyonContext.Uruns.Select(x => new
            {
                Id = x.UrunId,
                Barkod_No = x.barkodNo,
                Ürün_Adı = x.UrunAdi,
                Miktar = x.miktar,
                Alış_Fiyatı = x.alisFiyati,
                Satış_Fiyatı = x.satisFiyati
            }).ToList();
        }
        private void urunIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
            Kayıt();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtBarkodNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtÜrünAdı.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMiktar.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAlıs.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSatıs.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
         
        }

        void Kayıt()

        {
            try {
                if (otomasyonContext.Uruns.Count() != 0)
                {
                    var KayitSayisi = otomasyonContext.Uruns.Count();
                    lblSayı.Text = "Toplam kayıt sayısı: " + KayitSayisi;

                    var ToplamMiktar = otomasyonContext.Uruns.Sum(x => x.miktar);
                    lblMiktarSayı.Text = "Toplam ürün miktarı: " + ToplamMiktar;
                }
                else
                {
                    lblSayı.Text = "Toplam kayıt sayısı: " + "0";
                    lblMiktarSayı.Text = "Toplam ürün miktarı: " + "0";

                }

            }
            catch
            {

            }
        }
        void Temizle()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }


        }

        

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var ID = dataGridView1.CurrentRow.Cells[0].Value;
                var urun = otomasyonContext.Uruns.FirstOrDefault(x => x.UrunId.ToString() == ID.ToString());
                urun.barkodNo = int.Parse(txtBarkodNo.Text);
                urun.UrunAdi = txtÜrünAdı.Text;
                urun.satisFiyati = double.Parse(txtSatıs.Text);
                otomasyonContext.SaveChanges();
                MessageBox.Show("Kayıt güncellendi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                Listele();
                Kayıt();
            }
            catch
            {
                Temizle();
                MessageBox.Show("Lütfen girdiğiniz bilgileri kontrol edin", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

   
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            var ara = from urun in otomasyonContext.Uruns select urun;
            if (txtAra.Text != null)
            {
                dataGridView1.DataSource = ara.Where(urun => urun.barkodNo.ToString().Contains(txtAra.Text)).Select(x=> new
                {
                    Id = x.UrunId,
                    Barkod_No = x.barkodNo,
                    Ürün_Adı = x.UrunAdi,
                    Miktar = x.miktar,
                    Alış_Fiyatı = x.alisFiyati,
                    Satış_Fiyatı = x.satisFiyati
                }).ToList();

            }
        }
    }
}
