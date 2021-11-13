using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZERBIN_SIMONE
{
    public partial class Figlia1 : Form
    {
        public string combo=null;
        public string cabinato=null;
        Figlia1 f1;
        public Figlia1(string cmb, string cab)
        {
            InitializeComponent();
            this.combo = cmb;
            this.cabinato = cab;
        }

        private void Figlia1_Load(object sender, EventArgs e)
        {
           

        }

        

        private void btncarica_Click(object sender, EventArgs e)
        {
           
            combo = comboBox.Text;

            if (rbCabinato.Checked)
                cabinato = "Cabinato";
            else
                cabinato = "Non cabinato";
            
            f1 = new Figlia1(combo, cabinato);
            f1.combo = combo;
            f1.cabinato = cabinato;
            
          



        }
    }
}
