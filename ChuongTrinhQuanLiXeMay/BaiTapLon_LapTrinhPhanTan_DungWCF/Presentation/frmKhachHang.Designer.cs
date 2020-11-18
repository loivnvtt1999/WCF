namespace Presentation
{
    partial class frmKhachHang
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.dPTNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.tbxCMND = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbDanhSachNhanVien = new System.Windows.Forms.GroupBox();
            this.tbxTenKhachHang = new System.Windows.Forms.TextBox();
            this.tbxMaKhachHang = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.gbThongTinKhachHang = new System.Windows.Forms.GroupBox();
            this.tbxTimKiemKhachHang = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbDanhSachNhanVien.SuspendLayout();
            this.gbThongTinKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(1007, 146);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(106, 64);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dPTNgaySinh
            // 
            this.dPTNgaySinh.Enabled = false;
            this.dPTNgaySinh.Location = new System.Drawing.Point(888, 24);
            this.dPTNgaySinh.Name = "dPTNgaySinh";
            this.dPTNgaySinh.Size = new System.Drawing.Size(210, 30);
            this.dPTNgaySinh.TabIndex = 9;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(784, 29);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(88, 22);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Enabled = false;
            this.tbxEmail.Location = new System.Drawing.Point(526, 60);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(216, 30);
            this.tbxEmail.TabIndex = 7;
            // 
            // tbxSoDienThoai
            // 
            this.tbxSoDienThoai.Enabled = false;
            this.tbxSoDienThoai.Location = new System.Drawing.Point(526, 21);
            this.tbxSoDienThoai.Name = "tbxSoDienThoai";
            this.tbxSoDienThoai.Size = new System.Drawing.Size(216, 30);
            this.tbxSoDienThoai.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(457, 68);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 22);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(406, 30);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(114, 22);
            this.lblSoDienThoai.TabIndex = 4;
            this.lblSoDienThoai.Text = "Số điện thoại";
            // 
            // tbxCMND
            // 
            this.tbxCMND.Enabled = false;
            this.tbxCMND.Location = new System.Drawing.Point(888, 61);
            this.tbxCMND.Name = "tbxCMND";
            this.tbxCMND.Size = new System.Drawing.Size(210, 30);
            this.tbxCMND.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(756, 146);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 64);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(623, 146);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(106, 64);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(500, 145);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 64);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(1166, 392);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbDanhSachNhanVien
            // 
            this.gbDanhSachNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDanhSachNhanVien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbDanhSachNhanVien.Controls.Add(this.dataGridView1);
            this.gbDanhSachNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDanhSachNhanVien.Location = new System.Drawing.Point(12, 226);
            this.gbDanhSachNhanVien.Name = "gbDanhSachNhanVien";
            this.gbDanhSachNhanVien.Size = new System.Drawing.Size(1172, 421);
            this.gbDanhSachNhanVien.TabIndex = 4;
            this.gbDanhSachNhanVien.TabStop = false;
            this.gbDanhSachNhanVien.Text = "Danh sách khách hàng";
            // 
            // tbxTenKhachHang
            // 
            this.tbxTenKhachHang.Enabled = false;
            this.tbxTenKhachHang.Location = new System.Drawing.Point(182, 61);
            this.tbxTenKhachHang.Name = "tbxTenKhachHang";
            this.tbxTenKhachHang.Size = new System.Drawing.Size(210, 30);
            this.tbxTenKhachHang.TabIndex = 3;
            // 
            // tbxMaKhachHang
            // 
            this.tbxMaKhachHang.Enabled = false;
            this.tbxMaKhachHang.Location = new System.Drawing.Point(182, 23);
            this.tbxMaKhachHang.Name = "tbxMaKhachHang";
            this.tbxMaKhachHang.Size = new System.Drawing.Size(210, 30);
            this.tbxMaKhachHang.TabIndex = 3;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(752, 67);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(134, 22);
            this.lblCMND.TabIndex = 2;
            this.lblCMND.Text = "Chứng minh thư";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Location = new System.Drawing.Point(41, 68);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(131, 22);
            this.lblTenKhachHang.TabIndex = 1;
            this.lblTenKhachHang.Text = "Tên khách hàng";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(877, 146);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(106, 64);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Location = new System.Drawing.Point(43, 30);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(127, 22);
            this.lblMaKhachHang.TabIndex = 0;
            this.lblMaKhachHang.Text = "Mã khách hàng";
            // 
            // gbThongTinKhachHang
            // 
            this.gbThongTinKhachHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbThongTinKhachHang.Controls.Add(this.dPTNgaySinh);
            this.gbThongTinKhachHang.Controls.Add(this.lblNgaySinh);
            this.gbThongTinKhachHang.Controls.Add(this.tbxEmail);
            this.gbThongTinKhachHang.Controls.Add(this.tbxSoDienThoai);
            this.gbThongTinKhachHang.Controls.Add(this.lblEmail);
            this.gbThongTinKhachHang.Controls.Add(this.lblSoDienThoai);
            this.gbThongTinKhachHang.Controls.Add(this.tbxCMND);
            this.gbThongTinKhachHang.Controls.Add(this.tbxTenKhachHang);
            this.gbThongTinKhachHang.Controls.Add(this.tbxMaKhachHang);
            this.gbThongTinKhachHang.Controls.Add(this.lblCMND);
            this.gbThongTinKhachHang.Controls.Add(this.lblTenKhachHang);
            this.gbThongTinKhachHang.Controls.Add(this.lblMaKhachHang);
            this.gbThongTinKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbThongTinKhachHang.Location = new System.Drawing.Point(14, 12);
            this.gbThongTinKhachHang.Name = "gbThongTinKhachHang";
            this.gbThongTinKhachHang.Size = new System.Drawing.Size(1152, 108);
            this.gbThongTinKhachHang.TabIndex = 3;
            this.gbThongTinKhachHang.TabStop = false;
            this.gbThongTinKhachHang.Text = "Thông tin khách hàng";
            // 
            // tbxTimKiemKhachHang
            // 
            this.tbxTimKiemKhachHang.Location = new System.Drawing.Point(153, 181);
            this.tbxTimKiemKhachHang.Name = "tbxTimKiemKhachHang";
            this.tbxTimKiemKhachHang.Size = new System.Drawing.Size(200, 30);
            this.tbxTimKiemKhachHang.TabIndex = 19;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::Presentation.Properties.Resources.search_icon;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.Location = new System.Drawing.Point(369, 181);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(47, 31);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tên khách hàng";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1189, 659);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.tbxTimKiemKhachHang);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbDanhSachNhanVien);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.gbThongTinKhachHang);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbDanhSachNhanVien.ResumeLayout(false);
            this.gbThongTinKhachHang.ResumeLayout(false);
            this.gbThongTinKhachHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DateTimePicker dPTNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox tbxCMND;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbDanhSachNhanVien;
        private System.Windows.Forms.TextBox tbxTenKhachHang;
        private System.Windows.Forms.TextBox tbxMaKhachHang;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.GroupBox gbThongTinKhachHang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox tbxTimKiemKhachHang;
        private System.Windows.Forms.Label label1;
    }
}