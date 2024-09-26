using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSale
{
    public class Concet
    {
        public MySqlConnection Connection;
        private string Host;
        private string Database;
        private string User;
        private string Password;
        private string ConnectionString;

        public Concet() 
        { 
            Host = "127.0.0.1";
            Database = "auto";
            User = "root";
            Password = "0";
            ConnectionString = "SERVER=" + Host + ";DATABASE=" + Database + ";UID=" + User + ";PASSWORD=" + Password + ";SslMode=None";
            Connection = new MySqlConnection(ConnectionString);
        }
    }
}
