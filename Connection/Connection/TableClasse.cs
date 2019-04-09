using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using métier;
using System.Data;

namespace Connection
{
    public class TableClasse
    {
        private long lastId;
        private MySqlConnection cnx;
        public TableClasse(string u, string p, string db, string h)
        {
            ConnectionMysql cn = new ConnectionMysql(u, p, db, h);
            cnx = cn.GetConnection;
        }
        public long insert(Classe Classe)
        {
            long id;
            cnx.Open();
            MySqlCommand cmdSql = new MySqlCommand();
            cmdSql.Connection = cnx;
            cmdSql.CommandText = "insert into classe(idEnseignant,anneeScolaire,idNiveau) values(@idEnseignant,@annee,@idNiveau)";
            cmdSql.CommandType = CommandType.Text;
            cmdSql.Parameters.Add("@idEnseignant", MySqlDbType.Int32);
            cmdSql.Parameters["@idEnseignant"].Value = Classe.Getid;
            cmdSql.Parameters.Add("@annee", MySqlDbType.String);
            cmdSql.Parameters["@annee"].Value = Classe.GetAnneeScolaire;
            cmdSql.Parameters.Add("@idNiveau", MySqlDbType.Int32);
            cmdSql.Parameters["@idNiveau"].Value = Classe.GetNiveau;
            cmdSql.ExecuteNonQuery();
            id = cmdSql.LastInsertedId;
            cnx.Close();
            lastId = id;
            cnx.Close();
            // on récupère l'id
            return id;
        }

        public long LastId
        {
            get { return lastId; }
        }
    }
}
