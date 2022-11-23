using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowAnhtrongCay
{
    public partial class imageDesForm : Form
    {
        public imageDesForm(String path)
        {
            InitializeComponent();
            pictureBox1.ImageLocation = path;
        }

        private void imageDesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
