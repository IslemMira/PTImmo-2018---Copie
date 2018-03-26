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
    public partial class Nouveau_bien : Form
    {
        public Nouveau_bien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }


        private void Button_Valider_Click(object sender, EventArgs e)
        {

            string sql1 = "INSERT Into Bien (SURFACE_HABITABLE, SURFACE_PARCELLE, NB_PIECES, NB_CHAMBRES, NB_SALLE_DE_BAIN, GARAGE, CAVE, PRIX_VENDEUR, ADRESSE, DATE_MISE_EN_VENTE, COMMENTAIRE, STATUT, CODE_VILLE, NUM_CLIENT)";
            string sql2 = "VALUES (" + Convert.ToInt32(textBox_AjSurfaceHabitableBien.Text) + "," + Convert.ToInt32(textBox_AjSurfaceParcelleBien.Text) + "," + Convert.ToInt32(nbPiecesBien.Text) + "," + nbChambreBien.Text + "," + Convert.ToInt32(nbSDBien.Text) + "," + Convert.ToInt32(textBox_AjCPVendeur.Text) + "," + textBox_AjRueBien.Text + ", " + Convert.tomonthCalendar_AjDateMiseVenteBien + "," + textBox_AjCommentaireBien.Text + ", 'D'," + Convert.ToInt32(textBox_AjCPBien) + "," + textBox_AjCodeVendeur.Text + ",(SELECT v.code_ville from VILLE v where v.NOM_VILLE LIKE " + textBox_AjVilleBien.Text + ")";
            string sql = sql1 + sql2;

            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);

        
        }
    }
}
