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
    public partial class F_J_Vibit : Form
    {

        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        int position = 0;


        public F_J_Vibit()
        {
            InitializeComponent();
        }

        private void F_J_Vibit_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_J_Vibit". При необходимости она может быть перемещена или удалена.
            this.view_J_VibitTableAdapter.Fill(this.deviseDataSet.View_J_Vibit);
            switch (Holder.level)
            {
                case 0:
                    break;
                case 1:
                    BTN_Dell.Enabled = false;
                    break;
                case 2:
                    break;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                try
                {
                    var f = new F_Sost_J_Vibit();
                    f.ID = (int)dataGridView1.CurrentRow.Cells[1].Value;
                    f.ShowDialog();
                }
                catch { }


            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 1)
                {
                    if (dataGridView1.RowCount != dataGridView1.CurrentRow.Index)
                        textBox1.Text = new Summ_naklad().Summ("Sostav_Vibitie_Naklad", "ID_Naklad_Prodag", (int)dataGridView1.CurrentRow.Cells[1].Value).ToString();

                }
            }
            catch { }
        }

        private void BTN_Dell_Click(object sender, EventArgs e)
        {
            position = viewJVibitBindingSource.Position;

            if (dataGridView1.RowCount > 1)
            {
                position = viewJVibitBindingSource.Position;
                DialogResult dr = MessageBox.Show("Желаете удалить?", $"Удаление", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    ms.Open();
                    com = new SqlCommand($"delete from [Sostav_Vibitie_Naklad] " +
                        $"where(ID_Naklad_Prodag = '{dataGridView1.CurrentRow.Cells[1].Value}')", ms);
                    com.ExecuteNonQuery();
                    com = new SqlCommand($"delete from [J_Vibit] " +
                        $"where(ID_Naklad_Prodag = '{dataGridView1.CurrentRow.Cells[1].Value}')", ms);
                    com.ExecuteNonQuery();
                    ms.Close();
                    F_J_Vibit_Load(null, null);

                }
                viewJVibitBindingSource.Position = position;
            }

        }

        private void Exel_Click(object sender, EventArgs e)
        {
            new Exel(dataGridView1, "Выбытия");

        }

        private void PDF_Click(object sender, EventArgs e)
        {
            new PDF(dataGridView1, "Выбытия");

        }


        private void button3_Click(object sender, EventArgs e)
        {
            viewJVibitBindingSource.Filter = "";
            CB_Fio_sotr.Text = "";
            CB_Fio_Pok.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewJVibitBindingSource.Filter = $"FIO_Pokup like '%{CB_Fio_Pok.Text}%' and Nomer like '%{CB_Fio_sotr.Text}%'";
        }
    }
}
