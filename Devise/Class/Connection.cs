using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Devise
{
    public class Connection
    {
        public SqlConnection Sql()
        {
            SqlConnection ms = new SqlConnection( ConfigurationManager.ConnectionStrings["Devise.Properties.Settings.DeviseConnectionString"].ConnectionString);

            return ms;
        }

    }
}
