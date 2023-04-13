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
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_Sklad". При необходимости она может быть перемещена или удалена.
            this.view_SkladTableAdapter.Fill(this.deviseDataSet.View_Sklad);


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
                    c = (double.Parse(sredn_ZenaLabel2.Text) * ((double.Parse(Properties.Resources.String1) / 100.0) + 1.0)).ToString();
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
                        $" values('{ID_Naklad}','{CB_Tovar.SelectedValue}', '{NUP_Koll.Value}','{TB_Zena.Text}', '{TB_Summa.Text}'" +
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
                        $"'{ID_Naklad}' and Koll = '{NUP_Koll.Value}' and Zena = '{TB_Zena.Text}')", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"update Sost_Naklad_Prodag set   " +
                            $"Koll = '{NUP_Koll.Value}', " +
                            $"Zena = '{TB_Zena.Text}', " +
                            $"  Summa = '{TB_Summa.Text}' where (ID_Naklad_Prodag = '{ID_Naklad}' and ID_Tovar = '{ID_Tov}') ", ms);
                        //com.Parameters.AddWithValue("@Zena", (SqlMoney)Convert.ToDouble(TB_Zena.Text));
                        //com.Parameters.AddWithValue("@Summa", (SqlMoney)Convert.ToDouble(TB_Summa.Text));
                        com.ExecuteNonQuery();

                    }
                    else
                    {
                        MessageBox.Show("Такая запись уже естьЫ");
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
                TB_Summa.Text = (int.Parse(TB_Zena.Text) * int.Parse(NUP_Koll.Value.ToString())).ToString();
            }
            catch
            {

            }
        }

        private void NUP_Koll_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                TB_Summa.Text = (int.Parse(TB_Zena.Text) * int.Parse(NUP_Koll.Value.ToString())).ToString();
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
    }
}
