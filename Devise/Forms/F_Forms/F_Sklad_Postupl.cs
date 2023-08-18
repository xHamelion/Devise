using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devise
{
    public partial class F_Sklad_Postupl : Form
    {
        public int ID;

        public F_Sklad_Postupl()
        {
            InitializeComponent();
        }

        private void F_Sklad_Postupl_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            switch (Holder.level)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    
                    Exel.Enabled = false;
                    PDF.Enabled = false;
                    break;
            }
            this.hranim_Sostav_Patii_SkladTableAdapter.Fill(this.deviseDataSet.Hranim_Sostav_Patii_Sklad, ID);
            if (dataGridView1.RowCount > 1)
                numericUpDown1.Maximum = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value);
            else
                button1.Enabled = false;
        }

        private void Exel_Click(object sender, EventArgs e)
        {
            new Exel(dataGridView1, "Товары по поставкам");

        }

        private void PDF_Click(object sender, EventArgs e)
        {
            new PDF(dataGridView1, "Товары по поставкам");

        }

        private void btn_spravka_Click(object sender, EventArgs e)
        {
            new Spravka();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Text = (sender as RadioButton).Text;

        }
        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        private void button1_Click(object sender, EventArgs e)
        {
            int tek1 = (int)dataGridView1.CurrentRow.Cells[8].Value;
            int Vozvrat1 = (int)numericUpDown1.Value;
            int Razn1 = tek1 - Vozvrat1;
            ms.Open();
            com = new SqlCommand($"update Sostav_Partii set Koll = '{Razn1}', " +
                $"Summa = '{(Convert.ToDouble(dataGridView1.CurrentRow.Cells[9].Value) * (Convert.ToDouble(dataGridView1.CurrentRow.Cells[8].Value) - (double)numericUpDown1.Value)).ToString().Replace(',', '.')}'" +
                $"  where(ID_Naklada = '{dataGridView1.CurrentRow.Cells[0].Value}' " +
                $"and ID_Tovar = '{dataGridView1.CurrentRow.Cells[1].Value}' ) ", ms);
            com.ExecuteNonQuery();
            this.hranim_Sostav_Patii_SkladTableAdapter.Fill(this.deviseDataSet.Hranim_Sostav_Patii_Sklad, ID);
            if (tek1 - Vozvrat1 <= 0)
            {
                com = new SqlCommand($"delete Sostav_Partii where(ID_Naklada = '{dataGridView1.CurrentRow.Cells[0].Value}'" +
                $"and ID_Tovar = '{dataGridView1.CurrentRow.Cells[1].Value}' ) ", ms);
                com.ExecuteNonQuery();
            }
            this.hranim_Sostav_Patii_SkladTableAdapter.Fill(this.deviseDataSet.Hranim_Sostav_Patii_Sklad, ID);
            ms.Close();
            new Peresh_Sklad(dataGridView1);
            new Summ_naklad().Summ("Sostav_Partii", "ID_Naklada",(int) dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;

                if (dataGridView1.RowCount > 1)
                {
                    numericUpDown1.Maximum = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value);

                }
            }
            catch 
            {
                button1.Enabled = false;
            }
            
        }
    }
}
