namespace QuanLySinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbblophoc = new System.Windows.Forms.ComboBox();
            this.gridsinhvien = new System.Windows.Forms.DataGridView();
            this.sinhVienViewModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopHocViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoDem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLopHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridsinhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienViewModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp học";
            // 
            // cbblophoc
            // 
            this.cbblophoc.FormattingEnabled = true;
            this.cbblophoc.Location = new System.Drawing.Point(115, 39);
            this.cbblophoc.Name = "cbblophoc";
            this.cbblophoc.Size = new System.Drawing.Size(121, 21);
            this.cbblophoc.TabIndex = 1;
            this.cbblophoc.SelectedIndexChanged += new System.EventHandler(this.cbblophoc_SelectedIndexChanged);
            // 
            // gridsinhvien
            // 
            this.gridsinhvien.AutoGenerateColumns = false;
            this.gridsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridsinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.MaSinhVien,
            this.HoDem,
            this.Ten,
            this.NgaySinh,
            this.GioiTinh,
            this.QueQuan,
            this.iDLopHocDataGridViewTextBoxColumn});
            this.gridsinhvien.DataSource = this.sinhVienViewModelBindingSource;
            this.gridsinhvien.Location = new System.Drawing.Point(35, 88);
            this.gridsinhvien.Name = "gridsinhvien";
            this.gridsinhvien.Size = new System.Drawing.Size(731, 313);
            this.gridsinhvien.TabIndex = 2;
            // 
            // sinhVienViewModelBindingSource1
            // 
            this.sinhVienViewModelBindingSource1.DataSource = typeof(QuanLySinhVien.ViewModel.SinhVienViewModel);
            // 
            // sinhVienViewModelBindingSource
            // 
            this.sinhVienViewModelBindingSource.DataSource = typeof(QuanLySinhVien.ViewModel.SinhVienViewModel);
            // 
            // lopHocViewModelBindingSource
            // 
            this.lopHocViewModelBindingSource.DataSource = typeof(QuanLySinhVien.ViewModel.LopHocViewModel);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // MaSinhVien
            // 
            this.MaSinhVien.DataPropertyName = "MaSinhVien";
            this.MaSinhVien.HeaderText = "MaSinhVien";
            this.MaSinhVien.Name = "MaSinhVien";
            // 
            // HoDem
            // 
            this.HoDem.DataPropertyName = "HoDem";
            this.HoDem.HeaderText = "HoDem";
            this.HoDem.Name = "HoDem";
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Ten";
            this.Ten.Name = "Ten";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "NgaySinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "GioiTinh";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // QueQuan
            // 
            this.QueQuan.DataPropertyName = "QueQuan";
            this.QueQuan.HeaderText = "QueQuan";
            this.QueQuan.Name = "QueQuan";
            // 
            // iDLopHocDataGridViewTextBoxColumn
            // 
            this.iDLopHocDataGridViewTextBoxColumn.DataPropertyName = "IDLopHoc";
            this.iDLopHocDataGridViewTextBoxColumn.HeaderText = "IDLopHoc";
            this.iDLopHocDataGridViewTextBoxColumn.Name = "iDLopHocDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridsinhvien);
            this.Controls.Add(this.cbblophoc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridsinhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienViewModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbblophoc;
        private System.Windows.Forms.DataGridView gridsinhvien;
        private System.Windows.Forms.BindingSource lopHocViewModelBindingSource;
        private System.Windows.Forms.BindingSource sinhVienViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoDemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sinhVienViewModelBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoDem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLopHocDataGridViewTextBoxColumn;
    }
}

