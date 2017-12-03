﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier_Manager;
using System.Web;
using System.Net.Mail;

namespace lpcorp_IHM
{
    public partial class LPCORP_Frm : Form
    {
        string fileLink;
        public LPCORP_Frm()
        {
            InitializeComponent();
        }

        private void btn_Parcourir_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "xls";
            openFile.Filter = "Fichier MapInfoFormat (*.csv)|*.csv";
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
                fileLink = openFile.FileName;
            txt_parcourir.Text = fileLink;
        }

        private void ProgBar_prgbar_Click(object sender, EventArgs e)
        {
        }

        private void txt_AdresseServeur_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Port_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_NomBase_TextChanged(object sender, EventArgs e)
        {
                   
        }

        private void txt_Utilisateur_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Mdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_parcourir_TextChanged(object sender, EventArgs e)
        {

        }



        private void btn_Transferer_Click(object sender, EventArgs e)
        {
            ClientManager cm = new ClientManager(txt_parcourir.Text);
            cm.PushToDataBase();
            Console.WriteLine(cm.GetRapport());
            txt_rapport.Text = cm.GetRapport();
        }

        private void btn_DemRapport_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage("", txt_AdresseServeur.Text, "Rapport d'importation", txt_rapport.Text);
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("", "");
            client.EnableSsl = true;
            client.Send(mail);
        }
    }
}
