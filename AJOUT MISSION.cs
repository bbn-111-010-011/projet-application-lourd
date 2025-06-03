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
    public partial class AJOUT_MISSION : Form
    {
        public AJOUT_MISSION()
        {
            InitializeComponent();

            
        }

        private void Btn_Qter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AJOUT_MISSION_Load(object sender, EventArgs e)
        {
            try
            {
                // === Remplir cmbx_eleve ===
                MySqlConnection conn1 = new MySqlConnection("server=localhost;database=stages;uid=root;pwd=;");
                conn1.Open();
                MySqlCommand cmd1 = new MySqlCommand("SELECT nom_eleve_ FROM eleve", conn1);
                MySqlDataReader r1 = cmd1.ExecuteReader();
                while (r1.Read())
                {
                    cmbx_eleve.Items.Add(r1.GetString(0));
                }
                conn1.Close();

                // === Remplir cmbx_Prf ===
                MySqlConnection conn2 = new MySqlConnection("server=localhost;database=stages;uid=root;pwd=;");
                conn2.Open();
                MySqlCommand cmd2 = new MySqlCommand("SELECT nom_professeur FROM professeur", conn2);
                MySqlDataReader r2 = cmd2.ExecuteReader();
                while (r2.Read())
                {
                    cmbx_Prf.Items.Add(r2.GetString(0));
                }
                conn2.Close();

                // === Remplir cmbx_Tuteur ===
                MySqlConnection conn3 = new MySqlConnection("server=localhost;database=stages;uid=root;pwd=;");
                conn3.Open();
                MySqlCommand cmd3 = new MySqlCommand("SELECT DISTINCT nom_tuteur FROM tuteur", conn3);
                MySqlDataReader r3 = cmd3.ExecuteReader();
                while (r3.Read())
                {
                    cmbx_Tuteur.Items.Add(r3.GetString(0));
                }
                conn3.Close();
            }
            catch
            {
                MessageBox.Show("Erreur lors du chargement des listes.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                MySqlConnection connexion = new MySqlConnection("server=localhost;database=stages;uid=root;pwd=;");
                connexion.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT nom_entreprise FROM stage", connexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbx_Stage.Items.Add(reader.GetString(0));
                }

                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de chargement entreprise : " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Nm_Click(object sender, EventArgs e)
        {

        }

        private void cmbx_eleve_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string nom = cmbx_eleve.Text;
                MySqlConnection connexion = new MySqlConnection("server=localhost;database=stages;uid=root;pwd=;");
                connexion.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM eleve WHERE nom_eleve_ = '" + nom + "'", connexion);
                MySqlDataReader recherche = cmd.ExecuteReader();

                if (recherche.Read())
                {
                    lbl_num_miss.Text = recherche.GetValue(0).ToString();   // numero_eleve
                    lbl_nom_miss.Text = recherche.GetValue(1).ToString();   // nom_eleve_
                    lbl_ville_miss.Text = recherche.GetValue(4).ToString(); // libel_ville
                    lbl_code_miss.Text = recherche.GetValue(6).ToString();  // cde_ville
                    lbl_foyer_miss.Text = recherche.GetValue(11).ToString();// foyer_eleve
                }

                connexion.Close();
            }
            catch
            {
                MessageBox.Show("Erreur lors de la récupération de l'élève sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbx_Prf_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string nom = cmbx_Prf.Text;
                MySqlConnection connexion = new MySqlConnection("server=localhost;database=stages;uid=root;pwd=;");
                connexion.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM professeur WHERE nom_professeur = '" + nom + "'", connexion);
                MySqlDataReader recherche = cmd.ExecuteReader();

                if (recherche.Read())
                {
                    lbl_NUMERO_miss.Text = recherche.GetValue(0).ToString();   // numero_professeur
                    lbl_Nm_miss.Text = recherche.GetValue(1).ToString();       // nom_professeur
                    lbl_Prenom_miss.Text = recherche.GetValue(2).ToString();   // prenom_professeur
                    lbl_TELEPHONE_miss.Text = recherche.GetValue(3).ToString();// telephone_professeur
                    lbl_Cde_miss.Text = recherche.GetValue(4).ToString();      // cde_ville
                }

                connexion.Close();
            }
            catch
            {
                MessageBox.Show("Erreur lors de la récupération du professeur sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grpbx_Elv_Enter(object sender, EventArgs e)
        {

        }

        private void cmbx_Tuteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string nom = cmbx_Tuteur.Text;
                MySqlConnection connexion = new MySqlConnection("server=localhost;database=stages;uid=root;pwd=;");
                connexion.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tuteur WHERE nom_tuteur = '" + nom + "'", connexion);
                MySqlDataReader recherche = cmd.ExecuteReader();

                if (recherche.Read())
                {
                    lbl_Nmttr_miss.Text = recherche.GetValue(1).ToString();   // nom_tuteur
                    lbl_Prnmttr_miss.Text = recherche.GetValue(2).ToString(); // prenom_tuteur
                    lbl_Cdettr_miss.Text = recherche.GetValue(0).ToString();  // code_tuteur
                    lbl_Entrttr_miss.Text = recherche.GetValue(3).ToString(); // nom_entreprise
                    lbl_Pstettr_miss.Text = recherche.GetValue(4).ToString(); // nom_poste
                }

                connexion.Close();
            }
            catch
            {
                MessageBox.Show("Erreur lors de la récupération du tuteur sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void grpbx_Tutr_Enter(object sender, EventArgs e)
        {

        }



        

        private void grpbx_Stage_Enter(object sender, EventArgs e)
        {

        }

        private void cmbx_Stage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string nomEntreprise = cmbx_Stage.Text.Trim();

                using (MySqlConnection connexion = new MySqlConnection("server=localhost;database=stages;uid=root;pwd=;"))
                {
                    connexion.Open();

                    // 1. Lire les infos du stage
                    string queryStage = "SELECT * FROM stage WHERE nom_entreprise = @entreprise LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(queryStage, connexion);
                    cmd.Parameters.AddWithValue("@entreprise", nomEntreprise);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.Read())
                    {
                        MessageBox.Show("Aucun stage trouvé pour cette entreprise.");
                        return;
                    }

                    // === grpbx_Stage ===
                    lbl_StageElv_miss.Text = reader["nom_eleve"].ToString();
                    lbl_StagePrf_miss.Text = reader["nom_professeur"].ToString();
                    lbl_StageTtr_miss.Text = reader["nom_tuteur"].ToString();
                    lbl_StagePst_miss.Text = reader["nom_poste"].ToString();
                    lbl_StageDb_miss.Text = Convert.ToDateTime(reader["date_debut"]).ToShortDateString();
                    lbl_StageFn_miss.Text = Convert.ToDateTime(reader["date_fin"]).ToShortDateString();

                    // On garde les clés pour chercher le prof et tuteur
                    string nomProf = reader["nom_professeur"].ToString();
                    string codeTuteur = reader["code_tuteur"].ToString();

                    reader.Close();

                    // === grpbx_PROF ===
                    MySqlCommand cmdProf = new MySqlCommand("SELECT * FROM professeur WHERE nom_professeur = @nom", connexion);
                    cmdProf.Parameters.AddWithValue("@nom", nomProf);
                    MySqlDataReader rProf = cmdProf.ExecuteReader();

                    if (rProf.Read())
                    {
                        lbl_Nm_miss.Text = rProf["nom_professeur"].ToString();
                        lbl_Prenom_miss.Text = rProf["prenom_professeur"].ToString();
                        lbl_NUMERO_miss.Text = rProf["numero_professeur"].ToString();
                        lbl_Cde_miss.Text = rProf["cde_ville"].ToString();
                        lbl_TELEPHONE_miss.Text = rProf["telephone_professeur"].ToString();
                    }

                    rProf.Close();

                    // === grpbx_TUTEUR ===
                    MySqlCommand cmdTut = new MySqlCommand("SELECT * FROM tuteur WHERE code_tuteur = @code", connexion);
                    cmdTut.Parameters.AddWithValue("@code", codeTuteur);
                    MySqlDataReader rTut = cmdTut.ExecuteReader();

                    if (rTut.Read())
                    {
                        lbl_Nmttr_miss.Text = rTut["nom_tuteur"].ToString();
                        lbl_Prnmttr_miss.Text = rTut["prenom_tuteur"].ToString();
                        lbl_Cdettr_miss.Text = rTut["code_tuteur"].ToString();
                        lbl_Entrttr_miss.Text = rTut["nom_entreprise"].ToString();
                        lbl_Pstettr_miss.Text = rTut["nom_poste"].ToString();
                    }

                    rTut.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur réelle : " + ex.Message);
            }

        }


        
    }
}
