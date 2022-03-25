using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3_GSB
{
    public partial class Form1 : Form
    {
        private gsbrapports2021Entities mesDonneesEF;
        public Form1()
        {
            InitializeComponent();
            this.mesDonneesEF = new gsbrapports2021Entities();
        }

     

     

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddMedic add = new FrmAddMedic(this.mesDonneesEF);
            add.ShowDialog();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdate update = new FrmUpdate(this.mesDonneesEF);
            update.ShowDialog();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDelete del = new FrmDelete(this.mesDonneesEF) ;
            del.ShowDialog();
        }

        private void visiualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVoirMedic show = new FrmVoirMedic(this.mesDonneesEF);
            show.ShowDialog();
        }
      
    }
}
