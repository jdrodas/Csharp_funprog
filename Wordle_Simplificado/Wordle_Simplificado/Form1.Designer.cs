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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblColorCorrecto = new System.Windows.Forms.Label();
            this.lblColorDesubicado = new System.Windows.Forms.Label();
            this.lblColorFallido = new System.Windows.Forms.Label();
            this.lblLetra_intento1_posicion1 = new System.Windows.Forms.Label();
            this.lblLetra_intento1_posicion2 = new System.Windows.Forms.Label();
            this.lblLetra_intento1_posicion3 = new System.Windows.Forms.Label();
            this.lblLetra_intento1_posicion4 = new System.Windows.Forms.Label();
            this.lblLetra_intento1_posicion5 = new System.Windows.Forms.Label();
            this.lblLetra_intento2_posicion5 = new System.Windows.Forms.Label();
            this.lblLetra_intento2_posicion4 = new System.Windows.Forms.Label();
            this.lblLetra_intento2_posicion3 = new System.Windows.Forms.Label();
            this.lblLetra_intento2_posicion2 = new System.Windows.Forms.Label();
            this.lblLetra_intento2_posicion1 = new System.Windows.Forms.Label();
            this.lblLetra_intento4_posicion5 = new System.Windows.Forms.Label();
            this.lblLetra_intento4_posicion4 = new System.Windows.Forms.Label();
            this.lblLetra_intento4_posicion3 = new System.Windows.Forms.Label();
            this.lblLetra_intento4_posicion2 = new System.Windows.Forms.Label();
            this.lblLetra_intento4_posicion1 = new System.Windows.Forms.Label();
            this.lblLetra_intento3_posicion5 = new System.Windows.Forms.Label();
            this.lblLetra_intento3_posicion4 = new System.Windows.Forms.Label();
            this.lblLetra_intento3_posicion3 = new System.Windows.Forms.Label();
            this.lblLetra_intento3_posicion2 = new System.Windows.Forms.Label();
            this.lblLetra_intento3_posicion1 = new System.Windows.Forms.Label();
            this.lblLetra_intento6_posicion5 = new System.Windows.Forms.Label();
            this.lblLetra_intento6_posicion4 = new System.Windows.Forms.Label();
            this.lblLetra_intento6_posicion3 = new System.Windows.Forms.Label();
            this.lblLetra_intento6_posicion2 = new System.Windows.Forms.Label();
            this.lblLetra_intento6_posicion1 = new System.Windows.Forms.Label();
            this.lblLetra_intento5_posicion5 = new System.Windows.Forms.Label();
            this.lblLetra_intento5_posicion4 = new System.Windows.Forms.Label();
            this.lblLetra_intento5_posicion3 = new System.Windows.Forms.Label();
            this.lblLetra_intento5_posicion2 = new System.Windows.Forms.Label();
            this.lblLetra_intento5_posicion1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wordle Simplificado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Palabra ingresada:";
            // 
            // txtPalabraIngresada
            // 
            this.txtPalabraIngresada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalabraIngresada.Location = new System.Drawing.Point(273, 139);
            this.txtPalabraIngresada.MaxLength = 5;
            this.txtPalabraIngresada.Name = "txtPalabraIngresada";
            this.txtPalabraIngresada.Size = new System.Drawing.Size(100, 29);
            this.txtPalabraIngresada.TabIndex = 2;
            // 
            // btnEvaluaPalabra
            // 
            this.btnEvaluaPalabra.Location = new System.Drawing.Point(273, 174);
            this.btnEvaluaPalabra.Name = "btnEvaluaPalabra";
            this.btnEvaluaPalabra.Size = new System.Drawing.Size(100, 23);
            this.btnEvaluaPalabra.TabIndex = 3;
            this.btnEvaluaPalabra.Text = "Evaluar Palabra";
            this.btnEvaluaPalabra.UseVisualStyleBackColor = true;
            this.btnEvaluaPalabra.Click += new System.EventHandler(this.BtnEvaluaPalabra_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
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
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.NuevoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
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
            this.activarColoresAltoContrasteToolStripMenuItem.Click += new System.EventHandler(this.ActivarColoresAltoContrasteToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ayuda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Posición correcta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Posición desubicada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Posición fallida";
            // 
            // lblColorCorrecto
            // 
            this.lblColorCorrecto.BackColor = System.Drawing.Color.White;
            this.lblColorCorrecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColorCorrecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblColorCorrecto.ForeColor = System.Drawing.Color.White;
            this.lblColorCorrecto.Location = new System.Drawing.Point(273, 241);
            this.lblColorCorrecto.Name = "lblColorCorrecto";
            this.lblColorCorrecto.Size = new System.Drawing.Size(40, 40);
            this.lblColorCorrecto.TabIndex = 49;
            this.lblColorCorrecto.Text = "V";
            this.lblColorCorrecto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorDesubicado
            // 
            this.lblColorDesubicado.BackColor = System.Drawing.Color.White;
            this.lblColorDesubicado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColorDesubicado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblColorDesubicado.ForeColor = System.Drawing.Color.White;
            this.lblColorDesubicado.Location = new System.Drawing.Point(273, 286);
            this.lblColorDesubicado.Name = "lblColorDesubicado";
            this.lblColorDesubicado.Size = new System.Drawing.Size(40, 40);
            this.lblColorDesubicado.TabIndex = 50;
            this.lblColorDesubicado.Text = "V";
            this.lblColorDesubicado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorFallido
            // 
            this.lblColorFallido.BackColor = System.Drawing.Color.White;
            this.lblColorFallido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColorFallido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblColorFallido.ForeColor = System.Drawing.Color.White;
            this.lblColorFallido.Location = new System.Drawing.Point(273, 331);
            this.lblColorFallido.Name = "lblColorFallido";
            this.lblColorFallido.Size = new System.Drawing.Size(40, 40);
            this.lblColorFallido.TabIndex = 51;
            this.lblColorFallido.Text = "V";
            this.lblColorFallido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento1_posicion1
            // 
            this.lblLetra_intento1_posicion1.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento1_posicion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento1_posicion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento1_posicion1.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento1_posicion1.Location = new System.Drawing.Point(20, 100);
            this.lblLetra_intento1_posicion1.Name = "lblLetra_intento1_posicion1";
            this.lblLetra_intento1_posicion1.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento1_posicion1.TabIndex = 52;
            this.lblLetra_intento1_posicion1.Text = "V";
            this.lblLetra_intento1_posicion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento1_posicion2
            // 
            this.lblLetra_intento1_posicion2.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento1_posicion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento1_posicion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento1_posicion2.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento1_posicion2.Location = new System.Drawing.Point(65, 100);
            this.lblLetra_intento1_posicion2.Name = "lblLetra_intento1_posicion2";
            this.lblLetra_intento1_posicion2.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento1_posicion2.TabIndex = 53;
            this.lblLetra_intento1_posicion2.Text = "V";
            this.lblLetra_intento1_posicion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento1_posicion3
            // 
            this.lblLetra_intento1_posicion3.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento1_posicion3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento1_posicion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento1_posicion3.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento1_posicion3.Location = new System.Drawing.Point(110, 100);
            this.lblLetra_intento1_posicion3.Name = "lblLetra_intento1_posicion3";
            this.lblLetra_intento1_posicion3.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento1_posicion3.TabIndex = 54;
            this.lblLetra_intento1_posicion3.Text = "V";
            this.lblLetra_intento1_posicion3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento1_posicion4
            // 
            this.lblLetra_intento1_posicion4.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento1_posicion4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento1_posicion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento1_posicion4.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento1_posicion4.Location = new System.Drawing.Point(155, 100);
            this.lblLetra_intento1_posicion4.Name = "lblLetra_intento1_posicion4";
            this.lblLetra_intento1_posicion4.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento1_posicion4.TabIndex = 55;
            this.lblLetra_intento1_posicion4.Text = "V";
            this.lblLetra_intento1_posicion4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento1_posicion5
            // 
            this.lblLetra_intento1_posicion5.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento1_posicion5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento1_posicion5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento1_posicion5.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento1_posicion5.Location = new System.Drawing.Point(200, 100);
            this.lblLetra_intento1_posicion5.Name = "lblLetra_intento1_posicion5";
            this.lblLetra_intento1_posicion5.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento1_posicion5.TabIndex = 56;
            this.lblLetra_intento1_posicion5.Text = "V";
            this.lblLetra_intento1_posicion5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento2_posicion5
            // 
            this.lblLetra_intento2_posicion5.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento2_posicion5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento2_posicion5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento2_posicion5.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento2_posicion5.Location = new System.Drawing.Point(200, 145);
            this.lblLetra_intento2_posicion5.Name = "lblLetra_intento2_posicion5";
            this.lblLetra_intento2_posicion5.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento2_posicion5.TabIndex = 61;
            this.lblLetra_intento2_posicion5.Text = "V";
            this.lblLetra_intento2_posicion5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento2_posicion4
            // 
            this.lblLetra_intento2_posicion4.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento2_posicion4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento2_posicion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento2_posicion4.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento2_posicion4.Location = new System.Drawing.Point(155, 145);
            this.lblLetra_intento2_posicion4.Name = "lblLetra_intento2_posicion4";
            this.lblLetra_intento2_posicion4.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento2_posicion4.TabIndex = 60;
            this.lblLetra_intento2_posicion4.Text = "V";
            this.lblLetra_intento2_posicion4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento2_posicion3
            // 
            this.lblLetra_intento2_posicion3.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento2_posicion3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento2_posicion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento2_posicion3.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento2_posicion3.Location = new System.Drawing.Point(110, 145);
            this.lblLetra_intento2_posicion3.Name = "lblLetra_intento2_posicion3";
            this.lblLetra_intento2_posicion3.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento2_posicion3.TabIndex = 59;
            this.lblLetra_intento2_posicion3.Text = "V";
            this.lblLetra_intento2_posicion3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento2_posicion2
            // 
            this.lblLetra_intento2_posicion2.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento2_posicion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento2_posicion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento2_posicion2.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento2_posicion2.Location = new System.Drawing.Point(65, 145);
            this.lblLetra_intento2_posicion2.Name = "lblLetra_intento2_posicion2";
            this.lblLetra_intento2_posicion2.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento2_posicion2.TabIndex = 58;
            this.lblLetra_intento2_posicion2.Text = "V";
            this.lblLetra_intento2_posicion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento2_posicion1
            // 
            this.lblLetra_intento2_posicion1.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento2_posicion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento2_posicion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento2_posicion1.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento2_posicion1.Location = new System.Drawing.Point(20, 145);
            this.lblLetra_intento2_posicion1.Name = "lblLetra_intento2_posicion1";
            this.lblLetra_intento2_posicion1.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento2_posicion1.TabIndex = 57;
            this.lblLetra_intento2_posicion1.Text = "V";
            this.lblLetra_intento2_posicion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento4_posicion5
            // 
            this.lblLetra_intento4_posicion5.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento4_posicion5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento4_posicion5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento4_posicion5.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento4_posicion5.Location = new System.Drawing.Point(200, 235);
            this.lblLetra_intento4_posicion5.Name = "lblLetra_intento4_posicion5";
            this.lblLetra_intento4_posicion5.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento4_posicion5.TabIndex = 71;
            this.lblLetra_intento4_posicion5.Text = "V";
            this.lblLetra_intento4_posicion5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento4_posicion4
            // 
            this.lblLetra_intento4_posicion4.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento4_posicion4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento4_posicion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento4_posicion4.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento4_posicion4.Location = new System.Drawing.Point(155, 235);
            this.lblLetra_intento4_posicion4.Name = "lblLetra_intento4_posicion4";
            this.lblLetra_intento4_posicion4.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento4_posicion4.TabIndex = 70;
            this.lblLetra_intento4_posicion4.Text = "V";
            this.lblLetra_intento4_posicion4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento4_posicion3
            // 
            this.lblLetra_intento4_posicion3.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento4_posicion3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento4_posicion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento4_posicion3.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento4_posicion3.Location = new System.Drawing.Point(110, 235);
            this.lblLetra_intento4_posicion3.Name = "lblLetra_intento4_posicion3";
            this.lblLetra_intento4_posicion3.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento4_posicion3.TabIndex = 69;
            this.lblLetra_intento4_posicion3.Text = "V";
            this.lblLetra_intento4_posicion3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento4_posicion2
            // 
            this.lblLetra_intento4_posicion2.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento4_posicion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento4_posicion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento4_posicion2.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento4_posicion2.Location = new System.Drawing.Point(65, 235);
            this.lblLetra_intento4_posicion2.Name = "lblLetra_intento4_posicion2";
            this.lblLetra_intento4_posicion2.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento4_posicion2.TabIndex = 68;
            this.lblLetra_intento4_posicion2.Text = "V";
            this.lblLetra_intento4_posicion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento4_posicion1
            // 
            this.lblLetra_intento4_posicion1.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento4_posicion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento4_posicion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento4_posicion1.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento4_posicion1.Location = new System.Drawing.Point(20, 235);
            this.lblLetra_intento4_posicion1.Name = "lblLetra_intento4_posicion1";
            this.lblLetra_intento4_posicion1.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento4_posicion1.TabIndex = 67;
            this.lblLetra_intento4_posicion1.Text = "V";
            this.lblLetra_intento4_posicion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento3_posicion5
            // 
            this.lblLetra_intento3_posicion5.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento3_posicion5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento3_posicion5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento3_posicion5.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento3_posicion5.Location = new System.Drawing.Point(200, 190);
            this.lblLetra_intento3_posicion5.Name = "lblLetra_intento3_posicion5";
            this.lblLetra_intento3_posicion5.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento3_posicion5.TabIndex = 66;
            this.lblLetra_intento3_posicion5.Text = "V";
            this.lblLetra_intento3_posicion5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento3_posicion4
            // 
            this.lblLetra_intento3_posicion4.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento3_posicion4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento3_posicion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento3_posicion4.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento3_posicion4.Location = new System.Drawing.Point(155, 190);
            this.lblLetra_intento3_posicion4.Name = "lblLetra_intento3_posicion4";
            this.lblLetra_intento3_posicion4.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento3_posicion4.TabIndex = 65;
            this.lblLetra_intento3_posicion4.Text = "V";
            this.lblLetra_intento3_posicion4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento3_posicion3
            // 
            this.lblLetra_intento3_posicion3.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento3_posicion3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento3_posicion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento3_posicion3.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento3_posicion3.Location = new System.Drawing.Point(110, 190);
            this.lblLetra_intento3_posicion3.Name = "lblLetra_intento3_posicion3";
            this.lblLetra_intento3_posicion3.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento3_posicion3.TabIndex = 64;
            this.lblLetra_intento3_posicion3.Text = "V";
            this.lblLetra_intento3_posicion3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento3_posicion2
            // 
            this.lblLetra_intento3_posicion2.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento3_posicion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento3_posicion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento3_posicion2.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento3_posicion2.Location = new System.Drawing.Point(65, 190);
            this.lblLetra_intento3_posicion2.Name = "lblLetra_intento3_posicion2";
            this.lblLetra_intento3_posicion2.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento3_posicion2.TabIndex = 63;
            this.lblLetra_intento3_posicion2.Text = "V";
            this.lblLetra_intento3_posicion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento3_posicion1
            // 
            this.lblLetra_intento3_posicion1.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento3_posicion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento3_posicion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento3_posicion1.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento3_posicion1.Location = new System.Drawing.Point(20, 190);
            this.lblLetra_intento3_posicion1.Name = "lblLetra_intento3_posicion1";
            this.lblLetra_intento3_posicion1.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento3_posicion1.TabIndex = 62;
            this.lblLetra_intento3_posicion1.Text = "V";
            this.lblLetra_intento3_posicion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento6_posicion5
            // 
            this.lblLetra_intento6_posicion5.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento6_posicion5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento6_posicion5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento6_posicion5.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento6_posicion5.Location = new System.Drawing.Point(200, 325);
            this.lblLetra_intento6_posicion5.Name = "lblLetra_intento6_posicion5";
            this.lblLetra_intento6_posicion5.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento6_posicion5.TabIndex = 81;
            this.lblLetra_intento6_posicion5.Text = "V";
            this.lblLetra_intento6_posicion5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento6_posicion4
            // 
            this.lblLetra_intento6_posicion4.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento6_posicion4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento6_posicion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento6_posicion4.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento6_posicion4.Location = new System.Drawing.Point(155, 325);
            this.lblLetra_intento6_posicion4.Name = "lblLetra_intento6_posicion4";
            this.lblLetra_intento6_posicion4.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento6_posicion4.TabIndex = 80;
            this.lblLetra_intento6_posicion4.Text = "V";
            this.lblLetra_intento6_posicion4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento6_posicion3
            // 
            this.lblLetra_intento6_posicion3.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento6_posicion3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento6_posicion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento6_posicion3.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento6_posicion3.Location = new System.Drawing.Point(110, 325);
            this.lblLetra_intento6_posicion3.Name = "lblLetra_intento6_posicion3";
            this.lblLetra_intento6_posicion3.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento6_posicion3.TabIndex = 79;
            this.lblLetra_intento6_posicion3.Text = "V";
            this.lblLetra_intento6_posicion3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento6_posicion2
            // 
            this.lblLetra_intento6_posicion2.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento6_posicion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento6_posicion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento6_posicion2.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento6_posicion2.Location = new System.Drawing.Point(65, 325);
            this.lblLetra_intento6_posicion2.Name = "lblLetra_intento6_posicion2";
            this.lblLetra_intento6_posicion2.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento6_posicion2.TabIndex = 78;
            this.lblLetra_intento6_posicion2.Text = "V";
            this.lblLetra_intento6_posicion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento6_posicion1
            // 
            this.lblLetra_intento6_posicion1.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento6_posicion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento6_posicion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento6_posicion1.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento6_posicion1.Location = new System.Drawing.Point(20, 325);
            this.lblLetra_intento6_posicion1.Name = "lblLetra_intento6_posicion1";
            this.lblLetra_intento6_posicion1.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento6_posicion1.TabIndex = 77;
            this.lblLetra_intento6_posicion1.Text = "V";
            this.lblLetra_intento6_posicion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento5_posicion5
            // 
            this.lblLetra_intento5_posicion5.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento5_posicion5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento5_posicion5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento5_posicion5.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento5_posicion5.Location = new System.Drawing.Point(200, 280);
            this.lblLetra_intento5_posicion5.Name = "lblLetra_intento5_posicion5";
            this.lblLetra_intento5_posicion5.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento5_posicion5.TabIndex = 76;
            this.lblLetra_intento5_posicion5.Text = "V";
            this.lblLetra_intento5_posicion5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento5_posicion4
            // 
            this.lblLetra_intento5_posicion4.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento5_posicion4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento5_posicion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento5_posicion4.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento5_posicion4.Location = new System.Drawing.Point(155, 280);
            this.lblLetra_intento5_posicion4.Name = "lblLetra_intento5_posicion4";
            this.lblLetra_intento5_posicion4.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento5_posicion4.TabIndex = 75;
            this.lblLetra_intento5_posicion4.Text = "V";
            this.lblLetra_intento5_posicion4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento5_posicion3
            // 
            this.lblLetra_intento5_posicion3.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento5_posicion3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento5_posicion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento5_posicion3.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento5_posicion3.Location = new System.Drawing.Point(110, 280);
            this.lblLetra_intento5_posicion3.Name = "lblLetra_intento5_posicion3";
            this.lblLetra_intento5_posicion3.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento5_posicion3.TabIndex = 74;
            this.lblLetra_intento5_posicion3.Text = "V";
            this.lblLetra_intento5_posicion3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento5_posicion2
            // 
            this.lblLetra_intento5_posicion2.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento5_posicion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento5_posicion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento5_posicion2.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento5_posicion2.Location = new System.Drawing.Point(65, 280);
            this.lblLetra_intento5_posicion2.Name = "lblLetra_intento5_posicion2";
            this.lblLetra_intento5_posicion2.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento5_posicion2.TabIndex = 73;
            this.lblLetra_intento5_posicion2.Text = "V";
            this.lblLetra_intento5_posicion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento5_posicion1
            // 
            this.lblLetra_intento5_posicion1.BackColor = System.Drawing.Color.White;
            this.lblLetra_intento5_posicion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra_intento5_posicion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblLetra_intento5_posicion1.ForeColor = System.Drawing.Color.White;
            this.lblLetra_intento5_posicion1.Location = new System.Drawing.Point(20, 280);
            this.lblLetra_intento5_posicion1.Name = "lblLetra_intento5_posicion1";
            this.lblLetra_intento5_posicion1.Size = new System.Drawing.Size(40, 40);
            this.lblLetra_intento5_posicion1.TabIndex = 72;
            this.lblLetra_intento5_posicion1.Text = "V";
            this.lblLetra_intento5_posicion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 391);
            this.Controls.Add(this.lblLetra_intento6_posicion5);
            this.Controls.Add(this.lblLetra_intento6_posicion4);
            this.Controls.Add(this.lblLetra_intento6_posicion3);
            this.Controls.Add(this.lblLetra_intento6_posicion2);
            this.Controls.Add(this.lblLetra_intento6_posicion1);
            this.Controls.Add(this.lblLetra_intento5_posicion5);
            this.Controls.Add(this.lblLetra_intento5_posicion4);
            this.Controls.Add(this.lblLetra_intento5_posicion3);
            this.Controls.Add(this.lblLetra_intento5_posicion2);
            this.Controls.Add(this.lblLetra_intento5_posicion1);
            this.Controls.Add(this.lblLetra_intento4_posicion5);
            this.Controls.Add(this.lblLetra_intento4_posicion4);
            this.Controls.Add(this.lblLetra_intento4_posicion3);
            this.Controls.Add(this.lblLetra_intento4_posicion2);
            this.Controls.Add(this.lblLetra_intento4_posicion1);
            this.Controls.Add(this.lblLetra_intento3_posicion5);
            this.Controls.Add(this.lblLetra_intento3_posicion4);
            this.Controls.Add(this.lblLetra_intento3_posicion3);
            this.Controls.Add(this.lblLetra_intento3_posicion2);
            this.Controls.Add(this.lblLetra_intento3_posicion1);
            this.Controls.Add(this.lblLetra_intento2_posicion5);
            this.Controls.Add(this.lblLetra_intento2_posicion4);
            this.Controls.Add(this.lblLetra_intento2_posicion3);
            this.Controls.Add(this.lblLetra_intento2_posicion2);
            this.Controls.Add(this.lblLetra_intento2_posicion1);
            this.Controls.Add(this.lblLetra_intento1_posicion5);
            this.Controls.Add(this.lblLetra_intento1_posicion4);
            this.Controls.Add(this.lblLetra_intento1_posicion3);
            this.Controls.Add(this.lblLetra_intento1_posicion2);
            this.Controls.Add(this.lblLetra_intento1_posicion1);
            this.Controls.Add(this.lblColorFallido);
            this.Controls.Add(this.lblColorDesubicado);
            this.Controls.Add(this.lblColorCorrecto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEvaluaPalabra);
            this.Controls.Add(this.txtPalabraIngresada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wordle Simplificado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblColorCorrecto;
        private System.Windows.Forms.Label lblColorDesubicado;
        private System.Windows.Forms.Label lblColorFallido;
        private System.Windows.Forms.Label lblLetra_intento1_posicion1;
        private System.Windows.Forms.Label lblLetra_intento1_posicion2;
        private System.Windows.Forms.Label lblLetra_intento1_posicion3;
        private System.Windows.Forms.Label lblLetra_intento1_posicion4;
        private System.Windows.Forms.Label lblLetra_intento1_posicion5;
        private System.Windows.Forms.Label lblLetra_intento2_posicion5;
        private System.Windows.Forms.Label lblLetra_intento2_posicion4;
        private System.Windows.Forms.Label lblLetra_intento2_posicion3;
        private System.Windows.Forms.Label lblLetra_intento2_posicion2;
        private System.Windows.Forms.Label lblLetra_intento2_posicion1;
        private System.Windows.Forms.Label lblLetra_intento4_posicion5;
        private System.Windows.Forms.Label lblLetra_intento4_posicion4;
        private System.Windows.Forms.Label lblLetra_intento4_posicion3;
        private System.Windows.Forms.Label lblLetra_intento4_posicion2;
        private System.Windows.Forms.Label lblLetra_intento4_posicion1;
        private System.Windows.Forms.Label lblLetra_intento3_posicion5;
        private System.Windows.Forms.Label lblLetra_intento3_posicion4;
        private System.Windows.Forms.Label lblLetra_intento3_posicion3;
        private System.Windows.Forms.Label lblLetra_intento3_posicion2;
        private System.Windows.Forms.Label lblLetra_intento3_posicion1;
        private System.Windows.Forms.Label lblLetra_intento6_posicion5;
        private System.Windows.Forms.Label lblLetra_intento6_posicion4;
        private System.Windows.Forms.Label lblLetra_intento6_posicion3;
        private System.Windows.Forms.Label lblLetra_intento6_posicion2;
        private System.Windows.Forms.Label lblLetra_intento6_posicion1;
        private System.Windows.Forms.Label lblLetra_intento5_posicion5;
        private System.Windows.Forms.Label lblLetra_intento5_posicion4;
        private System.Windows.Forms.Label lblLetra_intento5_posicion3;
        private System.Windows.Forms.Label lblLetra_intento5_posicion2;
        private System.Windows.Forms.Label lblLetra_intento5_posicion1;
    }
}