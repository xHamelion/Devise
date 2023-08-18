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

namespace Devise
{
    public partial class F_Postupl_Nakladn : Form
    {

        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        int position;


        public F_Postupl_Nakladn()
        {
            InitializeComponent();
            
            this.Activated += (a, e) =>
            {
                this.view_NakladnaTableAdapter.Fill(this.deviseDataSet.View_Nakladna);

                for (int i = 0; i < dataGridView1.RowCount-1; i++)
                {
                    dataGridView1.Rows[i].Cells[8].Value = new Summ_naklad().Summ("Sost_Nakladna", "ID_Nakladna", (int)dataGridView1.Rows[i].Cells[0].Value).ToString("0.00");
                }
            };
        }

        private void F_Postupl_Nakladn_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_Sklad". При необходимости она может быть перемещена или удалена.
            this.view_SkladTableAdapter.Fill(this.deviseDataSet.View_Sklad);

            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_Nakladna". При необходимости она может быть перемещена или удалена.
            this.view_NakladnaTableAdapter.Fill(this.deviseDataSet.View_Nakladna);
            this.view_NakladnaTableAdapter.Fill(this.deviseDataSet.View_Nakladna);

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1.Rows[i].Cells[8].Value = new Summ_naklad().Summ("Sost_Nakladna", "ID_Nakladna", (int)dataGridView1.Rows[i].Cells[0].Value).ToString("0.00");
            }
        }

        private void Exel_Click(object sender, EventArgs e)
        {
            new Exel(dataGridView1, $"К поступлению");

        }

        private void PDF_Click(object sender, EventArgs e)
        {
            new PDF(dataGridView1, "К поступлению");

        }

        private void BTN_Dell_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                if (dataGridView1.RowCount != dataGridView1.CurrentRow.Index)
                {
                    position = viewNakladnaBindingSource.Position;
                    DialogResult dr = MessageBox.Show("Желаете удалить?", $"Удаление", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        ms.Open();
                        com = new SqlCommand($"delete from [Sost_Nakladna] " +
                            $"where(ID_Nakladna = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}')", ms);
                        com.ExecuteNonQuery();

                        com = new SqlCommand($"delete from [Nakladna] " +
                            $"where(ID_Nakladna = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}')", ms);
                        com.ExecuteNonQuery();
                        ms.Close();
                         this.view_NakladnaTableAdapter.Fill(this.deviseDataSet.View_Nakladna);
                        viewNakladnaBindingSource.Position = position;
                    }
                }
            }
        }

        private void BTN_Dob_Click(object sender, EventArgs e)
        {


            position = viewNakladnaBindingSource.Position;
            var dob = new F_D_R_Postupl_Nakladn();
            dob.BTN_Red_Save.Text = "Сохранить";
            dob.Text = "Создать запись";
            dob.ShowDialog();
            this.view_NakladnaTableAdapter.Fill(this.deviseDataSet.View_Nakladna);
            viewNakladnaBindingSource.Position = position;
            this.view_NakladnaTableAdapter.Fill(this.deviseDataSet.View_Nakladna);

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1.Rows[i].Cells[8].Value = new Summ_naklad().Summ("Sost_Nakladna", "ID_Nakladna", (int)dataGridView1.Rows[i].Cells[0].Value).ToString("0.00");
            }

        }

        private void BTN_Red_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount - 1 > 0)
            {
                if (dataGridView1.RowCount != dataGridView1.CurrentRow.Index)
                {
                    position = viewNakladnaBindingSource.Position;
                    var dob = new F_D_R_Postupl_Nakladn();
                    dob.DTP.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value);
                    dob.TB_Nomer.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    dob.BTN_Red_Save.Text = "Редактировать";
                    dob.Text = "Редактировать запись";
                    dob.ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    dob.Show();
                    dob.comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
                    dob.comboBox2.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value;
                    this.Enabled = false;
                    this.view_NakladnaTableAdapter.Fill(this.deviseDataSet.View_Nakladna);
                    viewNakladnaBindingSource.Position = position;

                }
            }



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != dataGridView1.RowCount)
            {
                try
                {
                    position = viewNakladnaBindingSource.Position;
                    var f = new F_Sost_Nakladnoi();
                    f.ID = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    f.ShowDialog();
                    viewNakladnaBindingSource.Position = position;

                }
                catch { }
                
            }
        }
        private void F_Postupl_Nakladn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Enabled = true;
            Application.OpenForms[1].Activate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                position = viewNakladnaBindingSource.Position;

                ms.Open();

                com = new SqlCommand($"insert into Sostav_Postupl_Naklad  SELECT * FROM Sost_Nakladna " +
                    $"where(ID_Nakladna = '{dataGridView1.CurrentRow.Cells[0].Value}') ", ms);
                com.ExecuteNonQuery();

                this.hranim_View_Sost_NakladnaTableAdapter.Fill(this.deviseDataSet.Hranim_View_Sost_Nakladna, (int)dataGridView1.CurrentRow.Cells[0].Value);

                for (int i = 0; i < dataGridView2.RowCount - 1; i++)
                {

                    com = new SqlCommand($"select count (*) from [Sklad] where (ID_Tovar = " +
                       $"'{dataGridView2.Rows[i].Cells[1].Value}')", ms);
                    if ((int)com.ExecuteScalar() == 0)
                    {
                        com = new SqlCommand($"insert into Sklad(ID_Tovar,Koll ) SELECT ID_Tovar,Koll  FROM Sost_Nakladna " +
                    $" where(ID_Nakladna = '{dataGridView1.CurrentRow.Cells[0].Value}' AND ID_Tovar = '{dataGridView2.Rows[i].Cells[1].Value}')", ms);
                        com.ExecuteNonQuery();
                        com = new SqlCommand($"update Sklad set  Sredn_Zena = '{Convert.ToInt32( dataGridView2.Rows[i].Cells[15].Value)}' where (ID_Tovar = '{dataGridView2.Rows[i].Cells[1].Value}') ", ms);
                        com.ExecuteNonQuery();//!!!
                    }
                    else
                    {
                        com = new SqlCommand($"select (Koll) from [Sklad] where(ID_Tovar = " +
                      $"'{dataGridView2.Rows[i].Cells[1].Value}')", ms);
                        SqlDataReader sd = com.ExecuteReader();
                        int d = 0;
                        sd.Read();
                        d = (int)sd[0];

                        sd.Close(); //7
                        d += (int)dataGridView2.Rows[i].Cells[14].Value;

                        com = new SqlCommand($"select * from [Sostav_Postupl_Naklad] where (ID_Tovar = '{dataGridView2.Rows[i].Cells[1].Value}')", ms);
                        SqlDataReader sd1 = com.ExecuteReader();
                        int sred_Zen=0,kol=0;
                        while (sd1.Read())
                        {
                            sred_Zen += Convert.ToInt32(sd1[4]);
                            kol++;
                        }
                        sd1.Close();
                        sred_Zen = sred_Zen / d;
                        com = new SqlCommand($"update Sklad set Koll = '{d}', Sredn_Zena = '{sred_Zen}' where (ID_Tovar = '{dataGridView2.Rows[i].Cells[1].Value}') ", ms);
                        com.ExecuteNonQuery();


                        //MessageBox.Show("Test" + d);
                    }


                }
                com = new SqlCommand($"insert into Sostav_Partii  SELECT * FROM Sost_Nakladna " +
                    $"where(ID_Nakladna = '{dataGridView1.CurrentRow.Cells[0].Value}') ", ms);
                com.ExecuteNonQuery();

                com = new SqlCommand($"delete from [Sost_Nakladna] " +
                        $"where(ID_Nakladna = '{dataGridView1.CurrentRow.Cells[0].Value}')", ms);
                com.ExecuteNonQuery();



                com = new SqlCommand($"insert into J_Postupl(ID_Postavhick,ID_Nakladna,Data_Postavki,Nomer,ID_Sotrudnic) " +
                    $" SELECT ID_Postavhick,ID_Nakladna, Data_Postavki , Nomer,ID_Sotrudnic FROM Nakladna " +
                    $"where(ID_Nakladna = '{dataGridView1.CurrentRow.Cells[0].Value}') ", ms);
                com.ExecuteNonQuery();



                com = new SqlCommand($"delete from [Nakladna] " +
                       $"where(ID_Nakladna = '{dataGridView1.CurrentRow.Cells[0].Value}')", ms);
                com.ExecuteNonQuery();
                F_Postupl_Nakladn_Load(null, null);
                ms.Close();
                viewNakladnaBindingSource.Position = position;
                this.view_SkladTableAdapter.Fill(this.deviseDataSet.View_Sklad);

                new Peresh_Sklad(dataGridView3);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 1)
                {
                    if (dataGridView1.RowCount != dataGridView1.CurrentRow.Index)
                        textBox1.Text = new Summ_naklad().Summ("Sost_Nakladna", "ID_Nakladna", (int)dataGridView1.CurrentRow.Cells[0].Value).ToString("0.00") + " руб.";

                }
            }
            catch { }
                
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewNakladnaBindingSource.Filter = "";
            CB_Nomer.Text = "";
            CB_Fio_sotr.Text = "";
            CB_Fio_Pok.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewNakladnaBindingSource.Filter = $"Naimenovanie_Organiz like '%{CB_Fio_Pok.Text}%' and FIO_Sotrudnic like '%{CB_Fio_sotr.Text}%' and Nomer like '%{CB_Nomer.Text}%'";
        }

        private void btn_spravka_Click(object sender, EventArgs e)
        {
            new Spravka();
        }
    }
}
