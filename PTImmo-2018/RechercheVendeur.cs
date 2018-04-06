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
            listView1_vendeurs.Enabled = true;

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


        }


        private void Visualiser_Click(object sender, EventArgs e)
		{
            FicheVendeur fv = new FicheVendeur();
            fv.Show(this);
            
        }

		private void listView1_vendeurs_MouseClick(object sender, MouseEventArgs e)
		{
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
         
        }
    }
}
