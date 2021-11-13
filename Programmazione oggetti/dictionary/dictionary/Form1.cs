using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dictionary
{
    public partial class Form1 : Form
    {

        public struct articoli
        {
            public string key;
            public string name;
        }
        public int i = 0;
        Dictionary<int, articoli> dizionarioArticoli = new Dictionary<int, articoli>();
        
      
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            articoli a;
            a.key = txtKey.Text;
            a.name = txtName.Text;
            dizionarioArticoli.Add(i, a);
            i++;
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            string key = txtKeyCerca.Text;
            foreach (articoli a in dizionarioArticoli.Values)
                if (a.key == key)
                    lblKey.Text = a.name;
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            lblNumero.Text = dizionarioArticoli.Count.ToString();
            
        }
    }
}
