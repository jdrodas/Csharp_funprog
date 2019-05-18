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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarColoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuColorPrimario = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuColorSecundario = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuTipoLetra = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.etiquetaEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.etiquetaPuntoInicial = new System.Windows.Forms.ToolStripStatusLabel();
            this.etiquetaPuntoFinal = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioTexto = new System.Windows.Forms.RadioButton();
            this.radioLinea = new System.Windows.Forms.RadioButton();
            this.radioElipse = new System.Windows.Forms.RadioButton();
            this.radioRectangulo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botonSwapColores = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cuadroColorSecundario = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cuadroColorPrimario = new System.Windows.Forms.PictureBox();
            this.cuadroDibujo = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectorGrosor = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BotonTipoLetra = new System.Windows.Forms.Button();
            this.textoFrase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioRellenoBorde = new System.Windows.Forms.RadioButton();
            this.radioRellenoSolido = new System.Windows.Forms.RadioButton();
            this.radioRellenoGradiente = new System.Windows.Forms.RadioButton();
            this.listaGradientes = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuadroColorSecundario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuadroColorPrimario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuadroDibujo)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectorGrosor)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuNuevo,
            this.itemMenuGuardar,
            this.itemMenuSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // itemMenuNuevo
            // 
            this.itemMenuNuevo.Name = "itemMenuNuevo";
            this.itemMenuNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.itemMenuNuevo.Size = new System.Drawing.Size(158, 22);
            this.itemMenuNuevo.Text = "Nuevo";
            this.itemMenuNuevo.Click += new System.EventHandler(this.itemMenuNuevo_Click);
            // 
            // itemMenuGuardar
            // 
            this.itemMenuGuardar.Name = "itemMenuGuardar";
            this.itemMenuGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.itemMenuGuardar.Size = new System.Drawing.Size(158, 22);
            this.itemMenuGuardar.Text = "Guardar";
            // 
            // itemMenuSalir
            // 
            this.itemMenuSalir.Name = "itemMenuSalir";
            this.itemMenuSalir.ShortcutKeyDisplayString = "";
            this.itemMenuSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.itemMenuSalir.Size = new System.Drawing.Size(158, 22);
            this.itemMenuSalir.Text = "Salir";
            this.itemMenuSalir.Click += new System.EventHandler(this.itemMenuSalir_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionarColoresToolStripMenuItem,
            this.itemMenuTipoLetra});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // seleccionarColoresToolStripMenuItem
            // 
            this.seleccionarColoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuColorPrimario,
            this.itemMenuColorSecundario});
            this.seleccionarColoresToolStripMenuItem.Name = "seleccionarColoresToolStripMenuItem";
            this.seleccionarColoresToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.seleccionarColoresToolStripMenuItem.Text = "Seleccionar Colores";
            // 
            // itemMenuColorPrimario
            // 
            this.itemMenuColorPrimario.Name = "itemMenuColorPrimario";
            this.itemMenuColorPrimario.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.itemMenuColorPrimario.Size = new System.Drawing.Size(251, 22);
            this.itemMenuColorPrimario.Text = "Color Primario";
            this.itemMenuColorPrimario.Click += new System.EventHandler(this.itemMenuColorPrimario_Click);
            // 
            // itemMenuColorSecundario
            // 
            this.itemMenuColorSecundario.Name = "itemMenuColorSecundario";
            this.itemMenuColorSecundario.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.itemMenuColorSecundario.Size = new System.Drawing.Size(251, 22);
            this.itemMenuColorSecundario.Text = "Color Secundario";
            this.itemMenuColorSecundario.Click += new System.EventHandler(this.itemMenuColorSecundario_Click);
            // 
            // itemMenuTipoLetra
            // 
            this.itemMenuTipoLetra.Name = "itemMenuTipoLetra";
            this.itemMenuTipoLetra.Size = new System.Drawing.Size(190, 22);
            this.itemMenuTipoLetra.Text = "Seleccionar Tipo Letra";
            this.itemMenuTipoLetra.Click += new System.EventHandler(this.itemMenuTipoLetra_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuAcercaDe});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // itemMenuAcercaDe
            // 
            this.itemMenuAcercaDe.Name = "itemMenuAcercaDe";
            this.itemMenuAcercaDe.Size = new System.Drawing.Size(126, 22);
            this.itemMenuAcercaDe.Text = "Acerca de";
            this.itemMenuAcercaDe.Click += new System.EventHandler(this.itemMenuAcercaDe_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etiquetaEstado,
            this.etiquetaPuntoInicial,
            this.etiquetaPuntoFinal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // etiquetaEstado
            // 
            this.etiquetaEstado.AutoSize = false;
            this.etiquetaEstado.Name = "etiquetaEstado";
            this.etiquetaEstado.Size = new System.Drawing.Size(250, 17);
            this.etiquetaEstado.Text = "Estado:";
            this.etiquetaEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // etiquetaPuntoInicial
            // 
            this.etiquetaPuntoInicial.AutoSize = false;
            this.etiquetaPuntoInicial.Name = "etiquetaPuntoInicial";
            this.etiquetaPuntoInicial.Size = new System.Drawing.Size(150, 17);
            this.etiquetaPuntoInicial.Text = "Punto Inicial: (0,0)";
            // 
            // etiquetaPuntoFinal
            // 
            this.etiquetaPuntoFinal.AutoSize = false;
            this.etiquetaPuntoFinal.Name = "etiquetaPuntoFinal";
            this.etiquetaPuntoFinal.Size = new System.Drawing.Size(150, 17);
            this.etiquetaPuntoFinal.Text = "Punto Final: (0,0)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioTexto);
            this.groupBox1.Controls.Add(this.radioLinea);
            this.groupBox1.Controls.Add(this.radioElipse);
            this.groupBox1.Controls.Add(this.radioRectangulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Herramientas";
            // 
            // radioTexto
            // 
            this.radioTexto.AutoSize = true;
            this.radioTexto.Location = new System.Drawing.Point(6, 88);
            this.radioTexto.Name = "radioTexto";
            this.radioTexto.Size = new System.Drawing.Size(52, 17);
            this.radioTexto.TabIndex = 5;
            this.radioTexto.TabStop = true;
            this.radioTexto.Text = "Texto";
            this.radioTexto.UseVisualStyleBackColor = true;
            this.radioTexto.CheckedChanged += new System.EventHandler(this.radioTexto_CheckedChanged);
            // 
            // radioLinea
            // 
            this.radioLinea.AutoSize = true;
            this.radioLinea.Checked = true;
            this.radioLinea.Location = new System.Drawing.Point(6, 19);
            this.radioLinea.Name = "radioLinea";
            this.radioLinea.Size = new System.Drawing.Size(51, 17);
            this.radioLinea.TabIndex = 3;
            this.radioLinea.TabStop = true;
            this.radioLinea.Text = "Linea";
            this.radioLinea.UseVisualStyleBackColor = true;
            this.radioLinea.CheckedChanged += new System.EventHandler(this.radioLinea_CheckedChanged);
            // 
            // radioElipse
            // 
            this.radioElipse.AutoSize = true;
            this.radioElipse.Location = new System.Drawing.Point(6, 65);
            this.radioElipse.Name = "radioElipse";
            this.radioElipse.Size = new System.Drawing.Size(53, 17);
            this.radioElipse.TabIndex = 4;
            this.radioElipse.TabStop = true;
            this.radioElipse.Text = "Elipse";
            this.radioElipse.UseVisualStyleBackColor = true;
            this.radioElipse.CheckedChanged += new System.EventHandler(this.radioElipse_CheckedChanged);
            // 
            // radioRectangulo
            // 
            this.radioRectangulo.AutoSize = true;
            this.radioRectangulo.Location = new System.Drawing.Point(6, 42);
            this.radioRectangulo.Name = "radioRectangulo";
            this.radioRectangulo.Size = new System.Drawing.Size(80, 17);
            this.radioRectangulo.TabIndex = 3;
            this.radioRectangulo.TabStop = true;
            this.radioRectangulo.Text = "Rectángulo";
            this.radioRectangulo.UseVisualStyleBackColor = true;
            this.radioRectangulo.CheckedChanged += new System.EventHandler(this.radioRectangulo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonSwapColores);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cuadroColorSecundario);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cuadroColorPrimario);
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 106);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colores";
            // 
            // botonSwapColores
            // 
            this.botonSwapColores.Location = new System.Drawing.Point(32, 74);
            this.botonSwapColores.Name = "botonSwapColores";
            this.botonSwapColores.Size = new System.Drawing.Size(75, 23);
            this.botonSwapColores.TabIndex = 4;
            this.botonSwapColores.Text = "Intercambiar";
            this.botonSwapColores.UseVisualStyleBackColor = true;
            this.botonSwapColores.Click += new System.EventHandler(this.botonSwapColores_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Secundario";
            // 
            // cuadroColorSecundario
            // 
            this.cuadroColorSecundario.BackColor = System.Drawing.Color.White;
            this.cuadroColorSecundario.Location = new System.Drawing.Point(85, 39);
            this.cuadroColorSecundario.Name = "cuadroColorSecundario";
            this.cuadroColorSecundario.Size = new System.Drawing.Size(33, 29);
            this.cuadroColorSecundario.TabIndex = 5;
            this.cuadroColorSecundario.TabStop = false;
            this.cuadroColorSecundario.Click += new System.EventHandler(this.cuadroColorSecundario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Primario";
            // 
            // cuadroColorPrimario
            // 
            this.cuadroColorPrimario.BackColor = System.Drawing.Color.Black;
            this.cuadroColorPrimario.Location = new System.Drawing.Point(18, 39);
            this.cuadroColorPrimario.Name = "cuadroColorPrimario";
            this.cuadroColorPrimario.Size = new System.Drawing.Size(33, 29);
            this.cuadroColorPrimario.TabIndex = 4;
            this.cuadroColorPrimario.TabStop = false;
            this.cuadroColorPrimario.Click += new System.EventHandler(this.cuadroColorPrimario_Click);
            // 
            // cuadroDibujo
            // 
            this.cuadroDibujo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cuadroDibujo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cuadroDibujo.Location = new System.Drawing.Point(186, 45);
            this.cuadroDibujo.Name = "cuadroDibujo";
            this.cuadroDibujo.Size = new System.Drawing.Size(736, 571);
            this.cuadroDibujo.TabIndex = 4;
            this.cuadroDibujo.TabStop = false;
            this.cuadroDibujo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cuadroDibujo_MouseDown);
            this.cuadroDibujo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cuadroDibujo_MouseMove);
            this.cuadroDibujo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cuadroDibujo_MouseUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.selectorGrosor);
            this.groupBox3.Location = new System.Drawing.Point(12, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 60);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grosor de Línea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Valor:";
            // 
            // selectorGrosor
            // 
            this.selectorGrosor.Location = new System.Drawing.Point(93, 29);
            this.selectorGrosor.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.selectorGrosor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectorGrosor.Name = "selectorGrosor";
            this.selectorGrosor.Size = new System.Drawing.Size(44, 20);
            this.selectorGrosor.TabIndex = 0;
            this.selectorGrosor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.selectorGrosor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectorGrosor.ValueChanged += new System.EventHandler(this.selectorGrosor_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BotonTipoLetra);
            this.groupBox4.Controls.Add(this.textoFrase);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(12, 490);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(159, 110);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opciones de texto:";
            // 
            // BotonTipoLetra
            // 
            this.BotonTipoLetra.Location = new System.Drawing.Point(25, 67);
            this.BotonTipoLetra.Name = "BotonTipoLetra";
            this.BotonTipoLetra.Size = new System.Drawing.Size(75, 23);
            this.BotonTipoLetra.TabIndex = 2;
            this.BotonTipoLetra.Text = "Tipo de letra";
            this.BotonTipoLetra.UseVisualStyleBackColor = true;
            this.BotonTipoLetra.Click += new System.EventHandler(this.BotonTipoLetra_Click);
            // 
            // textoFrase
            // 
            this.textoFrase.Location = new System.Drawing.Point(15, 40);
            this.textoFrase.Name = "textoFrase";
            this.textoFrase.Size = new System.Drawing.Size(100, 20);
            this.textoFrase.TabIndex = 1;
            this.textoFrase.Leave += new System.EventHandler(this.textoFrase_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Frase:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listaGradientes);
            this.groupBox5.Controls.Add(this.radioRellenoGradiente);
            this.groupBox5.Controls.Add(this.radioRellenoSolido);
            this.groupBox5.Controls.Add(this.radioRellenoBorde);
            this.groupBox5.Location = new System.Drawing.Point(12, 344);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(159, 140);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Estilo de relleno";
            // 
            // radioRellenoBorde
            // 
            this.radioRellenoBorde.AutoSize = true;
            this.radioRellenoBorde.Location = new System.Drawing.Point(15, 32);
            this.radioRellenoBorde.Name = "radioRellenoBorde";
            this.radioRellenoBorde.Size = new System.Drawing.Size(74, 17);
            this.radioRellenoBorde.TabIndex = 0;
            this.radioRellenoBorde.TabStop = true;
            this.radioRellenoBorde.Text = "Sin relleno";
            this.radioRellenoBorde.UseVisualStyleBackColor = true;
            // 
            // radioRellenoSolido
            // 
            this.radioRellenoSolido.AutoSize = true;
            this.radioRellenoSolido.Location = new System.Drawing.Point(15, 56);
            this.radioRellenoSolido.Name = "radioRellenoSolido";
            this.radioRellenoSolido.Size = new System.Drawing.Size(93, 17);
            this.radioRellenoSolido.TabIndex = 1;
            this.radioRellenoSolido.TabStop = true;
            this.radioRellenoSolido.Text = "Relleno Sólido";
            this.radioRellenoSolido.UseVisualStyleBackColor = true;
            // 
            // radioRellenoGradiente
            // 
            this.radioRellenoGradiente.AutoSize = true;
            this.radioRellenoGradiente.Location = new System.Drawing.Point(15, 80);
            this.radioRellenoGradiente.Name = "radioRellenoGradiente";
            this.radioRellenoGradiente.Size = new System.Drawing.Size(110, 17);
            this.radioRellenoGradiente.TabIndex = 2;
            this.radioRellenoGradiente.TabStop = true;
            this.radioRellenoGradiente.Text = "Relleno Gradiente";
            this.radioRellenoGradiente.UseVisualStyleBackColor = true;
            this.radioRellenoGradiente.CheckedChanged += new System.EventHandler(this.radioRellenoGradiente_CheckedChanged);
            // 
            // listaGradientes
            // 
            this.listaGradientes.FormattingEnabled = true;
            this.listaGradientes.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical",
            "Diagonal"});
            this.listaGradientes.Location = new System.Drawing.Point(48, 103);
            this.listaGradientes.Name = "listaGradientes";
            this.listaGradientes.Size = new System.Drawing.Size(105, 30);
            this.listaGradientes.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 641);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cuadroDibujo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficador Simple v. 2019";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuadroColorSecundario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuadroColorPrimario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuadroDibujo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectorGrosor)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

