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

// done

namespace PTImmo_2018
{
    public partial class ModifierCommercial : Form
    {
        public ModifierCommercial()
        {
            InitializeComponent();
        }

		private void button_annuler_Click(object sender, EventArgs e)
		{
			Recherche_Commerciaux rc = new Recherche_Commerciaux();
			rc.Show(this);
			this.Hide();
		}

		private void ModifierCommercial_Load(object sender, EventArgs e)
		{
           
                string nomBase = "IMMOBILLY_JACKYTEAM";
                string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
                OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
                dbConnection.Open();

                string sql = "SELECT c.NUM_COMMERCIAL, c.NOM, c.PRENOM, c.TELEPHONE_FIXE_PRO, c.TELEPHONE_PORTABLE_PRO, c.TELEPHONE_PRIVE, c.EMAIL, c.STATUT from COMMERCIAL c where c.NUM_COMMERCIAL = '" + ApplicationState.id_commercial + "' ";
                OleDbCommand cmd1 = new OleDbCommand(sql, dbConnection);
                OleDbDataReader reader1 = cmd1.ExecuteReader();

                this.comboBox1.SelectedIndex = 0;

            while (reader1.Read())
                {
                    textBox1_numCom.Text = reader1.GetInt32(0).ToString();
                    textBox1_Nom.Text = reader1.GetString(1);
                    textBox1_Prenom.Text = reader1.GetString(2);
                    textBox1_FixePro.Text = reader1.GetValue(3).ToString();
                    textBox1_MobilePro.Text = reader1.GetValue(4).ToString();
                    textBox1_Tel_Prive.Text = reader1.GetValue(5).ToString();
                    textBox1_Email.Text = reader1.GetString(6);
                    if (reader1.GetString(7) == "ACTIF") comboBox1.Text = "ACTIF";
                    if (reader1.GetString(7) == "ANCIEN EMPLOYE") comboBox1.Text = "ANCIEN EMPLOYE";
                }

                reader1.Close();
		}

        private void button_valider_Click_1(object sender, EventArgs e)
        {
            string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql = "Update Commercial  set NOM = '" + textBox1_Nom.Text.Replace("'", "''") + "', PRENOM = '" + textBox1_Prenom.Text.Replace("'", "''") + "',  TELEPHONE_FIXE_PRO = '" + textBox1_FixePro.Text + "',  TELEPHONE_PORTABLE_PRO = '" + textBox1_MobilePro.Text + "' , TELEPHONE_PRIVE = '" + textBox1_Tel_Prive.Text + "', EMAIL = '" + textBox1_Email.Text + "', STATUT ='" + comboBox1.Text + "'   where NUM_COMMERCIAL = '" + textBox1_numCom.Text + "' ";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Saved");

            Recherche_Commerciaux rc = new Recherche_Commerciaux();
            rc.Show(this);
            this.Hide();
        }
    }
}
