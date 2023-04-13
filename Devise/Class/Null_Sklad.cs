using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Devise
{
    class Null_Sklad
    {

        /// <summary>
        /// Строка подключения
        /// </summary>
        SqlConnection ms = new Connection().Sql();

        /// <summary>
        /// Команды
        /// </summary>
        SqlCommand com;

        public Null_Sklad()
        {
            ms.Open();
            com = new SqlCommand($"delete from Sklad where(Koll<=0)", ms);
            com.ExecuteNonQuery();
            ms.Close();
        }
    }
}
