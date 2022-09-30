namespace form22_09_2022
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridGiangVien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGiangVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsGiangVien = new System.Windows.Forms.BindingSource(this.components);
            this.btnThongTinGiangVien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(82, 12);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(181, 21);
            this.cbbKhoa.TabIndex = 0;
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khoa:";
            // 
            // gridGiangVien
            // 
            this.gridGiangVien.AutoGenerateColumns = false;
            this.gridGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGiangVienDataGridViewTextBoxColumn,
            this.HoVaTen,
            this.gioiTinhDataGridViewCheckBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.queQuanDataGridViewTextBoxColumn});
            this.gridGiangVien.DataSource = this.bdsGiangVien;
            this.gridGiangVien.Location = new System.Drawing.Point(19, 82);
            this.gridGiangVien.Name = "gridGiangVien";
            this.gridGiangVien.Size = new System.Drawing.Size(744, 329);
            this.gridGiangVien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách Giảng viên";
            // 
            // HoVaTen
            // 
            this.HoVaTen.DataPropertyName = "HoVaTen";
            this.HoVaTen.HeaderText = "Họ và Tên";
            this.HoVaTen.Name = "HoVaTen";
            this.HoVaTen.ReadOnly = true;
            this.HoVaTen.Width = 200;
            // 
            // maGiangVienDataGridViewTextBoxColumn
            // 
            this.maGiangVienDataGridViewTextBoxColumn.DataPropertyName = "MaGiangVien";
            this.maGiangVienDataGridViewTextBoxColumn.HeaderText = "Mã Giảng Viên";
            this.maGiangVienDataGridViewTextBoxColumn.Name = "maGiangVienDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewCheckBoxColumn
            // 
            this.gioiTinhDataGridViewCheckBoxColumn.DataPropertyName = "GioiTinhStr";
            this.gioiTinhDataGridViewCheckBoxColumn.HeaderText = "Giới tính";
            this.gioiTinhDataGridViewCheckBoxColumn.Name = "gioiTinhDataGridViewCheckBoxColumn";
            this.gioiTinhDataGridViewCheckBoxColumn.ReadOnly = true;
            this.gioiTinhDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gioiTinhDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.ngaySinhDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // queQuanDataGridViewTextBoxColumn
            // 
            this.queQuanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.queQuanDataGridViewTextBoxColumn.DataPropertyName = "QueQuan";
            this.queQuanDataGridViewTextBoxColumn.HeaderText = "Quê Quán";
            this.queQuanDataGridViewTextBoxColumn.Name = "queQuanDataGridViewTextBoxColumn";
            // 
            // bdsGiangVien
            // 
            this.bdsGiangVien.DataSource = typeof(form22_09_2022.ViewModel.GiangVienViewModel);
            // 
            // btnThongTinGiangVien
            // 
            this.btnThongTinGiangVien.Location = new System.Drawing.Point(633, 46);
            this.btnThongTinGiangVien.Name = "btnThongTinGiangVien";
            this.btnThongTinGiangVien.Size = new System.Drawing.Size(130, 23);
            this.btnThongTinGiangVien.TabIndex = 4;
            this.btnThongTinGiangVien.Text = "Thông tin Giảng Viên";
            this.btnThongTinGiangVien.UseVisualStyleBackColor = true;
            this.btnThongTinGiangVien.Click += new System.EventHandler(this.btnThongTinGiangVien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThongTinGiangVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridGiangVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbKhoa);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridGiangVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bdsGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGiangVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnThongTinGiangVien;
    }
}

