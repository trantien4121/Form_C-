using QuanLySinhVien.Model;
using QuanLySinhVien.Services;
using QuanLySinhVien.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmSinhVien : Form
    {

        SinhVienViewModel sinhVien;

        public frmSinhVien(SinhVienViewModel sinhVien = null)   //Neu k truyen (hoac null) thi la form Them Sinh vien, con truyen la cap nhat sinh vien
        {
            InitializeComponent();
            NapDSLopHoc();
            this.sinhVien = sinhVien;
            if(sinhVien != null)
            {
                cbbLopHoc.SelectedValue = sinhVien.IDLopHoc;
                txtMaSinhVien.Text = sinhVien.MaSinhVien;
                txtHoDem.Text = sinhVien.HoDem;
                txtTen.Text = sinhVien.Ten;
                dtbNgaySinh.Value = sinhVien.NgaySinh ?? DateTime.Now;
                txtQueQuan.Text = sinhVien.QueQuan;
                if (sinhVien.GioiTinh == 0)
                    rbNam.Checked = true;
                else if (sinhVien.GioiTinh == 1)
                    rbNu.Checked = true;
                else if (sinhVien.GioiTinh == 2)
                    rbKhac.Checked = true;
                }

        }
        public LopHocViewModel selectedLopHoc
        {
            get
            {
                return cbbLopHoc.SelectedItem as LopHocViewModel;
            }
        }
        void NapDSLopHoc()
        {
            var ls = LopHocService.Getlist();
            cbbLopHoc.DataSource = ls;
            cbbLopHoc.ValueMember = "ID";
            cbbLopHoc.DisplayMember = "TenLop";
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (this.sinhVien == null)
            {
                var sinhvien = new SinhVien
                {
                    HoDem = txtHoDem.Text,
                    Ten = txtTen.Text,
                    QueQuan = txtQueQuan.Text,
                    NgaySinh = dtbNgaySinh.Value,
                    MaSinhVien = txtMaSinhVien.Text,
                    IDLopHoc = selectedLopHoc.ID,
                    GioiTinh = (rbNam.Checked ? 0 : (rbNu.Checked ? 1 : 2))
                };
                if (SinhVienService.Addsinhvien(sinhvien) == KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK; //Bao ket qua
                }
                else
                {
                    MessageBox.Show("Mã sinh viên trùng", "Thông báo");
                    txtMaSinhVien.Focus();
                }
            }
            else
            {
                sinhVien.QueQuan = txtQueQuan.Text;
                sinhVien.HoDem = txtHoDem.Text;
                sinhVien.Ten = txtTen.Text;
                sinhVien.NgaySinh = dtbNgaySinh.Value;
                sinhVien.GioiTinh = (rbNam.Checked ? 0 : rbNu.Checked ? 1 : 2);
                sinhVien.MaSinhVien = txtMaSinhVien.Text;
                sinhVien.IDLopHoc = selectedLopHoc.ID;
                
                SinhVienService.UpdateSinhVien(sinhVien);
                DialogResult = DialogResult.OK;
            }
                   
        }
    }
}
