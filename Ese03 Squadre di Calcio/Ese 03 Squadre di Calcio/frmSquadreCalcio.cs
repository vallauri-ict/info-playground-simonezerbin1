using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ese_03_Squadre_di_Calcio
{
    public partial class frmSquadreCalcio : Form
    {
        Squadre sqA, sqB, sqC;
        public frmSquadreCalcio()
        {
            InitializeComponent();
        }

        private void btnCreaB_Click(object sender, EventArgs e)
        {
            sqB = new Squadre("Macedonia", "Golfo Aranci", 0, 0, 0);
            txtSecondaSquadra.Text = sqB.Città;
            txtSecondoValore.Text = (sqB.Vinte * 3 + sqB.Pareggiate * 1).ToString();
        }

        private void btnCreaC_Click(object sender, EventArgs e)
        {
            sqC = new Squadre("Virtus", "Città vecchia", 0, 0, 0);
            txtTerzaSquadra.Text = sqC.Città;
            txtTerzoValore.Text = (sqC.Vinte * 3 + sqC.Pareggiate * 1).ToString();
        }

        private void btnVinceA_Click(object sender, EventArgs e)
        {
            sqA.Vinte++;
            txtPrimaSquadra.Text = sqA.Città;
            txtPrimoValore.Text = (sqA.Vinte * 3 + sqA.Pareggiate * 1).ToString();
        }

        private void btnVinceB_Click(object sender, EventArgs e)
        {
            sqB.Vinte++;
            txtSecondaSquadra.Text = sqB.Città;
            txtSecondoValore.Text = (sqB.Vinte * 3 + sqB.Pareggiate * 1).ToString();
        }

        private void btnVinceC_Click(object sender, EventArgs e)
        {
            sqC.Vinte++;
            txtTerzaSquadra.Text = sqC.Città;
            txtTerzoValore.Text = (sqC.Vinte * 3 + sqC.Pareggiate * 1).ToString();
        }

        private void btnPareggiaA_Click(object sender, EventArgs e)
        {
            sqA.Pareggiate++;
            txtPrimaSquadra.Text = sqA.Città;
            txtPrimoValore.Text = (sqA.Vinte * 3 + sqA.Pareggiate * 1).ToString();
        }

        private void btnPareggiaB_Click(object sender, EventArgs e)
        {
            sqB.Pareggiate++;
            txtSecondaSquadra.Text = sqB.Città;
            txtSecondoValore.Text = (sqB.Vinte * 3 + sqB.Pareggiate * 1).ToString();
        }

        private void btnPareggiaC_Click(object sender, EventArgs e)
        {
            sqC.Pareggiate++;
            txtTerzaSquadra.Text = sqC.Città;
            txtTerzoValore.Text = (sqC.Vinte * 3 + sqC.Pareggiate * 1).ToString();
        }

        private void frmSquadreCalcio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCreaA_Click(object sender, EventArgs e)
        {
            sqA = new Squadre("Atlante", "Montecauto", 0, 0, 0);
            txtPrimaSquadra.Text = sqA.Città;
            txtPrimoValore.Text = (sqA.Vinte * 3 + sqA.Pareggiate * 1).ToString();
        }
    }
}
 