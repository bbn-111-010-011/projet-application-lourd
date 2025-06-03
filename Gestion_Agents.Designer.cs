
namespace GESTION_SECURITE
{
    partial class Gestion_Agents
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
            this.lbl_Usrnm = new System.Windows.Forms.Label();
            this.lbl_Mdp = new System.Windows.Forms.Label();
            this.lbl_VrfMdp = new System.Windows.Forms.Label();
            this.PSEUDO = new System.Windows.Forms.TextBox();
            this.MDP = new System.Windows.Forms.TextBox();
            this.Verification = new System.Windows.Forms.TextBox();
            this.btn_Enrgstr = new System.Windows.Forms.Button();
            this.btn_Qter = new System.Windows.Forms.Button();
            this.lbl_nv = new System.Windows.Forms.Label();
            this.HABILATATION = new System.Windows.Forms.TextBox();
            this.btn_Phto = new System.Windows.Forms.Button();
            this.lst_Phto = new System.Windows.Forms.ListBox();
            this.pctrbx_Phto = new System.Windows.Forms.PictureBox();
            this.btn_Rchr = new System.Windows.Forms.Button();
            this.btn_mz = new System.Windows.Forms.Button();
            this.pctrbx_recherche = new System.Windows.Forms.PictureBox();
            this.btn_suprsn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_Phto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_recherche)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Usrnm
            // 
            this.lbl_Usrnm.AutoSize = true;
            this.lbl_Usrnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usrnm.Location = new System.Drawing.Point(23, 28);
            this.lbl_Usrnm.Name = "lbl_Usrnm";
            this.lbl_Usrnm.Size = new System.Drawing.Size(109, 20);
            this.lbl_Usrnm.TabIndex = 0;
            this.lbl_Usrnm.Text = "USERNAME";
            // 
            // lbl_Mdp
            // 
            this.lbl_Mdp.AutoSize = true;
            this.lbl_Mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mdp.Location = new System.Drawing.Point(23, 87);
            this.lbl_Mdp.Name = "lbl_Mdp";
            this.lbl_Mdp.Size = new System.Drawing.Size(121, 20);
            this.lbl_Mdp.TabIndex = 1;
            this.lbl_Mdp.Text = "Mot De Passe";
            // 
            // lbl_VrfMdp
            // 
            this.lbl_VrfMdp.AutoSize = true;
            this.lbl_VrfMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VrfMdp.Location = new System.Drawing.Point(23, 144);
            this.lbl_VrfMdp.Name = "lbl_VrfMdp";
            this.lbl_VrfMdp.Size = new System.Drawing.Size(177, 20);
            this.lbl_VrfMdp.TabIndex = 2;
            this.lbl_VrfMdp.Text = "VERIFICATION MDP";
            // 
            // PSEUDO
            // 
            this.PSEUDO.Location = new System.Drawing.Point(263, 28);
            this.PSEUDO.Name = "PSEUDO";
            this.PSEUDO.Size = new System.Drawing.Size(100, 20);
            this.PSEUDO.TabIndex = 3;
            // 
            // MDP
            // 
            this.MDP.Location = new System.Drawing.Point(263, 89);
            this.MDP.Name = "MDP";
            this.MDP.PasswordChar = '*';
            this.MDP.Size = new System.Drawing.Size(100, 20);
            this.MDP.TabIndex = 4;
            // 
            // Verification
            // 
            this.Verification.Location = new System.Drawing.Point(263, 144);
            this.Verification.Name = "Verification";
            this.Verification.PasswordChar = '*';
            this.Verification.Size = new System.Drawing.Size(100, 20);
            this.Verification.TabIndex = 5;
            // 
            // btn_Enrgstr
            // 
            this.btn_Enrgstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enrgstr.Location = new System.Drawing.Point(812, 41);
            this.btn_Enrgstr.Name = "btn_Enrgstr";
            this.btn_Enrgstr.Size = new System.Drawing.Size(147, 30);
            this.btn_Enrgstr.TabIndex = 6;
            this.btn_Enrgstr.Text = "ENREGISTRER";
            this.btn_Enrgstr.UseVisualStyleBackColor = true;
            this.btn_Enrgstr.Click += new System.EventHandler(this.btn_Enrgstr_Click);
            // 
            // btn_Qter
            // 
            this.btn_Qter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Qter.Location = new System.Drawing.Point(812, 614);
            this.btn_Qter.Name = "btn_Qter";
            this.btn_Qter.Size = new System.Drawing.Size(147, 25);
            this.btn_Qter.TabIndex = 7;
            this.btn_Qter.Text = "QUITTER";
            this.btn_Qter.UseVisualStyleBackColor = true;
            this.btn_Qter.Click += new System.EventHandler(this.btn_Qter_Click);
            // 
            // lbl_nv
            // 
            this.lbl_nv.AutoSize = true;
            this.lbl_nv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nv.Location = new System.Drawing.Point(23, 213);
            this.lbl_nv.Name = "lbl_nv";
            this.lbl_nv.Size = new System.Drawing.Size(203, 20);
            this.lbl_nv.TabIndex = 8;
            this.lbl_nv.Text = "NIVEAU HABILITATION";
            // 
            // HABILATATION
            // 
            this.HABILATATION.Location = new System.Drawing.Point(263, 215);
            this.HABILATATION.MaxLength = 1;
            this.HABILATATION.Name = "HABILATATION";
            this.HABILATATION.Size = new System.Drawing.Size(100, 20);
            this.HABILATATION.TabIndex = 9;
            // 
            // btn_Phto
            // 
            this.btn_Phto.Location = new System.Drawing.Point(462, 162);
            this.btn_Phto.Name = "btn_Phto";
            this.btn_Phto.Size = new System.Drawing.Size(274, 50);
            this.btn_Phto.TabIndex = 10;
            this.btn_Phto.Text = "PHOTO";
            this.btn_Phto.UseVisualStyleBackColor = true;
            this.btn_Phto.Click += new System.EventHandler(this.btn_Phto_Click);
            // 
            // lst_Phto
            // 
            this.lst_Phto.FormattingEnabled = true;
            this.lst_Phto.Location = new System.Drawing.Point(12, 264);
            this.lst_Phto.Name = "lst_Phto";
            this.lst_Phto.Size = new System.Drawing.Size(240, 212);
            this.lst_Phto.TabIndex = 11;
            this.lst_Phto.SelectedIndexChanged += new System.EventHandler(this.lst_Phto_SelectedIndexChanged);
            // 
            // pctrbx_Phto
            // 
            this.pctrbx_Phto.Location = new System.Drawing.Point(286, 264);
            this.pctrbx_Phto.Name = "pctrbx_Phto";
            this.pctrbx_Phto.Size = new System.Drawing.Size(263, 212);
            this.pctrbx_Phto.TabIndex = 12;
            this.pctrbx_Phto.TabStop = false;
            // 
            // btn_Rchr
            // 
            this.btn_Rchr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rchr.Location = new System.Drawing.Point(27, 560);
            this.btn_Rchr.Name = "btn_Rchr";
            this.btn_Rchr.Size = new System.Drawing.Size(155, 26);
            this.btn_Rchr.TabIndex = 13;
            this.btn_Rchr.Text = "RECHERCHER";
            this.btn_Rchr.UseVisualStyleBackColor = true;
            this.btn_Rchr.Click += new System.EventHandler(this.btn_Rchr_Click);
            // 
            // btn_mz
            // 
            this.btn_mz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mz.Location = new System.Drawing.Point(286, 560);
            this.btn_mz.Name = "btn_mz";
            this.btn_mz.Size = new System.Drawing.Size(174, 26);
            this.btn_mz.TabIndex = 14;
            this.btn_mz.Text = "REMISE A 0";
            this.btn_mz.UseVisualStyleBackColor = true;
            // 
            // pctrbx_recherche
            // 
            this.pctrbx_recherche.Location = new System.Drawing.Point(628, 264);
            this.pctrbx_recherche.Name = "pctrbx_recherche";
            this.pctrbx_recherche.Size = new System.Drawing.Size(252, 212);
            this.pctrbx_recherche.TabIndex = 15;
            this.pctrbx_recherche.TabStop = false;
            this.pctrbx_recherche.Click += new System.EventHandler(this.pctrbx_recherche_Click);
            // 
            // btn_suprsn
            // 
            this.btn_suprsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suprsn.Location = new System.Drawing.Point(628, 560);
            this.btn_suprsn.Name = "btn_suprsn";
            this.btn_suprsn.Size = new System.Drawing.Size(147, 28);
            this.btn_suprsn.TabIndex = 16;
            this.btn_suprsn.Text = "SUPPRESION";
            this.btn_suprsn.UseVisualStyleBackColor = true;
            this.btn_suprsn.Click += new System.EventHandler(this.btn_suprsn_Click);
            // 
            // Gestion_Agents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(991, 651);
            this.Controls.Add(this.btn_suprsn);
            this.Controls.Add(this.pctrbx_recherche);
            this.Controls.Add(this.btn_mz);
            this.Controls.Add(this.btn_Rchr);
            this.Controls.Add(this.pctrbx_Phto);
            this.Controls.Add(this.lst_Phto);
            this.Controls.Add(this.btn_Phto);
            this.Controls.Add(this.HABILATATION);
            this.Controls.Add(this.lbl_nv);
            this.Controls.Add(this.btn_Qter);
            this.Controls.Add(this.btn_Enrgstr);
            this.Controls.Add(this.Verification);
            this.Controls.Add(this.MDP);
            this.Controls.Add(this.PSEUDO);
            this.Controls.Add(this.lbl_VrfMdp);
            this.Controls.Add(this.lbl_Mdp);
            this.Controls.Add(this.lbl_Usrnm);
            this.Name = "Gestion_Agents";
            this.Text = "Gestion_Agents";
            this.Load += new System.EventHandler(this.Gestion_Agents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_Phto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_recherche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Usrnm;
        private System.Windows.Forms.Label lbl_Mdp;
        private System.Windows.Forms.Label lbl_VrfMdp;
        private System.Windows.Forms.TextBox PSEUDO;
        private System.Windows.Forms.TextBox MDP;
        private System.Windows.Forms.TextBox Verification;
        private System.Windows.Forms.Button btn_Enrgstr;
        private System.Windows.Forms.Button btn_Qter;
        private System.Windows.Forms.Label lbl_nv;
        private System.Windows.Forms.TextBox HABILATATION;
        private System.Windows.Forms.Button btn_Phto;
        private System.Windows.Forms.ListBox lst_Phto;
        private System.Windows.Forms.PictureBox pctrbx_Phto;
        private System.Windows.Forms.Button btn_Rchr;
        private System.Windows.Forms.Button btn_mz;
        private System.Windows.Forms.PictureBox pctrbx_recherche;
        private System.Windows.Forms.Button btn_suprsn;
    }
}