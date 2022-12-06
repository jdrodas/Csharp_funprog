namespace SimRadio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.botonEncendido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.etiquetaValorFrecuencia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.etiquetaValorVolumen = new System.Windows.Forms.Label();
            this.botonSubeVolumen = new System.Windows.Forms.Button();
            this.botonBajaVolumen = new System.Windows.Forms.Button();
            this.botonSubeFrecuencia = new System.Windows.Forms.Button();
            this.botonBajaFrecuencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonEncendido
            // 
            this.botonEncendido.BackColor = System.Drawing.Color.Navy;
            this.botonEncendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEncendido.ForeColor = System.Drawing.Color.White;
            this.botonEncendido.Location = new System.Drawing.Point(174, 12);
            this.botonEncendido.Name = "botonEncendido";
            this.botonEncendido.Size = new System.Drawing.Size(75, 23);
            this.botonEncendido.TabIndex = 0;
            this.botonEncendido.Text = "ON/OFF";
            this.botonEncendido.UseVisualStyleBackColor = false;
            this.botonEncendido.Click += new System.EventHandler(this.botonEncendido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frecuencia:";
            // 
            // etiquetaValorFrecuencia
            // 
            this.etiquetaValorFrecuencia.BackColor = System.Drawing.Color.Black;
            this.etiquetaValorFrecuencia.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaValorFrecuencia.ForeColor = System.Drawing.Color.Yellow;
            this.etiquetaValorFrecuencia.Location = new System.Drawing.Point(62, 63);
            this.etiquetaValorFrecuencia.Name = "etiquetaValorFrecuencia";
            this.etiquetaValorFrecuencia.Size = new System.Drawing.Size(143, 55);
            this.etiquetaValorFrecuencia.TabIndex = 2;
            this.etiquetaValorFrecuencia.Text = "00.0";
            this.etiquetaValorFrecuencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Volumen";
            // 
            // etiquetaValorVolumen
            // 
            this.etiquetaValorVolumen.BackColor = System.Drawing.Color.Black;
            this.etiquetaValorVolumen.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaValorVolumen.ForeColor = System.Drawing.Color.Lime;
            this.etiquetaValorVolumen.Location = new System.Drawing.Point(60, 160);
            this.etiquetaValorVolumen.Name = "etiquetaValorVolumen";
            this.etiquetaValorVolumen.Size = new System.Drawing.Size(145, 54);
            this.etiquetaValorVolumen.TabIndex = 4;
            this.etiquetaValorVolumen.Text = "11";
            this.etiquetaValorVolumen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // botonSubeVolumen
            // 
            this.botonSubeVolumen.Location = new System.Drawing.Point(211, 160);
            this.botonSubeVolumen.Name = "botonSubeVolumen";
            this.botonSubeVolumen.Size = new System.Drawing.Size(38, 23);
            this.botonSubeVolumen.TabIndex = 5;
            this.botonSubeVolumen.Text = "V+";
            this.botonSubeVolumen.UseVisualStyleBackColor = true;
            this.botonSubeVolumen.Click += new System.EventHandler(this.botonSubeVolumen_Click);
            // 
            // botonBajaVolumen
            // 
            this.botonBajaVolumen.Location = new System.Drawing.Point(211, 191);
            this.botonBajaVolumen.Name = "botonBajaVolumen";
            this.botonBajaVolumen.Size = new System.Drawing.Size(38, 23);
            this.botonBajaVolumen.TabIndex = 6;
            this.botonBajaVolumen.Text = "V-";
            this.botonBajaVolumen.UseVisualStyleBackColor = true;
            this.botonBajaVolumen.Click += new System.EventHandler(this.botonBajaVolumen_Click);
            // 
            // botonSubeFrecuencia
            // 
            this.botonSubeFrecuencia.Location = new System.Drawing.Point(211, 63);
            this.botonSubeFrecuencia.Name = "botonSubeFrecuencia";
            this.botonSubeFrecuencia.Size = new System.Drawing.Size(38, 23);
            this.botonSubeFrecuencia.TabIndex = 7;
            this.botonSubeFrecuencia.Text = "F+";
            this.botonSubeFrecuencia.UseVisualStyleBackColor = true;
            this.botonSubeFrecuencia.Click += new System.EventHandler(this.botonSubeFrecuencia_Click);
            // 
            // botonBajaFrecuencia
            // 
            this.botonBajaFrecuencia.Location = new System.Drawing.Point(211, 95);
            this.botonBajaFrecuencia.Name = "botonBajaFrecuencia";
            this.botonBajaFrecuencia.Size = new System.Drawing.Size(38, 23);
            this.botonBajaFrecuencia.TabIndex = 8;
            this.botonBajaFrecuencia.Text = "F-";
            this.botonBajaFrecuencia.UseVisualStyleBackColor = true;
            this.botonBajaFrecuencia.Click += new System.EventHandler(this.botonBajaFrecuencia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 234);
            this.Controls.Add(this.botonBajaFrecuencia);
            this.Controls.Add(this.botonSubeFrecuencia);
            this.Controls.Add(this.botonBajaVolumen);
            this.Controls.Add(this.botonSubeVolumen);
            this.Controls.Add(this.etiquetaValorVolumen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.etiquetaValorFrecuencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonEncendido);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de Radio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button botonEncendido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label etiquetaValorFrecuencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label etiquetaValorVolumen;
        private System.Windows.Forms.Button botonSubeVolumen;
        private System.Windows.Forms.Button botonBajaVolumen;
        private System.Windows.Forms.Button botonSubeFrecuencia;
        private System.Windows.Forms.Button botonBajaFrecuencia;
    }
}