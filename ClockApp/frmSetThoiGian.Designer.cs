namespace ClockApp
{
    partial class frmSetThoiGian
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
            this.label1 = new System.Windows.Forms.Label();
            this.numSoPhut = new System.Windows.Forms.NumericUpDown();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSoPhut)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian (phút):";
            // 
            // numSoPhut
            // 
            this.numSoPhut.Location = new System.Drawing.Point(214, 68);
            this.numSoPhut.Name = "numSoPhut";
            this.numSoPhut.Size = new System.Drawing.Size(120, 20);
            this.numSoPhut.TabIndex = 1;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(248, 181);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.TabIndex = 2;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnboqua.Location = new System.Drawing.Point(354, 180);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 23);
            this.btnboqua.TabIndex = 3;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            // 
            // frmSetThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnboqua;
            this.ClientSize = new System.Drawing.Size(440, 251);
            this.ControlBox = false;
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.numSoPhut);
            this.Controls.Add(this.label1);
            this.Name = "frmSetThoiGian";
            this.Text = "frmSetThoiGian";
            ((System.ComponentModel.ISupportInitialize)(this.numSoPhut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSoPhut;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnboqua;
    }
}