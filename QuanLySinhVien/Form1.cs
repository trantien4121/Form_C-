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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapDsLopHoc();
            //NapDsSinhVien();
        }
        public LopHocViewModel selectedLopHoc
        {
            get
            {
                return cbblophoc.SelectedItem as LopHocViewModel;
            }
        }
        public SinhVienViewModel selectedSinhVien
        {
            get
            {
                return bdsSinhVien.Current as SinhVienViewModel;
            }
        }
        void NapDsLopHoc()
        {
            var ls = LopHocService.Getlist();
            cbblophoc.DataSource = ls;
            cbblophoc.DisplayMember = "TenLop";
        
        }

        void NapDsSinhVien()
        {
            
            
            if(selectedLopHoc != null)
            {
                var ls = SinhVienService.Getlist(selectedLopHoc.ID);
                bdsSinhVien.DataSource = ls;
                gridsinhvien.DataSource = bdsSinhVien;
            }

        }

        private void cbblophoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapDsSinhVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiem tra ma sinh vien co trung hay khong
            //MSV, Ho Dem, Ten khong duoc de trong

            var f = new frmSinhVien();
            var rs =  f.ShowDialog();
            if(rs == DialogResult.OK)
            {
                NapDsSinhVien();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)   //Sai
        {
            if (selectedSinhVien != null)
            {
                var rs = MessageBox.Show("Bạn có chắc là muốn xóa?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(rs == DialogResult.OK)
                {
                    SinhVienService.DeleteSinhVien(selectedSinhVien);
                    NapDsSinhVien();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedSinhVien != null)
            {
                var f = new frmSinhVien(selectedSinhVien);
                if(f.ShowDialog() == DialogResult.OK)
                {
                    NapDsSinhVien();
                }
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {

            var fl= new frmLopHoc();
            var rs = fl.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDsLopHoc();
            }
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            if (selectedLopHoc != null)
            {
                var fl = new frmLopHoc(selectedLopHoc); ;
                if (fl.ShowDialog() == DialogResult.OK)
                {
                    NapDsLopHoc();
                }
            }
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            if (selectedLopHoc != null)
            {
                var rs = MessageBox.Show("Bạn có chắc là muốn xóa lóp học này?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    LopHocService.DeleteLopHoc(selectedLopHoc);
                    NapDsLopHoc();
                }
            }
        }

        private void gridsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
