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
    public partial class Nouveau_Vendeur : Form
    {
        public Nouveau_Vendeur()
        {
            InitializeComponent();

        }

        private void Valider_NouveauVendeur(object sender, EventArgs e)
        {

            string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();
            string sql1 = "INSERT into Vendeur(Nom_Client, PRÉNOM_Client, Adresse, TÉLÉPHONE, E_MAIL, CODE_VILLE) ";
            string sql2 = " VALUES('"+textBox1_Nom.Text.Replace("'", "''") + "', '"+textBox2_Prenom.Text.Replace("'", "''") + "', '"+textBox12_Adresse.Text.Replace("'", "''") + "','"+textBox3_Telephone.Text+"','"+textBox4_E_Mail.Text + "', (SELECT v.code_ville from VILLE v where v.NOM_VILLE like  '" + textBox1_ville.Text.Replace("'", "''") + "' and v.CODE_POSTAL like '" + textBox10_CP.Text + "'))";

            string sql = sql1 + sql2;

            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");

			RechercheVendeur rv = new RechercheVendeur();
			rv.Show(this);
            this.Hide();

        }

        private void Annuler_NouveauVendeur(object sender, EventArgs e)
        {
            RechercheVendeur rv = new RechercheVendeur();
            rv.Show(this);
            this.Hide();
            
        }
               


    }
}
