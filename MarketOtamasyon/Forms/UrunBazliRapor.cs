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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace MarketOtamasyon.Forms
{
    public partial class UrunBazliRapor : Form
    {
        public UrunBazliRapor()
        {
            InitializeComponent();
        }

        OtomasyonContext otomasyonContext = new OtomasyonContext();
        private void UrunBazliRapor_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = otomasyonContext.Uruns.Select(x => new
            {
                x.UrunAdi,
                x.alisFiyati,
                x.satisFiyati,
                Kar = (int)(((double)(x.satisFiyati - x.alisFiyati) / x.alisFiyati) * 100)
            }).ToList();

            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                this.chart1.Series["Kar"].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString()));
                    
            }

        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.OverwritePrompt = false;
                save.Title = "PDF Dosyaları";
                save.DefaultExt = "pdf";
                save.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Tüm Dosyalar(*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);


                    pdfTable.DefaultCell.Padding = 3;
                    pdfTable.WidthPercentage = 80;
                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                    pdfTable.DefaultCell.BorderWidth = 1;


                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240); // hücre arka plan rengi
                        pdfTable.AddCell(cell);
                    }
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(cell.Value.ToString());
                            }
                        }
                    }
                    catch (NullReferenceException)
                    {
                    }
                    using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                    {
                        iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A2, 10f, 10f, 10f, 0f);// sayfa boyutu.
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                    }
                }
            }
        }
    }
}
