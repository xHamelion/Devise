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
    public partial class F_Postavhick : Form
    {
        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        int position;


        public F_Postavhick()
        {
            InitializeComponent();
        }

        private void F_Postavhick_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.Postavhick". При необходимости она может быть перемещена или удалена.
            this.postavhickTableAdapter.Fill(this.deviseDataSet.Postavhick);

        }

        private void F_Postavhick_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Enabled = true;
            Application.OpenForms[1].Activate();
        }

        private void Exel_Click(object sender, EventArgs e)
        {
            new Exel(dataGridView1, "Поставшики");

        }

        private void PDF_Click(object sender, EventArgs e)
        {
            new PDF(dataGridView1, "Поставшики");

        }

        private void BTN_Dell_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                
                position = postavhickBindingSource.Position;
                DialogResult dr = MessageBox.Show("Желаете удалить?", $"Удаление", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    ms.Open();
                    com = new SqlCommand($"delete from [Postavhick] " +
                        $"where(ID_Postavhick = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}')", ms);
                    try
                    {
                        com.ExecuteNonQuery();

                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Невозможно удалить! Имеються связанные данные!");
                    }
                    ms.Close();
                    F_Postavhick_Load(null, null);
                    this.postavhickTableAdapter.Fill(this.deviseDataSet.Postavhick);
                    postavhickBindingSource.Position = position;
                }
            }
        }

        private void BTN_Dob_Click(object sender, EventArgs e)
        {
             
                position = postavhickBindingSource.Position;
                var dob = new F_D_R_Postavhick();
                dob.BTN_Red_Save.Text = "Сохранить";
                dob.Text = "Создать запись";
                dob.ShowDialog();
                F_Postavhick_Load(null, null);
                this.postavhickTableAdapter.Fill(this.deviseDataSet.Postavhick);
                postavhickBindingSource.Position = position;

        }

        private void BTN_Red_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                position = postavhickBindingSource.Position;
                var dob = new F_D_R_Postavhick();

                dob.TB_Naim_Org.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dob.MTB_Telef.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dob.BTN_Red_Save.Text = "Редактировать";
                dob.Text = "Редактировать запись";
                dob.ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dob.ShowDialog();
                F_Postavhick_Load(null, null);
                this.postavhickTableAdapter.Fill(this.deviseDataSet.Postavhick);
                postavhickBindingSource.Position = position;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            postavhickBindingSource.Filter = "";
            CB_Fio_sotr.Text = "";
            CB_Fio_Pok.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            postavhickBindingSource.Filter = $"Naimenovanie_Organiz like '%{CB_Fio_Pok.Text}%' and Telefon like '%{CB_Fio_sotr.Text}%'";
        }

        private void btn_spravka_Click(object sender, EventArgs e)
        {
            new Spravka();
        }
    }
}
