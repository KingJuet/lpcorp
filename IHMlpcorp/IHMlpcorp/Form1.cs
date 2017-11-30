using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RH_Donnees;
using Metier_Manager;
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
         

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void txt_file1_Click(object sender, EventArgs e)
        {
            string fileLink = "";
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "XLS Files| *.xls";
            file.RestoreDirectory = true;
        }

        private void text_file1_TextChanged(object sender, EventArgs e)
        {

            // CsvReader reader = new CsvReader(new string[] { "CODE", "RAISON SOCIALE", "ADRESSE", "CP", "VILLE", "TEL", "FAX", "EMAIL", "ACTIF", "REGLEMENT" });
            //reader.LoadFile("F:\\Julien Rull\\Cours\\PPE\\Negomat_Client2.csv");

            //Connection.AjoutDansBase(reader.Read());
            ClientManager cm = new ClientManager("F:\\Julien Rull\\Cours\\PPE\\Negomat_Client2.csv");
            bool res = cm.PushToDataBase();
            Console.WriteLine(res.ToString());



        }
    }
}
