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
	public partial class Liste_des_propositions : Form
	{
		public Liste_des_propositions()
		{
			InitializeComponent();
		}

		private void Liste_des_propositions_Load(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			listView2.Items.Clear();

			string nomBase = "IMMOBILLY_JACKYTEAM";
			string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
			OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
			dbConnection.Open();

			string sql2 = "SELECT num_acheteur,nom_Acheteur, prénom_Acheteur where NUM_ACHETEUR =; ";
			OleDbCommand cmd2 = new OleDbCommand(sql2, dbConnection);
			OleDbDataReader reader2 = cmd2.ExecuteReader();
			while (reader2.Read())
			{
				textBox1.Text = reader2.GetInt32(0).ToString();
				textBox3.Text = reader2.GetInt32(1).ToString();
				textBox4.Text = reader2.GetInt32(2).ToString();
			}
			reader2.Close();

			string sql = "select b.code_bien,b.adresse,b.statut, count(v.code_visite) nb_visite from bien b left join proposition p on p.code_bien = b.code_bien left join visite v on v.code_proposition = p.code_proposition left join vendeur ve on ve.num_client = b.num_client where ve.nom_client like '%" + textBox1.Text + "%' and b.statut like '%" + "' group by b.code_bien,b.adresse,b.statut; ";

			OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
			OleDbDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				Console.WriteLine(reader.GetInt16(0));
				Console.WriteLine(reader.GetString(1));
				Console.WriteLine(reader.GetString(2));

				string[] row = { reader.GetInt16(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetInt32(3).ToString() };
				ListViewItem lvi = new ListViewItem(row);
				listView1.Items.Add(lvi);
			}
			reader.Close();

			string sql1 = "select s.CODE_SOUHAIT, p.DATE, v.DATE from VISITE v left join PROPOSITION p on p.CODE_PROPOSITION = v.CODE_PROPOSITION left join SOUHAIT s on s.CODE_SOUHAIT = p.CODE_SOUHAIT where s.NUM_ACHETEUR =; ";
				OleDbCommand cmd1 = new OleDbCommand(sql1, dbConnection);
				OleDbDataReader reader1 = cmd.ExecuteReader();
				while (reader1.Read())
				{
					Console.WriteLine(reader1.GetInt16(0));
					Console.WriteLine(reader1.GetDateTime(1));
					Console.WriteLine(reader1.GetDateTime(2));

					string[] row = { reader1.GetInt16(0).ToString(), reader1.GetDateTime(1).ToString(), reader1.GetDateTime(2).ToString() };
					ListViewItem visites = new ListViewItem(row);
					listView1.Items.Add(visites);
				}
			reader1.Close();
		}

		private void CreerVisite_Click(object sender, EventArgs e)
		{

		}

		private void GenererBonVisite_Click(object sender, EventArgs e)
		{

		}

		private void Modifier_Click(object sender, EventArgs e)
		{

		}

		private void Supprimer_Click(object sender, EventArgs e)
		{

		}

		private void FicheAcheteur_Click(object sender, EventArgs e)
		{
			Visualiser_Acheteur va = new Visualiser_Acheteur();
			va.Show(this);
			this.Hide();
		}
	}
}
