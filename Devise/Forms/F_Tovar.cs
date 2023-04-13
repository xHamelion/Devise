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
    public partial class F_Tovar : Form
    {
        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        int position;

        public F_Tovar()
        {
            InitializeComponent();
            imagePictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            this.Activated += (a, e) =>
            {

                F_Tovar_Load(null, null);
                viewTovarBindingSource.Position = position;
            };


        }

        private void F_Tovar_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_Tovar". При необходимости она может быть перемещена или удалена.
            this.view_TovarTableAdapter.Fill(this.deviseDataSet.View_Tovar);
            imagePictureBox.BackgroundImageLayout = ImageLayout.Stretch;
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
                position = viewTovarBindingSource.Position;
                DialogResult dr = MessageBox.Show("Желаете удалить?", $"Удаление", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    ms.Open();
                    com = new SqlCommand($"delete from [Tovar] " +
                        $"where(ID_Tovar = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}')", ms);
                    try
                    {
                        com.ExecuteNonQuery();

                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Невозможно удалить! Имеються связанные данные!");
                    }
                    ms.Close();
                    F_Tovar_Load(null, null);
                }
                    viewTovarBindingSource.Position = position;
            }
            imagePictureBox.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void BTN_Dob_Click(object sender, EventArgs e)
        {
            position = viewTovarBindingSource.Position;
            var dob = new F_D_R_Tovar();
            dob.BTN_Red_Save.Text = "Сохранить";
            dob.Text = "Создать запись";
            dob.ShowDialog();
            F_Tovar_Load(null, null);
            viewTovarBindingSource.Position = position;
            imagePictureBox.BackgroundImageLayout = ImageLayout.Stretch;


        }

        private void BTN_Red_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                position = viewTovarBindingSource.Position;
                var dob = new F_D_R_Tovar();
                dob.TB_Tovar.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                dob.richTextBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dob.pictureBox1.Image = imagePictureBox.Image;
                dob.BTN_Red_Save.Text = "Редактировать";
                dob.Text = "Редактировать запись";
                dob.ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dob.Show();
                dob.CB_Tip.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dob.CB_PodTip.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.Enabled = false;
                F_Tovar_Load(null, null);
                viewTovarBindingSource.Position = position;

            }

            imagePictureBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Exel_Click(object sender, EventArgs e)
        {
            new Exel(dataGridView1, "Товары");

        }

        private void PDF_Click(object sender, EventArgs e)
        {
            new PDF(dataGridView1, "Товары");

        }

        private void F_Tovar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Enabled = true;
            Application.OpenForms[1].Activate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewTovarBindingSource.Filter = "";
            CB_Nomer.Text = "";
            CB_Fio_sotr.Text = "";
            CB_Fio_Pok.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewTovarBindingSource.Filter = $"Tip like '%{CB_Fio_Pok.Text}%' and PodTip like '%{CB_Fio_sotr.Text}%' and Tovar like '%{CB_Nomer.Text}%'";
        }

        private void btn_spravka_Click(object sender, EventArgs e)
        {
            new Spravka();
        }
    }
}
