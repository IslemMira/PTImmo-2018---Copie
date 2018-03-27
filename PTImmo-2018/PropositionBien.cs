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
	public partial class PropositionBien : Form
	{
		public PropositionBien()
		{
			InitializeComponent();
		}

		private void PropositionBien_Load(object sender, EventArgs e)
		{
			string nomBase = "IMMOBILLY_JACKYTEAM";
			string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
			OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
			dbConnection.Open();

			string sql = "select s.CODE_SOUHAIT, v.NOM_VILLE, s.SURFACE_HABITABLE_MIN, s.SURFACE_PARCELLE_MIN, s.NB_PIECES_MIN, s.PRIX_MAX, s.STATUT from SOUHAIT s left join VILLE v on v.CODE_VILLE = s.CODE_VILLE where s.NUM_ACHETEUR =2 ";
			OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
			OleDbDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				textBox15.Text = reader.GetInt32(0).ToString();
				textBox1.Text = reader.GetString(1);
				numericUpDown1.Text = reader.GetInt32(2).ToString();
				numericUpDown2.Text = reader.GetInt32(3).ToString();
				numericUpDown3.Text = reader.GetInt32(4).ToString();
				//numericUpDown4.TextAlign = reader.GetInt32().ToString(); WHERE ARE MY TOILETS???
				textBox2.Text = reader.GetInt32(5).ToString();
			}
			reader.Close();
		}

		private void RechercheListePropositions_Click(object sender, EventArgs e)
		{
			//listView1.Items.Clear();

			//string nomBase = "IMMOBILLY_JACKYTEAM";
			//string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
			//OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
			//dbConnection.Open();

			//string sql = "";
			//OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
			//OleDbDataReader reader = cmd.ExecuteReader();
			//while (reader.Read())
			//{
			//	Console.WriteLine(reader.GetInt16(0));
			//	Console.WriteLine(reader.GetInt32(1));


			//	string[] row = { reader.GetInt16(0).ToString(), reader.GetInt32(1).ToString() };
			//	ListViewItem lbp = new ListViewItem(row);
			//	listView1.Items.Add(lbp);
			//}
			//reader.Close();
		}

		private void Proposer_Click(object sender, EventArgs e)
		{

		}

		private void Retour_Click(object sender, EventArgs e)
		{
			Visualiser_Acheteur va = new Visualiser_Acheteur();
			va.Show(this);
			this.Hide();
		}
	}
}
