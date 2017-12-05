﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lpcorp_metier;
using Npgsql;
namespace RH_Donnees
{
    public class DAOClient
    {
        private Connection connexion;
        public DAOClient(string adresse, string login, string password, string bddName)
        {
            this.connexion = new Connection(login, password, adresse, bddName);
        }
        public void AjouterClient(Client unClient)
        {
            try
            {
                NpgsqlConnection conn = this.connexion.GetConnexion();
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO res_partner (id, name, street, zip, city, phone, fax, email, active) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, false);";
                cmd.Parameters.AddWithValue("p1", unClient.Id);
                cmd.Parameters.AddWithValue("p2", unClient.RaisonSociale);
                cmd.Parameters.AddWithValue("p3", unClient.Adresse);
                cmd.Parameters.AddWithValue("p4", unClient.Cp);
                cmd.Parameters.AddWithValue("p5", unClient.Ville);
                cmd.Parameters.AddWithValue("p6", unClient.Tel);
                cmd.Parameters.AddWithValue("p7", unClient.Fax);
                cmd.Parameters.AddWithValue("p8", unClient.Email);
                //cmd.Parameters.AddWithValue("p9", unClient.Actif);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }


        public void AjouterDesClients(List<Client> lstClients)
        {
            string commande1 = "INSERT INTO res_partner (name, street, zip, city, phone, fax, email, active) VALUES ";
            string commande2 = "";
            for (int i = 0; i < lstClients.Count; i++)
            {



                commande1 += "(" + "'"+lstClients[i].RaisonSociale + "'"+ ", " +  "'" +lstClients[i].Adresse + "'" + ", " + "'" + lstClients[i].Cp + "'" + ", "+
                            "'" + lstClients[i].Ville + "'" + ", " + "'" + lstClients[i].Tel + "'" + ", " + "'" + lstClients[i].Fax + "'" + ", " + "'" + lstClients[i].Email + "'" + ", " + lstClients[i].Actif + ")";


                if (i < lstClients.Count - 1)
                {
                    commande1 += ",";
                }

            }
            commande1 += ";";
            commande1 += "UPDATE res_partner SET name = null WHERE name = ''; UPDATE res_partner SET street = null WHERE street = ''; UPDATE res_partner SET zip = null WHERE zip = ''; UPDATE res_partner SET city = null WHERE city = ''; UPDATE res_partner SET phone = null WHERE phone = ''; UPDATE res_partner SET fax = null WHERE fax = ''; UPDATE res_partner SET email = null WHERE email = ''; ";
            for (int i = 0; i < lstClients.Count; i++)
            {

                commande2 += "INSERT INTO account_payment_term (name) SELECT ('" + lstClients[i].Reglement + "') WHERE NOT EXISTS (SELECT 1 FROM account_payment_term WHERE name = '" + lstClients[i].Reglement + "');";

            }
            
            commande2 += "UPDATE account_payment_term SET name = null WHERE name = 'null';";

            try
            {
                NpgsqlConnection conn = this.connexion.GetConnexion();
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = commande1;

                cmd.ExecuteNonQuery();

                cmd.CommandText = commande2;

                cmd.ExecuteNonQuery();


                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}


