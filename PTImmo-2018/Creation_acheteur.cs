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

        private void Valider_Creation_Acheteur(object sender, EventArgs e)
        {
          
            string sql1 = "INSERT into Acheteur(Nom_Acheteur, PRÉNOM_ACHETEUR, Adresse, TÉLÉPHONE, E_MAIL, CODE_VILLE, NUM_COMMERCIAL)";
            string sql2 = "VALUES("+textBox_Nom.Text+","+textBox_Prénom.Text+","+textBox_Adresse.Text+","+Convert.ToInt32(textBox_tel.Text)+","+textBox_email.Text+" ,"+Convert.ToInt32(textBox_CP.Text)+","+Convert.ToInt32(comboBox_commercial.Text)+", (SELECT v.code_ville from VILLE v where v.NOM_VILLE = upper(''), );";

            string sql = sql1 + sql2;

            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
        }
    }
}
