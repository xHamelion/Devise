using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Devise
{
    public class Pereshet_Jurnala_prodag
    {
         SqlConnection ms = new Connection().Sql();
        SqlCommand com;
        public Pereshet_Jurnala_prodag(DataGridView dataGridView1)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                double summ = 0;
                ms.Open();
                com = new SqlCommand($"select (Summa) from[Sostav_Vibitie_Naklad] where(ID_Naklad_Prodag  = '{dataGridView1[1,i].Value}')", ms);
                SqlDataReader sd = com.ExecuteReader();
                while (sd.Read())
                {
                    summ += Convert.ToDouble(sd[0].ToString());

                }

                ms.Close();
                ms.Open();
                com = new SqlCommand($"update J_Vibit set Summa = '{summ.ToString().Replace(',','.')}', Summa_Obh = '{(summ + Convert.ToDouble(dataGridView1[9,i].Value)).ToString().Replace(',', '.')}'  where(ID_Naklad_Prodag  = '{dataGridView1[1,i].Value}')", ms);
                com.ExecuteNonQuery();
                ms.Close();
            }

        }
    }
}
