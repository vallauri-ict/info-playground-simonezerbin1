using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pila
{
    public partial class Form1 : Form
    {
        public struct container
        {
            public string codice;
            public double peso;
            public double tara;
        }
        public Form1()
        {
            InitializeComponent();
        }
        Stack<container> pilaContainer = new Stack<container>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            container c;
            c.codice = txtCodice.Text;
            c.peso = double.Parse(txtPeso.Text);
            c.tara= double.Parse(txtTara.Text);
            pilaContainer.Push(c);
        }

        private void btnMostra_Click(object sender, EventArgs e)
        {
            int i = 1; 
            int n = pilaContainer.Count;
            if (n > 0)
            {
                foreach (container c in pilaContainer)
                {
                    MessageBox.Show("Container n° " + i.ToString() + ": \nCodice: " + c.codice + "\nPeso: " + c.peso + "\nTara: " + c.tara);
                    i++;
                    pilaContainer.Peek();
                }

                for (int j = 0; j < n; j++)
                {
                    pilaContainer.Pop();
                }
            }
            else
                MessageBox.Show("Non ci sono container");
           

        }
    }
}
