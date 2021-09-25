using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_Form_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApriF1_Click(object sender, EventArgs e)
        {
            Figlia1 f = new Figlia1();
            f.MdiParent = this;
            f.Text = "Figlia 1";
            f.Size=new Size(200,350);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(0, 20);
            f.Show();
        }

        private void btnApriF2_Click(object sender, EventArgs e)
        {
            Figlia2 f = new Figlia2();
            f.MdiParent = this;
            f.Text = "Figlia 2";
            f.Size = new Size(200, 150);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(205, 140);
            f.Show();
        }

        private void btnFinestreAperte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sono state aperte: " + this.MdiChildren.Length + " Finestre");
            foreach(Form f in this.MdiChildren)
            {
                MessageBox.Show("Finestra " + f.Text + " Aperta");
            }
        }

        private void apriF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Premuto Apri 1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void apriF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Premuto Apri 2";
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Esci f = new Esci();
            f.Text = "Uscire?";
            if (f.ShowDialog() != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
