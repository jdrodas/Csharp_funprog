namespace Wordle_Simplificado
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
            this.txtPalabraIngresada = new System.Windows.Forms.TextBox();
            this.btnEvaluaPalabra = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activarColoresAltoContrasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColorCorrecto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtColorDesubicado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtColorFallido = new System.Windows.Forms.TextBox();
            this.txtletra_intento1_posicion1 = new System.Windows.Forms.TextBox();
            this.txtletra_intento1_posicion2 = new System.Windows.Forms.TextBox();
            this.txtletra_intento1_posicion4 = new System.Windows.Forms.TextBox();
            this.txtletra_intento1_posicion3 = new System.Windows.Forms.TextBox();
            this.txtletra_intento1_posicion5 = new System.Windows.Forms.TextBox();
            this.txtletra_intento2_posicion5 = new System.Windows.Forms.TextBox();
            this.txtletra_intento2_posicion4 = new System.Windows.Forms.TextBox();
            this.txtletra_intento2_posicion3 = new System.Windows.Forms.TextBox();
            this.txtletra_intento2_posicion2 = new System.Windows.Forms.TextBox();
            this.txtletra_intento2_posicion1 = new System.Windows.Forms.TextBox();
            this.txtletra_intento4_posicion5 = new System.Windows.Forms.TextBox();
            this.txtletra_intento4_posicion4 = new System.Windows.Forms.TextBox();
            this.txtletra_intento4_posicion3 = new System.Windows.Forms.TextBox();
            this.txtletra_intento4_posicion2 = new System.Windows.Forms.TextBox();
            this.txtletra_intento4_posicion1 = new System.Windows.Forms.TextBox();
            this.txtletra_intento3_posicion5 = new System.Windows.Forms.TextBox();
            this.txtletra_intento3_posicion4 = new System.Windows.Forms.TextBox();
            this.txtletra_intento3_posicion3 = new System.Windows.Forms.TextBox();
            this.txtletra_intento3_posicion2 = new System.Windows.Forms.TextBox();
            this.txtletra_intento3_posicion1 = new System.Windows.Forms.TextBox();
            this.txtletra_intento6_posicion5 = new System.Windows.Forms.TextBox();
            this.txtletra_intento6_posicion4 = new System.Windows.Forms.TextBox();
            this.txtletra_intento6_posicion3 = new System.Windows.Forms.TextBox();
            this.txtletra_intento6_posicion2 = new System.Windows.Forms.TextBox();
            this.txtletra_intento6_posicion1 = new System.Windows.Forms.TextBox();
            this.txtletra_intento5_posicion5 = new System.Windows.Forms.TextBox();
            this.txtletra_intento5_posicion4 = new System.Windows.Forms.TextBox();
            this.txtletra_intento5_posicion3 = new System.Windows.Forms.TextBox();
            this.txtletra_intento5_posicion2 = new System.Windows.Forms.TextBox();
            this.txtletra_intento5_posicion1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(65, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wordle Simplificado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Palabra ingresada:";
            // 
            // txtPalabraIngresada
            // 
            this.txtPalabraIngresada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalabraIngresada.Location = new System.Drawing.Point(296, 139);
            this.txtPalabraIngresada.MaxLength = 5;
            this.txtPalabraIngresada.Name = "txtPalabraIngresada";
            this.txtPalabraIngresada.Size = new System.Drawing.Size(100, 29);
            this.txtPalabraIngresada.TabIndex = 2;
            // 
            // btnEvaluaPalabra
            // 
            this.btnEvaluaPalabra.Location = new System.Drawing.Point(296, 174);
            this.btnEvaluaPalabra.Name = "btnEvaluaPalabra";
            this.btnEvaluaPalabra.Size = new System.Drawing.Size(100, 23);
            this.btnEvaluaPalabra.TabIndex = 3;
            this.btnEvaluaPalabra.Text = "Evaluar Palabra";
            this.btnEvaluaPalabra.UseVisualStyleBackColor = true;
            this.btnEvaluaPalabra.Click += new System.EventHandler(this.btnEvaluaPalabra_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(461, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activarColoresAltoContrasteToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // activarColoresAltoContrasteToolStripMenuItem
            // 
            this.activarColoresAltoContrasteToolStripMenuItem.Name = "activarColoresAltoContrasteToolStripMenuItem";
            this.activarColoresAltoContrasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.activarColoresAltoContrasteToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.activarColoresAltoContrasteToolStripMenuItem.Text = "Activar colores alto contraste";
            this.activarColoresAltoContrasteToolStripMenuItem.Click += new System.EventHandler(this.activarColoresAltoContrasteToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ayuda:";
            // 
            // txtColorCorrecto
            // 
            this.txtColorCorrecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorCorrecto.ForeColor = System.Drawing.Color.White;
            this.txtColorCorrecto.Location = new System.Drawing.Point(296, 234);
            this.txtColorCorrecto.Name = "txtColorCorrecto";
            this.txtColorCorrecto.Size = new System.Drawing.Size(40, 38);
            this.txtColorCorrecto.TabIndex = 13;
            this.txtColorCorrecto.Text = "V";
            this.txtColorCorrecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Posición correcta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Posición desubicada";
            // 
            // txtColorDesubicado
            // 
            this.txtColorDesubicado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorDesubicado.ForeColor = System.Drawing.Color.White;
            this.txtColorDesubicado.Location = new System.Drawing.Point(296, 278);
            this.txtColorDesubicado.Name = "txtColorDesubicado";
            this.txtColorDesubicado.Size = new System.Drawing.Size(40, 38);
            this.txtColorDesubicado.TabIndex = 15;
            this.txtColorDesubicado.Text = "V";
            this.txtColorDesubicado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Posición fallida";
            // 
            // txtColorFallido
            // 
            this.txtColorFallido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorFallido.ForeColor = System.Drawing.Color.White;
            this.txtColorFallido.Location = new System.Drawing.Point(296, 322);
            this.txtColorFallido.Name = "txtColorFallido";
            this.txtColorFallido.Size = new System.Drawing.Size(40, 38);
            this.txtColorFallido.TabIndex = 17;
            this.txtColorFallido.Text = "V";
            this.txtColorFallido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento1_posicion1
            // 
            this.txtletra_intento1_posicion1.Enabled = false;
            this.txtletra_intento1_posicion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento1_posicion1.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento1_posicion1.Location = new System.Drawing.Point(20, 107);
            this.txtletra_intento1_posicion1.Name = "txtletra_intento1_posicion1";
            this.txtletra_intento1_posicion1.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento1_posicion1.TabIndex = 19;
            this.txtletra_intento1_posicion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento1_posicion2
            // 
            this.txtletra_intento1_posicion2.Enabled = false;
            this.txtletra_intento1_posicion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento1_posicion2.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento1_posicion2.Location = new System.Drawing.Point(66, 107);
            this.txtletra_intento1_posicion2.Name = "txtletra_intento1_posicion2";
            this.txtletra_intento1_posicion2.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento1_posicion2.TabIndex = 20;
            this.txtletra_intento1_posicion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento1_posicion4
            // 
            this.txtletra_intento1_posicion4.Enabled = false;
            this.txtletra_intento1_posicion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento1_posicion4.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento1_posicion4.Location = new System.Drawing.Point(158, 107);
            this.txtletra_intento1_posicion4.Name = "txtletra_intento1_posicion4";
            this.txtletra_intento1_posicion4.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento1_posicion4.TabIndex = 22;
            this.txtletra_intento1_posicion4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento1_posicion3
            // 
            this.txtletra_intento1_posicion3.Enabled = false;
            this.txtletra_intento1_posicion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento1_posicion3.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento1_posicion3.Location = new System.Drawing.Point(112, 107);
            this.txtletra_intento1_posicion3.Name = "txtletra_intento1_posicion3";
            this.txtletra_intento1_posicion3.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento1_posicion3.TabIndex = 21;
            this.txtletra_intento1_posicion3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento1_posicion5
            // 
            this.txtletra_intento1_posicion5.Enabled = false;
            this.txtletra_intento1_posicion5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento1_posicion5.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento1_posicion5.Location = new System.Drawing.Point(204, 107);
            this.txtletra_intento1_posicion5.Name = "txtletra_intento1_posicion5";
            this.txtletra_intento1_posicion5.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento1_posicion5.TabIndex = 23;
            this.txtletra_intento1_posicion5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento2_posicion5
            // 
            this.txtletra_intento2_posicion5.Enabled = false;
            this.txtletra_intento2_posicion5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento2_posicion5.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento2_posicion5.Location = new System.Drawing.Point(204, 153);
            this.txtletra_intento2_posicion5.Name = "txtletra_intento2_posicion5";
            this.txtletra_intento2_posicion5.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento2_posicion5.TabIndex = 28;
            this.txtletra_intento2_posicion5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento2_posicion4
            // 
            this.txtletra_intento2_posicion4.Enabled = false;
            this.txtletra_intento2_posicion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento2_posicion4.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento2_posicion4.Location = new System.Drawing.Point(158, 153);
            this.txtletra_intento2_posicion4.Name = "txtletra_intento2_posicion4";
            this.txtletra_intento2_posicion4.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento2_posicion4.TabIndex = 27;
            this.txtletra_intento2_posicion4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento2_posicion3
            // 
            this.txtletra_intento2_posicion3.Enabled = false;
            this.txtletra_intento2_posicion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento2_posicion3.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento2_posicion3.Location = new System.Drawing.Point(112, 153);
            this.txtletra_intento2_posicion3.Name = "txtletra_intento2_posicion3";
            this.txtletra_intento2_posicion3.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento2_posicion3.TabIndex = 26;
            this.txtletra_intento2_posicion3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento2_posicion2
            // 
            this.txtletra_intento2_posicion2.Enabled = false;
            this.txtletra_intento2_posicion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento2_posicion2.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento2_posicion2.Location = new System.Drawing.Point(66, 153);
            this.txtletra_intento2_posicion2.Name = "txtletra_intento2_posicion2";
            this.txtletra_intento2_posicion2.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento2_posicion2.TabIndex = 25;
            this.txtletra_intento2_posicion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento2_posicion1
            // 
            this.txtletra_intento2_posicion1.Enabled = false;
            this.txtletra_intento2_posicion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento2_posicion1.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento2_posicion1.Location = new System.Drawing.Point(20, 153);
            this.txtletra_intento2_posicion1.Name = "txtletra_intento2_posicion1";
            this.txtletra_intento2_posicion1.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento2_posicion1.TabIndex = 24;
            this.txtletra_intento2_posicion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento4_posicion5
            // 
            this.txtletra_intento4_posicion5.Enabled = false;
            this.txtletra_intento4_posicion5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento4_posicion5.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento4_posicion5.Location = new System.Drawing.Point(204, 243);
            this.txtletra_intento4_posicion5.Name = "txtletra_intento4_posicion5";
            this.txtletra_intento4_posicion5.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento4_posicion5.TabIndex = 38;
            this.txtletra_intento4_posicion5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento4_posicion4
            // 
            this.txtletra_intento4_posicion4.Enabled = false;
            this.txtletra_intento4_posicion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento4_posicion4.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento4_posicion4.Location = new System.Drawing.Point(158, 243);
            this.txtletra_intento4_posicion4.Name = "txtletra_intento4_posicion4";
            this.txtletra_intento4_posicion4.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento4_posicion4.TabIndex = 37;
            this.txtletra_intento4_posicion4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento4_posicion3
            // 
            this.txtletra_intento4_posicion3.Enabled = false;
            this.txtletra_intento4_posicion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento4_posicion3.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento4_posicion3.Location = new System.Drawing.Point(112, 243);
            this.txtletra_intento4_posicion3.Name = "txtletra_intento4_posicion3";
            this.txtletra_intento4_posicion3.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento4_posicion3.TabIndex = 36;
            this.txtletra_intento4_posicion3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento4_posicion2
            // 
            this.txtletra_intento4_posicion2.Enabled = false;
            this.txtletra_intento4_posicion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento4_posicion2.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento4_posicion2.Location = new System.Drawing.Point(66, 243);
            this.txtletra_intento4_posicion2.Name = "txtletra_intento4_posicion2";
            this.txtletra_intento4_posicion2.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento4_posicion2.TabIndex = 35;
            this.txtletra_intento4_posicion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento4_posicion1
            // 
            this.txtletra_intento4_posicion1.Enabled = false;
            this.txtletra_intento4_posicion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento4_posicion1.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento4_posicion1.Location = new System.Drawing.Point(20, 243);
            this.txtletra_intento4_posicion1.Name = "txtletra_intento4_posicion1";
            this.txtletra_intento4_posicion1.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento4_posicion1.TabIndex = 34;
            this.txtletra_intento4_posicion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento3_posicion5
            // 
            this.txtletra_intento3_posicion5.Enabled = false;
            this.txtletra_intento3_posicion5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento3_posicion5.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento3_posicion5.Location = new System.Drawing.Point(204, 197);
            this.txtletra_intento3_posicion5.Name = "txtletra_intento3_posicion5";
            this.txtletra_intento3_posicion5.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento3_posicion5.TabIndex = 33;
            this.txtletra_intento3_posicion5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento3_posicion4
            // 
            this.txtletra_intento3_posicion4.Enabled = false;
            this.txtletra_intento3_posicion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento3_posicion4.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento3_posicion4.Location = new System.Drawing.Point(158, 197);
            this.txtletra_intento3_posicion4.Name = "txtletra_intento3_posicion4";
            this.txtletra_intento3_posicion4.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento3_posicion4.TabIndex = 32;
            this.txtletra_intento3_posicion4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento3_posicion3
            // 
            this.txtletra_intento3_posicion3.Enabled = false;
            this.txtletra_intento3_posicion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento3_posicion3.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento3_posicion3.Location = new System.Drawing.Point(112, 197);
            this.txtletra_intento3_posicion3.Name = "txtletra_intento3_posicion3";
            this.txtletra_intento3_posicion3.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento3_posicion3.TabIndex = 31;
            this.txtletra_intento3_posicion3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento3_posicion2
            // 
            this.txtletra_intento3_posicion2.Enabled = false;
            this.txtletra_intento3_posicion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento3_posicion2.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento3_posicion2.Location = new System.Drawing.Point(66, 197);
            this.txtletra_intento3_posicion2.Name = "txtletra_intento3_posicion2";
            this.txtletra_intento3_posicion2.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento3_posicion2.TabIndex = 30;
            this.txtletra_intento3_posicion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento3_posicion1
            // 
            this.txtletra_intento3_posicion1.Enabled = false;
            this.txtletra_intento3_posicion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento3_posicion1.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento3_posicion1.Location = new System.Drawing.Point(20, 197);
            this.txtletra_intento3_posicion1.Name = "txtletra_intento3_posicion1";
            this.txtletra_intento3_posicion1.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento3_posicion1.TabIndex = 29;
            this.txtletra_intento3_posicion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento6_posicion5
            // 
            this.txtletra_intento6_posicion5.Enabled = false;
            this.txtletra_intento6_posicion5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento6_posicion5.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento6_posicion5.Location = new System.Drawing.Point(204, 333);
            this.txtletra_intento6_posicion5.Name = "txtletra_intento6_posicion5";
            this.txtletra_intento6_posicion5.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento6_posicion5.TabIndex = 48;
            this.txtletra_intento6_posicion5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento6_posicion4
            // 
            this.txtletra_intento6_posicion4.Enabled = false;
            this.txtletra_intento6_posicion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento6_posicion4.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento6_posicion4.Location = new System.Drawing.Point(158, 333);
            this.txtletra_intento6_posicion4.Name = "txtletra_intento6_posicion4";
            this.txtletra_intento6_posicion4.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento6_posicion4.TabIndex = 47;
            this.txtletra_intento6_posicion4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento6_posicion3
            // 
            this.txtletra_intento6_posicion3.Enabled = false;
            this.txtletra_intento6_posicion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento6_posicion3.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento6_posicion3.Location = new System.Drawing.Point(112, 333);
            this.txtletra_intento6_posicion3.Name = "txtletra_intento6_posicion3";
            this.txtletra_intento6_posicion3.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento6_posicion3.TabIndex = 46;
            this.txtletra_intento6_posicion3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento6_posicion2
            // 
            this.txtletra_intento6_posicion2.Enabled = false;
            this.txtletra_intento6_posicion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento6_posicion2.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento6_posicion2.Location = new System.Drawing.Point(66, 333);
            this.txtletra_intento6_posicion2.Name = "txtletra_intento6_posicion2";
            this.txtletra_intento6_posicion2.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento6_posicion2.TabIndex = 45;
            this.txtletra_intento6_posicion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento6_posicion1
            // 
            this.txtletra_intento6_posicion1.Enabled = false;
            this.txtletra_intento6_posicion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento6_posicion1.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento6_posicion1.Location = new System.Drawing.Point(20, 333);
            this.txtletra_intento6_posicion1.Name = "txtletra_intento6_posicion1";
            this.txtletra_intento6_posicion1.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento6_posicion1.TabIndex = 44;
            this.txtletra_intento6_posicion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento5_posicion5
            // 
            this.txtletra_intento5_posicion5.Enabled = false;
            this.txtletra_intento5_posicion5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento5_posicion5.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento5_posicion5.Location = new System.Drawing.Point(204, 287);
            this.txtletra_intento5_posicion5.Name = "txtletra_intento5_posicion5";
            this.txtletra_intento5_posicion5.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento5_posicion5.TabIndex = 43;
            this.txtletra_intento5_posicion5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento5_posicion4
            // 
            this.txtletra_intento5_posicion4.Enabled = false;
            this.txtletra_intento5_posicion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento5_posicion4.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento5_posicion4.Location = new System.Drawing.Point(158, 287);
            this.txtletra_intento5_posicion4.Name = "txtletra_intento5_posicion4";
            this.txtletra_intento5_posicion4.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento5_posicion4.TabIndex = 42;
            this.txtletra_intento5_posicion4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento5_posicion3
            // 
            this.txtletra_intento5_posicion3.Enabled = false;
            this.txtletra_intento5_posicion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento5_posicion3.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento5_posicion3.Location = new System.Drawing.Point(112, 287);
            this.txtletra_intento5_posicion3.Name = "txtletra_intento5_posicion3";
            this.txtletra_intento5_posicion3.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento5_posicion3.TabIndex = 41;
            this.txtletra_intento5_posicion3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento5_posicion2
            // 
            this.txtletra_intento5_posicion2.Enabled = false;
            this.txtletra_intento5_posicion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento5_posicion2.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento5_posicion2.Location = new System.Drawing.Point(66, 287);
            this.txtletra_intento5_posicion2.Name = "txtletra_intento5_posicion2";
            this.txtletra_intento5_posicion2.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento5_posicion2.TabIndex = 40;
            this.txtletra_intento5_posicion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtletra_intento5_posicion1
            // 
            this.txtletra_intento5_posicion1.Enabled = false;
            this.txtletra_intento5_posicion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra_intento5_posicion1.ForeColor = System.Drawing.Color.White;
            this.txtletra_intento5_posicion1.Location = new System.Drawing.Point(20, 287);
            this.txtletra_intento5_posicion1.Name = "txtletra_intento5_posicion1";
            this.txtletra_intento5_posicion1.Size = new System.Drawing.Size(40, 38);
            this.txtletra_intento5_posicion1.TabIndex = 39;
            this.txtletra_intento5_posicion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 385);
            this.Controls.Add(this.txtletra_intento6_posicion5);
            this.Controls.Add(this.txtletra_intento6_posicion4);
            this.Controls.Add(this.txtletra_intento6_posicion3);
            this.Controls.Add(this.txtletra_intento6_posicion2);
            this.Controls.Add(this.txtletra_intento6_posicion1);
            this.Controls.Add(this.txtletra_intento5_posicion5);
            this.Controls.Add(this.txtletra_intento5_posicion4);
            this.Controls.Add(this.txtletra_intento5_posicion3);
            this.Controls.Add(this.txtletra_intento5_posicion2);
            this.Controls.Add(this.txtletra_intento5_posicion1);
            this.Controls.Add(this.txtletra_intento4_posicion5);
            this.Controls.Add(this.txtletra_intento4_posicion4);
            this.Controls.Add(this.txtletra_intento4_posicion3);
            this.Controls.Add(this.txtletra_intento4_posicion2);
            this.Controls.Add(this.txtletra_intento4_posicion1);
            this.Controls.Add(this.txtletra_intento3_posicion5);
            this.Controls.Add(this.txtletra_intento3_posicion4);
            this.Controls.Add(this.txtletra_intento3_posicion3);
            this.Controls.Add(this.txtletra_intento3_posicion2);
            this.Controls.Add(this.txtletra_intento3_posicion1);
            this.Controls.Add(this.txtletra_intento2_posicion5);
            this.Controls.Add(this.txtletra_intento2_posicion4);
            this.Controls.Add(this.txtletra_intento2_posicion3);
            this.Controls.Add(this.txtletra_intento2_posicion2);
            this.Controls.Add(this.txtletra_intento2_posicion1);
            this.Controls.Add(this.txtletra_intento1_posicion5);
            this.Controls.Add(this.txtletra_intento1_posicion4);
            this.Controls.Add(this.txtletra_intento1_posicion3);
            this.Controls.Add(this.txtletra_intento1_posicion2);
            this.Controls.Add(this.txtletra_intento1_posicion1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtColorFallido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtColorDesubicado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtColorCorrecto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEvaluaPalabra);
            this.Controls.Add(this.txtPalabraIngresada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Wordle - UPB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPalabraIngresada;
        private System.Windows.Forms.Button btnEvaluaPalabra;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activarColoresAltoContrasteToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColorCorrecto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtColorDesubicado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtColorFallido;
        private System.Windows.Forms.TextBox txtletra_intento1_posicion1;
        private System.Windows.Forms.TextBox txtletra_intento1_posicion2;
        private System.Windows.Forms.TextBox txtletra_intento1_posicion4;
        private System.Windows.Forms.TextBox txtletra_intento1_posicion3;
        private System.Windows.Forms.TextBox txtletra_intento1_posicion5;
        private System.Windows.Forms.TextBox txtletra_intento2_posicion5;
        private System.Windows.Forms.TextBox txtletra_intento2_posicion4;
        private System.Windows.Forms.TextBox txtletra_intento2_posicion3;
        private System.Windows.Forms.TextBox txtletra_intento2_posicion2;
        private System.Windows.Forms.TextBox txtletra_intento2_posicion1;
        private System.Windows.Forms.TextBox txtletra_intento4_posicion5;
        private System.Windows.Forms.TextBox txtletra_intento4_posicion4;
        private System.Windows.Forms.TextBox txtletra_intento4_posicion3;
        private System.Windows.Forms.TextBox txtletra_intento4_posicion2;
        private System.Windows.Forms.TextBox txtletra_intento4_posicion1;
        private System.Windows.Forms.TextBox txtletra_intento3_posicion5;
        private System.Windows.Forms.TextBox txtletra_intento3_posicion4;
        private System.Windows.Forms.TextBox txtletra_intento3_posicion3;
        private System.Windows.Forms.TextBox txtletra_intento3_posicion2;
        private System.Windows.Forms.TextBox txtletra_intento3_posicion1;
        private System.Windows.Forms.TextBox txtletra_intento6_posicion5;
        private System.Windows.Forms.TextBox txtletra_intento6_posicion4;
        private System.Windows.Forms.TextBox txtletra_intento6_posicion3;
        private System.Windows.Forms.TextBox txtletra_intento6_posicion2;
        private System.Windows.Forms.TextBox txtletra_intento6_posicion1;
        private System.Windows.Forms.TextBox txtletra_intento5_posicion5;
        private System.Windows.Forms.TextBox txtletra_intento5_posicion4;
        private System.Windows.Forms.TextBox txtletra_intento5_posicion3;
        private System.Windows.Forms.TextBox txtletra_intento5_posicion2;
        private System.Windows.Forms.TextBox txtletra_intento5_posicion1;
    }
}

