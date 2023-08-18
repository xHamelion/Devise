using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devise
{
    public partial class F_D_R_InternetUser : Form
    {
        public F_D_R_InternetUser()
        {
            InitializeComponent();
        }
        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        public int ID;
        private void F_D_R_InternetUser_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;

        }

        private void BTN_Red_Save_Click(object sender, EventArgs e)
        {
            ms.Open();

            try
            {
                if (BTN_Red_Save.Text == "Сохранить")
                {
                    com = new SqlCommand($"select count (*) from [InternetUser] where(Login = '{textBox4.Text}' )", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"insert into InternetUser(Familia,Imia,Telefon,eMail,Login,Pass)" +
                        $" values('{TB_Tip.Text}', '{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}')", ms);
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Такой логин уже есть!");
                    }
                }
                else
                {
                    com = new SqlCommand($"select count (*) from [InternetUser] where(Login = '{textBox4.Text}' and Pass = '{textBox5.Text}' and " +
                        $"Familia = '{TB_Tip.Text}' and Imia = '{textBox1.Text}' and Telefon = '{textBox2.Text}' and  eMail = '{textBox3.Text}')", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        ms.Close();
                        ms.Open();
                        com = new SqlCommand($"update InternetUser set Familia = '{TB_Tip.Text}', Imia = '{textBox1.Text}'," +
                            $" Telefon = '{textBox2.Text}', eMail = '{textBox3.Text}', Login = '{textBox4.Text}', Pass = '{textBox5.Text}'   where (ID_InternetUser = '{ID}') ", ms);
                        com.ExecuteNonQuery();
                        ms.Close();
                    }
                    else
                    {
                        MessageBox.Show("Такая запись уже есть");
                    }
                }
            }
            catch { }

            ms.Close();
        }
    }
}
