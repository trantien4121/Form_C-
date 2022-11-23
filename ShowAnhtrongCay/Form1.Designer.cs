namespace ShowAnhtrongCay
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbbODia = new System.Windows.Forms.ComboBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lsvListFile = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ổ đĩa";
            // 
            // cbbODia
            // 
            this.cbbODia.FormattingEnabled = true;
            this.cbbODia.Location = new System.Drawing.Point(84, 20);
            this.cbbODia.Name = "cbbODia";
            this.cbbODia.Size = new System.Drawing.Size(121, 23);
            this.cbbODia.TabIndex = 1;
            this.cbbODia.SelectedIndexChanged += new System.EventHandler(this.cbbODia_SelectedIndexChanged);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(24, 69);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(266, 323);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lsvListFile
            // 
            this.lsvListFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvListFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvListFile.FullRowSelect = true;
            this.lsvListFile.GridLines = true;
            this.lsvListFile.Location = new System.Drawing.Point(306, 69);
            this.lsvListFile.MultiSelect = false;
            this.lsvListFile.Name = "lsvListFile";
            this.lsvListFile.Size = new System.Drawing.Size(459, 323);
            this.lsvListFile.TabIndex = 4;
            this.lsvListFile.UseCompatibleStateImageBehavior = false;
            this.lsvListFile.View = System.Windows.Forms.View.Details;
            this.lsvListFile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvListFile_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên File";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Path";
            this.columnHeader2.Width = 340;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(698, 414);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnSelection
            // 
            this.btnSelection.Location = new System.Drawing.Point(603, 415);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(75, 23);
            this.btnSelection.TabIndex = 6;
            this.btnSelection.Text = "...";
            this.btnSelection.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lsvListFile);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.cbbODia);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ShowAnhTrongCay";
            this.Load += new System.EventHandler(this.S);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbbODia;
        private TreeView treeView1;
        private ListView lsvListFile;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnShow;
        private Button btnSelection;
    }
}