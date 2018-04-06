using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTImmo_2018
{
    public partial class visualiser_acheteur : Form
    {
        
        public visualiser_acheteur()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplicationState.id_acheteur = textBox6.Text;
            Liste_des_propositions ldp = new Liste_des_propositions();
            ldp.Show(this);
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (en_cours.Checked == true)
            {
                listView1.Items.Clear();

                //string nomBase = "IMMOBILLY_JACKYTEAM";
                string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
                OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
                dbConnection.Open();
                string sql1 = "SELECT s.CODE_SOUHAIT, s.SURFACE_HABITABLE_MIN, s.NB_PIECES_MIN, s.PRIX_MAX, s.Statut from souhait s where s.NUM_ACHETEUR = '" + textBox6.Text + "' and s.STATUT = 'EN COURS'";
                OleDbCommand cmd1 = new OleDbCommand(sql1, dbConnection);
                OleDbDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    string[] row = { reader1.GetInt32(0).ToString(), reader1.GetInt32(1).ToString(), reader1.GetInt32(2).ToString(), reader1.GetInt32(3).ToString(), reader1.GetString(4) };
                    ListViewItem ls = new ListViewItem(row);
                    listView1.Items.Add(ls);
                }
                reader1.Close();
            } 
        }
        
        

        public void Visualiser_Acheteur_Load(object sender, EventArgs e)
        {
            //string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();



            string sql = "SELECT nom_Acheteur, prénom_Acheteur, adresse, VILLE.CODE_POSTAL, Téléphone, E_MAIL,  c.Nom, c.Prenom, Num_Acheteur, VILLE.NOM_VILLE from ACHETEUR left join VILLE on ACHETEUR.Code_Ville = VILLE.Code_Ville join COMMERCIAL c on ACHETEUR.NUM_COMMERCIAL = c.NUM_COMMERCIAL where NUM_ACHETEUR = '" + ApplicationState.id_acheteur + "' ";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = reader.GetString(0).ToString().Trim();
                textBox2.Text = reader.GetString(1);
                textBox12.Text = reader.GetString(2);
                textBox10.Text = reader.GetValue(3).ToString();
                textBox3.Text = reader.GetValue(4).ToString();
                textBox4.Text = reader.GetString(5);
                textBox5.Text = reader.GetString(6).Trim().ToUpper() + " " + reader.GetString(7).Trim();
                textBox6.Text = reader.GetValue(8).ToString();
                textBox7.Text = reader.GetString(9);
            }
            reader.Close();

            if (en_cours.Checked == true) { 
            string sql1 = "SELECT s.CODE_SOUHAIT, s.SURFACE_HABITABLE_MIN, s.NB_PIECES_MIN, s.PRIX_MAX, s.Statut from souhait s where s.NUM_ACHETEUR = '" + textBox6.Text + "' and s.STATUT = 'EN COURS' ";
            OleDbCommand cmd1 = new OleDbCommand(sql1, dbConnection);
            OleDbDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                string[] row = { reader1.GetInt32(0).ToString(), reader1.GetInt32(1).ToString(), reader1.GetInt32(2).ToString(), reader1.GetInt32(3).ToString(), reader1.GetString(4) };
                ListViewItem ls = new ListViewItem(row);
                listView1.Items.Add(ls);
            }
            reader1.Close();
            }
 
        }

        private void Afficher_tout_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (Afficher_tout.Checked == true)
            {
                listView1.Items.Clear();
                //string nomBase = "IMMOBILLY_JACKYTEAM";
                string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
                OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
                dbConnection.Open();
                string sql1 = "SELECT s.CODE_SOUHAIT, s.SURFACE_HABITABLE_MIN, s.NB_PIECES_MIN, s.PRIX_MAX, s.Statut from souhait s where s.NUM_ACHETEUR = '" + textBox6.Text + "' ";
                OleDbCommand cmd1 = new OleDbCommand(sql1, dbConnection);
                OleDbDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    string[] row = { reader1.GetInt32(0).ToString(), reader1.GetInt32(1).ToString(), reader1.GetInt32(2).ToString(), reader1.GetInt32(3).ToString(), reader1.GetString(4) };
                    ListViewItem ls = new ListViewItem(row);
                    listView1.Items.Add(ls);
                }
                reader1.Close();
            }

        }

        

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            ApplicationState.id_souhait = listView1.SelectedItems[0].SubItems[0].Text;
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            RechercheAcheteur ra = new RechercheAcheteur();
            ra.Show(this);
            this.Hide();
        }

		private void ListePropositions_Click(object sender, EventArgs e)
		{
            ApplicationState.id_acheteur = textBox6.Text;
			Liste_des_propositions ldp = new Liste_des_propositions();
			ldp.Show(this);

		}

        private void Ajouter_un_souhait_Click_1(object sender, EventArgs e)
        {
            ApplicationState.id_acheteur = textBox6.Text;
            FicheSouhaitCreation fsc = new FicheSouhaitCreation();
            fsc.Show(this);
            
        }

        private void ModifierAcheteur_Click(object sender, EventArgs e)
        {
            ApplicationState.id_acheteur = textBox6.Text;
            ModifierAcheteur ma = new ModifierAcheteur();
            ma.Show(this);
            this.Hide();
        }

        private void details_MouseClick(object sender, MouseEventArgs e)
        {
            ApplicationState.id_souhait = listView1.SelectedItems[0].SubItems[0].Text;
            FicheSouhaitsViz fsv = new FicheSouhaitsViz();
            fsv.Show(this);
            
        }

        private void proposer_MouseClick(object sender, MouseEventArgs e)
        {
            ApplicationState.id_souhait = listView1.SelectedItems[0].SubItems[0].Text;
            PropositionBien pb = new PropositionBien();
            pb.Show(this);
            
        }
    }
}
