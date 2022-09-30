using form22_09_2022.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form22_09_2022
{
    public partial class frmGiangVien : Form
    {
        public delegate void SendInfo(String MaGiangVien, String HoTen, String NgaySinh, 
            String GioiTinh, String QueQuan, String TenKhoa);
        //public frmGiangVien()
        //{
        //  InitializeComponent();
        //}
        public SendInfo Sender; public frmGiangVien()
        {
            InitializeComponent();
            Sender = new SendInfo(GetInfo);
        }
        private void GetInfo(String MaGiangVien, String HoTen, String NgaySinh, 
            String GioiTinh, String QueQuan, String TenKhoa)
        {
            txtmagiangvien.Text = MaGiangVien;
            txthoten.Text = HoTen;
            txtngaysinh.Text = NgaySinh;
            txtgioitinh.Text = GioiTinh;
            txtquequan.Text = QueQuan;
            txttenkhoa.Text = TenKhoa;
        }

        private void btntrolai_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Visible = false;
            form1.Show();
        }
    }
}
