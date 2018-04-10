using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTImmo_2018
{
    public partial class Modifier_Bien : Form
    {
        private int visite;

        public Modifier_Bien()
        {
            InitializeComponent();
        }
        
		private void Modifier_Bien_Load(object sender, EventArgs e)
        {
			
			string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
			OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
			dbConnection.Open();
			string sql = "select b.code_bien, b.surface_habitable, b.surface_parcelle, b.nb_piéces, b.nb_chambres, b.nb_Salle_de_bain, b.garage, b.cave, b.prix_vendeur, b.adresse, b.date_Mise_en_Vente, b.commentaire, b.statut,  vi.nom_ville, vi.code_postal, ve.nom_client, ve.prénom_client, ve.téléphone, ve.e_mail from bien b left join ville vi on vi.code_ville = b.code_ville left join vendeur ve on ve.num_client = b.num_client where b.code_bien = '" + ApplicationState.id_bien + "' ";

			OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
			OleDbDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{

				textBox1.Text = reader.GetInt16(0).ToString();
				textBox2.Text = reader.GetInt32(1).ToString();
				textBox3.Text = reader.GetInt32(2).ToString();
				numericUpDown1.Value = reader.GetInt32(3);
				numericUpDown2.Value = reader.GetInt32(4);
				numericUpDown3.Value = reader.GetInt32(5);
				if (reader.GetBoolean(6) == true) Garage.Checked = true;
				if (reader.GetBoolean(7) == true) Cave.Checked = true;
				textBox4.Text = reader.GetInt32(8).ToString();
				dateTimePicker1.Text = reader.GetDateTime(10).ToString();
				textBox12.Text = reader.GetString(9);
				if (reader.GetString(12) == "D") Disponible.Checked = true;
				if (reader.GetString(12) == "S") Sous_Sein.Checked = true;
				if (reader.GetString(12) == "V") Vendu.Checked = true;
				if (reader.GetString(12) == "R") Retire.Checked = true;
                textBox9.Text = reader.GetString(11);
				textBox11.Text = reader.GetString(13);
				textBox10.Text = reader.GetValue(14).ToString();		
			}
			reader.Close();

            string sql1 = "Select count (v.code_visite) nb_visite from bien b left join proposition p on p.code_bien = b.code_bien left join visite v on v.code_proposition = p.code_proposition where b.code_bien = '" + textBox1.Text + "' ";
            OleDbCommand cmd1 = new OleDbCommand(sql1, dbConnection);
            OleDbDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                textBox5.Text = reader1.GetValue(0).ToString();
            }
            reader1.Close();

        }

		

		#region Button Supprimer 
		private void button1_Click(object sender, EventArgs e)
		{
            
            if (int.Parse(textBox5.Text) != 0 )
            {
                
                MessageBox.Show("Vous ne pouvez pas supprimer ce bien");
            }
            else
            {
                string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();
  
            string sql1 = "update bien set DATE_SUPPRESSION=SYSDATETIME() where CODE_BIEN= '" + textBox1.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql1, dbConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("supprimé");
           
            }
        }
        #endregion




        private void Button_Valider_MouseClick(object sender, MouseEventArgs e)
        {
            //string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            DateTime a = dateTimePicker1.Value;
            string statuts = " ";
            if (Disponible.Checked == true)
            {
                statuts = "D";
                Sous_Sein.Checked = false;
                Retire.Checked = false;
                Vendu.Checked = false;
            }

            else if (Sous_Sein.Checked == true)
            {
                statuts = "S";
                Disponible.Checked = false;
                Vendu.Checked = false;
                Retire.Checked = false;

            }


            else if (Vendu.Checked == true)
            {
                statuts = "V";
                Disponible.Checked = false;
                Sous_Sein.Checked = false;
                Retire.Checked = false;
            }


            else if (Retire.Checked == true)
            {
                statuts = "R";
                Disponible.Checked = false;
                Sous_Sein.Checked = false;
                Vendu.Checked = false;
            }

            string garage = " ";
            string cave = " ";

            if (Garage.Checked == true)
            {
                garage = "true";
            }

            if (Cave.Checked == true)
            {
                cave = "true";
            }
            string sql = "UPDATE Bien SET Surface_habitable ='" + textBox2.Text + "', Surface_parcelle ='" + textBox3.Text + "' ,Nb_piéces ='" + numericUpDown1.Value + "', Nb_chambres ='" + numericUpDown2.Value + "' , Nb_Salle_de_bain ='" + numericUpDown3.Value + "' , Garage ='" + garage + "' , Cave ='" + cave + "' , Prix_vendeur ='" + textBox4.Text + "' ,Adresse ='" + textBox12.Text + "', Date_Mise_en_Vente = '" + dateTimePicker1.Value + "' ,Commentaire = '" + textBox9.Text + "',Statut = '" + statuts + "'  , code_ville = (select code_ville from ville where upper(nom_ville) = '" + textBox11.Text + "' and Code_Postal = '" + textBox10.Text + "') WHERE Code_bien = '" + textBox1.Text + "' ";


            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");

            textBox1.Text = ApplicationState.id_bien;
            Fiche_Bien fb = new Fiche_Bien();
            fb.Show(this);
            this.Hide();
        }

        private void Button_Annuler_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = ApplicationState.id_bien;
            Fiche_Bien fb = new Fiche_Bien();
            fb.Show(this);
            this.Hide();
        }
    }
}
