using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DatabaseConnection
    {
        protected SqlConnection conn;
        protected void OpenConnection()
        {
            if (conn == null)
            {
                conn = new(GetConnectionString());
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        protected void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
            return config["ConnectionStrings:MyStoreDB"];
        }
    }
}
