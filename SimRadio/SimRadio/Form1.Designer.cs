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
            components = new System.ComponentModel.Container();
            botonEncendido = new Button();
            label1 = new Label();
            etiquetaValorFrecuencia = new Label();
            label3 = new Label();
            etiquetaValorVolumen = new Label();
            botonSubeVolumen = new Button();
            botonBajaVolumen = new Button();
            botonSubeFrecuencia = new Button();
            botonBajaFrecuencia = new Button();
            SuspendLayout();
            // 
            // botonEncendido
            // 
            botonEncendido.BackColor = Color.Navy;
            botonEncendido.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            botonEncendido.ForeColor = Color.White;
            botonEncendido.Location = new Point(174, 12);
            botonEncendido.Name = "botonEncendido";
            botonEncendido.Size = new Size(75, 23);
            botonEncendido.TabIndex = 0;
            botonEncendido.Text = "ON/OFF";
            botonEncendido.UseVisualStyleBackColor = false;
            botonEncendido.Click += new System.EventHandler(botonEncendido_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 39);
            label1.Name = "label1";
            label1.Size = new Size(63, 13);
            label1.TabIndex = 1;
            label1.Text = "Frecuencia:";
            // 
            // etiquetaValorFrecuencia
            // 
            etiquetaValorFrecuencia.BackColor = Color.Black;
            etiquetaValorFrecuencia.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            etiquetaValorFrecuencia.ForeColor = Color.Yellow;
            etiquetaValorFrecuencia.Location = new Point(62, 63);
            etiquetaValorFrecuencia.Name = "etiquetaValorFrecuencia";
            etiquetaValorFrecuencia.Size = new Size(143, 55);
            etiquetaValorFrecuencia.TabIndex = 2;
            etiquetaValorFrecuencia.Text = "00.0";
            etiquetaValorFrecuencia.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 132);
            label3.Name = "label3";
            label3.Size = new Size(48, 13);
            label3.TabIndex = 3;
            label3.Text = "Volumen";
            // 
            // etiquetaValorVolumen
            // 
            etiquetaValorVolumen.BackColor = Color.Black;
            etiquetaValorVolumen.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            etiquetaValorVolumen.ForeColor = Color.Lime;
            etiquetaValorVolumen.Location = new Point(60, 160);
            etiquetaValorVolumen.Name = "etiquetaValorVolumen";
            etiquetaValorVolumen.Size = new Size(145, 54);
            etiquetaValorVolumen.TabIndex = 4;
            etiquetaValorVolumen.Text = "11";
            etiquetaValorVolumen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // botonSubeVolumen
            // 
            botonSubeVolumen.Location = new Point(211, 160);
            botonSubeVolumen.Name = "botonSubeVolumen";
            botonSubeVolumen.Size = new Size(38, 23);
            botonSubeVolumen.TabIndex = 5;
            botonSubeVolumen.Text = "V+";
            botonSubeVolumen.UseVisualStyleBackColor = true;
            botonSubeVolumen.Click += new System.EventHandler(botonSubeVolumen_Click);
            // 
            // botonBajaVolumen
            // 
            botonBajaVolumen.Location = new Point(211, 191);
            botonBajaVolumen.Name = "botonBajaVolumen";
            botonBajaVolumen.Size = new Size(38, 23);
            botonBajaVolumen.TabIndex = 6;
            botonBajaVolumen.Text = "V-";
            botonBajaVolumen.UseVisualStyleBackColor = true;
            botonBajaVolumen.Click += new System.EventHandler(botonBajaVolumen_Click);
            // 
            // botonSubeFrecuencia
            // 
            botonSubeFrecuencia.Location = new Point(211, 63);
            botonSubeFrecuencia.Name = "botonSubeFrecuencia";
            botonSubeFrecuencia.Size = new Size(38, 23);
            botonSubeFrecuencia.TabIndex = 7;
            botonSubeFrecuencia.Text = "F+";
            botonSubeFrecuencia.UseVisualStyleBackColor = true;
            botonSubeFrecuencia.Click += new System.EventHandler(botonSubeFrecuencia_Click);
            // 
            // botonBajaFrecuencia
            // 
            botonBajaFrecuencia.Location = new Point(211, 95);
            botonBajaFrecuencia.Name = "botonBajaFrecuencia";
            botonBajaFrecuencia.Size = new Size(38, 23);
            botonBajaFrecuencia.TabIndex = 8;
            botonBajaFrecuencia.Text = "F-";
            botonBajaFrecuencia.UseVisualStyleBackColor = true;
            botonBajaFrecuencia.Click += new System.EventHandler(botonBajaFrecuencia_Click);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(315, 234);
            Controls.Add(botonBajaFrecuencia);
            Controls.Add(botonSubeFrecuencia);
            Controls.Add(botonBajaVolumen);
            Controls.Add(botonSubeVolumen);
            Controls.Add(etiquetaValorVolumen);
            Controls.Add(label3);
            Controls.Add(etiquetaValorFrecuencia);
            Controls.Add(label1);
            Controls.Add(botonEncendido);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Simulador de Radio";
            Load += new System.EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();
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