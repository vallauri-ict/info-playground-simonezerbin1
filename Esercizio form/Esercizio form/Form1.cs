﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApriF2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Form2 creata da Designer";
            f2.Show();
           

        }

        private void btnF2Controllo_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(txtDaPassare);
            f2.Text = "Form2 con passaggio di un textBox";
            f2.Show();
        }

        private void btnApriF2b_Click(object sender, EventArgs e)
        {
            Form2 f2b = new Form2(10);
            f2b.Text = "Form2 da designer con parametro";
            f2b.Show();
        }

        private void btnApriModale_Click(object sender, EventArgs e)
        {
            FormModale frm = new FormModale();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Premuto pulsante OK\nNome:" + frm.nome + "\nEtà: " + frm.eta);
            }
            else
            {
                MessageBox.Show("Premuto pulsante annulla");
            }
        }
    }
}
