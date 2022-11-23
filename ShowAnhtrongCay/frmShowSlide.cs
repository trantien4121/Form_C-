using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowAnhtrongCay
{
    public partial class frmShowSlide : Form
    {
        private ListView lsvListFile;
        public int ThoiGian;
        public int ChoPhepLap;
        public int ChayNgauNhien;
        public frmShowSlide(ListView lsvListFile, int ThoiGian, int choPhepLap, int chayNgauNhien)
        {
            InitializeComponent();
            this.lsvListFile = lsvListFile;
            if (ThoiGian > 0)
            {
                timer1.Interval = ThoiGian * 1000;
            }
            else
            {
                timer1.Interval = 1000;
            }
            ChoPhepLap = choPhepLap;
            ChayNgauNhien = chayNgauNhien;
        }
        static int count = 0;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (ChoPhepLap == 1 && ChayNgauNhien ==0)
            {
                if (count < lsvListFile.Items.Count)
                {
                    pbSlide.ImageLocation = lsvListFile.Items[count].SubItems[1].Text;
                    count++;
                }
                else
                {
                    count = 0;
                }
            }
            if (ChayNgauNhien == 1 && ChoPhepLap ==0)
            {
                //MessageBox.Show("Chạy ngẫu nhiên");
                Random r = new Random();
                count = r.Next(0, lsvListFile.Items.Count);
                pbSlide.ImageLocation = lsvListFile.Items[count].SubItems[1].Text;
            }
        }
    }
}
