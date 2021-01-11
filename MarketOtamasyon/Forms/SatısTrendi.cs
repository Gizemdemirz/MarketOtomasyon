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
    public partial class SatısTrendi : Form
    {
        public SatısTrendi()
        {
            InitializeComponent();
        }
        OtomasyonContext otomasyonContext = new OtomasyonContext();
        private void SatısTrendi_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = otomasyonContext.Satis.Select(x => new
            {
                Barkod_No = x.UrunBarkodNo,
                Tutar = x.tutar,
                Satış_Tarihi = x.SatisTarihi
            }).ToList();
           Grafik();
        }

        void Grafik()
        {
            chart1.Series["Satış"].Points.Clear();
            dataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                this.chart1.Series["Satış"].Points.AddXY((dataGridView1.Rows[i].Cells[2].Value.ToString()),
                  Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString()));

            }
        }
        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            
            var bul = from x in otomasyonContext.Satis
                      where x.SatisTarihi >= BasTarih.Value & x.SatisTarihi <= BitTarih.Value
                      select x;
            dataGridView1.DataSource = bul.Select(x => new
            {
                Barkod_No = x.UrunBarkodNo,
                Tutar = x.tutar,
                Satış_Tarihi = x.SatisTarihi
            }).ToList();
            Grafik();
        }
    }
}
