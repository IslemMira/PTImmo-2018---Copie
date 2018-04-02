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
    public partial class Nouveau_bien : Form
    {
        public Nouveau_bien()
        {
            InitializeComponent();
        }

        private void Button_Valider_Click(object sender, EventArgs e)
        {
			string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
			OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
			dbConnection.Open();

			string sql1 = "INSERT Into Bien (SURFACE_HABITABLE, SURFACE_PARCELLE, NB_PIECES, NB_CHAMBRES, NB_SALLE_DE_BAIN, GARAGE, CAVE, PRIX_VENDEUR, ADRESSE, DATE_MISE_EN_VENTE, COMMENTAIRE, STATUT, CODE_VILLE, NUM_CLIENT)";
            string sql2 = "VALUES (" + textBox_AjSurfaceHabitableBien.Text + "," + textBox_AjSurfaceParcelleBien.Text + "," + Convert.ToInt32(nbPiecesBien.Text) + "," + nbChambreBien.Text + "," + Convert.ToInt32(nbSDBien.Text) + "," + Convert.ToInt32(textBox_AjCPVendeur.Text) + "," + textBox_AjRueBien.Text + "," + textBox_AjCommentaireBien.Text + ", 'D'," + Convert.ToInt32(textBox_AjCPBien) + "," + textBox_AjCodeVendeur.Text + ",(SELECT v.code_ville from VILLE v where v.NOM_VILLE LIKE " + textBox_AjVilleBien.Text + ")";
            string sql = sql1 + sql2;

            
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Saved");
			FicheVendeur fv = new FicheVendeur();
			fv.Show(this);
			this.Hide();

		}

        private void Annuler_NouveauBien(object sender, EventArgs e)
        {
            FicheVendeur fv = new FicheVendeur();
            fv.Show(this);
            this.Hide();
        }

       

		private void Nouveau_bien_Load(object sender, EventArgs e)
		{
			string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

			OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
			dbConnection.Open();

			string sqlS1 = "Select v.Num_Client, v.Nom_Client, v.Prénom_Client, v.Téléphone, v.E_mail, v.adresse, vi.nom_ville, vi.code_postal";
			string sqlF1 = " from Vendeur v left join ville vi on vi.code_ville = v.code_ville  where v.num_client = '"+FicheVendeur.id_vendeur +"' ";
			string sql = sqlS1 + sqlF1;

			OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
			OleDbDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				textBox_AjCodeVendeur.Text = reader.GetInt32(0).ToString();
				textBox_AjNomVendeur.Text = reader.GetString(1);
				textBox_AjPrenomVendeur.Text = reader.GetString(2);
				textBox_AjTelephoneVendeur.Text = reader.GetInt32(3).ToString();
				textBox_AjEmailVendeur.Text = reader.GetString(4);
				textBox_AjRueVendeur.Text = reader.GetString(5);
				textBox_AjVilleVendeur.Text = reader.GetString(6);
				textBox_AjCPVendeur.Text = reader.GetInt32(7).ToString();
			}
			reader.Close();
		}
	}
}
