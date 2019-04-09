using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using métier;
using MySql.Data.MySqlClient;
using System.Data;

namespace Connection
{
    public class TableEleve
    {
        private MySqlConnection cnx;
        private string u;
        private string db;
        private string h;
        private string p;
        public TableEleve(string u, string p, string db, string h)
        {
            this.u = u;
            this.p = p;
            this.db = db;
            this.h = h;
            ConnectionMysql cn = new ConnectionMysql(u, p, db, h);
            cnx = cn.GetConnection;
        }

        //Permet de créer un élève dans la table élève
        public void Insert(Eleve eleve, long idClasse)
        {
            //récupère l'id de la classe



            //récupère l'id du aauth_users
            MySqlCommand cmd1 = new MySqlCommand();
            cmd1.Connection = cnx;
            cnx.Open();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select max(id) from aauth_users";
            int idAauth = Convert.ToInt32(cmd1.ExecuteScalar());
            cnx.Close();

            Hash pass = new Hash();


            //créer un utilisateur dans la table aauth_users
            MySqlCommand cmd2 = new MySqlCommand();
            cmd2.Connection = cnx;
            cnx.Open();
            cmd2.CommandText = "insert into aauth_users(email,pass,username) values(@email,@passWord,@username) ";
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.Add("@email", MySqlDbType.String);
            cmd2.Parameters["@email"].Value = eleve.GetLogin;
            cmd2.Parameters.Add("@username", MySqlDbType.String);
            cmd2.Parameters["@username"].Value = eleve.GetPrenom[0] + eleve.Getnom;
            cmd2.Parameters.Add("@passWord", MySqlDbType.String);
            cmd2.Parameters["@passWord"].Value = pass.GetHashPassword(eleve.GetPassword, idAauth + 1);
            cmd2.ExecuteNonQuery();
            cnx.Close();

            MySqlCommand cmd4 = new MySqlCommand();
            cmd4.Connection = cnx;
            cnx.Open();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "insert into aauth_user_to_group(user_id,group_id) values(@idUser,@idGroup)";
            cmd4.Parameters.Add("@idUser", MySqlDbType.Int32);
            cmd4.Parameters["@idUser"].Value = idAauth + 1;
            cmd4.Parameters.Add("@idGroup", MySqlDbType.Int32);
            cmd4.Parameters["@idGroup"].Value = 4;
            cmd4.ExecuteNonQuery();
            cnx.Close();

            TableClasse uneTableClasse = new TableClasse(this.u,this.p,this.db,this.h);
            idClasse = uneTableClasse.LastId;

            //créer un élève dans la table élève
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            cnx.Open();
            cmd.CommandText = "insert into eleve(idClasse,nom,prenom,login,idAuth) values(@idClasse,@nom,@prenom,@login,@idAuth)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idClasse", MySqlDbType.Int32);
            cmd.Parameters["@idClasse"].Value = idClasse;
            cmd.Parameters.Add("@nom", MySqlDbType.String);
            cmd.Parameters["@nom"].Value = eleve.Getnom;
            cmd.Parameters.Add("@prenom", MySqlDbType.String);
            cmd.Parameters["@prenom"].Value = eleve.GetPrenom;
            cmd.Parameters.Add("@login", MySqlDbType.String);
            cmd.Parameters["@login"].Value = eleve.GetLogin;
            cmd.Parameters.Add("@idAuth", MySqlDbType.Int32);
            cmd.Parameters["@idAuth"].Value = idAauth + 1;
            seleccmd.ExecuteNonQuery();
            cnx.Close();

        }
    }
}
