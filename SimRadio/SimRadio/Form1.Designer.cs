namespace SimRadio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LabelFrecuencia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelVolumen = new System.Windows.Forms.Label();
            this.BotonEstado = new System.Windows.Forms.Button();
            this.BotonFmas = new System.Windows.Forms.Button();
            this.BotonFmenos = new System.Windows.Forms.Button();
            this.BotonVmas = new System.Windows.Forms.Button();
            this.BotonVmenos = new System.Windows.Forms.Button();
            this.TrackVolumen = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.TrackVolumen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulador de Radio";
            // 
            // LabelFrecuencia
            // 
            this.LabelFrecuencia.BackColor = System.Drawing.Color.Black;
            this.LabelFrecuencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFrecuencia.ForeColor = System.Drawing.Color.Yellow;
            this.LabelFrecuencia.Location = new System.Drawing.Point(23, 91);
            this.LabelFrecuencia.Name = "LabelFrecuencia";
            this.LabelFrecuencia.Size = new System.Drawing.Size(342, 73);
            this.LabelFrecuencia.TabIndex = 1;
            this.LabelFrecuencia.Text = "000.0 MHz";
            this.LabelFrecuencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Frecuencia actual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Volumen:";
            // 
            // LabelVolumen
            // 
            this.LabelVolumen.BackColor = System.Drawing.Color.Black;
            this.LabelVolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVolumen.ForeColor = System.Drawing.Color.Fuchsia;
            this.LabelVolumen.Location = new System.Drawing.Point(429, 91);
            this.LabelVolumen.Name = "LabelVolumen";
            this.LabelVolumen.Size = new System.Drawing.Size(104, 73);
            this.LabelVolumen.TabIndex = 4;
            this.LabelVolumen.Text = "00";
            this.LabelVolumen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BotonEstado
            // 
            this.BotonEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEstado.Location = new System.Drawing.Point(442, 20);
            this.BotonEstado.Name = "BotonEstado";
            this.BotonEstado.Size = new System.Drawing.Size(136, 40);
            this.BotonEstado.TabIndex = 5;
            this.BotonEstado.Text = "Encendido / Apagado";
            this.BotonEstado.UseVisualStyleBackColor = true;
            this.BotonEstado.Click += new System.EventHandler(this.BotonEstado_Click);
            // 
            // BotonFmas
            // 
            this.BotonFmas.Location = new System.Drawing.Point(371, 91);
            this.BotonFmas.Name = "BotonFmas";
            this.BotonFmas.Size = new System.Drawing.Size(37, 23);
            this.BotonFmas.TabIndex = 6;
            this.BotonFmas.Text = "F+";
            this.BotonFmas.UseVisualStyleBackColor = true;
            this.BotonFmas.Click += new System.EventHandler(this.BotonFmas_Click);
            // 
            // BotonFmenos
            // 
            this.BotonFmenos.Location = new System.Drawing.Point(371, 141);
            this.BotonFmenos.Name = "BotonFmenos";
            this.BotonFmenos.Size = new System.Drawing.Size(37, 23);
            this.BotonFmenos.TabIndex = 7;
            this.BotonFmenos.Text = "F-";
            this.BotonFmenos.UseVisualStyleBackColor = true;
            this.BotonFmenos.Click += new System.EventHandler(this.BotonFmenos_Click);
            // 
            // BotonVmas
            // 
            this.BotonVmas.Location = new System.Drawing.Point(541, 91);
            this.BotonVmas.Name = "BotonVmas";
            this.BotonVmas.Size = new System.Drawing.Size(37, 23);
            this.BotonVmas.TabIndex = 8;
            this.BotonVmas.Text = "V+";
            this.BotonVmas.UseVisualStyleBackColor = true;
            this.BotonVmas.Click += new System.EventHandler(this.BotonVmas_Click);
            // 
            // BotonVmenos
            // 
            this.BotonVmenos.Location = new System.Drawing.Point(541, 141);
            this.BotonVmenos.Name = "BotonVmenos";
            this.BotonVmenos.Size = new System.Drawing.Size(37, 23);
            this.BotonVmenos.TabIndex = 9;
            this.BotonVmenos.Text = "V-";
            this.BotonVmenos.UseVisualStyleBackColor = true;
            this.BotonVmenos.Click += new System.EventHandler(this.BotonVmenos_Click);
            // 
            // TrackVolumen
            // 
            this.TrackVolumen.Location = new System.Drawing.Point(424, 178);
            this.TrackVolumen.Name = "TrackVolumen";
            this.TrackVolumen.Size = new System.Drawing.Size(104, 45);
            this.TrackVolumen.TabIndex = 11;
            this.TrackVolumen.Scroll += new System.EventHandler(this.TrackVolumen_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 235);
            this.Controls.Add(this.TrackVolumen);
            this.Controls.Add(this.BotonVmenos);
            this.Controls.Add(this.BotonVmas);
            this.Controls.Add(this.BotonFmenos);
            this.Controls.Add(this.BotonFmas);
            this.Controls.Add(this.BotonEstado);
            this.Controls.Add(this.LabelVolumen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelFrecuencia);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de Radio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackVolumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelFrecuencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelVolumen;
        private System.Windows.Forms.Button BotonEstado;
        private System.Windows.Forms.Button BotonFmas;
        private System.Windows.Forms.Button BotonFmenos;
        private System.Windows.Forms.Button BotonVmas;
        private System.Windows.Forms.Button BotonVmenos;
        private System.Windows.Forms.TrackBar TrackVolumen;
    }
}

