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
    public partial class Visualiser_Acheteur : Form
    {
        public Visualiser_Acheteur()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Visualiser_Acheteur_Load(object sender, EventArgs e)
        {
            string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            

            string sql = "SELECT num_acheteur, nom_Acheteur, prénom_Acheteur, adresse, téléphone, E_MAIL, VILLE.Code_Postale from ACHETEUR left join VILLE on ACHETEUR.Code_Ville = VILLE.Code_Ville";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //textBox1_Nom.Text = reader.GetString(1);
                //textBox2_Prenom.Text = reader.GetString(2);
                //textBox3_Telephone.Text = reader.GetInt32(3).ToString();
                //textBox4_E_Mail.Text = reader.GetString(4);
                //textBox12_Adresse.Text = reader.GetString(5);
                //textBox11_Ville.Text = reader.GetString(6);
                //textBox10_CP.Text = reader.GetInt32(7).ToString();
            }
            reader.Close();


            

        }
    }
}
