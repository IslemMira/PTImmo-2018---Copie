﻿using System;
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
    public partial class PropositionBien : Form
    {
        static string id_bien_a_visualizer;
        public PropositionBien()
        {
            InitializeComponent();
        }

        private void PropositionBien_Load(object sender, EventArgs e)
        {
            string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql = "select a.NOM_ACHETEUR, a.PRÉNOM_ACHETEUR,s.CODE_SOUHAIT, v.NOM_VILLE, s.SURFACE_HABITABLE_MIN, s.SURFACE_PARCELLE_MIN, s.NB_PIECES_MIN, s.PRIX_MAX, s.STATUT from SOUHAIT s left join ACHETEUR a on a.NUM_ACHETEUR = s.NUM_ACHETEUR left join VILLE v on v.CODE_VILLE = s.CODE_VILLE where s.Code_Souhait =  '" + visualiser_acheteur.id_souhait + "' ";


            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox3.Text = reader.GetString(0);
                textBox4.Text = reader.GetString(1);
                textBox15.Text = reader.GetInt32(2).ToString();
                textBox1.Text = reader.GetString(3);
                numericUpDown1.Text = reader.GetInt32(4).ToString();
                numericUpDown2.Text = reader.GetInt32(5).ToString();
                numericUpDown3.Text = reader.GetInt32(6).ToString();
                //numericUpDown4.TextAlign = reader.GetInt32().ToString(); WHERE ARE MY TOILETS???
                textBox2.Text = reader.GetInt32(7).ToString();
            }
            reader.Close();
        }

        private void RechercheListePropositions_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql = "select b.code_bien, b.prix_vendeur from bien b where b.surface_habitable >= " + numericUpDown1.Text + "and b.surface_parcelle >=" + numericUpDown2.Text + "and b.nb_piéces >=" + numericUpDown3.Text + "and b.prix_vendeur <=" + textBox2.Text + "and statut in ('D','S')  ; ";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetInt16(0));
                Console.WriteLine(reader.GetInt32(1));


                string[] row = { reader.GetInt16(0).ToString(), reader.GetInt32(1).ToString() };
                ListViewItem lbp = new ListViewItem(row);
                listView1.Items.Add(lbp);
            }
            reader.Close();
        }

        private void Proposer_Click(object sender, EventArgs e)
        {
            string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql1 = "Insert into Proposition (Code_Souhait, Code_Bien, Date) ";
            string sql2 = "values('" +textBox15.Text  + "','" + id_bien_a_visualizer + "' , '"+ DateTime.Now+"')";

            string sql = sql1 + sql2;

            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Proposition sauvegardée");
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            visualiser_acheteur va = new visualiser_acheteur();
            va.Show(this);
            this.Hide();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            id_bien_a_visualizer = listView1.SelectedItems[0].SubItems[0].Text;
            Console.WriteLine(listView1.SelectedItems[0].SubItems[0].Text);

            string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql = "select SURFACE_HABITABLE,SURFACE_PARCELLE,NB_PIÉCES, NB_SALLE_DE_BAIN, GARAGE, cave, PRIX_VENDEUR,ADRESSE, COMMENTAIRE from BIEN where code_bien =" + id_bien_a_visualizer+ "; ";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox6.Text = reader.GetInt32(0).ToString();
                textBox7.Text = reader.GetInt32(1).ToString();
                textBox8.Text = reader.GetInt32(2).ToString();
                textBox9.Text = reader.GetInt32(3).ToString();
                if (reader.GetBoolean(4) == true) checkBox4.Checked = true;
                if (reader.GetBoolean(5) == true) checkBox3.Checked = true;
                textBox10.Text = reader.GetInt32(6).ToString();
                textBox11.Text = reader.GetString(7);
                textBox14.Text = reader.GetString(8);
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Liste_des_propositions ldp = new Liste_des_propositions();
            ldp.Show(this);
            this.Hide();
        }
    }
}
