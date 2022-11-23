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
    public partial class imageForm : Form
    {

        public imageForm(String path)
        {
            InitializeComponent();
            pictureBox1.ImageLocation = path;
        }

        private void imageForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
