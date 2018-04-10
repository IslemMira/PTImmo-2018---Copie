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
    public partial class RechercheAcheteur : Form
    {
        string idcommmercial = "-1";

        public RechercheAcheteur()
        {
            InitializeComponent();


            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql = "SELECT Num_Commercial, Nom, Prenom from commercial";
            Console.WriteLine("test1");
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string num_commercial = reader.GetInt32(0).ToString();
                string nom_commercial = reader.GetString(1);
                string prenom_commercial = reader.GetString(2);

                string itembox = num_commercial+" "+ nom_commercial;

                comboBox_commercial.Items.Add(itembox);


            }

                
        }

        private void Button_RechercheAcheteur(object sender, EventArgs e)
        {

           
        }

        private void Filtre_Commercial(object sender, EventArgs e)
        {

        }


		private void RechercheAcheteur_Load(object sender, EventArgs e)
		{
			

		}

		private void Ajouter_Click(object sender, EventArgs e)
		{
			Creation_acheteur ca = new Creation_acheteur();
			ca.Show(this);
			this.Hide();
		}

		private void Visualiser_Click(object sender, EventArgs e)
		{
			visualiser_acheteur va = new visualiser_acheteur();
			va.Show(this);
			this.Hide();
		}

		private void listView1_MouseClick(object sender, MouseEventArgs e)
		{
			ApplicationState.id_acheteur = listView1.SelectedItems[0].SubItems[0].Text;
		}

        private void Rechercher_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();
            
            string sql = "SELECT num_acheteur, nom_Acheteur, prénom_Acheteur, TÉLÉPHONE, E_MAIL from ACHETEUR where NOM_ACHETEUR LIKE '%"+textBox_Nom.Text+"%' and Prénom_Acheteur LIKE '%"+textBox_Prenom.Text+"%'";
            string sql2 = "AND ACHETEUR.num_commercial=" + idcommmercial + " ;";
            Console.WriteLine(idcommmercial);
            int test; 
            Int32.TryParse(idcommmercial, out test);
            Console.WriteLine(test);
            if (test != 0) 
            {
                sql = sql + sql2;
            }
            Console.WriteLine("test1");
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string num_acheteur = reader.GetInt32(0).ToString();
                string nom_acheteur = reader.GetString(1);
                string prénom_acheteur = reader.GetString(2);
                string telephone ='0' + reader.GetInt32(3).ToString();
                string email = reader.GetString(4);
                string[] row = {num_acheteur, nom_acheteur, prénom_acheteur,telephone,email};
                ListViewItem lvi = new ListViewItem(row);
                listView1.Items.Add(lvi);

            }
            reader.Close();
        }

        private void comboBox_commercial_Validated(object sender, EventArgs e)
        {
            string[] substrings = comboBox_commercial.Text.Split(' ');

            idcommmercial = substrings[0];
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            FormAcceuil fa = new FormAcceuil();
            fa.Show(this);
            this.Hide();
        }
    }
}
