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
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
            button1_Click();
        }

        public bool author = false;

        /// <summary>
        /// Строка подключения
        /// </summary>
        SqlConnection ms = new Connection().Sql();

        /// <summary>
        /// Команды
        /// </summary>
        SqlCommand com;

        CheckBox cb = new CheckBox();


        private void button1_Click()
        {
            

            //Переход с входа на регистрацию и обратно
            L_per.Click += (a, c) =>
            {
                if (this.Text == "Вход")
                {
                    this.Text = "Регистрация";
                    L_per.Text = "Вход";
                    BTN_Vhod_Reg.Text = "Регистрация";

                }
                else
                {
                    this.Text = "Вход";
                    L_per.Text = "Зарегистрироваться";
                    BTN_Vhod_Reg.Text = "Вход";
                }
            };


            //Выход
            BTN_Out.Click += (a, c) =>
            {
                Application.Exit();
            };

            //Переключение пороля
            BTN_Show.Click += (a, c) =>
            {
                if (cb.Checked == false)
                {
                    TB_Porol.PasswordChar = '\0';
                    BTN_Show.BackgroundImage = Properties.Resources.Show;
                    cb.Checked = true;
                }
                else
                {
                    cb.Checked = false;
                    TB_Porol.PasswordChar = '*';
                    BTN_Show.BackgroundImage = Properties.Resources.NonShow;
                }
            };
        }

         

        private void F_Login_Load_1(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            //this.Icon = Properties.Resources.iconfinder_warehouse_3992927_112594;
            this.Text = "Вход";
            BTN_Show.BackgroundImage = Properties.Resources.NonShow;
        }

        private void L_per_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btn_spravka_Click(object sender, EventArgs e)
        {
            new Spravka();
        }

        public void BTN_Vhod_Reg_Click(object sender, EventArgs e)
        {
            
                ms.Open();
                com = new SqlCommand($"select count(*) from [Reg] where(Login = '{TB_Log.Text}')", ms);
                if (this.Text != "Вход")
                {
                    if (int.Parse(com.ExecuteScalar().ToString()) == 0)
                    {
                        if (TB_Log.Text != "" && TB_Porol.Text != "")
                        {
                            com = new SqlCommand($"insert into Reg(Login,Porol,Dostup) values('{TB_Log.Text}','{TB_Porol.Text}','2')", ms);
                            com.ExecuteNonQuery();
                            MessageBox.Show("Успешно");
                            Security security = new Security(2);
                            Form menu = new F_Menu();
                            menu.Show();
                        author = true;
                            this.Hide();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Такой логин уже есть!");
                    }
                }
                else
                {
                    com = new SqlCommand($"select count(*) from [Reg] where(Login = '{TB_Log.Text}' and Porol = '{TB_Porol.Text}')", ms);
                    SqlCommand autific = new SqlCommand($"select * from [Reg] where(Login = '{TB_Log.Text}' and Porol = '{TB_Porol.Text}')", ms);

                    if (int.Parse(com.ExecuteScalar().ToString()) == 1)
                    {
                        SqlDataReader sdr = autific.ExecuteReader();
                        sdr.Read();
                        Security security = new Security((int)sdr[3]);
                        sdr.Close();
                        Form menu = new F_Menu();
                        author = true;
                        menu.Show();
                    this.Hide();
                    }

                }
                ms.Close();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void BTN_Show_Click(object sender, EventArgs e)
        {

        }
    }
}
