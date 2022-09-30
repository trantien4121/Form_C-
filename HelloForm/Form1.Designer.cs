namespace HelloForm
{
    partial class form1
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
        private void InitializeComponent() //Sau khi chọn các lable thì click chuột phải vào đây -> Go to defination
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsothunhat = new System.Windows.Forms.TextBox();
            this.txtsothuhai = new System.Windows.Forms.TextBox();
            this.btncong = new System.Windows.Forms.Button();
            this.btntru = new System.Windows.Forms.Button();
            this.btnnhan = new System.Windows.Forms.Button();
            this.btnchia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblketqua = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdblabel = new System.Windows.Forms.RadioButton();
            this.rdbmessage = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.llkchonhinh = new System.Windows.Forms.LinkLabel();
            this.llkchonmau = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(228, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ứng dụng tính toán cơ bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số thứ nhất: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập số thứ hai: ";
            // 
            // txtsothunhat
            // 
            this.txtsothunhat.Location = new System.Drawing.Point(263, 168);
            this.txtsothunhat.Name = "txtsothunhat";
            this.txtsothunhat.Size = new System.Drawing.Size(361, 20);
            this.txtsothunhat.TabIndex = 1;
            // 
            // txtsothuhai
            // 
            this.txtsothuhai.Location = new System.Drawing.Point(263, 230);
            this.txtsothuhai.Name = "txtsothuhai";
            this.txtsothuhai.Size = new System.Drawing.Size(361, 20);
            this.txtsothuhai.TabIndex = 2;
            // 
            // btncong
            // 
            this.btncong.Location = new System.Drawing.Point(263, 291);
            this.btncong.Name = "btncong";
            this.btncong.Size = new System.Drawing.Size(75, 33);
            this.btncong.TabIndex = 3;
            this.btncong.Text = "+";
            this.btncong.UseVisualStyleBackColor = true;
            this.btncong.Click += new System.EventHandler(this.btncong_Click);
            // 
            // btntru
            // 
            this.btntru.Location = new System.Drawing.Point(359, 291);
            this.btntru.Name = "btntru";
            this.btntru.Size = new System.Drawing.Size(75, 33);
            this.btntru.TabIndex = 4;
            this.btntru.Text = "-";
            this.btntru.UseVisualStyleBackColor = true;
            this.btntru.Click += new System.EventHandler(this.btntru_Click);
            // 
            // btnnhan
            // 
            this.btnnhan.Location = new System.Drawing.Point(458, 291);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(75, 33);
            this.btnnhan.TabIndex = 5;
            this.btnnhan.Text = "*";
            this.btnnhan.UseVisualStyleBackColor = true;
            this.btnnhan.Click += new System.EventHandler(this.btnnhan_Click);
            // 
            // btnchia
            // 
            this.btnchia.Location = new System.Drawing.Point(549, 291);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(75, 33);
            this.btnchia.TabIndex = 6;
            this.btnchia.Text = "/";
            this.btnchia.UseVisualStyleBackColor = true;
            this.btnchia.Click += new System.EventHandler(this.btnchia_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(302, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kết quả";
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblketqua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblketqua.Location = new System.Drawing.Point(413, 348);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(21, 24);
            this.lblketqua.TabIndex = 5;
            this.lblketqua.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hiển thị kết quả";
            // 
            // rdblabel
            // 
            this.rdblabel.AutoSize = true;
            this.rdblabel.Checked = true;
            this.rdblabel.Location = new System.Drawing.Point(293, 394);
            this.rdblabel.Name = "rdblabel";
            this.rdblabel.Size = new System.Drawing.Size(72, 17);
            this.rdblabel.TabIndex = 8;
            this.rdblabel.TabStop = true;
            this.rdblabel.Text = "Trên label";
            this.rdblabel.UseVisualStyleBackColor = true;
            // 
            // rdbmessage
            // 
            this.rdbmessage.AutoSize = true;
            this.rdbmessage.Location = new System.Drawing.Point(417, 394);
            this.rdbmessage.Name = "rdbmessage";
            this.rdbmessage.Size = new System.Drawing.Size(92, 17);
            this.rdbmessage.TabIndex = 9;
            this.rdbmessage.TabStop = true;
            this.rdbmessage.Text = "Trên message";
            this.rdbmessage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Màu nền";
            // 
            // llkchonhinh
            // 
            this.llkchonhinh.AutoSize = true;
            this.llkchonhinh.Location = new System.Drawing.Point(414, 439);
            this.llkchonhinh.Name = "llkchonhinh";
            this.llkchonhinh.Size = new System.Drawing.Size(55, 13);
            this.llkchonhinh.TabIndex = 10;
            this.llkchonhinh.TabStop = true;
            this.llkchonhinh.Text = "Chọn hình";
            this.llkchonhinh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llkchonhinh_LinkClicked);
            // 
            // llkchonmau
            // 
            this.llkchonmau.AutoSize = true;
            this.llkchonmau.Location = new System.Drawing.Point(290, 439);
            this.llkchonmau.Name = "llkchonmau";
            this.llkchonmau.Size = new System.Drawing.Size(55, 13);
            this.llkchonmau.TabIndex = 11;
            this.llkchonmau.TabStop = true;
            this.llkchonmau.Text = "Chọn màu";
            this.llkchonmau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llkchonmau_LinkClicked_1);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.llkchonmau);
            this.Controls.Add(this.llkchonhinh);
            this.Controls.Add(this.rdbmessage);
            this.Controls.Add(this.rdblabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnchia);
            this.Controls.Add(this.btnnhan);
            this.Controls.Add(this.btntru);
            this.Controls.Add(this.btncong);
            this.Controls.Add(this.txtsothuhai);
            this.Controls.Add(this.txtsothunhat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsothunhat;
        private System.Windows.Forms.TextBox txtsothuhai;
        private System.Windows.Forms.Button btncong;
        private System.Windows.Forms.Button btntru;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.Button btnchia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdblabel;
        private System.Windows.Forms.RadioButton rdbmessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel llkchonhinh;
        private System.Windows.Forms.LinkLabel llkchonmau;
    }
}

