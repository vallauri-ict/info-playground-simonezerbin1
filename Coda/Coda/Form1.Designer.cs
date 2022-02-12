namespace Coda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEtà = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnServi = new System.Windows.Forms.Button();
            this.txtColore = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMaxMinTemperatura = new System.Windows.Forms.Button();
            this.nudTemperatura = new System.Windows.Forms.NumericUpDown();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblServe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemperatura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Età";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Colore";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(229, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtEtà
            // 
            this.txtEtà.Location = new System.Drawing.Point(229, 100);
            this.txtEtà.Name = "txtEtà";
            this.txtEtà.Size = new System.Drawing.Size(100, 20);
            this.txtEtà.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(540, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Aggiungi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnServi
            // 
            this.btnServi.Location = new System.Drawing.Point(540, 133);
            this.btnServi.Name = "btnServi";
            this.btnServi.Size = new System.Drawing.Size(104, 23);
            this.btnServi.TabIndex = 7;
            this.btnServi.Text = "Servi paziente";
            this.btnServi.UseVisualStyleBackColor = true;
            this.btnServi.Click += new System.EventHandler(this.btnServi_Click);
            // 
            // txtColore
            // 
            this.txtColore.FormattingEnabled = true;
            this.txtColore.Items.AddRange(new object[] {
            "Rosso",
            "Giallo",
            "Verde",
            "Bianco"});
            this.txtColore.Location = new System.Drawing.Point(229, 140);
            this.txtColore.Name = "txtColore";
            this.txtColore.Size = new System.Drawing.Size(100, 21);
            this.txtColore.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Temperatura";
            // 
            // btnMaxMinTemperatura
            // 
            this.btnMaxMinTemperatura.Location = new System.Drawing.Point(295, 234);
            this.btnMaxMinTemperatura.Name = "btnMaxMinTemperatura";
            this.btnMaxMinTemperatura.Size = new System.Drawing.Size(104, 40);
            this.btnMaxMinTemperatura.TabIndex = 11;
            this.btnMaxMinTemperatura.Text = "Massima e minima temperatura";
            this.btnMaxMinTemperatura.UseVisualStyleBackColor = true;
            this.btnMaxMinTemperatura.Click += new System.EventHandler(this.btnMaxMinTemperatura_Click);
            // 
            // nudTemperatura
            // 
            this.nudTemperatura.Location = new System.Drawing.Point(229, 186);
            this.nudTemperatura.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nudTemperatura.Minimum = new decimal(new int[] {
            34,
            0,
            0,
            0});
            this.nudTemperatura.Name = "nudTemperatura";
            this.nudTemperatura.Size = new System.Drawing.Size(120, 20);
            this.nudTemperatura.TabIndex = 12;
            this.nudTemperatura.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(198, 291);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(113, 13);
            this.lblMax.TabIndex = 13;
            this.lblMax.Text = "Massima temperatura: ";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(198, 322);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(105, 13);
            this.lblMin.TabIndex = 14;
            this.lblMin.Text = "Minima temperatura: ";
            // 
            // lblServe
            // 
            this.lblServe.AutoSize = true;
            this.lblServe.Location = new System.Drawing.Point(537, 186);
            this.lblServe.Name = "lblServe";
            this.lblServe.Size = new System.Drawing.Size(0, 13);
            this.lblServe.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblServe);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.nudTemperatura);
            this.Controls.Add(this.btnMaxMinTemperatura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtColore);
            this.Controls.Add(this.btnServi);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEtà);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTemperatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEtà;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnServi;
        private System.Windows.Forms.ComboBox txtColore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMaxMinTemperatura;
        private System.Windows.Forms.NumericUpDown nudTemperatura;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblServe;
    }
}

