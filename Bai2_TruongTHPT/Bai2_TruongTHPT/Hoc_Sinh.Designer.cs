namespace Bai2_TruongTHPT
{
    partial class Hoc_Sinh
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
            this.txtHoTen_HS = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMa_HS = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbGT_HS = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaySinh_HS = new System.Windows.Forms.DateTimePicker();
            this.txtPhuHuynh = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu_HS = new System.Windows.Forms.Button();
            this.btnXoa_HS = new System.Windows.Forms.Button();
            this.btnSua_HS = new System.Windows.Forms.Button();
            this.btnThem_HS = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTK_HS = new System.Windows.Forms.TextBox();
            this.cbTK_HS = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHoTen_HS
            // 
            this.txtHoTen_HS.Location = new System.Drawing.Point(155, 91);
            this.txtHoTen_HS.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen_HS.Name = "txtHoTen_HS";
            this.txtHoTen_HS.Size = new System.Drawing.Size(235, 22);
            this.txtHoTen_HS.TabIndex = 54;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 97);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 17);
            this.label15.TabIndex = 53;
            this.label15.Text = "Họ Tên";
            // 
            // txtMa_HS
            // 
            this.txtMa_HS.Enabled = false;
            this.txtMa_HS.Location = new System.Drawing.Point(155, 32);
            this.txtMa_HS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMa_HS.Name = "txtMa_HS";
            this.txtMa_HS.Size = new System.Drawing.Size(235, 22);
            this.txtMa_HS.TabIndex = 52;
            this.txtMa_HS.TextChanged += new System.EventHandler(this.TxtMa_HS_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 36);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 17);
            this.label16.TabIndex = 51;
            this.label16.Text = "Mã HS";
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(155, 208);
            this.cbLop.Margin = new System.Windows.Forms.Padding(4);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(235, 24);
            this.cbLop.TabIndex = 58;
            // 
            // cbGT_HS
            // 
            this.cbGT_HS.FormattingEnabled = true;
            this.cbGT_HS.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbGT_HS.Location = new System.Drawing.Point(155, 147);
            this.cbGT_HS.Margin = new System.Windows.Forms.Padding(4);
            this.cbGT_HS.Name = "cbGT_HS";
            this.cbGT_HS.Size = new System.Drawing.Size(235, 24);
            this.cbGT_HS.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 218);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "Lớp";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 156);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 55;
            this.label14.Text = "Giới Tính";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(542, 140);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(235, 22);
            this.txtDiaChi.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "Địa Chỉ";
            // 
            // dtpNgaySinh_HS
            // 
            this.dtpNgaySinh_HS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh_HS.Location = new System.Drawing.Point(542, 85);
            this.dtpNgaySinh_HS.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinh_HS.Name = "dtpNgaySinh_HS";
            this.dtpNgaySinh_HS.Size = new System.Drawing.Size(235, 22);
            this.dtpNgaySinh_HS.TabIndex = 68;
            // 
            // txtPhuHuynh
            // 
            this.txtPhuHuynh.Location = new System.Drawing.Point(542, 31);
            this.txtPhuHuynh.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhuHuynh.Name = "txtPhuHuynh";
            this.txtPhuHuynh.Size = new System.Drawing.Size(235, 22);
            this.txtPhuHuynh.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(430, 35);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 17);
            this.label12.TabIndex = 65;
            this.label12.Text = "Phụ Huynh";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(430, 89);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 66;
            this.label13.Text = "Ngày Sinh";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(1022, 150);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 42);
            this.btnHuy.TabIndex = 75;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu_HS
            // 
            this.btnLuu_HS.Location = new System.Drawing.Point(1022, 91);
            this.btnLuu_HS.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu_HS.Name = "btnLuu_HS";
            this.btnLuu_HS.Size = new System.Drawing.Size(100, 42);
            this.btnLuu_HS.TabIndex = 74;
            this.btnLuu_HS.Text = "Lưu";
            this.btnLuu_HS.UseVisualStyleBackColor = true;
            // 
            // btnXoa_HS
            // 
            this.btnXoa_HS.Location = new System.Drawing.Point(1022, 32);
            this.btnXoa_HS.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa_HS.Name = "btnXoa_HS";
            this.btnXoa_HS.Size = new System.Drawing.Size(100, 42);
            this.btnXoa_HS.TabIndex = 73;
            this.btnXoa_HS.Text = "Xóa";
            this.btnXoa_HS.UseVisualStyleBackColor = true;
            // 
            // btnSua_HS
            // 
            this.btnSua_HS.Location = new System.Drawing.Point(897, 91);
            this.btnSua_HS.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua_HS.Name = "btnSua_HS";
            this.btnSua_HS.Size = new System.Drawing.Size(100, 42);
            this.btnSua_HS.TabIndex = 72;
            this.btnSua_HS.Text = "Sửa";
            this.btnSua_HS.UseVisualStyleBackColor = true;
            // 
            // btnThem_HS
            // 
            this.btnThem_HS.Location = new System.Drawing.Point(897, 32);
            this.btnThem_HS.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem_HS.Name = "btnThem_HS";
            this.btnThem_HS.Size = new System.Drawing.Size(100, 42);
            this.btnThem_HS.TabIndex = 71;
            this.btnThem_HS.Text = "Thêm";
            this.btnThem_HS.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 300);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 78;
            this.label9.Text = "Tìm kiếm";
            // 
            // txtTK_HS
            // 
            this.txtTK_HS.Location = new System.Drawing.Point(465, 292);
            this.txtTK_HS.Margin = new System.Windows.Forms.Padding(4);
            this.txtTK_HS.Name = "txtTK_HS";
            this.txtTK_HS.Size = new System.Drawing.Size(316, 22);
            this.txtTK_HS.TabIndex = 77;
            // 
            // cbTK_HS
            // 
            this.cbTK_HS.FormattingEnabled = true;
            this.cbTK_HS.Items.AddRange(new object[] {
            "Mã",
            "Họ Tên"});
            this.cbTK_HS.Location = new System.Drawing.Point(155, 290);
            this.cbTK_HS.Margin = new System.Windows.Forms.Padding(4);
            this.cbTK_HS.Name = "cbTK_HS";
            this.cbTK_HS.Size = new System.Drawing.Size(235, 24);
            this.cbTK_HS.TabIndex = 76;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHocSinh);
            this.groupBox1.Location = new System.Drawing.Point(1, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1120, 210);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocSinh.Location = new System.Drawing.Point(3, 18);
            this.dgvHocSinh.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.RowHeadersWidth = 51;
            this.dgvHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocSinh.Size = new System.Drawing.Size(1114, 189);
            this.dgvHocSinh.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaHS";
            this.Column1.HeaderText = "Mã HS";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "HovaTen";
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "GT";
            this.Column3.HeaderText = "GT";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "NgaySinh";
            this.Column4.HeaderText = "Ngày Sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "DiaChi";
            this.Column5.HeaderText = "Địa Chỉ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "PhuHuynh";
            this.Column6.HeaderText = "Phụ Huynh";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "TenLop";
            this.Column7.HeaderText = "Mã Lớp";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Hoc_Sinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTK_HS);
            this.Controls.Add(this.cbTK_HS);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu_HS);
            this.Controls.Add(this.btnXoa_HS);
            this.Controls.Add(this.btnSua_HS);
            this.Controls.Add(this.btnThem_HS);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgaySinh_HS);
            this.Controls.Add(this.txtPhuHuynh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.cbGT_HS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtHoTen_HS);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtMa_HS);
            this.Controls.Add(this.label16);
            this.Name = "Hoc_Sinh";
            this.Text = "Hoc_Sinh";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoTen_HS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMa_HS;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbGT_HS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh_HS;
        private System.Windows.Forms.TextBox txtPhuHuynh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu_HS;
        private System.Windows.Forms.Button btnXoa_HS;
        private System.Windows.Forms.Button btnSua_HS;
        private System.Windows.Forms.Button btnThem_HS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTK_HS;
        private System.Windows.Forms.ComboBox cbTK_HS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}