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
    public partial class F_Sost_J_Vibit : Form
    {
        public F_Sost_J_Vibit()
        {
            InitializeComponent();
        }
        public int ID=0;
        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        int position = 0;
        private void F_Sost_J_Vibit_Load(object sender, EventArgs e)
        {
            switch (Holder.level)
            {
                case 0:
                    break;
                case 1:
                    button1.Enabled = false;
                    break;
                case 2:
                    
                    break;
            }
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_Sklad". При необходимости она может быть перемещена или удалена.
            this.view_SkladTableAdapter.Fill(this.deviseDataSet.View_Sklad);
            this.hranim_Sost_J_VibitTableAdapter.Fill(this.deviseDataSet.Hranim_Sost_J_Vibit, ID);
            if (dataGridView1.RowCount > 1)
                numericUpDown1.Maximum = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value);
            else
                button1.Enabled = false;

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1 || dataGridView1.CurrentRow.Cells[0].Value == null)
            {
                return;
            }

            int id_Peresh = (int)dataGridView1.CurrentRow.Cells[0].Value;
            position = hranimSostJVibitBindingSource.Position;
            hranimSostJVibitBindingSource.Position = position;

            if (radioButton2.Checked)
            {
                int tek1 = (int)dataGridView1.CurrentRow.Cells[8].Value;
                int Vozvrat1 = (int)numericUpDown1.Value;
                int Razn1 = tek1 - Vozvrat1;
                ms.Open();
                com = new SqlCommand($"update Sostav_Vibitie_Naklad set Koll = '{Razn1}', " +
                    $"Summa = '{(Convert.ToDouble(dataGridView1.CurrentRow.Cells[9].Value) * (Convert.ToDouble(dataGridView1.CurrentRow.Cells[8].Value) - (double)numericUpDown1.Value)).ToString().Replace(',', '.')}'" +
                    $"  where(ID_Naklad_Prodag = '{dataGridView1.CurrentRow.Cells[0].Value}'" +
                    $"and ID_Tovar = '{dataGridView1.CurrentRow.Cells[1].Value}' ) ", ms);
                com.ExecuteNonQuery();
                this.hranim_Sost_J_VibitTableAdapter.Fill(this.deviseDataSet.Hranim_Sost_J_Vibit, ID);
                if (tek1 - Vozvrat1 <= 0)
                {
                    com = new SqlCommand($"delete Sostav_Vibitie_Naklad where(ID_Naklad_Prodag = '{dataGridView1.CurrentRow.Cells[0].Value}'" +
                    $"and ID_Tovar = '{dataGridView1.CurrentRow.Cells[1].Value}' ) ", ms);
                    com.ExecuteNonQuery();
                }
            this.hranim_Sost_J_VibitTableAdapter.Fill(this.deviseDataSet.Hranim_Sost_J_Vibit, ID);
                ms.Close();
                new Peresh_Sklad(dataGridView2);
                new Summ_naklad().Summ("Sostav_Vibitie_Naklad", "ID_Naklad_Prodag", id_Peresh);
                return;
            }
            ms.Open();
            com = new SqlCommand($"insert into Sostav_Partii  SELECT * FROM Sostav_Vibitie_Naklad where(ID_Naklad_Prodag = '{dataGridView1.CurrentRow.Cells[0].Value}'" +
                $"and ID_Tovar = '{dataGridView1.CurrentRow.Cells[1].Value}' ) ",ms);

            com.ExecuteNonQuery();
            com = new SqlCommand($"update Sostav_Partii set Koll = '{numericUpDown1.Value}' , " +
                $"Summa = '{(Convert.ToDouble(dataGridView1.CurrentRow.Cells[9].Value) * (double)numericUpDown1.Value).ToString().Replace(',','.')}'" +
                $"  where (ID_Naklada = '{dataGridView1.CurrentRow.Cells[0].Value}'" +
                $"and ID_Tovar = '{dataGridView1.CurrentRow.Cells[1].Value}') ", ms);
            com.ExecuteNonQuery();

            int tek =  (int)dataGridView1.CurrentRow.Cells[8].Value;
            int Vozvrat = (int)numericUpDown1.Value;
            int Razn = tek - Vozvrat;
            com = new SqlCommand($"update Sostav_Vibitie_Naklad set Koll = '{Razn}', " +
                $"Summa = '{(Convert.ToDouble(dataGridView1.CurrentRow.Cells[9].Value) * (Convert.ToDouble(dataGridView1.CurrentRow.Cells[8].Value)-(double)numericUpDown1.Value)).ToString().Replace(',', '.')}'" +
                $"  where(ID_Naklad_Prodag = '{dataGridView1.CurrentRow.Cells[0].Value}'" +
                $"and ID_Tovar = '{dataGridView1.CurrentRow.Cells[1].Value}' ) ", ms);
                com.ExecuteNonQuery();
            this.hranim_Sost_J_VibitTableAdapter.Fill(this.deviseDataSet.Hranim_Sost_J_Vibit, ID);
            if(tek - Vozvrat <= 0)
            {
                com = new SqlCommand($"delete Sostav_Vibitie_Naklad where(ID_Naklad_Prodag = '{dataGridView1.CurrentRow.Cells[0].Value}'" +
                $"and ID_Tovar = '{dataGridView1.CurrentRow.Cells[1].Value}' ) ", ms);
                com.ExecuteNonQuery();
            }
            ms.Close();
            ms.Open();
            com = new SqlCommand($"select count(*) from [Sklad] where(ID_Tovar = '{dataGridView1.CurrentRow.Cells[1].Value}')",  ms);
            if (Convert.ToInt32(com.ExecuteScalar()) == 0)
            {
                com = new SqlCommand($"insert into Sklad(ID_Tovar,Koll,Sredn_Zena )" +
                        $" values('{dataGridView1.CurrentRow.Cells[1].Value}', '{Razn}', '0' )", ms);
                com.ExecuteNonQuery();
            }
            ms.Close();
                this.hranim_Sost_J_VibitTableAdapter.Fill(this.deviseDataSet.Hranim_Sost_J_Vibit, ID);
            this.view_SkladTableAdapter.Fill(this.deviseDataSet.View_Sklad);
            new Peresh_Sklad(dataGridView2);
            new Summ_naklad().Summ("Sostav_Vibitie_Naklad", "ID_Naklad_Prodag", id_Peresh);
            hranimSostJVibitBindingSource.Position = position;
        }

        private void btn_spravka_Click(object sender, EventArgs e)
        {
            new Spravka();
        }

        private void opisanieRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void imagePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                numericUpDown1.Maximum = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value);

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Text = (sender as RadioButton).Text;
        }
    }
}
