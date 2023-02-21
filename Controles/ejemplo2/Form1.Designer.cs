namespace ejemplo2
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cbVerga = new System.Windows.Forms.CheckBox();
            this.rbMacho = new System.Windows.Forms.RadioButton();
            this.rbHembra = new System.Windows.Forms.RadioButton();
            this.rbX = new System.Windows.Forms.RadioButton();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.gbxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(208, 347);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 20);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(86, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lwElementos
            // 
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(35, 295);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(167, 72);
            this.lwElementos.TabIndex = 3;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.List;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(32, 77);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(116, 71);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(211, 20);
            this.dtpFechaNac.TabIndex = 7;
            // 
            // cbVerga
            // 
            this.cbVerga.AutoSize = true;
            this.cbVerga.Location = new System.Drawing.Point(116, 107);
            this.cbVerga.Name = "cbVerga";
            this.cbVerga.Size = new System.Drawing.Size(121, 17);
            this.cbVerga.TabIndex = 8;
            this.cbVerga.Text = "¿Te gusta la verga?";
            this.cbVerga.UseVisualStyleBackColor = true;
            // 
            // rbMacho
            // 
            this.rbMacho.AutoSize = true;
            this.rbMacho.Checked = true;
            this.rbMacho.Location = new System.Drawing.Point(35, 19);
            this.rbMacho.Name = "rbMacho";
            this.rbMacho.Size = new System.Drawing.Size(58, 17);
            this.rbMacho.TabIndex = 9;
            this.rbMacho.TabStop = true;
            this.rbMacho.Text = "Macho";
            this.rbMacho.UseVisualStyleBackColor = true;
            // 
            // rbHembra
            // 
            this.rbHembra.AutoSize = true;
            this.rbHembra.Location = new System.Drawing.Point(140, 19);
            this.rbHembra.Name = "rbHembra";
            this.rbHembra.Size = new System.Drawing.Size(62, 17);
            this.rbHembra.TabIndex = 10;
            this.rbHembra.Text = "Hembra";
            this.rbHembra.UseVisualStyleBackColor = true;
            // 
            // rbX
            // 
            this.rbX.AutoSize = true;
            this.rbX.Location = new System.Drawing.Point(260, 18);
            this.rbX.Name = "rbX";
            this.rbX.Size = new System.Drawing.Size(32, 17);
            this.rbX.TabIndex = 11;
            this.rbX.Text = "X";
            this.rbX.UseVisualStyleBackColor = true;
            // 
            // gbxTipo
            // 
            this.gbxTipo.Controls.Add(this.rbHembra);
            this.gbxTipo.Controls.Add(this.rbX);
            this.gbxTipo.Controls.Add(this.rbMacho);
            this.gbxTipo.Location = new System.Drawing.Point(35, 150);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(301, 47);
            this.gbxTipo.TabIndex = 12;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "Tipo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rojo",
            "Verde ",
            "Amariyou",
            "Negro"});
            this.comboBox1.Location = new System.Drawing.Point(188, 216);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(188, 243);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(148, 20);
            this.numericUpDown1.TabIndex = 14;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Location = new System.Drawing.Point(35, 258);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(75, 20);
            this.btnPerfil.TabIndex = 15;
            this.btnPerfil.Text = "Ver &Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 412);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gbxTipo);
            this.Controls.Add(this.cbVerga);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.CheckBox cbVerga;
        private System.Windows.Forms.RadioButton rbMacho;
        private System.Windows.Forms.RadioButton rbHembra;
        private System.Windows.Forms.RadioButton rbX;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnPerfil;
    }
}

