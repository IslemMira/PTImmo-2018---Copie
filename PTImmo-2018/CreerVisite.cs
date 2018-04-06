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
    public partial class CreerVisite : Form
    {
        public CreerVisite()
        {
            InitializeComponent();
        }

        private void CreerVisite_Load(object sender, EventArgs e)
        {
            //string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql = "select Num_Commercial, Nom, Prenom from COMMERCIAL ";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Num_Commercial", typeof(string));
            dt.Columns.Add("Nom", typeof(string));
            //dt.Columns.Add("Prenom", typeof(string));

            dt.Load(reader);

            comboBox_Commercial.ValueMember = "Num_Commercial";
            comboBox_Commercial.DisplayMember = "Nom";
            comboBox_Commercial.DataSource = dt;
            reader.Close();
            Console.WriteLine(ApplicationState.id_proposition);

            string sql1 = "Select a.nom_acheteur, a.PRÉNOM_ACHETEUR, b.CODE_BIEN, b.SURFACE_HABITABLE, b.SURFACE_PARCELLE, b.NB_PIÉCES, b.NB_CHAMBRES, b.NB_SALLE_DE_BAIN,b.GARAGE, b.CAVE,b.PRIX_VENDEUR,p.date, a.Num_acheteur, b.ADRESSE,vi.NOM_VILLE, vi.CODE_POSTAL from ACHETEUR a inner join souhait s on s.NUM_ACHETEUR = a.NUM_ACHETEUR inner join PROPOSITION p on s.CODE_SOUHAIT = p.CODE_SOUHAIT inner join bien b on p.CODE_BIEN = b.CODE_BIEN  inner join VILLE vi on b.CODE_VILLE = vi.CODE_VILLE where p.CODE_PROPOSITION = '" + ApplicationState.id_proposition + "' ";
            OleDbCommand cmd1 = new OleDbCommand(sql1, dbConnection);
            OleDbDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                textBox_Nom.Text = reader1.GetString(0);
                textBox_Prénom.Text = reader1.GetString(1);
                IdBien.Text = reader1.GetInt16(2).ToString();
                textBox_SurfHab.Text = reader1.GetInt32(3).ToString();
                textBox_SurfParc.Text = reader1.GetInt32(4).ToString();
                textBox_NbPiece.Text = reader1.GetInt32(5).ToString();
                textBox_NbChambre.Text = reader1.GetInt32(6).ToString();
                textBox_NbSdb.Text = reader1.GetInt32(7).ToString();
                if (reader1.GetBoolean(8) == true) checkBox_Garage.Checked = true;
                if (reader1.GetBoolean(9) == true) checkBox_Cave.Checked = true;
                textBox_Prix.Text = reader1.GetInt32(10).ToString();
                dateTimePicker2.Text = reader1.GetDateTime(11).ToString();
                this.dateTimePicker2.Enabled = false;
                textBox1.Text = reader1.GetInt32(12).ToString();
                textBox_VisRueBien.Text = reader1.GetString(13);
                textBox_Ville.Text = reader1.GetString(14);
                textBox_VisCPBien.Text = reader1.GetValue(15).ToString();
            }
            reader1.Close();
        }

        private void button_Valider_MouseClick(object sender, MouseEventArgs e)
        {
            //string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql2 = "Insert into Visite ( Code_Proposition,Date)";
            string sql3 = "values('" + ApplicationState.id_proposition + "', '" + dateTimePicker2.Value + "' ) ";

            string sql4 = sql2 + sql3;

            OleDbCommand cmd2 = new OleDbCommand(sql4, dbConnection);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Saved");

            Liste_des_propositions ldp = new Liste_des_propositions();
            ldp.Show(this);
            this.Hide();
        }

        private void button_Annuler_MouseClick(object sender, MouseEventArgs e)
        {
            Liste_des_propositions ldp = new Liste_des_propositions();
            ldp.Show(this);
            this.Hide();
        }
    }
}
