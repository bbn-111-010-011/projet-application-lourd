
namespace GESTION_SECURITE
{
    partial class GET_AGENT
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
            this.lbl_Psdo = new System.Windows.Forms.Label();
            this.lbl_Mdp = new System.Windows.Forms.Label();
            this.lbl_Vrfmdp = new System.Windows.Forms.Label();
            this.btn_enrgst = new System.Windows.Forms.Button();
            this.btn_qter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Psdo
            // 
            this.lbl_Psdo.AutoSize = true;
            this.lbl_Psdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Psdo.Location = new System.Drawing.Point(59, 82);
            this.lbl_Psdo.Name = "lbl_Psdo";
            this.lbl_Psdo.Size = new System.Drawing.Size(94, 24);
            this.lbl_Psdo.TabIndex = 0;
            this.lbl_Psdo.Text = "PSEUDO";
            // 
            // lbl_Mdp
            // 
            this.lbl_Mdp.AutoSize = true;
            this.lbl_Mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mdp.Location = new System.Drawing.Point(59, 239);
            this.lbl_Mdp.Name = "lbl_Mdp";
            this.lbl_Mdp.Size = new System.Drawing.Size(54, 24);
            this.lbl_Mdp.TabIndex = 1;
            this.lbl_Mdp.Text = "MDP";
            // 
            // lbl_Vrfmdp
            // 
            this.lbl_Vrfmdp.AutoSize = true;
            this.lbl_Vrfmdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vrfmdp.Location = new System.Drawing.Point(59, 381);
            this.lbl_Vrfmdp.Name = "lbl_Vrfmdp";
            this.lbl_Vrfmdp.Size = new System.Drawing.Size(126, 24);
            this.lbl_Vrfmdp.TabIndex = 2;
            this.lbl_Vrfmdp.Text = "VERIF MDP ";
            // 
            // btn_enrgst
            // 
            this.btn_enrgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enrgst.Location = new System.Drawing.Point(842, 143);
            this.btn_enrgst.Name = "btn_enrgst";
            this.btn_enrgst.Size = new System.Drawing.Size(76, 41);
            this.btn_enrgst.TabIndex = 3;
            this.btn_enrgst.Text = "enregistrer";
            this.btn_enrgst.UseVisualStyleBackColor = true;
            this.btn_enrgst.Click += new System.EventHandler(this.btn_enrgst_Click);
            // 
            // btn_qter
            // 
            this.btn_qter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qter.Location = new System.Drawing.Point(842, 422);
            this.btn_qter.Name = "btn_qter";
            this.btn_qter.Size = new System.Drawing.Size(97, 40);
            this.btn_qter.TabIndex = 4;
            this.btn_qter.Text = "quitter";
            this.btn_qter.UseVisualStyleBackColor = true;
            // 
            // GET_AGENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 630);
            this.Controls.Add(this.btn_qter);
            this.Controls.Add(this.btn_enrgst);
            this.Controls.Add(this.lbl_Vrfmdp);
            this.Controls.Add(this.lbl_Mdp);
            this.Controls.Add(this.lbl_Psdo);
            this.Name = "GET_AGENT";
            this.Text = "GET_AGENT";
            this.Load += new System.EventHandler(this.GET_AGENT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Psdo;
        private System.Windows.Forms.Label lbl_Mdp;
        private System.Windows.Forms.Label lbl_Vrfmdp;
        private System.Windows.Forms.Button btn_enrgst;
        private System.Windows.Forms.Button btn_qter;
    }
}