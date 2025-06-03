using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace GESTION_SECURITE
{
    public partial class CLIENT : Form
    {
        public CLIENT()
        {
            InitializeComponent();
        }

        private void CLIENT_Load(object sender, EventArgs e)
        {

        }

        private void btn_engstr_Click(object sender, EventArgs e)
        {

          if (NOM.Text != "" &&PRENOM.Text != "" &&NUM.Text !="") 
           {


           
            // transfrmer en chiffre 
            int tel_cli = int.Parse(NUM.Text);

            // transformer le cmbx foyer en chiffre

            int nb_foyercli = int.Parse(donnee_public.pub_foyer);

            //variable
            string user = NOM.Text;
            string prenom = PRENOM.Text;
            string num = NUM.Text;
            string adr = ADDRESSE.Text;
            string adress = ADRESSESECOND.Text;
            string mail = MAIL.Text;
            string ville = VILLE.Text;
            string foyer = FOYER.Text;


            MySqlConnection ajt_cli = new MySqlConnection("database=securite; server=localhost; user id=root; mdp=");
            try
            {

                // message reussi 
                MessageBox.Show(" LANCEMENT DE LA REQUETE", "INSERTION  CLIENTS ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //ouverture de la base 
                ajt_cli.Open();

                MySqlCommand inserrtion_cli = new MySqlCommand(" INSERT  INTO CLIENTS VALUES (NULL, '" + NOM + "','" + PRENOM+ "','" + tel_cli + "','" + MAIL + "','" + adress + "','" + ADDRESSE + "','" + ADRESSESECOND + "','" + "Marseille" +  "')", ajt_cli);



                //EXEC DE LA REQUETE 
                inserrtion_cli.ExecuteNonQuery();



                // message reussi 
                MessageBox.Show(" ENREGISTREMENT AJOUTER AVEC SUCEES", "INSERTION TABLE CLIENTS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //fermeture 
                ajt_cli.Close();

                //mise a blanc de l'affichage CLEAR
               

            }

            catch
            {

                MessageBox.Show("BASE NON TROUVER" , "ERREUR" , MessageBoxButtons.OK ,MessageBoxIcon.Error);



            }

          }


        }

        private void btn_qter_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void cmbbx_foyer_SelectedIndexChanged(object sender, EventArgs e)
        {


            donnee_public.pub_foyer = cmbbx_foyer.Text;


        }
    }
}
