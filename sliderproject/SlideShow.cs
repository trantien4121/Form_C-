using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sliderproject
{
    public partial class frmSlideShow : Form
    {
        private ListView lsvListFile;

        public frmSlideShow()
        {
            InitializeComponent();
        }

        public frmSlideShow(ListView lsvListFile)
        {
         
            InitializeComponent();
            this.lsvListFile = lsvListFile;
    
        }
        static int count = 0; 
        private void timer1_Tick(object sender, EventArgs e)
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

        private void pbSlide_Click(object sender, EventArgs e)
        {

        }
    }
}
