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
    public partial class F_D_R_Sotrudnic : Form
    {

        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        public string ID;


        public F_D_R_Sotrudnic()
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
                    com = new SqlCommand($"select count (*) from [Sotrudnic] where(Familia = '{TB_Famil.Text}' and Imia = " +
                        $"'{TB_Name.Text}' and Otzh = '{TB_Otzh.Text}'  )", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"insert into Sotrudnic(Familia, Imia, Otzh,  Telefon)" +
                        $" values('{TB_Famil.Text}','{TB_Name.Text}', '{TB_Otzh.Text}',  '{MTB_Tel.Text}')", ms);
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Такая запись уже есть");
                    }
                }
                else
                {
                    com = new SqlCommand($"select count (*) from [Sotrudnic] where(Familia = '{TB_Famil.Text}' and Imia = " +
                         $"'{TB_Name.Text}' and Otzh = '{TB_Otzh.Text}'  and Telefon = '{MTB_Tel.Text}')", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"update Sotrudnic set Familia = '{TB_Famil.Text}', Imia = '{TB_Name.Text}',  Otzh = '{TB_Otzh.Text}', " +
                            $"  Telefon = '{MTB_Tel.Text}' where (ID_Sotrudnic = '{ID}') ", ms);
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

        private void F_D_R_Sotrudnic_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;

        }
    }
}
