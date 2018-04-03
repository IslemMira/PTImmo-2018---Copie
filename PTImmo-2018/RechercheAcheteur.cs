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
        }

        private void Button_RechercheAcheteur(object sender, EventArgs e)
        {

            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql = "SELECT num_acheteur, nom_Acheteur, prénom_Acheteur, adresse, téléphone, E_MAIL, VILLE.Nom_Ville from ACHETEUR left join SOUHAIT on ACHETEUR.NUM_ACHETEUR = SOUHAIT.NUM_ACHETEUR left join VILLE on ACHETEUR.Code_Ville = VILLE.Code_Ville where Nom_Acheteur like '% %'   and Prénom_Acheteur like '% %' and statut like '% '";
 
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox_Identidiant.Text = reader.GetInt32(1).ToString();
                textBox_Nom.Text = reader.GetString(2);
                textBox_Prenom.Text = reader.GetString(3);
 
            }
            reader.Close();
        }

        private void Filtre_Commercial(object sender, EventArgs e)
        {

            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql = "Select c.Nom, c.Prenom from Commercial c left join acheteur a on a.num_commercial = c.Num_Commercial order by NOM";

            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();

        }


		private void RechercheAcheteur_Load(object sender, EventArgs e)
		{
			string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

			OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
			dbConnection.Open();

			string sql = "SELECT num_acheteur, nom_Acheteur, prénom_Acheteur, téléphone, E_MAIL from ACHETEUR ";
			OleDbCommand cmd1 = new OleDbCommand(sql, dbConnection);
			OleDbDataReader reader1 = cmd1.ExecuteReader();
			while (reader1.Read())
			{
				string[] row = { reader1.GetValue(0).ToString(), reader1.GetString(1), reader1.GetString(2), reader1.GetValue(3).ToString(), reader1.GetString(4)  };
				ListViewItem listeAcheteurs = new ListViewItem(row);
				listView1.Items.Add(listeAcheteurs);
			}
			reader1.Close();

		}

		private void Ajouter_Click(object sender, EventArgs e)
		{
			Creation_acheteur ca = new Creation_acheteur();
			ca.Show(this);
			this.Hide();
		}

		private void Visualiser_Click(object sender, EventArgs e)
		{
			visualiser_acheteur va = new visualiser_acheteur();
			va.Show(this);
			this.Hide();
		}

		private void listView1_MouseClick(object sender, MouseEventArgs e)
		{
			ApplicationState.id_acheteur = listView1.SelectedItems[0].SubItems[0].Text;
		}
	}
}
