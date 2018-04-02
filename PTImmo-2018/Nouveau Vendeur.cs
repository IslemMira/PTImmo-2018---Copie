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
            string sql2 = "VALUES("+textBox1_Nom.Text+", "+textBox2_Prenom.Text+", "+textBox12_Adresse.Text+","+Convert.ToInt32(textBox3_Telephone)+","+textBox4_E_Mail.Text+","+textBox1_codeVille.Text+", (SELECT v.code_ville from VILLE v where v.NOM_VILLE LIKE 'Bordeaux'));";

            string sql = sql1 + sql2;

            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");

			FicheVendeur fv = new FicheVendeur();
			fv.Show(this);
			this.Hide();

        }

        private void Annuler_NouveauVendeur(object sender, EventArgs e)
        {
            FormAcceuil Accueil = new FormAcceuil();
            Accueil.Show(this);
            this.Hide();
        }

        


    }
}
