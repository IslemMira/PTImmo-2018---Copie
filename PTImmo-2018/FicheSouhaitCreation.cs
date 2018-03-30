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

            string sql1 = "INSERT Into Souhait(NUM_ACHETEUR, SURFACE_HABITABLE_min, SURFACE_PARCELLE_min, NB_PIECES_min, Prix_max, STATUT, CODE_VILLE)";
            string sql2 = "VALUES(" + Convert.ToInt32(textBox_SurfaceHabitable.Text) + "," + Convert.ToInt32(textBox_SurfaceParcelle.Text) + "," + Convert.ToInt32(nbPieces.Text) + ",'EN COURS', " + Convert.ToInt32(textBox_Ville.Text) + ");";

            string sql = sql1 + sql2;

            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);

        }

        private void Annuler_CreationSouhait(object sender, EventArgs e)
        {
            visualiser_acheteur va = new visualiser_acheteur();
            va.Show(this);
            this.Hide();
        }

        private void Ajouter_VilleSouhait(object sender, EventArgs e)
        {

        }


    }
}
