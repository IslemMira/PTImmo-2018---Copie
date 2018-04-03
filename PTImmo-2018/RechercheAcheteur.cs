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

            
        }

        private void Filtre_Commercial(object sender, EventArgs e)
        {

        }


		private void RechercheAcheteur_Load(object sender, EventArgs e)
		{
			

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

        private void Rechercher_Click(object sender, EventArgs e)
        {
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql = "SELECT nom_Acheteur, prénom_Acheteur from ACHETEUR left join VILLE on ACHETEUR.Code_Ville = VILLE.Code_Ville  ";

            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string[] row = { reader.GetString(0), reader.GetString(1) };
                ListViewItem lvi = new ListViewItem(row);
                listView1.Items.Add(lvi);

            }
            reader.Close();
        }
    }
}
