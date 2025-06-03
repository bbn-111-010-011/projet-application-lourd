
namespace GESTION_SECURITE
{
    partial class Form1
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
            this.LOG = new System.Windows.Forms.TextBox();
            this.PASS = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.pictureBoxIdentifiant = new System.Windows.Forms.PictureBox();
            this.pictureBoxMdp = new System.Windows.Forms.PictureBox();
            this.aff_pass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdentifiant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMdp)).BeginInit();
            this.SuspendLayout();
            // 
            // LOG
            // 
            this.LOG.Location = new System.Drawing.Point(334, 216);
            this.LOG.Name = "LOG";
            this.LOG.Size = new System.Drawing.Size(100, 20);
            this.LOG.TabIndex = 0;
            // 
            // PASS
            // 
            this.PASS.Location = new System.Drawing.Point(334, 381);
            this.PASS.Name = "PASS";
            this.PASS.Size = new System.Drawing.Size(100, 20);
            this.PASS.TabIndex = 1;
            this.PASS.TextChanged += new System.EventHandler(this.PASS_TextChanged);
            // 
            // buttonValider
            // 
            this.buttonValider.BackgroundImage = global::GESTION_SECURITE.Properties.Resources.valider;
            this.buttonValider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonValider.Location = new System.Drawing.Point(685, 43);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(146, 94);
            this.buttonValider.TabIndex = 2;
            this.buttonValider.Text = "  ";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.BackgroundImage = global::GESTION_SECURITE.Properties.Resources.exit;
            this.buttonQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonQuitter.Location = new System.Drawing.Point(685, 414);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(146, 104);
            this.buttonQuitter.TabIndex = 3;
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // pictureBoxIdentifiant
            // 
            this.pictureBoxIdentifiant.BackgroundImage = global::GESTION_SECURITE.Properties.Resources.HD_wallpaper_security_concept_digital_art_creative_3d_lock_computer_security_scanning_security;
            this.pictureBoxIdentifiant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxIdentifiant.Location = new System.Drawing.Point(31, 175);
            this.pictureBoxIdentifiant.Name = "pictureBoxIdentifiant";
            this.pictureBoxIdentifiant.Size = new System.Drawing.Size(193, 107);
            this.pictureBoxIdentifiant.TabIndex = 4;
            this.pictureBoxIdentifiant.TabStop = false;
            // 
            // pictureBoxMdp
            // 
            this.pictureBoxMdp.BackgroundImage = global::GESTION_SECURITE.Properties.Resources.clavier;
            this.pictureBoxMdp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMdp.Location = new System.Drawing.Point(31, 323);
            this.pictureBoxMdp.Name = "pictureBoxMdp";
            this.pictureBoxMdp.Size = new System.Drawing.Size(193, 102);
            this.pictureBoxMdp.TabIndex = 5;
            this.pictureBoxMdp.TabStop = false;
            // 
            // aff_pass
            // 
            this.aff_pass.AutoSize = true;
            this.aff_pass.Location = new System.Drawing.Point(332, 485);
            this.aff_pass.Name = "aff_pass";
            this.aff_pass.Size = new System.Drawing.Size(142, 17);
            this.aff_pass.TabIndex = 6;
            this.aff_pass.Text = "Afficher le mot de passe ";
            this.aff_pass.UseVisualStyleBackColor = true;
            this.aff_pass.CheckedChanged += new System.EventHandler(this.aff_pass_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GESTION_SECURITE.Properties.Resources.HACK;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 530);
            this.Controls.Add(this.aff_pass);
            this.Controls.Add(this.pictureBoxMdp);
            this.Controls.Add(this.pictureBoxIdentifiant);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.PASS);
            this.Controls.Add(this.LOG);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdentifiant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMdp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LOG;
        private System.Windows.Forms.TextBox PASS;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.PictureBox pictureBoxIdentifiant;
        private System.Windows.Forms.PictureBox pictureBoxMdp;
        private System.Windows.Forms.CheckBox aff_pass;
    }
}

