using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP06_As_Is
{
    public partial class Form1 : Form
    {
        Random casuale = new Random();
        public Form1()
        {
            InitializeComponent();
              
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGeneraMostro_Click(object sender, EventArgs e)
        {
            Mostro guardiano;
            if(casuale.Next(2)==0)
            {
                guardiano = new Mannaro();
            }
            else
            {
                guardiano = new Zombie();
            }
           
            if(guardiano is Mannaro)
            {
                MessageBox.Show("Verso come mannaro: " + (guardiano as Mannaro).Verso());
            }
            else if(guardiano is Zombie)
            {
                MessageBox.Show("Verso come zombie: " + (guardiano as Zombie).Verso());
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(sender is Button)
            {
                (sender as Button).Text = "Cliccato";
            }
            if(sender is Label)
            {
                (sender as Label).BackColor = Color.Red;
            }
        }
    }
}
