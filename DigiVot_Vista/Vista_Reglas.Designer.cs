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
            this.dtReglas = new System.Windows.Forms.DataGridView();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblRegla = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtRegla = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtReglas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtReglas
            // 
            this.dtReglas.AllowUserToAddRows = false;
            this.dtReglas.AllowUserToDeleteRows = false;
            this.dtReglas.AllowUserToResizeColumns = false;
            this.dtReglas.AllowUserToResizeRows = false;
            this.dtReglas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtReglas.Location = new System.Drawing.Point(159, 187);
            this.dtReglas.MultiSelect = false;
            this.dtReglas.Name = "dtReglas";
            this.dtReglas.ReadOnly = true;
            this.dtReglas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtReglas.Size = new System.Drawing.Size(352, 185);
            this.dtReglas.TabIndex = 12;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(75, 90);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 13);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descripcion: ";
            // 
            // lblRegla
            // 
            this.lblRegla.AutoSize = true;
            this.lblRegla.Location = new System.Drawing.Point(75, 51);
            this.lblRegla.Name = "lblRegla";
            this.lblRegla.Size = new System.Drawing.Size(38, 13);
            this.lblRegla.TabIndex = 11;
            this.lblRegla.Text = "Regla:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(475, 117);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(336, 117);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(229, 117);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Modificar ";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(129, 117);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(159, 90);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(167, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtRegla
            // 
            this.txtRegla.Location = new System.Drawing.Point(159, 54);
            this.txtRegla.Name = "txtRegla";
            this.txtRegla.Size = new System.Drawing.Size(100, 20);
            this.txtRegla.TabIndex = 5;
            // 
            // Vista_Reglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 427);
            this.Controls.Add(this.dtReglas);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblRegla);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtRegla);
            this.Name = "Vista_Reglas";
            this.Text = "Vista_Reglas";
            ((System.ComponentModel.ISupportInitialize)(this.dtReglas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtReglas;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblRegla;
        public System.Windows.Forms.Button btnLimpiar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtRegla;
    }
}