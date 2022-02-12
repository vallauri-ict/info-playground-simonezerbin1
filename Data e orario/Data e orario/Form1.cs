using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_e_orario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Data data;
        DataOra dataOra;

        private void btnCreaDataPredefinita_Click(object sender, EventArgs e)
        {
            data = new Data();
        }

        private void btnCreaDataParametri_Click(object sender, EventArgs e)
        {

            int giorno = Convert.ToInt32(txtGiorno.Text);
            int mese = Convert.ToInt32(txtMese.Text);
            int anno = Convert.ToInt32(txtAnno.Text);
            data = new Data(giorno,mese,anno);
        }

        private void btnLeggiData_Click(object sender, EventArgs e)
        {
            int giorno = Convert.ToInt32(txtGiorno.Text);
            int mese = Convert.ToInt32(txtMese.Text);
            int anno = Convert.ToInt32(txtAnno.Text);
            data.leggi(giorno,mese,anno);
        }

        private void btnScrividata_Click(object sender, EventArgs e)
        {
            int giorno = Convert.ToInt32(txtGiorno.Text);
            int mese = Convert.ToInt32(txtMese.Text);
            int anno = Convert.ToInt32(txtAnno.Text);
            data.scrivi(ref giorno, ref mese, ref anno);
        }

        private void btnLeggiStringaData_Click(object sender, EventArgs e)
        {
            MessageBox.Show(data.ToString());
        }

        private void btnLeggiGiorno_Click(object sender, EventArgs e)
        {
            MessageBox.Show(data.giorno());
        }

        private void btnCreaDataOrario_Click(object sender, EventArgs e)
        {
            int giorno = Convert.ToInt32(txtGiorno.Text);
            int mese = Convert.ToInt32(txtMese.Text);
            int anno = Convert.ToInt32(txtAnno.Text);
            int ore = Convert.ToInt32(txtOre.Text);
            int minuti = Convert.ToInt32(txtMinuti.Text);
            int secondi = Convert.ToInt32(txtSecondi.Text);
            dataOra = new DataOra(giorno, mese, anno, ore, minuti, secondi);
        }

        private void btnLeggiOrario_Click(object sender, EventArgs e)
        {
            int ore = Convert.ToInt32(txtOre.Text);
            int minuti = Convert.ToInt32(txtMinuti.Text);
            int secondi = Convert.ToInt32(txtSecondi.Text);
            dataOra.leggi(ore, minuti, secondi);
        }

        private void btnScriviOrario_Click(object sender, EventArgs e)
        {
            int ore = Convert.ToInt32(txtOre.Text);
            int minuti = Convert.ToInt32(txtMinuti.Text);
            int secondi = Convert.ToInt32(txtSecondi.Text);
            dataOra.scrivi(ref ore, ref minuti, ref secondi);
        }

        private void btnLeggiStringaOrario_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataOra.ToString());
        }
    }
}
