using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowAnhtrongCay
{
    public partial class frmCaiDat : Form
    {
        public frmCaiDat()
        {
            InitializeComponent();
        }

        public int SoGiay { get; set; }
        public int choPhepLap { get; set; }
        public int hienThiNgauNhien { get; set; }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (rbChoPhepLap.Checked == true)
            {
                choPhepLap = 1;
            }
            if (rbRandom.Checked == true)
            {
                hienThiNgauNhien = 1;
            }
            SoGiay = (int)numSoGiay.Value;
            DialogResult = DialogResult.OK;

        }
    }
}
