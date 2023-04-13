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
    public partial class F_Sost_Nakladnoi_Prodag : Form
    {
        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        
        int position;
        public int ID=0;

        public F_Sost_Nakladnoi_Prodag()
        {
            InitializeComponent();
            this.Activated += (a, e) =>
            {
            F_Sost_Nakladnoi_Prodag_Load(null, null);
                hranimSostNakladProdagBindingSource.Position = position;
                Pereshhh();
            };
        }

        private void F_Sost_Nakladnoi_Prodag_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            this.hranim_Sost_Naklad_ProdagTableAdapter.Fill(this.deviseDataSet.Hranim_Sost_Naklad_Prodag, ID);
        }

        private void Exel_Click(object sender, EventArgs e)
        {
            new Exel(dataGridView1, "Состав накладной продажи");

        }

        private void PDF_Click(object sender, EventArgs e)
        {
            new PDF(dataGridView1, "Состав накладной продажи");

        }

        private void BTN_Dell_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                position = hranimSostNakladProdagBindingSource.Position;
                DialogResult dr = MessageBox.Show("Желаете удалить?", $"Удаление", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    ms.Open();
                    com = new SqlCommand($"delete from [Sost_Naklad_Prodag] " +
                        $"where(ID_Naklad_Prodag = '{dataGridView1.CurrentRow.Cells[0].Value}' and ID_Tovar = '{dataGridView1.CurrentRow.Cells[1].Value}')", ms);
                    com.ExecuteNonQuery();
                    ms.Close();
                    F_Sost_Nakladnoi_Prodag_Load(null, null);
                Pereshhh();
                    hranimSostNakladProdagBindingSource.Position = position;
                }
            }

        }

        private void BTN_Dob_Click(object sender, EventArgs e)
        {
            position = hranimSostNakladProdagBindingSource.Position;
            var dob = new F_D_R_Sost_Nakladnoi_Prodag();
            dob.BTN_Red_Save.Text = "Сохранить";
            dob.Text = "Создать запись";
            dob.TB_Summa.Enabled = false;
            dob.ID_Naklad = ID;
            dob.Show();
            dob.CB_Tovar.Text = "";
            this.Enabled = false;
            F_Sost_Nakladnoi_Prodag_Load(null, null);
       
            hranimSostNakladProdagBindingSource.Position = position;

        }

        private void BTN_Red_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                position = hranimSostNakladProdagBindingSource.Position;
                var dob = new F_D_R_Sost_Nakladnoi_Prodag();
                dob.NUP_Koll.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value);
                dob.BTN_Red_Save.Text = "Редактировать";
                dob.Text = "Редактировать запись";
                dob.ID_Naklad = ID;
                dob.ID_Tov = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                dob.Show();
                string c = (dataGridView1.CurrentRow.Cells[10].Value).ToString();
                dob.TB_Summa.Text = c.Substring(0,c.IndexOf(","));
                c = (dataGridView1.CurrentRow.Cells[9].Value).ToString();
                dob.TB_Zena.Text = c.Substring(0, c.IndexOf(","));

                dob.CB_Tovar.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
                dob.CB_Tovar.Enabled = false;
                dob.TB_Summa.Enabled = false;
                this.Enabled = false;

                F_Sost_Nakladnoi_Prodag_Load(null, null);
                
                hranimSostNakladProdagBindingSource.Position = position;
            }



        }


        public void Pereshhh()
        {
            try
            {
                int z = 0;
                for (int i = 0; dataGridView1.RowCount - 1 > i; i++)
                {

                    z += Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value);
                }
                ms.Open();
                com = new SqlCommand($"update Naklad_Prodag set Summa = '{z}'where (ID_Naklad_Prodag = '{ID}') ", ms);
                com.ExecuteNonQuery();
                ms.Close();

            }
            catch { }
                
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hranimSostNakladProdagBindingSource.Filter = "";
            CB_Nomer.Text = "";
            CB_Fio_sotr.Text = "";
            CB_Fio_Pok.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hranimSostNakladProdagBindingSource.Filter = $"Tip like '%{CB_Fio_Pok.Text}%' and PodTip like '%{CB_Fio_sotr.Text}%' and Tovar like '%{CB_Nomer.Text}%'";
        }

        private void btn_spravka_Click(object sender, EventArgs e)
        {
            new Spravka();
        }
    }
}
