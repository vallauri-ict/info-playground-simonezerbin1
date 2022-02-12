using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryQuadrato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProvaMetodoFactory_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Prova con lato = 5");
                Quadrato q = Quadrato.CreaQuadrato(5);
                MessageBox.Show("Prova con lato = 0 ");
                Quadrato q2 = Quadrato.CreaQuadrato(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRORE!!");
               
            }
        }

        private void btnProvaMetodoSingleton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creazione primo oggetto Singleton");
            Singleton s1 = Singleton.GetIstance();
            MessageBox.Show("Progressivo: " + s1.n);
            MessageBox.Show("prova creazione secondo oggetto Singleton");
            Singleton s2 = Singleton.GetIstance();
            MessageBox.Show("Progressivo : " + s2.n);
            MessageBox.Show("Prima istanza: " + s1 + "\nSeconda istanza: " + s2);
        }

        private void btnProvaStringheIndexate_Click(object sender, EventArgs e)
        {
            StringheIndexate s = new StringheIndexate(10);
            for (int i = 0; i < 10; i++)
            {
                s[i] = i.ToString();
            }
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show("Stringa " + i + " = " + s[i]);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
