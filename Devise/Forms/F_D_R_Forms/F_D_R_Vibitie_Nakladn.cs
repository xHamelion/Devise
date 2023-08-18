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
    public partial class F_D_R_Vibitie_Nakladn : Form
    {

        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        public string ID;
        public string Summa="0";
        public string Summa_Obh="0";
        private int ID_InternetUser;
        public F_D_R_Vibitie_Nakladn()
        {
            InitializeComponent();
        }

        private void BTN_Red_Save_Click(object sender, EventArgs e)
        {

            ms.Open();
            com = new SqlCommand($"select count(*) from [InternetUser] where(Familia = 'Локальный пользователь' and Imia = 'Локальный пользователь')",ms);
            if (Convert.ToInt32(com.ExecuteScalar()) == 0)
            {
                ms.Close();
                ms.Open();
                //NLdOb2OyN2k#icJFCh$
                com = new SqlCommand($"insert into [InternetUser] values('Локальный пользователь','Локальный пользователь','Локальный пользователь','Локальный пользователь','LocalUserPKDevise','NLdOb2OyN2k#icJFCh$')", ms);
                com.ExecuteNonQuery();
                ms.Close();
            }
            else
                ms.Close();

            ms.Open();
            com = new SqlCommand($"select ID_InternetUser from [InternetUser] where(Familia = 'Локальный пользователь' and Imia = 'Локальный пользователь')",ms);
            SqlDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                ID_InternetUser = Convert.ToInt32( rd[0].ToString());

            }
            ms.Close();


            if (checkBox1.Checked != true)
            {

                TB_Nomer.Text = DTP.Value.ToLongTimeString().Replace(' ', '\0') + comboBox1.Text.Substring(0, 3) + CB_Sotrud.Text.Substring(0, 2) +
                    DTP.Value.ToLongDateString().Replace(' ', '\0');
             
            }
             
            ms.Open();
            string c = TB_Dost.Text;
            if(c.IndexOf(',')>0)
                c = c.Substring(0, c.IndexOf(','));

            if(TB_Nomer.Text!="")
            try
            {
                if (BTN_Red_Save.Text == "Сохранить")
                {
                    com = new SqlCommand($"select count (*) from [Naklad_Prodag] where(Nomer = '{TB_Nomer.Text}' and ID_Pokup = '{comboBox1.SelectedValue}')", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"insert into  Naklad_Prodag(Nomer, Data_Pokup, ID_Pokup, ID_Sotrudnic,Summa,Dostavka,Summa_Obh,ID_InternetUser)" +
                        $" values('{TB_Nomer.Text}','{DTP.Value}', '{comboBox1.SelectedValue}','{CB_Sotrud.SelectedValue}', '{Summa}', '{c}', '{TB_Dost.Text}', '{ID_InternetUser}')", ms);
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Такая запись уже есть");
                    }
                }
                else
                {
                    com = new SqlCommand($"select count (*) from [Naklad_Prodag] where(Nomer = '{TB_Nomer.Text}' and ID_Pokup = '{comboBox1.SelectedValue} '" +
                        $"and Dostavka = '{TB_Dost.Text}'and ID_Sotrudnic = '{CB_Sotrud.SelectedValue}')", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"update Naklad_Prodag set Nomer = '{TB_Nomer.Text}', Data_Pokup = '{DTP.Value}', ID_Pokup = '{comboBox1.SelectedValue}', " +
                            $" ID_Sotrudnic = '{CB_Sotrud.SelectedValue}', Dostavka = '{c}'  " +
                            $" where (ID_Naklad_Prodag = '{ID}') ", ms);
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
                MessageBox.Show("Ошибка в ведении!");
            }
            else
            {
                MessageBox.Show("Введите номер или уберите галочку!");
            }

            ms.Close();
        }

        private void F_D_R_Vibitie_Nakladn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[2].Enabled = true;
            Application.OpenForms[2].Activate();

        }

        private void F_D_R_Vibitie_Nakladn_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_Sotrudnic". При необходимости она может быть перемещена или удалена.
            this.view_SotrudnicTableAdapter.Fill(this.deviseDataSet.View_Sotrudnic);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_Pokup". При необходимости она может быть перемещена или удалена.
            this.view_PokupTableAdapter.Fill(this.deviseDataSet.View_Pokup);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.Pokup". При необходимости она может быть перемещена или удалена.

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                TB_Nomer.Enabled = true;
            }
            else
            {
                TB_Nomer.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var f = new F_D_R_Pokup();
            f.BTN_Red_Save.Text = "Сохранить";
            f.Text = "Добавить";
            f.ShowDialog();
            this.view_PokupTableAdapter.Fill(this.deviseDataSet.View_Pokup);
        }
    }
}
