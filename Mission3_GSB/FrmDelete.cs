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
    public partial class FrmDelete : Form
    {
        private gsbrapports2021Entities mesDonneesEf;
        public FrmDelete(gsbrapports2021Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonneesEf = mesDonnees;
            this.bdgSourceDelM.DataSource = this.mesDonneesEf.medicament.ToList();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            string conf = "lol";
            if (this.txtConf.Text== conf)
            {
                 int rowIndex = dtgSuppr.CurrentCell.RowIndex;
                 string valeur = dtgSuppr.CurrentCell.Value.ToString(); // Rajout de cette ligne qui permet de récupérer la l'ID dans la datagrid dans une variable pour ensuite la retourner plus bas
                 dtgSuppr.Rows.RemoveAt(rowIndex);


                //fonctionne que sur le datagrid mais ne supprime rien dans la base de donnée


               // var query = mesDonneesEf.AsEnumerable();


                MessageBox.Show("Votre médicament a bien été supprimer !");
            }
            else
            {
                MessageBox.Show("Veuiller bien noter Confirmation !!");
            }
        }
    }
}
