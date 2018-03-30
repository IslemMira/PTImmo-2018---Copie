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

            string sql = "select s.CODE_SOUHAIT,s.STATUT, s.SURFACE_HABITABLE_MIN, s.SURFACE_PARCELLE_MIN, s.NB_PIECES_MIN,  s.PRIX_MAX, v.NOM_VILLE, v.Code_Postal from SOUHAIT s left join VILLE v on v.CODE_VILLE = s.CODE_VILLE where s.CODE_SOUHAIT =3 ";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(textBox1.Text);
                textBox1.Text = reader.GetInt32(0).ToString();
                comboBox1.Text = reader.GetString(1);
                numericUpDown1.Text = reader.GetInt32(2).ToString();
                numericUpDown2.Text = reader.GetInt32(3).ToString();
                numericUpDown3.Text = reader.GetInt32(4).ToString();

                textBox2.Text = reader.GetValue(5).ToString();
                textBox3.Text = reader.GetString(6);
                textBox4.Text = reader.GetValue(7).ToString();

            }
            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
            OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
            dbConnection.Open();

            string sql = "UPDATE SOUHAIT  set STATUT = '" + comboBox1.Text + "', SURFACE_HABITABLE_MIN = '" + numericUpDown1.Text + "', SURFACE_PARCELLE_MIN = '" + numericUpDown2.Text + "', NB_PIECES_MIN = '" + numericUpDown3.Text + "',  PRIX_MAX = '" + textBox2.Text + "' where CODE_SOUHAIT = '" + textBox1.Text + "' ";
            OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");

            FicheSouhaitsViz fsv = new FicheSouhaitsViz();
            fsv.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FicheSouhaitsViz fsv = new FicheSouhaitsViz();
            fsv.Show(this);
            this.Hide();
        }
    }
    }

