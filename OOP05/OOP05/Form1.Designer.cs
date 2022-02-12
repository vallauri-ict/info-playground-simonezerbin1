namespace OOP05
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
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddLibro = new System.Windows.Forms.Button();
            this.btnVisElm = new System.Windows.Forms.Button();
            this.nudIndiceLibro = new System.Windows.Forms.NumericUpDown();
            this.btnVisIndiceLibro = new System.Windows.Forms.Button();
            this.btnAddCoda = new System.Windows.Forms.Button();
            this.btnAddInStack = new System.Windows.Forms.Button();
            this.btnEstraiCoda = new System.Windows.Forms.Button();
            this.btnEstraiDaStack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndiceLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titolo";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(138, 40);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(100, 20);
            this.txtTitolo.TabIndex = 1;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(138, 92);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(100, 20);
            this.txtAutore.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autore";
            // 
            // btnAddLibro
            // 
            this.btnAddLibro.Location = new System.Drawing.Point(95, 140);
            this.btnAddLibro.Name = "btnAddLibro";
            this.btnAddLibro.Size = new System.Drawing.Size(120, 24);
            this.btnAddLibro.TabIndex = 4;
            this.btnAddLibro.Text = "Aggiungi in dizionario";
            this.btnAddLibro.UseVisualStyleBackColor = true;
            this.btnAddLibro.Click += new System.EventHandler(this.btnAddLibro_Click);
            // 
            // btnVisElm
            // 
            this.btnVisElm.Location = new System.Drawing.Point(95, 179);
            this.btnVisElm.Name = "btnVisElm";
            this.btnVisElm.Size = new System.Drawing.Size(120, 23);
            this.btnVisElm.TabIndex = 5;
            this.btnVisElm.Text = "Visualizza elementi";
            this.btnVisElm.UseVisualStyleBackColor = true;
            this.btnVisElm.Click += new System.EventHandler(this.btnVisElm_Click);
            // 
            // nudIndiceLibro
            // 
            this.nudIndiceLibro.Location = new System.Drawing.Point(95, 221);
            this.nudIndiceLibro.Name = "nudIndiceLibro";
            this.nudIndiceLibro.Size = new System.Drawing.Size(120, 20);
            this.nudIndiceLibro.TabIndex = 6;
            // 
            // btnVisIndiceLibro
            // 
            this.btnVisIndiceLibro.Location = new System.Drawing.Point(276, 221);
            this.btnVisIndiceLibro.Name = "btnVisIndiceLibro";
            this.btnVisIndiceLibro.Size = new System.Drawing.Size(106, 23);
            this.btnVisIndiceLibro.TabIndex = 7;
            this.btnVisIndiceLibro.Text = "Visualizza libro";
            this.btnVisIndiceLibro.UseVisualStyleBackColor = true;
            this.btnVisIndiceLibro.Click += new System.EventHandler(this.btnVisIndiceLibro_Click);
            // 
            // btnAddCoda
            // 
            this.btnAddCoda.Location = new System.Drawing.Point(95, 262);
            this.btnAddCoda.Name = "btnAddCoda";
            this.btnAddCoda.Size = new System.Drawing.Size(120, 23);
            this.btnAddCoda.TabIndex = 8;
            this.btnAddCoda.Text = "Aggiungi in coda";
            this.btnAddCoda.UseVisualStyleBackColor = true;
            this.btnAddCoda.Click += new System.EventHandler(this.btnAddCoda_Click);
            // 
            // btnAddInStack
            // 
            this.btnAddInStack.Location = new System.Drawing.Point(95, 307);
            this.btnAddInStack.Name = "btnAddInStack";
            this.btnAddInStack.Size = new System.Drawing.Size(120, 23);
            this.btnAddInStack.TabIndex = 9;
            this.btnAddInStack.Text = "Aggiungi in stack";
            this.btnAddInStack.UseVisualStyleBackColor = true;
            this.btnAddInStack.Click += new System.EventHandler(this.btnAddInStack_Click);
            // 
            // btnEstraiCoda
            // 
            this.btnEstraiCoda.Location = new System.Drawing.Point(95, 348);
            this.btnEstraiCoda.Name = "btnEstraiCoda";
            this.btnEstraiCoda.Size = new System.Drawing.Size(120, 23);
            this.btnEstraiCoda.TabIndex = 10;
            this.btnEstraiCoda.Text = "Estrai da coda";
            this.btnEstraiCoda.UseVisualStyleBackColor = true;
            this.btnEstraiCoda.Click += new System.EventHandler(this.btnEstraiCoda_Click);
            // 
            // btnEstraiDaStack
            // 
            this.btnEstraiDaStack.Location = new System.Drawing.Point(95, 389);
            this.btnEstraiDaStack.Name = "btnEstraiDaStack";
            this.btnEstraiDaStack.Size = new System.Drawing.Size(120, 23);
            this.btnEstraiDaStack.TabIndex = 11;
            this.btnEstraiDaStack.Text = "Estrai da stack";
            this.btnEstraiDaStack.UseVisualStyleBackColor = true;
            this.btnEstraiDaStack.Click += new System.EventHandler(this.btnEstraiDaStack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEstraiDaStack);
            this.Controls.Add(this.btnEstraiCoda);
            this.Controls.Add(this.btnAddInStack);
            this.Controls.Add(this.btnAddCoda);
            this.Controls.Add(this.btnVisIndiceLibro);
            this.Controls.Add(this.nudIndiceLibro);
            this.Controls.Add(this.btnVisElm);
            this.Controls.Add(this.btnAddLibro);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudIndiceLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddLibro;
        private System.Windows.Forms.Button btnVisElm;
        private System.Windows.Forms.NumericUpDown nudIndiceLibro;
        private System.Windows.Forms.Button btnVisIndiceLibro;
        private System.Windows.Forms.Button btnAddCoda;
        private System.Windows.Forms.Button btnAddInStack;
        private System.Windows.Forms.Button btnEstraiCoda;
        private System.Windows.Forms.Button btnEstraiDaStack;
    }
}

