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
    public partial class F_D_R_Pod_Kategor : Form
    {
        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        public string ID;
        public string ID_Tip;

        public F_D_R_Pod_Kategor()
        {
            InitializeComponent();
        }

        private void F_D_R_Pod_Kategor_Load(object sender, EventArgs e)
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
                    com = new SqlCommand($"select count (*) from [PodTip] where(PodTip = '{TB_Tip.Text}' )", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"insert into PodTip(PodTip,ID_Tip)" +
                        $" values('{TB_Tip.Text}','{ID_Tip}')", ms);
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Такая запись уже есть");
                    }
                }
                else
                {
                    com = new SqlCommand($"select count (*) from [PodTip] where(PodTip = '{TB_Tip.Text}' )", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"update PodTip set PodTip = '{TB_Tip.Text}' where (ID_PodTip = '{ID}') ", ms);
                        com.ExecuteNonQuery();

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
