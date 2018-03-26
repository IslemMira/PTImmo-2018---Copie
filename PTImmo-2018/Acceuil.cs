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
    public partial class FormAcceuil : Form
    {
         public  FormAcceuil()
        {
            InitializeComponent();
            
        }

        private void GB_Click(object sender, EventArgs e)
        {
            liste_des_biens ldb = new liste_des_biens();            
                ldb.Show(this);
                this.Hide();

            

        }
    }
}
