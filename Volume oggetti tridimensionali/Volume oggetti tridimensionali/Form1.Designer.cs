﻿namespace Volume_oggetti_tridimensionali
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
            this.txtRaggio = new System.Windows.Forms.TextBox();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLato1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLato2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAreaCilindro = new System.Windows.Forms.Button();
            this.btnAreaParallelepipedo = new System.Windows.Forms.Button();
            this.btnVolumeCilindro = new System.Windows.Forms.Button();
            this.btnVolumeParallelepipedo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raggio";
            // 
            // txtRaggio
            // 
            this.txtRaggio.Location = new System.Drawing.Point(143, 36);
            this.txtRaggio.Name = "txtRaggio";
            this.txtRaggio.Size = new System.Drawing.Size(100, 20);
            this.txtRaggio.TabIndex = 1;
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(333, 138);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(100, 20);
            this.txtAltezza.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altezza";
            // 
            // txtLato1
            // 
            this.txtLato1.Location = new System.Drawing.Point(587, 36);
            this.txtLato1.Name = "txtLato1";
            this.txtLato1.Size = new System.Drawing.Size(100, 20);
            this.txtLato1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lato 1";
            // 
            // txtLato2
            // 
            this.txtLato2.Location = new System.Drawing.Point(587, 93);
            this.txtLato2.Name = "txtLato2";
            this.txtLato2.Size = new System.Drawing.Size(100, 20);
            this.txtLato2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lato 2";
            // 
            // btnAreaCilindro
            // 
            this.btnAreaCilindro.Location = new System.Drawing.Point(83, 231);
            this.btnAreaCilindro.Name = "btnAreaCilindro";
            this.btnAreaCilindro.Size = new System.Drawing.Size(100, 47);
            this.btnAreaCilindro.TabIndex = 8;
            this.btnAreaCilindro.Text = "Area Cilindro";
            this.btnAreaCilindro.UseVisualStyleBackColor = true;
            this.btnAreaCilindro.Click += new System.EventHandler(this.btnAreaCilindro_Click);
            // 
            // btnAreaParallelepipedo
            // 
            this.btnAreaParallelepipedo.Location = new System.Drawing.Point(577, 231);
            this.btnAreaParallelepipedo.Name = "btnAreaParallelepipedo";
            this.btnAreaParallelepipedo.Size = new System.Drawing.Size(100, 47);
            this.btnAreaParallelepipedo.TabIndex = 9;
            this.btnAreaParallelepipedo.Text = "Area parallelepipedo";
            this.btnAreaParallelepipedo.UseVisualStyleBackColor = true;
            this.btnAreaParallelepipedo.Click += new System.EventHandler(this.btnAreaParallelepipedo_Click);
            // 
            // btnVolumeCilindro
            // 
            this.btnVolumeCilindro.Location = new System.Drawing.Point(83, 318);
            this.btnVolumeCilindro.Name = "btnVolumeCilindro";
            this.btnVolumeCilindro.Size = new System.Drawing.Size(100, 47);
            this.btnVolumeCilindro.TabIndex = 10;
            this.btnVolumeCilindro.Text = "Volume cilindro";
            this.btnVolumeCilindro.UseVisualStyleBackColor = true;
            this.btnVolumeCilindro.Click += new System.EventHandler(this.btnVolumeCilindro_Click);
            // 
            // btnVolumeParallelepipedo
            // 
            this.btnVolumeParallelepipedo.Location = new System.Drawing.Point(577, 309);
            this.btnVolumeParallelepipedo.Name = "btnVolumeParallelepipedo";
            this.btnVolumeParallelepipedo.Size = new System.Drawing.Size(100, 47);
            this.btnVolumeParallelepipedo.TabIndex = 11;
            this.btnVolumeParallelepipedo.Text = "Volume parallelepipedo";
            this.btnVolumeParallelepipedo.UseVisualStyleBackColor = true;
            this.btnVolumeParallelepipedo.Click += new System.EventHandler(this.btnVolumeParallelepipedo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolumeParallelepipedo);
            this.Controls.Add(this.btnVolumeCilindro);
            this.Controls.Add(this.btnAreaParallelepipedo);
            this.Controls.Add(this.btnAreaCilindro);
            this.Controls.Add(this.txtLato2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLato1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAltezza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRaggio);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRaggio;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLato1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLato2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAreaCilindro;
        private System.Windows.Forms.Button btnAreaParallelepipedo;
        private System.Windows.Forms.Button btnVolumeCilindro;
        private System.Windows.Forms.Button btnVolumeParallelepipedo;
    }
}

