using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using TreeView = System.Windows.Forms.TreeView;

namespace ShowAnhtrongCay
{
    public partial class Form1 : Form
    {
        DirectoryInfo curDir;

        public Form1()
        {
            InitializeComponent();
            foreach (var Drives in Environment.GetLogicalDrives())
            {
                DriveInfo DriveInf = new DriveInfo(Drives);
                if (DriveInf.IsReady == true)
                {
                    cbbODia.Items.Add(DriveInf.Name);
                }
            }
        }

        public String selectedOdia{
            get { return cbbODia.SelectedItem as String;}
        }
        
        private void cbbODia_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"{selectedOdia}"); 
            if (cbbODia.SelectedItem != null)
            {
                ListDirectory(treeView1, cbbODia.SelectedItem.ToString());
            }
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }
        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            try
            {
                foreach (var directory in directoryInfo.GetDirectories())
                    directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            }
            catch (Exception ex)
            {
                UnauthorizedAccessException Uaex = new UnauthorizedAccessException();
                if (ex == Uaex)
                {
                    MessageBox.Show(Uaex.Message);
                }
            }
            return directoryNode;
        }
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {
                    e.Node.Nodes.Clear();

                    //get the list of sub direcotires
                    string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());

                    foreach (string dir in dirs)
                    {
                        DirectoryInfo di = new DirectoryInfo(dir);
                        TreeNode node = new TreeNode(di.Name, 0, 1);

                        try
                        {
                            //keep the directory's full path in the tag for use later
                            node.Tag = dir;

                            //if the directory has sub directories add the place holder
                            if (di.GetDirectories().Count() > 0)
                                node.Nodes.Add(null, "...", 0, 0);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            //display a locked folder icon
                            node.ImageIndex = 12;
                            node.SelectedImageIndex = 12;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "DirectoryLister",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            e.Node.Nodes.Add(node);
                        }
                    }
                }
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           TreeNode selectedNode = treeView1.SelectedNode;
            /*if (selectedNode.Tag.GetType() == typeof(DirectoryInfo))
            {
                selectedNode.Nodes.Clear();
                DirectoryInfo dir = (DirectoryInfo)selectedNode.Tag;
                foreach(DirectoryInfo subDir in dir.GetDirectories())
                {
                    TreeNode dirNode = new TreeNode(subDir.Name);
                    dirNode.Tag = subDir;
                    dirNode.ImageIndex = 2;
                    dirNode.SelectedImageIndex=3;
                    selectedNode.Nodes.Add(dirNode);
                }
                //Hien thi tren list view
                curDir = dir;
                OpenDirectory();
            }
*/
            MessageBox.Show($"{selectedNode.FullPath}");

            var exts = new String[] { ".png", ".jpg", ".jpeg", ".gif" };

            lsvListFile.Items.Clear();
            //Lay thong tin cua thu muc do
            DirectoryInfo directory = new DirectoryInfo(selectedNode.FullPath);

            //Lay danh sach file trong thu muc do (ko tinh cac thu muc con)
            var listFile = directory.GetFiles();

            //Show danh sach file ra listview
            foreach (var file in listFile)
            {
                if (exts.Contains(file.Extension.ToLower()))
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.FullName);
                    item.SubItems.Add(file.Length.ToString());

                    lsvListFile.Items.Add(item);
                }

            }

            selectedNode.Expand();
        }

        private void OpenDirectory()
        {

            lsvListFile.Items.Clear();
            foreach (DirectoryInfo subDir in curDir.GetDirectories())
            {
                ListViewItem lvi = lsvListFile.Items.Add(subDir.Name);
                lvi.Tag = subDir;
                lvi.ImageIndex = 0;
                lvi.SubItems.Add("");
                lvi.SubItems.Add("Folder");
                lvi.SubItems.Add(subDir.LastWriteTime.ToString());
            }
            foreach (FileInfo file in curDir.GetFiles())
            {
                ListViewItem lvi = lsvListFile.Items.Add(file.Name);

                lvi.SubItems.Add(file.FullName);
                lvi.SubItems.Add(file.Length.ToString());
            }
        }
        private void lsvListFile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Ten file so [0], path so [1], size so [2]
            var selectedItems = lsvListFile.SelectedItems[0];

            var imagePath = selectedItems.SubItems[1].Text;
            
            imageDesForm f = new imageDesForm(imagePath);
            f.ShowDialog();
        }

        private void S(object sender, EventArgs e)
        {

        }
    }
}