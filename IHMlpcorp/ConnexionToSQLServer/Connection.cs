using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace RH_Donnees
{
    public class Connection
    {

        private string login;
        private string password;
        private string adresse;
        private string bddName;

        public Connection(string unLogin, string unPassword, string uneAdresse, string unNom)
        {
            this.login = unLogin;
            this.password = unPassword;
            this.adresse = uneAdresse;
            this.bddName = unNom;
        }

        public static NpgsqlConnection Connexion(string adresse, string userId, string password, string name)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server="+ adresse + ";User Id="+ userId + ";" +
                                "Password="+ password + ";Database="+ name +";");
            return conn;
        }


     

        public static void TestConnection()
        {
            NpgsqlConnection conn = Connexion("localhost", "julien", "zone51@", "lpcorp");
            conn.Open();
            // Define a query
            NpgsqlCommand cmd = new NpgsqlCommand("select name from res_partner", conn);
            
            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            // Read all rows and output the first column in each row
            while (dr.Read())
                Console.Write("{0}\n", dr[0]);

            // Close connection
            conn.Close();
        }

        public static void AjoutDansBase()
        {
            NpgsqlConnection conn = Connexion("localhost", "julien", "zone51@", "lpcorp");
            conn.Open();
            // Define a query
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO res_partner (id, city) VALUES (2, @p);";
            cmd.Parameters.AddWithValue("p", "test");
            // Execute a query


            cmd.ExecuteNonQuery();
            //foreach(string s in data["VILLE"]){
            //cmd = new NpgsqlCommand("INSERT INTO res_partner (city) VALUES ("+s+");", conn);
            //cmd.ExecuteNonQuery();
            // }
            conn.Close();
        }

    }
}
