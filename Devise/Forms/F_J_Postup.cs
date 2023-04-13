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
    public partial class F_J_Postup : Form
    {

        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        int position;


        public F_J_Postup()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 1)
                {
                    if (dataGridView1.RowCount != dataGridView1.CurrentRow.Index)
                        textBox1.Text = new Summ_naklad().Summ("Sost_Nakladna", "ID_Nakladna", (int)dataGridView1.CurrentRow.Cells[0].Value).ToString();

                }
            }
            catch { }
        }

        private void F_J_Postup_Load(object sender, EventArgs e)
        {
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
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_J_Postupl". При необходимости она может быть перемещена или удалена.
            this.view_J_PostuplTableAdapter.Fill(this.deviseDataSet.View_J_Postupl);

        }

        private void BTN_Dell_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                position = viewJPostuplBindingSource.Position;
                DialogResult dr = MessageBox.Show("Желаете удалить?", $"Удаление", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    ms.Open();
                    com = new SqlCommand($"delete from [Sostav_Postupl_Naklad] " +
                        $"where(ID_Naklad_Postupl = '{dataGridView1.CurrentRow.Cells[1].Value}')", ms);
                    com.ExecuteNonQuery();
                    com = new SqlCommand($"delete from [J_Postupl] " +
                        $"where(ID_Nakladna = '{dataGridView1.CurrentRow.Cells[1].Value}')", ms);
                    com.ExecuteNonQuery();
                    ms.Close();
                    F_J_Postup_Load(null, null);

                }
                viewJPostuplBindingSource.Position = position;

            }
        }

        private void Exel_Click(object sender, EventArgs e)
        {
            new Exel(dataGridView1, "Поступления");

        }

        private void PDF_Click(object sender, EventArgs e)
        {
            new PDF(dataGridView1, "Поступления");

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != dataGridView1.RowCount)
            {
                try
                {
                    var f = new F_Sostav_J_Postupl();
                    f.ID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    f.ShowDialog();
                }
                catch { }
            }
        }

        private void F_J_Postup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Enabled = true;
            Application.OpenForms[1].Activate();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            viewJPostuplBindingSource.Filter = "";
            CB_Nomer.Text = "";
            CB_Fio_sotr.Text = "";
            CB_Fio_Pok.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewJPostuplBindingSource.Filter = $"Naimenovanie_Organiz like '%{CB_Fio_Pok.Text}%' and Telefon like '%{CB_Fio_sotr.Text}%' and FIO like '%{CB_Nomer.Text}%'";
        }
    }
}
