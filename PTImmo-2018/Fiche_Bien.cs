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
    public partial class Fiche_Bien : Form
    {
        public Fiche_Bien()
        {
            InitializeComponent();
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();



            string sql = "select b.code_bien, b.surface_habitable, b.surface_parcelle, b.nb_piéces, b.nb_chambres, b.nb_Salle_de_bain, b.garage, b.cave, b.prix_vendeur, b.date_Mise_en_Vente, b.commentaire, b.statut, b.adresse, vi.nom_ville, vi.code_postal, ve.nom_client, ve.prénom_client, ve.téléphone, ve.e_mail from bien b left join ville vi on vi.code_ville = b.code_ville left  join vendeur ve on ve.num_client = b.num_client where b.code_bien =2  ";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt16(0));
                textBox1.Text = reader.GetInt16(0).ToString();
                textBox_VisSourfaceHabitableBien.Text = reader.GetInt32(1).ToString();
                textBox_VisSurfaceParcelleBien.Text = reader.GetInt32(2).ToString();
                VisNbPiecesBien.Text = reader.GetInt32(3).ToString();
                VisNbSDBien.Text = reader.GetInt32(4).ToString();
                VisNbSDBien.Text = reader.GetInt32(5).ToString();
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
                textBox_VisCPBien.Text = reader.GetInt32(14).ToString() ;
                textBox_VisNomVendeur.Text = reader.GetString(15);
                textBox_VisPrenomVendeur.Text = reader.GetString(16);
                textBox_VisTelephoneVendeur.Text = reader.GetInt32(17).ToString();
                textBox_VisEmailVendeur.Text = reader.GetString(18);
            }
            reader.Close(); 
        }
        private void Fiche_Bien_Load(object sender, EventArgs e)
        {

            
            

        }

    
    }
}
