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
        public Modifier_Bien()
        {
            InitializeComponent();
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();
            string sql = "select b.code_bien, b.surface_habitable, b.surface_parcelle, b.nb_piéces, b.nb_chambres, b.nb_Salle_de_bain, b.garage, b.cave, b.prix_vendeur, b.adresse, b.date_Mise_en_Vente, b.commentaire, b.statut, b.adresse, vi.nom_ville, vi.code_postal, ve.nom_client, ve.prénom_client, ve.téléphone, ve.e_mail from bien b left join ville vi on vi.code_ville = b.code_ville left join vendeur ve on ve.num_client = b.num_client where b.code_bien =2  ";

            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime date_mise_en_vente;
                textBox1.Text = reader.GetInt16(0).ToString();
                textBox2.Text = reader.GetInt32(1).ToString();
                textBox3.Text = reader.GetInt32(2).ToString();
                textBox4.Text = reader.GetInt32(8).ToString();
                textBox5.Text = reader.GetString(16);
                textBox7.Text = reader.GetInt32(18).ToString();
                textBox8.Text = reader.GetString(17);
                textBox9.Text = reader.GetString(11);
                textBox12.Text = reader.GetString(13);
                textBox11.Text = reader.GetString(14);
                textBox10.Text = reader.GetInt32(15).ToString();
                numericUpDown1.Value = reader.GetInt32(3);
                numericUpDown2.Value = reader.GetInt32(5);
                numericUpDown3.Value = reader.GetInt32(4);
                //il faut finir le champs de la date
               //DateTime.TryParse(reader.GetString(10), out date_mise_en_vente);
                //dateTimePicker1.Value = date_mise_en_vente;

                if (reader.GetBoolean(6)== true)
                {
                    Garage.Checked = true;
                }

                if(reader.GetBoolean(7)== true)
                {
                    Cave.Checked = true;
                }

                if (reader.GetString(13)== "d")
                {
                    Disponible.Checked = true;
                }
                else if (reader.GetString(13)== "s")
                {
                    Sous_Sein.Checked = true;
                }
                else if (reader.GetString(13) == "v")
                {
                    Vendu.Checked = true;
                }
                else if (reader.GetString(13) == "r")
                {
                   Retire.Checked = true;
                }
            }
            reader.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Modifier_Bien_Load(object sender, EventArgs e)
        {

        }

        private void VALIDER_Click(object sender, EventArgs e)
        {
            string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            DateTime a = dateTimePicker1.Value;
            string statuts=" ";
            if (Disponible.Checked == true)
            {
                statuts = "d";
                Sous_Sein.Checked = false;
                Retire.Checked = false;
                Vendu.Checked = false;
            }

         else if(Sous_Sein.Checked == true)
            {
                statuts = "s";
                Disponible.Checked = false;
                Vendu.Checked = false;
                Retire.Checked = false;

            }

           
           else if(Vendu.Checked == true)
            {
                statuts = "v";
                Disponible.Checked = false;
                Sous_Sein.Checked = false;
                Retire.Checked = false;
            }

            
            else if(Retire.Checked == true)
            {
                statuts = "r";
                Disponible.Checked = false;
                Sous_Sein.Checked = false;
                Vendu.Checked = false;
            }

            string garage =" ";
            string cave = " ";

            if (Garage.Checked == true)
            {
                garage = "true";
            }
           
            if (Cave.Checked == true)
            {
                cave = "true";
            }
            string sql = "UPDATE Bien SET Surface_habitable ="+textBox2.Text +", Surface_parcelle ="+textBox3.Text+" ,Nb_pieces ="+ numericUpDown1.Value+ ", Nb_chambres =" + numericUpDown3.Value + " ,Nb_Salle_de_bain =" + numericUpDown2.Value + " ,Garage ="+ true+" ,Cave ="+true+" ,Prix_vendeur =" + textBox4.Text +" ,Adresse =" + textBox12.Text + " ' ', Date_Mise_en_Vente = "+dateTimePicker1.Value+" ,Commentaire = "+ textBox9.Text +" ' ',Statut = "+ statuts +" ' ', Adresse = "+textBox12.Text+ "' ', code_ville = ((select code_ville from ville where upper(nom_ville) = " + textBox11.Text + ")WHERE Code_bien = "+textBox1.Text+" ";


            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            

        }
    }
}
