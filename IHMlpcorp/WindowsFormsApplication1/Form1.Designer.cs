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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Liste_lst = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Parcourir
            // 
            this.btn_Parcourir.Location = new System.Drawing.Point(12, 12);
            this.btn_Parcourir.Name = "btn_Parcourir";
            this.btn_Parcourir.Size = new System.Drawing.Size(121, 23);
            this.btn_Parcourir.TabIndex = 0;
            this.btn_Parcourir.Text = "Sélectionner un fichier";
            this.btn_Parcourir.UseVisualStyleBackColor = true;
            this.btn_Parcourir.Click += new System.EventHandler(this.btn_Parcourir_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(12, 189);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajouter.TabIndex = 1;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            // 
            // btn_Transferer
            // 
            this.btn_Transferer.Location = new System.Drawing.Point(174, 189);
            this.btn_Transferer.Name = "btn_Transferer";
            this.btn_Transferer.Size = new System.Drawing.Size(75, 23);
            this.btn_Transferer.TabIndex = 2;
            this.btn_Transferer.Text = "Transférer";
            this.btn_Transferer.UseVisualStyleBackColor = true;
            // 
            // txt_parcourir
            // 
            this.txt_parcourir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_parcourir.Enabled = false;
            this.txt_parcourir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_parcourir.Location = new System.Drawing.Point(12, 41);
            this.txt_parcourir.Name = "txt_parcourir";
            this.txt_parcourir.ReadOnly = true;
            this.txt_parcourir.Size = new System.Drawing.Size(576, 21);
            this.txt_parcourir.TabIndex = 3;
            this.txt_parcourir.Text = "Le chemin du fichier va s\'afficher ici";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Supprimer.Location = new System.Drawing.Point(93, 189);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_Supprimer.TabIndex = 5;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adresse du serveur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom de la base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Utilisateur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mot de passe";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 163);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(118, 163);
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '●';
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 14;
            // 
            // Liste_lst
            // 
            this.Liste_lst.FormattingEnabled = true;
            this.Liste_lst.Location = new System.Drawing.Point(259, 72);
            this.Liste_lst.Name = "Liste_lst";
            this.Liste_lst.ScrollAlwaysVisible = true;
            this.Liste_lst.Size = new System.Drawing.Size(330, 147);
            this.Liste_lst.TabIndex = 15;
            // 
            // LPCORP_Frm
            // 
            this.AcceptButton = this.btn_Ajouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Supprimer;
            this.ClientSize = new System.Drawing.Size(590, 220);
            this.Controls.Add(this.Liste_lst);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ListBox Liste_lst;
    }
}

