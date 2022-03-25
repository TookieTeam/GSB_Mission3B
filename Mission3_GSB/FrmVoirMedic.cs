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
    public partial class FrmVoirMedic : Form
    {
        private gsbrapports2021Entities mesDonneesEF;
        public FrmVoirMedic(gsbrapports2021Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonnees;
            this.bdgSourceVMedic.DataSource = this.mesDonneesEF.medicament.ToList();
            this.bdgSourceOffrir.DataSource = this.mesDonneesEF.offrir.ToList();
            this.bdgSourceFamille.DataSource = this.mesDonneesEF.famille.ToList();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUpdate update = new FrmUpdate(this.mesDonneesEF);
            update.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FrmDelete del = new FrmDelete(this.mesDonneesEF);
            del.ShowDialog();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            FrmUpdate update = new FrmUpdate(this.mesDonneesEF);
            update.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddMedic add = new FrmAddMedic(this.mesDonneesEF);
            add.ShowDialog();
        }

        private void btnAddFam_Click(object sender, EventArgs e)
        {
            FrmAddFamily addF = new FrmAddFamily(this.mesDonneesEF);
            addF.ShowDialog();
            this.cmBxFam.Update();
        }

       
    }
}
