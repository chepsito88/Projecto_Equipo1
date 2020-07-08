namespace DigiVot_Vista
{
    partial class Vista_Asignador
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
            this.grpPerfiles = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmbPerfiles = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.grpReglas = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtReglas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.grpPerfiles.SuspendLayout();
            this.grpReglas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtReglas)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPerfiles
            // 
            this.grpPerfiles.Controls.Add(this.cmbPerfiles);
            this.grpPerfiles.Controls.Add(this.lblPerfil);
            this.grpPerfiles.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.grpPerfiles.FillColor = System.Drawing.Color.WhiteSmoke;
            this.grpPerfiles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPerfiles.ForeColor = System.Drawing.Color.White;
            this.grpPerfiles.Location = new System.Drawing.Point(30, 12);
            this.grpPerfiles.MaximumSize = new System.Drawing.Size(1011, 135);
            this.grpPerfiles.Name = "grpPerfiles";
            this.grpPerfiles.ShadowDecoration.Parent = this.grpPerfiles;
            this.grpPerfiles.Size = new System.Drawing.Size(575, 124);
            this.grpPerfiles.TabIndex = 7;
            this.grpPerfiles.Text = "Datos de Perfiles";
            this.grpPerfiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbPerfiles
            // 
            this.cmbPerfiles.BackColor = System.Drawing.Color.Transparent;
            this.cmbPerfiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfiles.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPerfiles.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPerfiles.FocusedState.Parent = this.cmbPerfiles;
            this.cmbPerfiles.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPerfiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPerfiles.HoverState.Parent = this.cmbPerfiles;
            this.cmbPerfiles.ItemHeight = 30;
            this.cmbPerfiles.ItemsAppearance.Parent = this.cmbPerfiles;
            this.cmbPerfiles.Location = new System.Drawing.Point(306, 69);
            this.cmbPerfiles.Name = "cmbPerfiles";
            this.cmbPerfiles.ShadowDecoration.Parent = this.cmbPerfiles;
            this.cmbPerfiles.Size = new System.Drawing.Size(140, 36);
            this.cmbPerfiles.TabIndex = 1;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblPerfil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.lblPerfil.Location = new System.Drawing.Point(39, 69);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(43, 18);
            this.lblPerfil.TabIndex = 0;
            this.lblPerfil.Text = "Perfil";
            // 
            // grpReglas
            // 
            this.grpReglas.Controls.Add(this.dtReglas);
            this.grpReglas.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            this.grpReglas.FillColor = System.Drawing.Color.WhiteSmoke;
            this.grpReglas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReglas.ForeColor = System.Drawing.Color.White;
            this.grpReglas.Location = new System.Drawing.Point(30, 192);
            this.grpReglas.Name = "grpReglas";
            this.grpReglas.ShadowDecoration.Parent = this.grpReglas;
            this.grpReglas.Size = new System.Drawing.Size(575, 335);
            this.grpReglas.TabIndex = 8;
            this.grpReglas.Text = "Listado de Reglas";
            this.grpReglas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtReglas
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtReglas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtReglas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtReglas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtReglas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtReglas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtReglas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtReglas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(89)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtReglas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtReglas.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtReglas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtReglas.EnableHeadersVisualStyles = false;
            this.dtReglas.GridColor = System.Drawing.Color.White;
            this.dtReglas.Location = new System.Drawing.Point(16, 75);
            this.dtReglas.MultiSelect = false;
            this.dtReglas.Name = "dtReglas";
            this.dtReglas.RowHeadersVisible = false;
            this.dtReglas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtReglas.Size = new System.Drawing.Size(521, 232);
            this.dtReglas.TabIndex = 9;
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
            this.dtReglas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReglas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dtReglas.ThemeStyle.RowsStyle.Height = 22;
            this.dtReglas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtReglas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Vista_Asignador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 553);
            this.Controls.Add(this.grpReglas);
            this.Controls.Add(this.grpPerfiles);
            this.Name = "Vista_Asignador";
            this.Text = "Vista_Asignado";
            this.grpPerfiles.ResumeLayout(false);
            this.grpPerfiles.PerformLayout();
            this.grpReglas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtReglas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2GroupBox grpPerfiles;
        public System.Windows.Forms.Label lblPerfil;
        public Guna.UI2.WinForms.Guna2ComboBox cmbPerfiles;
        public Guna.UI2.WinForms.Guna2GroupBox grpReglas;
        public Guna.UI2.WinForms.Guna2DataGridView dtReglas;
    }
}