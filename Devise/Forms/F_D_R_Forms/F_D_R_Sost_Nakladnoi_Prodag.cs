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
    public partial class F_D_R_Sost_Nakladnoi_Prodag : Form
    {

        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        public int ID_Naklad = 0;
        public int ID_Tov = 0;
        public F_D_R_Sost_Nakladnoi_Prodag()
        {
            InitializeComponent();
        }

        private void F_D_R_Sost_Nakladnoi_Prodag_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_PodTip". При необходимости она может быть перемещена или удалена.
            this.view_PodTipTableAdapter.Fill(this.deviseDataSet.View_PodTip);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.Tip". При необходимости она может быть перемещена или удалена.
            this.tipTableAdapter.Fill(this.deviseDataSet.Tip);
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_Sklad". При необходимости она может быть перемещена или удалена.
            this.view_SkladTableAdapter.Fill(this.deviseDataSet.View_Sklad);

            comboBox1.Text = "";
            viewPodTipBindingSource.Filter = $"PodTip = '-685531'";
            textBox1.Text = "";
            viewSkladBindingSource.Filter = "";
            if (BTN_Red_Save.Text != "Сохранить")
            {
                panel1.Enabled = false;
            }
        }

        private void sredn_ZenaLabel2_TextChanged(object sender, EventArgs e)
        {
            ms.Open();
            string c = "";
            try
            {
                if (CB_Tovar.SelectedValue != null)
                {
                    com = new SqlCommand($"select Koll from [Sklad] where " +
                       $"(ID_Tovar = '{CB_Tovar.SelectedValue}')", ms);
                    SqlDataReader sq = com.ExecuteReader();
                    sq.Read();
                    NUP_Koll.Maximum = (int)sq[0];
                    sq.Close();
                    c = (double.Parse(sredn_ZenaLabel2.Text) * ((Convert.ToDouble(Properties.Settings.Default.Skidka) / 100.0) )).ToString();
                    if (c.IndexOf(',') > 0)
                        label8.Text = c.Substring(0, c.IndexOf(','));
                    else
                        label8.Text = c;
                }



            }
            catch { }

            ms.Close();
        }

        private void lab1_Click(object sender, EventArgs e)
        {
            
        }

        private void BTN_Red_Save_Click(object sender, EventArgs e)
        {

            ms.Open();
            if(CB_Tovar.Text != ""&&NUP_Koll.Value!=0&&TB_Zena.Text!=""&&TB_Summa.Text!="")
            try
            {
                if (BTN_Red_Save.Text == "Сохранить")
                {//Data_Izgot
                    com = new SqlCommand($"select count (*) from [Sost_Naklad_Prodag] where(ID_Tovar = '{CB_Tovar.SelectedValue}' and ID_Naklad_Prodag = " +
                       $"'{ID_Naklad}')", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"insert into Sost_Naklad_Prodag(ID_Naklad_Prodag, ID_Tovar, Koll, Zena ,Summa)" +
                        $" values('{ID_Naklad}','{CB_Tovar.SelectedValue}', '{NUP_Koll.Value}','{TB_Zena.Text.Replace(',','.')}', '{TB_Summa.Text.Replace(',', '.')}'" +
                        $" )", ms);
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
                    com = new SqlCommand($"select count (*) from [Sost_Naklad_Prodag] where(ID_Tovar = '{CB_Tovar.SelectedValue}' and ID_Naklad_Prodag = " +
                        $"'{ID_Naklad}' and Koll = '{NUP_Koll.Value}' and Summa = '{TB_Summa.Text.Replace(',', '.')}' )", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"update Sost_Naklad_Prodag set   " +
                            $"Koll = '{NUP_Koll.Value}', " +
                            $"Zena = '{TB_Zena.Text.Replace(',', '.')}', " +
                            $"  Summa = '{TB_Summa.Text.Replace(',', '.')}' where (ID_Naklad_Prodag = '{ID_Naklad}' and ID_Tovar = '{ID_Tov}') ", ms);
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
            else
            {
                MessageBox.Show("Заполните все поля");
            }

            ms.Close();
        }

        private void TB_Zena_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TB_Summa.Text = (double.Parse(TB_Zena.Text) * double.Parse(NUP_Koll.Value.ToString())).ToString();
            }
            catch
            {

            }
        }

        private void NUP_Koll_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                TB_Summa.Text = (double.Parse(TB_Zena.Text) * double.Parse(NUP_Koll.Value.ToString())).ToString();
            }
            catch
            {

            }
        }

        private void F_D_R_Sost_Nakladnoi_Prodag_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[3].Enabled = true;
            Application.OpenForms[3].Activate();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as CheckBox).Checked)
            {
                TB_Zena.Text = label8.Text;

            }
            CheckRadioButton();
        }

        private void CheckRadioButton()
        {
            double zen = 0;
            if (checkBox1.Checked)
                TB_Zena.Text = label8.Text;
            try
            {
                 zen = Convert.ToDouble(TB_Zena.Text);

            }
            catch { return; }
            if (radioButton1.Checked)
            {
                TB_Zena.Text = (zen).ToString();
            }
            else if (radioButton2.Checked)
            {
                TB_Zena.Text = (zen - ((zen * (Properties.Settings.Default.SkidkaPension / 100.0)) - zen)).ToString();
            }
            else
                TB_Zena.Text = (zen - ((zen * (Properties.Settings.Default.Skidka_Inaia / 100.0)) - zen)).ToString();

        }

        private void CB_Tovar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                TB_Zena.Text = label8.Text;
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                TB_Zena.Text = label8.Text;
            CheckRadioButton();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            CheckRadioButton();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewSkladBindingSource.Filter = $"Tip = '{comboBox1.Text}' and PodTip = '{comboBox2.Text}'" +
               $"and Tovar like '%{textBox1.Text}%' ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            viewPodTipBindingSource.Filter = $"PodTip = '-685531'";
            textBox1.Text = "";
            viewSkladBindingSource.Filter = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewPodTipBindingSource.Filter = $"ID_Tip = '{comboBox1.SelectedValue}'";

        }
    }
}
