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
	public partial class FicheSouhaitCreation : Form
	{
		public FicheSouhaitCreation()
		{
			InitializeComponent();
		}

        private void Validation_Creation_Souhait(object sender, EventArgs e)
        {

            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql1 = "INSERT Into Souhait(NUM_ACHETEUR, SURFACE_HABITABLE_min, SURFACE_PARCELLE_min, NB_PIECES_min, Prix_max, STATUT, CODE_VILLE)";
            string sql2 = " VALUES('" + ApplicationState.id_acheteur + "', '" + textBox_SurfaceHabitable.Text + "','" + textBox_SurfaceParcelle.Text + "','" + nbPieces.Text + "','"+ textBox_Prix.Text + "','EN COURS', (SELECT v.code_ville from VILLE v where v.NOM_VILLE like  '" + textBox_Ville.Text + "' and v.CODE_POSTAL like '" + textBox_CP.Text + "') )";

            string sql = sql1 + sql2;


            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            visualiser_acheteur va = new visualiser_acheteur();
            va.Show(this);
            this.Hide();


        }

        private void Annuler_CreationSouhait(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Ajouter_VilleSouhait(object sender, EventArgs e)
        {

        }

        private void FicheSouhaitCreation_Load(object sender, EventArgs e)
        {
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();
           
        }

   
    }
}
