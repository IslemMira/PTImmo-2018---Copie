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
    public partial class Recherche_Commerciaux : Form
    {        
        public Recherche_Commerciaux()
        {
            InitializeComponent();
            Visualiser.Enabled = false;

            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sqlS1 = "Select c.Num_Commercial, c.Nom, c.Prenom, count(a.num_acheteur) as nombre_acheteur, c.Statut";
            string sqlF1 = " from Commercial c left join acheteur a on a.num_commercial = c.Num_Commercial";
            string sqlW1 = " where c.Statut = 'ACTIF'";
            string sqlG1 = " group by c.Num_Commercial, c.Nom, c.Prenom, c.Statut";
            string sql = sqlS1 + sqlF1 + sqlW1 + sqlG1;

            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                string[] ligne = { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetInt32(3).ToString(), reader.GetString(4) };
                ListViewItem lvi = new ListViewItem(ligne);
                listView1_Commerciaux.Items.Add(lvi);
            }
            reader.Close();
        }

        private void checkBox_actif_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Recherche_IdCommercial(object sender, EventArgs e)
        {
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sqlS1 = "Select c.Num_Commercial, c.Nom, c.Prenom, count(a.num_acheteur) as nombre_acheteur, c.Statut";
            string sqlF1 = " from Commercial c left join acheteur a on a.num_commercial = c.Num_Commercial";
            string sqlW1 = " where c.NUM_COMMERCIAL = %";
            string sqlG1 = " group by c.Num_Commercial, c.Nom, c.Prenom, c.Statut";
            string sql = sqlS1 + sqlF1 + sqlW1 + sqlG1;

            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                textBox_id.Text = reader.GetString(1);
            }
            reader.Close();
        }

        private void Button_AjouterCommercial(object sender, EventArgs e)
        {
            Ajouter_commercial ac = new Ajouter_commercial();
            ac.Show(this);
            this.Hide();
        }

        private void Fermer_RechercheCommercial(object sender, EventArgs e)
        {
            FormAcceuil Accueil = new FormAcceuil();
            Accueil.Show(this);
            this.Hide();
        }

        private void Visualiser_Click(object sender, EventArgs e)
        {
            ModifierCommercial mc = new ModifierCommercial();
            mc.Show(this);
            this.Hide();
        }

        private void listView1_Commerciaux_MouseClick(object sender, MouseEventArgs e)
        {
            Visualiser.Enabled = true;
             ApplicationState.id_commercial = listView1_Commerciaux.SelectedItems[0].SubItems[0].Text;
            Console.WriteLine(ApplicationState.id_commercial);
        }

        private void button1_rechercher_Click(object sender, EventArgs e)
        {
            listView1_Commerciaux.Items.Clear();

            if (textBox_id.Text != "")
            {

                string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

                OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
                dbConnection.Open();

                string sqlS1 = "Select c.Num_Commercial, c.Nom, c.Prenom, count(a.num_acheteur) as nombre_acheteur, c.Statut";
                string sqlF1 = " from Commercial c left join acheteur a on a.num_commercial = c.Num_Commercial";
                string sqlW1 = " where c.nom LIKE '" + textBox_id.Text + "%' ";
                string sqlG1 = " group by c.Num_Commercial, c.Nom, c.Prenom, c.Statut";
                string sql = sqlS1 + sqlF1 + sqlW1 + sqlG1;

                OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {


                    string[] ligne = { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetInt32(3).ToString(), reader.GetString(4) };
                    ListViewItem lvi = new ListViewItem(ligne);
                    listView1_Commerciaux.Items.Add(lvi);
                }
                reader.Close();
            }
            else
            {

                if (checkBox_actif.Checked == true)
                {
                    string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

                    OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
                    dbConnection.Open();

                    string sqlS1 = "Select c.Num_Commercial, c.Nom, c.Prenom, count(a.num_acheteur) as nombre_acheteur, c.Statut";
                    string sqlF1 = " from Commercial c left join acheteur a on a.num_commercial = c.Num_Commercial";
                    string sqlW1 = " where c.Statut = 'ACTIF'";
                    string sqlG1 = " group by c.Num_Commercial, c.Nom, c.Prenom, c.Statut";
                    string sql = sqlS1 + sqlF1 + sqlW1 + sqlG1;

                    OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                        string[] ligne = { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetInt32(3).ToString(), reader.GetString(4) };
                        ListViewItem lvi = new ListViewItem(ligne);
                        listView1_Commerciaux.Items.Add(lvi);
                    }
                    reader.Close();
                }

                if (checkBox1.Checked == true)
                {
                    string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

                    OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
                    dbConnection.Open();

                    string sqlS1 = "Select c.Num_Commercial, c.Nom, c.Prenom, count(a.num_acheteur) as nombre_acheteur, c.Statut";
                    string sqlF1 = " from Commercial c left join acheteur a on a.num_commercial = c.Num_Commercial";
                    string sqlW1 = " where c.Statut = 'ANCIEN EMPLOYE'";
                    string sqlG1 = " group by c.Num_Commercial, c.Nom, c.Prenom, c.Statut";
                    string sql = sqlS1 + sqlF1 + sqlW1 + sqlG1;

                    OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                        string[] ligne = { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetInt32(3).ToString(), reader.GetString(4) };
                        ListViewItem lvi = new ListViewItem(ligne);
                        listView1_Commerciaux.Items.Add(lvi);
                    }
                    reader.Close();
                }
            }
        
        
    }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
