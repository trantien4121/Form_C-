using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockApp
{
    public partial class frmSetThoiGian : Form
    {
        public frmSetThoiGian()
        {
            InitializeComponent();
        } 

        public int SoPhut { get; set; }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            SoPhut = (int) numSoPhut.Value;
            DialogResult = DialogResult.OK; //Khi form co su thay doi, lap tuc dong lai
        }
    }
}
