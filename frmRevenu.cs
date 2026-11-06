using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCsWinRevenue
{
    public partial class frmRevenu : Form
    {
        public frmRevenu()
        {
            InitializeComponent();
        }

        private void btncalculer_Click(object sender, EventArgs e)
        {

            string bio, nom;
            decimal salaire, dedbrutes;
                decimal avatotaux = 0,
                revtotaux;
            Int32 nbreenfant;

            const decimal txMarie = 0.20m;
            const decimal txCelibat = 0.3m;
            const decimal txhomme = 0.2m;
            const decimal txfemme = 0.1m;
            const decimal avEnfant = 5000.00m;

            nom = txtnom.Text;
            salaire = Convert.ToDecimal(txtsalaire.Text);
            nbreenfant =Convert.ToInt32(txtnbeenfants.Text);
            

            if (radhomme.Checked==true)
            {
                bio = "Monsieur";

                if (chkoui.Checked == true)
                {
                    dedbrutes =  (salaire) * (txMarie + txhomme);
                    

                }
                else
                {
                    dedbrutes =  (salaire) * (txCelibat + txhomme);
                }       
            }
            else
            {
                bio = "Madame";

                if (chkoui.Checked == true)
                {
                    dedbrutes =  (salaire) * (txMarie + txfemme);
                }
                else
                {
                    dedbrutes =  (salaire) * (txCelibat + txfemme);
                }
                avatotaux = nbreenfant * avEnfant;
            }

            revtotaux = salaire - dedbrutes + avatotaux;

            lblresultat.Text = bio + nom + ",\n - Votre salaire brut est " + salaire +
                " $ \n - Vos deductions totales " + dedbrutes +
                "$ \n - Vos avantages totaux " + avatotaux +
                "$ \n ---------------------------------------------\n - Vos avantages totaux "
                + revtotaux +"$";

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtnom.Text = txtsalaire.Text  = lblresultat.Text = txtnbeenfants.Text = "";
            txtnom.Focus();
            
        }
    }
}
