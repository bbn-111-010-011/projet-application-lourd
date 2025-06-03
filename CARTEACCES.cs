using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_SECURITE
{
    public partial class CARTEACCES : Form
    {
        Form frm_principal = new PRINCIPAL();

        public CARTEACCES()
        {
            InitializeComponent();
        }

        private void CARTEACCES_Load(object sender, EventArgs e)
        {
            // afficher les variables gloable au label 1 
            LABELNOM.Text = donnee_public.pub_nom;
            LABELDROIT.Text = donnee_public.pub_droit;
            // affecter la photo 
            string chemin = donnee_public.pub_chemin;

            Bitmap recup_img = new Bitmap(chemin);

            pctr_Agnt.Image = recup_img;

            pctr_Agnt.SizeMode = PictureBoxSizeMode.StretchImage;
            pctr_Agnt.Visible = true;

        }

        private void btn_Lncerappli_Click(object sender, EventArgs e)
        {
            frm_principal.Show();

        }

        private void btn_Qter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctr_Agnt_Click(object sender, EventArgs e)
        {

        }
    }
}
