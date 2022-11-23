using System.Net.Http.Headers;

namespace sliderproject
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

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            var exts = new String[] { ".png", ".jpg", ".jpeg", ".gif" };
            
            //chon thu muc
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            var rs = dialog.ShowDialog();
            if ( rs == DialogResult.OK)
            {
                txtFolderPath.Text = dialog.SelectedPath;
                lsvListFile.Items.Clear();
                //Lay thong tin cua thu muc do
                DirectoryInfo directory = new DirectoryInfo(dialog.SelectedPath);
                
                //Lay danh sach file trong thu muc do (ko tinh cac thu muc con)
                var listFile = directory.GetFiles();
                
                //Show danh sach file ra listview
                foreach(var file in listFile)
                {
                    if (exts.Contains(file.Extension.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(file.Name);
                        item.SubItems.Add(file.FullName);
                        item.SubItems.Add(file.Length.ToString());

                        lsvListFile.Items.Add(item);
                    }
                    
                }

            }
        }

        private void lsvListFile_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (lsvListFile.SelectedItems.Count > 0)
            {
                var item = lsvListFile.SelectedItems[0];
                MessageBox.Show($"{item.SubItems[]}");
            }*/
            
        }

        private void lsvListFile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Ten file so [0], path so [1], size so [2]
            var selectedItems = lsvListFile.SelectedItems[0];

            var imagePath = selectedItems.SubItems[1].Text;

            imageForm f = new imageForm(imagePath);
            f.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
          /*  var lstImagePath = new List<string>();
            for(int i=0; i<lsvListFile.Items.Count; i++)
            {
                lstImagePath.Add(lsvListFile.Items[i].SubItems[2].Text);
            }

            for (int i = 0; i < lsvListFile.Items.Count; i++)
            {
                MessageBox.Show($"{lsvListFile.Items[i].SubItems[1].Text}");
            }*/
           frmSlideShow fr = new frmSlideShow(lsvListFile);
           fr.ShowDialog();
        }
    }
}