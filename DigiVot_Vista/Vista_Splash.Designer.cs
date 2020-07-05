namespace DigiVot_Vista
{
    partial class Vista_Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_Splash));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrTiempo = new System.Windows.Forms.Timer(this.components);
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tmrTiempo
            // 
            this.tmrTiempo.Enabled = true;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl1.Controls.Add(this.pnl2);
            this.pnl1.Location = new System.Drawing.Point(94, 299);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(324, 26);
            this.pnl1.TabIndex = 5;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnl2.Location = new System.Drawing.Point(2, 2);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(0, 22);
            this.pnl2.TabIndex = 2;
            // 
            // Vista_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(480, 350);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vista_Splash";
            this.Text = "Vista_Splash";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Timer tmrTiempo;
        public System.Windows.Forms.Panel pnl1;
        public System.Windows.Forms.Panel pnl2;
    }
}