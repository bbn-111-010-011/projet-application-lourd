using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//ouverture bibliotheque regex
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace GESTION_SECURITE
{
    public partial class Gestion_Agents : Form
    {
        public Gestion_Agents()
        {
            InitializeComponent();
        }

        private void Gestion_Agents_Load(object sender, EventArgs e)
        {
            lst_Phto.Visible = false;
            pctrbx_Phto.Visible = false;
            pctrbx_recherche.Visible = false;
            btn_mz.Visible = false;

        }

        private void btn_Enrgstr_Click(object sender, EventArgs e)
        {
            // DECLA REGEX
            var numero = new Regex(@"[0-9]+");
            var maj = new Regex(@"[A-Z]+");
            var carspe = new Regex(@"[*:/:.]+");



            if (PSEUDO.Text != " " && Verification.Text != "" && MDP.Text != "")

                //test regex

                //NUMERO
                if (!numero.IsMatch(MDP.Text))
                {

                    MessageBox.Show("vous n'avez pas saisie de chiffres dans votre mdp ", "Gestion  mdp");
                    MDP.Clear();
                    Verification.Clear();
                }

                //MAJUSCULE

                else if (!maj.IsMatch(MDP.Text))
                {
                    MessageBox.Show("vous n'avez pas saisie de MAJ dans votre mdp ", "Gestion  mdp");
                    MDP.Clear();
                    Verification.Clear();
                }

                // symbole
                else if (!carspe.IsMatch(MDP.Text))
                {
                    MessageBox.Show("vous n'avez pas saisie de SYMBOLE dans votre mdp ", "Gestion  mdp");
                   MDP.Clear();
                    Verification.Clear();
                }


                // TEST SI LES 2MDP CORRECT

                else if (MDP.Text == Verification.Text)
                {

                    //  connexion a la table
                    MySqlConnection connexion1 = new MySqlConnection("database=securite; server=localhost; user id=root; mdp=");

                    try
                    {

                       MessageBox.Show(" LANCEMENT DE LA REQUETE ", " INSERTION AGENTS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // ouvertrure base 
                        connexion1.Open();
                        //AFFECTATION VARIABLEE-
                        string log = PSEUDO.Text;
                        string mdp = MDP.Text;
                        string niv = HABILATATION.Text;
                        string verf = Verification.Text;
                        string chemin = donnee_public.pub_chemin; 

                        // forcer le // dans la bdd chemin

                        chemin = chemin.Replace("\\", "\\\\");

                        // MISE EN FORM%E DE LA REQUETE

                        MySqlCommand insertion = new MySqlCommand(" INSERT  INTO agents VALUES (NULL, '" + log + "','" + mdp + "','" + niv + "','" + chemin + "')", connexion1);

                        //EXECUTION DE LA REQUETE 
                        insertion.ExecuteNonQuery();

                       
                        // message reussi 
                        MessageBox.Show(" ENREGISTREMENT AJOUTER AVEC SUCEES", "INSERTION TABLE AGENTS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // fermeture base 
                        connexion1.Close();

                        MDP.Clear();
                        Verification.Clear();
                        PSEUDO.Clear();
                        HABILATATION.Clear();
                    }


                    catch

                    {
                        MessageBox.Show(" MDP IDENTIQUE ", "Gestion mdp");
                    }
                     
                }


                else

                {
                    MessageBox.Show(" Les 2 mdp ne sont pas identique", "Gestion mdp identique ");
                    MDP.Clear();
                   Verification.Clear();

                }


            else
            {
                MessageBox.Show(" VOOUS DEVEZ REMPLIR TOUT LES CHAMP ", " Gestion champ vide ");
                MDP.Clear();
                Verification.Clear();
            }
        }

        private void btn_Qter_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_Phto_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog recherchedossier;
                recherchedossier = new System.Windows.Forms.FolderBrowserDialog();

            recherchedossier.Description = " selection du dossier photo ";

            recherchedossier.SelectedPath = "D:\\gestion securite\\GESTION SECURITE\\GESTION SECURITE\\Resources";

            //affichage + recuperer la variable 

            DialogResult choix = recherchedossier.ShowDialog();

            //

            if (choix==DialogResult.OK)
            {
                //
                lst_Phto.Visible = true;
                donnee_public.pub_dossier = recherchedossier.SelectedPath;
                //
                lst_Phto.Items.Clear();

                //

                foreach(string fichiers in System.IO.Directory.GetFiles(donnee_public.pub_dossier))
                {
                    //extraction nom fichier
                    string nom = System.IO.Path.GetFileName(fichiers);

                    // remplizsssafge de la lstbox deas nom
                    lst_Phto.Items.Add(nom); 

                    // selection de la premiere  image voulu 
                    if(lst_Phto.Items.Count>0)
                    {
                        lst_Phto.SelectedIndex = 0;

                    }

                }
            }

            // aff photo = pctr photo


        }

        private void lst_Phto_SelectedIndexChanged(object sender, EventArgs e)
        {
                 //afficher la picture box 
                  pctrbx_Phto.Visible = true;

            try
            {
                //affectation du chemin complet de l'image 
                donnee_public.pub_chemin = donnee_public.pub_dossier + "\\" + lst_Phto.SelectedItem;

                // remplissage de la pctrbx
                pctrbx_Phto.Image = Image.FromFile(donnee_public.pub_chemin);
                pctrbx_Phto.SizeMode = PictureBoxSizeMode.StretchImage;

            }



            catch
            {
                pctrbx_Phto.Image = null;


            }


        }

        private void btn_Rchr_Click(object sender, EventArgs e)
        {

            // afffichzge bouton mz
            btn_mz.Visible = true;

            // masquer btn enrgdtr
            btn_Enrgstr.Visible = false;


            //  connexion a la table
            MySqlConnection connexion = new MySqlConnection("database=securite; server=localhost; user id=root; mdp=");
             connexion.Open();

              //memo de la requette de recherche
             MySqlCommand cmd = new MySqlCommand("select * from agents where nom_agents= '" + PSEUDO.Text + "' " , connexion);

            //execution de la requete
            MySqlDataReader recherche = cmd.ExecuteReader();


             // test si il a trouver l'enregistrement 
              if (recherche.HasRows)
              {

                //test si il  a vtroouver l"enregistrement 
                recherche.Read();

                //affectation des champs dans ^les zones de texte
                PSEUDO.Text = recherche.GetValue(1).ToString();
                MDP.Text = recherche.GetValue(2).ToString();
                Verification.Text = recherche.GetValue(2).ToString();
              
                HABILATATION.Text = recherche.GetValue(3).ToString();

               //affectation du chhemin de l'image de la table agents 
                string chemin = recherche.GetValue(4).ToString();
                if (chemin != "")
                {
                    //declaration format image
                    Bitmap recup_img = new Bitmap(chemin);
                    //mise e place de l'image dans picturebox
                    pctrbx_recherche.Image = recup_img;
                    //format d'affichage 
                    pctrbx_recherche.SizeMode = PictureBoxSizeMode.StretchImage;
                    //afichage de l'image
                    pctrbx_recherche.Visible = true;

                }
                //fermeture
                connexion.Close();


              }
            else
            {
                MessageBox.Show("collaborateur  non trouvé ","zone de recherche", MessageBoxButtons.OK,MessageBoxIcon.Error);
                pctrbx_recherche.Visible = false;
                PSEUDO.Clear();
                MDP.Clear();
                Verification.Clear();
                HABILATATION.Clear();
                //fermeture
                connexion.Close();

            }


        }

        private void btn_suprsn_Click(object sender, EventArgs e)
        {
            MySqlConnection connexion = new MySqlConnection("database=securite; server=localhost; user id=root; mdp=");
            try
            {
                 connexion.Open();
                //suppresion de l'enregistrement trouvé
                MySqlCommand supr = new MySqlCommand(" DELETE FROM AGENTS WHERE nom_agents= '"+PSEUDO.Text+"'",connexion);
                //

                MySqlDataReader suppresion = supr.ExecuteReader();

                // AVERTIR DE LA SUPPRSION DE LAGENT
                MessageBox.Show("LE COLLABORATEUR   : " +PSEUDO.Text+ " a ete supprimer de la base ", "SUPPRESION BASE ",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //fermeture 
                connexion.Close();

                //mise a blanc de l'affichage CLEAR
                MDP.Clear();
                Verification.Clear();
                PSEUDO.Clear();
                HABILATATION.Clear();
                //
                pctrbx_recherche.Visible = false;
                //
                btn_suprsn.Visible = true;
                btn_mz.Visible = false;
                btn_Enrgstr.Visible = true;
                //
                PSEUDO.Enabled = true;






            }

            catch
            {

                MessageBox.Show("BASE NON TROUVER ");



            }


        }

        private void pctrbx_recherche_Click(object sender, EventArgs e)
        {

        }
    }
}
