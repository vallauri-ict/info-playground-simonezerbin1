using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coda
{
    public partial class Form1 : Form
    {
        int min, max;
        public struct paziente
        {
            public string nome;
            public int età;
            public string colore;
            public int temperatura;
        }
        
        Queue<paziente> codaRossa = new Queue<paziente>();
        Queue<paziente> codaGialla = new Queue<paziente>();
        Queue<paziente> codaVerde= new Queue<paziente>();
        Queue<paziente> codaBianca = new Queue<paziente>();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            min = 46;
            max = 33;
            lblServe.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            paziente p;
            p.nome = txtNome.Text;
            p.età = Convert.ToInt32(txtEtà.Text);
            p.colore = txtColore.Text;
            p.temperatura = Convert.ToInt32(nudTemperatura.Value);
            if (p.colore == "Rosso")
                codaRossa.Enqueue(p);
            else if (p.colore == "Giallo")
                codaGialla.Enqueue(p);
            else if (p.colore == "Verde")
                codaVerde.Enqueue(p);
            else
                codaBianca.Enqueue(p);
            calcolaMinMax();
        }

        private void btnServi_Click(object sender, EventArgs e)
        {
            paziente p;
            lblServe.Text = "";
            if (codaRossa.Count != 0)
            {
                lblServe.Text = "È stato servito il paziente: \nNome: " + codaRossa.Peek().nome +
                "\nEtà: " + codaRossa.Peek().età + "\nColore: " + codaRossa.Peek().colore + "\nTemperatura: " + codaRossa.Peek().temperatura;
                codaRossa.Dequeue();
            }    
            else if (codaGialla.Count != 0)
            {
                lblServe.Text = "È stato servito il paziente: \nNome: " + codaGialla.Peek().nome +
                "\nEtà: " + codaGialla.Peek().età + "\nColore: " + codaGialla.Peek().colore + "\nTemperatura: " + codaGialla.Peek().temperatura;
                codaGialla.Dequeue();
            } 
            else if (codaVerde.Count != 0)
            {
                lblServe.Text = "È stato servito il paziente: \nNome: " + codaVerde.Peek().nome +
                "\nEtà: " + codaVerde.Peek().età + "\nColore: " + codaVerde.Peek().colore + "\nTemperatura: " + codaVerde.Peek().temperatura;
                codaVerde.Dequeue();
            }   
            else if (codaBianca.Count != 0)
            {
                lblServe.Text = "È stato servito il paziente: \nNome: " + codaBianca.Peek().nome +
                "\nEtà: " + codaBianca.Peek().età + "\nColore: " + codaBianca.Peek().colore + "\nTemperatura: " + codaBianca.Peek().temperatura;
                codaBianca.Dequeue();
            } 
            else
                MessageBox.Show("La coda è vuota");
           
        }

        private void btnMaxMinTemperatura_Click(object sender, EventArgs e)
        {
            lblMax.Text = "Massima temperatura: " + max.ToString();
            lblMin.Text = "Minima temperatura: " + min.ToString();

        }

        private void calcolaMinMax()
        {
            foreach (paziente p in codaRossa)
            {
                if (p.temperatura > max)
                    max = p.temperatura;
                if (p.temperatura < min)
                    min = p.temperatura;
            }
            foreach (paziente p in codaGialla)
            {
                if (p.temperatura > max)
                    max = p.temperatura;
                if (p.temperatura < min)
                    min = p.temperatura;
            }
            foreach (paziente p in codaVerde)
            {
                if (p.temperatura > max)
                    max = p.temperatura;
                if (p.temperatura < min)
                    min = p.temperatura;
            }
            foreach (paziente p in codaBianca)
            {
                if (p.temperatura > max)
                    max = p.temperatura;
                if (p.temperatura < min)
                    min = p.temperatura;
            }
        }
    }
}
