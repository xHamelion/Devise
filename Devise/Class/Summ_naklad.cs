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

        public int Summ(string Name_Table, string Name_ID, int ID_Where)
        {
            ms.Open();
            com = new SqlCommand($"select * from {Name_Table} where({Name_ID} = '{ID_Where}')", ms);
            SqlDataReader sd = com.ExecuteReader();
            int sum = 0;
            while (sd.Read())
            {
                sum += Convert.ToInt32(sd[@"Summa"]);
            }
            sd.Close();
            ms.Close();

            return sum;
        }
    }
}