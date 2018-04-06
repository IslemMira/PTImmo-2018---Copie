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
    public partial class FicheVendeur : Form
	{ 
        public FicheVendeur()
        {
            InitializeComponent();
       
        }

		private void FicheVendeur_Load(object sender, EventArgs e)
		{
			string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

			OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
			dbConnection.Open();

			string sqlS1 = "Select v.Num_Client, v.Nom_Client, v.Prénom_Client, v.Téléphone, v.E_mail, v.adresse, vi.nom_ville, vi.code_postal";
			string sqlF1 = " from Vendeur v left join ville vi on vi.code_ville = v.code_ville  where v.num_client = '" + ApplicationState.id_vendeur + "' ";
			string sql = sqlS1 + sqlF1;

			OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
			OleDbDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				textBox_AjCodeVendeur.Text = reader.GetValue(0).ToString();
				textBox1_Nom.Text = reader.GetString(1);
				textBox2_Prenom.Text = reader.GetString(2);
				textBox3_Telephone.Text = reader.GetInt32(3).ToString();
				textBox4_E_Mail.Text = reader.GetString(4);
				textBox12_Adresse.Text = reader.GetString(5);
				textBox11_Ville.Text = reader.GetString(6);
				textBox10_CP.Text = reader.GetInt32(7).ToString();
			}
			reader.Close();

			string sql2 = "Select b.code_bien,b.adresse,b.statut, count(v.code_visite) nb_visite from bien b left join proposition p on p.code_bien = b.code_bien left join visite v on v.code_proposition = p.code_proposition where b.num_client = '" + ApplicationState.id_vendeur + "'  group by b.code_bien,b.adresse,b.statut ";

			cmd = new OleDbCommand(sql2, dbConnection);
			reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				string[] ligne = { reader.GetInt16(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetInt32(3).ToString() };
				ListViewItem lvi = new ListViewItem(ligne);
				listView1.Items.Add(lvi);
			}
			reader.Close();
		}

		private void ModifierVendeur_Click(object sender, EventArgs e)
		{
			ApplicationState.id_vendeur = textBox_AjCodeVendeur.Text;
			ModifierVendeur mv = new ModifierVendeur();
			mv.Show(this);
			this.Hide();
		}

		private void AjouterBien_Click(object sender, EventArgs e)
		{
            Nouveau_bien nb = new Nouveau_bien();
			nb.Show(this);
			
		}

		private void Visualiser_Click(object sender, EventArgs e)
		{

			Fiche_Bien fb = new Fiche_Bien();
			fb.Show(this);
			this.Hide();
		}

		private void Button_Annuler_Click(object sender, EventArgs e)
		{
            RechercheVendeur rv = new RechercheVendeur();
            rv.Show(this);
            this.Hide();
        }

		private void listView1_MouseClick(object sender, MouseEventArgs e)
		{
			ApplicationState.id_bien = listView1.SelectedItems[0].SubItems[0].Text;
		}
	}
}
