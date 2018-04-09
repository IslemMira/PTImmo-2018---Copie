using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTImmo_2018
{
    public partial class Nouveau_bien : Form
    {
        public Nouveau_bien()
        {

            OleDbConnection dbConnection = new OleDbConnection(ApplicationState.ChaineBd);
            dbConnection.Open();
            InitializeComponent();
            string sql = "select Code_Ville, Nom_Ville from Ville  ";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Code_Ville", typeof(string));
            dt.Columns.Add("Nom_Ville", typeof(string));
            //dt.Columns.Add("Prenom", typeof(string));

            dt.Load(reader);

            comboBox1.ValueMember = "Code_Ville";
            comboBox1.DisplayMember = "Nom_Ville";
            comboBox1.DataSource = dt;
            reader.Close();

        }

        private void Button_Valider_Click(object sender, EventArgs e)
        {
            #region insertion du bien
            OleDbConnection dbConnection = new OleDbConnection(ApplicationState.ChaineBd);
            dbConnection.Open();

            string sql1 = "INSERT Into Bien (SURFACE_HABITABLE, SURFACE_PARCELLE, NB_PIéCES, NB_CHAMBRES, NB_SALLE_DE_BAIN, GARAGE, CAVE, PRIX_VENDEUR, ADRESSE, DATE_MISE_EN_VENTE, COMMENTAIRE, STATUT, CODE_VILLE, NUM_CLIENT)";
            string sql2 = "VALUES ('" + textBox_AjSurfaceHabitableBien.Text + "','" + textBox_AjSurfaceParcelleBien.Text + "','" + nbPiecesBien.Text + "','" + nbChambreBien.Text + "','" + nbSDBien.Text + "', '" + checkBox_GarageOuiBien.Checked + "', '" + checkBoxCaveOuiBien.Checked + "', '" + textBox_AjPrixVendeurBien.Text + "','" + textBox_AjRueBien.Text.Replace("'","''") + "','" + dateTimePicker1.Value + "', '" + textBox_AjCommentaireBien.Text + "', 'D',(SELECT v.code_ville from VILLE v where v.NOM_VILLE LIKE '" + textBox_AjVilleBien.Text + "' AND v.code_postal like '" + textBox_AjCPBien.Text + "'),'" + textBox_AjCodeVendeur.Text + "' ) ";
            string sql = sql1 + sql2;


            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            cmd.ExecuteNonQuery();

            #endregion
            #region  mail de notification aux commerciaux

            MailMessage email = new MailMessage();
            email.From = new MailAddress("ImmoJackyTeam@gmail.com");
            string sqlMailCommerciaux = "SELECT Email from COMMERCIAL";
            cmd = new OleDbCommand(sqlMailCommerciaux, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                email.To.Add(new MailAddress(reader.GetString(0)));

            }
            reader.Close();
            email.To.Add(new MailAddress("gyzmogato@gmail.com"));
            email.IsBodyHtml = false;
            email.Subject = "Arrivée d'un nouveau Bien";
            email.Body = "Description du Bien : \n Nom vendeur: " + textBox_AjNomVendeur.Text.Replace(" ","") + " " + textBox_AjPrenomVendeur.Text.Replace(" ","") + "\n Adresse du bien: " + textBox_AjRueBien.Text + "\n " + textBox_AjVilleBien.Text +" "+ textBox_AjCPBien.Text + "\n Prix : " + textBox_AjPrixVendeurBien.Text  + "\n Surface habitable : " + textBox_AjSurfaceHabitableBien.Text + "\n Surface parcelle : " + textBox_AjSurfaceParcelleBien.Text + "\n Nb Pièces: " + nbPiecesBien.Value.ToString() + "\n Nb Chambres : " + nbChambreBien.Value.ToString() + "\n Nb Sdb: " + nbSDBien.Value.ToString() + "\n Commentaire :" + textBox_AjCommentaireBien.Text;
            Console.WriteLine(email.Body);
            SmtpClient smtp = new SmtpClient();
           
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("ImmoJackyTeam", "ImmoBilly123");
            smtp.Send(email);




            #endregion
            MessageBox.Show("Saved");

            FicheVendeur fv = new FicheVendeur();
            fv.Show(this);
            this.Hide();

        }

        private void Annuler_NouveauBien(object sender, EventArgs e)
        {
            FicheVendeur fv = new FicheVendeur();
            fv.Show(this);
            this.Hide();
        }



        private void Nouveau_bien_Load(object sender, EventArgs e)
        {


            OleDbConnection dbConnection = new OleDbConnection(ApplicationState.ChaineBd);
            dbConnection.Open();

            string sqlS1 = "Select v.Num_Client, v.Nom_Client, v.Prénom_Client, v.Téléphone, v.E_mail, v.adresse, vi.nom_ville, vi.code_postal";
            string sqlF1 = " from Vendeur v left join ville vi on vi.code_ville = v.code_ville  where v.num_client = '" + ApplicationState.id_vendeur + "' ";
            string sql = sqlS1 + sqlF1;

            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox_AjCodeVendeur.Text = reader.GetValue(0).ToString();
                textBox_AjNomVendeur.Text = reader.GetString(1);
                textBox_AjPrenomVendeur.Text = reader.GetString(2);
                textBox_AjTelephoneVendeur.Text = reader.GetInt32(3).ToString();
                textBox_AjEmailVendeur.Text = reader.GetString(4);
                textBox_AjRueVendeur.Text = reader.GetString(5);
                textBox_AjVilleVendeur.Text = reader.GetString(6);
                textBox_AjCPVendeur.Text = reader.GetInt32(7).ToString();
            }
            reader.Close();
        }


    }
}
