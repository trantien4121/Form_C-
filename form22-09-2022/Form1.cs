using form22_09_2022.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form22_09_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapDSKhoa();
        }
        void NapDSKhoa()
        {
            var ds = KhoaViewModel.getList();
            cbbKhoa.DataSource = ds;
            cbbKhoa.DisplayMember = "TenKhoa";
        }

        void NapDSGiangVien()
        {
            if (selectedKhoa != null)
            {
                var list = GiangVienViewModel.getByKhoa(selectedKhoa.MaKhoa);
                //gridGiangVien.DataSource = list;
                bdsGiangVien.DataSource = list;
                gridGiangVien.DataSource = bdsGiangVien;
            }
        }

        public KhoaViewModel selectedKhoa
        {
            get
            {
                return cbbKhoa.SelectedItem as KhoaViewModel;
            }
        }

        public GiangVienViewModel selectedGiangVien
        {
            get
            {
                return bdsGiangVien.Current as GiangVienViewModel;
            }
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedKhoa != null)
            {
                //MessageBox.Show($"Chào: {selectedKhoa.TenKhoa}");
                NapDSGiangVien();
            }

        }

        private void btnThongTinGiangVien_Click(object sender, EventArgs e)
        {
            //var giangVien = bdsGiangVien.Current as GiangVienViewModel; //Thuoc tinh current giup xac dinh nhanh doi tuong dang chon la doi tuong nao, neu ko thi tra ve null
            if (selectedGiangVien != null) 
            MessageBox.Show($"Xin chào, {(selectedGiangVien.GioiTinh ? "Thầy" : "Cô")} {selectedGiangVien.HoVaTen}");
            frmGiangVien formGiangVien = new frmGiangVien();
            formGiangVien.Sender(selectedGiangVien.MaGiangVien, selectedGiangVien.HoVaTen,
                selectedGiangVien.NgaySinh.ToString("dd/MM/yyyy"), selectedGiangVien.GioiTinhStr, 
                selectedGiangVien.QueQuan, selectedKhoa.TenKhoa);
            this.Visible = false;
            formGiangVien.Show();
        }
    }
}
