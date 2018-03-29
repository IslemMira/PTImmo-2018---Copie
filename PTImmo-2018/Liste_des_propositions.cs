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
        public static string id_proposition_visite;
        public static string id_proposition_bien;

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

            string sql2 = "SELECT num_acheteur,nom_Acheteur, prénom_Acheteur FROM Acheteur where NUM_ACHETEUR =2 ";
            OleDbCommand cmd = new OleDbCommand(sql2, dbConnection);
            OleDbDataReader reader2 = cmd.ExecuteReader();
            while (reader2.Read())
            {
                textBox1.Text = reader2.GetInt32(0).ToString();
                textBox2.Text = reader2.GetString(1);
                textBox4.Text = reader2.GetString(2);
            }
            reader2.Close();



            string sql1 = "select p.CODE_SOUHAIT, p.code_bien, p.DATE from PROPOSITION p  left join SOUHAIT s on p.CODE_SOUHAIT = s.CODE_SOUHAIT left join ACHETEUR a on s.NUM_ACHETEUR = a.NUM_ACHETEUR where a.NUM_ACHETEUR = " + textBox1.Text + ";";
            OleDbCommand cmd1 = new OleDbCommand(sql1, dbConnection);
            OleDbDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                string[] row = { reader1.GetInt32(0).ToString(), reader1.GetValue(1).ToString(), reader1.GetValue(2).ToString() };
                ListViewItem proposition = new ListViewItem(row);
                listView1.Items.Add(proposition);
            }
            reader1.Close();

            string sql3 = "select p.CODE_SOUHAIT, p.DATE, v.date from PROPOSITION p inner join visite v on p.CODE_PROPOSITION = v.CODE_PROPOSITION  left join SOUHAIT s on p.CODE_SOUHAIT = s.CODE_SOUHAIT left join ACHETEUR a on s.NUM_ACHETEUR = a.NUM_ACHETEUR where a.NUM_ACHETEUR = " + textBox1.Text + ";";
            OleDbCommand cmd3 = new OleDbCommand(sql3, dbConnection);
            OleDbDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                string[] row = { reader3.GetInt32(0).ToString(), reader3.GetValue(1).ToString(), reader3.GetValue(2).ToString() };
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

        public void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            id_proposition_visite = listView1.SelectedItems[0].SubItems[0].Text;
            id_proposition_bien = listView1.SelectedItems[0].SubItems[1].Text;
           
        }

       
    }
}
