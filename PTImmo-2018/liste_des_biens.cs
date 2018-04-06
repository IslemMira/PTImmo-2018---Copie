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
    public partial class liste_des_biens : Form
    {
        static string id_bien_selectionne;
        string statut = "d";
        


        public liste_des_biens()
        {
            InitializeComponent();

            listView1.Items.Clear();
            Visualiser.Enabled = false;

            //string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql = "select b.CODE_BIEN, b.SURFACE_HABITABLE, b.NB_PIÉCES, b.STATUT,vi.NOM_VILLE, v.NOM_CLIENT, v.PRÉNOM_CLIENT from  Bien b join VENDEUR v on b.NUM_CLIENT = v.NUM_CLIENT join ville vi on b.CODE_VILLE = vi.CODE_VILLE where v.nom_client like '%" + textBox2.Text + "%' and b.statut like '%" + statut + "' ; ";

            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string[] row = { reader.GetInt16(0).ToString(), reader.GetInt32(1).ToString(), reader.GetInt32(2).ToString(), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6) };
                ListViewItem lvi = new ListViewItem(row);
                listView1.Items.Add(lvi);


            }
            reader.Close();

        }

        
        private void Rechercher_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            
            //string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();
            
            string sql = "select b.CODE_BIEN, b.SURFACE_HABITABLE, b.NB_PIÉCES, b.STATUT,vi.NOM_VILLE, v.NOM_CLIENT, v.PRÉNOM_CLIENT from  Bien b join VENDEUR v on b.NUM_CLIENT = v.NUM_CLIENT join ville vi on b.CODE_VILLE = vi.CODE_VILLE where v.nom_client like '%" + textBox2.Text + "%' and b.statut like '%" + statut + "' ; ";

            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string[] row = { reader.GetInt16(0).ToString(), reader.GetInt32(1).ToString(), reader.GetInt32(2).ToString(), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6) };
                ListViewItem lvi = new ListViewItem(row);
                listView1.Items.Add(lvi);
                

            }
            reader.Close();
            
        }

        private void Disponible_CheckedChanged(object sender, EventArgs e)
        {
            if (Disponible.Checked == true)
            {
                SousS.Checked = false;
                Vendu.Checked = false;
                Retire.Checked = false;
                statut = "d";
            }
            else if (Retire.Checked == false && SousS.Checked == false && Vendu.Checked == false)
            {
                Disponible.Checked = true;
            }
        }

        private void SousS_CheckedChanged(object sender, EventArgs e)
        {
            if (SousS.Checked == true)
            {
                Disponible.Checked = false;
                Vendu.Checked = false;
                Retire.Checked = false;
                statut = "s";
            }
            else if (Disponible.Checked == false && Retire.Checked == false && Vendu.Checked == false)
            {
                SousS.Checked = true;
            }
        }

        private void Vendu_CheckedChanged(object sender, EventArgs e)
        {
            if(Vendu.Checked== true)
            {
                Disponible.Checked = false;
                SousS.Checked = false;
                Retire.Checked = false;
                statut = "v";
            }
            else if (Disponible.Checked == false && SousS.Checked == false && Retire.Checked == false)
            {
                Vendu.Checked = true;
            }
        }

        private void Retire_CheckedChanged(object sender, EventArgs e)
        {
            if (Retire.Checked == true)
            {
                Disponible.Checked = false;
                SousS.Checked = false;
                Vendu.Checked = false;
                statut = "r";
            } else if(Disponible.Checked==false && SousS.Checked==false && Vendu.Checked == false)
            {
                Retire.Checked = true;
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            Visualiser.Enabled = true;
            id_bien_selectionne = listView1.SelectedItems[0].SubItems[0].Text;
            
        }

		private void Ajouter_Click(object sender, EventArgs e)
		{
			RechercheVendeur rv = new RechercheVendeur();
			rv.Show(this);
			this.Hide();
		}

        private void Visualiser_Click(object sender, EventArgs e)
        {
            ApplicationState.id_bien = id_bien_selectionne;
            Console.WriteLine(ApplicationState.id_bien);
            Fiche_Bien fb = new Fiche_Bien();
            fb.Show(this);
            this.Hide();

        }
    }
}
