using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSQL
    {
        public readonly string ConnectionString;
        public ConnectionToSQL()
        {
            //ConnectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=DANGNHAP;Integrated Security=True";
            ConnectionString = "Server=(localdb)\\ProjectsV13;DataBase=DOAN;integrated security=True";
        }
        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}