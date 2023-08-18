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
    public partial class F_InternetUser : Form
    {
        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        int position;

        public F_InternetUser()
        {
            InitializeComponent();
        }

        private void F_InternetUser_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_InternetUser". При необходимости она может быть перемещена или удалена.
            this.view_InternetUserTableAdapter.Fill(this.deviseDataSet.View_InternetUser);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_InternetUser". При необходимости она может быть перемещена или удалена.
            this.view_InternetUserTableAdapter.Fill(this.deviseDataSet.View_InternetUser);

        }

        private void BTN_Red_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                position = viewInternetUserBindingSource.Position;
                var dob = new F_D_R_InternetUser();

                dob.TB_Tip.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dob.textBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                dob.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dob.textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dob.textBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dob.textBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                dob.BTN_Red_Save.Text = "Редактировать";
                dob.Text = "Редактировать запись";
                dob.ID = Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value);
                dob.ShowDialog();
                this.view_InternetUserTableAdapter.Fill(this.deviseDataSet.View_InternetUser);
                F_InternetUser_Load(null, null);
                viewInternetUserBindingSource.Position = position;
            }
        }

        private void BTN_Dob_Click(object sender, EventArgs e)
        {
            position = viewInternetUserBindingSource.Position;
            var dob = new F_D_R_InternetUser();
            dob.BTN_Red_Save.Text = "Сохранить";
            dob.Text = "Создать запись";
            dob.ShowDialog();
            F_InternetUser_Load(null, null);
            this.view_InternetUserTableAdapter.Fill(this.deviseDataSet.View_InternetUser);
            viewInternetUserBindingSource.Position = position;
        }

        private void BTN_Dell_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {

                position = viewInternetUserBindingSource.Position;
                DialogResult dr = MessageBox.Show("Желаете удалить?", $"Удаление", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    ms.Open();
                    com = new SqlCommand($"delete from [InternetUser] " +
                        $"where(ID_InternetUser = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}')", ms);
                    try
                    {
                        com.ExecuteNonQuery();

                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Невозможно удалить! Имеються связанные данные!");
                    }
                    ms.Close();
                    F_InternetUser_Load(null, null);
            this.view_InternetUserTableAdapter.Fill(this.deviseDataSet.View_InternetUser);
                    viewInternetUserBindingSource.Position = position;
                }
            }
        }

        private void Exel_Click(object sender, EventArgs e)
        {
            new Exel(dataGridView1, "интернет пользователи");

        }

        private void PDF_Click(object sender, EventArgs e)
        {
            new PDF(dataGridView1, "интернет пользователи");

        }
    }
}
