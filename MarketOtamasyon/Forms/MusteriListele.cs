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
    public partial class MusteriListele : Form
    {
        public MusteriListele()
        {
            InitializeComponent();
        }
        OtomasyonContext otomasyonContext = new OtomasyonContext();
        void Listele()
        {
            dataGridView1.DataSource = otomasyonContext.Musteris.Select(x => new
            {
                Id = x.MusteriId,
                Ad = x.MusteriAdi,
                Soyad = x.MusteriSoyadi,
                Borç = Math.Round(x.borc, 2),
            }).ToList();
        }
        private void MusteriListele_Load(object sender, EventArgs e)
        {
            Listele();
            Kayıt();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        void Kayıt()
        {
            var KayitSayisi = otomasyonContext.Musteris.Count();
            lblKayıt.Text = "Toplam kayıt sayısı: " + KayitSayisi;


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
            if (txtAd.Text != "" & txtSoyad.Text != "")
            {
                var ID = dataGridView1.CurrentRow.Cells[0].Value;
                var musteri = otomasyonContext.Musteris.FirstOrDefault(x => x.MusteriId.ToString() == ID.ToString());
                var ara = otomasyonContext.Musteris.FirstOrDefault(x => x.MusteriAdi == txtAd.Text & x.MusteriSoyadi == txtSoyad.Text);
                if (ara == null)
                {
                    musteri.MusteriAdi = txtAd.Text;
                    musteri.MusteriSoyadi = txtSoyad.Text;
                    otomasyonContext.SaveChanges();
                    MessageBox.Show("Kayıt güncellendi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    Listele();
                    Kayıt();
                }
                else
                {
                    MessageBox.Show("Bu isme sahip bir müşteri zaten var.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" & txtSoyad.Text != "")
            {
                var ara = otomasyonContext.Musteris.FirstOrDefault(x => x.MusteriAdi == txtAd.Text & x.MusteriSoyadi == txtSoyad.Text);


                if (ara != null)
                {
                    int Id = ara.MusteriId;
                    var satıs = otomasyonContext.Satis.FirstOrDefault(x => x.Musteri.MusteriId == Id);
                    if (satıs != null)
                    {
                        otomasyonContext.Satis.Remove(satıs);
                    }

                    otomasyonContext.Musteris.Remove(ara);

                    otomasyonContext.SaveChanges();

                    MessageBox.Show("Kayıt silindi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();

                    Listele();
                    Kayıt();
                }
                else
                {
                    MessageBox.Show("Lütfen işleminizi kontrol ediniz!!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Temizle();
                }

            }

        }
    
        

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            
         
             var ara = from musteri in otomasyonContext.Musteris 
             where musteri.MusteriAdi.Contains(txtAra.Text) || musteri.MusteriSoyadi.Contains(txtAra.Text) 
                       select musteri;
            if (txtAra.Text != null)
            {
                dataGridView1.DataSource = ara.Select(x => new
                {
                    Id = x.MusteriId,
                    Ad = x.MusteriAdi,
                    Soyad = x.MusteriSoyadi,
                    Borç = Math.Round(x.borc, 2),
                }).ToList();


            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" & txtSoyad.Text != "")
            {
                var bul = from x in otomasyonContext.Musteris where x.MusteriAdi == txtAd.Text & x.MusteriSoyadi == txtSoyad.Text select x;
                if (bul.Any())
                {
                    MessageBox.Show("Bu isimde bir müşteri zaten var!!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Temizle();
                }
                else
                {

                    var musteri = new Musteri();
                    musteri.MusteriAdi = txtAd.Text;
                    musteri.MusteriSoyadi = txtSoyad.Text;
                    musteri.borc = 0;
                    otomasyonContext.Musteris.Add(musteri);
                    otomasyonContext.SaveChanges();
                    MessageBox.Show("Kayıt Eklendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    Listele();
                    Kayıt();
                }
            }
        }

    
    }
}
