using QuanLySinhVien.Model;
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
            var ls = LopHocViewModel.Getlist();
            cbblophoc.DataSource = ls;
            cbblophoc.DisplayMember = "TenLop";
        
        }

        void NapDsSinhVien()
        {
            
            
            if(selectedLopHoc != null)
            {
                var ls = SinhVienViewModel.Getlist(selectedLopHoc.ID);
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
                if (SinhVienViewModel.DeleteSinhVien(selectedSinhVien.MaSinhVien) == KetQua.ThanhCong)
                {
                    MessageBox.Show("xoa ok!");
                    NapDsSinhVien();

                }
                else
                {
                    MessageBox.Show("Loi!");
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
    }
}
