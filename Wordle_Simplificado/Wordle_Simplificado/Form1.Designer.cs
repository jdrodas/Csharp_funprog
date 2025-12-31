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
            label1 = new Label();
            label2 = new Label();
            txtPalabraIngresada = new TextBox();
            btnEvaluaPalabra = new Button();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            configuraciónToolStripMenuItem = new ToolStripMenuItem();
            activarColoresAltoContrasteToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblColorCorrecto = new Label();
            lblColorDesubicado = new Label();
            lblColorFallido = new Label();
            lblLetra_intento1_posicion1 = new Label();
            lblLetra_intento1_posicion2 = new Label();
            lblLetra_intento1_posicion3 = new Label();
            lblLetra_intento1_posicion4 = new Label();
            lblLetra_intento1_posicion5 = new Label();
            lblLetra_intento2_posicion5 = new Label();
            lblLetra_intento2_posicion4 = new Label();
            lblLetra_intento2_posicion3 = new Label();
            lblLetra_intento2_posicion2 = new Label();
            lblLetra_intento2_posicion1 = new Label();
            lblLetra_intento4_posicion5 = new Label();
            lblLetra_intento4_posicion4 = new Label();
            lblLetra_intento4_posicion3 = new Label();
            lblLetra_intento4_posicion2 = new Label();
            lblLetra_intento4_posicion1 = new Label();
            lblLetra_intento3_posicion5 = new Label();
            lblLetra_intento3_posicion4 = new Label();
            lblLetra_intento3_posicion3 = new Label();
            lblLetra_intento3_posicion2 = new Label();
            lblLetra_intento3_posicion1 = new Label();
            lblLetra_intento6_posicion5 = new Label();
            lblLetra_intento6_posicion4 = new Label();
            lblLetra_intento6_posicion3 = new Label();
            lblLetra_intento6_posicion2 = new Label();
            lblLetra_intento6_posicion1 = new Label();
            lblLetra_intento5_posicion5 = new Label();
            lblLetra_intento5_posicion4 = new Label();
            lblLetra_intento5_posicion3 = new Label();
            lblLetra_intento5_posicion2 = new Label();
            lblLetra_intento5_posicion1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(42, 42);
            label1.Name = "label1";
            label1.Size = new Size(331, 45);
            label1.TabIndex = 0;
            label1.Text = "Wordle Simplificado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 122);
            label2.Name = "label2";
            label2.Size = new Size(95, 13);
            label2.TabIndex = 1;
            label2.Text = "Palabra ingresada:";
            // 
            // txtPalabraIngresada
            // 
            txtPalabraIngresada.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            txtPalabraIngresada.Location = new Point(273, 139);
            txtPalabraIngresada.MaxLength = 5;
            txtPalabraIngresada.Name = "txtPalabraIngresada";
            txtPalabraIngresada.Size = new Size(100, 29);
            txtPalabraIngresada.TabIndex = 2;
            // 
            // btnEvaluaPalabra
            // 
            btnEvaluaPalabra.Location = new Point(273, 174);
            btnEvaluaPalabra.Name = "btnEvaluaPalabra";
            btnEvaluaPalabra.Size = new Size(100, 23);
            btnEvaluaPalabra.TabIndex = 3;
            btnEvaluaPalabra.Text = "Evaluar Palabra";
            btnEvaluaPalabra.UseVisualStyleBackColor = true;
            btnEvaluaPalabra.Click += new System.EventHandler(BtnEvaluaPalabra_Click);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] {
            archivoToolStripMenuItem,
            configuraciónToolStripMenuItem});
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(434, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            nuevoToolStripMenuItem,
            salirToolStripMenuItem});
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            nuevoToolStripMenuItem.Size = new Size(152, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += new System.EventHandler(NuevoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            salirToolStripMenuItem.Size = new Size(152, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += new System.EventHandler(SalirToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            configuraciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            activarColoresAltoContrasteToolStripMenuItem});
            configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            configuraciónToolStripMenuItem.Size = new Size(95, 20);
            configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // activarColoresAltoContrasteToolStripMenuItem
            // 
            activarColoresAltoContrasteToolStripMenuItem.Name = "activarColoresAltoContrasteToolStripMenuItem";
            activarColoresAltoContrasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.C)));
            activarColoresAltoContrasteToolStripMenuItem.Size = new Size(301, 22);
            activarColoresAltoContrasteToolStripMenuItem.Text = "Activar colores alto contraste";
            activarColoresAltoContrasteToolStripMenuItem.Click += new System.EventHandler(ActivarColoresAltoContrasteToolStripMenuItem_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 222);
            label3.Name = "label3";
            label3.Size = new Size(40, 13);
            label3.TabIndex = 12;
            label3.Text = "Ayuda:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(320, 255);
            label6.Name = "label6";
            label6.Size = new Size(89, 13);
            label6.TabIndex = 14;
            label6.Text = "Posición correcta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(320, 301);
            label7.Name = "label7";
            label7.Size = new Size(105, 13);
            label7.TabIndex = 16;
            label7.Text = "Posición desubicada";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(320, 345);
            label8.Name = "label8";
            label8.Size = new Size(77, 13);
            label8.TabIndex = 18;
            label8.Text = "Posición fallida";
            // 
            // lblColorCorrecto
            // 
            lblColorCorrecto.BackColor = Color.White;
            lblColorCorrecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblColorCorrecto.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblColorCorrecto.ForeColor = Color.White;
            lblColorCorrecto.Location = new Point(273, 241);
            lblColorCorrecto.Name = "lblColorCorrecto";
            lblColorCorrecto.Size = new Size(40, 40);
            lblColorCorrecto.TabIndex = 49;
            lblColorCorrecto.Text = "V";
            lblColorCorrecto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblColorDesubicado
            // 
            lblColorDesubicado.BackColor = Color.White;
            lblColorDesubicado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblColorDesubicado.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblColorDesubicado.ForeColor = Color.White;
            lblColorDesubicado.Location = new Point(273, 286);
            lblColorDesubicado.Name = "lblColorDesubicado";
            lblColorDesubicado.Size = new Size(40, 40);
            lblColorDesubicado.TabIndex = 50;
            lblColorDesubicado.Text = "V";
            lblColorDesubicado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblColorFallido
            // 
            lblColorFallido.BackColor = Color.White;
            lblColorFallido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblColorFallido.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblColorFallido.ForeColor = Color.White;
            lblColorFallido.Location = new Point(273, 331);
            lblColorFallido.Name = "lblColorFallido";
            lblColorFallido.Size = new Size(40, 40);
            lblColorFallido.TabIndex = 51;
            lblColorFallido.Text = "V";
            lblColorFallido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento1_posicion1
            // 
            lblLetra_intento1_posicion1.BackColor = Color.White;
            lblLetra_intento1_posicion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento1_posicion1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento1_posicion1.ForeColor = Color.White;
            lblLetra_intento1_posicion1.Location = new Point(20, 100);
            lblLetra_intento1_posicion1.Name = "lblLetra_intento1_posicion1";
            lblLetra_intento1_posicion1.Size = new Size(40, 40);
            lblLetra_intento1_posicion1.TabIndex = 52;
            lblLetra_intento1_posicion1.Text = "V";
            lblLetra_intento1_posicion1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento1_posicion2
            // 
            lblLetra_intento1_posicion2.BackColor = Color.White;
            lblLetra_intento1_posicion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento1_posicion2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento1_posicion2.ForeColor = Color.White;
            lblLetra_intento1_posicion2.Location = new Point(65, 100);
            lblLetra_intento1_posicion2.Name = "lblLetra_intento1_posicion2";
            lblLetra_intento1_posicion2.Size = new Size(40, 40);
            lblLetra_intento1_posicion2.TabIndex = 53;
            lblLetra_intento1_posicion2.Text = "V";
            lblLetra_intento1_posicion2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento1_posicion3
            // 
            lblLetra_intento1_posicion3.BackColor = Color.White;
            lblLetra_intento1_posicion3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento1_posicion3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento1_posicion3.ForeColor = Color.White;
            lblLetra_intento1_posicion3.Location = new Point(110, 100);
            lblLetra_intento1_posicion3.Name = "lblLetra_intento1_posicion3";
            lblLetra_intento1_posicion3.Size = new Size(40, 40);
            lblLetra_intento1_posicion3.TabIndex = 54;
            lblLetra_intento1_posicion3.Text = "V";
            lblLetra_intento1_posicion3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento1_posicion4
            // 
            lblLetra_intento1_posicion4.BackColor = Color.White;
            lblLetra_intento1_posicion4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento1_posicion4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento1_posicion4.ForeColor = Color.White;
            lblLetra_intento1_posicion4.Location = new Point(155, 100);
            lblLetra_intento1_posicion4.Name = "lblLetra_intento1_posicion4";
            lblLetra_intento1_posicion4.Size = new Size(40, 40);
            lblLetra_intento1_posicion4.TabIndex = 55;
            lblLetra_intento1_posicion4.Text = "V";
            lblLetra_intento1_posicion4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento1_posicion5
            // 
            lblLetra_intento1_posicion5.BackColor = Color.White;
            lblLetra_intento1_posicion5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento1_posicion5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento1_posicion5.ForeColor = Color.White;
            lblLetra_intento1_posicion5.Location = new Point(200, 100);
            lblLetra_intento1_posicion5.Name = "lblLetra_intento1_posicion5";
            lblLetra_intento1_posicion5.Size = new Size(40, 40);
            lblLetra_intento1_posicion5.TabIndex = 56;
            lblLetra_intento1_posicion5.Text = "V";
            lblLetra_intento1_posicion5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento2_posicion5
            // 
            lblLetra_intento2_posicion5.BackColor = Color.White;
            lblLetra_intento2_posicion5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento2_posicion5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento2_posicion5.ForeColor = Color.White;
            lblLetra_intento2_posicion5.Location = new Point(200, 145);
            lblLetra_intento2_posicion5.Name = "lblLetra_intento2_posicion5";
            lblLetra_intento2_posicion5.Size = new Size(40, 40);
            lblLetra_intento2_posicion5.TabIndex = 61;
            lblLetra_intento2_posicion5.Text = "V";
            lblLetra_intento2_posicion5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento2_posicion4
            // 
            lblLetra_intento2_posicion4.BackColor = Color.White;
            lblLetra_intento2_posicion4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento2_posicion4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento2_posicion4.ForeColor = Color.White;
            lblLetra_intento2_posicion4.Location = new Point(155, 145);
            lblLetra_intento2_posicion4.Name = "lblLetra_intento2_posicion4";
            lblLetra_intento2_posicion4.Size = new Size(40, 40);
            lblLetra_intento2_posicion4.TabIndex = 60;
            lblLetra_intento2_posicion4.Text = "V";
            lblLetra_intento2_posicion4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento2_posicion3
            // 
            lblLetra_intento2_posicion3.BackColor = Color.White;
            lblLetra_intento2_posicion3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento2_posicion3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento2_posicion3.ForeColor = Color.White;
            lblLetra_intento2_posicion3.Location = new Point(110, 145);
            lblLetra_intento2_posicion3.Name = "lblLetra_intento2_posicion3";
            lblLetra_intento2_posicion3.Size = new Size(40, 40);
            lblLetra_intento2_posicion3.TabIndex = 59;
            lblLetra_intento2_posicion3.Text = "V";
            lblLetra_intento2_posicion3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento2_posicion2
            // 
            lblLetra_intento2_posicion2.BackColor = Color.White;
            lblLetra_intento2_posicion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento2_posicion2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento2_posicion2.ForeColor = Color.White;
            lblLetra_intento2_posicion2.Location = new Point(65, 145);
            lblLetra_intento2_posicion2.Name = "lblLetra_intento2_posicion2";
            lblLetra_intento2_posicion2.Size = new Size(40, 40);
            lblLetra_intento2_posicion2.TabIndex = 58;
            lblLetra_intento2_posicion2.Text = "V";
            lblLetra_intento2_posicion2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento2_posicion1
            // 
            lblLetra_intento2_posicion1.BackColor = Color.White;
            lblLetra_intento2_posicion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento2_posicion1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento2_posicion1.ForeColor = Color.White;
            lblLetra_intento2_posicion1.Location = new Point(20, 145);
            lblLetra_intento2_posicion1.Name = "lblLetra_intento2_posicion1";
            lblLetra_intento2_posicion1.Size = new Size(40, 40);
            lblLetra_intento2_posicion1.TabIndex = 57;
            lblLetra_intento2_posicion1.Text = "V";
            lblLetra_intento2_posicion1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento4_posicion5
            // 
            lblLetra_intento4_posicion5.BackColor = Color.White;
            lblLetra_intento4_posicion5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento4_posicion5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento4_posicion5.ForeColor = Color.White;
            lblLetra_intento4_posicion5.Location = new Point(200, 235);
            lblLetra_intento4_posicion5.Name = "lblLetra_intento4_posicion5";
            lblLetra_intento4_posicion5.Size = new Size(40, 40);
            lblLetra_intento4_posicion5.TabIndex = 71;
            lblLetra_intento4_posicion5.Text = "V";
            lblLetra_intento4_posicion5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento4_posicion4
            // 
            lblLetra_intento4_posicion4.BackColor = Color.White;
            lblLetra_intento4_posicion4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento4_posicion4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento4_posicion4.ForeColor = Color.White;
            lblLetra_intento4_posicion4.Location = new Point(155, 235);
            lblLetra_intento4_posicion4.Name = "lblLetra_intento4_posicion4";
            lblLetra_intento4_posicion4.Size = new Size(40, 40);
            lblLetra_intento4_posicion4.TabIndex = 70;
            lblLetra_intento4_posicion4.Text = "V";
            lblLetra_intento4_posicion4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento4_posicion3
            // 
            lblLetra_intento4_posicion3.BackColor = Color.White;
            lblLetra_intento4_posicion3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento4_posicion3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento4_posicion3.ForeColor = Color.White;
            lblLetra_intento4_posicion3.Location = new Point(110, 235);
            lblLetra_intento4_posicion3.Name = "lblLetra_intento4_posicion3";
            lblLetra_intento4_posicion3.Size = new Size(40, 40);
            lblLetra_intento4_posicion3.TabIndex = 69;
            lblLetra_intento4_posicion3.Text = "V";
            lblLetra_intento4_posicion3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento4_posicion2
            // 
            lblLetra_intento4_posicion2.BackColor = Color.White;
            lblLetra_intento4_posicion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento4_posicion2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento4_posicion2.ForeColor = Color.White;
            lblLetra_intento4_posicion2.Location = new Point(65, 235);
            lblLetra_intento4_posicion2.Name = "lblLetra_intento4_posicion2";
            lblLetra_intento4_posicion2.Size = new Size(40, 40);
            lblLetra_intento4_posicion2.TabIndex = 68;
            lblLetra_intento4_posicion2.Text = "V";
            lblLetra_intento4_posicion2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento4_posicion1
            // 
            lblLetra_intento4_posicion1.BackColor = Color.White;
            lblLetra_intento4_posicion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento4_posicion1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento4_posicion1.ForeColor = Color.White;
            lblLetra_intento4_posicion1.Location = new Point(20, 235);
            lblLetra_intento4_posicion1.Name = "lblLetra_intento4_posicion1";
            lblLetra_intento4_posicion1.Size = new Size(40, 40);
            lblLetra_intento4_posicion1.TabIndex = 67;
            lblLetra_intento4_posicion1.Text = "V";
            lblLetra_intento4_posicion1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento3_posicion5
            // 
            lblLetra_intento3_posicion5.BackColor = Color.White;
            lblLetra_intento3_posicion5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento3_posicion5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento3_posicion5.ForeColor = Color.White;
            lblLetra_intento3_posicion5.Location = new Point(200, 190);
            lblLetra_intento3_posicion5.Name = "lblLetra_intento3_posicion5";
            lblLetra_intento3_posicion5.Size = new Size(40, 40);
            lblLetra_intento3_posicion5.TabIndex = 66;
            lblLetra_intento3_posicion5.Text = "V";
            lblLetra_intento3_posicion5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento3_posicion4
            // 
            lblLetra_intento3_posicion4.BackColor = Color.White;
            lblLetra_intento3_posicion4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento3_posicion4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento3_posicion4.ForeColor = Color.White;
            lblLetra_intento3_posicion4.Location = new Point(155, 190);
            lblLetra_intento3_posicion4.Name = "lblLetra_intento3_posicion4";
            lblLetra_intento3_posicion4.Size = new Size(40, 40);
            lblLetra_intento3_posicion4.TabIndex = 65;
            lblLetra_intento3_posicion4.Text = "V";
            lblLetra_intento3_posicion4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento3_posicion3
            // 
            lblLetra_intento3_posicion3.BackColor = Color.White;
            lblLetra_intento3_posicion3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento3_posicion3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento3_posicion3.ForeColor = Color.White;
            lblLetra_intento3_posicion3.Location = new Point(110, 190);
            lblLetra_intento3_posicion3.Name = "lblLetra_intento3_posicion3";
            lblLetra_intento3_posicion3.Size = new Size(40, 40);
            lblLetra_intento3_posicion3.TabIndex = 64;
            lblLetra_intento3_posicion3.Text = "V";
            lblLetra_intento3_posicion3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento3_posicion2
            // 
            lblLetra_intento3_posicion2.BackColor = Color.White;
            lblLetra_intento3_posicion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento3_posicion2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento3_posicion2.ForeColor = Color.White;
            lblLetra_intento3_posicion2.Location = new Point(65, 190);
            lblLetra_intento3_posicion2.Name = "lblLetra_intento3_posicion2";
            lblLetra_intento3_posicion2.Size = new Size(40, 40);
            lblLetra_intento3_posicion2.TabIndex = 63;
            lblLetra_intento3_posicion2.Text = "V";
            lblLetra_intento3_posicion2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento3_posicion1
            // 
            lblLetra_intento3_posicion1.BackColor = Color.White;
            lblLetra_intento3_posicion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento3_posicion1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento3_posicion1.ForeColor = Color.White;
            lblLetra_intento3_posicion1.Location = new Point(20, 190);
            lblLetra_intento3_posicion1.Name = "lblLetra_intento3_posicion1";
            lblLetra_intento3_posicion1.Size = new Size(40, 40);
            lblLetra_intento3_posicion1.TabIndex = 62;
            lblLetra_intento3_posicion1.Text = "V";
            lblLetra_intento3_posicion1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento6_posicion5
            // 
            lblLetra_intento6_posicion5.BackColor = Color.White;
            lblLetra_intento6_posicion5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento6_posicion5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento6_posicion5.ForeColor = Color.White;
            lblLetra_intento6_posicion5.Location = new Point(200, 325);
            lblLetra_intento6_posicion5.Name = "lblLetra_intento6_posicion5";
            lblLetra_intento6_posicion5.Size = new Size(40, 40);
            lblLetra_intento6_posicion5.TabIndex = 81;
            lblLetra_intento6_posicion5.Text = "V";
            lblLetra_intento6_posicion5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento6_posicion4
            // 
            lblLetra_intento6_posicion4.BackColor = Color.White;
            lblLetra_intento6_posicion4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento6_posicion4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento6_posicion4.ForeColor = Color.White;
            lblLetra_intento6_posicion4.Location = new Point(155, 325);
            lblLetra_intento6_posicion4.Name = "lblLetra_intento6_posicion4";
            lblLetra_intento6_posicion4.Size = new Size(40, 40);
            lblLetra_intento6_posicion4.TabIndex = 80;
            lblLetra_intento6_posicion4.Text = "V";
            lblLetra_intento6_posicion4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento6_posicion3
            // 
            lblLetra_intento6_posicion3.BackColor = Color.White;
            lblLetra_intento6_posicion3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento6_posicion3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento6_posicion3.ForeColor = Color.White;
            lblLetra_intento6_posicion3.Location = new Point(110, 325);
            lblLetra_intento6_posicion3.Name = "lblLetra_intento6_posicion3";
            lblLetra_intento6_posicion3.Size = new Size(40, 40);
            lblLetra_intento6_posicion3.TabIndex = 79;
            lblLetra_intento6_posicion3.Text = "V";
            lblLetra_intento6_posicion3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento6_posicion2
            // 
            lblLetra_intento6_posicion2.BackColor = Color.White;
            lblLetra_intento6_posicion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento6_posicion2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento6_posicion2.ForeColor = Color.White;
            lblLetra_intento6_posicion2.Location = new Point(65, 325);
            lblLetra_intento6_posicion2.Name = "lblLetra_intento6_posicion2";
            lblLetra_intento6_posicion2.Size = new Size(40, 40);
            lblLetra_intento6_posicion2.TabIndex = 78;
            lblLetra_intento6_posicion2.Text = "V";
            lblLetra_intento6_posicion2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento6_posicion1
            // 
            lblLetra_intento6_posicion1.BackColor = Color.White;
            lblLetra_intento6_posicion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento6_posicion1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento6_posicion1.ForeColor = Color.White;
            lblLetra_intento6_posicion1.Location = new Point(20, 325);
            lblLetra_intento6_posicion1.Name = "lblLetra_intento6_posicion1";
            lblLetra_intento6_posicion1.Size = new Size(40, 40);
            lblLetra_intento6_posicion1.TabIndex = 77;
            lblLetra_intento6_posicion1.Text = "V";
            lblLetra_intento6_posicion1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento5_posicion5
            // 
            lblLetra_intento5_posicion5.BackColor = Color.White;
            lblLetra_intento5_posicion5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento5_posicion5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento5_posicion5.ForeColor = Color.White;
            lblLetra_intento5_posicion5.Location = new Point(200, 280);
            lblLetra_intento5_posicion5.Name = "lblLetra_intento5_posicion5";
            lblLetra_intento5_posicion5.Size = new Size(40, 40);
            lblLetra_intento5_posicion5.TabIndex = 76;
            lblLetra_intento5_posicion5.Text = "V";
            lblLetra_intento5_posicion5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento5_posicion4
            // 
            lblLetra_intento5_posicion4.BackColor = Color.White;
            lblLetra_intento5_posicion4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento5_posicion4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento5_posicion4.ForeColor = Color.White;
            lblLetra_intento5_posicion4.Location = new Point(155, 280);
            lblLetra_intento5_posicion4.Name = "lblLetra_intento5_posicion4";
            lblLetra_intento5_posicion4.Size = new Size(40, 40);
            lblLetra_intento5_posicion4.TabIndex = 75;
            lblLetra_intento5_posicion4.Text = "V";
            lblLetra_intento5_posicion4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento5_posicion3
            // 
            lblLetra_intento5_posicion3.BackColor = Color.White;
            lblLetra_intento5_posicion3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento5_posicion3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento5_posicion3.ForeColor = Color.White;
            lblLetra_intento5_posicion3.Location = new Point(110, 280);
            lblLetra_intento5_posicion3.Name = "lblLetra_intento5_posicion3";
            lblLetra_intento5_posicion3.Size = new Size(40, 40);
            lblLetra_intento5_posicion3.TabIndex = 74;
            lblLetra_intento5_posicion3.Text = "V";
            lblLetra_intento5_posicion3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento5_posicion2
            // 
            lblLetra_intento5_posicion2.BackColor = Color.White;
            lblLetra_intento5_posicion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento5_posicion2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento5_posicion2.ForeColor = Color.White;
            lblLetra_intento5_posicion2.Location = new Point(65, 280);
            lblLetra_intento5_posicion2.Name = "lblLetra_intento5_posicion2";
            lblLetra_intento5_posicion2.Size = new Size(40, 40);
            lblLetra_intento5_posicion2.TabIndex = 73;
            lblLetra_intento5_posicion2.Text = "V";
            lblLetra_intento5_posicion2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLetra_intento5_posicion1
            // 
            lblLetra_intento5_posicion1.BackColor = Color.White;
            lblLetra_intento5_posicion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblLetra_intento5_posicion1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold);
            lblLetra_intento5_posicion1.ForeColor = Color.White;
            lblLetra_intento5_posicion1.Location = new Point(20, 280);
            lblLetra_intento5_posicion1.Name = "lblLetra_intento5_posicion1";
            lblLetra_intento5_posicion1.Size = new Size(40, 40);
            lblLetra_intento5_posicion1.TabIndex = 72;
            lblLetra_intento5_posicion1.Text = "V";
            lblLetra_intento5_posicion1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(434, 391);
            Controls.Add(lblLetra_intento6_posicion5);
            Controls.Add(lblLetra_intento6_posicion4);
            Controls.Add(lblLetra_intento6_posicion3);
            Controls.Add(lblLetra_intento6_posicion2);
            Controls.Add(lblLetra_intento6_posicion1);
            Controls.Add(lblLetra_intento5_posicion5);
            Controls.Add(lblLetra_intento5_posicion4);
            Controls.Add(lblLetra_intento5_posicion3);
            Controls.Add(lblLetra_intento5_posicion2);
            Controls.Add(lblLetra_intento5_posicion1);
            Controls.Add(lblLetra_intento4_posicion5);
            Controls.Add(lblLetra_intento4_posicion4);
            Controls.Add(lblLetra_intento4_posicion3);
            Controls.Add(lblLetra_intento4_posicion2);
            Controls.Add(lblLetra_intento4_posicion1);
            Controls.Add(lblLetra_intento3_posicion5);
            Controls.Add(lblLetra_intento3_posicion4);
            Controls.Add(lblLetra_intento3_posicion3);
            Controls.Add(lblLetra_intento3_posicion2);
            Controls.Add(lblLetra_intento3_posicion1);
            Controls.Add(lblLetra_intento2_posicion5);
            Controls.Add(lblLetra_intento2_posicion4);
            Controls.Add(lblLetra_intento2_posicion3);
            Controls.Add(lblLetra_intento2_posicion2);
            Controls.Add(lblLetra_intento2_posicion1);
            Controls.Add(lblLetra_intento1_posicion5);
            Controls.Add(lblLetra_intento1_posicion4);
            Controls.Add(lblLetra_intento1_posicion3);
            Controls.Add(lblLetra_intento1_posicion2);
            Controls.Add(lblLetra_intento1_posicion1);
            Controls.Add(lblColorFallido);
            Controls.Add(lblColorDesubicado);
            Controls.Add(lblColorCorrecto);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(btnEvaluaPalabra);
            Controls.Add(txtPalabraIngresada);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Wordle Simplificado";
            Load += new System.EventHandler(Form1_Load);
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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