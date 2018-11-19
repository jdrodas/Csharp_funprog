namespace ex04_TiendaGomitas
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
            this.BotonInicio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblFrecuencia = new System.Windows.Forms.Label();
            this.txtDetallePedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaborChontaduro = new System.Windows.Forms.TextBox();
            this.txtSaborMamoncillo = new System.Windows.Forms.TextBox();
            this.txtSaborArracacha = new System.Windows.Forms.TextBox();
            this.txtColorZafiro = new System.Windows.Forms.TextBox();
            this.txtColorEsmeralda = new System.Windows.Forms.TextBox();
            this.txtColorSalmon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtColorMagenta = new System.Windows.Forms.TextBox();
            this.txtColorMostaza = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFormaCondor = new System.Windows.Forms.TextBox();
            this.txtFormaDragon = new System.Windows.Forms.TextBox();
            this.txtFormaPiramide = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tienda de Gomitas - Simulación Surtido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Presiona el botón para simular compra de 1000 gomitas!";
            // 
            // BotonInicio
            // 
            this.BotonInicio.Location = new System.Drawing.Point(305, 81);
            this.BotonInicio.Name = "BotonInicio";
            this.BotonInicio.Size = new System.Drawing.Size(109, 23);
            this.BotonInicio.TabIndex = 2;
            this.BotonInicio.Text = "Iniciar Simulación!";
            this.BotonInicio.UseVisualStyleBackColor = true;
            this.BotonInicio.Click += new System.EventHandler(this.BotonInicio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSaborArracacha);
            this.groupBox1.Controls.Add(this.txtSaborMamoncillo);
            this.groupBox1.Controls.Add(this.txtSaborChontaduro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(32, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totales por sabor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtColorMagenta);
            this.groupBox2.Controls.Add(this.txtColorMostaza);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtColorZafiro);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtColorEsmeralda);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtColorSalmon);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(192, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totales por color:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFormaCondor);
            this.groupBox3.Controls.Add(this.txtFormaDragon);
            this.groupBox3.Controls.Add(this.txtFormaPiramide);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(454, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales por forma:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDetallePedido);
            this.groupBox4.Controls.Add(this.lblFrecuencia);
            this.groupBox4.Location = new System.Drawing.Point(31, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(584, 189);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Información del pedido:";
            // 
            // lblFrecuencia
            // 
            this.lblFrecuencia.Location = new System.Drawing.Point(7, 20);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.Size = new System.Drawing.Size(548, 41);
            this.lblFrecuencia.TabIndex = 0;
            this.lblFrecuencia.Text = "Información de Mayor y menor Frecuencia:";
            // 
            // txtDetallePedido
            // 
            this.txtDetallePedido.Location = new System.Drawing.Point(10, 90);
            this.txtDetallePedido.Multiline = true;
            this.txtDetallePedido.Name = "txtDetallePedido";
            this.txtDetallePedido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetallePedido.Size = new System.Drawing.Size(545, 78);
            this.txtDetallePedido.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chontaduro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mamoncillo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Arracacha";
            // 
            // txtSaborChontaduro
            // 
            this.txtSaborChontaduro.Location = new System.Drawing.Point(77, 17);
            this.txtSaborChontaduro.Name = "txtSaborChontaduro";
            this.txtSaborChontaduro.Size = new System.Drawing.Size(46, 20);
            this.txtSaborChontaduro.TabIndex = 3;
            this.txtSaborChontaduro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSaborMamoncillo
            // 
            this.txtSaborMamoncillo.Location = new System.Drawing.Point(77, 41);
            this.txtSaborMamoncillo.Name = "txtSaborMamoncillo";
            this.txtSaborMamoncillo.Size = new System.Drawing.Size(46, 20);
            this.txtSaborMamoncillo.TabIndex = 4;
            this.txtSaborMamoncillo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSaborArracacha
            // 
            this.txtSaborArracacha.Location = new System.Drawing.Point(77, 67);
            this.txtSaborArracacha.Name = "txtSaborArracacha";
            this.txtSaborArracacha.Size = new System.Drawing.Size(46, 20);
            this.txtSaborArracacha.TabIndex = 5;
            this.txtSaborArracacha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtColorZafiro
            // 
            this.txtColorZafiro.Location = new System.Drawing.Point(74, 67);
            this.txtColorZafiro.Name = "txtColorZafiro";
            this.txtColorZafiro.Size = new System.Drawing.Size(46, 20);
            this.txtColorZafiro.TabIndex = 11;
            this.txtColorZafiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtColorEsmeralda
            // 
            this.txtColorEsmeralda.Location = new System.Drawing.Point(74, 41);
            this.txtColorEsmeralda.Name = "txtColorEsmeralda";
            this.txtColorEsmeralda.Size = new System.Drawing.Size(46, 20);
            this.txtColorEsmeralda.TabIndex = 10;
            this.txtColorEsmeralda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtColorSalmon
            // 
            this.txtColorSalmon.Location = new System.Drawing.Point(74, 17);
            this.txtColorSalmon.Name = "txtColorSalmon";
            this.txtColorSalmon.Size = new System.Drawing.Size(46, 20);
            this.txtColorSalmon.TabIndex = 9;
            this.txtColorSalmon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Zafiro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Esmeralda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Salmón";
            // 
            // txtColorMagenta
            // 
            this.txtColorMagenta.Location = new System.Drawing.Point(203, 41);
            this.txtColorMagenta.Name = "txtColorMagenta";
            this.txtColorMagenta.Size = new System.Drawing.Size(46, 20);
            this.txtColorMagenta.TabIndex = 16;
            this.txtColorMagenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtColorMostaza
            // 
            this.txtColorMostaza.Location = new System.Drawing.Point(203, 17);
            this.txtColorMostaza.Name = "txtColorMostaza";
            this.txtColorMostaza.Size = new System.Drawing.Size(46, 20);
            this.txtColorMostaza.TabIndex = 15;
            this.txtColorMostaza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(135, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Magenta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(135, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Mostaza";
            // 
            // txtFormaCondor
            // 
            this.txtFormaCondor.Location = new System.Drawing.Point(86, 67);
            this.txtFormaCondor.Name = "txtFormaCondor";
            this.txtFormaCondor.Size = new System.Drawing.Size(46, 20);
            this.txtFormaCondor.TabIndex = 11;
            this.txtFormaCondor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFormaDragon
            // 
            this.txtFormaDragon.Location = new System.Drawing.Point(86, 41);
            this.txtFormaDragon.Name = "txtFormaDragon";
            this.txtFormaDragon.Size = new System.Drawing.Size(46, 20);
            this.txtFormaDragon.TabIndex = 10;
            this.txtFormaDragon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFormaPiramide
            // 
            this.txtFormaPiramide.Location = new System.Drawing.Point(86, 17);
            this.txtFormaPiramide.Name = "txtFormaPiramide";
            this.txtFormaPiramide.Size = new System.Drawing.Size(46, 20);
            this.txtFormaPiramide.TabIndex = 9;
            this.txtFormaPiramide.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Cóndor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Dragón";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Pirámide";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BotonInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda de Gomitas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BotonInicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDetallePedido;
        private System.Windows.Forms.Label lblFrecuencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaborArracacha;
        private System.Windows.Forms.TextBox txtSaborMamoncillo;
        private System.Windows.Forms.TextBox txtSaborChontaduro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColorMagenta;
        private System.Windows.Forms.TextBox txtColorMostaza;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtColorZafiro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtColorEsmeralda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtColorSalmon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFormaCondor;
        private System.Windows.Forms.TextBox txtFormaDragon;
        private System.Windows.Forms.TextBox txtFormaPiramide;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

