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
    public partial class F_D_R_Tip : Form
    {
        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        public string ID;

        public F_D_R_Tip()
        {
            InitializeComponent();
        }

        private void BTN_Red_Save_Click(object sender, EventArgs e)
        {
            ms.Open();

            try
            {
                if (BTN_Red_Save.Text == "Сохранить")
                {
                    com = new SqlCommand($"select count (*) from [Tip] where(Tip = '{TB_Tip.Text}' )", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"insert into Tip(Tip)" +
                        $" values('{TB_Tip.Text}')", ms);
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Такая запись уже есть");
                    }
                }
                else
                {
                    com = new SqlCommand($"select count (*) from [Tip] where(Tip = '{TB_Tip.Text}' )", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"update Tip set Tip = '{TB_Tip.Text}' where (ID_Tip = '{ID}') ", ms);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TB_Tip_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_D_R_Tip_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;

        }
    }
}
