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
	public partial class ModifierVendeur : Form
	{
		public ModifierVendeur()
		{
			InitializeComponent();
		}

		private void ModifierVendeur_Load(object sender, EventArgs e)
		{
			string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

			OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
			dbConnection.Open();

			string sql = "Select v.Num_Client, v.Nom_Client, v.Prénom_Client, v.Téléphone, v.E_mail, v.adresse, vi.nom_ville, vi.code_postal from Vendeur v left join ville vi on vi.code_ville = v.code_ville  where v.num_client = '" + ApplicationState.id_vendeur + "'  ";
		

			OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
			OleDbDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				textBox1_codeVendeur.Text = reader.GetValue(0).ToString();
				textBox1_Nom.Text = reader.GetString(1);
				textBox2_Prenom.Text = reader.GetString(2);
				textBox3_Telephone.Text = '0' + reader.GetInt32(3).ToString();
				textBox4_E_Mail.Text = reader.GetString(4);
				textBox12_Adresse.Text = reader.GetString(5);
				textBox11_Ville.Text = reader.GetString(6);
				textBox1.Text = reader.GetInt32(7).ToString();
			}
			reader.Close();
		}

		
			

		private void button_annuler_Click(object sender, EventArgs e)
		{
			FicheVendeur fv = new FicheVendeur();
			fv.Show(this);
			this.Hide();
		}

        private void button_valider_MouseClick(object sender, MouseEventArgs e)
        {
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";

            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql = "UPDATE VENDEUR SET Nom_Client = '" + textBox1_Nom.Text + "', Prénom_Client = '" + textBox2_Prenom.Text + "', Téléphone =  '" + textBox3_Telephone.Text + "', E_mail = '" + textBox4_E_Mail.Text + "', Adresse = '" + textBox12_Adresse.Text + "', code_ville = (select code_ville from ville where upper(nom_ville) = '" + textBox11_Ville.Text + "' and Code_Postal = '" + textBox1.Text + "') where Num_Client = '" + ApplicationState.id_vendeur + "'  ";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");

            FicheVendeur fv = new FicheVendeur();
            fv.Show(this);
            this.Hide();
        
    }
    }
}
