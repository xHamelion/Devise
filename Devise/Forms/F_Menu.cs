using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devise
{
    public partial class F_Menu : Form
    {
        public F_Menu()
        {
            InitializeComponent();
            CreateControls();
        }


        void CreateControls()
        {
            richTextBox1.Text = $"{Holder.securityName}ская запись";
            switch (Holder.level)
            {
                case 0:
                    button2.Enabled = true;
                    button4.Enabled = true;
                    BTN_Add_Reg.Enabled = true;
                    break;
                case 1:
                    
                    break;
                case 2:
                    button9.Enabled = false;
                    button7.Enabled = false;
                    button13.Enabled = false;
                    button11.Enabled = false;
                    button6.Enabled = false;
                    button3.Enabled = false;
                    button5.Enabled = false;
                    поставшикиToolStripMenuItem.Enabled = false;
                    покупателиToolStripMenuItem.Enabled = false;
                    сотрудникиToolStripMenuItem.Enabled = false;
                    поступлениеToolStripMenuItem.Enabled = false;
                    выбытиеToolStripMenuItem.Enabled = false;
                    break;

            }

           


        }


        private void поставшикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new F_Postavhick().Show();
            this.Enabled = false;
        }

        private void покупателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new F_Pokup().Show();
            this.Enabled = false;
        }

        private void категоряТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new F_Kategor().Show();
            this.Enabled = false;

        }

        private void F_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new F_Tovar().Show();
            this.Enabled = false;
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new F_Sotrudnic().Show();
            this.Enabled = false;
        }

        private void новоеПоступлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new F_Postupl_Nakladn().Show();
            this.Enabled = false;
        }

        private void журналПоступленийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new F_J_Postup().Show();
            this.Enabled = false;
        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new F_Sklad().Show();
            this.Enabled = false;
        }

        private void новоеВыбитиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Vibitie_Naklad f = new F_Vibitie_Naklad();
            f.ShowDialog();
        }

        private void журналВыбытийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_J_Vibit f = new F_J_Vibit();
            f.ShowDialog();
        }

        private void F_Menu_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Spravka();
        }

        private void button6_Click(object sender, EventArgs e)
        {
             
             
        }

        private void button8_Click(object sender, EventArgs e)
        {
            складToolStripMenuItem.ShowDropDown();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Add_Reg_Click(object sender, EventArgs e)
        {
            new F_Uchets().ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
