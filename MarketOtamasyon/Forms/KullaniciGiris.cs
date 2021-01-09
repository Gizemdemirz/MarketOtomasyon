using MarketOtamasyon.Contexts;
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
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }
        OtomasyonContext otomasyonContext = new OtomasyonContext();
        private void btnGiris_Click(object sender, EventArgs e)
        { var kullanici = from x in otomasyonContext.Kullanicis where x.KullaniciAdi == txtAd.Text.Trim() & x.Sifre == txtSifre.Text.Trim()
                    select x;
            
            if (kullanici.Any())
            {
            
                foreach(var item in kullanici)
                {
                    item.sonGirisTarihi = DateTime.Now;
                }
                otomasyonContext.SaveChanges();
                this.Hide();
                satisSayfasi satisSayfasi = new satisSayfasi();
                satisSayfasi.Show();
            
            }
            else
            {
                lblMesaj.Text = "Kullanıcı adı ve/veya şifre yanlış!!";
                txtAd.Text = "";
                txtSifre.Text = "";
            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
