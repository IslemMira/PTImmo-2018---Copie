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
    public partial class FicheSouhaitsViz : Form
    {
        public FicheSouhaitsViz()
        {
            InitializeComponent();
        }

        private void FicheSouhaitsViz_Load(object sender, EventArgs e)
        {
            
                string ChaineBd = "Provider=SQLOLEDB;Data Source=INFO-joyeux;Initial Catalog=IMMOBILLY_JACKYTEAM;Persist Security Info=True; Integrated Security=sspi;";
                OleDbConnection dbConnection = new OleDbConnection(ChaineBd);
                dbConnection.Open();



                string sql = "select s.CODE_SOUHAIT,s.STATUT, s.SURFACE_HABITABLE_MIN, s.SURFACE_PARCELLE_MIN, s.NB_PIECES_MIN,  s.PRIX_MAX, v.NOM_VILLE, v.Code_Postal from SOUHAIT s left join VILLE v on v.CODE_VILLE = s.CODE_VILLE where s.CODE_SOUHAIT = '" +ApplicationState.id_souhait+ "' ";
                OleDbCommand cmd = new OleDbCommand(sql, dbConnection);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    textBox1.Text = reader.GetInt32(0).ToString();
                    textBox5.Text = reader.GetString(1);
                    numericUpDown1.Text = reader.GetInt32(2).ToString();
                    numericUpDown2.Text = reader.GetInt32(3).ToString();
                    numericUpDown3.Text = reader.GetInt32(4).ToString();
                   
                    textBox2.Text = reader.GetValue(5).ToString();
                    textBox3.Text = reader.GetString(6);
                    textBox4.Text = reader.GetValue(7).ToString(); 

                }
                reader.Close();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            ModifierSouhait ms = new ModifierSouhait();
            ms.Show(this);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            visualiser_acheteur va = new visualiser_acheteur();
            va.Show(this);
            this.Hide();
        }
    }
    }
    



		
	
