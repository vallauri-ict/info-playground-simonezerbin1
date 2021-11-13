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
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        RichTextBox txt = new RichTextBox();
        TextBox txtNFormattato = new TextBox();
        TextBox txtFormato = new TextBox();
        TextBox txtNumero = new TextBox();
        public Form1()
        {
            InitializeComponent();
        }


        public struct ButtonStruct
        {
            public char Content;
            public ButtonStruct(char content)
            {
                this.Content = content;
            }
            public override string ToString()
            {
                return Content.ToString();
            }
        }
        private ButtonStruct[,] buttons =
        {
            { new ButtonStruct('7'), new ButtonStruct('8'), new ButtonStruct('9') },
            { new ButtonStruct('4'), new ButtonStruct('5'), new ButtonStruct('6')},
            { new ButtonStruct('1'), new ButtonStruct('2'), new ButtonStruct('3')},
            { new ButtonStruct('+'), new ButtonStruct('0'), new ButtonStruct('#')},

        };
        private void Form1_Load(object sender, EventArgs e)
        {
            generaPulsanti();
        }

        private void generaPulsanti()
        {
            Button btn;
    
            for (int i = 0; i < 6; i++)
            {
                btn = new Button();
                if (i < 5)
                    btn.Text = "Parte " + (i + 3).ToString();
                else
                    btn.Text = "FAC";
                btn.Left = rnd.Next(100, 700);
                btn.Top = rnd.Next(400, 580);
                btn.Name = ("btn" + btn.Text);
                this.Controls.Add(btn);
                btn.Click += new EventHandler(this.button_Click);

            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch(btn.Name)
            {
                case "btnParte 3":
                    riposizionaPulsanti();
                    break;
                case "btnParte 4":
                    creaTastierino();
                    break;
                case "btnParte 5":
                    eliminaTastierino();
                    break;
                case "btnParte 6":
                    generaRichTextBox();
                    break;
                case "btnParte 7":
                    generaEtichette();
                    break;
                case "btnFAC":
                    ripulisciTutto();
                    break;


            }
           
        }

        private void ripulisciTutto()
        {
            eliminaTastierino();
            eliminaBottoni();
            eliminaLabelseTextBox();
            generaPulsanti();
            riposizionaPulsanti();
            creaTastierino();
            generaRichTextBox();
            generaEtichette();
        }

        private void eliminaLabelseTextBox()
        {
            
            /*
              foreach(Label lbl in this.Controls)
              {
                  this.Controls.Remove(lbl);
              }
              foreach (Button btn in this.Controls)
              {
                  this.Controls.Remove(btn);
              }
              foreach (TextBox txt in this.Controls)
              {
                  this.Controls.Remove(txt);
              }
              foreach(RichTextBox txt in this.Controls)
              {
                  this.Controls.Remove(txt);
              }*/
            this.Controls.RemoveByKey("lblFormato");
            this.Controls.RemoveByKey("lblNumero");
            this.Controls.RemoveByKey("lblNFormattato");
            this.Controls.RemoveByKey("txtFormato");
            this.Controls.RemoveByKey("txtNumero");
            this.Controls.RemoveByKey("txtNFormattato");
            this.Controls.RemoveByKey("txtRich");

        }

        private void eliminaBottoni()
        {
            for (int i = 0; i < 6; i++)
            {
                if (i < 5)
                    this.Controls.RemoveByKey("btnParte " + (i + 3).ToString());
                else
                    this.Controls.RemoveByKey("btnFAC");
            }
        }

        private void generaEtichette()
        {
            Label formato = new Label();
            Label numero = new Label();
            Label nFormattato = new Label();
            formato.Left = 100;
            formato.Top = 50;
            formato.Text = "Formato";
            formato.Name = "lblFormato";
            this.Controls.Add(formato);
            numero.Left = 300;
            numero.Top = 50;
            numero.Text = "Numero";
            numero.Name = "lblNumero";
            this.Controls.Add(numero);
            nFormattato.Left = 600;
            nFormattato.Top = 50;
            nFormattato.Text = "Numero formattato";
            nFormattato.Name = "lblNformattato";
            this.Controls.Add(nFormattato);
           
         
            txtFormato.Left = 100;
            txtFormato.Top = 110;
            txtFormato.Name = "txtFormato";
            this.Controls.Add(txtFormato);
            txtNumero.Left = 300;
            txtNumero.Top = 110;
            txtNumero.Name = "txtNumero";
            this.Controls.Add(txtNumero);
            txtNFormattato.Left = 600;
            txtNFormattato.Top = 110;
            txtNFormattato.ReadOnly = true;
            txtNFormattato.Name = "txtNFormattato";

            this.Controls.Add(txtNFormattato);
          
            txtNumero.TextChanged += new EventHandler(text_Changed);



        }

        private void text_Changed(object sender, EventArgs e)
        {

            txtNFormattato.Font = new Font(txtFormato.Text, 16, FontStyle.Regular);
            txtNFormattato.Text = txtNumero.Text;
            
        }

        private void generaRichTextBox()
        {
           
            txt.Left = 250;
            txt.Top = 0;
            txt.Text = "";
            txt.Height = 50;
            txt.Width = 200;
            txt.ReadOnly = true;
            txt.Name = "txtRich";
            this.Controls.Add(txt);

        }

        private void eliminaTastierino()
        {
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    Button myButton = new Button();
                    this.Controls.RemoveByKey("btn-" + i + "-" + j);
                }
            }
        }

        private void creaTastierino()
        {
            int buttonWidth = 80;
            int buttonHeight = 60;
            int posX = 250;
            int posY = 140;
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    ButtonStruct myButtonStruct = buttons[i, j];
                    Button myButton = new Button();
                    myButton.Text = myButtonStruct.ToString();
                    myButton.Width = buttonWidth;
                    myButton.Height = buttonHeight;
                    myButton.Left = posX;
                    myButton.Top = posY;
                    myButton.Tag = myButtonStruct;
                    myButton.Name = "btn-" + i + "-" + j;
                    myButton.Click += Tastierino_Click;
                    this.Controls.Add(myButton);
                    posX += buttonWidth;
                }
                posX = 250;
                posY += buttonHeight;
            }
        }

        private void riposizionaPulsanti()
        {
            eliminaBottoni();
            generaPulsanti();
        }


        private void Tastierino_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "+")
            {
                if (txt.Text.Length == 0)
                    txt.Text += btn.Text;
            }
            else if (btn.Text == "#")
            {
                txt.Text += btn.Text;
                rimuoviEvento();
                
            }
            else
                txt.Text += btn.Text;
        }

        private void rimuoviEvento()
        {
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    Button btn = (Button)this.Controls["btn-"+i+"-"+j];
                    btn.Click -= Tastierino_Click;
                    
                }
            }
        }
    }
}
