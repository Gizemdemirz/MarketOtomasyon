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

        }


        void BorcListele()
        {
            var borclu = from x in otomasyonContext.Musteris where x.borc != 0 select x;
            dataGridView1.DataSource = borclu.Select(x => new
            {
                
                x.MusteriId,
                x.MusteriAdi,
                x.MusteriSoyadi,
                x.borc
            }).ToList();

        }

     
        private void btnBorç_Click(object sender, EventArgs e)
        {
            BorcListele();
            Kayit();
          
        }

        void Borc()
        {
            if(lblId.Text != "") { 
            int id = int.Parse(lblId.Text);
            Musteri musteri = otomasyonContext.Musteris.Find(id);
            lblToplam.Text = "Toplam Borç:";
            lblBorc.Text = musteri.borc.ToString();
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
                lblId.Visible = false;
                lblId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
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
                    x.Musteri.MusteriAdi,
                    x.Musteri.MusteriSoyadi,
                    x.tutar,
                    x.SatisTarihi

                }).ToList();
                Borc();
                Kayit();
            }

      
        }


        private void btnOdeme_Click(object sender, EventArgs e)
        {
            Kayit();
           if(lblId.Text != "" & txtÖdeme.Text !="")
            {
                int id = int.Parse(lblId.Text);
                Musteri musteri = otomasyonContext.Musteris.Find(id);

                if (double.Parse(txtÖdeme.Text) <= musteri.borc)
                {
                    musteri.borc -= double.Parse(txtÖdeme.Text);
                    otomasyonContext.SaveChanges();
                    MessageBox.Show("Ödeme işlemi gerçekleşti.", "Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Borc();
                    BorcListele();
                    Temizle();

                }
                else
                {
                    MessageBox.Show("Lütfen ödenen tutarı kontrol ediniz!!", "Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dataGridView1.Rows.Count != 0)
            {

                var ara = from musteri in otomasyonContext.Musteris where musteri.borc != 0 & (musteri.MusteriAdi.Contains(txtAra.Text) || musteri.MusteriSoyadi.Contains(txtAra.Text)) select musteri;
                if (txtAra.Text != null)
                {
                    dataGridView1.DataSource = ara.Select(x => new
                    {
                        x.MusteriId,
                        x.MusteriAdi,
                        x.MusteriSoyadi,
                        x.borc
                    }).ToList();

                }
            }
                
            
        }
        void Temizle()
        {
            lblId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtÖdeme.Text = "";
        }
    }
}
