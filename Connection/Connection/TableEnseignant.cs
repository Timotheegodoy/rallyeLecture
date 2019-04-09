using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using métier;
using MySql.Data.MySqlClient;
using System.Data;

namespace Connection
{
    public class TableEnseignant
    {
        private MySqlConnection cnx;
        public TableEnseignant(string u, string p, string db, string h)
        {
            ConnectionMysql cn = new ConnectionMysql(u, p, db, h);
            cnx = cn.GetConnection;
        }
        public Enseignant GetByLogin(string login)
        {
            Enseignant enseignant;
            cnx.Open();
            MySqlCommand cmdSql = new MySqlCommand();
            cmdSql.Connection = cnx;
            cmdSql.CommandText = "select * from enseignant where login=@login";
            cmdSql.CommandType = CommandType.Text;
            cmdSql.Parameters.Add("login", MySqlDbType.String);
            cmdSql.Parameters["login"].Direction = ParameterDirection.Input;
            cmdSql.Parameters["login"].Value = login;
            MySqlDataReader reader = cmdSql.ExecuteReader();
            enseignant = new Enseignant(Convert.ToInt32(reader[0]), (string)reader[1], (string)reader[2], (string)reader[3], (string)reader[4]);
            this.cnx.Close();
            return enseignant;
        }
    }
}
