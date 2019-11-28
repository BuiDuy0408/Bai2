namespace Bai2_TruongTHPT
{
    partial class frmHuongDan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Đăng nhập");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Màn hình chính");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Quản lý giáo viên");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Quản lý học sinh");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Quản lý giảng dạy");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Các chức năng", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Giới thiệu phần mềm", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtGioiThieu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.treeView1.LineColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "gtDangNhap";
            treeNode1.Text = "Đăng nhập";
            treeNode2.Name = "gtManHinhChinh";
            treeNode2.Text = "Màn hình chính";
            treeNode3.Name = "gtGiaoVien";
            treeNode3.Text = "Quản lý giáo viên";
            treeNode4.Name = "gtHocSinh";
            treeNode4.Text = "Quản lý học sinh";
            treeNode5.Name = "gtQLGD";
            treeNode5.Text = "Quản lý giảng dạy";
            treeNode6.Name = "gtChucNang";
            treeNode6.Text = "Các chức năng";
            treeNode7.Name = "gtPhanMem";
            treeNode7.Text = "Giới thiệu phần mềm";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(196, 480);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // txtGioiThieu
            // 
            this.txtGioiThieu.BackColor = System.Drawing.SystemColors.Window;
            this.txtGioiThieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGioiThieu.Location = new System.Drawing.Point(196, 0);
            this.txtGioiThieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGioiThieu.Multiline = true;
            this.txtGioiThieu.Name = "txtGioiThieu";
            this.txtGioiThieu.Size = new System.Drawing.Size(689, 480);
            this.txtGioiThieu.TabIndex = 4;
            // 
            // frmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 480);
            this.Controls.Add(this.txtGioiThieu);
            this.Controls.Add(this.treeView1);
            this.Name = "frmHuongDan";
            this.Text = "FrmHuongDan";
            this.Load += new System.EventHandler(this.FrmHuongDan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtGioiThieu;
    }
}