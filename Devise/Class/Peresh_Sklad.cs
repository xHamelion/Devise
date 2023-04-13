using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Devise
{
    class Peresh_Sklad
    {
        /// <summary>
        /// Строка подключения
        /// </summary>
        SqlConnection ms = new Connection().Sql();

        /// <summary>
        /// Команды
        /// </summary>
        SqlCommand com;
        public Peresh_Sklad(DataGridView dataGridView)
        {
            ms.Open();
            for (int i = 0; i < dataGridView.RowCount - 1; i++)
            {
                com = new SqlCommand($"select * from [View_Sostav_Partii] where " +
                    $"(ID_Tovar = '{dataGridView.Rows[i].Cells[1].Value}')", ms);
                SqlDataReader sq = com.ExecuteReader();
                int koll = 0;
                int sred_Sum = 0;
                while (sq.Read())
                {

                    sred_Sum += Convert.ToInt32(sq[10]);
                    koll += (int)sq[8];
                }
                sred_Sum = sred_Sum / koll;
                sq.Close();
                com = new SqlCommand($"update Sklad set Koll = '{koll}', Sredn_Zena ='{sred_Sum}' " +
                    $"where(ID_Tovar = '{dataGridView.Rows[i].Cells[1].Value}')", ms);
                com.ExecuteNonQuery();


            }


            ms.Close();
        }
    }
}
