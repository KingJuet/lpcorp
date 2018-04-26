using System;
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
using RH_Donnees;
using System.IO;
using Npgsql;

namespace lpcorp_IHM

{
    public partial class LPCORP_Frm : Form
    {
        string fileLink;
        ErrorProvider erreurIcone;
        ClientManager cm;
        public LPCORP_Frm()
        {
            InitializeComponent();
            erreurIcone = new ErrorProvider();
            cm = null;
        }

        private void btn_Parcourir_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "csv";
            openFile.Filter = "Fichier MapInfoFormat (*.csv)|*.csv";
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
                fileLink = openFile.FileName;
            txt_parcourir.Text = fileLink;
            erreurIcone.Clear();
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
            if(txt_Mdp.Text != "" && txt_NomBase.Text != ""  && txt_AdresseServeur.Text != ""  && txt_Utilisateur.Text != "")
            {
                lbl_erreur.Text = "";
                try
                {
                    try
                    {
                        DAOClient newConnexion = new DAOClient(txt_AdresseServeur.Text, txt_Port.Text, txt_Utilisateur.Text, txt_Mdp.Text, txt_NomBase.Text);
                        this.cm = new ClientManager(txt_parcourir.Text, newConnexion);
                        this.cm.PushToDataBase();
                        txt_rapport.Text = this.cm.GetRapport();
                        txt_Mdp.Enabled = false;
                        txt_NomBase.Enabled = false;
                        txt_Port.Enabled = false;
                        txt_AdresseServeur.Enabled = false;
                        txt_MailRapport.Enabled = true;
                        txt_Utilisateur.Enabled = false;
                        btn_Ajouter.Enabled = true;
                        btn_Transferer.Enabled = false;
                        btn_Supprimer.Enabled = false;
                        btn_DemRapport.Enabled = true;
                    }
                    catch(NpgsqlException ex) {
                        MessageBox.Show("Identifiants de la BDD incorrect", "ERREUR", MessageBoxButtons.OK);
                    }
                    
                    
                }
                catch (Exception ex)
                {
                    erreurIcone.SetError(txt_parcourir, "Aucun fichier n'a été selectionné !");
                }

            }
            else
            {
                lbl_erreur.Text = "Certains champs n'ont pas été renseigné !";
            }
          

        }

        private void btn_DemRapport_Click(object sender, EventArgs e)
        {
            try
            {

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("pièceJointe.txt");

                //Write a line of text
                sw.Write(txt_rapport.Text);

                //Close the file
                sw.Close();
            }
            catch (Exception exep)
            {
                Console.WriteLine("Exception: " + exep.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            try
            {
                erreurIcone.Clear();
                MailMessage mail = new MailMessage("testLpCorp@gmail.com", txt_MailRapport.Text, "Rapport d'importation", "Rapport d'importation en pièce jointe !");
                mail.Attachments.Add(new Attachment("pièceJointe.txt"));
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("testLpCorp@gmail.com", "jone51@12");
                client.EnableSsl = true;
                client.Send(mail);
            }
            catch (Exception exep)
            {
                erreurIcone.SetError(txt_MailRapport, "Le mail est invalid !");
            }

            //File.Delete("pièceJointe.txt");
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            txt_Mdp.Enabled = true;
            txt_NomBase.Enabled = true;
            txt_Port.Enabled = true;
            txt_AdresseServeur.Enabled = true;
            txt_MailRapport.Enabled = true;
            txt_Utilisateur.Enabled = true;
            btn_Ajouter.Enabled = false;
            btn_Transferer.Enabled = true;
            btn_Supprimer.Enabled = true;
            
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            txt_Mdp.Text = "";
            txt_NomBase.Text = "";
            txt_Port.Text = "";
            txt_AdresseServeur.Text = "";
            txt_MailRapport.Text = "";
            txt_Utilisateur.Text = "";
        }

        private void LPCORP_Frm_Load(object sender, EventArgs e)
        {
            txt_rapport.SelectionStart = txt_rapport.Text.Length;
            txt_rapport.ScrollToCaret();
        }
    }
}
