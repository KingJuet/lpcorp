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
            this.SuspendLayout();
            // 
            // btn_Parcourir
            // 
            this.btn_Parcourir.Location = new System.Drawing.Point(13, 13);
            this.btn_Parcourir.Name = "btn_Parcourir";
            this.btn_Parcourir.Size = new System.Drawing.Size(75, 23);
            this.btn_Parcourir.TabIndex = 0;
            this.btn_Parcourir.Text = "Parcourir";
            this.btn_Parcourir.UseVisualStyleBackColor = true;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(13, 143);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajouter.TabIndex = 1;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            // 
            // btn_Transferer
            // 
            this.btn_Transferer.Location = new System.Drawing.Point(197, 143);
            this.btn_Transferer.Name = "btn_Transferer";
            this.btn_Transferer.Size = new System.Drawing.Size(75, 23);
            this.btn_Transferer.TabIndex = 2;
            this.btn_Transferer.Text = "Transférer";
            this.btn_Transferer.UseVisualStyleBackColor = true;
            this.btn_Transferer.Click += new System.EventHandler(this.btn_Transferer_Click);
            // 
            // LPCORP_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_Transferer);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Parcourir);
            this.Name = "LPCORP_Frm";
            this.Text = "Forme LPCORP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Parcourir;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Transferer;
    }
}

