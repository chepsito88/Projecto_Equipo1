namespace DigiVot_Vista
{
    partial class Vista_Tipo_Elecciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlElecciones = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.grpOperaciones = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.grpListaCandidatos = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtgEleciones = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlElecciones.SuspendLayout();
            this.grpOperaciones.SuspendLayout();
            this.grpListaCandidatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEleciones)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlElecciones
            // 
            this.pnlElecciones.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.pnlElecciones.BorderRadius = 5;
            this.pnlElecciones.BorderThickness = 2;
            this.pnlElecciones.Controls.Add(this.lblDescripcion);
            this.pnlElecciones.Controls.Add(this.lblNombre);
            this.pnlElecciones.Controls.Add(this.txtDescripcion);
            this.pnlElecciones.Controls.Add(this.txtNombre);
            this.pnlElecciones.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.pnlElecciones.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.pnlElecciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlElecciones.ForeColor = System.Drawing.Color.White;
            this.pnlElecciones.Location = new System.Drawing.Point(70, 15);
            this.pnlElecciones.Name = "pnlElecciones";
            this.pnlElecciones.ShadowDecoration.Parent = this.pnlElecciones;
            this.pnlElecciones.Size = new System.Drawing.Size(515, 220);
            this.pnlElecciones.TabIndex = 21;
            this.pnlElecciones.Text = "Datos de la Elección";
            this.pnlElecciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.lblDescripcion.Location = new System.Drawing.Point(127, 131);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(101, 18);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.lblNombre.Location = new System.Drawing.Point(87, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(141, 18);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre Elección:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.DefaultText = "";
            this.txtDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.DisabledState.Parent = this.txtDescripcion;
            this.txtDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.FocusedState.Parent = this.txtDescripcion;
            this.txtDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.HoverState.Parent = this.txtDescripcion;
            this.txtDescripcion.Location = new System.Drawing.Point(250, 125);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(9);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.PlaceholderText = "Descripcion";
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.ShadowDecoration.Parent = this.txtDescripcion;
            this.txtDescripcion.Size = new System.Drawing.Size(150, 31);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.Parent = this.txtNombre;
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedState.Parent = this.txtNombre;
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.HoverState.Parent = this.txtNombre;
            this.txtNombre.Location = new System.Drawing.Point(250, 73);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(150, 31);
            this.txtNombre.TabIndex = 3;
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.grpOperaciones.BorderRadius = 5;
            this.grpOperaciones.BorderThickness = 2;
            this.grpOperaciones.Controls.Add(this.btnLimpiar);
            this.grpOperaciones.Controls.Add(this.btnEliminar);
            this.grpOperaciones.Controls.Add(this.btnEditar);
            this.grpOperaciones.Controls.Add(this.btnGuardar);
            this.grpOperaciones.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.grpOperaciones.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.grpOperaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOperaciones.ForeColor = System.Drawing.Color.White;
            this.grpOperaciones.Location = new System.Drawing.Point(70, 274);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.ShadowDecoration.Parent = this.grpOperaciones;
            this.grpOperaciones.Size = new System.Drawing.Size(159, 329);
            this.grpOperaciones.TabIndex = 33;
            this.grpOperaciones.Text = "Operaciones";
            this.grpOperaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BorderRadius = 22;
            this.btnLimpiar.CheckedState.Parent = this.btnLimpiar;
            this.btnLimpiar.CustomImages.Parent = this.btnLimpiar;
            this.btnLimpiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.HoverState.Parent = this.btnLimpiar;
            this.btnLimpiar.Location = new System.Drawing.Point(32, 270);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.ShadowDecoration.Parent = this.btnLimpiar;
            this.btnLimpiar.Size = new System.Drawing.Size(88, 40);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BorderRadius = 22;
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.CustomImages.Parent = this.btnEliminar;
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.Location = new System.Drawing.Point(31, 201);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(88, 40);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BorderRadius = 22;
            this.btnEditar.CheckedState.Parent = this.btnEditar;
            this.btnEditar.CustomImages.Parent = this.btnEditar;
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.HoverState.Parent = this.btnEditar;
            this.btnEditar.Location = new System.Drawing.Point(28, 133);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ShadowDecoration.Parent = this.btnEditar;
            this.btnEditar.Size = new System.Drawing.Size(88, 40);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Modificar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BorderRadius = 22;
            this.btnGuardar.CheckedState.Parent = this.btnGuardar;
            this.btnGuardar.CustomImages.Parent = this.btnGuardar;
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.Parent = this.btnGuardar;
            this.btnGuardar.Location = new System.Drawing.Point(26, 68);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(88, 40);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            // 
            // grpListaCandidatos
            // 
            this.grpListaCandidatos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.grpListaCandidatos.BorderRadius = 5;
            this.grpListaCandidatos.BorderThickness = 2;
            this.grpListaCandidatos.Controls.Add(this.dtgEleciones);
            this.grpListaCandidatos.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.grpListaCandidatos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.grpListaCandidatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpListaCandidatos.ForeColor = System.Drawing.Color.White;
            this.grpListaCandidatos.Location = new System.Drawing.Point(249, 274);
            this.grpListaCandidatos.Name = "grpListaCandidatos";
            this.grpListaCandidatos.ShadowDecoration.Parent = this.grpListaCandidatos;
            this.grpListaCandidatos.Size = new System.Drawing.Size(336, 327);
            this.grpListaCandidatos.TabIndex = 32;
            this.grpListaCandidatos.Text = "Listado de tipos Elecciones";
            this.grpListaCandidatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtgEleciones
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgEleciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgEleciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEleciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtgEleciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgEleciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgEleciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEleciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgEleciones.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgEleciones.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgEleciones.EnableHeadersVisualStyles = false;
            this.dtgEleciones.GridColor = System.Drawing.Color.White;
            this.dtgEleciones.Location = new System.Drawing.Point(15, 51);
            this.dtgEleciones.MultiSelect = false;
            this.dtgEleciones.Name = "dtgEleciones";
            this.dtgEleciones.RowHeadersVisible = false;
            this.dtgEleciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEleciones.Size = new System.Drawing.Size(308, 262);
            this.dtgEleciones.TabIndex = 30;
            this.dtgEleciones.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgEleciones.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgEleciones.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgEleciones.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgEleciones.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgEleciones.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgEleciones.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtgEleciones.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dtgEleciones.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.dtgEleciones.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgEleciones.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgEleciones.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgEleciones.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgEleciones.ThemeStyle.HeaderStyle.Height = 30;
            this.dtgEleciones.ThemeStyle.ReadOnly = false;
            this.dtgEleciones.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.dtgEleciones.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgEleciones.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgEleciones.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgEleciones.ThemeStyle.RowsStyle.Height = 22;
            this.dtgEleciones.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgEleciones.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Vista_Tipo_Elecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(655, 618);
            this.Controls.Add(this.grpOperaciones);
            this.Controls.Add(this.grpListaCandidatos);
            this.Controls.Add(this.pnlElecciones);
            this.Name = "Vista_Tipo_Elecciones";
            this.Text = "DigiVot: Tipo Elecciones";
            this.pnlElecciones.ResumeLayout(false);
            this.pnlElecciones.PerformLayout();
            this.grpOperaciones.ResumeLayout(false);
            this.grpListaCandidatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEleciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2GroupBox pnlElecciones;
        public System.Windows.Forms.Label lblNombre;
        public Guna.UI2.WinForms.Guna2TextBox txtNombre;
        public System.Windows.Forms.Label lblDescripcion;
        public Guna.UI2.WinForms.Guna2TextBox txtDescripcion;
        public Guna.UI2.WinForms.Guna2GroupBox grpOperaciones;
        public Guna.UI2.WinForms.Guna2Button btnLimpiar;
        public Guna.UI2.WinForms.Guna2Button btnEliminar;
        public Guna.UI2.WinForms.Guna2Button btnEditar;
        public Guna.UI2.WinForms.Guna2Button btnGuardar;
        public Guna.UI2.WinForms.Guna2GroupBox grpListaCandidatos;
        public Guna.UI2.WinForms.Guna2DataGridView dtgEleciones;
    }
}