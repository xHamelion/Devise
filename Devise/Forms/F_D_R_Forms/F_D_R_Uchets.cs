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
    public partial class F_D_R_Uchets : Form
    {
        public F_D_R_Uchets()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Строка подключения
        /// </summary>
        SqlConnection ms = new Connection().Sql();

        /// <summary>
        /// Команды
        /// </summary>
        SqlCommand com;

        public int ID;
        private void CB_PodTip_TextChanged(object sender, EventArgs e)
        {
            switch (CB_PodTip.SelectedIndex)
            {
                case 0:
                    richTextBox1.Text = "Администратор - полный доступ к приложению.";
                    break;
                case 1:
                    richTextBox1.Text = "Менеджер - доступ к продажам, добавлению и редактированию данных (удаление не доступно - кроме заказов которые не проведены.)";
                    break;
                case 2:
                    richTextBox1.Text = "Покупатель - доступен только просмотр данных.";
                    break;
            }
        }

        private void BTN_Otm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Red_Save_Click(object sender, EventArgs e)
        {
            ms.Open();
            if(CB_PodTip.Text == "")
            {
                MessageBox.Show("Выберите уровень доступа!");
                ms.Close();
                return;
            }
            try
            {
                if (BTN_Red_Save.Text == "Сохранить")
                {
                    com = new SqlCommand($"select count (*) from [Reg] where(Login = '{TB_Tovar.Text}' )", ms);

                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"insert into Reg(Login,Porol,Dostup)" +
                        $" values('{TB_Tovar.Text}','{textBox1.Text}','{CB_PodTip.SelectedIndex}')", ms);
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Такой логин уже есть");
                    }
                }
                else
                {
                    com = new SqlCommand($"select count (*) from [Reg] where(Login = '{TB_Tovar.Text}' and Dostup = '{CB_PodTip.SelectedIndex}' and " +
                        $"Porol = '{textBox1.Text}')", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"update Reg set Login = '{TB_Tovar.Text}', " +
                            $"Porol  = '{textBox1.Text}', Dostup = '{CB_PodTip.SelectedIndex}'  where (ID_Reg = '{ID}') ", ms);
                        com.ExecuteNonQuery();

                    }
                    else
                    {
                        MessageBox.Show("Такой логин уже есть");
                    }
                }
            }
            catch { }

            ms.Close();
        }

        private void F_D_R_Uchets_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;

        }
    }
}
