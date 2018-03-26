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

            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sqlS1 = "Select c.Num_Commercial, c.Nom, c.Prenom, count(a.num_acheteur) as nombre_acheteur, c.Statut";
            string sqlF1 = " from Commercial c left join acheteur a on a.num_commercial = c.Num_Commercial";
            string sqlG1 = " group by c.Num_Commercial, c.Nom, c.Prenom, c.Statut";
            string sql = sqlS1 + sqlF1 + sqlG1;

            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                
                string[] ligne = { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetInt32(3).ToString(), reader.GetString(4)};
                ListViewItem lvi = new ListViewItem(ligne);
                listView1_Commerciaux.Items.Add(lvi);
            }
            reader.Close();
        }

        private void checkBox_actif_CheckedChanged(object sender, EventArgs e)
        {
            listView1_Commerciaux.Clear();

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

                string[] ligne = { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetInt32(3).ToString(), reader.GetString(4) };
                ListViewItem lvi = new ListViewItem(ligne);
                listView1_Commerciaux.Items.Add(lvi);
            }
            reader.Close();
        }
    }
}
