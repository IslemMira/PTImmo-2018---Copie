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

        public void Liste_des_propositions_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();

            string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql2 = "SELECT nom_Acheteur, prénom_Acheteur FROM Acheteur where Num_Acheteur = '" + ApplicationState.id_acheteur +"' ";
            OleDbCommand cmd = new OleDbCommand(sql2, dbConnection);
            OleDbDataReader reader2 = cmd.ExecuteReader();
            while (reader2.Read())
            {
                
                textBox1.Text = ApplicationState.id_acheteur;
                textBox2.Text = reader2.GetString(0);
                textBox4.Text = reader2.GetString(1);
            }
            reader2.Close();



            string sql1 = "select p.CODE_SOUHAIT, p.code_bien, p.DATE, p.Code_Proposition from PROPOSITION p  left join SOUHAIT s on p.CODE_SOUHAIT = s.CODE_SOUHAIT left join ACHETEUR a on s.NUM_ACHETEUR = a.NUM_ACHETEUR where a.NUM_ACHETEUR = '" + textBox1.Text + "' ";
            OleDbCommand cmd1 = new OleDbCommand(sql1, dbConnection);
            OleDbDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                string[] row = { reader1.GetValue(3).ToString(),reader1.GetInt32(0).ToString(), reader1.GetValue(1).ToString(), reader1.GetValue(2).ToString() };
                ListViewItem proposition = new ListViewItem(row);
                listView1.Items.Add(proposition);
            }
            reader1.Close();

            string sql3 = "select p.Code_proposition, p.CODE_SOUHAIT, p.DATE, v.date from PROPOSITION p inner join visite v on p.CODE_PROPOSITION = v.CODE_PROPOSITION  left join SOUHAIT s on p.CODE_SOUHAIT = s.CODE_SOUHAIT left join ACHETEUR a on s.NUM_ACHETEUR = a.NUM_ACHETEUR where a.NUM_ACHETEUR = '" + textBox1.Text + "'";
            OleDbCommand cmd3 = new OleDbCommand(sql3, dbConnection);
            OleDbDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                string[] row = { reader3.GetInt32(0).ToString(), reader3.GetInt32(1).ToString(), reader3.GetValue(2).ToString(), reader3.GetValue(3).ToString() };
                ListViewItem visites = new ListViewItem(row);
                listView2.Items.Add(visites);
            }
            reader3.Close();
        }

		private void CreerVisite_Click(object sender, EventArgs e)
		{
			CreerVisite cv = new CreerVisite();
			cv.Show(this);
			this.Hide();
		}

		private void GenererBonVisite_Click(object sender, EventArgs e)
		{
			Bon_Visite bv = new Bon_Visite();
			bv.Show(this);
			this.Hide();
		}

		private void Modifier_Click(object sender, EventArgs e)
		{
			ModifierVisite mf = new ModifierVisite();
			mf.Show(this);
			this.Hide();
		}

		private void Supprimer_Click(object sender, EventArgs e)
		{
			string nomBase = "IMMOBILLY_JACKYTEAM";
			string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
			OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
			dbConnection.Open();

			string sql = "DELETE FROM Visite  where v.code_Visite = ";
			OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
			cmd.ExecuteNonQuery();

			MessageBox.Show("Supprime");
		}

		private void FicheAcheteur_Click(object sender, EventArgs e)
		{
			visualiser_acheteur va = new visualiser_acheteur();
			va.Show(this);
			this.Hide();
		}

        public void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            ApplicationState.id_proposition = listView1.SelectedItems[0].SubItems[0].Text;
            ApplicationState.id_proposition_souhait = listView1.SelectedItems[0].SubItems[1].Text;
            ApplicationState.id_proposition_bien = listView1.SelectedItems[0].SubItems[2].Text;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
           PropositionBien pb = new PropositionBien();
            pb.Show(this);
            this.Hide();
        }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void listView2_MouseClick(object sender, MouseEventArgs e)
		{
			ApplicationState.id_proposition_visite = listView2.SelectedItems[0].SubItems[0].Text;
		}
	}
}
