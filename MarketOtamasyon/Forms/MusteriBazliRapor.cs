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
    public partial class MusteriBazliRapor : Form
    {
        public MusteriBazliRapor()
        {
            InitializeComponent();
        }
        OtomasyonContext otomasyonContext = new OtomasyonContext();

        void MusteriListele()
        {
            dataGridView1.DataSource = otomasyonContext.Musteris.Select(x => new
            {
                x.MusteriId,
                x.MusteriAdi,
                x.MusteriSoyadi
            }).ToList();
        }
        private void MusteriBazliRapor_Load(object sender, EventArgs e)
        {
            MusteriListele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
             
                var id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                var detay = from x in otomasyonContext.Musteris
                            join
                      y in otomasyonContext.Satis on x.MusteriId equals y.Musteri.MusteriId
                            select y;
                var nolur = detay.GroupBy(z => z.UrunAdi).Select(y => new
                {
                    UrunAdi = y.Key,
                    UrunMiktarı = y.Sum(z => z.UrunMiktarı),
                    tutar = y.Sum(z=> z.tutar)

                }).ToList().OrderByDescending(z=> z.UrunMiktarı);

                dataGridView1.DataSource = nolur.Select(x => new
                {
                    x.UrunAdi,
                    x.UrunMiktarı,
                    x.tutar
                }).ToList();


             
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            MusteriListele();
        }
    }
}
