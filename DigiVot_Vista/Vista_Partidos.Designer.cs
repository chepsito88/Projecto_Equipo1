namespace DigiVot_Vista
{
    partial class Vista_Partidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPartido = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnImagen = new Guna.UI2.WinForms.Guna2Button();
            this.pbxPartido = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.grpOperaciones = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.grpListaCandidatos = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtgPartidos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlPartido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPartido)).BeginInit();
            this.grpOperaciones.SuspendLayout();
            this.grpListaCandidatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartidos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPartido
            // 
            this.pnlPartido.Controls.Add(this.btnImagen);
            this.pnlPartido.Controls.Add(this.pbxPartido);
            this.pnlPartido.Controls.Add(this.lblNombre);
            this.pnlPartido.Controls.Add(this.txtNombre);
            this.pnlPartido.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.pnlPartido.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.pnlPartido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPartido.ForeColor = System.Drawing.Color.White;
            this.pnlPartido.Location = new System.Drawing.Point(70, 15);
            this.pnlPartido.Name = "pnlPartido";
            this.pnlPartido.ShadowDecoration.Parent = this.pnlPartido;
            this.pnlPartido.Size = new System.Drawing.Size(515, 220);
            this.pnlPartido.TabIndex = 14;
            this.pnlPartido.Text = "Datos del  Partido";
            this.pnlPartido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnImagen
            // 
            this.btnImagen.BackColor = System.Drawing.Color.Transparent;
            this.btnImagen.BorderRadius = 22;
            this.btnImagen.CheckedState.Parent = this.btnImagen;
            this.btnImagen.CustomImages.Parent = this.btnImagen;
            this.btnImagen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnImagen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen.ForeColor = System.Drawing.Color.White;
            this.btnImagen.HoverState.Parent = this.btnImagen;
            this.btnImagen.Location = new System.Drawing.Point(97, 130);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.ShadowDecoration.Parent = this.btnImagen;
            this.btnImagen.Size = new System.Drawing.Size(113, 40);
            this.btnImagen.TabIndex = 22;
            this.btnImagen.Text = "Agregar Foto";
            this.btnImagen.UseTransparentBackground = true;
            // 
            // pbxPartido
            // 
            this.pbxPartido.Location = new System.Drawing.Point(261, 97);
            this.pbxPartido.Name = "pbxPartido";
            this.pbxPartido.Size = new System.Drawing.Size(142, 107);
            this.pbxPartido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPartido.TabIndex = 23;
            this.pbxPartido.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.lblNombre.Location = new System.Drawing.Point(94, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(127, 18);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre Partido:";
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
            this.txtNombre.Location = new System.Drawing.Point(257, 49);
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
            this.grpOperaciones.TabIndex = 31;
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
            this.grpListaCandidatos.Controls.Add(this.dtgPartidos);
            this.grpListaCandidatos.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.grpListaCandidatos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.grpListaCandidatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpListaCandidatos.ForeColor = System.Drawing.Color.White;
            this.grpListaCandidatos.Location = new System.Drawing.Point(249, 274);
            this.grpListaCandidatos.Name = "grpListaCandidatos";
            this.grpListaCandidatos.ShadowDecoration.Parent = this.grpListaCandidatos;
            this.grpListaCandidatos.Size = new System.Drawing.Size(336, 327);
            this.grpListaCandidatos.TabIndex = 30;
            this.grpListaCandidatos.Text = "Listado de Candidatos";
            this.grpListaCandidatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtgPartidos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgPartidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPartidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPartidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtgPartidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgPartidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgPartidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPartidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPartidos.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPartidos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgPartidos.EnableHeadersVisualStyles = false;
            this.dtgPartidos.GridColor = System.Drawing.Color.White;
            this.dtgPartidos.Location = new System.Drawing.Point(15, 51);
            this.dtgPartidos.MultiSelect = false;
            this.dtgPartidos.Name = "dtgPartidos";
            this.dtgPartidos.RowHeadersVisible = false;
            this.dtgPartidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPartidos.Size = new System.Drawing.Size(308, 262);
            this.dtgPartidos.TabIndex = 30;
            this.dtgPartidos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgPartidos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgPartidos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgPartidos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgPartidos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgPartidos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgPartidos.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtgPartidos.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dtgPartidos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.dtgPartidos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgPartidos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgPartidos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgPartidos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgPartidos.ThemeStyle.HeaderStyle.Height = 30;
            this.dtgPartidos.ThemeStyle.ReadOnly = false;
            this.dtgPartidos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.dtgPartidos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgPartidos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.dtgPartidos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgPartidos.ThemeStyle.RowsStyle.Height = 22;
            this.dtgPartidos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgPartidos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Vista_Partidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 618);
            this.Controls.Add(this.grpOperaciones);
            this.Controls.Add(this.grpListaCandidatos);
            this.Controls.Add(this.pnlPartido);
            this.Name = "Vista_Partidos";
            this.Text = "DigiVot:  Partidos";
            this.pnlPartido.ResumeLayout(false);
            this.pnlPartido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPartido)).EndInit();
            this.grpOperaciones.ResumeLayout(false);
            this.grpListaCandidatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPartidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2GroupBox pnlPartido;
        public Guna.UI2.WinForms.Guna2Button btnImagen;
        public System.Windows.Forms.PictureBox pbxPartido;
        public System.Windows.Forms.Label lblNombre;
        public Guna.UI2.WinForms.Guna2TextBox txtNombre;
        public Guna.UI2.WinForms.Guna2GroupBox grpOperaciones;
        public Guna.UI2.WinForms.Guna2Button btnLimpiar;
        public Guna.UI2.WinForms.Guna2Button btnEliminar;
        public Guna.UI2.WinForms.Guna2Button btnEditar;
        public Guna.UI2.WinForms.Guna2Button btnGuardar;
        public Guna.UI2.WinForms.Guna2GroupBox grpListaCandidatos;
        public Guna.UI2.WinForms.Guna2DataGridView dtgPartidos;
    }
}