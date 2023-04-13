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
    public partial class F_Pod_Kategor : Form
    {

        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        int position;
        public int ID_Tip;

        public F_Pod_Kategor()
        {
            InitializeComponent();
        }

        private void F_Pod_Kategor_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            this.hranim_PodTipTableAdapter.Fill(this.deviseDataSet.Hranim_PodTip, ID_Tip);

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
                position = hranimPodTipBindingSource.Position;
                DialogResult dr = MessageBox.Show("Желаете удалить?", $"Удаление", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    ms.Open();
                    com = new SqlCommand($"delete from [PodTip] " +
                        $"where(ID_PodTip = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}')", ms);
                    try
                    {
                        com.ExecuteNonQuery();

                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Невозможно удалить! Имеються связанные данные!");
                    }
                    ms.Close();
                    this.hranim_PodTipTableAdapter.Fill(this.deviseDataSet.Hranim_PodTip, ID_Tip);



                    hranimPodTipBindingSource.Position = position;
                }
                hranimPodTipBindingSource.Position = position;

            }
        }

        private void BTN_Dob_Click(object sender, EventArgs e)
        {
            position = hranimPodTipBindingSource.Position;
            var dob = new F_D_R_Pod_Kategor();
            dob.ID_Tip = ID_Tip.ToString();
            dob.BTN_Red_Save.Text = "Сохранить";
            dob.Text = "Создать запись";
            dob.ShowDialog();
            this.hranim_PodTipTableAdapter.Fill(this.deviseDataSet.Hranim_PodTip, ID_Tip);


            hranimPodTipBindingSource.Position = position;
        }

        private void BTN_Red_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                position = hranimPodTipBindingSource.Position;
                var dob = new F_D_R_Pod_Kategor();
                dob.TB_Tip.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dob.BTN_Red_Save.Text = "Редактировать";
                dob.Text = "Редактировать запись";
                dob.ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dob.ShowDialog();
                this.hranim_PodTipTableAdapter.Fill(this.deviseDataSet.Hranim_PodTip, ID_Tip);


                hranimPodTipBindingSource.Position = position;

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

        private void F_Pod_Kategor_FormClosed(object sender, FormClosedEventArgs e)
        {
           

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                var f = new F_D_R_Hablon_Haract();
                f.ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                f.ShowDialog();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            hranimPodTipBindingSource.Filter = "";
            CB_Fio_sotr.Text = "";
            CB_Fio_Pok.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hranimPodTipBindingSource.Filter = $"Tip like '%{CB_Fio_Pok.Text}%' and PodTip like '%{CB_Fio_sotr.Text}%' ";
        }

        private void btn_spravka_Click(object sender, EventArgs e)
        {
            new Spravka();
        }
    }
}
