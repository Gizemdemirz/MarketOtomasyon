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
    public partial class TedarikciIslemleri : Form
    {
        public TedarikciIslemleri()
        {
            InitializeComponent();
        }

        OtomasyonContext otomasyonContext = new OtomasyonContext();
        void TedarikciListele()
        {
            var tedarikci = from x in otomasyonContext.Tedarikcis  select x;
            dataGridView1.DataSource = tedarikci.Select(x => new
            {

                Tedarikçi_Id = x.TedarikciId,
                Ad = x.Ad,
                Borç = x.AlınacakTutar,

            }).ToList();
            Kayit();

        }

       

        

        void Temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtÖdeme.Text = "";
        }
        void Kayit()
        {
            var kayit = dataGridView1.Rows.Count;
            lblKayit.Text = "Kayıt sayısı: " + kayit;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows.Count != 0)
            {

                txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            }
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" & txtÖdeme.Text != "")
            {
                int id = int.Parse(txtID.Text);
                var tedarikci = otomasyonContext.Tedarikcis.Find(id);

                if (double.Parse(txtÖdeme.Text) <= tedarikci.AlınacakTutar & tedarikci.Ad.Contains(txtAd.Text))
                {
                    tedarikci.AlınacakTutar -= int.Parse(txtÖdeme.Text);
                    otomasyonContext.SaveChanges();
                    MessageBox.Show("Ödeme işlemi gerçekleşti.", "Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TedarikciListele();
                    Temizle();

                }
                else
                {
                    MessageBox.Show("Lütfen işlemlerinizi kontrol ediniz!!", "Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                Temizle();

            }
            else
            {
                MessageBox.Show("Lütfen işlemlerinizi kontrol ediniz!!", "Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Temizle();
            }

        }

        private void txtAra_TextChanged_1(object sender, EventArgs e)
        {
           
                var ara = from tedarikci in otomasyonContext.Tedarikcis select tedarikci;
                if (txtAra.Text != null)
                {
                        dataGridView1.DataSource = ara.Where(x => x.Ad.Contains(txtAra.Text)).Select(x => new
                        {
                            Tedarikçi_Id = x.TedarikciId,
                            Ad = x.Ad,
                            Alınacak_Tutar = x.AlınacakTutar,

                        }).ToList();
                        Kayit();

                }
               

      
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(txtTAdı.Text != "")
            {
                var bul = from x in otomasyonContext.Tedarikcis where x.Ad == txtTAdı.Text select x;
                if (bul.Any())
                {
                    MessageBox.Show("Bu isme sahip bir tedarikçi zaten var!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                      
                }
                else
                {
                    var tedarikci = new Tedarikci();
                    tedarikci.Ad = txtTAdı.Text;
                    tedarikci.AlınacakTutar = 0;
                    otomasyonContext.Tedarikcis.Add(tedarikci);
                    otomasyonContext.SaveChanges();
                    TedarikciListele();
                }
                txtTAdı.Text = "";
            }
        }

        private void TedarikciIslemleri_Load(object sender, EventArgs e)
        {
            TedarikciListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (txtTAdı.Text != "")
            {
                var tedarikci = from x in otomasyonContext.Tedarikcis where x.Ad == txtTAdı.Text select x;
                if (tedarikci.Any())
                {
                    foreach(var item in tedarikci)
                    {
                        otomasyonContext.Tedarikcis.Remove(item);
                        
                    }
                    
                }
                otomasyonContext.SaveChanges();
                TedarikciListele();
                txtTAdı.Text = "";
            }
        }
    }
}
