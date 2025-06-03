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
    public partial class Form1 : Form
    {

        Form frm_accces= new CARTEACCES();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PASS.UseSystemPasswordChar = true;

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            // declaration des variables 

            string co = LOG.Text;
            string mdp = PASS.Text;
            MySqlConnection connexion = new MySqlConnection("database=securite; server=localhost; user id=root; mdp=");

            try
            {
            //MessageBox.Show(" super connexion a ma base ok !! " , "MESSAGE DE CONEXION " , MessageBoxButtons.OK , MessageBoxIcon.Information);
                connexion.Open();
              

                MySqlCommand cmd = new MySqlCommand("select * from agents where nom_agents= '" + co + "' AND mdpass = '" + mdp + "' ", connexion);

                // execution de la requete que l'on va memoriser 
                MySqlDataReader recherche_agent = cmd.ExecuteReader();

                // si l'agent est trouvé 
                if(recherche_agent.HasRows)
                {
                    MessageBox.Show(" SUPER " +co+ " , vous etes bien autorisé a utiliser cette application ", " MESSAGE CONNECTON ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                    // leecture de l'enregistrement trouvé

                    recherche_agent.Read();


                    // affectation des données de l'agents

                    string nom_ag = recherche_agent.GetValue(1).ToString();
                    string droit_ag = recherche_agent.GetValue(3).ToString();
                    string chemin_ag = recherche_agent.GetValue(4).ToString();



                    // 

                    MessageBox.Show(nom_ag);
                    MessageBox.Show(droit_ag);
                   

                    // affectation des donnes public 
                    donnee_public.pub_nom = nom_ag;
                    donnee_public.pub_droit = droit_ag;
                    donnee_public.pub_chemin = chemin_ag;

                   

                    // fermeture
                    connexion.Close();


                    // afficghage carte d'acces 
                    frm_accces.Show();

                    /// caher le formulaire 
                   


                  

                }
                else
                {
                    MessageBox.Show(co+  " vous n'etes pas autorisé a utiliser cette application ", " MESSAGE CONNECTON ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    connexion.Close();

                }


            }

            catch
            {
               //MessageBox.Show(" ATENTION CONEXION NON REUSSIS ");

            }


            
        }

        private void aff_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (aff_pass.Checked)
            {
                PASS.UseSystemPasswordChar = false;

            }
            else
            {
                PASS.UseSystemPasswordChar = true;
            }
        }

        private void PASS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
