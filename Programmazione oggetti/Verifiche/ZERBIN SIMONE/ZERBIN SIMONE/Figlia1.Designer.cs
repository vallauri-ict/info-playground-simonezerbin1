namespace ZERBIN_SIMONE
{
    partial class Figlia1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.rbCabinato = new System.Windows.Forms.RadioButton();
            this.rbNonCabinato = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btncarica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Same",
            "Lamborghini",
            "Caro-Kann",
            "Nimzo"});
            this.comboBox.Location = new System.Drawing.Point(41, 63);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 0;
        
            // 
            // rbCabinato
            // 
            this.rbCabinato.AutoSize = true;
            this.rbCabinato.Location = new System.Drawing.Point(48, 130);
            this.rbCabinato.Name = "rbCabinato";
            this.rbCabinato.Size = new System.Drawing.Size(35, 17);
            this.rbCabinato.TabIndex = 1;
            this.rbCabinato.Text = "SI";
            this.rbCabinato.UseVisualStyleBackColor = true;
            // 
            // rbNonCabinato
            // 
            this.rbNonCabinato.AutoSize = true;
            this.rbNonCabinato.Checked = true;
            this.rbNonCabinato.Location = new System.Drawing.Point(48, 165);
            this.rbNonCabinato.Name = "rbNonCabinato";
            this.rbNonCabinato.Size = new System.Drawing.Size(41, 17);
            this.rbNonCabinato.TabIndex = 2;
            this.rbNonCabinato.TabStop = true;
            this.rbNonCabinato.Text = "NO";
            this.rbNonCabinato.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Deve essere cabinato?";
            // 
            // btncarica
            // 
            this.btncarica.Location = new System.Drawing.Point(48, 212);
            this.btncarica.Name = "btncarica";
            this.btncarica.Size = new System.Drawing.Size(75, 23);
            this.btncarica.TabIndex = 4;
            this.btncarica.Text = "carica dati";
            this.btncarica.UseVisualStyleBackColor = true;
            this.btncarica.Click += new System.EventHandler(this.btncarica_Click);
            // 
            // Figlia1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncarica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbNonCabinato);
            this.Controls.Add(this.rbCabinato);
            this.Controls.Add(this.comboBox);
            this.Name = "Figlia1";
            this.Text = "Figlia1";
            this.Load += new System.EventHandler(this.Figlia1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.RadioButton rbCabinato;
        private System.Windows.Forms.RadioButton rbNonCabinato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncarica;
    }
}