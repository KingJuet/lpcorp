﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace ConnectToSQLServer
{
    public class Connection
    {

        public static NpgsqlConnection Connect(string adresse, string userId, string password, string name)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server="+ adresse + ";User Id="+ userId + ";" +
                                "Password="+ password + ";Database="+ name +";");

            return conn;
        }

        public static void TestConnection(string adresse, string userId, string password, string name)
        {
            NpgsqlConnection conn = Connect("localhost", "julien", "zone51@", "lpcorp");
            conn.Open();
            // Define a query
            NpgsqlCommand cmd = new NpgsqlCommand("select city from cities", conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            // Read all rows and output the first column in each row
            while (dr.Read())
                Console.Write("{0}\n", dr[0]);

            // Close connection
            conn.Close();
        }

    }
}