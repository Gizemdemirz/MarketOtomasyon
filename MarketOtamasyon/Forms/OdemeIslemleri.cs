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
    public partial class OdemeIslemleri : Form
    {
        public OdemeIslemleri()
        {
            InitializeComponent();
        }
        OtomasyonContext otomasyonContext = new OtomasyonContext();
        private void OdemeIslemleri_Load(object sender, EventArgs e)
        {
            BorcListele();
            Kayit();
           
        }


        void BorcListele()
        {
            var borclu = from x in otomasyonContext.Musteris where x.borc != 0 select x;
            dataGridView1.DataSource = borclu.Select(x => new
            {

                Id = x.MusteriId,
                Ad = x.MusteriAdi,
                Soyad = x.MusteriSoyadi,
                Borc = Math.Round(x.borc, 2),
            }).ToList();
            lblAra.Visible = true;
            txtAra.Visible = true;

        }

     
       
        void Borc()
        {
            if (txtId.Text != "")
            {
                int id = int.Parse(txtId.Text);
                var musteri = otomasyonContext.Musteris.Find(id);
                if(Math.Round(musteri.borc, 2) <= 0)
                {
                    musteri.borc = 0;
                }
                lblToplam.Text = "Toplam Borç:";
                lblBorc.Text = Math.Round(musteri.borc, 2).ToString();
            }
        }


        void Kayit()
        {
            var kayit = dataGridView1.Rows.Count;
            lblKayit.Text = "Kayıt sayısı:";
            lblKytsyi.Text = kayit.ToString();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)

        {
            if (dataGridView1.Rows.Count != 0)
            {
                lblAra.Visible = false;
                txtAra.Visible = false;
              
                txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                var id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                var detay = from x in otomasyonContext.Musteris
                            join
                      y in otomasyonContext.Satis on x.MusteriId equals y.Musteri.MusteriId
                            where x.MusteriId.ToString() == id.ToString()
                            select y;
                
                dataGridView1.DataSource = detay.Select(x => new
                {
                    Ad = x.Musteri.MusteriAdi,
                    Soyad = x.Musteri.MusteriSoyadi,
                    Tutar = x.tutar,
                    Satış_Fiyatı = x.SatisTarihi

                }).ToList();
                Borc();
                Kayit();
            }

      
        }


        private void btnOdeme_Click(object sender, EventArgs e)
        {
            Kayit();
           if(txtId.Text != "" & txtÖdeme.Text !="" & txtAd.Text != "" & txtSoyad.Text!="")
            {
                int id = int.Parse(txtId.Text);
                var musteri = otomasyonContext.Musteris.Find(id);
                if (musteri != null)
                {
                    if (double.Parse(txtÖdeme.Text) <= musteri.borc & musteri.MusteriAdi.Contains(txtAd.Text) & musteri.MusteriSoyadi.Contains(txtSoyad.Text))
                    {
                        musteri.borc -= double.Parse(txtÖdeme.Text);
                        otomasyonContext.SaveChanges();
                        MessageBox.Show("Ödeme işlemi gerçekleşti.", "Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Borc();
                        BorcListele();
                        Temizle();
                        lblToplam.Text = "";
                        lblBorc.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Lütfen ödenen tutarı kontrol ediniz!!", "Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();

                    }
                }
                else
                {
                    MessageBox.Show("Lütfen işlemlerinizi kontrol ediniz!!", "Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Temizle();
                }


            }
           else 
            {
                MessageBox.Show("Lütfen ödeme bilgilerini kontrol ediniz!","Ödeme",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
           

                var ara = from musteri in otomasyonContext.Musteris where musteri.borc != 0 & (musteri.MusteriAdi.Contains(txtAra.Text) || musteri.MusteriSoyadi.Contains(txtAra.Text)) select musteri;
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
        void Temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtÖdeme.Text = "";
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Temizle();
            BorcListele();
            Kayit();
            lblToplam.Text = "";
            lblBorc.Text = "";
        }
    }
}
