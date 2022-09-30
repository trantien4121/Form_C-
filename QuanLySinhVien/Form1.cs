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
            NapDsSinhVien();
        }
        public LopHocViewModel selectedLopHoc
        {
            get
            {
                return cbblophoc.SelectedItem as LopHocViewModel;
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
                gridsinhvien.DataSource = ls;
            }

        }

        private void cbblophoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapDsSinhVien();
        }
    }
}
