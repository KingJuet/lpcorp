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
        private string port;
        private string bddName;

        public Connection(string unLogin, string unPassword, string uneAdresse, string unPort, string unNom)
        {
            this.login = unLogin;
            this.password = unPassword;
            this.adresse = uneAdresse;
            this.bddName = unNom;
            this.port = unPort;
        }

        public  NpgsqlConnection GetConnexion()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server="+ this.adresse + ";Port="+ this.port + ";User Id="+ this.login + ";" +
                                "Password="+ this.password + ";Database="+ this.bddName +";");
            return conn;
        }
       

    }
}
