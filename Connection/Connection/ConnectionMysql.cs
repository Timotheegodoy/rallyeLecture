using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Connection
{
    public class ConnectionMysql
    {
        private string user;
        private string passWord;
        private string database;
        private string server;
        private MySqlConnection mySqlConnection;

        public ConnectionMysql(string user, string passWord, string database, string server)
        {
            this.user = user;
            this.passWord = passWord;
            this.database = database;
            this.server = server;
        }

        public MySqlConnection GetConnection
        {
            get
            {
                string sCnx = String.Format("server={0};user={1};database={2};password={3}", this.server, this.user, this.database, this.passWord);
                mySqlConnection = new MySqlConnection(sCnx);
                return mySqlConnection;
            }
        }
    }
}
