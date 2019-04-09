namespace Nouvelle_Classe
{
    partial class FormNouvelleClasse
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
            this.lblRepertoire = new System.Windows.Forms.Label();
            this.ClbIntegrer = new System.Windows.Forms.CheckedListBox();
            this.LblFichier = new System.Windows.Forms.Label();
            this.TbAnnee = new System.Windows.Forms.TextBox();
            this.ckbAleatoire = new System.Windows.Forms.CheckBox();
            this.ckbConstruit = new System.Windows.Forms.CheckBox();
            this.LblAnnee = new System.Windows.Forms.Label();
            this.LblNiveau = new System.Windows.Forms.Label();
            this.LblMdp = new System.Windows.Forms.Label();
            this.BtnIntegrer = new System.Windows.Forms.Button();
            this.FbdCsv = new System.Windows.Forms.FolderBrowserDialog();
            this.LbNiveau = new System.Windows.Forms.ListBox();
            this.CbRepertoire = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblRepertoire
            // 
            this.lblRepertoire.AutoSize = true;
            this.lblRepertoire.Location = new System.Drawing.Point(14, 37);
            this.lblRepertoire.Name = "lblRepertoire";
            this.lblRepertoire.Size = new System.Drawing.Size(118, 13);
            this.lblRepertoire.TabIndex = 1;
            this.lblRepertoire.Text = "Repertoire des fichiers :";
            // 
            // ClbIntegrer
            // 
            this.ClbIntegrer.FormattingEnabled = true;
            this.ClbIntegrer.Location = new System.Drawing.Point(138, 61);
            this.ClbIntegrer.Name = "ClbIntegrer";
            this.ClbIntegrer.Size = new System.Drawing.Size(202, 64);
            this.ClbIntegrer.TabIndex = 2;
            // 
            // LblFichier
            // 
            this.LblFichier.AutoSize = true;
            this.LblFichier.Location = new System.Drawing.Point(14, 61);
            this.LblFichier.Name = "LblFichier";
            this.LblFichier.Size = new System.Drawing.Size(111, 13);
            this.LblFichier.TabIndex = 3;
            this.LblFichier.Text = "Fichier csv à intégrer :";
            // 
            // TbAnnee
            // 
            this.TbAnnee.Location = new System.Drawing.Point(138, 131);
            this.TbAnnee.Name = "TbAnnee";
            this.TbAnnee.Size = new System.Drawing.Size(103, 20);
            this.TbAnnee.TabIndex = 4;
            // 
            // ckbAleatoire
            // 
            this.ckbAleatoire.AutoSize = true;
            this.ckbAleatoire.Location = new System.Drawing.Point(125, 240);
            this.ckbAleatoire.Name = "ckbAleatoire";
            this.ckbAleatoire.Size = new System.Drawing.Size(66, 17);
            this.ckbAleatoire.TabIndex = 6;
            this.ckbAleatoire.Text = "aleatoire";
            this.ckbAleatoire.UseVisualStyleBackColor = true;
            // 
            // ckbConstruit
            // 
            this.ckbConstruit.AutoSize = true;
            this.ckbConstruit.Location = new System.Drawing.Point(230, 240);
            this.ckbConstruit.Name = "ckbConstruit";
            this.ckbConstruit.Size = new System.Drawing.Size(66, 17);
            this.ckbConstruit.TabIndex = 7;
            this.ckbConstruit.Text = "construit";
            this.ckbConstruit.UseVisualStyleBackColor = true;
            // 
            // LblAnnee
            // 
            this.LblAnnee.AutoSize = true;
            this.LblAnnee.Location = new System.Drawing.Point(14, 134);
            this.LblAnnee.Name = "LblAnnee";
            this.LblAnnee.Size = new System.Drawing.Size(82, 13);
            this.LblAnnee.TabIndex = 8;
            this.LblAnnee.Text = "année scolaire :";
            // 
            // LblNiveau
            // 
            this.LblNiveau.AutoSize = true;
            this.LblNiveau.Location = new System.Drawing.Point(14, 165);
            this.LblNiveau.Name = "LblNiveau";
            this.LblNiveau.Size = new System.Drawing.Size(45, 13);
            this.LblNiveau.TabIndex = 9;
            this.LblNiveau.Text = "niveau :";
            // 
            // LblMdp
            // 
            this.LblMdp.AutoSize = true;
            this.LblMdp.Location = new System.Drawing.Point(14, 241);
            this.LblMdp.Name = "LblMdp";
            this.LblMdp.Size = new System.Drawing.Size(77, 13);
            this.LblMdp.TabIndex = 10;
            this.LblMdp.Text = "mot de Passe :";
            // 
            // BtnIntegrer
            // 
            this.BtnIntegrer.Location = new System.Drawing.Point(138, 279);
            this.BtnIntegrer.Name = "BtnIntegrer";
            this.BtnIntegrer.Size = new System.Drawing.Size(130, 25);
            this.BtnIntegrer.TabIndex = 11;
            this.BtnIntegrer.Text = "Lancer l\'intégration";
            this.BtnIntegrer.UseVisualStyleBackColor = true;
            this.BtnIntegrer.Click += new System.EventHandler(this.BtnIntegrer_Click);
            // 
            // LbNiveau
            // 
            this.LbNiveau.FormattingEnabled = true;
            this.LbNiveau.Location = new System.Drawing.Point(138, 159);
            this.LbNiveau.Name = "LbNiveau";
            this.LbNiveau.Size = new System.Drawing.Size(208, 69);
            this.LbNiveau.TabIndex = 12;
            // 
            // CbRepertoire
            // 
            this.CbRepertoire.FormattingEnabled = true;
            this.CbRepertoire.Location = new System.Drawing.Point(141, 29);
            this.CbRepertoire.Name = "CbRepertoire";
            this.CbRepertoire.Size = new System.Drawing.Size(199, 21);
            this.CbRepertoire.TabIndex = 14;
            // 
            // FormNouvelleClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 350);
            this.Controls.Add(this.CbRepertoire);
            this.Controls.Add(this.LbNiveau);
            this.Controls.Add(this.BtnIntegrer);
            this.Controls.Add(this.LblMdp);
            this.Controls.Add(this.LblNiveau);
            this.Controls.Add(this.LblAnnee);
            this.Controls.Add(this.ckbConstruit);
            this.Controls.Add(this.ckbAleatoire);
            this.Controls.Add(this.TbAnnee);
            this.Controls.Add(this.LblFichier);
            this.Controls.Add(this.ClbIntegrer);
            this.Controls.Add(this.lblRepertoire);
            this.Name = "FormNouvelleClasse";
            this.Text = " Nouvelle Classe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepertoire;
        private System.Windows.Forms.CheckedListBox ClbIntegrer;
        private System.Windows.Forms.Label LblFichier;
        private System.Windows.Forms.TextBox TbAnnee;
        private System.Windows.Forms.CheckBox ckbAleatoire;
        private System.Windows.Forms.CheckBox ckbConstruit;
        private System.Windows.Forms.Label LblAnnee;
        private System.Windows.Forms.Label LblNiveau;
        private System.Windows.Forms.Label LblMdp;
        private System.Windows.Forms.Button BtnIntegrer;
        private System.Windows.Forms.FolderBrowserDialog FbdCsv;
        private System.Windows.Forms.ListBox LbNiveau;
        private System.Windows.Forms.ComboBox CbRepertoire;
    }
}

