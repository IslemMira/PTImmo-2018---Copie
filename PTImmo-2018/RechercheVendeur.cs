using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTImmo_2018
{
    public partial class RechercheVendeur : Form
    {
		
        public RechercheVendeur()
        {
            InitializeComponent();
        }

		private void RechercheVendeur_Load(object sender, EventArgs e)
		{

		}

		private void Rechercher_Click(object sender, EventArgs e)
		{

		}

		private void Visualiser_Click(object sender, EventArgs e)
		{

		}

		private void listView1_vendeurs_MouseClick(object sender, MouseEventArgs e)
		{
			ApplicationState.id_vendeur = listView1_vendeurs.SelectedItems[0].SubItems[0].Text;
		}
	}
}
