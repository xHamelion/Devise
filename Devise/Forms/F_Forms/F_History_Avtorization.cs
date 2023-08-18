using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devise.Forms
{
    public partial class F_History_Avtorization : Form
    {
        SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        public F_History_Avtorization()
        {
            InitializeComponent();
        }

        private void F_History_Avtorization_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deviseDataSet.View_History". При необходимости она может быть перемещена или удалена.
            this.view_HistoryTableAdapter.Fill(this.deviseDataSet.View_History);
            this.Icon = Properties.Resources.изображение_2022_06_18_131740798__1_;

        }
        int position;

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                position = viewHistoryBindingSource.Position;
                DialogResult dr = MessageBox.Show("Желаете удалить?", $"Удаление", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    ms.Open();
                    com = new SqlCommand($"delete from [History] " +
                        $"where(ID_History = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}')", ms);
                    try
                    {
                        com.ExecuteNonQuery();

                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Невозможно удалить! Имеються связанные данные!");
                    }
                    ms.Close();
                    this.view_HistoryTableAdapter.Fill(this.deviseDataSet.View_History);

                    viewHistoryBindingSource.Position = position;
                }
            }
        }
    }
}
