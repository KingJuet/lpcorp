namespace lpcorp_IHM
{
    partial class LPCORP_Frm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Parcourir = new System.Windows.Forms.Button();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Transferer = new System.Windows.Forms.Button();
            this.txt_parcourir = new System.Windows.Forms.TextBox();
            this.txt_AdresseServeur = new System.Windows.Forms.TextBox();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.lbl_AdresseServeur = new System.Windows.Forms.Label();
            this.lbl_NomBase = new System.Windows.Forms.Label();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.lbl_Utilisateur = new System.Windows.Forms.Label();
            this.lbl_Mdp = new System.Windows.Forms.Label();
            this.txt_NomBase = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.txt_Utilisateur = new System.Windows.Forms.TextBox();
            this.txt_Mdp = new System.Windows.Forms.TextBox();
            this.ProgBar_prgbar = new System.Windows.Forms.ProgressBar();
            this.lbl_MailRapport = new System.Windows.Forms.Label();
            this.txt_MailRapport = new System.Windows.Forms.TextBox();
            this.btn_DemRapport = new System.Windows.Forms.Button();
            this.txt_rapport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Parcourir
            // 
            this.btn_Parcourir.Location = new System.Drawing.Point(2, 12);
            this.btn_Parcourir.Name = "btn_Parcourir";
            this.btn_Parcourir.Size = new System.Drawing.Size(121, 23);
            this.btn_Parcourir.TabIndex = 0;
            this.btn_Parcourir.Text = "Sélectionner un fichier";
            this.btn_Parcourir.UseVisualStyleBackColor = true;
            this.btn_Parcourir.Click += new System.EventHandler(this.btn_Parcourir_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ajouter.Location = new System.Drawing.Point(2, 189);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajouter.TabIndex = 6;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            // 
            // btn_Transferer
            // 
            this.btn_Transferer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Transferer.Location = new System.Drawing.Point(164, 189);
            this.btn_Transferer.Name = "btn_Transferer";
            this.btn_Transferer.Size = new System.Drawing.Size(75, 23);
            this.btn_Transferer.TabIndex = 8;
            this.btn_Transferer.Text = "Transférer";
            this.btn_Transferer.UseVisualStyleBackColor = true;
            this.btn_Transferer.Click += new System.EventHandler(this.btn_Transferer_Click);
            // 
            // txt_parcourir
            // 
            this.txt_parcourir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_parcourir.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_parcourir.Enabled = false;
            this.txt_parcourir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_parcourir.Location = new System.Drawing.Point(2, 41);
            this.txt_parcourir.Name = "txt_parcourir";
            this.txt_parcourir.ReadOnly = true;
            this.txt_parcourir.Size = new System.Drawing.Size(576, 21);
            this.txt_parcourir.TabIndex = 3;
            this.txt_parcourir.Text = "Le chemin du fichier va s\'afficher ici";
            this.txt_parcourir.TextChanged += new System.EventHandler(this.txt_parcourir_TextChanged);
            // 
            // txt_AdresseServeur
            // 
            this.txt_AdresseServeur.Location = new System.Drawing.Point(2, 85);
            this.txt_AdresseServeur.Name = "txt_AdresseServeur";
            this.txt_AdresseServeur.Size = new System.Drawing.Size(129, 20);
            this.txt_AdresseServeur.TabIndex = 1;
            this.txt_AdresseServeur.TextChanged += new System.EventHandler(this.txt_AdresseServeur_TextChanged);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Supprimer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Supprimer.Location = new System.Drawing.Point(83, 189);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_Supprimer.TabIndex = 7;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            // 
            // lbl_AdresseServeur
            // 
            this.lbl_AdresseServeur.AutoSize = true;
            this.lbl_AdresseServeur.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdresseServeur.Location = new System.Drawing.Point(-1, 65);
            this.lbl_AdresseServeur.Name = "lbl_AdresseServeur";
            this.lbl_AdresseServeur.Size = new System.Drawing.Size(132, 17);
            this.lbl_AdresseServeur.TabIndex = 6;
            this.lbl_AdresseServeur.Text = "Adresse du serveur";
            // 
            // lbl_NomBase
            // 
            this.lbl_NomBase.AutoSize = true;
            this.lbl_NomBase.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_NomBase.Location = new System.Drawing.Point(-1, 108);
            this.lbl_NomBase.Name = "lbl_NomBase";
            this.lbl_NomBase.Size = new System.Drawing.Size(109, 17);
            this.lbl_NomBase.TabIndex = 7;
            this.lbl_NomBase.Text = "Nom de la base";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Port.Location = new System.Drawing.Point(136, 67);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(35, 17);
            this.lbl_Port.TabIndex = 8;
            this.lbl_Port.Text = "Port";
            // 
            // lbl_Utilisateur
            // 
            this.lbl_Utilisateur.AutoSize = true;
            this.lbl_Utilisateur.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Utilisateur.Location = new System.Drawing.Point(-1, 147);
            this.lbl_Utilisateur.Name = "lbl_Utilisateur";
            this.lbl_Utilisateur.Size = new System.Drawing.Size(76, 17);
            this.lbl_Utilisateur.TabIndex = 9;
            this.lbl_Utilisateur.Text = "Utilisateur";
            // 
            // lbl_Mdp
            // 
            this.lbl_Mdp.AutoSize = true;
            this.lbl_Mdp.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Mdp.Location = new System.Drawing.Point(105, 147);
            this.lbl_Mdp.Name = "lbl_Mdp";
            this.lbl_Mdp.Size = new System.Drawing.Size(94, 17);
            this.lbl_Mdp.TabIndex = 10;
            this.lbl_Mdp.Text = "Mot de passe";
            // 
            // txt_NomBase
            // 
            this.txt_NomBase.Location = new System.Drawing.Point(2, 124);
            this.txt_NomBase.Name = "txt_NomBase";
            this.txt_NomBase.Size = new System.Drawing.Size(129, 20);
            this.txt_NomBase.TabIndex = 3;
            this.txt_NomBase.TextChanged += new System.EventHandler(this.txt_NomBase_TextChanged);
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(139, 83);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(32, 20);
            this.txt_Port.TabIndex = 2;
            this.txt_Port.TextChanged += new System.EventHandler(this.txt_Port_TextChanged);
            // 
            // txt_Utilisateur
            // 
            this.txt_Utilisateur.Location = new System.Drawing.Point(2, 163);
            this.txt_Utilisateur.Name = "txt_Utilisateur";
            this.txt_Utilisateur.Size = new System.Drawing.Size(100, 20);
            this.txt_Utilisateur.TabIndex = 4;
            this.txt_Utilisateur.TextChanged += new System.EventHandler(this.txt_Utilisateur_TextChanged);
            // 
            // txt_Mdp
            // 
            this.txt_Mdp.Location = new System.Drawing.Point(108, 163);
            this.txt_Mdp.Name = "txt_Mdp";
            this.txt_Mdp.PasswordChar = '●';
            this.txt_Mdp.Size = new System.Drawing.Size(100, 20);
            this.txt_Mdp.TabIndex = 5;
            this.txt_Mdp.TextChanged += new System.EventHandler(this.txt_Mdp_TextChanged);
            // 
            // ProgBar_prgbar
            // 
            this.ProgBar_prgbar.Location = new System.Drawing.Point(2, 225);
            this.ProgBar_prgbar.Name = "ProgBar_prgbar";
            this.ProgBar_prgbar.Size = new System.Drawing.Size(576, 23);
            this.ProgBar_prgbar.TabIndex = 11;
            this.ProgBar_prgbar.Click += new System.EventHandler(this.ProgBar_prgbar_Click);
            // 
            // lbl_MailRapport
            // 
            this.lbl_MailRapport.AutoSize = true;
            this.lbl_MailRapport.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MailRapport.Location = new System.Drawing.Point(-1, 251);
            this.lbl_MailRapport.Name = "lbl_MailRapport";
            this.lbl_MailRapport.Size = new System.Drawing.Size(103, 17);
            this.lbl_MailRapport.TabIndex = 17;
            this.lbl_MailRapport.Text = "e-mail Rapport";
            // 
            // txt_MailRapport
            // 
            this.txt_MailRapport.Location = new System.Drawing.Point(2, 271);
            this.txt_MailRapport.Name = "txt_MailRapport";
            this.txt_MailRapport.Size = new System.Drawing.Size(156, 20);
            this.txt_MailRapport.TabIndex = 18;
            // 
            // btn_DemRapport
            // 
            this.btn_DemRapport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DemRapport.Location = new System.Drawing.Point(2, 297);
            this.btn_DemRapport.Name = "btn_DemRapport";
            this.btn_DemRapport.Size = new System.Drawing.Size(121, 23);
            this.btn_DemRapport.TabIndex = 19;
            this.btn_DemRapport.Text = "Demander le rapport";
            this.btn_DemRapport.UseVisualStyleBackColor = true;
            this.btn_DemRapport.Click += new System.EventHandler(this.btn_DemRapport_Click);
            // 
            // txt_rapport
            // 
            this.txt_rapport.Location = new System.Drawing.Point(245, 68);
            this.txt_rapport.Multiline = true;
            this.txt_rapport.Name = "txt_rapport";
            this.txt_rapport.ReadOnly = true;
            this.txt_rapport.Size = new System.Drawing.Size(322, 144);
            this.txt_rapport.TabIndex = 20;
            // 
            // LPCORP_Frm
            // 
            this.AcceptButton = this.btn_Ajouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Supprimer;
            this.ClientSize = new System.Drawing.Size(579, 359);
            this.Controls.Add(this.txt_rapport);
            this.Controls.Add(this.btn_DemRapport);
            this.Controls.Add(this.txt_MailRapport);
            this.Controls.Add(this.lbl_MailRapport);
            this.Controls.Add(this.ProgBar_prgbar);
            this.Controls.Add(this.txt_Mdp);
            this.Controls.Add(this.txt_Utilisateur);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_NomBase);
            this.Controls.Add(this.lbl_Mdp);
            this.Controls.Add(this.lbl_Utilisateur);
            this.Controls.Add(this.lbl_Port);
            this.Controls.Add(this.lbl_NomBase);
            this.Controls.Add(this.lbl_AdresseServeur);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.txt_AdresseServeur);
            this.Controls.Add(this.txt_parcourir);
            this.Controls.Add(this.btn_Transferer);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Parcourir);
            this.Name = "LPCORP_Frm";
            this.Text = "LP.CORP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Parcourir;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Transferer;
        private System.Windows.Forms.TextBox txt_parcourir;
        private System.Windows.Forms.TextBox txt_AdresseServeur;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Label lbl_AdresseServeur;
        private System.Windows.Forms.Label lbl_NomBase;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.Label lbl_Utilisateur;
        private System.Windows.Forms.Label lbl_Mdp;
        private System.Windows.Forms.TextBox txt_NomBase;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.TextBox txt_Utilisateur;
        private System.Windows.Forms.TextBox txt_Mdp;
        private System.Windows.Forms.ProgressBar ProgBar_prgbar;
        private System.Windows.Forms.Label lbl_MailRapport;
        private System.Windows.Forms.TextBox txt_MailRapport;
        private System.Windows.Forms.Button btn_DemRapport;
        private System.Windows.Forms.TextBox txt_rapport;
    }
}

