namespace Presentation
{
    partial class frmNhanVien
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
            this.gbThongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.cBTrangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.dPTNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.tbxCMND = new System.Windows.Forms.TextBox();
            this.tbxTenNhanVien = new System.Windows.Forms.TextBox();
            this.tbxMaNhanVien = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.gbDanhSachNhanVien = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tbxTimKiemNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbThongTinNhanVien.SuspendLayout();
            this.gbDanhSachNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongTinNhanVien
            // 
            this.gbThongTinNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbThongTinNhanVien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbThongTinNhanVien.Controls.Add(this.cBTrangThai);
            this.gbThongTinNhanVien.Controls.Add(this.label1);
            this.gbThongTinNhanVien.Controls.Add(this.cbChucVu);
            this.gbThongTinNhanVien.Controls.Add(this.dPTNgaySinh);
            this.gbThongTinNhanVien.Controls.Add(this.lblNgaySinh);
            this.gbThongTinNhanVien.Controls.Add(this.tbxEmail);
            this.gbThongTinNhanVien.Controls.Add(this.tbxSoDienThoai);
            this.gbThongTinNhanVien.Controls.Add(this.lblChucVu);
            this.gbThongTinNhanVien.Controls.Add(this.lblEmail);
            this.gbThongTinNhanVien.Controls.Add(this.lblSoDienThoai);
            this.gbThongTinNhanVien.Controls.Add(this.tbxCMND);
            this.gbThongTinNhanVien.Controls.Add(this.tbxTenNhanVien);
            this.gbThongTinNhanVien.Controls.Add(this.tbxMaNhanVien);
            this.gbThongTinNhanVien.Controls.Add(this.lblCMND);
            this.gbThongTinNhanVien.Controls.Add(this.lblTenNhanVien);
            this.gbThongTinNhanVien.Controls.Add(this.lblMaNhanVien);
            this.gbThongTinNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbThongTinNhanVien.Location = new System.Drawing.Point(13, 22);
            this.gbThongTinNhanVien.Name = "gbThongTinNhanVien";
            this.gbThongTinNhanVien.Size = new System.Drawing.Size(1068, 141);
            this.gbThongTinNhanVien.TabIndex = 0;
            this.gbThongTinNhanVien.TabStop = false;
            this.gbThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // cBTrangThai
            // 
            this.cBTrangThai.FormattingEnabled = true;
            this.cBTrangThai.Location = new System.Drawing.Point(514, 97);
            this.cBTrangThai.Name = "cBTrangThai";
            this.cBTrangThai.Size = new System.Drawing.Size(216, 30);
            this.cBTrangThai.TabIndex = 12;
            this.cBTrangThai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cBTrangThai_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Trạng thái";
            // 
            // cbChucVu
            // 
            this.cbChucVu.Enabled = false;
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(853, 60);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(210, 30);
            this.cbChucVu.TabIndex = 10;
            this.cbChucVu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbChucVu_KeyDown);
            // 
            // dPTNgaySinh
            // 
            this.dPTNgaySinh.Enabled = false;
            this.dPTNgaySinh.Location = new System.Drawing.Point(853, 22);
            this.dPTNgaySinh.Name = "dPTNgaySinh";
            this.dPTNgaySinh.Size = new System.Drawing.Size(210, 30);
            this.dPTNgaySinh.TabIndex = 9;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(759, 30);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(88, 22);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Enabled = false;
            this.tbxEmail.Location = new System.Drawing.Point(514, 60);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(216, 30);
            this.tbxEmail.TabIndex = 7;
            // 
            // tbxSoDienThoai
            // 
            this.tbxSoDienThoai.Enabled = false;
            this.tbxSoDienThoai.Location = new System.Drawing.Point(514, 22);
            this.tbxSoDienThoai.Name = "tbxSoDienThoai";
            this.tbxSoDienThoai.Size = new System.Drawing.Size(216, 30);
            this.tbxSoDienThoai.TabIndex = 7;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(771, 68);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(76, 22);
            this.lblChucVu.TabIndex = 6;
            this.lblChucVu.Text = "Chức vụ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(445, 68);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 22);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(394, 30);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(114, 22);
            this.lblSoDienThoai.TabIndex = 4;
            this.lblSoDienThoai.Text = "Số điện thoại";
            // 
            // tbxCMND
            // 
            this.tbxCMND.Enabled = false;
            this.tbxCMND.Location = new System.Drawing.Point(171, 97);
            this.tbxCMND.Name = "tbxCMND";
            this.tbxCMND.Size = new System.Drawing.Size(210, 30);
            this.tbxCMND.TabIndex = 3;
            // 
            // tbxTenNhanVien
            // 
            this.tbxTenNhanVien.Enabled = false;
            this.tbxTenNhanVien.Location = new System.Drawing.Point(171, 60);
            this.tbxTenNhanVien.Name = "tbxTenNhanVien";
            this.tbxTenNhanVien.Size = new System.Drawing.Size(210, 30);
            this.tbxTenNhanVien.TabIndex = 3;
            // 
            // tbxMaNhanVien
            // 
            this.tbxMaNhanVien.Enabled = false;
            this.tbxMaNhanVien.Location = new System.Drawing.Point(170, 22);
            this.tbxMaNhanVien.Name = "tbxMaNhanVien";
            this.tbxMaNhanVien.Size = new System.Drawing.Size(210, 30);
            this.tbxMaNhanVien.TabIndex = 3;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(24, 105);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(134, 22);
            this.lblCMND.TabIndex = 2;
            this.lblCMND.Text = "Chứng minh thư";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Location = new System.Drawing.Point(38, 68);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(120, 22);
            this.lblTenNhanVien.TabIndex = 1;
            this.lblTenNhanVien.Text = "Tên nhân viên";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Location = new System.Drawing.Point(42, 30);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(116, 22);
            this.lblMaNhanVien.TabIndex = 0;
            this.lblMaNhanVien.Text = "Mã nhân viên";
            // 
            // gbDanhSachNhanVien
            // 
            this.gbDanhSachNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDanhSachNhanVien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbDanhSachNhanVien.Controls.Add(this.dataGridView1);
            this.gbDanhSachNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDanhSachNhanVien.Location = new System.Drawing.Point(9, 251);
            this.gbDanhSachNhanVien.Name = "gbDanhSachNhanVien";
            this.gbDanhSachNhanVien.Size = new System.Drawing.Size(1071, 389);
            this.gbDanhSachNhanVien.TabIndex = 1;
            this.gbDanhSachNhanVien.TabStop = false;
            this.gbDanhSachNhanVien.Text = "Danh sách nhân viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(427, 176);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 64);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(549, 176);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(106, 64);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(671, 176);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 64);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Thay đổi trạng thái";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(792, 176);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(106, 64);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(915, 176);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(106, 64);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::Presentation.Properties.Resources.search_icon;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.Location = new System.Drawing.Point(353, 209);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(47, 31);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // tbxTimKiemNhanVien
            // 
            this.tbxTimKiemNhanVien.Location = new System.Drawing.Point(147, 210);
            this.tbxTimKiemNhanVien.Name = "tbxTimKiemNhanVien";
            this.tbxTimKiemNhanVien.Size = new System.Drawing.Size(200, 30);
            this.tbxTimKiemNhanVien.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên nhân viên";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 634);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.tbxTimKiemNhanVien);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbDanhSachNhanVien);
            this.Controls.Add(this.gbThongTinNhanVien);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.gbThongTinNhanVien.ResumeLayout(false);
            this.gbThongTinNhanVien.PerformLayout();
            this.gbDanhSachNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTinNhanVien;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.GroupBox gbDanhSachNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.TextBox tbxCMND;
        private System.Windows.Forms.TextBox tbxTenNhanVien;
        private System.Windows.Forms.TextBox tbxMaNhanVien;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxSoDienThoai;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.DateTimePicker dPTNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox tbxTimKiemNhanVien;
        private System.Windows.Forms.ComboBox cBTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}