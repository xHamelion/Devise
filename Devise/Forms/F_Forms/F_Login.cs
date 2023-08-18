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
using System.Net;

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
            

            //Переход с Авторизацияа на регистрацию и обратно
            L_per.Click += (a, c) =>
            {
                if (this.Text == "Авторизация")
                {
                    this.Text = "Регистрация";
                    L_per.Text = "Авторизация";
                    BTN_Vhod_Reg.Text = "Регистрация";

                }
                else
                {
                    this.Text = "Авторизация";
                    L_per.Text = "Регистрация";
                    BTN_Vhod_Reg.Text = "Авторизация";
                }
                label1.Text = this.Text;

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

         void AddHistory()
         {
            int ID_Reg = 0;
            string FIO_Full = "";
            string F = "";
            string I = "";
            string O = "";
            ms.Open();
            com = new SqlCommand($"select (ID_Reg) from [Reg] where(Login = '{TB_Log.Text}' and Porol = '{TB_Porol.Text}')", ms);
            SqlDataReader sd = com.ExecuteReader();
            while (sd.Read())
            {
                ID_Reg = Convert.ToInt32( sd[0]);

            }
            ms.Close();
            ms.Open();

            com = new SqlCommand($"select FIO,Familia,Imia,Otzh from [View_Sotrudnic] where(ID_Reg = '{ID_Reg}')", ms);
            sd = com.ExecuteReader();
            
            while (sd.Read())
            {
                FIO_Full = sd[0].ToString();
                F = sd[1].ToString();
                I = sd[2].ToString();
                O = sd[3].ToString();
            }
            ms.Close();
            if(FIO_Full == "")
                Holder.FIO_Full = "Покупатель";
            else
                Holder.FIO_Full = FIO_Full;
            try
            {
                Holder.FIO_Socroshen = $"{F} {I.Substring(0, 1)}. {O.Substring(0, 1)}.";

            }
            catch 
            {
                Holder.FIO_Socroshen = $"Покупатель";

            }



            string hostName = Dns.GetHostName(); // Retrive the Name of HOST

            // Get the IP
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            ms.Open();
            com = new SqlCommand($"insert into History values('{ID_Reg}','{DateTime.Now}','{myIP}', '{System.Environment.MachineName}', '{FIO_Full}')", ms);
            com.ExecuteNonQuery();
            ms.Close();
        }

        private void F_Login_Load_1(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            //this.Icon = Properties.Resources.iconfinder_warehouse_3992927_112594;
            this.Text = "Авторизация";
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
            try
            {
                ms.Open();

            }
            catch
            {
                MessageBox.Show("Нет доступа к БД.\nПроверьте подключение или измените строку подключения",
                    "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                var f = new F_Setings();
                f.numericUpDown1.Enabled = false;
                f.numericUpDown2.Enabled = false;
                f.numericUpDown3.Enabled = false;
                f.numericUpDown4.Enabled = false;
                f.ShowDialog();
                ms.Close();
                return;
            }
            ms.Close();



            ms.Open();
            com = new SqlCommand($"select count(*) from [Reg] Where( Dostup = '0')  ",ms);
            if(int.Parse(com.ExecuteScalar().ToString()) == 0)
            {
                if(TB_Log.Text != "Admin"|| TB_Porol.Text != "Admin")
                {
                    MessageBox.Show("Не верный логин или пароль.","Ошибка");
                    ms.Close();
                    return;
                }
                Security security = new Security(0);
                Holder.FIO_Socroshen = "Первй запуск";
                Form menu = new F_Menu();
                author = true;
                menu.Show();
                ms.Close();
                this.Hide();
                return;
            }
                ms.Close();
                ms.Open();
            com = new SqlCommand($"select count(*) from [Reg] where(Login = '{TB_Log.Text}')", ms);
                if (this.Text != "Авторизация")
                {
                    if (int.Parse(com.ExecuteScalar().ToString()) == 0)
                    {
                        if (TB_Log.Text != "" && TB_Porol.Text != "")
                        {
                            com = new SqlCommand($"insert into Reg(Login,Porol,Dostup) values('{TB_Log.Text}','{TB_Porol.Text}','2')", ms);
                            com.ExecuteNonQuery();
                            MessageBox.Show("Успешно");
                            Security security = new Security(2);
                            ms.Close();
                        AddHistory();
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
                    ms.Close();
                        AddHistory();
                    Form menu = new F_Menu();
                    author = true;
                    menu.Show();
                         this.Hide();
                        }

                }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void BTN_Show_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Out_Click(object sender, EventArgs e)
        {

        }
    }
}
