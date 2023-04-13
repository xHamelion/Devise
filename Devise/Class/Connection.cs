using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Devise
{
    public class Connection
    {
        public SqlConnection Sql()
        {
            SqlConnection ms = new SqlConnection(@"Data Source=DESKTOP-J96IBMI;Initial Catalog=Devise;Integrated Security=True");

            return ms;
        }

    }
}
