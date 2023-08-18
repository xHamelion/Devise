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
    public partial class F_D_R_Postupl_Nakladn : Form
    {

        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        public string ID;

        public F_D_R_Postupl_Nakladn()
        {
            InitializeComponent();
        }

        private void F_D_R_Postupl_Nakladn_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.Postavhick". При необходимости она может быть перемещена или удалена.
            this.postavhickTableAdapter.Fill(this.deviseDataSet.Postavhick);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_Sotrudnic". При необходимости она может быть перемещена или удалена.
            this.view_SotrudnicTableAdapter.Fill(this.deviseDataSet.View_Sotrudnic);
            if (Holder.level != 0)
                button1.Enabled = false;
        }

        private void BTN_Red_Save_Click(object sender, EventArgs e)
        {
            ms.Open();
            try
            {
                if (BTN_Red_Save.Text == "Сохранить")
                {
                    com = new SqlCommand($"select count (*) from [Nakladna] where(Nomer = '{TB_Nomer.Text}' and ID_Postavhick = '{comboBox1.SelectedValue}')", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"insert into  Nakladna(Nomer, Data_Postavki, ID_Postavhick,ID_Sotrudnic )" +
                        $" values('{TB_Nomer.Text}','{DTP.Value}', '{comboBox1.SelectedValue}','{comboBox2.SelectedValue}')", ms);
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Такая запись уже есть");
                    }
                }
                else
                {
                    com = new SqlCommand($"select count (*) from [Nakladna] where(Nomer = '{TB_Nomer.Text}' and ID_Postavhick = '{comboBox1.SelectedValue}')", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"update Nakladna set Nomer = '{TB_Nomer.Text}', Data_Postavki = '{DTP.Value}', ID_Postavhick = '{comboBox1.SelectedValue}', " +
                            $"ID_Sotrudnic = '{comboBox2.SelectedValue}' where (ID_Nakladna = '{ID}') ", ms);
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Такая запись уже есть");
                    }
                }
            }
            catch
            {

            }

            ms.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f = new F_D_R_Postavhick();
            f.Text = "Добавить";
            f.BTN_Red_Save.Text = "Сохранить";
            f.ShowDialog();
            this.postavhickTableAdapter.Fill(this.deviseDataSet.Postavhick);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new F_D_R_Sotrudnic();
            f.Text = "Добавить";
            f.BTN_Red_Save.Text = "Сохранить";
            f.ShowDialog();
            this.view_SotrudnicTableAdapter.Fill(this.deviseDataSet.View_Sotrudnic);
        }

        private void F_D_R_Postupl_Nakladn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[2].Enabled = true;
            Application.OpenForms[2].Activate();
        }
    }
}
