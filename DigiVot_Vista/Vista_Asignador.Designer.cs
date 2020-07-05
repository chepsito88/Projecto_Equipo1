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
            this.grpPerfiles = new System.Windows.Forms.GroupBox();
            this.cmbPerfiles = new System.Windows.Forms.ComboBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.grpReglas = new System.Windows.Forms.GroupBox();
            this.dtReglas = new System.Windows.Forms.DataGridView();
            this.grpPerfiles.SuspendLayout();
            this.grpReglas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtReglas)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPerfiles
            // 
            this.grpPerfiles.Controls.Add(this.cmbPerfiles);
            this.grpPerfiles.Controls.Add(this.lblPerfil);
            this.grpPerfiles.Location = new System.Drawing.Point(12, 25);
            this.grpPerfiles.Name = "grpPerfiles";
            this.grpPerfiles.Size = new System.Drawing.Size(421, 66);
            this.grpPerfiles.TabIndex = 0;
            this.grpPerfiles.TabStop = false;
            this.grpPerfiles.Text = "Datos de Perfiles";
            // 
            // cmbPerfiles
            // 
            this.cmbPerfiles.FormattingEnabled = true;
            this.cmbPerfiles.Location = new System.Drawing.Point(151, 20);
            this.cmbPerfiles.Name = "cmbPerfiles";
            this.cmbPerfiles.Size = new System.Drawing.Size(121, 21);
            this.cmbPerfiles.TabIndex = 1;
            this.cmbPerfiles.Text = "Elije Opcion";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(6, 28);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(30, 13);
            this.lblPerfil.TabIndex = 0;
            this.lblPerfil.Text = "Perfil";
            // 
            // grpReglas
            // 
            this.grpReglas.Controls.Add(this.dtReglas);
            this.grpReglas.Location = new System.Drawing.Point(12, 97);
            this.grpReglas.Name = "grpReglas";
            this.grpReglas.Size = new System.Drawing.Size(489, 341);
            this.grpReglas.TabIndex = 1;
            this.grpReglas.TabStop = false;
            this.grpReglas.Text = "Listado de Reglas";
            // 
            // dtReglas
            // 
            this.dtReglas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtReglas.Location = new System.Drawing.Point(32, 48);
            this.dtReglas.Name = "dtReglas";
            this.dtReglas.Size = new System.Drawing.Size(421, 274);
            this.dtReglas.TabIndex = 0;
            // 
            // Vista_Asignador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 451);
            this.Controls.Add(this.grpReglas);
            this.Controls.Add(this.grpPerfiles);
            this.Name = "Vista_Asignador";
            this.Text = "Vista_Asignador";
            this.grpPerfiles.ResumeLayout(false);
            this.grpPerfiles.PerformLayout();
            this.grpReglas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtReglas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPerfiles;
        public System.Windows.Forms.ComboBox cmbPerfiles;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.GroupBox grpReglas;
        public System.Windows.Forms.DataGridView dtReglas;
    }
}