using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PTImmo_2018
{
    public partial class ModifierSouhait : Form
    {
        public ModifierSouhait()
        {
            InitializeComponent();
        }

        private void ModifierSouhait_Load(object sender, EventArgs e)
        {
           
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql = "select s.CODE_SOUHAIT,s.STATUT, s.SURFACE_HABITABLE_MIN, s.SURFACE_PARCELLE_MIN, s.NB_PIECES_MIN,  s.PRIX_MAX, v.NOM_VILLE, v.Code_Postal from SOUHAIT s left join VILLE v on v.CODE_VILLE = s.CODE_VILLE where s.CODE_SOUHAIT = '" + ApplicationState.id_souhait + "' ";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(textBox1.Text);
                textBox1.Text = reader.GetInt32(0).ToString();
                comboBox1.Text = reader.GetString(1);
                textBox_SurfaceHabitable.Text = reader.GetInt32(2).ToString();
                textBox_Parcelle.Text = reader.GetInt32(3).ToString();
                numericUpDown3.Text = reader.GetInt32(4).ToString();

                textBox2.Text = reader.GetValue(5).ToString();
                textBox3.Text = reader.GetString(6);
                textBox4.Text = reader.GetValue(7).ToString();

            }
            reader.Close();
        }

       

        private void button_Valider_MouseClick(object sender, MouseEventArgs e)
        {
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql = "UPDATE SOUHAIT  set STATUT = '" + comboBox1.Text + "', SURFACE_HABITABLE_MIN = '" + textBox_SurfaceHabitable.Text + "', SURFACE_PARCELLE_MIN = '" + textBox_Parcelle.Text + "', NB_PIECES_MIN = '" + numericUpDown3.Text + "',  PRIX_MAX = '" + textBox2.Text + "' where CODE_SOUHAIT = '" + textBox1.Text + "' ";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");

            FicheSouhaitsViz fsv = new FicheSouhaitsViz();
            fsv.Show(this);
            this.Hide();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            FicheSouhaitsViz fsv = new FicheSouhaitsViz();
            fsv.Show(this);
            this.Hide();
        }
    }
    }

