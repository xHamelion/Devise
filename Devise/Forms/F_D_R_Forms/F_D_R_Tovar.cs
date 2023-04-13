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
using System.IO;
using System.Data.SqlTypes;

namespace Devise
{
    public partial class F_D_R_Tovar : Form
    {
        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        public string ID;

        public F_D_R_Tovar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        byte[] imageData = null;

        private void F_D_R_Tovar_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_PodTip". При необходимости она может быть перемещена или удалена.
            this.view_PodTipTableAdapter.Fill(this.deviseDataSet.View_PodTip);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.Tip". При необходимости она может быть перемещена или удалена.
            this.tipTableAdapter.Fill(this.deviseDataSet.Tip);

            if (ID == null)
            {
                CB_Tip.Text = "";
                CB_Tip_SelectedValueChanged(null, null);
                viewPodTipBindingSource.Filter = $"ID_Tip = '{-5}'";
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog op = new OpenFileDialog())
                {
                    op.ShowDialog();
                    pictureBox1.Image = Image.FromStream(File.OpenRead(op.FileName));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    FileStream stream = new FileStream(op.FileName, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    imageData = brs.ReadBytes((int)stream.Length);
                }
            }
            catch { }
            
        }

        private void comboBox1_ValueMemberChanged(object sender, EventArgs e)
        {
           
        }

        private void CB_Tip_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CB_Tip.Text != "")
            {
                CB_PodTip.DataSource = viewPodTipBindingSource;
                CB_PodTip.DisplayMember = "PodTip";
                CB_PodTip.ValueMember = "ID_PodTip";
                viewPodTipBindingSource.Filter = $"ID_Tip = '{CB_Tip.SelectedValue}'";
            }
            else
            {
                CB_PodTip.Text = "";
            }
        }

        private void BTN_Red_Save_Click(object sender, EventArgs e)
        {
            ms.Open();
             
                try
                {
                    if (BTN_Red_Save.Text == "Сохранить")
                    {
                        com = new SqlCommand($"select count (*) from [Tovar] where(Tovar = '{TB_Tovar.Text}')", ms);
                        if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                        {
                            com = new SqlCommand($"insert into  Tovar(Tovar,Opisanie,ID_PodTip,Image)" +
                            $" values('{TB_Tovar.Text}', '{richTextBox1.Text}', '{CB_PodTip.SelectedValue}', " +
                            $"@Image)", ms);
                            com.Parameters.Add(new SqlParameter("@Image", imageData)); ; 

                            com.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Такая запись уже есть");
                        }
                    }
                    else
                    {
                        com = new SqlCommand($"select count (*) from [Tovar] where(Tovar = '{TB_Tovar.Text}' and Opisanie = '{richTextBox1.Text}' " +
                            $"and ID_PodTip = '{CB_PodTip.SelectedValue}')", ms);
                            
                        if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                        {
                            com = new SqlCommand($"update Tovar set Tovar = '{TB_Tovar.Text}', Opisanie = '{richTextBox1.Text}', " +
                                $"ID_PodTip = '{CB_PodTip.SelectedValue}'   where (ID_Tovar = '{ID}') ", ms);
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
                    MessageBox.Show("Заполните все поля!!!");

                }
            
            

            ms.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Желаете использовать шаблон? Это удалит уже введеный текст.", $"Шаблон товара", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                ms.Open();
                com = new SqlCommand($"select count (*) from [Hablon] where(ID_PodTip = '{CB_PodTip.SelectedValue}'  )", ms);
                if (Convert.ToInt32(com.ExecuteScalar()) != 0)
                {
                    com = new SqlCommand($"select * from [Hablon] where(ID_PodTip = '{CB_PodTip.SelectedValue}'  )", ms);
                    SqlDataReader s = com.ExecuteReader();
                    s.Read();
                    richTextBox1.Text = s[1].ToString();
                    s.Close();
                }
                else
                {
                    DialogResult dr2 = MessageBox.Show("Шаблон не сушествует! Желаете создать его?.", $"Шаблон товара", MessageBoxButtons.YesNo);
                    if (dr2 == DialogResult.Yes)
                    {
                        var f = new F_D_R_Hablon_Haract();
                        f.ID = CB_PodTip.SelectedValue.ToString();
                        f.ShowDialog();
                    }
                }
                ms.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f = new F_D_R_Tip();
            f.BTN_Red_Save.Text = "Сохранить";
            f.Text = "Создать запись";
            f.ShowDialog();
            this.tipTableAdapter.Fill(this.deviseDataSet.Tip);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var f = new F_D_R_Pod_Kategor();
            f.BTN_Red_Save.Text = "Сохранить";
            f.Text = "Создать запись";
            f.ID_Tip = CB_Tip.SelectedValue.ToString();
            f.ShowDialog();
            this.view_PodTipTableAdapter.Fill(this.deviseDataSet.View_PodTip);
        }

        private void F_D_R_Tovar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[2].Enabled = true;
            Application.OpenForms[2].Activate();
        }
    }
}
