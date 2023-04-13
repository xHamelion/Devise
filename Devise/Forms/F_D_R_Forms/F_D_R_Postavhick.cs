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
    public partial class F_D_R_Postavhick : Form
    {

        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        public string ID;

        public F_D_R_Postavhick()
        {
            InitializeComponent();
        }

        private void F_D_R_Postavhick_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            //Application.OpenForms[2].Enabled = false;

        }

        public void BTN_Red_Save_Click(object sender, EventArgs e)
        {
            if (TB_Naim_Org.Text == "" || MTB_Telef.Text == "+ (   )-   -  -")
                return;
            ms.Open();
            try
            {
                if (BTN_Red_Save.Text == "Сохранить")
                {
                    com = new SqlCommand($"select count (*) from [Postavhick] where( Naimenovanie_Organiz = '{TB_Naim_Org.Text}'   )", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"insert into Postavhick( Naimenovanie_Organiz , Telefon)" +
                        $" values('{TB_Naim_Org.Text}', '{MTB_Telef.Text}')", ms);
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Такая запись уже есть");
                    }
                }
                else
                {
                    com = new SqlCommand($"select count (*) from [Postavhick] where( Naimenovanie_Organiz = '{TB_Naim_Org.Text}' and Telefon = '{MTB_Telef.Text}' )", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"update Postavhick set  " +
                            $"Naimenovanie_Organiz = '{TB_Naim_Org.Text}', " +
                            $"  Telefon = '{MTB_Telef.Text}' where (ID_Postavhick = '{ID}') ", ms);
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
            ms.Close();
        }

        private void F_D_R_Postavhick_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void F_D_R_Postavhick_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[2].Enabled = true;
        }
    }
}
