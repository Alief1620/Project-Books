using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proby
{
    class data
    {
        MySqlConnection connection=new MySqlConnection("server=localhost;port=3306;user=root;password=root;database=autificationone");
        public void openConnection()
        {
            if(connection.State==System.Data.ConnectionState.Closed)
            connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection getConnection()
            { return connection; }
    }
}
