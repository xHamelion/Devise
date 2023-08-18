using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Devise
{
    public partial class F_Setings : Form
    {
        public F_Setings()
        {
            InitializeComponent();
        }
        string conStr = "";
        int naz = 0;
        private void F_Setings_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_Sklad". При необходимости она может быть перемещена или удалена.
            try
            {
                this.view_SkladTableAdapter.Fill(this.deviseDataSet.View_Sklad);

            }
            catch { }
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            numericUpDown1.Minimum= 0;
            numericUpDown1.Value = Properties.Settings.Default.Skidka-100;
            numericUpDown3.Value = Properties.Settings.Default.SkidkaPension-100;
            numericUpDown4.Value = Properties.Settings.Default.Skidka_Inaia-100;
            naz = (int)numericUpDown1.Value;
            numericUpDown2.Value = Properties.Settings.Default.Minuts;
            numericUpDown1.Maximum = 100;
                conStr = ConfigurationManager.ConnectionStrings["Devise.Properties.Settings.DeviseConnectionString"].ConnectionString;
            richTextBox1.Text = conStr;
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Enabled)
                Properties.Settings.Default.Skidka = 100 + (int)numericUpDown1.Value;
            if (numericUpDown2.Enabled)
                Properties.Settings.Default.Minuts =  (int)numericUpDown2.Value;
            if (numericUpDown3.Enabled)
                Properties.Settings.Default.SkidkaPension = 100 + (int)numericUpDown3.Value;
            if(numericUpDown4.Enabled)
                Properties.Settings.Default.Skidka_Inaia = 100 + (int)numericUpDown4.Value;
            
            if (numericUpDown2.Enabled)
                Properties.Settings.Default.Save();

            if (naz != numericUpDown1.Value)
                new Peresh_Sklad(dataGridView1);

            if (conStr != richTextBox1.Text)
            {

                DialogResult r = MessageBox.Show("Вы изменили строку подключения. Приложение необходимо перезапустить\nПерезапустить?",
                    "Изменение строки подключения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.No == r)
                {
                    richTextBox1.Text = conStr;
                    return;
                }
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings["Devise.Properties.Settings.DeviseConnectionString"].ConnectionString = richTextBox1.Text;
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");
                Application.Restart();
            }
            else
                this.Close();

        }
    }
}
