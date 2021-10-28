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
    public partial class FormMain : Form
    {
        public string combo = null;
        public string cabinato = null;
        public bool f1Aperto = false;
        public Figlia1 f1;
        public Figlia2 f2;
        public FormMain()
        {
            InitializeComponent();
         
        }

        

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1Aperto = true;
            f1 = new Figlia1(combo, cabinato);
            f1.MdiParent = this;
            f1.Text = "Figlia 1";
            f1.Size = new Size(250, 400);
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = new Point(10, 10);
            f1.Show();

        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
           
            if(f1Aperto&&f1.combo!="")
            {
                f2 = new Figlia2(f1.combo, f1.cabinato);
                toolStripStatusLabel1.Text = "Hai selezionato un " + f1.combo + " " + f1.cabinato;
                f2.MdiParent = this;
                f2.Text = "Figlia 2";
                f2.Size = new Size(450, 400);
                f2.StartPosition = FormStartPosition.Manual;
                f2.Location = new Point(270, 10);
                f2.Show();
               

            }
            else
            {
                FormModale fm = new FormModale();
                
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    fm.Close();
                }
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Esci f = new Esci();
            f.MdiParent = this;
            f.Text = "Vuoi uscire?";
            if (f.ShowDialog() == DialogResult.OK)
            {
                Close();
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo f = new FormInfo();
            f.Text = "Informazioni?";

            if (f.ShowDialog() == DialogResult.OK)
            {
                f.Close();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
