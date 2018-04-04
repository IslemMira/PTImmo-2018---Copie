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
    public partial class Creation_acheteur : Form
    {
        public Creation_acheteur()
        {
            InitializeComponent();
        }


        private void Annuler_CreationVendeur(object sender, EventArgs e)
        {
            FormAcceuil Accueil = new FormAcceuil();
            Accueil.Show(this);
            this.Hide();
        }

        private void button_valider_MouseClick(object sender, MouseEventArgs e)
        {
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();
            string sql1 = "INSERT into Acheteur(Nom_Acheteur, PRÉNOM_ACHETEUR, Adresse, TÉLÉPHONE, E_MAIL, CODE_VILLE, NUM_COMMERCIAL)";
            string sql2 = "VALUES('" + textBox_Nom.Text + "','" + textBox_Prénom.Text + "','" + textBox_Adresse.Text + "','" +textBox_tel.Text + "','" + textBox_email.Text + "' , (SELECT v.code_ville from VILLE v where v.NOM_VILLE like  '" + textBox1.Text + "' and v.CODE_POSTAL like '" +textBox_CP.Text + "'),(select c.NUM_COMMERCIAL from COMMERCIAL c where NOM LIKE '" + comboBox_commercial.Text + "' ) )";

            string sql = sql1 + sql2;

            
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            RechercheAcheteur ra = new RechercheAcheteur();
            ra.Show(this);
            this.Hide();
        }

        private void Creation_acheteur_Load(object sender, EventArgs e)
        {
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();
            string sql = "select Num_Commercial, Nom, Prenom from COMMERCIAL ";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Num_Commercial", typeof(string));
            dt.Columns.Add("Nom", typeof(string));
            //dt.Columns.Add("Prenom", typeof(string));

            dt.Load(reader);

            comboBox_commercial.ValueMember = "Num_Commercial";
            comboBox_commercial.DisplayMember = "Nom";
            comboBox_commercial.DataSource = dt;
            reader.Close();
        }
    }
}
