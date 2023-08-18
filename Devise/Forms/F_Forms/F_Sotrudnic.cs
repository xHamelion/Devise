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
    public partial class F_Sotrudnic : Form
    {

        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        int position;


        public F_Sotrudnic()
        {
            InitializeComponent();
        }

        private void F_Sotrudnic_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            if(Holder.level != 0)
            {
                BTN_Red.Enabled = false;
                BTN_Dell.Enabled = false;
                BTN_Dob.Enabled = false;
            }
            this.view_SotrudnicTableAdapter.Fill(this.deviseDataSet.View_Sotrudnic);

        }

        private void Exel_Click(object sender, EventArgs e)
        {
            new Exel(dataGridView1, "Сотрудники");

        }

        private void PDF_Click(object sender, EventArgs e)
        {
            new PDF(dataGridView1, "Сотрудники");

        }

        private void BTN_Dob_Click(object sender, EventArgs e)
        {
            position = viewSotrudnicBindingSource.Position;
            var dob = new F_D_R_Sotrudnic();
            dob.BTN_Red_Save.Text = "Сохранить";
            dob.Text = "Создать запись";
            dob.ShowDialog();
            this.view_SotrudnicTableAdapter.Fill(this.deviseDataSet.View_Sotrudnic);
            viewSotrudnicBindingSource.Position = position;

        }

        private void BTN_Dell_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                try
                {
                    var dsd = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString());

                }
                catch
                {
                    MessageBox.Show("Статические записи запрешены для удаления!");
                    return;
                }
                position = viewSotrudnicBindingSource.Position;
                DialogResult dr = MessageBox.Show("Желаете удалить?", $"Удаление", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    ms.Open();
                    com = new SqlCommand($"delete from [Sotrudnic] " +
                        $"where(ID_Sotrudnic = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}')", ms);
                    try
                    {
                        com.ExecuteNonQuery();

                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Невозможно удалить! Имеються связанные данные!");
                    }
                    ms.Close();
                    this.view_SotrudnicTableAdapter.Fill(this.deviseDataSet.View_Sotrudnic);

                    viewSotrudnicBindingSource.Position = position;
                }
            }
        }

        private void BTN_Red_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                position = viewSotrudnicBindingSource.Position;
                var dob = new F_D_R_Sotrudnic();
                //if(dataGridView1.CurrentRow.Cells[6].Value == null)
                //{
                    
                //};
                try
                {
                    dob.id_Reg = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString());

                }
                catch 
                {
                    MessageBox.Show("Статические записи запрешены для редактирования!");
                    return;
                }
                dob.TB_Famil.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dob.TB_Name.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dob.TB_Otzh.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                dob.MTB_Tel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dob.BTN_Red_Save.Text = "Редактировать";
                dob.Text = "Редактировать запись";
                dob.ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dob.ShowDialog();
                this.view_SotrudnicTableAdapter.Fill(this.deviseDataSet.View_Sotrudnic);
                viewSotrudnicBindingSource.Position = position;

            }
        }

        private void F_Sotrudnic_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Enabled = true;
            Application.OpenForms[1].Activate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewSotrudnicBindingSource.Filter = "";
            CB_Fio_sotr.Text = "";
            CB_Fio_Pok.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewSotrudnicBindingSource.Filter = $"FIO like '%{CB_Fio_Pok.Text}%' and Telefon like '%{CB_Fio_sotr.Text}%'";
        }

        private void btn_spravka_Click(object sender, EventArgs e)
        {
            new Spravka();
        }
    }
}
