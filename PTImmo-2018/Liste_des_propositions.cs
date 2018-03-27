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

			string sql2 = "SELECT num_acheteur,nom_Acheteur, prénom_Acheteur FROM Acheteur where NUM_ACHETEUR =2 ";
			OleDbCommand cmd = new OleDbCommand(sql2, dbConnection);
            OleDbDataReader reader2 = cmd.ExecuteReader();
			while (reader2.Read())
			{
				textBox1.Text = reader2.GetInt32(0).ToString();
				textBox3.Text = reader2.GetString(1);
				textBox4.Text = reader2.GetString(2);
			}
			reader2.Close();

			

			string sql1 = "select s.CODE_SOUHAIT, p.DATE, v.DATE from VISITE v left join PROPOSITION p on p.CODE_PROPOSITION = v.CODE_PROPOSITION left join SOUHAIT s on s.CODE_SOUHAIT = p.CODE_SOUHAIT where s.NUM_ACHETEUR =2 ";
				OleDbCommand cmd1 = new OleDbCommand(sql1, dbConnection);
				OleDbDataReader reader1 = cmd.ExecuteReader();
				while (reader1.Read())
				{
					Console.WriteLine(reader1.GetInt32(0));
					Console.WriteLine(reader1.GetValue(1));
					Console.WriteLine(reader1.GetValue(2));

					string[] row = { reader1.GetInt32(0).ToString(), reader1.GetValue(1).ToString(), reader1.GetValue(2).ToString() };
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
