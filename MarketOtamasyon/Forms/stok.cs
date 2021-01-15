using MarketOtamasyon.Contexts;
using MarketOtamasyon.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtamasyon.Forms
{
    public partial class stok : Form
    {
        public stok()
        {
            InitializeComponent();
        }
        OtomasyonContext otomasyonContext = new OtomasyonContext();

        private void stok_Load(object sender, EventArgs e)
        {
            var tedarikci= otomasyonContext.Tedarikcis.Select(x => new
            {
                x.TedarikciId,
                 x.Ad,

            }).ToList();
            cmbTedarikci.DataSource = tedarikci;
            cmbTedarikci.DisplayMember = "Ad";
            cmbTedarikci.ValueMember = "TedarikciId";
            cmbTedarikci.Text = "";
            cmbTedarikci.SelectedIndex = -1;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = " Metin dosyaları(*.txt) | *.txt";
            file.FilterIndex = 1;
            file.ShowDialog();
            if(file.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = file.FileName;
                string DosyaAdi = file.SafeFileName;
                var lines = File.ReadAllLines(DosyaYolu);
                if (lines.Count() > 0)
                {
                    foreach (var columnName in lines.FirstOrDefault()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        dataGridView1.Columns.Add(columnName, columnName);
                    }
                    foreach (var cellValues in lines.Skip(1))
                    {
                        var cellArray = cellValues
                            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (cellArray.Length == dataGridView1.Columns.Count)
                            dataGridView1.Rows.Add(cellArray);
                    }
                }
                llblDosyAdi.Text = "Dosya Adi: " + DosyaAdi;
                tutar();
            }
        }

        void tutar()
        {
            double tutar = 0;
            if (dataGridView1.Rows.Count != 0)
            {

                for (int i = 0; i < dataGridView1.Rows.Count-1 ; i++)
                {
                    tutar +=(double) (double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()) * double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()));
                        }
                lblTutar.Text = tutar.ToString();
                label1.Text = "Toplam tutar:";
            }
        }
  
        private void btnStok_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count != 0 & cmbTedarikci.SelectedIndex != -1)
            {
                
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    var barkodNo = dataGridView1.Rows[i].Cells[2].Value;
                    var ara = from x in otomasyonContext.Uruns
                            where x.barkodNo.ToString() == barkodNo.ToString()
                            select x;
                    if (ara.Any())
                    {
                        foreach (var item in ara)
                        {

                            item.alisFiyati = double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                            item.miktar += int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                        }
                    }
                    else
                    {
                        var urun = new Urun();

                        urun.barkodNo = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        urun.UrunAdi = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        urun.alisFiyati = double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                        urun.miktar = int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                        urun.satisFiyati = Math.Round(urun.alisFiyati * 1.2,2);
                        urun.irsaliyeNo = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        otomasyonContext.Uruns.Add(urun);
                        

                    }
                    otomasyonContext.SaveChanges();
                   
                    
                }
               
                int id = (int)cmbTedarikci.SelectedValue;
                Tedarikci tedarikci = otomasyonContext.Tedarikcis.Find(id);
                tedarikci.AlınacakTutar += double.Parse(lblTutar.Text);
                otomasyonContext.SaveChanges();
                lblTutar.Text = "";
                label1.Text = "";
                MessageBox.Show("Ürünler stoğa eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = "";
                llblDosyAdi.Text = "";
                cmbTedarikci.Text = "";
                cmbTedarikci.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Lütfen dosya ve tedarikçi seçtiğinizden emin olun!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
