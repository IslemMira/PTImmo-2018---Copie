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
    public partial class liste_des_biens : Form
    {
        static string id_bien_a_modifier;
        string statut = "d";


        public liste_des_biens()
        {
            InitializeComponent();
            
        }

        
        private void Rechercher_Click(object sender, EventArgs e)
        {
            
            listView1.Items.Clear();
            string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();
            
            string sql = "select b.code_bien,b.adresse,b.statut, count(v.code_visite) nb_visite from bien b left join proposition p on p.code_bien = b.code_bien left join visite v on v.code_proposition = p.code_proposition left join vendeur ve on ve.num_client = b.num_client where ve.nom_client like '%" + textBox1.Text+  "%' and b.statut like '%"+ statut+ "' group by b.code_bien,b.adresse,b.statut; ";

            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string[] row = { reader.GetInt16(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetInt32(3).ToString() };
                ListViewItem lvi = new ListViewItem(row);
                listView1.Items.Add(lvi);
                

            }
            reader.Close();
            
        }

        private void Disponible_CheckedChanged(object sender, EventArgs e)
        {
            if (Disponible.Checked == true)
            {
                SousS.Checked = false;
                Vendu.Checked = false;
                Retire.Checked = false;
                statut = "d";
            }
            else if (Retire.Checked == false && SousS.Checked == false && Vendu.Checked == false)
            {
                Disponible.Checked = true;
            }
        }

        private void SousS_CheckedChanged(object sender, EventArgs e)
        {
            if (SousS.Checked == true)
            {
                Disponible.Checked = false;
                Vendu.Checked = false;
                Retire.Checked = false;
                statut = "s";
            }
            else if (Disponible.Checked == false && Retire.Checked == false && Vendu.Checked == false)
            {
                SousS.Checked = true;
            }
        }

        private void Vendu_CheckedChanged(object sender, EventArgs e)
        {
            if(Vendu.Checked== true)
            {
                Disponible.Checked = false;
                SousS.Checked = false;
                Retire.Checked = false;
                statut = "v";
            }
            else if (Disponible.Checked == false && SousS.Checked == false && Retire.Checked == false)
            {
                Vendu.Checked = true;
            }
        }

        private void Retire_CheckedChanged(object sender, EventArgs e)
        {
            if (Retire.Checked == true)
            {
                Disponible.Checked = false;
                SousS.Checked = false;
                Vendu.Checked = false;
                statut = "r";
            } else if(Disponible.Checked==false && SousS.Checked==false && Vendu.Checked == false)
            {
                Retire.Checked = true;
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            id_bien_a_modifier = listView1.SelectedItems[0].SubItems[0].Text;
            Console.WriteLine(listView1.SelectedItems[0].SubItems[0].Text);
        }
    }
}
