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
    public partial class F_Sost_Nakladnoi : Form
    {

        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        int position;
        public int ID;

        public F_Sost_Nakladnoi()
        {
            InitializeComponent();
            this.Activated += (a, e) =>
            {

                F_Sost_Nakladnoi_Load(null, null);
                hranimViewSostNakladnaBindingSource.Position = position;
            };
        }

        private void F_Sost_Nakladnoi_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            this.hranim_View_Sost_NakladnaTableAdapter.Fill(this.deviseDataSet.Hranim_View_Sost_Nakladna, ID);
        }

        private void BTN_Dell_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                position = hranimViewSostNakladnaBindingSource.Position;
                DialogResult dr = MessageBox.Show("Желаете удалить?", $"Удаление", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    ms.Open();
                    com = new SqlCommand($"delete from [Sost_Nakladna] " +
                        $"where(ID_Nakladna = '{dataGridView1.CurrentRow.Cells[0].Value }' and ID_Tovar = '{dataGridView1.CurrentRow.Cells[1].Value }' )", ms);
                    com.ExecuteNonQuery();
                    ms.Close();
                    F_Sost_Nakladnoi_Load(null, null);
                    hranimViewSostNakladnaBindingSource.Position = position;
                }

            }
        }

        private void BTN_Dob_Click(object sender, EventArgs e)
        {

            position = hranimViewSostNakladnaBindingSource.Position;
            var dob = new F_D_R_Sost_Nakladnoi();
            dob.BTN_Red_Save.Text = "Сохранить";
            dob.Text = "Создать запись";
            dob.TB_Summa.Enabled = false;
            dob.ID_Naklad = ID.ToString();
            dob.ShowDialog();
            F_Sost_Nakladnoi_Load(null, null);
            hranimViewSostNakladnaBindingSource.Position = position;



        }

        private void BTN_Red_Click(object sender, EventArgs e)
        {

            if (dataGridView1.RowCount > 1)
            {
                position = hranimViewSostNakladnaBindingSource.Position;
                var dob = new F_D_R_Sost_Nakladnoi();
                dob.NUP_Koll.Value = (int)dataGridView1.CurrentRow.Cells[14].Value;
                dob.TB_Zena.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString().Substring(0, dataGridView1.CurrentRow.Cells[16].Value.ToString().IndexOf(','));
                dob.TB_Summa.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString().Substring(0, dataGridView1.CurrentRow.Cells[16].Value.ToString().IndexOf(','));
                dob.BTN_Red_Save.Text = "Редактировать";
                dob.Text = "Редактировать запись";
                dob.ID_Naklad = ID.ToString();
                dob.ID_Tovar = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dob.Show();
                dob.CB_Tovar.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
                dob.CB_Tovar.Enabled = false;
                dob.TB_Summa.Enabled = false;
                dob.panel1.Enabled = false;
                this.Enabled = false;
                this.hranim_View_Sost_NakladnaTableAdapter.Fill(this.deviseDataSet.Hranim_View_Sost_Nakladna, ID);

                F_Sost_Nakladnoi_Load(null, null);
                hranimViewSostNakladnaBindingSource.Position = position;

            }



        }

        private void Exel_Click(object sender, EventArgs e)
        {
            new Exel(dataGridView1, $"Сотав накладной");

        }

        private void PDF_Click(object sender, EventArgs e)
        {
            new PDF(dataGridView1, $"Сотав накладной");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            hranimViewSostNakladnaBindingSource.Filter = "";
            CB_Nomer.Text = "";
            CB_Fio_sotr.Text = "";
            CB_Fio_Pok.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hranimViewSostNakladnaBindingSource.Filter = $"Tip like '%{CB_Fio_Pok.Text}%' and PodTip like '%{CB_Fio_sotr.Text}%' and Tovar like '%{CB_Nomer.Text}%'";
        }

        private void btn_spravka_Click(object sender, EventArgs e)
        {
            new Spravka();
        }
    }
}
