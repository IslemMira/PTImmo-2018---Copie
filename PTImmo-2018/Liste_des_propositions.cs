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

            //string nomBase = "IMMOBILLY_JACKYTEAM";
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



            string sql1 = "select p.CODE_PROPOSITION, a.NOM_ACHETEUR, a.PRÉNOM_ACHETEUR, c.NOM, c.PRENOM, b.CODE_BIEN, p.DATE from PROPOSITION p join bien b on b.CODE_BIEN = p.CODE_BIEN join souhait s on s.CODE_SOUHAIT = p.CODE_SOUHAIT join acheteur a on s.NUM_ACHETEUR = a.NUM_ACHETEUR join COMMERCIAL c on c.NUM_COMMERCIAL = a.NUM_COMMERCIAL where a.NUM_ACHETEUR = '" + textBox1.Text + "' ";
            OleDbCommand cmd1 = new OleDbCommand(sql1, dbConnection);
            OleDbDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                string[] row = { reader1.GetValue(0).ToString(), reader1.GetString(1), reader1.GetString(2), reader1.GetString(3), reader1.GetString(4), reader1.GetValue(5).ToString(), reader1.GetValue(6).ToString() };
                ListViewItem proposition = new ListViewItem(row);
                listView1.Items.Add(proposition);
            }
            reader1.Close();

            string sql3 = "SELECT v.CODE_VISITE, v.date,c.nom, c.PRENOM, p.CODE_PROPOSITION  from VISITE v join PROPOSITION p on p.CODE_PROPOSITION = v.CODE_PROPOSITION join souhait s on s.CODE_SOUHAIT = p.CODE_SOUHAIT join ACHETEUR a on a.NUM_ACHETEUR = s.NUM_ACHETEUR join COMMERCIAL c on c.NUM_COMMERCIAL = a.NUM_COMMERCIAL where a.NUM_ACHETEUR = '" + textBox1.Text + "'";
            OleDbCommand cmd3 = new OleDbCommand(sql3, dbConnection);
            OleDbDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                string[] row = { reader3.GetInt32(0).ToString(), reader3.GetValue(1).ToString(), reader3.GetString(2), reader3.GetString(3), reader3.GetValue(4).ToString() };
                ListViewItem visites = new ListViewItem(row);
                listView2.Items.Add(visites);
            }
            reader3.Close();
        }

		private void CreerVisite_Click(object sender, EventArgs e)
		{
           ApplicationState.id_proposition = listView1.SelectedItems[0].SubItems[0].Text;
            CreerVisite cv = new CreerVisite();
			cv.Show(this);
			this.Hide();
		}

		private void GenererBonVisite_Click(object sender, EventArgs e)
		{
            ApplicationState.id_proposition = listView2.SelectedItems[0].SubItems[4].Text;
            Bon_Visite bv = new Bon_Visite();
			bv.Show(this);
			
		}

		private void Modifier_Click(object sender, EventArgs e)
		{
            ApplicationState.id_visite = listView2.SelectedItems[0].SubItems[0].Text;
            ModifierVisite mf = new ModifierVisite();
			mf.Show(this);
			
		}

		private void Supprimer_Click(object sender, EventArgs e)
		{
            ApplicationState.id_visite = listView2.SelectedItems[0].SubItems[0].Text;
            //string nomBase = "IMMOBILLY_JACKYTEAM";
			string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
			OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
			dbConnection.Open();

			string sql = "DELETE FROM Visite where code_Visite = '" + ApplicationState.id_visite + "'  ";
			OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
			cmd.ExecuteNonQuery();

			MessageBox.Show("Supprime");
            Liste_des_propositions ldp = new Liste_des_propositions();
            ldp.Show(this);
            this.Hide();

        }

        public void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            ApplicationState.id_proposition = listView1.SelectedItems[0].SubItems[0].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           PropositionBien pb = new PropositionBien();
            pb.Show(this);
            this.Hide();
        }

	

		private void listView2_MouseClick(object sender, MouseEventArgs e)
		{
			ApplicationState.id_proposition = listView2.SelectedItems[0].SubItems[0].Text;
		}
	}
}
