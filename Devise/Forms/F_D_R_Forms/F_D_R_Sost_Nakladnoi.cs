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
    public partial class F_D_R_Sost_Nakladnoi : Form
    {

        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        public string ID_Tovar=null;
        public string ID_Naklad;

        public F_D_R_Sost_Nakladnoi()
        {
            InitializeComponent();
        }

        private void F_D_R_Sost_Nakladnoi_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_PodTip". При необходимости она может быть перемещена или удалена.
            this.view_PodTipTableAdapter.Fill(this.deviseDataSet.View_PodTip);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.Tip". При необходимости она может быть перемещена или удалена.
            this.tipTableAdapter.Fill(this.deviseDataSet.Tip);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_Tovar". При необходимости она может быть перемещена или удалена.
            this.view_TovarTableAdapter.Fill(this.deviseDataSet.View_Tovar);

            if (ID_Tovar == null)
            {
                CB_Tovar.Text = "";
                comboBox1.Text = "";
                viewPodTipBindingSource.Filter = $"PodTip = '-685531'";
            }
            if (BTN_Red_Save.Text != "Сохранить")
            {
                panel1.Enabled = false;
            }


        }

        private void BTN_Red_Save_Click(object sender, EventArgs e)
        {
            ms.Open();
            try
            {
                if (BTN_Red_Save.Text == "Сохранить")
                {//Data_Izgot
                    com = new SqlCommand($"select count (*) from [Sost_Nakladna] where(ID_Nakladna = '{ID_Naklad}' and ID_Tovar = " +
                        $"'{CB_Tovar.SelectedValue}')", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"insert into Sost_Nakladna(ID_Nakladna, ID_Tovar, Koll, Zena, Summa)" +
                        $" values('{ID_Naklad}','{CB_Tovar.SelectedValue}',  '{NUP_Koll.Value}'" +
                        $" , '{TB_Zena.Text.Replace(',', '.')}','{TB_Summa.Text.Replace(',', '.')}')", ms);
                        ////SqlMoney z = (SqlMoney)Convert.ToDouble(TB_Zena.Text);
                        ////SqlMoney s = (SqlMoney)Convert.ToDouble(TB_Summa.Text);
                        //com.Parameters.Add("@Zena", SqlDbType.Money).Value = Convert.ToDouble(TB_Summa.Text);
                        //com.Parameters.Add("@Summa", SqlDbType.Money).Value = Convert.ToDouble(TB_Zena.Text);
                        ////MessageBox.Show("Test" + (SqlMoney)Convert.ToDouble(TB_Zena.Text));
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Такая запись уже есть");
                    }
                }
                else
                {
                    com = new SqlCommand($"select count (*) from [Sost_Nakladna] where(ID_Nakladna = '{ID_Naklad}' and ID_Tovar = " +
                        $"'{CB_Tovar.SelectedValue}' and Koll = '{NUP_Koll.Value}' and Zena = '{TB_Zena.Text}')", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"update Sost_Nakladna set   " +
                            $"Koll = '{NUP_Koll.Value}', " +
                            $"Zena = '{TB_Zena.Text.Replace(',', '.')}', " +
                            $"  Summa = '{TB_Summa.Text.Replace(',', '.')}' where (ID_Nakladna = '{ID_Naklad}' and ID_Tovar = '{ID_Tovar}') ", ms);
                        //com.Parameters.AddWithValue("@Zena", (SqlMoney)Convert.ToDouble(TB_Zena.Text));
                        //com.Parameters.AddWithValue("@Summa", (SqlMoney)Convert.ToDouble(TB_Summa.Text));
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

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            viewPodTipBindingSource.Filter = $"ID_Tip = '{comboBox1.SelectedValue}'";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            viewPodTipBindingSource.Filter = $"PodTip = '-685531'";
            textBox1.Text = "";
            viewTovarBindingSource.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewTovarBindingSource.Filter = $"Tip = '{comboBox1.Text}' and PodTip = '{comboBox2.Text}'" +
                $"and Tovar like '%{textBox1.Text}%' ";
        }

        private void NUP_Koll_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TB_Summa.Text = (Convert.ToDouble(NUP_Koll.Value) * Convert.ToDouble(TB_Zena.Text)).ToString();

            }
            catch
            {

            }
        }

        private void TB_Zena_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TB_Summa.Text = (Convert.ToDouble(NUP_Koll.Value) * Convert.ToDouble(TB_Zena.Text)).ToString();

            }
            catch
            {

            }
        }

        private void F_D_R_Sost_Nakladnoi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[3].Enabled = true;
            Application.OpenForms[3].Activate();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f = new F_D_R_Tovar();
            f.Text = "Добавить";
            f.BTN_Red_Save.Text = "Сохранить";
            f.ShowDialog();
            this.view_TovarTableAdapter.Fill(this.deviseDataSet.View_Tovar);
        }
    }
}
