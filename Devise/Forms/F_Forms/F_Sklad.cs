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
    public partial class F_Sklad : Form
    {
        public F_Sklad()
        {
            InitializeComponent();
            
        }
        int position = 0;
        private void F_Sklad_Load(object sender, EventArgs e)
        {
            switch (Holder.level)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    button2.Enabled = false;
                    button3.Enabled = false;
                    Exel.Enabled = false;
                    PDF.Enabled = false;
                    dataGridView1.Columns[9].Visible = false;
                    dataGridView1.Columns[12].Visible = false;
                    dataGridView1.Columns[11].HeaderText = "Цена";
                    break;
            }
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;

            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_Sklad". При необходимости она может быть перемещена или удалена.
            this.view_SkladTableAdapter.Fill(this.deviseDataSet.View_Sklad);

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[0, i].Value == null)
                    break;
                dataGridView1[11, i].Value = (Convert.ToDouble( dataGridView1[9, i].Value) * ((double)Properties.Settings.Default.Skidka/100.0)).ToString("0.00");
                dataGridView1[12, i].Value = Convert.ToDouble(dataGridView1[9, i].Value).ToString("0.00");


            }

            viewSkladBindingSource.Position = position;

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            position = viewSkladBindingSource.Position;
            new Peresh_Sklad(dataGridView1);
            F_Sklad_Load(null, null);
            viewSkladBindingSource.Position = position;

        }

        public void button2_Click(object sender, EventArgs e)
        {
            position = viewSkladBindingSource.Position;
            new Null_Sklad();
            F_Sklad_Load(null, null);
            viewSkladBindingSource.Position = position;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

 

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                try
                {
                    if (dataGridView1.RowCount != dataGridView1.CurrentRow.Index)
                        textBox1.Text = new Summ_naklad().Summ("Sostav_Partii", "ID_Tovar", (int)dataGridView1.CurrentRow.Cells[1].Value).ToString();
                }
                catch { }
            }
        }

        private void Exel_Click(object sender, EventArgs e)
        {
            new Exel(dataGridView1, "Склад");

        }

        private void PDF_Click(object sender, EventArgs e)
        {
            new PDF(dataGridView1, "Склад");

        }

        private void F_Sklad_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Holder.TestTatus)
                return;
            Application.OpenForms[1].Enabled = true;
            Application.OpenForms[1].Activate();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 1 && Holder.level != 2)
            {
                new Null_Sklad();
                new Peresh_Sklad(dataGridView1);
                var f = new F_Sklad_Postupl();
                f.ID = (int)dataGridView1.CurrentRow.Cells[1].Value;
                f.ShowDialog();
            }
        }

        private void imagePictureBox_Click(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewSkladBindingSource.Filter = $"Tip like '%{CB_Fio_Pok.Text}%' and PodTip like '%{CB_Fio_sotr.Text}%' and Tovar like '%{CB_Nomer.Text}%'";

        }


        private void button1_Click(object sender, EventArgs e)
        {
            viewSkladBindingSource.Filter = "";
            CB_Nomer.Text = "";
            CB_Fio_sotr.Text = "";
            CB_Fio_Pok.Text = "";
        }

        private void btn_spravka_Click(object sender, EventArgs e)
        {
            new Spravka();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void opisanieRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
