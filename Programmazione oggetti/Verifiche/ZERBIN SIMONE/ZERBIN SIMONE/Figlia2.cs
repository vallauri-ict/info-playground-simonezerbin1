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
    public partial class Figlia2 : Form
    {
        public string combo;
        public string cabinato;
        public Figlia2(string cmb, string cab)
        {
            InitializeComponent();
            this.combo = cmb;
            this.cabinato = cab;
        }

        private void Figlia2_Load(object sender, EventArgs e)
        {
            Figlia2 f2 = new Figlia2(combo, cabinato);
            label1.Text = "Hai selezionato un " + f2.combo + " " + f2.cabinato;
       
        }
    }
}
