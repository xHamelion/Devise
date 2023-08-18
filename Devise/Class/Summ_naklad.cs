using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Devise
{
    class Summ_naklad
    {
        /// <summary>
        /// Строка подключения
        /// </summary>
        SqlConnection ms = new Connection().Sql();
        /// <summary>
        /// Команды
        /// </summary>
        SqlCommand com;

        public double Summ(string Name_Table, string Name_ID, int ID_Where)
        {
            ms.Open();
            com = new SqlCommand($"select * from {Name_Table} where({Name_ID} = '{ID_Where}')", ms);
            SqlDataReader sd = com.ExecuteReader();
            double sum = 0;
            while (sd.Read())
            {
                sum += Convert.ToDouble(sd[@"Summa"]);
            }
            sd.Close();
            ms.Close();
            ms.Open();
            com = new SqlCommand($"update J_Vibit set Summa = '{sum.ToString().Replace(',','.')}'  where(ID_Naklad_Prodag = '{ID_Where}')", ms);
            com.ExecuteNonQuery();
            ms.Close();

            return sum;
        }
    }
}