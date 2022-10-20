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
    public partial class frmLopHoc : Form
    {
        LopHocViewModel lopHoc;
        public frmLopHoc(LopHocViewModel lopHoc = null) //Nếu không truyền hoặc null thì là form Thêm Lớp, còn truyền thì là form Cập nhật Lớp
        {
            InitializeComponent();
            this.lopHoc = lopHoc;
            if(lopHoc != null)
            {
               txtTenLop.Text = lopHoc.TenLop;
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (this.lopHoc == null)    //Xứ lý trường hợp add sinh viên
            {
                var lophoc = new LopHoc
                {
                    TenLop = txtTenLop.Text,
                };
                if (LopHocService.addLopHoc(lophoc) == KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK; //Bao ket qua
                }
                else
                {
                    MessageBox.Show("Tên lớp học đã tồn tại", "Thông báo");
                    txtTenLop.Focus();
                }

            }
            //Xứ lý trường hợp update sinh viên
            else
            {
                lopHoc.TenLop = txtTenLop.Text;

                LopHocService.UpdateLopHoc(lopHoc);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
