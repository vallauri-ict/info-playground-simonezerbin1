using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_oggetti_tridimensionali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAreaCilindro_Click(object sender, EventArgs e)
        {
            Cilindro c = new Cilindro(Convert.ToInt32(txtRaggio.Text), Convert.ToInt32(txtAltezza.Text));
            MessageBox.Show(c.StampaArea());
        }

        private void btnVolumeCilindro_Click(object sender, EventArgs e)
        {
            Cilindro c = new Cilindro(Convert.ToInt32(txtRaggio.Text), Convert.ToInt32(txtAltezza.Text));
            MessageBox.Show(c.stampaVolume());
        }

        private void btnAreaParallelepipedo_Click(object sender, EventArgs e)
        {
            Parallelepipedo p = new Parallelepipedo(Convert.ToInt32(txtLato1.Text), Convert.ToInt32(txtLato2.Text), Convert.ToInt32(txtAltezza.Text));
            MessageBox.Show(p.StampaArea());
        }

        private void btnVolumeParallelepipedo_Click(object sender, EventArgs e)
        {
            Parallelepipedo p = new Parallelepipedo(Convert.ToInt32(txtLato1.Text), Convert.ToInt32(txtLato2.Text), Convert.ToInt32(txtAltezza.Text));
            MessageBox.Show(p.stampaVolume());
        }
    }
}
