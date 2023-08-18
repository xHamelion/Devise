using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devise
{
    public class PereshetZakaza
    {
        SqlCommand com = new SqlCommand();
        SqlConnection ms = new Connection().Sql();
        public PereshetZakaza()
        {
            List<int> id_Nakl_Prod = new List<int>();
            ms.Open();
            com = new SqlCommand($"select (ID_Naklad_Prodag) from Naklad_Prodag", ms);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                id_Nakl_Prod.Add((int)sdr[0]);
            }
            ms.Close();
            com = new SqlCommand($"select (ID_Naklad_Prodag) from ID_Naklad_Prodag", ms);
            //List<string> sostav = new List<string>();
            double summ = 0;
            foreach (int item in id_Nakl_Prod)
            {
                ms.Open();
                com = new SqlCommand($"select (Summa) from Sost_Naklad_Prodag where(ID_Naklad_Prodag = '{item}')", ms);
                sdr = com.ExecuteReader();
                while (sdr.Read())
                {
                    summ += Convert.ToDouble(sdr[0]);
                }
                ms.Close();
                ms.Open();
                com = new SqlCommand($"update Naklad_Prodag set Summa = '{summ.ToString().Replace(',', '.')}'" +
                    $"where(ID_Naklad_Prodag = '{item}')", ms);
                com.ExecuteNonQuery();

                ms.Close();
                summ = 0;
            }



        }
    }
}
