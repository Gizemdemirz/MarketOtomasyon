using MarketOtamasyon.Contexts;
using MarketOtamasyon.Entities;
using MarketOtamasyon.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtamasyon
{
    public partial class satisSayfasi : Form
    {
        public satisSayfasi()
        {
            InitializeComponent();
        }


        private void müşteriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriListele musteriListele = new MusteriListele();
            musteriListele.ShowDialog();
            
        }

        private void ürünListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunIslemleri urunIslemleri = new urunIslemleri();
            urunIslemleri.ShowDialog();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stok stok = new stok();
            stok.ShowDialog();
        }

        OtomasyonContext otomasyonContext = new OtomasyonContext();
        private void satisSayfasi_Load(object sender, EventArgs e)
        {
            var musteriListe = otomasyonContext.Musteris.Select(x => new
            {
                x.MusteriId,
                MusteriAd = x.MusteriAdi + " " + x.MusteriSoyadi
            }).ToList();
            cmboxMusteri.DataSource = musteriListe;
            cmboxMusteri.DisplayMember = "MusteriAd";
            cmboxMusteri.ValueMember = "MusteriId";
            cmboxMusteri.Text= "";
            cmboxMusteri.SelectedIndex = -1;
            cmboxSecim.Items.Add ("Peşin");
            cmboxSecim.Items.Add("Veresiye");
          SepetListele();
            Tutar();
            
        }
        private void SepetListele()
        {
            var liste = from x in otomasyonContext.Sepet
                        select new
                        {
                            Barkod_No = x.UrunBarkodNo,
                            Ürün_Adı = x.UrunAdi,
                            Miktar = x.miktar,
                            Tutar = x.tutar,
                        };
            dataGridView1.DataSource = liste.ToList();

        }
        void Tutar()
        {
            try
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    var ToplamTutar = otomasyonContext.Sepet.Sum(x => x.tutar);
                    lblToplamTutar.Text = ToplamTutar.ToString();
                    lblT.Text = "Toplam sepet tutarı: ";
                }
                else
                {
                    lblToplamTutar.Text = "";
                    lblT.Text = "";
                }
            }
            catch
            {

            }
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtMiktar)
                        {
                            item.Text = "";
                        }
                    }
                }

            }

            else
            {
                var ara = from Urun in otomasyonContext.Uruns
                          where Urun.barkodNo.ToString() == txtBarkodNo.Text
                          select Urun;

                foreach (var item in ara)
                {

                    txtUrunAdi.Text = item.UrunAdi;
                    txtSatisFiyati.Text = item.satisFiyati.ToString();
                }
            }
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var barkod = int.Parse(txtBarkodNo.Text);
                var urun = otomasyonContext.Uruns.FirstOrDefault(x => x.barkodNo.ToString() == barkod.ToString());
                int urunMiktar = urun.miktar;
                if (int.Parse(txtMiktar.Text) > urunMiktar)
                {
                    MessageBox.Show("Ürün stok adedi :" + urunMiktar);
                    txtMiktar.Text = "1";
                }

                txtTutar.Text = (double.Parse(txtMiktar.Text) * double.Parse(txtSatisFiyati.Text)).ToString();
            }
            catch
            {

            }
        }

        private void txtSatisFiyati_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTutar.Text = (double.Parse(txtMiktar.Text) * double.Parse(txtSatisFiyati.Text)).ToString();
            }
            catch (Exception)
            {

            }
        }
        void TextBoxTemizle()
        {
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtMiktar)
                    {
                        item.Text = "";
                    }
                    else
                    {
                        item.Text = "1";
                    }
                }
            }
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {

                var ara = from x in otomasyonContext.Sepet
                          where x.UrunBarkodNo.ToString() == txtBarkodNo.Text
                          select x;

                if (ara.Any())
                {
                    foreach (var item in ara)
                    {
                        item.miktar += int.Parse(txtMiktar.Text);
                        item.tutar += double.Parse(txtTutar.Text);

                    }
                    otomasyonContext.SaveChanges();

                }
                else
                {

                    var sepet = new Sepet();

                    sepet.UrunBarkodNo = int.Parse(txtBarkodNo.Text);
                    sepet.UrunAdi = txtUrunAdi.Text;
                    sepet.miktar = int.Parse(txtMiktar.Text.ToString());
                    sepet.tutar = double.Parse(txtTutar.Text);

                    otomasyonContext.Sepet.Add(sepet);
                    otomasyonContext.SaveChanges();
                }
                MessageBox.Show("Ürün Sepete Eklendi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TextBoxTemizle();
                SepetListele();
                Tutar();

            }
            catch
            {
                MessageBox.Show("Lütfen işleminizi konrol ediniz!!");
            }
        }     
       

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count != 0)
                {
                    var barkodNo = dataGridView1.CurrentRow.Cells[0].Value;
                    var urun = otomasyonContext.Sepet.FirstOrDefault(x => x.UrunBarkodNo.ToString() == barkodNo.ToString());
                    otomasyonContext.Sepet.Remove(urun);
                    otomasyonContext.SaveChanges();
                    MessageBox.Show("Ürün sepetten çıkarıldı.", "Sepet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SepetListele();
                    Tutar();
                }
                else
                {
                    MessageBox.Show("Silinecek ürün yok!!");
                }
             }
            catch
            {
                MessageBox.Show("Lütfen işleminizi kontrol ediniz!!");
            }

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    var barkodNo = dataGridView1.Rows[i].Cells[0].Value;
                    var urun = otomasyonContext.Sepet.FirstOrDefault(x => x.UrunBarkodNo.ToString() == barkodNo.ToString());
                    otomasyonContext.Sepet.Remove(urun);
                    otomasyonContext.SaveChanges();
                } MessageBox.Show("Ürünler sepetten çıkarıldı.", "Sepet", MessageBoxButtons.OK, MessageBoxIcon.Information);
               SepetListele();
               Tutar();
            }

               
        }

     
        void sepetTemizle()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var barkodNo = dataGridView1.Rows[i].Cells[0].Value;
                var urun = from x in otomasyonContext.Sepet
                           join y in otomasyonContext.Uruns
               on x.UrunBarkodNo equals y.barkodNo
                           where x.UrunBarkodNo.ToString() == barkodNo.ToString()
                           select y;
                foreach (var item in urun)
                {
                    item.miktar -= int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());

                }
                var sil = otomasyonContext.Sepet.FirstOrDefault(x => x.UrunBarkodNo.ToString() == barkodNo.ToString());
                otomasyonContext.Sepet.Remove(sil);
                otomasyonContext.SaveChanges();
            }
        }


        private void btnSatis_Click(object sender, EventArgs e)
        {



            if (dataGridView1.Rows.Count != 0 & cmboxSecim.SelectedIndex != -1)
            {



                if (cmboxSecim.SelectedIndex == 1 & cmboxMusteri.SelectedIndex != -1)
                {
                    int id = (int)cmboxMusteri.SelectedValue;
                    Musteri musteri = otomasyonContext.Musteris.Find(id);
                    
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {


                        musteri.Satis.Add(new Satis
                        {
                            UrunBarkodNo = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()),
                            UrunAdi = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                            UrunMiktarı = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()),
                            tutar = double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()),
                            SatisTarihi = DateTime.Now,

                        });

                    }
                    musteri.borc += double.Parse(lblToplamTutar.Text);
                    otomasyonContext.SaveChanges();
                    MessageBox.Show("Satış işlemi gerçekleşti", "Satış", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextBoxTemizle();
                    sepetTemizle();
                    SepetListele();
                    Tutar();
                    cmboxMusteri.SelectedIndex = -1;
                    cmboxSecim.SelectedIndex = -1;
                }
                else if (cmboxSecim.SelectedIndex == 1 & cmboxMusteri.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen müşteri seçiniz!!", "Satış", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        var satis = new Satis();
                        satis.UrunBarkodNo = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        satis.UrunAdi = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        satis.UrunMiktarı = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        satis.tutar = double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                        satis.SatisTarihi = DateTime.Now;
                        otomasyonContext.Satis.Add(satis);
                    }
                    otomasyonContext.SaveChanges();
                    MessageBox.Show("Satış işlemi gerçekleşti", "Satış", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextBoxTemizle();
                    sepetTemizle();
                    SepetListele();
                    Tutar();
                    cmboxMusteri.SelectedIndex = -1;
                    cmboxSecim.SelectedIndex = -1;

                }



            }
            else
            {
                MessageBox.Show("Lütfen işlemlerinizi kontrol edin!", "Satış", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void satışlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            satisListele satisListele = new satisListele();
            satisListele.ShowDialog();
        }

        private void ödemeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdemeIslemleri odemeIslemleri = new OdemeIslemleri();
            odemeIslemleri.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kullanıcıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullanicIslem kullanicIslem = new KullanicIslem();
            kullanicIslem.Show();
        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopluBorc rapor = new TopluBorc();
            rapor.ShowDialog();
        }

        private void ürünBazlıRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunBazliRapor urunBazliRapor = new UrunBazliRapor();
            urunBazliRapor.ShowDialog();
        }

        private void tedarikçiİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TedarikciIslemleri tedarikciIslemleri = new TedarikciIslemleri();
            tedarikciIslemleri.ShowDialog();
        }

        private void satışTrendiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatısTrendi satısTrendi = new SatısTrendi();
            satısTrendi.ShowDialog();
        }

        private void müşteriBazlıRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriBazliRapor musteriBazliRapor = new MusteriBazliRapor();
            musteriBazliRapor.ShowDialog();
        }
    }
}
