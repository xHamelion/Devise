using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Devise
{
    public partial class F_Vibitie_Naklad : Form
    {

        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        int position=0;

        public F_Vibitie_Naklad()
        {
            InitializeComponent();
            this.Activated += (a, e) =>
            {
                new PereshetZakaza();
                viewNakladProdagBindingSource.Position = position;

                F_Vibitie_Naklad_Load(null, null);
                viewNakladProdagBindingSource.Position = position;
                ms.Open();
                try
                {
                    //F_Vibitie_Naklad_Load(null, null);
                    if (dataGridView1.RowCount > 1)
                    {
                        com = new SqlCommand($"update Naklad_Prodag set Summa_Obh = '" +
                    $"{Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value) + Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value)}" +
                    $"'where (ID_Naklad_Prodag = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}') ", ms);
                        com.ExecuteNonQuery();
                    }

                }
                catch { }

                ms.Close();
                F_Vibitie_Naklad_Load(null, null);

                viewNakladProdagBindingSource.Position = position;


            };
        }

        private void Exel_Click(object sender, EventArgs e)
        {
            new Exel(dataGridView1, "Накладные выбытия");

        }

        private void PDF_Click(object sender, EventArgs e)
        {
            new PDF(dataGridView1, "Накладные выбытия");

        }

        private void BTN_Dell_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                position = viewNakladProdagBindingSource.Position;
                DialogResult dr = MessageBox.Show("Желаете удалить?", $"Удаление", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {

                    ms.Open();
                    com = new SqlCommand($"delete from [Sost_Naklad_Prodag] " +
                        $"where(ID_Naklad_Prodag = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}')", ms);
                    com.ExecuteNonQuery();
                    com = new SqlCommand($"delete from [Naklad_Prodag] " +
                        $"where(ID_Naklad_Prodag = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}')", ms);
                    com.ExecuteNonQuery();
                    ms.Close();
                    F_Vibitie_Naklad_Load(null, null);
                }
            this.view_Naklad_ProdagTableAdapter.Fill(this.deviseDataSet.View_Naklad_Prodag);
                viewNakladProdagBindingSource.Position = position;

            }

        }

        private void BTN_Dob_Click(object sender, EventArgs e)
        {
            position = viewNakladProdagBindingSource.Position;
            var dob = new F_D_R_Vibitie_Nakladn();
            dob.BTN_Red_Save.Text = "Сохранить";
            dob.Text = "Создать запись";
            dob.ShowDialog();
            this.view_Naklad_ProdagTableAdapter.Fill(this.deviseDataSet.View_Naklad_Prodag);
            viewNakladProdagBindingSource.Position = position;

        }

        private void BTN_Red_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                position = viewNakladProdagBindingSource.Position;
                var dob = new F_D_R_Vibitie_Nakladn();
                dob.DTP.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
                dob.TB_Nomer.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dob.BTN_Red_Save.Text = "Редактировать";
                dob.Text = "Редактировать запись";
                dob.Summa = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                dob.Summa_Obh = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                dob.TB_Dost.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                dob.ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dob.Show();
                dob.comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
                dob.CB_Sotrud.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value;
                this.Enabled = false;
            this.view_Naklad_ProdagTableAdapter.Fill(this.deviseDataSet.View_Naklad_Prodag);
                viewNakladProdagBindingSource.Position = position;
            }

        }

        private void F_Vibitie_Naklad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_Sklad". При необходимости она может быть перемещена или удалена.
            this.view_SkladTableAdapter.Fill(this.deviseDataSet.View_Sklad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_Naklad_Prodag". При необходимости она может быть перемещена или удалена.
            this.view_Naklad_ProdagTableAdapter.Fill(this.deviseDataSet.View_Naklad_Prodag);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_Naklad_Prodag". При необходимости она может быть перемещена или удалена.
            this.view_Naklad_ProdagTableAdapter.Fill(this.deviseDataSet.View_Naklad_Prodag);
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_Naklad_Prodag". При необходимости она может быть перемещена или удалена.
            this.view_Naklad_ProdagTableAdapter.Fill(this.deviseDataSet.View_Naklad_Prodag);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 1)
                {
                    position = viewNakladProdagBindingSource.Position;
                    var f = new F_Sost_Nakladnoi_Prodag();
                    f.ID = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    f.ShowDialog();
                    viewNakladProdagBindingSource.Position = position;

                }
            }
            catch { }
           
        }

        public void check()
        {
            if (Holder.TestTatus)
                viewNakladProdagBindingSource.Position = 0;
            this.hranim_Sost_Naklad_ProdagTableAdapter.Fill(this.deviseDataSet.Hranim_Sost_Naklad_Prodag, (int)dataGridView1.CurrentRow.Cells[0].Value);
            int z = viewNakladProdagBindingSource.Position;
            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A6, 0f, 0f, 0f, 0f);
            if (Holder.UnitTest_Put == null)
            {
                saveFileDialog1.ShowDialog();
                Holder.UnitTest_Put = saveFileDialog1.FileName;
            }
            if (Holder.UnitTest_Put.IndexOf(".pdf") > -1)
            {
            }
            else
                Holder.UnitTest_Put += ".pdf";
            viewNakladProdagBindingSource.Position = z;
            PdfWriter.GetInstance(doc, new FileStream(Holder.UnitTest_Put, FileMode.Create));
            doc.Open();
            BaseFont bf = BaseFont.CreateFont("C:/Windows/Fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

            PdfPTable tb = new PdfPTable(1);
            PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase("ООО \"Девайс\"\n\n\n", font));
            cell.HorizontalAlignment = 1;
            cell.Colspan = 1;
            cell.Border = 0;
            tb.AddCell(cell);
            doc.Add(tb);

            tb = new PdfPTable(2);
             cell = new PdfPCell(new iTextSharp.text.Phrase("Клиент", font));
            cell.HorizontalAlignment = 0;
            cell.Colspan = 1;
            cell.Border = 0;
            tb.AddCell(cell);
            cell = new PdfPCell(new iTextSharp.text.Phrase(dataGridView1.CurrentRow.Cells[3].Value.ToString(), font));
            cell.Border = 0;
            tb.AddCell(cell);
            cell = new PdfPCell(new iTextSharp.text.Phrase("Продавец", font));
            cell.Border = 0;
            tb.AddCell(cell);
            cell = new PdfPCell(new iTextSharp.text.Phrase(dataGridView1.CurrentRow.Cells[4].Value.ToString(), font));
            cell.Border = 0;
            tb.AddCell(cell);

            cell = new PdfPCell(new iTextSharp.text.Phrase("Номер продажи", font));
            cell.Border = 0;
            tb.AddCell(cell);
            cell = new PdfPCell(new iTextSharp.text.Phrase(dataGridView1.CurrentRow.Cells[6].Value.ToString(), font));
            cell.Border = 0;
            tb.AddCell(cell);

           

            cell = new PdfPCell(new iTextSharp.text.Phrase("Дата покупки", font));
            cell.Border = 0;
            tb.AddCell(cell);
            cell = new PdfPCell(new iTextSharp.text.Phrase(Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value).ToString(), font));
            cell.Border = 0;
            tb.AddCell(cell);


            cell = new PdfPCell(new iTextSharp.text.Phrase("Товары:", font));
            cell.Border = 0;
            tb.AddCell(cell);
            cell = new PdfPCell(new iTextSharp.text.Phrase("", font));
            cell.Border = 0;
            tb.AddCell(cell);

            doc.Add(tb);
            tb = new PdfPTable(3);

            cell = new PdfPCell(new iTextSharp.text.Phrase("Товар", font));
            tb.AddCell(cell);

            cell = new PdfPCell(new iTextSharp.text.Phrase("Количество", font));
            tb.AddCell(cell);

            cell = new PdfPCell(new iTextSharp.text.Phrase("Цена", font));
            tb.AddCell(cell);

            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                cell = new PdfPCell(new iTextSharp.text.Phrase(dataGridView2.Rows[i].Cells[6].Value.ToString(), font));
                tb.AddCell(cell);

                cell = new PdfPCell(new iTextSharp.text.Phrase(dataGridView2.Rows[i].Cells[8].Value.ToString() + " штук", font));
                tb.AddCell(cell);

                cell = new PdfPCell(new iTextSharp.text.Phrase(dataGridView2.Rows[i].Cells[10].Value.ToString() + " руб.", font));
                tb.AddCell(cell);
            }

            cell = new PdfPCell(new iTextSharp.text.Phrase("Цена по товарам", font));
            cell.Border = 0;
            cell.HorizontalAlignment = 0;
            tb.AddCell(cell);
            cell = new PdfPCell(new iTextSharp.text.Phrase(dataGridView1.CurrentRow.Cells[7].Value.ToString() + " руб.", font));
            cell.Border = 0;
            cell.HorizontalAlignment = 0;
            tb.AddCell(cell);
            cell = new PdfPCell(new iTextSharp.text.Phrase("", font));
            cell.Border = 0;
            tb.AddCell(cell);

            cell = new PdfPCell(new iTextSharp.text.Phrase("Доставка", font));
            cell.Border = 0;
            cell.HorizontalAlignment = 0;
            tb.AddCell(cell);
            cell = new PdfPCell(new iTextSharp.text.Phrase(dataGridView1.CurrentRow.Cells[8].Value.ToString() + " руб.", font));
            cell.Border = 0;
            cell.HorizontalAlignment = 0;
            tb.AddCell(cell);
            cell = new PdfPCell(new iTextSharp.text.Phrase("", font));
            cell.Border = 0;
            tb.AddCell(cell);

            cell = new PdfPCell(new iTextSharp.text.Phrase("Сумма к оплате", font));
            cell.Border = 0;
            cell.HorizontalAlignment = 0;
            tb.AddCell(cell);
            cell = new PdfPCell(new iTextSharp.text.Phrase(dataGridView1.CurrentRow.Cells[9].Value.ToString() + " руб.", font));
            cell.Border = 0;
            cell.HorizontalAlignment = 0;
            tb.AddCell(cell);
            cell = new PdfPCell(new iTextSharp.text.Phrase("", font));
            cell.Border = 0;
            tb.AddCell(cell);
            doc.Add(tb);
             tb = new PdfPTable(1);
             cell = new PdfPCell(new iTextSharp.text.Phrase("\nГ. Вельск, ул. Дзержинского, д. 107, \"Девайс\"", font));
            cell.HorizontalAlignment = 1;
            cell.Colspan = 1;
            cell.Border = 0;
            tb.AddCell(cell);
            doc.Add(tb);
            doc.Close();
            Holder.UnitTest_Put = null;

        }

        public void button1_Click(object sender, EventArgs e)
        {

            position = viewNakladProdagBindingSource.Position;
            ms.Open();
            try
            {
                F_Vibitie_Naklad_Load(null, null);
                viewNakladProdagBindingSource.Position = position;
                if (dataGridView1.RowCount > 1)
                {
                    com = new SqlCommand($"update Naklad_Prodag set Summa_Obh = '" +
                $"{Convert.ToDouble(dataGridView1.CurrentRow.Cells[7].Value) + Convert.ToDouble(dataGridView1.CurrentRow.Cells[8].Value)}" +
                $"'where (ID_Naklad_Prodag = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}') ", ms);
                    com.ExecuteNonQuery();
                }

            }
            catch { }

            ms.Close();
            viewNakladProdagBindingSource.Position = position;

            if (dataGridView1.RowCount > 1)
            {
                position = viewNakladProdagBindingSource.Position;
                check();
                ms.Open();



                this.hranim_Sost_Naklad_ProdagTableAdapter.Fill(this.deviseDataSet.Hranim_Sost_Naklad_Prodag, (int)dataGridView1.CurrentRow.Cells[0].Value);

                int stchet = 0;
                SqlCommand[] mass = new SqlCommand[1000];

                for (int i = 0; i < dataGridView2.RowCount - 1; i++)
                {
                    com = new SqlCommand($"select count (*) from [Sklad] where (ID_Tovar = " +
                       $"'{dataGridView2.Rows[i].Cells[1].Value}')", ms);
                    if ((int)com.ExecuteScalar() == 0)
                    {
                        //    com = new SqlCommand($"insert into Sklad(ID_Tovar,Koll) SELECT ID_Tovar,Koll FROM Sost_Nakladna " +
                        //$" where(ID_Nakladna = '{dataGridView1.CurrentRow.Cells[0].Value}')", ms);
                        //    com.ExecuteNonQuery();
                        MessageBox.Show($"Не все товары присутвуют на складе. Нету({dataGridView2.Rows[i].Cells[6].Value})" +
                            $"\n он не будет дававелн к продаже");
                    }
                    else
                    {

                        com = new SqlCommand($"select (Koll) from [Sklad] where(ID_Tovar = " +
                      $"'{dataGridView2.Rows[i].Cells[1].Value}')", ms);
                        SqlDataReader sd = com.ExecuteReader();
                        int d = 0;
                        while (sd.Read())
                        {
                            d = (int)sd[0];
                        }
                        sd.Close(); //7
                        if (d < (int)dataGridView2.Rows[i].Cells[8].Value)
                        {
                            MessageBox.Show($"Товара недостаточно на складе! В наличие есть {d}\n" +
                                $"Данный товар не будет поставлен");
                            continue;
                        }
                        d -= (int)dataGridView2.Rows[i].Cells[8].Value;
                        ms.Close();
                        ms.Open();
                        com = new SqlCommand($"insert into Sostav_Vibitie_Naklad  SELECT * FROM Sost_Naklad_Prodag " +
                    $"where(ID_Naklad_Prodag = '{dataGridView1.CurrentRow.Cells[0].Value}' and ID_Tovar = '{dataGridView2.Rows[i].Cells[1].Value}') ", ms);
                        com.ExecuteNonQuery();
                        ms.Close();
                        ms.Open();
                        
                        int koll = (int)dataGridView2.Rows[i].Cells[8].Value;
                        com = new SqlCommand($"update Sklad set Koll = '{d}' where (ID_Tovar = '{dataGridView2.Rows[i].Cells[1].Value}') ", ms);
                        com.ExecuteNonQuery();
                        com = new SqlCommand($"select * from [Sostav_Partii] where (ID_Tovar = " +
                       $"'{dataGridView2.Rows[i].Cells[1].Value}') ", ms);
                        SqlDataReader ko = com.ExecuteReader();
                        while (ko.Read())
                        {
                            int tekkoll = (int)ko[2];
                            if (tekkoll - koll > 0)
                            {

                                int tov = (int)ko[1];
                                ko.Close();
                                mass[stchet] = new SqlCommand($"update Sostav_Partii set Koll = '{tekkoll - koll}' where " +
                                    $"(ID_Tovar = '{dataGridView2.Rows[i].Cells[1].Value}' and ID_Naklada = '{tov}') ", ms);
                                stchet++;
                                break;
                            }
                            else
                            {
                                int tov = (int)ko[1];
                                int nakl = (int)ko[0];
                                koll -= tekkoll;
                                mass[stchet] = new SqlCommand($"delete from [Sostav_Partii] " +
                      $"where(ID_Naklada = '{nakl}' and ID_Tovar = '{tov}')", ms);
                                stchet++;

                                if (koll <= 0)
                                {
                                    break;
                                }
                            }
                            //if (koll <= 0)
                            //    break;

                        }

                        ko.Close();

                        //MessageBox.Show("Test" + d);
                    }


                }

                foreach (SqlCommand c in mass)
                {
                    if (c == null)
                    {
                        break;
                    }
                    else
                    {
                        c.ExecuteNonQuery();
                    }
                }

                com = new SqlCommand($"delete from [Sost_Naklad_Prodag] " +
                    $"where(ID_Naklad_Prodag = '{dataGridView1.CurrentRow.Cells[0].Value}')", ms);
                com.ExecuteNonQuery();



                com = new SqlCommand($"insert into J_Vibit(ID_Pokup,ID_Naklad_Prodag,ID_Sotrudnic,Data_Vibitia,Nomer," +
                    $"Summa, Dostavka,Summa_Obh) " +
                    $" SELECT ID_Pokup,ID_Naklad_Prodag, ID_Sotrudnic ,Data_Pokup,Nomer," +
                    $"Summa, Dostavka,Summa_Obh FROM Naklad_Prodag " +
                    $"where(ID_Naklad_Prodag = '{dataGridView1.CurrentRow.Cells[0].Value}') ", ms);
                com.ExecuteNonQuery();




                com = new SqlCommand($"delete from [Naklad_Prodag] " +
                       $"where(ID_Naklad_Prodag = '{dataGridView1.CurrentRow.Cells[0].Value}')", ms);
                com.ExecuteNonQuery();
                F_Vibitie_Naklad_Load(null, null);
                ms.Close();
                new Null_Sklad();
                this.view_SkladTableAdapter.Fill(this.deviseDataSet.View_Sklad);
                new Peresh_Sklad(dataGridView3);

                viewNakladProdagBindingSource.Position = position;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 1)
                {
                    if (dataGridView1.RowCount != dataGridView1.CurrentRow.Index)
                        textBox1.Text = new Summ_naklad().Summ("Sost_Naklad_Prodag", "ID_Naklad_Prodag", (int)dataGridView1.CurrentRow.Cells[0].Value).ToString("0.00") + " руб.";
                }
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewNakladProdagBindingSource.Filter = "";
            CB_Nomer.Text = "";
            CB_Fio_sotr.Text = "";
            CB_Fio_Pok.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewNakladProdagBindingSource.Filter = $"FIO_Pokup like '%{CB_Fio_Pok.Text}%' and FIO_Sotrudnic like '%{CB_Fio_sotr.Text}%' and Nomer like '%{CB_Nomer.Text}%'";
        }

        private void btn_spravka_Click(object sender, EventArgs e)
        {
            new Spravka();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            check();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.hranim_Sost_Naklad_ProdagTableAdapter.Fill(this.deviseDataSet.Hranim_Sost_Naklad_Prodag, (int)dataGridView1.CurrentRow.Cells[0].Value);

        }
    }
}
