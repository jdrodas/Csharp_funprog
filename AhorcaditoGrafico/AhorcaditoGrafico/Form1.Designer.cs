using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AhorcaditoGrafico
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
            label1 = new Label();
            label2 = new Label();
            TextoLetraIngresada = new TextBox();
            BotonEvaluaLetra = new Button();
            TextoLetra1 = new TextBox();
            TextoLetra2 = new TextBox();
            TextoLetra3 = new TextBox();
            TextoLetra4 = new TextBox();
            TextoLetra5 = new TextBox();
            TextoLetra6 = new TextBox();
            TextoLetra7 = new TextBox();
            TextoLetra8 = new TextBox();
            TextoLetra9 = new TextBox();
            TextoLetra10 = new TextBox();
            label3 = new Label();
            TextoLetrasColocadas = new TextBox();
            TextoPalabraBuscada = new TextBox();
            label4 = new Label();
            label5 = new Label();
            TextoTotalFallos = new TextBox();
            BotonReiniciaJuego = new Button();
            TextoTotalAciertos = new TextBox();
            label6 = new Label();
            CuadroImagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CuadroImagen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25.8F, FontStyle.Bold);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(128, 36);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(622, 79);
            label1.TabIndex = 0;
            label1.Text = "Ahorcadito Gráfico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(141, 169);
            label2.Name = "label2";
            label2.Size = new Size(210, 30);
            label2.TabIndex = 1;
            label2.Text = "Ingresa una letra:";
            // 
            // TextoLetraIngresada
            // 
            TextoLetraIngresada.Font = new Font("Microsoft Sans Serif", 9.75F);
            TextoLetraIngresada.Location = new Point(357, 166);
            TextoLetraIngresada.MaxLength = 1;
            TextoLetraIngresada.Name = "TextoLetraIngresada";
            TextoLetraIngresada.Size = new Size(37, 37);
            TextoLetraIngresada.TabIndex = 2;
            TextoLetraIngresada.TextAlign = HorizontalAlignment.Center;
            // 
            // BotonEvaluaLetra
            // 
            BotonEvaluaLetra.Font = new Font("Microsoft Sans Serif", 9.75F);
            BotonEvaluaLetra.ForeColor = Color.Black;
            BotonEvaluaLetra.Location = new Point(410, 160);
            BotonEvaluaLetra.Name = "BotonEvaluaLetra";
            BotonEvaluaLetra.Size = new Size(249, 48);
            BotonEvaluaLetra.TabIndex = 3;
            BotonEvaluaLetra.Text = "Evalua Letra";
            BotonEvaluaLetra.UseVisualStyleBackColor = true;
            BotonEvaluaLetra.Click += BotonEvaluaLetra_Click;
            // 
            // TextoLetra1
            // 
            TextoLetra1.BackColor = Color.White;
            TextoLetra1.Enabled = false;
            TextoLetra1.Font = new Font("Microsoft Sans Serif", 9.75F);
            TextoLetra1.Location = new Point(144, 251);
            TextoLetra1.MaxLength = 1;
            TextoLetra1.Name = "TextoLetra1";
            TextoLetra1.Size = new Size(26, 37);
            TextoLetra1.TabIndex = 4;
            TextoLetra1.TextAlign = HorizontalAlignment.Center;
            // 
            // TextoLetra2
            // 
            TextoLetra2.BackColor = Color.White;
            TextoLetra2.Enabled = false;
            TextoLetra2.Font = new Font("Microsoft Sans Serif", 9.75F);
            TextoLetra2.Location = new Point(174, 251);
            TextoLetra2.MaxLength = 1;
            TextoLetra2.Name = "TextoLetra2";
            TextoLetra2.Size = new Size(26, 37);
            TextoLetra2.TabIndex = 5;
            TextoLetra2.TextAlign = HorizontalAlignment.Center;
            // 
            // TextoLetra3
            // 
            TextoLetra3.BackColor = Color.White;
            TextoLetra3.Enabled = false;
            TextoLetra3.Font = new Font("Microsoft Sans Serif", 9.75F);
            TextoLetra3.Location = new Point(203, 251);
            TextoLetra3.MaxLength = 1;
            TextoLetra3.Name = "TextoLetra3";
            TextoLetra3.Size = new Size(26, 37);
            TextoLetra3.TabIndex = 6;
            TextoLetra3.TextAlign = HorizontalAlignment.Center;
            // 
            // TextoLetra4
            // 
            TextoLetra4.BackColor = Color.White;
            TextoLetra4.Enabled = false;
            TextoLetra4.Font = new Font("Microsoft Sans Serif", 9.75F);
            TextoLetra4.Location = new Point(233, 251);
            TextoLetra4.MaxLength = 1;
            TextoLetra4.Name = "TextoLetra4";
            TextoLetra4.Size = new Size(26, 37);
            TextoLetra4.TabIndex = 7;
            TextoLetra4.TextAlign = HorizontalAlignment.Center;
            // 
            // TextoLetra5
            // 
            TextoLetra5.BackColor = Color.White;
            TextoLetra5.Enabled = false;
            TextoLetra5.Font = new Font("Microsoft Sans Serif", 9.75F);
            TextoLetra5.Location = new Point(262, 251);
            TextoLetra5.MaxLength = 1;
            TextoLetra5.Name = "TextoLetra5";
            TextoLetra5.Size = new Size(26, 37);
            TextoLetra5.TabIndex = 8;
            TextoLetra5.TextAlign = HorizontalAlignment.Center;
            // 
            // TextoLetra6
            // 
            TextoLetra6.BackColor = Color.White;
            TextoLetra6.Enabled = false;
            TextoLetra6.Font = new Font("Microsoft Sans Serif", 9.75F);
            TextoLetra6.Location = new Point(292, 251);
            TextoLetra6.MaxLength = 1;
            TextoLetra6.Name = "TextoLetra6";
            TextoLetra6.Size = new Size(26, 37);
            TextoLetra6.TabIndex = 9;
            TextoLetra6.TextAlign = HorizontalAlignment.Center;
            // 
            // TextoLetra7
            // 
            TextoLetra7.BackColor = Color.White;
            TextoLetra7.Enabled = false;
            TextoLetra7.Font = new Font("Microsoft Sans Serif", 9.75F);
            TextoLetra7.Location = new Point(321, 251);
            TextoLetra7.MaxLength = 1;
            TextoLetra7.Name = "TextoLetra7";
            TextoLetra7.Size = new Size(26, 37);
            TextoLetra7.TabIndex = 10;
            TextoLetra7.TextAlign = HorizontalAlignment.Center;
            // 
            // TextoLetra8
            // 
            TextoLetra8.BackColor = Color.White;
            TextoLetra8.Enabled = false;
            TextoLetra8.Font = new Font("Microsoft Sans Serif", 9.75F);
            TextoLetra8.Location = new Point(351, 251);
            TextoLetra8.MaxLength = 1;
            TextoLetra8.Name = "TextoLetra8";
            TextoLetra8.Size = new Size(26, 37);
            TextoLetra8.TabIndex = 11;
            TextoLetra8.TextAlign = HorizontalAlignment.Center;
            // 
            // TextoLetra9
            // 
            TextoLetra9.BackColor = Color.White;
            TextoLetra9.Enabled = false;
            TextoLetra9.Font = new Font("Microsoft Sans Serif", 9.75F);
            TextoLetra9.Location = new Point(380, 251);
            TextoLetra9.MaxLength = 1;
            TextoLetra9.Name = "TextoLetra9";
            TextoLetra9.Size = new Size(26, 37);
            TextoLetra9.TabIndex = 12;
            TextoLetra9.TextAlign = HorizontalAlignment.Center;
            // 
            // TextoLetra10
            // 
            TextoLetra10.BackColor = Color.White;
            TextoLetra10.Enabled = false;
            TextoLetra10.Font = new Font("Microsoft Sans Serif", 9.75F);
            TextoLetra10.Location = new Point(410, 251);
            TextoLetra10.MaxLength = 1;
            TextoLetra10.Name = "TextoLetra10";
            TextoLetra10.Size = new Size(26, 37);
            TextoLetra10.TabIndex = 13;
            TextoLetra10.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(52, 346);
            label3.Name = "label3";
            label3.Size = new Size(213, 30);
            label3.TabIndex = 14;
            label3.Text = "Letras colocadas:";
            // 
            // TextoLetrasColocadas
            // 
            TextoLetrasColocadas.BackColor = Color.White;
            TextoLetrasColocadas.Enabled = false;
            TextoLetrasColocadas.Font = new Font("Microsoft Sans Serif", 9.75F);
            TextoLetrasColocadas.Location = new Point(268, 343);
            TextoLetrasColocadas.Name = "TextoLetrasColocadas";
            TextoLetrasColocadas.Size = new Size(317, 37);
            TextoLetrasColocadas.TabIndex = 15;
            // 
            // TextoPalabraBuscada
            // 
            TextoPalabraBuscada.BackColor = Color.White;
            TextoPalabraBuscada.Enabled = false;
            TextoPalabraBuscada.Font = new Font("Microsoft Sans Serif", 9.75F);
            TextoPalabraBuscada.Location = new Point(268, 423);
            TextoPalabraBuscada.Name = "TextoPalabraBuscada";
            TextoPalabraBuscada.Size = new Size(317, 37);
            TextoPalabraBuscada.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(51, 423);
            label4.Name = "label4";
            label4.Size = new Size(211, 30);
            label4.TabIndex = 17;
            label4.Text = "Palabra buscada:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(52, 501);
            label5.Name = "label5";
            label5.Size = new Size(89, 30);
            label5.TabIndex = 18;
            label5.Text = "Fallos:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TextoTotalFallos
            // 
            TextoTotalFallos.BackColor = Color.White;
            TextoTotalFallos.Enabled = false;
            TextoTotalFallos.Font = new Font("Microsoft Sans Serif", 9.75F);
            TextoTotalFallos.Location = new Point(144, 498);
            TextoTotalFallos.Name = "TextoTotalFallos";
            TextoTotalFallos.Size = new Size(45, 37);
            TextoTotalFallos.TabIndex = 19;
            TextoTotalFallos.TextAlign = HorizontalAlignment.Right;
            // 
            // BotonReiniciaJuego
            // 
            BotonReiniciaJuego.Font = new Font("Microsoft Sans Serif", 9.75F);
            BotonReiniciaJuego.Location = new Point(233, 607);
            BotonReiniciaJuego.Name = "BotonReiniciaJuego";
            BotonReiniciaJuego.Size = new Size(332, 48);
            BotonReiniciaJuego.TabIndex = 20;
            BotonReiniciaJuego.Text = "Reinicia Juego";
            BotonReiniciaJuego.UseVisualStyleBackColor = true;
            BotonReiniciaJuego.Click += BotonReiniciaJuego_Click;
            // 
            // TextoTotalAciertos
            // 
            TextoTotalAciertos.BackColor = Color.White;
            TextoTotalAciertos.Enabled = false;
            TextoTotalAciertos.Font = new Font("Microsoft Sans Serif", 9.75F);
            TextoTotalAciertos.Location = new Point(367, 494);
            TextoTotalAciertos.Name = "TextoTotalAciertos";
            TextoTotalAciertos.Size = new Size(45, 37);
            TextoTotalAciertos.TabIndex = 22;
            TextoTotalAciertos.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(248, 501);
            label6.Name = "label6";
            label6.Size = new Size(113, 30);
            label6.TabIndex = 21;
            label6.Text = "Aciertos:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CuadroImagen
            // 
            CuadroImagen.BackColor = Color.White;
            CuadroImagen.Location = new Point(612, 281);
            CuadroImagen.Name = "CuadroImagen";
            CuadroImagen.Size = new Size(230, 240);
            CuadroImagen.TabIndex = 23;
            CuadroImagen.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 794);
            Controls.Add(CuadroImagen);
            Controls.Add(label6);
            Controls.Add(TextoTotalAciertos);
            Controls.Add(BotonReiniciaJuego);
            Controls.Add(TextoTotalFallos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TextoPalabraBuscada);
            Controls.Add(TextoLetrasColocadas);
            Controls.Add(label3);
            Controls.Add(TextoLetra10);
            Controls.Add(TextoLetra9);
            Controls.Add(TextoLetra8);
            Controls.Add(TextoLetra7);
            Controls.Add(TextoLetra6);
            Controls.Add(TextoLetra5);
            Controls.Add(TextoLetra4);
            Controls.Add(TextoLetra3);
            Controls.Add(TextoLetra2);
            Controls.Add(TextoLetra1);
            Controls.Add(BotonEvaluaLetra);
            Controls.Add(TextoLetraIngresada);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ahorcadito Gráfico";
            ((System.ComponentModel.ISupportInitialize)CuadroImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TextoLetraIngresada;
        private Button BotonEvaluaLetra;
        private TextBox TextoLetra1;
        private TextBox TextoLetra2;
        private TextBox TextoLetra3;
        private TextBox TextoLetra4;
        private TextBox TextoLetra5;
        private TextBox TextoLetra6;
        private TextBox TextoLetra7;
        private TextBox TextoLetra8;
        private TextBox TextoLetra9;
        private TextBox TextoLetra10;
        private Label label3;
        private TextBox TextoLetrasColocadas;
        private TextBox TextoPalabraBuscada;
        private Label label4;
        private Label label5;
        private TextBox TextoTotalFallos;
        private Button BotonReiniciaJuego;
        private TextBox TextoTotalAciertos;
        private Label label6;
        private PictureBox CuadroImagen;
    }
}
