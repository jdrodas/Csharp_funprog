namespace AhorcaditoGrafico
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
            this.TextoLetraIngresada = new System.Windows.Forms.TextBox();
            this.BotonEvaluaLetra = new System.Windows.Forms.Button();
            this.TextoLetra1 = new System.Windows.Forms.TextBox();
            this.TextoLetra2 = new System.Windows.Forms.TextBox();
            this.TextoLetra4 = new System.Windows.Forms.TextBox();
            this.TextoLetra3 = new System.Windows.Forms.TextBox();
            this.TextoLetra8 = new System.Windows.Forms.TextBox();
            this.TextoLetra7 = new System.Windows.Forms.TextBox();
            this.TextoLetra6 = new System.Windows.Forms.TextBox();
            this.TextoLetra5 = new System.Windows.Forms.TextBox();
            this.TextoLetra10 = new System.Windows.Forms.TextBox();
            this.TextoLetra9 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextoLetrasColocadas = new System.Windows.Forms.TextBox();
            this.TextoPalabraBuscada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextoTotalFallos = new System.Windows.Forms.TextBox();
            this.BotonReiniciaJuego = new System.Windows.Forms.Button();
            this.TextoTotalAciertos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CuadroImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CuadroImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(117, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ahorcadito Gráfico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa una letra:";
            // 
            // TextoLetraIngresada
            // 
            this.TextoLetraIngresada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextoLetraIngresada.Location = new System.Drawing.Point(189, 100);
            this.TextoLetraIngresada.MaxLength = 1;
            this.TextoLetraIngresada.Name = "TextoLetraIngresada";
            this.TextoLetraIngresada.Size = new System.Drawing.Size(37, 22);
            this.TextoLetraIngresada.TabIndex = 2;
            this.TextoLetraIngresada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BotonEvaluaLetra
            // 
            this.BotonEvaluaLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotonEvaluaLetra.ForeColor = System.Drawing.Color.Black;
            this.BotonEvaluaLetra.Location = new System.Drawing.Point(230, 97);
            this.BotonEvaluaLetra.Name = "BotonEvaluaLetra";
            this.BotonEvaluaLetra.Size = new System.Drawing.Size(139, 29);
            this.BotonEvaluaLetra.TabIndex = 3;
            this.BotonEvaluaLetra.Text = "Evalua Letra";
            this.BotonEvaluaLetra.UseVisualStyleBackColor = true;
            this.BotonEvaluaLetra.Click += new System.EventHandler(this.BotonEvaluaLetra_Click);
            // 
            // TextoLetra1
            // 
            this.TextoLetra1.BackColor = System.Drawing.Color.White;
            this.TextoLetra1.Enabled = false;
            this.TextoLetra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextoLetra1.Location = new System.Drawing.Point(50, 150);
            this.TextoLetra1.MaxLength = 1;
            this.TextoLetra1.Name = "TextoLetra1";
            this.TextoLetra1.Size = new System.Drawing.Size(26, 22);
            this.TextoLetra1.TabIndex = 4;
            this.TextoLetra1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextoLetra2
            // 
            this.TextoLetra2.BackColor = System.Drawing.Color.White;
            this.TextoLetra2.Enabled = false;
            this.TextoLetra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextoLetra2.Location = new System.Drawing.Point(80, 150);
            this.TextoLetra2.MaxLength = 1;
            this.TextoLetra2.Name = "TextoLetra2";
            this.TextoLetra2.Size = new System.Drawing.Size(26, 22);
            this.TextoLetra2.TabIndex = 5;
            this.TextoLetra2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextoLetra4
            // 
            this.TextoLetra4.BackColor = System.Drawing.Color.White;
            this.TextoLetra4.Enabled = false;
            this.TextoLetra4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextoLetra4.Location = new System.Drawing.Point(139, 150);
            this.TextoLetra4.MaxLength = 1;
            this.TextoLetra4.Name = "TextoLetra4";
            this.TextoLetra4.Size = new System.Drawing.Size(26, 22);
            this.TextoLetra4.TabIndex = 7;
            this.TextoLetra4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextoLetra3
            // 
            this.TextoLetra3.BackColor = System.Drawing.Color.White;
            this.TextoLetra3.Enabled = false;
            this.TextoLetra3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextoLetra3.Location = new System.Drawing.Point(109, 150);
            this.TextoLetra3.MaxLength = 1;
            this.TextoLetra3.Name = "TextoLetra3";
            this.TextoLetra3.Size = new System.Drawing.Size(26, 22);
            this.TextoLetra3.TabIndex = 6;
            this.TextoLetra3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextoLetra8
            // 
            this.TextoLetra8.BackColor = System.Drawing.Color.White;
            this.TextoLetra8.Enabled = false;
            this.TextoLetra8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextoLetra8.Location = new System.Drawing.Point(257, 150);
            this.TextoLetra8.MaxLength = 1;
            this.TextoLetra8.Name = "TextoLetra8";
            this.TextoLetra8.Size = new System.Drawing.Size(26, 22);
            this.TextoLetra8.TabIndex = 11;
            this.TextoLetra8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextoLetra7
            // 
            this.TextoLetra7.BackColor = System.Drawing.Color.White;
            this.TextoLetra7.Enabled = false;
            this.TextoLetra7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextoLetra7.Location = new System.Drawing.Point(227, 150);
            this.TextoLetra7.MaxLength = 1;
            this.TextoLetra7.Name = "TextoLetra7";
            this.TextoLetra7.Size = new System.Drawing.Size(26, 22);
            this.TextoLetra7.TabIndex = 10;
            this.TextoLetra7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextoLetra6
            // 
            this.TextoLetra6.BackColor = System.Drawing.Color.White;
            this.TextoLetra6.Enabled = false;
            this.TextoLetra6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextoLetra6.Location = new System.Drawing.Point(198, 150);
            this.TextoLetra6.MaxLength = 1;
            this.TextoLetra6.Name = "TextoLetra6";
            this.TextoLetra6.Size = new System.Drawing.Size(26, 22);
            this.TextoLetra6.TabIndex = 9;
            this.TextoLetra6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextoLetra5
            // 
            this.TextoLetra5.BackColor = System.Drawing.Color.White;
            this.TextoLetra5.Enabled = false;
            this.TextoLetra5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextoLetra5.Location = new System.Drawing.Point(168, 150);
            this.TextoLetra5.MaxLength = 1;
            this.TextoLetra5.Name = "TextoLetra5";
            this.TextoLetra5.Size = new System.Drawing.Size(26, 22);
            this.TextoLetra5.TabIndex = 8;
            this.TextoLetra5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextoLetra10
            // 
            this.TextoLetra10.BackColor = System.Drawing.Color.White;
            this.TextoLetra10.Enabled = false;
            this.TextoLetra10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextoLetra10.Location = new System.Drawing.Point(316, 150);
            this.TextoLetra10.MaxLength = 1;
            this.TextoLetra10.Name = "TextoLetra10";
            this.TextoLetra10.Size = new System.Drawing.Size(26, 22);
            this.TextoLetra10.TabIndex = 13;
            this.TextoLetra10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextoLetra9
            // 
            this.TextoLetra9.BackColor = System.Drawing.Color.White;
            this.TextoLetra9.Enabled = false;
            this.TextoLetra9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextoLetra9.Location = new System.Drawing.Point(286, 150);
            this.TextoLetra9.MaxLength = 1;
            this.TextoLetra9.Name = "TextoLetra9";
            this.TextoLetra9.Size = new System.Drawing.Size(26, 22);
            this.TextoLetra9.TabIndex = 12;
            this.TextoLetra9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Letras colocadas:";
            // 
            // TextoLetrasColocadas
            // 
            this.TextoLetrasColocadas.BackColor = System.Drawing.Color.White;
            this.TextoLetrasColocadas.Enabled = false;
            this.TextoLetrasColocadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextoLetrasColocadas.Location = new System.Drawing.Point(179, 188);
            this.TextoLetrasColocadas.Name = "TextoLetrasColocadas";
            this.TextoLetrasColocadas.Size = new System.Drawing.Size(163, 22);
            this.TextoLetrasColocadas.TabIndex = 15;
            // 
            // TextoPalabraBuscada
            // 
            this.TextoPalabraBuscada.BackColor = System.Drawing.Color.White;
            this.TextoPalabraBuscada.Enabled = false;
            this.TextoPalabraBuscada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextoPalabraBuscada.Location = new System.Drawing.Point(179, 225);
            this.TextoPalabraBuscada.Name = "TextoPalabraBuscada";
            this.TextoPalabraBuscada.Size = new System.Drawing.Size(163, 22);
            this.TextoPalabraBuscada.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Palabra buscada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(87, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Fallos:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextoTotalFallos
            // 
            this.TextoTotalFallos.BackColor = System.Drawing.Color.White;
            this.TextoTotalFallos.Enabled = false;
            this.TextoTotalFallos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextoTotalFallos.Location = new System.Drawing.Point(150, 259);
            this.TextoTotalFallos.Name = "TextoTotalFallos";
            this.TextoTotalFallos.Size = new System.Drawing.Size(45, 22);
            this.TextoTotalFallos.TabIndex = 19;
            this.TextoTotalFallos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BotonReiniciaJuego
            // 
            this.BotonReiniciaJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotonReiniciaJuego.Location = new System.Drawing.Point(52, 308);
            this.BotonReiniciaJuego.Name = "BotonReiniciaJuego";
            this.BotonReiniciaJuego.Size = new System.Drawing.Size(300, 29);
            this.BotonReiniciaJuego.TabIndex = 20;
            this.BotonReiniciaJuego.Text = "Reinicia Juego";
            this.BotonReiniciaJuego.UseVisualStyleBackColor = true;
            this.BotonReiniciaJuego.Click += new System.EventHandler(this.BotonReiniciaJuego_Click);
            // 
            // TextoTotalAciertos
            // 
            this.TextoTotalAciertos.BackColor = System.Drawing.Color.White;
            this.TextoTotalAciertos.Enabled = false;
            this.TextoTotalAciertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextoTotalAciertos.Location = new System.Drawing.Point(296, 259);
            this.TextoTotalAciertos.Name = "TextoTotalAciertos";
            this.TextoTotalAciertos.Size = new System.Drawing.Size(45, 22);
            this.TextoTotalAciertos.TabIndex = 22;
            this.TextoTotalAciertos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(211, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Aciertos:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CuadroImagen
            // 
            this.CuadroImagen.BackColor = System.Drawing.Color.White;
            this.CuadroImagen.Location = new System.Drawing.Point(394, 102);
            this.CuadroImagen.Name = "CuadroImagen";
            this.CuadroImagen.Size = new System.Drawing.Size(230, 240);
            this.CuadroImagen.TabIndex = 23;
            this.CuadroImagen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 377);
            this.Controls.Add(this.CuadroImagen);
            this.Controls.Add(this.TextoTotalAciertos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BotonReiniciaJuego);
            this.Controls.Add(this.TextoTotalFallos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextoPalabraBuscada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextoLetrasColocadas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextoLetra10);
            this.Controls.Add(this.TextoLetra9);
            this.Controls.Add(this.TextoLetra8);
            this.Controls.Add(this.TextoLetra7);
            this.Controls.Add(this.TextoLetra6);
            this.Controls.Add(this.TextoLetra5);
            this.Controls.Add(this.TextoLetra4);
            this.Controls.Add(this.TextoLetra3);
            this.Controls.Add(this.TextoLetra2);
            this.Controls.Add(this.TextoLetra1);
            this.Controls.Add(this.BotonEvaluaLetra);
            this.Controls.Add(this.TextoLetraIngresada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ahorcadito Gráfico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CuadroImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextoLetraIngresada;
        private System.Windows.Forms.Button BotonEvaluaLetra;
        private System.Windows.Forms.TextBox TextoLetra1;
        private System.Windows.Forms.TextBox TextoLetra2;
        private System.Windows.Forms.TextBox TextoLetra4;
        private System.Windows.Forms.TextBox TextoLetra3;
        private System.Windows.Forms.TextBox TextoLetra8;
        private System.Windows.Forms.TextBox TextoLetra7;
        private System.Windows.Forms.TextBox TextoLetra6;
        private System.Windows.Forms.TextBox TextoLetra5;
        private System.Windows.Forms.TextBox TextoLetra10;
        private System.Windows.Forms.TextBox TextoLetra9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextoLetrasColocadas;
        private System.Windows.Forms.TextBox TextoPalabraBuscada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextoTotalFallos;
        private System.Windows.Forms.Button BotonReiniciaJuego;
        private System.Windows.Forms.TextBox TextoTotalAciertos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox CuadroImagen;
    }
}