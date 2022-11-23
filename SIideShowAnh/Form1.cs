using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIideShowAnh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int numPicture = 0; 
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[numPicture]; 
            if(imageList1.Images.Count -1 == numPicture)
            {
                numPicture = 0; 
            }
            else
            {
                numPicture++; 
            }

        }
    }
}
