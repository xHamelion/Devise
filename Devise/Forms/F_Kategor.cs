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
    public partial class F_Kategor : Form
    {
        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        int position;

        public F_Kategor()
        {
            InitializeComponent();
        }

        private void F_Kategor_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.Tip". При необходимости она может быть перемещена или удалена.
            this.tipTableAdapter.Fill(this.deviseDataSet.Tip);
            switch (Holder.level)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    BTN_Red.Enabled = false;
                    BTN_Dob.Enabled = false;
                    BTN_Dell.Enabled = false;
                    Exel.Enabled = false;
                    PDF.Enabled = false;
                    break;
            }

        }

        private void BTN_Dell_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                position = tipBindingSource.Position;
                DialogResult dr = MessageBox.Show("Желаете удалить?", $"Удаление", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    ms.Open();
                    com = new SqlCommand($"delete from [Tip] " +
                        $"where(ID_Tip = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}')", ms);
                    try
                    {
                        com.ExecuteNonQuery();

                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Невозможно удалить! Имеються связанные данные!");
                    }
                    ms.Close();
                    this.tipTableAdapter.Fill(this.deviseDataSet.Tip);

                    tipBindingSource.Position = position;
                }
                tipBindingSource.Position = position;

            }
        }

        private void BTN_Dob_Click(object sender, EventArgs e)
        {
            position = tipBindingSource.Position;
            var dob = new F_D_R_Tip();
            dob.BTN_Red_Save.Text = "Сохранить";
            dob.Text = "Создать запись";
            dob.ShowDialog();
            this.tipTableAdapter.Fill(this.deviseDataSet.Tip);
            tipBindingSource.Position = position;
        }

        private void BTN_Red_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                position = tipBindingSource.Position;
                var dob = new F_D_R_Tip();
                dob.TB_Tip.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dob.BTN_Red_Save.Text = "Редактировать";
                dob.Text = "Редактировать запись";
                dob.ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dob.ShowDialog();
                this.tipTableAdapter.Fill(this.deviseDataSet.Tip);
                tipBindingSource.Position = position;

            }
        }

        private void Exel_Click(object sender, EventArgs e)
        {
            new Exel(dataGridView1, "Типы товаров");

        }

        private void PDF_Click(object sender, EventArgs e)
        {
            new PDF(dataGridView1, "Типы товаров");

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                var f = new F_Pod_Kategor();
                f.ID_Tip = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                f.ShowDialog();
            }
        }

        private void F_Kategor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Enabled = true;
            Application.OpenForms[1].Activate(); 
        }


        private void button3_Click(object sender, EventArgs e)
        {
            tipBindingSource.Filter = "";
 
            CB_Fio_Pok.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tipBindingSource.Filter = $"Tip like '%{CB_Fio_Pok.Text}%'";
        }

        private void btn_spravka_Click(object sender, EventArgs e)
        {
            new Spravka();
        }
    }
}
