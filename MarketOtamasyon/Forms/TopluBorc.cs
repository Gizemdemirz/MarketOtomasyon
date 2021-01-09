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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
namespace MarketOtamasyon.Forms
{
   
    public partial class TopluBorc : Form
    {
        public TopluBorc()
        {
            InitializeComponent();
        }

        OtomasyonContext otomasyonContext = new OtomasyonContext();
        private void btnBorc_Click(object sender, EventArgs e)
        {
            
            var musteriSatis = (from x in otomasyonContext.Musteris
                        join
                  y in otomasyonContext.Satis on x.MusteriId equals y.Musteri.MusteriId
                  where x.borc != 0
                        select x );
        
            dataGridView1.DataSource = musteriSatis.Select(x => new
            {
                AdSoyad = x.MusteriAdi + " " + x.MusteriSoyadi,
                ToplamSatis = x.Satis.Count(),
                ToplamÖdeme = x.Satis.Sum(y=> y.tutar) - x.borc,
                KalanBorc = x.borc

            }).Distinct().ToList() ;
        

        }


        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {

                Excel.Application excel = new Excel.Application();
                excel.Visible = true;
                object Missing = Type.Missing;
                Workbook workbook = excel.Workbooks.Add(Missing);
                Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Excel.Range myRange = (Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;

                }
                StartRow++;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        Excel.Range myRange = (Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        myRange.Select();
                    }
                }
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
                    using (FileStream stream = new FileStream(save.FileName , FileMode.Create))
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

        private void btnWord_Click(object sender, EventArgs e)
        {

            /* SaveFileDialog save = new SaveFileDialog();
             save.OverwritePrompt = false;
             save.Title = "Word Dosyaları";
             save.DefaultExt = "docx";
             save.Filter = "Word Dosyaları (*.docx)|*.docx|Tüm Dosyalar(*.*)|*.*";
             if (save.ShowDialog() == DialogResult.OK)
             {*/
            if (dataGridView1.Rows.Count != 0)
            {
                Word.Application word = new Word.Application();
                object missing = Type.Missing;
                Word.Document WordDocument = word.Documents.Add(missing);

                word.Visible = true;
                WordDocument.PageSetup.PaperSize = Word.WdPaperSize.wdPaperA4;


                word.Selection.Font.Bold = (int)Word.WdConstants.wdFirst;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    word.Selection.TypeText(dataGridView1.Columns[j].HeaderText.ToString() + "   ");


                }
                word.Selection.TypeParagraph();
                //datagridview'deki verileri word e aktardık.
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        word.Selection.TypeText(dataGridView1[j, i].Value.ToString() + "          ");
                    }
                    word.Selection.TypeParagraph();
                }

            }
            /*using (FileStream stream = new FileStream(save.FileName , FileMode.Create))
            {


                stream.Close();
            }*/



        }
    
    }
}
