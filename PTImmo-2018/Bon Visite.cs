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
	public partial class Bon_Visite : Form
	{
		public Bon_Visite()
		{
			InitializeComponent();
		}

		private void Bon_Visite_Load(object sender, EventArgs e)
		{
			//string nomBase = "IMMOBILLY_JACKYTEAM";
			string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
			OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
			dbConnection.Open();

			string sql = "select  b.surface_habitable, b.surface_parcelle, b.nb_piéces, b.nb_chambres, b.nb_Salle_de_bain, b.garage, b.cave, b.prix_vendeur,  b.adresse, vi.nom_ville, vi.code_postal, v.Date,a.NOM_ACHETEUR, a.PRÉNOM_ACHETEUR, c.NOM, c.PRENOM  from bien b left join ville vi on vi.code_ville = b.code_ville join proposition p on b.CODE_BIEN = p.CODE_BIEN join visite v on p.code_proposition = v.code_proposition join souhait s on s.CODE_SOUHAIT = p.CODE_SOUHAIT join acheteur a on a.NUM_ACHETEUR = s.NUM_ACHETEUR join COMMERCIAL c on a.NUM_COMMERCIAL = c.NUM_COMMERCIAL where p.code_proposition = '" + ApplicationState.id_proposition + "' ";
			OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
			OleDbDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				textBox_SurfHab.Text = reader.GetInt32(0).ToString();
				textBox_SurfParc.Text = reader.GetInt32(1).ToString();
				textBox_NbPiece.Text = reader.GetInt32(2).ToString();
				textBox_NbChambre.Text = reader.GetInt32(3).ToString();
				textBox_NbSdb.Text = reader.GetInt32(4).ToString();
				if (reader.GetBoolean(5) == true) checkBox_Garage.Checked = true;
				if (reader.GetBoolean(6) == true) checkBox_Cave.Checked = true;
				textBox_Prix.Text = reader.GetValue(7).ToString();
				textBox_VisRueBien.Text = reader.GetString(8);
				textBox_Ville.Text = reader.GetString(9);
				textBox_VisCPBien.Text = reader.GetValue(10).ToString();
				dateTimePicker1.Text = reader.GetDateTime(11).ToString();
                textBox2.Text = reader.GetString(12);
                textBox1.Text = reader.GetString(13);
                textBox3.Text = reader.GetString(14).Trim().ToUpper() + " " + reader.GetString(15).Trim();
                textBox4.Text = "Maison de " + textBox_NbPiece.Text + " piéces située à " + textBox_Ville.Text + "";
			}
			reader.Close();
		}
	}
}
