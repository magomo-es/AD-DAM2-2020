namespace Hoteles
{
    partial class FormHotel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHotel));
            this.labelCiudad = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelCadena = new System.Windows.Forms.Label();
            this.comboBoxCiudades = new System.Windows.Forms.ComboBox();
            this.bindingSourceCiudades = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxCadena = new System.Windows.Forms.ComboBox();
            this.bindingSourceCadenas = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCiudades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadenas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Location = new System.Drawing.Point(21, 25);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(40, 13);
            this.labelCiudad.TabIndex = 0;
            this.labelCiudad.Text = "Ciudad";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(21, 60);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(21, 94);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(54, 13);
            this.labelCategoria.TabIndex = 2;
            this.labelCategoria.Text = "Categoría";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(21, 131);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(52, 13);
            this.labelDireccion.TabIndex = 3;
            this.labelDireccion.Text = "Dirección";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(21, 165);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 4;
            this.labelTelefono.Text = "Teléfono";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(21, 201);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(28, 13);
            this.labelTipo.TabIndex = 5;
            this.labelTipo.Text = "Tipo";
            // 
            // labelCadena
            // 
            this.labelCadena.AutoSize = true;
            this.labelCadena.Location = new System.Drawing.Point(21, 238);
            this.labelCadena.Name = "labelCadena";
            this.labelCadena.Size = new System.Drawing.Size(44, 13);
            this.labelCadena.TabIndex = 6;
            this.labelCadena.Text = "Cadena";
            // 
            // comboBoxCiudades
            // 
            this.comboBoxCiudades.DataSource = this.bindingSourceCiudades;
            this.comboBoxCiudades.DisplayMember = "nombre";
            this.comboBoxCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCiudades.FormattingEnabled = true;
            this.comboBoxCiudades.Location = new System.Drawing.Point(100, 22);
            this.comboBoxCiudades.Name = "comboBoxCiudades";
            this.comboBoxCiudades.Size = new System.Drawing.Size(302, 21);
            this.comboBoxCiudades.TabIndex = 7;
            this.comboBoxCiudades.ValueMember = "id_ciudad";
            // 
            // bindingSourceCiudades
            // 
            this.bindingSourceCiudades.DataSource = typeof(ciudades);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(100, 57);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(302, 20);
            this.textBoxNombre.TabIndex = 8;
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(100, 91);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(302, 20);
            this.textBoxCategoria.TabIndex = 9;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(100, 128);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(302, 20);
            this.textBoxDireccion.TabIndex = 10;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(100, 162);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(302, 20);
            this.textBoxTelefono.TabIndex = 11;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DisplayMember = "nombre";
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "PLAYA",
            "MONTAÑA"});
            this.comboBoxTipo.Location = new System.Drawing.Point(100, 198);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(302, 21);
            this.comboBoxTipo.TabIndex = 12;
            this.comboBoxTipo.ValueMember = "id_ciudad";
            // 
            // comboBoxCadena
            // 
            this.comboBoxCadena.DataSource = this.bindingSourceCadenas;
            this.comboBoxCadena.DisplayMember = "nombre";
            this.comboBoxCadena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCadena.FormattingEnabled = true;
            this.comboBoxCadena.Location = new System.Drawing.Point(100, 235);
            this.comboBoxCadena.Name = "comboBoxCadena";
            this.comboBoxCadena.Size = new System.Drawing.Size(302, 21);
            this.comboBoxCadena.TabIndex = 13;
            this.comboBoxCadena.ValueMember = "cif";
            // 
            // bindingSourceCadenas
            // 
            this.bindingSourceCadenas.DataSource = typeof(cadenas);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(24, 287);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 14;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(119, 287);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 347);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.comboBoxCadena);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.comboBoxCiudades);
            this.Controls.Add(this.labelCadena);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCiudad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHotel";
            this.Text = "FormHotel";
            this.Load += new System.EventHandler(this.FormHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCiudades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadenas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelCadena;
        private System.Windows.Forms.ComboBox comboBoxCiudades;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxCadena;
        private System.Windows.Forms.BindingSource bindingSourceCiudades;
        private System.Windows.Forms.BindingSource bindingSourceCadenas;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}