using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compito_RegEx
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInserisciDati_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool correct = true;
            string pattern = @"^\D{3,20}$";
            string str = txtNome.Text;
            Regex rgx = new Regex(pattern);
            if (!rgx.IsMatch(str))
            {
                errorProvider.SetError(txtNome, "Il campo NOME deve contenere almeno 3 caratteri e non deve contenere numeri");
                correct = false;
            }

            str = txtCognome.Text;
            rgx = new Regex(pattern);
            if (!rgx.IsMatch(str))
            {
                errorProvider.SetError(txtCognome, "Il campo COGNOME deve contenere almeno 3 caratteri e non deve contenere numeri");
                correct = false;
            }

            str = txtEtà.Text;
            pattern = @"^\d{1,3}$";
            rgx = new Regex(pattern);
            if (!rgx.IsMatch(str))
            {
                errorProvider.SetError(txtEtà, "Il campo Età deve contenere un numero compreso tra 0 e 120");
                correct = false;
            }
            else if (Convert.ToInt32(str) > 120 || Convert.ToInt32(str) < 0)
            {
                errorProvider.SetError(txtEtà, "Il campo Età deve contenere un numero compreso tra 0 e 120");
                correct = false;
            }
            str = txtCap.Text;
            pattern = @"^\d{5}$";
            rgx = new Regex(pattern);
            if (!rgx.IsMatch(str))
            {
                errorProvider.SetError(txtCap, "Il campo CAP deve contenere 5 cifre");
                correct = false;
            }

            str = txtCittà.Text;
            pattern = @"^\D{3} \D\D$";
            rgx = new Regex(pattern);
            if (!rgx.IsMatch(str))
            {
                errorProvider.SetError(txtCittà, "Il campo città deve contenere 3 caratteri + xx");
                correct = false;
            }
            str = txtEmail.Text;
            pattern = @"(\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*\, ){1,10}";
            rgx = new Regex(pattern);
            if (!rgx.IsMatch(str))
            {
                correct = false;
                errorProvider.SetError(txtEmail, "Inserisci un elenco di e-mail eparate da virgola");
            }

            str = txtCF.Text;
            pattern = @"^[A-Z]{6}[0-9]{2}[A-Z][0-9]{2}[A-Z][0-9]{3}[A-Z]$";
            rgx = new Regex(pattern);
            if (!rgx.IsMatch(str))
            {
                errorProvider.SetError(txtCF, "Inserisci un codice fiscale corretto");
                correct = false;
            }

            str = txtUsername.Text;
            pattern = @"^\D\w{4,50}$";
            rgx = new Regex(pattern);
            if (!rgx.IsMatch(str))
            {
                errorProvider.SetError(txtUsername, "Inserisci un username che inizi con una lettera e abbia almeno 5 caratteri");
                correct = false;
            }

            str = txtPassword.Text;
            pattern = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$";
            rgx = new Regex(pattern);
            if (!rgx.IsMatch(str))
            {
                errorProvider.SetError(txtPassword, "Inserisci una password con 8 caratteri che contenga lettere, numeri e un carattere speciale");
                correct = false;
            }
            if(correct)
            {
                MessageBox.Show("Dati inviati correttamente");
                MessageBox.Show("Elenco email: " + txtEmail.Text);
                txtCap.Text = "";
                txtCognome.Text = "";
                txtNome.Text = "";
                txtCittà.Text = "";
                txtEtà.Text = "";
                txtPassword.Text = "";
                txtUsername.Text = "";
                txtEmail.Text = "";
                txtCF.Text = "";
                errorProvider.Clear();
            }
        }
    }
}
