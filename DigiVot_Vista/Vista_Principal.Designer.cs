namespace DigiVot_Vista
{
    partial class Vista_Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuAltas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCandidatos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCiudadanos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPartidos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnElecciones = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCVitual = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMesaDirectiva = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLocales = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEstatales = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNacionales = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAsigF_M = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioMesaDirectivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfinguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPerfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReglas = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeNosotrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAsignacion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAltas,
            this.reportesToolStripMenuItem,
            this.btnAsigF_M,
            this.mnuConfinguracion,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuAltas
            // 
            this.mnuAltas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCandidatos,
            this.btnCiudadanos,
            this.btnPartidos,
            this.btnElecciones,
            this.btnCVitual,
            this.btnMesaDirectiva,
            this.btnFuncionarios});
            this.mnuAltas.Name = "mnuAltas";
            this.mnuAltas.Size = new System.Drawing.Size(45, 20);
            this.mnuAltas.Text = "Altas";
            // 
            // btnCandidatos
            // 
            this.btnCandidatos.Name = "btnCandidatos";
            this.btnCandidatos.Size = new System.Drawing.Size(151, 22);
            this.btnCandidatos.Text = "Candidatos";
            // 
            // btnCiudadanos
            // 
            this.btnCiudadanos.Name = "btnCiudadanos";
            this.btnCiudadanos.Size = new System.Drawing.Size(151, 22);
            this.btnCiudadanos.Text = "Ciudadanos";
            // 
            // btnPartidos
            // 
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(151, 22);
            this.btnPartidos.Text = "Partidos";
            // 
            // btnElecciones
            // 
            this.btnElecciones.Name = "btnElecciones";
            this.btnElecciones.Size = new System.Drawing.Size(151, 22);
            this.btnElecciones.Text = "Elecciones";
            // 
            // btnCVitual
            // 
            this.btnCVitual.Name = "btnCVitual";
            this.btnCVitual.Size = new System.Drawing.Size(151, 22);
            this.btnCVitual.Text = "Casilla Virtual";
            // 
            // btnMesaDirectiva
            // 
            this.btnMesaDirectiva.Name = "btnMesaDirectiva";
            this.btnMesaDirectiva.Size = new System.Drawing.Size(151, 22);
            this.btnMesaDirectiva.Text = "Mesa Directiva";
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(151, 22);
            this.btnFuncionarios.Text = "Funcionarios";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLocales,
            this.btnEstatales,
            this.btnNacionales});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // btnLocales
            // 
            this.btnLocales.Name = "btnLocales";
            this.btnLocales.Size = new System.Drawing.Size(135, 22);
            this.btnLocales.Text = "Locales";
            // 
            // btnEstatales
            // 
            this.btnEstatales.Name = "btnEstatales";
            this.btnEstatales.Size = new System.Drawing.Size(135, 22);
            this.btnEstatales.Text = "Estatales";
            this.btnEstatales.Click += new System.EventHandler(this.nacionalesToolStripMenuItem_Click);
            // 
            // btnNacionales
            // 
            this.btnNacionales.Name = "btnNacionales";
            this.btnNacionales.Size = new System.Drawing.Size(135, 22);
            this.btnNacionales.Text = "Nacionales ";
            // 
            // btnAsigF_M
            // 
            this.btnAsigF_M.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionarioMesaDirectivaToolStripMenuItem});
            this.btnAsigF_M.Name = "btnAsigF_M";
            this.btnAsigF_M.Size = new System.Drawing.Size(89, 20);
            this.btnAsigF_M.Text = "Asignaciones";
            // 
            // funcionarioMesaDirectivaToolStripMenuItem
            // 
            this.funcionarioMesaDirectivaToolStripMenuItem.Name = "funcionarioMesaDirectivaToolStripMenuItem";
            this.funcionarioMesaDirectivaToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.funcionarioMesaDirectivaToolStripMenuItem.Text = "Funcionario-Mesa Directiva";
            // 
            // mnuConfinguracion
            // 
            this.mnuConfinguracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsuarios,
            this.btnPerfiles,
            this.btnReglas,
            this.btnAsignacion});
            this.mnuConfinguracion.Name = "mnuConfinguracion";
            this.mnuConfinguracion.Size = new System.Drawing.Size(95, 20);
            this.mnuConfinguracion.Text = "Configuracion";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(180, 22);
            this.btnUsuarios.Text = "Usuarios";
            // 
            // btnPerfiles
            // 
            this.btnPerfiles.Name = "btnPerfiles";
            this.btnPerfiles.Size = new System.Drawing.Size(180, 22);
            this.btnPerfiles.Text = "Perfiles";
            // 
            // btnReglas
            // 
            this.btnReglas.Name = "btnReglas";
            this.btnReglas.Size = new System.Drawing.Size(180, 22);
            this.btnReglas.Text = "Reglas";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeNosotrosToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // acercaDeNosotrosToolStripMenuItem
            // 
            this.acercaDeNosotrosToolStripMenuItem.Name = "acercaDeNosotrosToolStripMenuItem";
            this.acercaDeNosotrosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.acercaDeNosotrosToolStripMenuItem.Text = "Acerca de Nosotros";
            // 
            // btnAsignacion
            // 
            this.btnAsignacion.Name = "btnAsignacion";
            this.btnAsignacion.Size = new System.Drawing.Size(180, 22);
            this.btnAsignacion.Text = "Asignacion";
            // 
            // Vista_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Vista_Principal";
            this.Text = "Vista_Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem mnuAltas;
        public System.Windows.Forms.ToolStripMenuItem btnCandidatos;
        public System.Windows.Forms.ToolStripMenuItem btnCiudadanos;
        public System.Windows.Forms.ToolStripMenuItem btnPartidos;
        public System.Windows.Forms.ToolStripMenuItem btnElecciones;
        public System.Windows.Forms.ToolStripMenuItem btnCVitual;
        public System.Windows.Forms.ToolStripMenuItem btnMesaDirectiva;
        public System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem btnLocales;
        public System.Windows.Forms.ToolStripMenuItem btnEstatales;
        private System.Windows.Forms.ToolStripMenuItem btnFuncionarios;
        public System.Windows.Forms.ToolStripMenuItem btnNacionales;
        private System.Windows.Forms.ToolStripMenuItem btnAsigF_M;
        public System.Windows.Forms.ToolStripMenuItem btnUsuarios;
        public System.Windows.Forms.ToolStripMenuItem btnPerfiles;
        public System.Windows.Forms.ToolStripMenuItem btnReglas;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeNosotrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioMesaDirectivaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mnuConfinguracion;
        public System.Windows.Forms.ToolStripMenuItem btnAsignacion;
    }
}