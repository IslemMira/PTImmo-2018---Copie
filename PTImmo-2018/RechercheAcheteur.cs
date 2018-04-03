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
	public partial class RechercheAcheteur : Form
	{
        public RechercheAcheteur()
        {
            InitializeComponent();


            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();
            string sql = "SELECT num_acheteur, nom_Acheteur, prénom_Acheteur, adresse, téléphone, E_MAIL, VILLE.Nom_Ville from ACHETEUR left join SOUHAIT on ACHETEUR.NUM_ACHETEUR = SOUHAIT.NUM_ACHETEUR left join VILLE on ACHETEUR.Code_Ville = VILLE.Code_Ville where Nom_Acheteur like '%" + "' and Prénom_Acheteur like '%'" + "%' and statut like '%" + "';";

            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                identifiant.Text = reader.GetString(1);
                nom.Text = reader.GetString(2);
                prenom.Text = reader.GetString(3);
                listBox1.Text = reader.GetString(4);
                //comboBox_commercial.

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();


            string statuts = " ";
            string sql = "SELECT num_acheteur, nom_Acheteur, prénom_Acheteur, adresse, téléphone, E_MAIL, VILLE.Nom_Ville from ACHETEUR left join SOUHAIT on ACHETEUR.NUM_ACHETEUR = SOUHAIT.NUM_ACHETEUR left join VILLE on ACHETEUR.Code_Ville = VILLE.Code_Ville where Nom_Acheteur like '%" + "' and Prénom_Acheteur like '%'" + "%' and statut like '%" + "';";
            string acheteur_d_exis = "";

            if (en_cours.Checked == true)
            {
                acheteur_d_exis = "E";
                afficher_tout.Checked = false;
            }

            if (afficher_tout.Checked == true)
            {
                acheteur_d_exis = "A";
                en_cours.Checked = false;
            }
       
            private void Charger_Liste_Commerciaux()
        {
            List<Ajouter_commercial> commerciaux = (from c in RechercheAcheteur.IMMOBILLY_JACKYTEAM.COMMERCIAL
                                            select c).ToList();

            foreach (COMMERCIAL c in commerciaux)

                comboBox_commercial.Items.Add(c.NOM_COMMERCIAL);
           
        }


        OleDbCommand cmd = new OleDbCommand(sql, dbConnection);

        }
    }

