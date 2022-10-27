
namespace AhorcaditoSimple
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
            this.label2 = new System.Windows.Forms.Label();
            this.textoLetraIngresada = new System.Windows.Forms.TextBox();
            this.botonEvaluaLetra = new System.Windows.Forms.Button();
            this.textoLetra1 = new System.Windows.Forms.TextBox();
            this.textoLetra2 = new System.Windows.Forms.TextBox();
            this.textoLetra3 = new System.Windows.Forms.TextBox();
            this.textoLetra4 = new System.Windows.Forms.TextBox();
            this.textoLetra6 = new System.Windows.Forms.TextBox();
            this.textoLetra5 = new System.Windows.Forms.TextBox();
            this.textoLetra7 = new System.Windows.Forms.TextBox();
            this.textoLetra8 = new System.Windows.Forms.TextBox();
            this.textoLetra9 = new System.Windows.Forms.TextBox();
            this.textoLetra10 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textoLetrasColocadas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textoFallos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textoAciertos = new System.Windows.Forms.TextBox();
            this.botonReiniciaJuego = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ahorcadito Simple";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa una letra:";
            // 
            // textoLetraIngresada
            // 
            this.textoLetraIngresada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLetraIngresada.Location = new System.Drawing.Point(209, 86);
            this.textoLetraIngresada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoLetraIngresada.MaxLength = 1;
            this.textoLetraIngresada.Name = "textoLetraIngresada";
            this.textoLetraIngresada.Size = new System.Drawing.Size(25, 30);
            this.textoLetraIngresada.TabIndex = 2;
            this.textoLetraIngresada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // botonEvaluaLetra
            // 
            this.botonEvaluaLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEvaluaLetra.Location = new System.Drawing.Point(249, 85);
            this.botonEvaluaLetra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonEvaluaLetra.Name = "botonEvaluaLetra";
            this.botonEvaluaLetra.Size = new System.Drawing.Size(217, 32);
            this.botonEvaluaLetra.TabIndex = 3;
            this.botonEvaluaLetra.Text = "Evalua letra";
            this.botonEvaluaLetra.UseVisualStyleBackColor = true;
            this.botonEvaluaLetra.Click += new System.EventHandler(this.botonEvaluaLetra_Click);
            // 
            // textoLetra1
            // 
            this.textoLetra1.Enabled = false;
            this.textoLetra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLetra1.Location = new System.Drawing.Point(27, 158);
            this.textoLetra1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoLetra1.Name = "textoLetra1";
            this.textoLetra1.Size = new System.Drawing.Size(25, 30);
            this.textoLetra1.TabIndex = 4;
            this.textoLetra1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textoLetra2
            // 
            this.textoLetra2.Enabled = false;
            this.textoLetra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLetra2.Location = new System.Drawing.Point(72, 158);
            this.textoLetra2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoLetra2.Name = "textoLetra2";
            this.textoLetra2.Size = new System.Drawing.Size(25, 30);
            this.textoLetra2.TabIndex = 5;
            this.textoLetra2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textoLetra3
            // 
            this.textoLetra3.Enabled = false;
            this.textoLetra3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLetra3.Location = new System.Drawing.Point(116, 158);
            this.textoLetra3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoLetra3.Name = "textoLetra3";
            this.textoLetra3.Size = new System.Drawing.Size(25, 30);
            this.textoLetra3.TabIndex = 7;
            this.textoLetra3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textoLetra4
            // 
            this.textoLetra4.Enabled = false;
            this.textoLetra4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLetra4.Location = new System.Drawing.Point(161, 158);
            this.textoLetra4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoLetra4.Name = "textoLetra4";
            this.textoLetra4.Size = new System.Drawing.Size(25, 30);
            this.textoLetra4.TabIndex = 10;
            this.textoLetra4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textoLetra6
            // 
            this.textoLetra6.Enabled = false;
            this.textoLetra6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLetra6.Location = new System.Drawing.Point(249, 158);
            this.textoLetra6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoLetra6.Name = "textoLetra6";
            this.textoLetra6.Size = new System.Drawing.Size(25, 30);
            this.textoLetra6.TabIndex = 9;
            this.textoLetra6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textoLetra5
            // 
            this.textoLetra5.Enabled = false;
            this.textoLetra5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLetra5.Location = new System.Drawing.Point(205, 158);
            this.textoLetra5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoLetra5.Name = "textoLetra5";
            this.textoLetra5.Size = new System.Drawing.Size(25, 30);
            this.textoLetra5.TabIndex = 8;
            this.textoLetra5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textoLetra7
            // 
            this.textoLetra7.Enabled = false;
            this.textoLetra7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLetra7.Location = new System.Drawing.Point(295, 158);
            this.textoLetra7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoLetra7.Name = "textoLetra7";
            this.textoLetra7.Size = new System.Drawing.Size(25, 30);
            this.textoLetra7.TabIndex = 13;
            this.textoLetra7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textoLetra8
            // 
            this.textoLetra8.Enabled = false;
            this.textoLetra8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLetra8.Location = new System.Drawing.Point(339, 158);
            this.textoLetra8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoLetra8.Name = "textoLetra8";
            this.textoLetra8.Size = new System.Drawing.Size(25, 30);
            this.textoLetra8.TabIndex = 12;
            this.textoLetra8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textoLetra9
            // 
            this.textoLetra9.Enabled = false;
            this.textoLetra9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLetra9.Location = new System.Drawing.Point(384, 158);
            this.textoLetra9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoLetra9.Name = "textoLetra9";
            this.textoLetra9.Size = new System.Drawing.Size(25, 30);
            this.textoLetra9.TabIndex = 11;
            this.textoLetra9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textoLetra10
            // 
            this.textoLetra10.Enabled = false;
            this.textoLetra10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLetra10.Location = new System.Drawing.Point(428, 158);
            this.textoLetra10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoLetra10.Name = "textoLetra10";
            this.textoLetra10.Size = new System.Drawing.Size(25, 30);
            this.textoLetra10.TabIndex = 14;
            this.textoLetra10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Letras colocadas:";
            // 
            // textoLetrasColocadas
            // 
            this.textoLetrasColocadas.Enabled = false;
            this.textoLetrasColocadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLetrasColocadas.Location = new System.Drawing.Point(205, 220);
            this.textoLetrasColocadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoLetrasColocadas.Name = "textoLetrasColocadas";
            this.textoLetrasColocadas.Size = new System.Drawing.Size(260, 30);
            this.textoLetrasColocadas.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fallos:";
            // 
            // textoFallos
            // 
            this.textoFallos.Enabled = false;
            this.textoFallos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoFallos.Location = new System.Drawing.Point(136, 279);
            this.textoFallos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoFallos.Name = "textoFallos";
            this.textoFallos.Size = new System.Drawing.Size(81, 30);
            this.textoFallos.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(257, 284);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Aciertos:";
            // 
            // textoAciertos
            // 
            this.textoAciertos.Enabled = false;
            this.textoAciertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoAciertos.Location = new System.Drawing.Point(344, 279);
            this.textoAciertos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoAciertos.Name = "textoAciertos";
            this.textoAciertos.Size = new System.Drawing.Size(81, 30);
            this.textoAciertos.TabIndex = 22;
            // 
            // botonReiniciaJuego
            // 
            this.botonReiniciaJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonReiniciaJuego.Location = new System.Drawing.Point(27, 334);
            this.botonReiniciaJuego.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonReiniciaJuego.Name = "botonReiniciaJuego";
            this.botonReiniciaJuego.Size = new System.Drawing.Size(439, 47);
            this.botonReiniciaJuego.TabIndex = 23;
            this.botonReiniciaJuego.Text = "Reinicia Juego";
            this.botonReiniciaJuego.UseVisualStyleBackColor = true;
            this.botonReiniciaJuego.Click += new System.EventHandler(this.botonReiniciaJuego_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 417);
            this.Controls.Add(this.botonReiniciaJuego);
            this.Controls.Add(this.textoAciertos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textoFallos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textoLetrasColocadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textoLetra10);
            this.Controls.Add(this.textoLetra7);
            this.Controls.Add(this.textoLetra8);
            this.Controls.Add(this.textoLetra9);
            this.Controls.Add(this.textoLetra4);
            this.Controls.Add(this.textoLetra6);
            this.Controls.Add(this.textoLetra5);
            this.Controls.Add(this.textoLetra3);
            this.Controls.Add(this.textoLetra2);
            this.Controls.Add(this.textoLetra1);
            this.Controls.Add(this.botonEvaluaLetra);
            this.Controls.Add(this.textoLetraIngresada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ahorcadito Simple";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoLetraIngresada;
        private System.Windows.Forms.Button botonEvaluaLetra;
        private System.Windows.Forms.TextBox textoLetra1;
        private System.Windows.Forms.TextBox textoLetra2;
        private System.Windows.Forms.TextBox textoLetra3;
        private System.Windows.Forms.TextBox textoLetra4;
        private System.Windows.Forms.TextBox textoLetra6;
        private System.Windows.Forms.TextBox textoLetra5;
        private System.Windows.Forms.TextBox textoLetra7;
        private System.Windows.Forms.TextBox textoLetra8;
        private System.Windows.Forms.TextBox textoLetra9;
        private System.Windows.Forms.TextBox textoLetra10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textoLetrasColocadas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textoFallos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textoAciertos;
        private System.Windows.Forms.Button botonReiniciaJuego;
    }
}