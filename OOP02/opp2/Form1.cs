using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opp2
{
    public partial class Form1 : Form
    {
        Persona abele = new Persona();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abele.eta = 17;
            MessageBox.Show("eta del primo richiamo a compleanno:\n" + abele.eta);
            compelanno(abele);
            MessageBox.Show("eta del dopo richiamo a compleanno:\n" + abele.eta);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            abele.eta = 54;
            MessageBox.Show("eta del primo richiamo a supplenza:\n" + abele.eta);
            supplenza(ref abele); 
            MessageBox.Show("eta del DOPO richiamo a supplenza:\n" + abele.eta);
        }
        private void compelanno(Persona p)
        {
            p.eta++;
        }
        private void supplenza(ref Persona p)
        {
            p = new Persona();
            p.eta = 27;
        }

        
    }
}
