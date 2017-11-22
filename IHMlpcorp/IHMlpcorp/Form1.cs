﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectToSQLServer;

namespace IHMlpcorp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonParcourir1_Click(object sender, EventArgs e)
        {

        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            //Connection.TestConnection();
            CsvReader reader = new CsvReader(new string[] { "CODE", "RAISON SOCIALE", "ADRESSE", "CP", "VILLE", "TEL", "FAX", "EMAIL", "ACTIF", "REGLEMENT" });
            reader.LoadFile("F:\\Julien Rull\\Cours\\PPE\\Negomat_Client2.csv");
            reader.Read();
            foreach(string s in reader.GetData()["CODE"])
            {
                Console.WriteLine(s);
            }
        }
    }
}
