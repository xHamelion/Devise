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
    public partial class F_Sklad_Postupl : Form
    {
        public int ID;

        public F_Sklad_Postupl()
        {
            InitializeComponent();
        }

        private void F_Sklad_Postupl_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            switch (Holder.level)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    
                    Exel.Enabled = false;
                    PDF.Enabled = false;
                    break;
            }
            this.hranim_Sostav_Patii_SkladTableAdapter.Fill(this.deviseDataSet.Hranim_Sostav_Patii_Sklad, ID);
        }

        private void Exel_Click(object sender, EventArgs e)
        {
            new Exel(dataGridView1, "Товары по поставкам");

        }

        private void PDF_Click(object sender, EventArgs e)
        {
            new PDF(dataGridView1, "Товары по поставкам");

        }

        private void btn_spravka_Click(object sender, EventArgs e)
        {
            new Spravka();
        }
    }
}
