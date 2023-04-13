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
    public partial class F_D_R_Hablon_Haract : Form
    {
        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        public string ID;

        public F_D_R_Hablon_Haract()
        {
            InitializeComponent();
            switch (Holder.level)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    BTN_Red_Save.Enabled = false;
                    break;
            }
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
        }

        private void F_D_R_Hablon_Haract_Load(object sender, EventArgs e)
        {
            ms.Open();
            com = new SqlCommand($"select count (*) from [Hablon] where(ID_PodTip = '{ID}'  )", ms);
            if (Convert.ToInt32(com.ExecuteScalar()) != 0)
            {
            com = new SqlCommand($"select * from [Hablon] where(ID_PodTip = '{ID}'  )", ms);
                SqlDataReader s = com.ExecuteReader();
                s.Read();
                richTextBox1.Text = s[1].ToString();
                s.Close();
            }
            ms.Close();
        }

        private void BTN_Red_Save_Click(object sender, EventArgs e)
        {
            ms.Open();

            try
            {
                com = new SqlCommand($"select count (*) from [Hablon] where(ID_PodTip = '{ID}'  )", ms);
                if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                {
                    
                        com = new SqlCommand($"insert into Hablon(ID_PodTip, Hablon)" +
                        $" values('{ID}','{richTextBox1.Text}')", ms);
                        com.ExecuteNonQuery();
                   
                }
                else
                {
                    
                    
                        com = new SqlCommand($"update Hablon set  Hablon = '{richTextBox1.Text}'" +
                            $" where (ID_PodTip = '{ID}') ", ms);
                        com.ExecuteNonQuery();

                }
            }
            catch { }

            ms.Close();
        }
    }
}
