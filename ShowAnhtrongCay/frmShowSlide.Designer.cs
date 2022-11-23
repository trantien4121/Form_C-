namespace ShowAnhtrongCay
{
    partial class frmShowSlide
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbSlide = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbSlide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 379);
            this.panel1.TabIndex = 0;
            // 
            // pbSlide
            // 
            this.pbSlide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSlide.Location = new System.Drawing.Point(0, 0);
            this.pbSlide.Name = "pbSlide";
            this.pbSlide.Size = new System.Drawing.Size(608, 379);
            this.pbSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlide.TabIndex = 0;
            this.pbSlide.TabStop = false;
            // 
            // frmShowSlide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 379);
            this.Controls.Add(this.panel1);
            this.Name = "frmShowSlide";
            this.Text = "frmShowSlide";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private PictureBox pbSlide;
    }
}