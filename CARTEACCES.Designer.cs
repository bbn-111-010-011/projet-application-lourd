namespace GESTION_SECURITE
{
    partial class CARTEACCES
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LABELDROIT = new System.Windows.Forms.Label();
            this.LABELNOM = new System.Windows.Forms.Label();
            this.pctr_Agnt = new System.Windows.Forms.PictureBox();
            this.lbl_Agnt = new System.Windows.Forms.Label();
            this.lbl_Drt = new System.Windows.Forms.Label();
            this.btn_Lncerappli = new System.Windows.Forms.Button();
            this.btn_Qter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Agnt)).BeginInit();
            this.SuspendLayout();
            // 
            // LABELDROIT
            // 
            this.LABELDROIT.AutoSize = true;
            this.LABELDROIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABELDROIT.Location = new System.Drawing.Point(869, 415);
            this.LABELDROIT.Name = "LABELDROIT";
            this.LABELDROIT.Size = new System.Drawing.Size(66, 24);
            this.LABELDROIT.TabIndex = 0;
            this.LABELDROIT.Text = "label1";
            // 
            // LABELNOM
            // 
            this.LABELNOM.AutoSize = true;
            this.LABELNOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABELNOM.Location = new System.Drawing.Point(869, 264);
            this.LABELNOM.Name = "LABELNOM";
            this.LABELNOM.Size = new System.Drawing.Size(66, 24);
            this.LABELNOM.TabIndex = 1;
            this.LABELNOM.Text = "label2";
            // 
            // pctr_Agnt
            // 
            this.pctr_Agnt.Location = new System.Drawing.Point(46, 101);
            this.pctr_Agnt.Name = "pctr_Agnt";
            this.pctr_Agnt.Size = new System.Drawing.Size(548, 480);
            this.pctr_Agnt.TabIndex = 2;
            this.pctr_Agnt.TabStop = false;
            this.pctr_Agnt.Click += new System.EventHandler(this.pctr_Agnt_Click);
            // 
            // lbl_Agnt
            // 
            this.lbl_Agnt.AutoSize = true;
            this.lbl_Agnt.BackColor = System.Drawing.Color.Red;
            this.lbl_Agnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Agnt.ForeColor = System.Drawing.Color.Black;
            this.lbl_Agnt.Location = new System.Drawing.Point(838, 195);
            this.lbl_Agnt.Name = "lbl_Agnt";
            this.lbl_Agnt.Size = new System.Drawing.Size(129, 24);
            this.lbl_Agnt.TabIndex = 3;
            this.lbl_Agnt.Text = "***AGENT***";
            // 
            // lbl_Drt
            // 
            this.lbl_Drt.AutoSize = true;
            this.lbl_Drt.BackColor = System.Drawing.Color.Red;
            this.lbl_Drt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Drt.Location = new System.Drawing.Point(838, 356);
            this.lbl_Drt.Name = "lbl_Drt";
            this.lbl_Drt.Size = new System.Drawing.Size(120, 24);
            this.lbl_Drt.TabIndex = 4;
            this.lbl_Drt.Text = "***DROIT***";
            // 
            // btn_Lncerappli
            // 
            this.btn_Lncerappli.Location = new System.Drawing.Point(729, 21);
            this.btn_Lncerappli.Name = "btn_Lncerappli";
            this.btn_Lncerappli.Size = new System.Drawing.Size(324, 68);
            this.btn_Lncerappli.TabIndex = 5;
            this.btn_Lncerappli.Text = "LANCER APPLICATION";
            this.btn_Lncerappli.UseVisualStyleBackColor = true;
            this.btn_Lncerappli.Click += new System.EventHandler(this.btn_Lncerappli_Click);
            // 
            // btn_Qter
            // 
            this.btn_Qter.Location = new System.Drawing.Point(789, 536);
            this.btn_Qter.Name = "btn_Qter";
            this.btn_Qter.Size = new System.Drawing.Size(195, 71);
            this.btn_Qter.TabIndex = 6;
            this.btn_Qter.Text = "QUITTER";
            this.btn_Qter.UseVisualStyleBackColor = true;
            this.btn_Qter.Click += new System.EventHandler(this.btn_Qter_Click);
            // 
            // CARTEACCES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GESTION_SECURITE.Properties.Resources._18735672_cadenas_numerique_avec_ecran_virtuel_sur_fond_sombre_technologie_de_cybersecurite_et_concept_de_protection_du_reseau_de_donnees_de_confidentialite_vectorie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1095, 670);
            this.Controls.Add(this.btn_Qter);
            this.Controls.Add(this.btn_Lncerappli);
            this.Controls.Add(this.lbl_Drt);
            this.Controls.Add(this.lbl_Agnt);
            this.Controls.Add(this.pctr_Agnt);
            this.Controls.Add(this.LABELNOM);
            this.Controls.Add(this.LABELDROIT);
            this.MaximizeBox = false;
            this.Name = "CARTEACCES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CARTEACCES";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.CARTEACCES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Agnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABELDROIT;
        private System.Windows.Forms.Label LABELNOM;
        private System.Windows.Forms.PictureBox pctr_Agnt;
        private System.Windows.Forms.Label lbl_Agnt;
        private System.Windows.Forms.Label lbl_Drt;
        private System.Windows.Forms.Button btn_Lncerappli;
        private System.Windows.Forms.Button btn_Qter;
    }
}