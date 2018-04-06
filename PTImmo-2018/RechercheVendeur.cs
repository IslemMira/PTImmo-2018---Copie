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
    public partial class RechercheVendeur : Form
    {
		
        public RechercheVendeur()
        {
            InitializeComponent();
           
            Bouton_Ajouter_bien.Enabled = false;
            Visualiser.Enabled = false;

            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sqlS1 = "Select v.Num_Client, v.Nom_Client, v.Prénom_Client, v.Adresse, v.Téléphone, v.E_mail, v.adresse, vi.nom_ville, vi.code_postal";
            string sqlF1 = " from Vendeur v left join ville vi on vi.code_ville = v.code_ville";
            
            string sql = sqlS1 + sqlF1;

            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                string[] ligne = { reader.GetInt16(0).ToString(), reader.GetString(1), reader.GetString(2)};
                ListViewItem lvi = new ListViewItem(ligne);
                listView1_vendeurs.Items.Add(lvi);
            }
            reader.Close();

        }

		private void RechercheVendeur_Load(object sender, EventArgs e)
		{
           

            if (textBox_Identidiant.Text != "")
            {
                listView1_vendeurs.Items.Clear();

                string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

                OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
                dbConnection.Open();

                string sqlS1 = "Select v.Num_Client, v.Nom_Client, v.Prénom_Client, v.Adresse, v.Téléphone, v.E_mail, v.adresse, vi.nom_ville, vi.code_postal";
                string sqlF1 = " from Vendeur v left join ville vi on vi.code_ville = v.code_ville";
                string sqlW1 = " where v.Num_Client LIKE '" + textBox_Identidiant.Text + "%' ";
                string sql = sqlS1 + sqlF1 + sqlW1;

                OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    string[] ligne = { reader.GetInt16(0).ToString(), reader.GetString(1), reader.GetString(2) };
                    ListViewItem lvi = new ListViewItem(ligne);
                    listView1_vendeurs.Items.Add(lvi);
                }
                reader.Close();
            }
            else
            {
                if (textBox_Nom.Text != "")
                {
                    listView1_vendeurs.Items.Clear();


                    string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

                    OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
                    dbConnection.Open();

                    string sqlS1 = "Select v.Num_Client, v.Nom_Client, v.Prénom_Client, v.Adresse, v.Téléphone, v.E_mail, v.adresse, vi.nom_ville, vi.code_postal";
                    string sqlF1 = " from Vendeur v left join ville vi on vi.code_ville = v.code_ville";
                    string sqlW1 = " where v.Nom_Client LIKE '" + textBox_Nom.Text + "%' ";
                    string sql = sqlS1 + sqlF1 + sqlW1;

                    OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        string[] ligne = { reader.GetInt16(0).ToString(), reader.GetString(1), reader.GetString(2) };
                        ListViewItem lvi = new ListViewItem(ligne);
                        listView1_vendeurs.Items.Add(lvi);
                    }
                    reader.Close();
                }
                else
                {
                    listView1_vendeurs.Items.Clear();

                    string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

                    OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
                    dbConnection.Open();

                    string sqlS1 = "Select v.Num_Client, v.Nom_Client, v.Prénom_Client, v.Adresse, v.Téléphone, v.E_mail, v.adresse, vi.nom_ville, vi.code_postal";
                    string sqlF1 = " from Vendeur v left join ville vi on vi.code_ville = v.code_ville";

                    string sql = sqlS1 + sqlF1;

                    OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        string[] ligne = { reader.GetInt16(0).ToString(), reader.GetString(1), reader.GetString(2) };
                        ListViewItem lvi = new ListViewItem(ligne);
                        listView1_vendeurs.Items.Add(lvi);
                    }
                    reader.Close();
                }
            }
        }


        private void Visualiser_Click(object sender, EventArgs e)
		{
            FicheVendeur fv = new FicheVendeur();
            fv.Show(this);
            this.Hide();
        }

		private void listView1_vendeurs_MouseClick(object sender, MouseEventArgs e)
		{
            Bouton_Ajouter_bien.Enabled = true;
            Visualiser.Enabled = true;

            ApplicationState.id_vendeur = listView1_vendeurs.SelectedItems[0].SubItems[0].Text;
		}

        private void Button_Annuler_MouseClick(object sender, MouseEventArgs e)
        {
            liste_des_biens lb = new liste_des_biens();
            lb.Show(this);
            this.Hide();
        }

        private void Bouton_Ajouter_bien_MouseClick(object sender, MouseEventArgs e)
        {
           
            ApplicationState.id_vendeur = listView1_vendeurs.SelectedItems[0].SubItems[0].Text;
            Nouveau_bien nb = new Nouveau_bien();
            nb.Show(this);
            this.Hide();
        }

        private void Bouton_CreerVendeur(object sender, EventArgs e)
        {
            Nouveau_Vendeur nv = new Nouveau_Vendeur();
            nv.Show(this);
            this.Hide();
        }
    }
}
