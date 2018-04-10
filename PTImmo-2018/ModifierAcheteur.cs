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
    public partial class ModifierAcheteur : Form
    {
        public ModifierAcheteur()
        {
            InitializeComponent();
        }

        public void ModifierAcheteur_Load(object sender, EventArgs e)
        {
            //string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql = "SELECT nom_Acheteur, prénom_Acheteur, adresse, ville.nom_ville, VILLE.CODE_POSTAL, Téléphone, E_MAIL,  c.Nom, c.Prenom from ACHETEUR left join VILLE on ACHETEUR.Code_Ville = VILLE.Code_Ville join COMMERCIAL c on ACHETEUR.NUM_COMMERCIAL = c.NUM_COMMERCIAL where NUM_ACHETEUR = '" + ApplicationState.id_acheteur + "' ";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox1_codeAcheteur.Text = ApplicationState.id_acheteur;
                textBox_Nom.Text = reader.GetString(0).ToString().Trim();
                textBox_Prénom.Text = reader.GetString(1);
                textBox_Adresse.Text = reader.GetString(2);
                textBox1.Text = reader.GetString(3);
                textBox_CP.Text = reader.GetValue(4).ToString();
                textBox_tel.Text = '0' + reader.GetValue(5).ToString();
                textBox50.Text = reader.GetString(6).Trim();
               comboBox_commercial.Text = reader.GetValue(7).ToString();
            }
            reader.Close();
        }

       
    

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql = "UPDATE ACHETEUR set Nom_Acheteur = '" + textBox_Nom.Text + "', Prénom_Acheteur = '" + textBox_Prénom.Text + "', Adresse = '" + textBox_Adresse.Text + "',  Téléphone = '" + textBox_tel.Text + "' where Num_Acheteur = '" + ApplicationState.id_acheteur + "' ";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");

            visualiser_acheteur va = new visualiser_acheteur();
            va.Show(this);
            this.Hide();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            visualiser_acheteur va = new visualiser_acheteur();
            va.Show(this);
            this.Hide();
        }
    }
}
