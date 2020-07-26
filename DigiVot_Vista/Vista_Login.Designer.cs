namespace DigiVot_Vista
{
    partial class Vista_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.eprvUno = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtUsuario = new PlaceholderTextBox.PlaceholderTextBox();
            this.txtContrasena = new PlaceholderTextBox.PlaceholderTextBox();
            this.btnAcceder = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.pktCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprvUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pktCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(189)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(442, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Inicio de Sesión ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(240)))));
            this.linkLabel1.Location = new System.Drawing.Point(453, 287);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(238, 21);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Ha olvidado su contraseña?";
            // 
            // eprvUno
            // 
            this.eprvUno.ContainerControl = this;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(189)))), ((int)(((byte)(169)))));
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(349, 88);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "chepsito";
            this.txtUsuario.Size = new System.Drawing.Size(395, 31);
            this.txtUsuario.TabIndex = 21;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(189)))), ((int)(((byte)(169)))));
            this.txtContrasena.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.White;
            this.txtContrasena.Location = new System.Drawing.Point(349, 163);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PlaceholderText = "1988";
            this.txtContrasena.Size = new System.Drawing.Size(395, 31);
            this.txtContrasena.TabIndex = 22;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAcceder.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAcceder.IconColor = System.Drawing.Color.White;
            this.btnAcceder.IconSize = 22;
            this.btnAcceder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcceder.Location = new System.Drawing.Point(349, 230);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Rotation = 0D;
            this.btnAcceder.Size = new System.Drawing.Size(395, 35);
            this.btnAcceder.TabIndex = 23;
            this.btnAcceder.Text = "  Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(240)))));
            this.iconPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconSize = 30;
            this.iconPictureBox2.Location = new System.Drawing.Point(685, 12);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(30, 30);
            this.iconPictureBox2.TabIndex = 25;
            this.iconPictureBox2.TabStop = false;
            // 
            // pktCerrar
            // 
            this.pktCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(240)))));
            this.pktCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pktCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.pktCerrar.IconColor = System.Drawing.Color.White;
            this.pktCerrar.IconSize = 30;
            this.pktCerrar.Location = new System.Drawing.Point(728, 12);
            this.pktCerrar.Name = "pktCerrar";
            this.pktCerrar.Size = new System.Drawing.Size(30, 30);
            this.pktCerrar.TabIndex = 24;
            this.pktCerrar.TabStop = false;
            // 
            // Vista_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.pktCerrar);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vista_Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprvUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pktCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.LinkLabel linkLabel1;
        public FontAwesome.Sharp.IconButton btnAcceder;
        public PlaceholderTextBox.PlaceholderTextBox txtContrasena;
        public PlaceholderTextBox.PlaceholderTextBox txtUsuario;
        public FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        public FontAwesome.Sharp.IconPictureBox pktCerrar;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ErrorProvider eprvUno;
    }
}