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


//work in progress : liste historique visites  // Arina


namespace PTImmo_2018
{
	public partial class Fiche_Bien : Form
	{
		

		public Fiche_Bien()
		{
            InitializeComponent();

           
        }
		

		private void button_FicheVendeurConsultationBien_Click(object sender, EventArgs e)
		{
            ApplicationState.id_vendeur = textBox2.Text;
			FicheVendeur fv = new FicheVendeur();
			fv.Show(this);
			this.Hide();
		}

		#region Button Modifier Bien
		private void button1_Modifier_Bien_Click(object sender, EventArgs e)
		{
			ApplicationState.id_bien = textBox1.Text;
			Modifier_Bien mb = new Modifier_Bien();
			mb.Show(this);
			this.Hide();
		}
        #endregion

        private void Fiche_Bien_Load_1(object sender, EventArgs e)
        {
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql = "select b.code_bien, b.surface_habitable, b.surface_parcelle, b.nb_piéces, b.nb_chambres, b.nb_Salle_de_bain, b.garage, b.cave, b.prix_vendeur, b.date_Mise_en_Vente, b.commentaire, b.statut, b.adresse, vi.nom_ville, vi.code_postal, ve.Num_Client from bien b left join ville vi on vi.code_ville = b.code_ville left  join vendeur ve on ve.num_client = b.num_client where b.code_bien = '" + ApplicationState.id_bien +"' ";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                textBox1.Text = reader.GetInt16(0).ToString();
                textBox_VisSourfaceHabitableBien.Text = reader.GetInt32(1).ToString();
                textBox_VisSurfaceParcelleBien.Text = reader.GetInt32(2).ToString();
                VisNbPiecesBien.Text = reader.GetInt32(3).ToString();
                VisNbChambresBien.Text = reader.GetInt32(4).ToString();
                VisNbSDBBien.Text = reader.GetInt32(5).ToString();
                if (reader.GetBoolean(6) == true) checkBox_Garage.Checked = true;
                if (reader.GetBoolean(7) == true) checkBox_Cave.Checked = true;
                textBox_AjPrixVendeurBien.Text = reader.GetInt32(8).ToString();
                Date.Text = reader.GetDateTime(9).ToString();
                textBox_VisCommentaireBien.Text = reader.GetString(10);
                if (reader.GetString(11) == "D") checkBox_VisDispoBien.Checked = true;
                if (reader.GetString(11) == "S") checkBox_VisSousSeingBien.Checked = true;
                if (reader.GetString(11) == "V") checkBox_VisVenduBien.Checked = true;
                if (reader.GetString(11) == "R") checkBox_VisRetireBien.Checked = true;
                textBox_VisRueBien.Text = reader.GetString(12);
                textBox_VisVilleBien.Text = reader.GetString(13);
                textBox_VisCPBien.Text = reader.GetInt32(14).ToString();
                textBox2.Text = reader.GetValue(15).ToString();
                
            }
            reader.Close();

          
            string sql1 = "Select count (v.code_visite) nb_visite from bien b left join proposition p on p.code_bien = b.code_bien left join visite v on v.code_proposition = p.code_proposition where b.code_bien = '" + textBox1.Text + "' ";
            OleDbCommand cmd1 = new OleDbCommand(sql1, dbConnection);
            OleDbDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                textBox3.Text = reader1.GetValue(0).ToString();
            }
            reader1.Close();
        }

        private void Button_Fermer_Click(object sender, EventArgs e)
        {
            liste_des_biens ldb = new liste_des_biens();
            ldb.Show(this);
            this.Hide();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            FormAcceuil fa = new FormAcceuil();
            fa.Show(this);
            this.Hide();
        }
    }
}

