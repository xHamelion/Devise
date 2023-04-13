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
    public partial class F_Sost_J_Vibit : Form
    {
        public F_Sost_J_Vibit()
        {
            InitializeComponent();
        }
        public int ID=0;
        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        int position = 0;
        private void F_Sost_J_Vibit_Load(object sender, EventArgs e)
        {
            switch (Holder.level)
            {
                case 0:
                    break;
                case 1:
                    button1.Enabled = false;
                    break;
                case 2:
                    
                    break;
            }
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_Sklad". При необходимости она может быть перемещена или удалена.
            this.view_SkladTableAdapter.Fill(this.deviseDataSet.View_Sklad);
            this.hranim_Sost_J_VibitTableAdapter.Fill(this.deviseDataSet.Hranim_Sost_J_Vibit, ID);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            position = hranimSostJVibitBindingSource.Position;
            ms.Open();
            com = new SqlCommand($"insert into Sostav_Partii  SELECT * FROM Sostav_Vibitie_Naklad where(ID_Naklad_Prodag = '{dataGridView1.CurrentRow.Cells[0].Value}'" +
                $"and ID_Tovar = '{dataGridView1.CurrentRow.Cells[1].Value}' ) ",ms);

            com.ExecuteNonQuery();

            new Peresh_Sklad(dataGridView2);

            com = new SqlCommand($"delete Sostav_Vibitie_Naklad where(ID_Naklad_Prodag = '{dataGridView1.CurrentRow.Cells[0].Value}'" +
                $"and ID_Tovar = '{dataGridView1.CurrentRow.Cells[1].Value}' ) ",ms);
            com.ExecuteNonQuery();

            hranimSostJVibitBindingSource.Position = position;
            ms.Close();
        }

        private void btn_spravka_Click(object sender, EventArgs e)
        {
            new Spravka();
        }

        private void opisanieRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
