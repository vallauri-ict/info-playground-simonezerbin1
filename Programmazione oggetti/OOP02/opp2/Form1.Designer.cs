namespace opp2
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnval = new System.Windows.Forms.Button();
            this.btnref = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnval
            // 
            this.btnval.Location = new System.Drawing.Point(22, 96);
            this.btnval.Name = "btnval";
            this.btnval.Size = new System.Drawing.Size(126, 49);
            this.btnval.TabIndex = 0;
            this.btnval.Text = "Passagio per valore";
            this.btnval.UseVisualStyleBackColor = true;
            this.btnval.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnref
            // 
            this.btnref.Location = new System.Drawing.Point(22, 188);
            this.btnref.Name = "btnref";
            this.btnref.Size = new System.Drawing.Size(126, 49);
            this.btnref.TabIndex = 1;
            this.btnref.Text = "Passagio per referenza";
            this.btnref.UseVisualStyleBackColor = true;
            this.btnref.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 297);
            this.Controls.Add(this.btnref);
            this.Controls.Add(this.btnval);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnval;
        private System.Windows.Forms.Button btnref;
    }
}

