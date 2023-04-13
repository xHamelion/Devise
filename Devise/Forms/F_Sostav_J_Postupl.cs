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
    public partial class F_Sostav_J_Postupl : Form
    {

        public int ID;

        public F_Sostav_J_Postupl()
        {
            InitializeComponent();
        }

        private void F_Sostav_J_Postupl_Load(object sender, EventArgs e)
        {
             
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            this.view_Sostav_Postupl_NaklaTableAdapter.Fill(this.deviseDataSet.View_Sostav_Postupl_Nakla, ID);
        }

        private void btn_spravka_Click(object sender, EventArgs e)
        {
            new Spravka();
        }
    }
}
