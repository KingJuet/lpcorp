using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lpcorp_metier;
using Npgsql;
namespace RH_Donnees
{
    public static class DAOClient
    {
        public static void AjouterClient(Client unClient)
        {
            try
            {
                NpgsqlConnection conn = Connection.Connexion("localhost", "julien", "zone51@", "lpcorp");
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
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
