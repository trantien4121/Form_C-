namespace sliderproject
{
    partial class frmSlideShow
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
            this.pbSlide = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSlide
            // 
            this.pbSlide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSlide.Location = new System.Drawing.Point(0, 0);
            this.pbSlide.Name = "pbSlide";
            this.pbSlide.Size = new System.Drawing.Size(800, 450);
            this.pbSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlide.TabIndex = 0;
            this.pbSlide.TabStop = false;
            this.pbSlide.Click += new System.EventHandler(this.pbSlide_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbSlide);
            this.Name = "frmSlideShow";
            this.Text = "SlideShow";
            ((System.ComponentModel.ISupportInitialize)(this.pbSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbSlide;
        private System.Windows.Forms.Timer timer;
    }
}