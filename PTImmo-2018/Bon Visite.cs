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
			string nomBase = "IMMOBILLY_JACKYTEAM";
			string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
			OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
			dbConnection.Open();

			string sql = "select  b.surface_habitable, b.surface_parcelle, b.nb_piéces, b.nb_chambres, b.nb_Salle_de_bain, b.garage, b.cave, b.prix_vendeur,  b.adresse, vi.nom_ville, vi.code_postal, v.Date from bien b left join ville vi on vi.code_ville = b.code_ville join proposition p on b.code_proposition = p.code_proposition join visite v on p.code_proposition = v.code_proposition where p.code_proposition = '" + Liste_des_propositions.id_proposition_visite + "' ";
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
			}
			reader.Close();
		}
	}
}
