namespace DigiVot_Vista
{
    partial class Vista_Reglas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtReglas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnLimpiar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtRegla = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRegla = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtReglas)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtReglas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtReglas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtReglas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtReglas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtReglas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtReglas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtReglas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtReglas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtReglas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtReglas.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtReglas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtReglas.EnableHeadersVisualStyles = false;
            this.dtReglas.GridColor = System.Drawing.Color.White;
            this.dtReglas.Location = new System.Drawing.Point(61, 363);
            this.dtReglas.MultiSelect = false;
            this.dtReglas.Name = "dtReglas";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtReglas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtReglas.RowHeadersVisible = false;
            this.dtReglas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtReglas.Size = new System.Drawing.Size(532, 232);
            this.dtReglas.TabIndex = 14;
            this.dtReglas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtReglas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtReglas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtReglas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtReglas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtReglas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtReglas.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtReglas.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dtReglas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.dtReglas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtReglas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtReglas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtReglas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtReglas.ThemeStyle.HeaderStyle.Height = 30;
            this.dtReglas.ThemeStyle.ReadOnly = false;
            this.dtReglas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.dtReglas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtReglas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtReglas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtReglas.ThemeStyle.RowsStyle.Height = 22;
            this.dtReglas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtReglas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.btnLimpiar);
            this.guna2GroupBox2.Controls.Add(this.btnEliminar);
            this.guna2GroupBox2.Controls.Add(this.btnEditar);
            this.guna2GroupBox2.Controls.Add(this.btnGuardar);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.guna2GroupBox2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(12, 186);
            this.guna2GroupBox2.MaximumSize = new System.Drawing.Size(1011, 135);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(631, 135);
            this.guna2GroupBox2.TabIndex = 13;
            this.guna2GroupBox2.Text = "Seleccione la opción que desee realizar";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnLimpiar.Location = new System.Drawing.Point(506, 66);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.ShadowDecoration.Parent = this.btnLimpiar;
            this.btnLimpiar.Size = new System.Drawing.Size(92, 40);
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
            this.btnEliminar.Location = new System.Drawing.Point(345, 66);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(92, 40);
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
            this.btnEditar.Location = new System.Drawing.Point(182, 66);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ShadowDecoration.Parent = this.btnEditar;
            this.btnEditar.Size = new System.Drawing.Size(92, 40);
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
            this.btnGuardar.Location = new System.Drawing.Point(22, 66);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(92, 40);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.txtDescripcion);
            this.guna2GroupBox1.Controls.Add(this.lblDescripcion);
            this.guna2GroupBox1.Controls.Add(this.txtRegla);
            this.guna2GroupBox1.Controls.Add(this.lblRegla);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 24);
            this.guna2GroupBox1.MaximumSize = new System.Drawing.Size(1011, 135);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(631, 135);
            this.guna2GroupBox1.TabIndex = 12;
            this.guna2GroupBox1.Text = "Ingrese los siguientes datos";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtDescripcion.Location = new System.Drawing.Point(411, 64);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(6);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.PlaceholderText = "";
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.ShadowDecoration.Parent = this.txtDescripcion;
            this.txtDescripcion.Size = new System.Drawing.Size(194, 27);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.lblDescripcion.Location = new System.Drawing.Point(301, 68);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(101, 18);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtRegla
            // 
            this.txtRegla.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegla.DefaultText = "";
            this.txtRegla.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegla.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegla.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegla.DisabledState.Parent = this.txtRegla;
            this.txtRegla.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegla.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegla.FocusedState.Parent = this.txtRegla;
            this.txtRegla.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegla.HoverState.Parent = this.txtRegla;
            this.txtRegla.Location = new System.Drawing.Point(64, 64);
            this.txtRegla.Margin = new System.Windows.Forms.Padding(4);
            this.txtRegla.Name = "txtRegla";
            this.txtRegla.PasswordChar = '\0';
            this.txtRegla.PlaceholderText = "";
            this.txtRegla.SelectedText = "";
            this.txtRegla.ShadowDecoration.Parent = this.txtRegla;
            this.txtRegla.Size = new System.Drawing.Size(155, 26);
            this.txtRegla.TabIndex = 1;
            // 
            // lblRegla
            // 
            this.lblRegla.AutoSize = true;
            this.lblRegla.BackColor = System.Drawing.Color.Transparent;
            this.lblRegla.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.lblRegla.Location = new System.Drawing.Point(10, 68);
            this.lblRegla.Name = "lblRegla";
            this.lblRegla.Size = new System.Drawing.Size(55, 18);
            this.lblRegla.TabIndex = 0;
            this.lblRegla.Text = "Regla:";
            // 
            // Vista_Reglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 618);
            this.Controls.Add(this.dtReglas);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "Vista_Reglas";
            this.Text = "Vista_Regla";
            ((System.ComponentModel.ISupportInitialize)(this.dtReglas)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2DataGridView dtReglas;
        public Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        public Guna.UI2.WinForms.Guna2Button btnLimpiar;
        public Guna.UI2.WinForms.Guna2Button btnEliminar;
        public Guna.UI2.WinForms.Guna2Button btnEditar;
        public Guna.UI2.WinForms.Guna2Button btnGuardar;
        public Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        public Guna.UI2.WinForms.Guna2TextBox txtDescripcion;
        public System.Windows.Forms.Label lblDescripcion;
        public Guna.UI2.WinForms.Guna2TextBox txtRegla;
        public System.Windows.Forms.Label lblRegla;
    }
}