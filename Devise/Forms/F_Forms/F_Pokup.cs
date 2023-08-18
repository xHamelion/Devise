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
    public partial class F_Pokup : Form
    {

        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        int position;

        public F_Pokup()
        {
            InitializeComponent();
        }

        private void F_Pokup_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;

            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_Pokup". При необходимости она может быть перемещена или удалена.
            this.view_PokupTableAdapter.Fill(this.deviseDataSet.View_Pokup);

        }

        private void Exel_Click(object sender, EventArgs e)
        {
            new Exel(dataGridView1, "Покупатели");

        }

        private void PDF_Click(object sender, EventArgs e)
        {
            new PDF(dataGridView1, "Покупатели");

        }

        private void BTN_Dob_Click(object sender, EventArgs e)
        {
            position = viewPokupBindingSource.Position;
            var dob = new F_D_R_Pokup();
            dob.BTN_Red_Save.Text = "Сохранить";
            dob.Text = "Создать запись";
            dob.ShowDialog();
            this.view_PokupTableAdapter.Fill(this.deviseDataSet.View_Pokup);
            viewPokupBindingSource.Position = position;

        }

        private void BTN_Dell_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                position = viewPokupBindingSource.Position;
                DialogResult dr = MessageBox.Show("Желаете удалить?", $"Удаление", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    ms.Open();
                    com = new SqlCommand($"delete from [Pokup] " +
                        $"where(ID_Pokup = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}')", ms);
                    try
                    {
                        com.ExecuteNonQuery();

                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Невозможно удалить! Имеються связанные данные!");
                    }
                    ms.Close();
                    F_Pokup_Load(null, null);
                    this.view_PokupTableAdapter.Fill(this.deviseDataSet.View_Pokup);

                    viewPokupBindingSource.Position = position;
                }
            }
        }

        private void BTN_Red_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                position = viewPokupBindingSource.Position;
                var dob = new F_D_R_Pokup();
                 
                dob.TB_Famil.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dob.TB_Name.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dob.TB_Otzh.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                dob.MTB_Tel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dob.BTN_Red_Save.Text = "Редактировать";
                dob.Text = "Редактировать запись";
                dob.ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dob.ShowDialog();
                F_Pokup_Load(null, null);
                viewPokupBindingSource.Position = position;

            }
        }

        private void F_Pokup_FormClosed(object sender, FormClosedEventArgs e)
        {
            //#if DEBUG
            //return;
            //#endif
            Application.OpenForms[1].Enabled = true;
            Application.OpenForms[1].Activate();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            viewPokupBindingSource.Filter = "";
            CB_Fio_sotr.Text = "";
            CB_Fio_Pok.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewPokupBindingSource.Filter = $"FIO like '%{CB_Fio_Pok.Text}%' and Telefon like '%{CB_Fio_sotr.Text}%'";
        }

        private void btn_spravka_Click(object sender, EventArgs e)
        {
            new Spravka();
        }
    }
}
