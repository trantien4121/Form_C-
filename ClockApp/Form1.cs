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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
        }

        //int count = 0;
        int soPhut = 0;

        public int soPhut2 { get; set; }
        private void timer1_Tick(object sender, EventArgs e)
        {
            soPhut2--;
            lblphut.Text = $"{convert(soPhut2)}";
            if(soPhut2 < 10)
            {
                lblphut.ForeColor = Color.Blue;
            }
            if(soPhut2 == 0)
            {
                timer1.Stop();

                MessageBox.Show("Bạn đã hết thời gian!");

            }
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (soPhut2 > 0)
            {
                btnstart.Enabled = false;
                timer1.Start();
            }
               
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnstart.Enabled = true;
        }

        private void lblgiay_Click(object sender, EventArgs e)
        {

        }


        private void btncaidat_Click(object sender, EventArgs e)
        {
            var f = new frmSetThoiGian();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                soPhut = f.SoPhut;
                lblphut.Text = convert(soPhut * 60);
                soPhut2 = f.SoPhut * 60;
            }
        }
        String convert(int soGiay)
        {
            int p = soGiay / 60;
            int s = soGiay % 60;
                return $"{p:0#}:{s:0#}";    //Hien thi 2 chu so, neu 1 chu so thi dien vao do la 0
            }
    }
}
