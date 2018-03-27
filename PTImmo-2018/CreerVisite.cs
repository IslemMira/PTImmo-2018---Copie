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


// work in progress : Arina


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
            string nomBase = "IMMOBILLY_JACKYTEAM";
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql = "select Num_Commercial, Nom, Prenom from COMMERCIAL ";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();

           
            DataTable dt = new DataTable();
            dt.Columns.Add("Num_Commercial", typeof(string));
            dt.Columns.Add("Nom" , typeof(string));
            //dt.Columns.Add("Prenom", typeof(string));

            dt.Load(reader);

            comboBox_Commercial.ValueMember = "Num_Commercial";
            comboBox_Commercial.DisplayMember = "Nom";    
            comboBox_Commercial.DataSource = dt;


			string sql1 = " ";
			OleDbCommand cmd1 = new OleDbCommand(sql1, dbConnection);
			OleDbDataReader reader1 = cmd1.ExecuteReader();

			while (reader1.Read())
			{

				textBox_Nom.Text = reader1.GetString(0);
				textBox_Prénom.Text = reader1.GetString(1);
				IdBien.Text = reader1.GetInt32(2).ToString();
				textBox_SurfHab.Text = reader1.GetInt32(3).ToString();
				textBox_SurfParc.Text = reader1.GetInt32(4).ToString();
				textBox_NbPiece.Text = reader1.GetInt32(5).ToString();
				textBox_NbChambre.Text = reader1.GetInt32(6).ToString();
				textBox_NbSdb.Text = reader1.GetInt32(7).ToString();
				if (reader1.GetBoolean(8) == true) checkBox_Garage.Checked = true;
				if (reader1.GetBoolean(9) == true) checkBox_Cave.Checked = true;
				textBox_Prix.Text = reader1.GetString(10);
				textBox_Ville.Text = reader1.GetString(11);
				textBox3.Text = reader1.GetDateTime(12).ToString();
			}
			reader.Close();
		}

		private void button_Valider_Click(object sender, EventArgs e)
		{
			string nomBase = "IMMOBILLY_JACKYTEAM";
			string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
			OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
			dbConnection.Open();

			string sql2 = "Insert into Visite (Date) where Code_Proposition= ";
			string sql3 = "values('" + dateTimePicker1.Text + "' ) ";

			string sql4 = sql2 + sql3;

			OleDbCommand cmd2 = new OleDbCommand(sql4, dbConnection);
			cmd2.ExecuteNonQuery();
			MessageBox.Show("Saved");
		}

		private void button_Annuler_Click(object sender, EventArgs e)
		{
			Liste_des_propositions ldp = new Liste_des_propositions();
			ldp.Show(this);
			this.Hide();
		}
	}
}
