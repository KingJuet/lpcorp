using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lpcorp_metier;
using Npgsql;
namespace RH_Donnees
{
    /// <summary>
    /// Classe : Pour exécuter les requetes concerant l'insertion des clients dans la base de données
    /// </summary>
    public class DAOClient
    {
        private Connection connexion;
        public DAOClient(string adresse, string unPort, string login, string password, string bddName)
        {
            this.connexion = new Connection(login, password, adresse, unPort, bddName);
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
                cmd.Parameters.AddWithValue("p9", unClient.Actif);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        /// <summary>
        /// Insert la liste de clients dans la base de données 
        /// </summary>
        /// <param name="lstClients">Liste des clients</param>
        public void AjouterDesClients(List<Client> lstClients)
        {
            string commande1 = "INSERT INTO res_partner (name, street, zip, city, phone, fax, email, active) VALUES ";
            // Insertion dans la table res_partner
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

            // Insertion dans la table account_payment_term
            for (int i = 0; i < lstClients.Count; i++)
            {

                commande1 += "INSERT INTO account_payment_term (name) SELECT ('" + lstClients[i].Reglement + "') WHERE NOT EXISTS (SELECT 1 FROM account_payment_term WHERE name = '" + lstClients[i].Reglement + "');";

            }
            
            commande1 += "UPDATE account_payment_term SET name = null WHERE name = 'null';";

            // Insertion dans la table account_invoice
            for (int i = 0; i < lstClients.Count; i++)
            {

                commande1 += "INSERT INTO account_invoice (partner_id, payment_term_id) SELECT (SELECT id FROM res_partner WHERE name = '" + lstClients[i].RaisonSociale + "' AND phone = '" + lstClients[i].Tel + "' LIMIT 1), (SELECT id FROM account_payment_term WHERE name = '" + lstClients[i].Reglement + "' LIMIT 1);";

            }
            try
            {
                NpgsqlConnection conn = this.connexion.GetConnexion(); // Etablir la connexion
                conn.Open(); // Ouvrir la connexion

                NpgsqlCommand cmd = new NpgsqlCommand(); // Instanciation d'une commande
                cmd.Connection = conn; // Liée la connexion à la commande
                cmd.CommandText = commande1; // Donnée le text de commande 

                cmd.ExecuteNonQuery(); //Exécuter la commande 




                conn.Close(); //Fermer la commande
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}


