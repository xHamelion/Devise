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
        public string ID = "-1";


        public F_D_R_Sotrudnic()
        {
            InitializeComponent();
        }

        private void BTN_Red_Save_Click(object sender, EventArgs e)
        {
            ms.Open();
            com = new SqlCommand($"select count (*) from [Sotrudnic] where(ID_Reg = '{comboBox1.SelectedValue}' and not ID_Sotrudnic  = '{ID}')", ms);
            if (Convert.ToInt32(com.ExecuteScalar()) != 0)
            {
                MessageBox.Show("Такой аккаунт уже есть у другого сотрудника выберите другой или создайте новый.",
                    "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ms.Close();
                return;
            }
            ms.Close();
            ms.Open();
            try
            {

                
                if (BTN_Red_Save.Text == "Сохранить")
                {
                    com = new SqlCommand($"select count (*) from [Sotrudnic] where(Familia = '{TB_Famil.Text}' and Imia = " +
                        $"'{TB_Name.Text}' and Otzh = '{TB_Otzh.Text}' and ID_Reg = '{comboBox1.SelectedValue}')", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"insert into Sotrudnic(Familia, Imia, Otzh,  Telefon, ID_Reg)" +
                        $" values('{TB_Famil.Text}','{TB_Name.Text}', '{TB_Otzh.Text}',  '{MTB_Tel.Text}' , '{comboBox1.SelectedValue}')", ms);
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
                         $"'{TB_Name.Text}' and Otzh = '{TB_Otzh.Text}'  and Telefon = '{MTB_Tel.Text}' and ID_Reg = '{comboBox1.SelectedValue}')", ms);
                    if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                    {
                        com = new SqlCommand($"update Sotrudnic set Familia = '{TB_Famil.Text}', Imia = '{TB_Name.Text}',  Otzh = '{TB_Otzh.Text}', " +
                            $"  Telefon = '{MTB_Tel.Text}', ID_Reg = '{comboBox1.SelectedValue}' where (ID_Sotrudnic = '{ID}') ", ms);
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
        public int id_Reg;
        private void F_D_R_Sotrudnic_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.Reg". При необходимости она может быть перемещена или удалена.
            this.regTableAdapter.Fill(this.deviseDataSet.Reg);
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            comboBox1.SelectedValue = id_Reg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var f =  new F_D_R_Uchets();
            f.BTN_Red_Save.Text = "Сохранить";
            f.Text = "Добавить";
            f.ShowDialog();
            this.regTableAdapter.Fill(this.deviseDataSet.Reg);
        }
    }
}
