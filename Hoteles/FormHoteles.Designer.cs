namespace Hoteles
{
    partial class FormHoteles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoteles));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCiudades = new System.Windows.Forms.Label();
            this.comboBoxCiudades = new System.Windows.Forms.ComboBox();
            this.bindingSourceCiudades = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewHoteles = new System.Windows.Forms.DataGridView();
            this.idciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadenasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceHoteles = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCiudades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoteles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNuevo,
            this.toolStripMenuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemNuevo
            // 
            this.toolStripMenuItemNuevo.Image = global::Hoteles.Properties.Resources.nuevo;
            this.toolStripMenuItemNuevo.Name = "toolStripMenuItemNuevo";
            this.toolStripMenuItemNuevo.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItemNuevo.Click += new System.EventHandler(this.toolStripMenuItemNuevo_Click);
            // 
            // toolStripMenuSalir
            // 
            this.toolStripMenuSalir.Image = global::Hoteles.Properties.Resources.exit;
            this.toolStripMenuSalir.Name = "toolStripMenuSalir";
            this.toolStripMenuSalir.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuSalir.ToolTipText = "asdasd";
            this.toolStripMenuSalir.Click += new System.EventHandler(this.toolStripMenuSalir_Click);
            // 
            // labelCiudades
            // 
            this.labelCiudades.AutoSize = true;
            this.labelCiudades.Location = new System.Drawing.Point(12, 39);
            this.labelCiudades.Name = "labelCiudades";
            this.labelCiudades.Size = new System.Drawing.Size(51, 13);
            this.labelCiudades.TabIndex = 1;
            this.labelCiudades.Text = "Ciudades";
            // 
            // comboBoxCiudades
            // 
            this.comboBoxCiudades.DataSource = this.bindingSourceCiudades;
            this.comboBoxCiudades.DisplayMember = "nombre";
            this.comboBoxCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCiudades.FormattingEnabled = true;
            this.comboBoxCiudades.Location = new System.Drawing.Point(83, 36);
            this.comboBoxCiudades.Name = "comboBoxCiudades";
            this.comboBoxCiudades.Size = new System.Drawing.Size(264, 21);
            this.comboBoxCiudades.TabIndex = 2;
            this.comboBoxCiudades.ValueMember = "id_ciudad";
            this.comboBoxCiudades.SelectedIndexChanged += new System.EventHandler(this.comboBoxCiudades_SelectedIndexChanged);
            // 
            // bindingSourceCiudades
            // 
            this.bindingSourceCiudades.DataSource = typeof(ciudades);
            // 
            // dataGridViewHoteles
            // 
            this.dataGridViewHoteles.AllowUserToAddRows = false;
            this.dataGridViewHoteles.AllowUserToResizeColumns = false;
            this.dataGridViewHoteles.AllowUserToResizeRows = false;
            this.dataGridViewHoteles.AutoGenerateColumns = false;
            this.dataGridViewHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoteles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idciudadDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.cifDataGridViewTextBoxColumn,
            this.cadenasDataGridViewTextBoxColumn,
            this.ciudadesDataGridViewTextBoxColumn});
            this.dataGridViewHoteles.DataSource = this.bindingSourceHoteles;
            this.dataGridViewHoteles.Location = new System.Drawing.Point(15, 67);
            this.dataGridViewHoteles.MultiSelect = false;
            this.dataGridViewHoteles.Name = "dataGridViewHoteles";
            this.dataGridViewHoteles.ReadOnly = true;
            this.dataGridViewHoteles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHoteles.Size = new System.Drawing.Size(865, 371);
            this.dataGridViewHoteles.TabIndex = 3;
            this.dataGridViewHoteles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHoteles_DoubleClick);
            this.dataGridViewHoteles.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewHoteles_UserDeletingRow);
            // 
            // idciudadDataGridViewTextBoxColumn
            // 
            this.idciudadDataGridViewTextBoxColumn.DataPropertyName = "id_ciudad";
            this.idciudadDataGridViewTextBoxColumn.HeaderText = "id_ciudad";
            this.idciudadDataGridViewTextBoxColumn.Name = "idciudadDataGridViewTextBoxColumn";
            this.idciudadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cifDataGridViewTextBoxColumn
            // 
            this.cifDataGridViewTextBoxColumn.DataPropertyName = "cif";
            this.cifDataGridViewTextBoxColumn.HeaderText = "cif";
            this.cifDataGridViewTextBoxColumn.Name = "cifDataGridViewTextBoxColumn";
            this.cifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cadenasDataGridViewTextBoxColumn
            // 
            this.cadenasDataGridViewTextBoxColumn.DataPropertyName = "cadenas";
            this.cadenasDataGridViewTextBoxColumn.HeaderText = "cadenas";
            this.cadenasDataGridViewTextBoxColumn.Name = "cadenasDataGridViewTextBoxColumn";
            this.cadenasDataGridViewTextBoxColumn.ReadOnly = true;
            this.cadenasDataGridViewTextBoxColumn.Visible = false;
            // 
            // ciudadesDataGridViewTextBoxColumn
            // 
            this.ciudadesDataGridViewTextBoxColumn.DataPropertyName = "ciudades";
            this.ciudadesDataGridViewTextBoxColumn.HeaderText = "ciudades";
            this.ciudadesDataGridViewTextBoxColumn.Name = "ciudadesDataGridViewTextBoxColumn";
            this.ciudadesDataGridViewTextBoxColumn.ReadOnly = true;
            this.ciudadesDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSourceHoteles
            // 
            this.bindingSourceHoteles.DataSource = typeof(hoteles);
            // 
            // FormHoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.dataGridViewHoteles);
            this.Controls.Add(this.comboBoxCiudades);
            this.Controls.Add(this.labelCiudades);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHoteles";
            this.Text = "Hoteles";
            this.Load += new System.EventHandler(this.FormHoteles_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCiudades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoteles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoteles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNuevo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSalir;
        private System.Windows.Forms.Label labelCiudades;
        private System.Windows.Forms.ComboBox comboBoxCiudades;
        private System.Windows.Forms.DataGridView dataGridViewHoteles;
        private System.Windows.Forms.BindingSource bindingSourceCiudades;
        private System.Windows.Forms.BindingSource bindingSourceHoteles;
        private System.Windows.Forms.DataGridViewTextBoxColumn idciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadenasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadesDataGridViewTextBoxColumn;
    }
}