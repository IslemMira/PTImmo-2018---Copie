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
    public partial class Ajouter_commercial : Form
    {
        public Ajouter_commercial()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();
            string sql1 = "Insert into Commercial (Nom, Prenom, Telephone_Fixe_Pro, Telephone_Portable_Pro, Telephone_Prive, Email, Statut)";
            string sql2 = "values("+textBox1_Nom.Text+","+textBox1_Prenom.Text+","+Convert.ToInt32(textBox1_FixePro.Text)+","+ Convert.ToInt32(textBox1_MobilePro.Text)+","+ Convert.ToInt32(textBox1_Tel_Prive.Text)+","+textBox1_Email.Text+",'ACTIF') ";
            string sql = sql1 + sql2;

            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);


        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
