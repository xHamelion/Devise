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
    public partial class F_Uchets : Form
    {
        public F_Uchets()
        {
            InitializeComponent();
        }
        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        int position;
        private void F_Uchets_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.Reg". При необходимости она может быть перемещена или удалена.
            this.regTableAdapter.Fill(this.deviseDataSet.Reg);
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.Reg". При необходимости она может быть перемещена или удалена.
            this.regTableAdapter.Fill(this.deviseDataSet.Reg);

        }

        private void BTN_Dob_Click(object sender, EventArgs e)
        {
            position = regBindingSource.Position;
            var dob = new F_D_R_Uchets();
            dob.BTN_Red_Save.Text = "Сохранить";
            dob.Text = "Создать запись";
            dob.ShowDialog();
            this.regTableAdapter.Fill(this.deviseDataSet.Reg);
            regBindingSource.Position = position;
        }

        private void BTN_Red_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                position = regBindingSource.Position;
                var dob = new F_D_R_Uchets();
                dob.TB_Tovar.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dob.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dob.CB_PodTip.SelectedIndex = (int)dataGridView1.CurrentRow.Cells[2].Value;
                dob.BTN_Red_Save.Text = "Редактировать";
                dob.Text = "Редактировать запись";
                dob.ID = (int)dataGridView1.CurrentRow.Cells[3].Value;
                dob.ShowDialog();
                    this.regTableAdapter.Fill(this.deviseDataSet.Reg);
                regBindingSource.Position = position;

            }
        }

        private void BTN_Dell_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                position = regBindingSource.Position;
                DialogResult dr = MessageBox.Show("Желаете удалить?", $"Удаление", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    ms.Open();
                    com = new SqlCommand($"delete from [Reg] " +
                        $"where(ID_Reg = '{dataGridView1.CurrentRow.Cells[3].Value.ToString()}')", ms);
                    try
                    {
                        com.ExecuteNonQuery();

                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Невозможно удалить! Имеються связанные данные!");
                    }
                    ms.Close();
                    this.regTableAdapter.Fill(this.deviseDataSet.Reg);

                    regBindingSource.Position = position;
                }
            }
        }
    }
}
