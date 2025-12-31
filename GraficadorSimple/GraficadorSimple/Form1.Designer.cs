namespace GraficadorSimple
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            itemMenuNuevo = new ToolStripMenuItem();
            itemMenuGuardar = new ToolStripMenuItem();
            itemMenuSalir = new ToolStripMenuItem();
            ediciónToolStripMenuItem = new ToolStripMenuItem();
            seleccionarColoresToolStripMenuItem = new ToolStripMenuItem();
            itemMenuColorPrimario = new ToolStripMenuItem();
            itemMenuColorSecundario = new ToolStripMenuItem();
            itemMenuTipoLetra = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            itemMenuAcercaDe = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            etiquetaEstado = new ToolStripStatusLabel();
            etiquetaPuntoInicial = new ToolStripStatusLabel();
            etiquetaPuntoFinal = new ToolStripStatusLabel();
            groupBox1 = new GroupBox();
            etiquetaLados = new Label();
            selectorNumeroLados = new NumericUpDown();
            radioPoligono = new RadioButton();
            radioTexto = new RadioButton();
            radioLinea = new RadioButton();
            radioElipse = new RadioButton();
            radioRectangulo = new RadioButton();
            groupBox2 = new GroupBox();
            botonSwapColores = new Button();
            label2 = new Label();
            cuadroColorSecundario = new PictureBox();
            label1 = new Label();
            cuadroColorPrimario = new PictureBox();
            cuadroDibujo = new PictureBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            selectorGrosor = new NumericUpDown();
            groupBox4 = new GroupBox();
            BotonTipoLetra = new Button();
            textoFrase = new TextBox();
            label4 = new Label();
            groupBox5 = new GroupBox();
            listaGradientes = new ListBox();
            radioRellenoGradiente = new RadioButton();
            radioRellenoSolido = new RadioButton();
            radioRellenoBorde = new RadioButton();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(selectorNumeroLados)).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(cuadroColorSecundario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(cuadroColorPrimario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(cuadroDibujo)).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(selectorGrosor)).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] {
            archivoToolStripMenuItem,
            ediciónToolStripMenuItem,
            ayudaToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(996, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            itemMenuNuevo,
            itemMenuGuardar,
            itemMenuSalir});
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // itemMenuNuevo
            // 
            itemMenuNuevo.Name = "itemMenuNuevo";
            itemMenuNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            itemMenuNuevo.Size = new System.Drawing.Size(180, 22);
            itemMenuNuevo.Text = "Nuevo";
            itemMenuNuevo.Click += new System.EventHandler(itemMenuNuevo_Click);
            // 
            // itemMenuGuardar
            // 
            itemMenuGuardar.Name = "itemMenuGuardar";
            itemMenuGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            itemMenuGuardar.Size = new System.Drawing.Size(180, 22);
            itemMenuGuardar.Text = "Guardar";
            itemMenuGuardar.Click += new System.EventHandler(itemMenuGuardar_Click);
            // 
            // itemMenuSalir
            // 
            itemMenuSalir.Name = "itemMenuSalir";
            itemMenuSalir.ShortcutKeyDisplayString = "";
            itemMenuSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            itemMenuSalir.Size = new System.Drawing.Size(180, 22);
            itemMenuSalir.Text = "Salir";
            itemMenuSalir.Click += new System.EventHandler(itemMenuSalir_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            ediciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            seleccionarColoresToolStripMenuItem,
            itemMenuTipoLetra});
            ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            ediciónToolStripMenuItem.Text = "Edición";
            // 
            // seleccionarColoresToolStripMenuItem
            // 
            seleccionarColoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            itemMenuColorPrimario,
            itemMenuColorSecundario});
            seleccionarColoresToolStripMenuItem.Name = "seleccionarColoresToolStripMenuItem";
            seleccionarColoresToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            seleccionarColoresToolStripMenuItem.Text = "Seleccionar Colores";
            // 
            // itemMenuColorPrimario
            // 
            itemMenuColorPrimario.Name = "itemMenuColorPrimario";
            itemMenuColorPrimario.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.P)));
            itemMenuColorPrimario.Size = new System.Drawing.Size(251, 22);
            itemMenuColorPrimario.Text = "Color Primario";
            itemMenuColorPrimario.Click += new System.EventHandler(itemMenuColorPrimario_Click);
            // 
            // itemMenuColorSecundario
            // 
            itemMenuColorSecundario.Name = "itemMenuColorSecundario";
            itemMenuColorSecundario.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.S)));
            itemMenuColorSecundario.Size = new System.Drawing.Size(251, 22);
            itemMenuColorSecundario.Text = "Color Secundario";
            itemMenuColorSecundario.Click += new System.EventHandler(itemMenuColorSecundario_Click);
            // 
            // itemMenuTipoLetra
            // 
            itemMenuTipoLetra.Name = "itemMenuTipoLetra";
            itemMenuTipoLetra.Size = new System.Drawing.Size(189, 22);
            itemMenuTipoLetra.Text = "Seleccionar Tipo Letra";
            itemMenuTipoLetra.Click += new System.EventHandler(itemMenuTipoLetra_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            itemMenuAcercaDe});
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // itemMenuAcercaDe
            // 
            itemMenuAcercaDe.Name = "itemMenuAcercaDe";
            itemMenuAcercaDe.Size = new System.Drawing.Size(180, 22);
            itemMenuAcercaDe.Text = "Acerca de";
            itemMenuAcercaDe.Click += new System.EventHandler(itemMenuAcercaDe_Click);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] {
            etiquetaEstado,
            etiquetaPuntoInicial,
            etiquetaPuntoFinal});
            statusStrip1.Location = new System.Drawing.Point(0, 639);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(996, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // etiquetaEstado
            // 
            etiquetaEstado.AutoSize = false;
            etiquetaEstado.Name = "etiquetaEstado";
            etiquetaEstado.Size = new System.Drawing.Size(450, 17);
            etiquetaEstado.Text = "Estado:";
            etiquetaEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // etiquetaPuntoInicial
            // 
            etiquetaPuntoInicial.AutoSize = false;
            etiquetaPuntoInicial.Name = "etiquetaPuntoInicial";
            etiquetaPuntoInicial.Size = new System.Drawing.Size(150, 17);
            etiquetaPuntoInicial.Text = "Punto Inicial: (0,0)";
            // 
            // etiquetaPuntoFinal
            // 
            etiquetaPuntoFinal.AutoSize = false;
            etiquetaPuntoFinal.Name = "etiquetaPuntoFinal";
            etiquetaPuntoFinal.Size = new System.Drawing.Size(150, 17);
            etiquetaPuntoFinal.Text = "Punto Final: (0,0)";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(etiquetaLados);
            groupBox1.Controls.Add(selectorNumeroLados);
            groupBox1.Controls.Add(radioPoligono);
            groupBox1.Controls.Add(radioTexto);
            groupBox1.Controls.Add(radioLinea);
            groupBox1.Controls.Add(radioElipse);
            groupBox1.Controls.Add(radioRectangulo);
            groupBox1.Location = new System.Drawing.Point(12, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(159, 154);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Herramientas";
            // 
            // etiquetaLados
            // 
            etiquetaLados.AutoSize = true;
            etiquetaLados.Location = new System.Drawing.Point(52, 121);
            etiquetaLados.Name = "etiquetaLados";
            etiquetaLados.Size = new System.Drawing.Size(39, 13);
            etiquetaLados.TabIndex = 2;
            etiquetaLados.Text = "Lados:";
            // 
            // selectorNumeroLados
            // 
            selectorNumeroLados.Location = new System.Drawing.Point(93, 119);
            selectorNumeroLados.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            selectorNumeroLados.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            selectorNumeroLados.Name = "selectorNumeroLados";
            selectorNumeroLados.Size = new System.Drawing.Size(44, 20);
            selectorNumeroLados.TabIndex = 2;
            selectorNumeroLados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            selectorNumeroLados.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            selectorNumeroLados.ValueChanged += new System.EventHandler(selectorNumeroLados_ValueChanged);
            // 
            // radioPoligono
            // 
            radioPoligono.AutoSize = true;
            radioPoligono.Location = new System.Drawing.Point(6, 100);
            radioPoligono.Name = "radioPoligono";
            radioPoligono.Size = new System.Drawing.Size(66, 17);
            radioPoligono.TabIndex = 6;
            radioPoligono.TabStop = true;
            radioPoligono.Text = "Poligono";
            radioPoligono.UseVisualStyleBackColor = true;
            radioPoligono.CheckedChanged += new System.EventHandler(radioPoligono_CheckedChanged);
            // 
            // radioTexto
            // 
            radioTexto.AutoSize = true;
            radioTexto.Location = new System.Drawing.Point(6, 40);
            radioTexto.Name = "radioTexto";
            radioTexto.Size = new System.Drawing.Size(52, 17);
            radioTexto.TabIndex = 5;
            radioTexto.TabStop = true;
            radioTexto.Text = "Texto";
            radioTexto.UseVisualStyleBackColor = true;
            radioTexto.CheckedChanged += new System.EventHandler(radioTexto_CheckedChanged);
            // 
            // radioLinea
            // 
            radioLinea.AutoSize = true;
            radioLinea.Checked = true;
            radioLinea.Location = new System.Drawing.Point(6, 20);
            radioLinea.Name = "radioLinea";
            radioLinea.Size = new System.Drawing.Size(51, 17);
            radioLinea.TabIndex = 3;
            radioLinea.TabStop = true;
            radioLinea.Text = "Linea";
            radioLinea.UseVisualStyleBackColor = true;
            radioLinea.CheckedChanged += new System.EventHandler(radioLinea_CheckedChanged);
            // 
            // radioElipse
            // 
            radioElipse.AutoSize = true;
            radioElipse.Location = new System.Drawing.Point(6, 80);
            radioElipse.Name = "radioElipse";
            radioElipse.Size = new System.Drawing.Size(53, 17);
            radioElipse.TabIndex = 4;
            radioElipse.TabStop = true;
            radioElipse.Text = "Elipse";
            radioElipse.UseVisualStyleBackColor = true;
            radioElipse.CheckedChanged += new System.EventHandler(radioElipse_CheckedChanged);
            // 
            // radioRectangulo
            // 
            radioRectangulo.AutoSize = true;
            radioRectangulo.Location = new System.Drawing.Point(6, 60);
            radioRectangulo.Name = "radioRectangulo";
            radioRectangulo.Size = new System.Drawing.Size(80, 17);
            radioRectangulo.TabIndex = 3;
            radioRectangulo.TabStop = true;
            radioRectangulo.Text = "Rectángulo";
            radioRectangulo.UseVisualStyleBackColor = true;
            radioRectangulo.CheckedChanged += new System.EventHandler(radioRectangulo_CheckedChanged);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(botonSwapColores);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cuadroColorSecundario);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cuadroColorPrimario);
            groupBox2.Location = new System.Drawing.Point(12, 194);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(159, 106);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Colores";
            // 
            // botonSwapColores
            // 
            botonSwapColores.Location = new System.Drawing.Point(32, 74);
            botonSwapColores.Name = "botonSwapColores";
            botonSwapColores.Size = new System.Drawing.Size(75, 23);
            botonSwapColores.TabIndex = 4;
            botonSwapColores.Text = "Intercambiar";
            botonSwapColores.UseVisualStyleBackColor = true;
            botonSwapColores.Click += new System.EventHandler(botonSwapColores_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(73, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 13);
            label2.TabIndex = 5;
            label2.Text = "Secundario";
            // 
            // cuadroColorSecundario
            // 
            cuadroColorSecundario.BackColor = System.Drawing.Color.White;
            cuadroColorSecundario.Location = new System.Drawing.Point(85, 39);
            cuadroColorSecundario.Name = "cuadroColorSecundario";
            cuadroColorSecundario.Size = new System.Drawing.Size(33, 29);
            cuadroColorSecundario.TabIndex = 5;
            cuadroColorSecundario.TabStop = false;
            cuadroColorSecundario.Click += new System.EventHandler(cuadroColorSecundario_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 13);
            label1.TabIndex = 4;
            label1.Text = "Primario";
            // 
            // cuadroColorPrimario
            // 
            cuadroColorPrimario.BackColor = System.Drawing.Color.Black;
            cuadroColorPrimario.Location = new System.Drawing.Point(18, 39);
            cuadroColorPrimario.Name = "cuadroColorPrimario";
            cuadroColorPrimario.Size = new System.Drawing.Size(33, 29);
            cuadroColorPrimario.TabIndex = 4;
            cuadroColorPrimario.TabStop = false;
            cuadroColorPrimario.Click += new System.EventHandler(cuadroColorPrimario_Click);
            // 
            // cuadroDibujo
            // 
            cuadroDibujo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            cuadroDibujo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            cuadroDibujo.Location = new System.Drawing.Point(186, 45);
            cuadroDibujo.Name = "cuadroDibujo";
            cuadroDibujo.Size = new System.Drawing.Size(800, 580);
            cuadroDibujo.TabIndex = 4;
            cuadroDibujo.TabStop = false;
            cuadroDibujo.MouseDown += new MouseEventHandler(cuadroDibujo_MouseDown);
            cuadroDibujo.MouseMove += new MouseEventHandler(cuadroDibujo_MouseMove);
            cuadroDibujo.MouseUp += new MouseEventHandler(cuadroDibujo_MouseUp);
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(selectorGrosor);
            groupBox3.Location = new System.Drawing.Point(12, 306);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(159, 60);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Grosor de Línea";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 35);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 13);
            label3.TabIndex = 1;
            label3.Text = "Valor:";
            // 
            // selectorGrosor
            // 
            selectorGrosor.Location = new System.Drawing.Point(93, 29);
            selectorGrosor.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            selectorGrosor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            selectorGrosor.Name = "selectorGrosor";
            selectorGrosor.Size = new System.Drawing.Size(44, 20);
            selectorGrosor.TabIndex = 0;
            selectorGrosor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            selectorGrosor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            selectorGrosor.ValueChanged += new System.EventHandler(selectorGrosor_ValueChanged);
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BotonTipoLetra);
            groupBox4.Controls.Add(textoFrase);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new System.Drawing.Point(12, 517);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(159, 110);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Opciones de texto:";
            // 
            // BotonTipoLetra
            // 
            BotonTipoLetra.Location = new System.Drawing.Point(25, 67);
            BotonTipoLetra.Name = "BotonTipoLetra";
            BotonTipoLetra.Size = new System.Drawing.Size(75, 23);
            BotonTipoLetra.TabIndex = 2;
            BotonTipoLetra.Text = "Tipo de letra";
            BotonTipoLetra.UseVisualStyleBackColor = true;
            BotonTipoLetra.Click += new System.EventHandler(BotonTipoLetra_Click);
            // 
            // textoFrase
            // 
            textoFrase.Location = new System.Drawing.Point(15, 40);
            textoFrase.Name = "textoFrase";
            textoFrase.Size = new System.Drawing.Size(100, 20);
            textoFrase.TabIndex = 1;
            textoFrase.Leave += new System.EventHandler(textoFrase_Leave);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(15, 23);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 13);
            label4.TabIndex = 0;
            label4.Text = "Frase:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(listaGradientes);
            groupBox5.Controls.Add(radioRellenoGradiente);
            groupBox5.Controls.Add(radioRellenoSolido);
            groupBox5.Controls.Add(radioRellenoBorde);
            groupBox5.Location = new System.Drawing.Point(12, 372);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(159, 140);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Estilo de relleno";
            // 
            // listaGradientes
            // 
            listaGradientes.FormattingEnabled = true;
            listaGradientes.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical",
            "Diagonal Adelante",
            "Diagonal Atrás"});
            listaGradientes.Location = new System.Drawing.Point(48, 103);
            listaGradientes.Name = "listaGradientes";
            listaGradientes.Size = new System.Drawing.Size(105, 30);
            listaGradientes.TabIndex = 3;
            // 
            // radioRellenoGradiente
            // 
            radioRellenoGradiente.AutoSize = true;
            radioRellenoGradiente.Location = new System.Drawing.Point(15, 80);
            radioRellenoGradiente.Name = "radioRellenoGradiente";
            radioRellenoGradiente.Size = new System.Drawing.Size(110, 17);
            radioRellenoGradiente.TabIndex = 2;
            radioRellenoGradiente.TabStop = true;
            radioRellenoGradiente.Text = "Relleno Gradiente";
            radioRellenoGradiente.UseVisualStyleBackColor = true;
            radioRellenoGradiente.CheckedChanged += new System.EventHandler(radioRellenoGradiente_CheckedChanged);
            // 
            // radioRellenoSolido
            // 
            radioRellenoSolido.AutoSize = true;
            radioRellenoSolido.Location = new System.Drawing.Point(15, 56);
            radioRellenoSolido.Name = "radioRellenoSolido";
            radioRellenoSolido.Size = new System.Drawing.Size(93, 17);
            radioRellenoSolido.TabIndex = 1;
            radioRellenoSolido.TabStop = true;
            radioRellenoSolido.Text = "Relleno Sólido";
            radioRellenoSolido.UseVisualStyleBackColor = true;
            // 
            // radioRellenoBorde
            // 
            radioRellenoBorde.AutoSize = true;
            radioRellenoBorde.Location = new System.Drawing.Point(15, 32);
            radioRellenoBorde.Name = "radioRellenoBorde";
            radioRellenoBorde.Size = new System.Drawing.Size(74, 17);
            radioRellenoBorde.TabIndex = 0;
            radioRellenoBorde.TabStop = true;
            radioRellenoBorde.Text = "Sin relleno";
            radioRellenoBorde.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(996, 661);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(cuadroDibujo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Graficador Simple v. 2025";
            Load += new System.EventHandler(Form1_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(selectorNumeroLados)).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(cuadroColorSecundario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(cuadroColorPrimario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(cuadroDibujo)).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(selectorGrosor)).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMenuNuevo;
        private System.Windows.Forms.ToolStripMenuItem itemMenuGuardar;
        private System.Windows.Forms.ToolStripMenuItem itemMenuSalir;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel etiquetaEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioTexto;
        private System.Windows.Forms.RadioButton radioLinea;
        private System.Windows.Forms.RadioButton radioElipse;
        private System.Windows.Forms.RadioButton radioRectangulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox cuadroColorSecundario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox cuadroColorPrimario;
        private System.Windows.Forms.ToolStripMenuItem seleccionarColoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMenuColorPrimario;
        private System.Windows.Forms.ToolStripMenuItem itemMenuColorSecundario;
        private System.Windows.Forms.Button botonSwapColores;
        private System.Windows.Forms.PictureBox cuadroDibujo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown selectorGrosor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BotonTipoLetra;
        private System.Windows.Forms.TextBox textoFrase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem itemMenuTipoLetra;
        private System.Windows.Forms.ToolStripMenuItem itemMenuAcercaDe;
        private System.Windows.Forms.ToolStripStatusLabel etiquetaPuntoInicial;
        private System.Windows.Forms.ToolStripStatusLabel etiquetaPuntoFinal;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioRellenoGradiente;
        private System.Windows.Forms.RadioButton radioRellenoSolido;
        private System.Windows.Forms.RadioButton radioRellenoBorde;
        private System.Windows.Forms.ListBox listaGradientes;
        private System.Windows.Forms.Label etiquetaLados;
        private System.Windows.Forms.NumericUpDown selectorNumeroLados;
        private System.Windows.Forms.RadioButton radioPoligono;
    }
}