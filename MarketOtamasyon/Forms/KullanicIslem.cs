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
    public partial class KullanicIslem : Form
    {
        public KullanicIslem()
        {
            InitializeComponent();
        }
        OtomasyonContext otomasyonContext = new OtomasyonContext();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(txtAd.Text != "" & txtSifre.Text != "")
            {
                var kullanici = from x in otomasyonContext.Kullanicis where x.KullaniciAdi.Contains(txtAd.Text) select x;
                if (kullanici.Any())
                {
                    MessageBox.Show("Bu kullanıcı adına sahip bir kullanıcı zaten var!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var yeniKullanici = new Kullanici();
                    yeniKullanici.KullaniciAdi = txtAd.Text;
                    yeniKullanici.Sifre = txtSifre.Text;
                    yeniKullanici.sonGirisTarihi = DateTime.Now;
                    otomasyonContext.Kullanicis.Add(yeniKullanici);
                    MessageBox.Show("Yeni kullanıcı eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = otomasyonContext.Kullanicis.ToList();
                }
                otomasyonContext.SaveChanges();
                Temizle();
                KullanıcıListele();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        void Temizle()
        {
            lblId.Text = "";
            txtAd.Text = "";
            txtSifre.Text = "";
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(lblId.Text != "")
            {
                int id = int.Parse(lblId.Text);
                var kullanici = otomasyonContext.Kullanicis.Find(id);
                kullanici.KullaniciAdi = txtAd.Text;
                kullanici.Sifre = txtSifre.Text;
                otomasyonContext.SaveChanges();
                MessageBox.Show("Kullanıcı bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                KullanıcıListele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(lblId.Text != "")
            {
                int id = int.Parse(lblId.Text);
                var kullanici = otomasyonContext.Kullanicis.Find(id);
                otomasyonContext.Kullanicis.Remove(kullanici);
                otomasyonContext.SaveChanges();
                MessageBox.Show("Kullanıcı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                KullanıcıListele();
            }
            
        }

        void KullanıcıListele()
        {
            dataGridView1.DataSource = otomasyonContext.Kullanicis.Select(x => new
            {
                Id= x.KullaniciId,
                Kullanıcı_Adı = x.KullaniciAdi,
                Şifre = x.Sifre,
                Son_Giriş_Tarihi = x.sonGirisTarihi
            }).ToList();
        }
        private void KullanicIslem_Load(object sender, EventArgs e)
        {
            KullanıcıListele();
        }
    }
}
