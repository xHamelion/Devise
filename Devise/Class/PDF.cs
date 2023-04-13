using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Devise
{
    public  class PDF
    {
        public PDF(DataGridView dataGridView1, string name)
        {
            BaseFont bf = BaseFont.CreateFont("C:/Windows/Fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            PdfPTable tb = new PdfPTable(dataGridView1.Columns.Count);
            PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase($"{name}", font));
            cell.Colspan = dataGridView1.Columns.Count;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            tb.AddCell(cell);
            int ia = 0;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                if ("ID" != dataGridView1.Columns[j].HeaderText.Substring(0, 1).ToString()/* && dataGridView1.Columns[j].HeaderText != "ID_Otdelenie"*/)
                {
                    PdfPCell re = new PdfPCell(new iTextSharp.text.Phrase(dataGridView1.Columns[j].HeaderText, font));
                    re.BackgroundColor = BaseColor.ORANGE;
                    tb.AddCell(re);
                }
                else
                    ia++;


            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count - ia; j++)
                {
                    if ("ID" != dataGridView1.Columns[j].HeaderText.Substring(0, 1).ToString())
                        tb.AddCell(new iTextSharp.text.Phrase(dataGridView1.Rows[i].Cells[j].Value.ToString(), font));


                }
            }
            try
            {
                using (SaveFileDialog SFD = new SaveFileDialog())
                {
                    SFD.Filter = "Text files(*.pdf)|*.pdf|All files(*.*)|*.*";
                    if (Holder.UnitTest_Put == null)
                    {
                        SFD.ShowDialog();
                        Holder.UnitTest_Put = SFD.FileName;
                    }

                    using (FileStream str = new FileStream(Holder.UnitTest_Put, FileMode.OpenOrCreate))
                    {
                        iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A2, 5f, 5f, 5f, 0f);
                        PdfWriter.GetInstance(doc, str);
                        doc.Open();
                        doc.Add(cell);
                        doc.Add(tb);
                        doc.Close();
                    }

                }
                Holder.UnitTest_Put = null;
            }
            catch { }
            
        }
    }
}
