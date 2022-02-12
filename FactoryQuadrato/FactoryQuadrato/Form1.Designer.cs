namespace FactoryQuadrato
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
            this.btnProvaMetodoFactory = new System.Windows.Forms.Button();
            this.btnProvaMetodoSingleton = new System.Windows.Forms.Button();
            this.btnProvaStringheIndexate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProvaMetodoFactory
            // 
            this.btnProvaMetodoFactory.Location = new System.Drawing.Point(42, 46);
            this.btnProvaMetodoFactory.Name = "btnProvaMetodoFactory";
            this.btnProvaMetodoFactory.Size = new System.Drawing.Size(93, 39);
            this.btnProvaMetodoFactory.TabIndex = 0;
            this.btnProvaMetodoFactory.Text = "prova metodo factory";
            this.btnProvaMetodoFactory.UseVisualStyleBackColor = true;
            this.btnProvaMetodoFactory.Click += new System.EventHandler(this.btnProvaMetodoFactory_Click);
            // 
            // btnProvaMetodoSingleton
            // 
            this.btnProvaMetodoSingleton.Location = new System.Drawing.Point(181, 46);
            this.btnProvaMetodoSingleton.Name = "btnProvaMetodoSingleton";
            this.btnProvaMetodoSingleton.Size = new System.Drawing.Size(93, 39);
            this.btnProvaMetodoSingleton.TabIndex = 1;
            this.btnProvaMetodoSingleton.Text = "prova metodo singleton";
            this.btnProvaMetodoSingleton.UseVisualStyleBackColor = true;
            this.btnProvaMetodoSingleton.Click += new System.EventHandler(this.btnProvaMetodoSingleton_Click);
            // 
            // btnProvaStringheIndexate
            // 
            this.btnProvaStringheIndexate.Location = new System.Drawing.Point(313, 46);
            this.btnProvaStringheIndexate.Name = "btnProvaStringheIndexate";
            this.btnProvaStringheIndexate.Size = new System.Drawing.Size(93, 39);
            this.btnProvaStringheIndexate.TabIndex = 2;
            this.btnProvaStringheIndexate.Text = "prova metodo stringhe indexate";
            this.btnProvaStringheIndexate.UseVisualStyleBackColor = true;
            this.btnProvaStringheIndexate.Click += new System.EventHandler(this.btnProvaStringheIndexate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProvaStringheIndexate);
            this.Controls.Add(this.btnProvaMetodoSingleton);
            this.Controls.Add(this.btnProvaMetodoFactory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProvaMetodoFactory;
        private System.Windows.Forms.Button btnProvaMetodoSingleton;
        private System.Windows.Forms.Button btnProvaStringheIndexate;
    }
}

