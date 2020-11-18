namespace Presentation
{
    partial class frmXeMay
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
            this.tbxTenXeMay = new System.Windows.Forms.TextBox();
            this.tbxMaXeMay = new System.Windows.Forms.TextBox();
            this.lblLoaiBanh = new System.Windows.Forms.Label();
            this.lblTenXe = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMaXe = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblMauSac = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblPhanKhoi = new System.Windows.Forms.Label();
            this.gbDanhSachXeMay = new System.Windows.Forms.GroupBox();
            this.lblLoaiPhanh = new System.Windows.Forms.Label();
            this.tbxPhanKhoi = new System.Windows.Forms.TextBox();
            this.tbxMauSac = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.gbThongTinXeMay = new System.Windows.Forms.GroupBox();
            this.cBTrangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVND = new System.Windows.Forms.Label();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.tbxGiaThanh = new System.Windows.Forms.TextBox();
            this.lblGiaThanh = new System.Windows.Forms.Label();
            this.nUDsoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.cbLoaiXe = new System.Windows.Forms.ComboBox();
            this.lblLoaiXe = new System.Windows.Forms.Label();
            this.tbxLoaiBanh = new System.Windows.Forms.TextBox();
            this.tbxLoaiPhanh = new System.Windows.Forms.TextBox();
            this.tbxTimKiemXeMay = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbDanhSachXeMay.SuspendLayout();
            this.gbThongTinXeMay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDsoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(1092, 218);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(106, 64);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // tbxTenXeMay
            // 
            this.tbxTenXeMay.Location = new System.Drawing.Point(77, 61);
            this.tbxTenXeMay.Name = "tbxTenXeMay";
            this.tbxTenXeMay.Size = new System.Drawing.Size(210, 30);
            this.tbxTenXeMay.TabIndex = 3;
            // 
            // tbxMaXeMay
            // 
            this.tbxMaXeMay.Location = new System.Drawing.Point(77, 23);
            this.tbxMaXeMay.Name = "tbxMaXeMay";
            this.tbxMaXeMay.Size = new System.Drawing.Size(210, 30);
            this.tbxMaXeMay.TabIndex = 3;
            // 
            // lblLoaiBanh
            // 
            this.lblLoaiBanh.AutoSize = true;
            this.lblLoaiBanh.Location = new System.Drawing.Point(318, 111);
            this.lblLoaiBanh.Name = "lblLoaiBanh";
            this.lblLoaiBanh.Size = new System.Drawing.Size(88, 22);
            this.lblLoaiBanh.TabIndex = 2;
            this.lblLoaiBanh.Text = "Loại bánh";
            // 
            // lblTenXe
            // 
            this.lblTenXe.AutoSize = true;
            this.lblTenXe.Location = new System.Drawing.Point(14, 68);
            this.lblTenXe.Name = "lblTenXe";
            this.lblTenXe.Size = new System.Drawing.Size(63, 22);
            this.lblTenXe.TabIndex = 1;
            this.lblTenXe.Text = "Tên xe";
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
            this.dataGridView1.Size = new System.Drawing.Size(1302, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblMaXe
            // 
            this.lblMaXe.AutoSize = true;
            this.lblMaXe.Location = new System.Drawing.Point(16, 30);
            this.lblMaXe.Name = "lblMaXe";
            this.lblMaXe.Size = new System.Drawing.Size(59, 22);
            this.lblMaXe.TabIndex = 0;
            this.lblMaXe.Text = "Mã xe";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(841, 218);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 64);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Thay đổi trạng thái";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(708, 218);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(106, 64);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblMauSac
            // 
            this.lblMauSac.AutoSize = true;
            this.lblMauSac.Location = new System.Drawing.Point(3, 111);
            this.lblMauSac.Name = "lblMauSac";
            this.lblMauSac.Size = new System.Drawing.Size(76, 22);
            this.lblMauSac.TabIndex = 4;
            this.lblMauSac.Text = "Màu sắc";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(585, 217);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 64);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblPhanKhoi
            // 
            this.lblPhanKhoi.AutoSize = true;
            this.lblPhanKhoi.Location = new System.Drawing.Point(318, 30);
            this.lblPhanKhoi.Name = "lblPhanKhoi";
            this.lblPhanKhoi.Size = new System.Drawing.Size(87, 22);
            this.lblPhanKhoi.TabIndex = 5;
            this.lblPhanKhoi.Text = "Phân khối";
            // 
            // gbDanhSachXeMay
            // 
            this.gbDanhSachXeMay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbDanhSachXeMay.Controls.Add(this.dataGridView1);
            this.gbDanhSachXeMay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDanhSachXeMay.Location = new System.Drawing.Point(10, 301);
            this.gbDanhSachXeMay.Name = "gbDanhSachXeMay";
            this.gbDanhSachXeMay.Size = new System.Drawing.Size(1308, 349);
            this.gbDanhSachXeMay.TabIndex = 11;
            this.gbDanhSachXeMay.TabStop = false;
            this.gbDanhSachXeMay.Text = "Danh sách xe máy";
            // 
            // lblLoaiPhanh
            // 
            this.lblLoaiPhanh.AutoSize = true;
            this.lblLoaiPhanh.Location = new System.Drawing.Point(311, 68);
            this.lblLoaiPhanh.Name = "lblLoaiPhanh";
            this.lblLoaiPhanh.Size = new System.Drawing.Size(97, 22);
            this.lblLoaiPhanh.TabIndex = 8;
            this.lblLoaiPhanh.Text = "Loại phanh";
            // 
            // tbxPhanKhoi
            // 
            this.tbxPhanKhoi.Location = new System.Drawing.Point(408, 22);
            this.tbxPhanKhoi.Name = "tbxPhanKhoi";
            this.tbxPhanKhoi.Size = new System.Drawing.Size(216, 30);
            this.tbxPhanKhoi.TabIndex = 7;
            // 
            // tbxMauSac
            // 
            this.tbxMauSac.Location = new System.Drawing.Point(77, 104);
            this.tbxMauSac.Name = "tbxMauSac";
            this.tbxMauSac.Size = new System.Drawing.Size(210, 30);
            this.tbxMauSac.TabIndex = 7;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(962, 218);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(106, 64);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // gbThongTinXeMay
            // 
            this.gbThongTinXeMay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbThongTinXeMay.Controls.Add(this.cBTrangThai);
            this.gbThongTinXeMay.Controls.Add(this.label1);
            this.gbThongTinXeMay.Controls.Add(this.lblVND);
            this.gbThongTinXeMay.Controls.Add(this.btnNhapHang);
            this.gbThongTinXeMay.Controls.Add(this.tbxGiaThanh);
            this.gbThongTinXeMay.Controls.Add(this.lblGiaThanh);
            this.gbThongTinXeMay.Controls.Add(this.nUDsoLuong);
            this.gbThongTinXeMay.Controls.Add(this.lblSoLuong);
            this.gbThongTinXeMay.Controls.Add(this.cbLoaiXe);
            this.gbThongTinXeMay.Controls.Add(this.lblLoaiXe);
            this.gbThongTinXeMay.Controls.Add(this.tbxLoaiBanh);
            this.gbThongTinXeMay.Controls.Add(this.tbxLoaiPhanh);
            this.gbThongTinXeMay.Controls.Add(this.lblLoaiPhanh);
            this.gbThongTinXeMay.Controls.Add(this.tbxPhanKhoi);
            this.gbThongTinXeMay.Controls.Add(this.tbxMauSac);
            this.gbThongTinXeMay.Controls.Add(this.lblPhanKhoi);
            this.gbThongTinXeMay.Controls.Add(this.lblMauSac);
            this.gbThongTinXeMay.Controls.Add(this.tbxTenXeMay);
            this.gbThongTinXeMay.Controls.Add(this.tbxMaXeMay);
            this.gbThongTinXeMay.Controls.Add(this.lblLoaiBanh);
            this.gbThongTinXeMay.Controls.Add(this.lblTenXe);
            this.gbThongTinXeMay.Controls.Add(this.lblMaXe);
            this.gbThongTinXeMay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbThongTinXeMay.Location = new System.Drawing.Point(8, 12);
            this.gbThongTinXeMay.Name = "gbThongTinXeMay";
            this.gbThongTinXeMay.Size = new System.Drawing.Size(1310, 188);
            this.gbThongTinXeMay.TabIndex = 10;
            this.gbThongTinXeMay.TabStop = false;
            this.gbThongTinXeMay.Text = "Thông tin xe máy";
            // 
            // cBTrangThai
            // 
            this.cBTrangThai.FormattingEnabled = true;
            this.cBTrangThai.Location = new System.Drawing.Point(408, 147);
            this.cBTrangThai.Name = "cBTrangThai";
            this.cBTrangThai.Size = new System.Drawing.Size(216, 30);
            this.cBTrangThai.TabIndex = 20;
            this.cBTrangThai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cBTrangThai_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Trạng thái";
            // 
            // lblVND
            // 
            this.lblVND.AutoSize = true;
            this.lblVND.Location = new System.Drawing.Point(950, 112);
            this.lblVND.Name = "lblVND";
            this.lblVND.Size = new System.Drawing.Size(51, 22);
            this.lblVND.TabIndex = 18;
            this.lblVND.Text = "VNĐ";
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Location = new System.Drawing.Point(954, 65);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(99, 27);
            this.btnNhapHang.TabIndex = 17;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // tbxGiaThanh
            // 
            this.tbxGiaThanh.Location = new System.Drawing.Point(737, 104);
            this.tbxGiaThanh.Name = "tbxGiaThanh";
            this.tbxGiaThanh.Size = new System.Drawing.Size(193, 30);
            this.tbxGiaThanh.TabIndex = 16;
            // 
            // lblGiaThanh
            // 
            this.lblGiaThanh.AutoSize = true;
            this.lblGiaThanh.Location = new System.Drawing.Point(647, 110);
            this.lblGiaThanh.Name = "lblGiaThanh";
            this.lblGiaThanh.Size = new System.Drawing.Size(85, 22);
            this.lblGiaThanh.TabIndex = 15;
            this.lblGiaThanh.Text = "Giá thành";
            // 
            // nUDsoLuong
            // 
            this.nUDsoLuong.Location = new System.Drawing.Point(737, 61);
            this.nUDsoLuong.Name = "nUDsoLuong";
            this.nUDsoLuong.Size = new System.Drawing.Size(193, 30);
            this.nUDsoLuong.TabIndex = 14;
            this.nUDsoLuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nUDsoLuong_KeyDown);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(649, 70);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(82, 22);
            this.lblSoLuong.TabIndex = 13;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // cbLoaiXe
            // 
            this.cbLoaiXe.FormattingEnabled = true;
            this.cbLoaiXe.Location = new System.Drawing.Point(737, 22);
            this.cbLoaiXe.Name = "cbLoaiXe";
            this.cbLoaiXe.Size = new System.Drawing.Size(193, 30);
            this.cbLoaiXe.TabIndex = 12;
            this.cbLoaiXe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbLoaiXe_KeyDown);
            // 
            // lblLoaiXe
            // 
            this.lblLoaiXe.AutoSize = true;
            this.lblLoaiXe.Location = new System.Drawing.Point(659, 30);
            this.lblLoaiXe.Name = "lblLoaiXe";
            this.lblLoaiXe.Size = new System.Drawing.Size(69, 22);
            this.lblLoaiXe.TabIndex = 11;
            this.lblLoaiXe.Text = "Loại xe";
            // 
            // tbxLoaiBanh
            // 
            this.tbxLoaiBanh.Location = new System.Drawing.Point(408, 104);
            this.tbxLoaiBanh.Name = "tbxLoaiBanh";
            this.tbxLoaiBanh.Size = new System.Drawing.Size(216, 30);
            this.tbxLoaiBanh.TabIndex = 10;
            // 
            // tbxLoaiPhanh
            // 
            this.tbxLoaiPhanh.Location = new System.Drawing.Point(408, 60);
            this.tbxLoaiPhanh.Name = "tbxLoaiPhanh";
            this.tbxLoaiPhanh.Size = new System.Drawing.Size(216, 30);
            this.tbxLoaiPhanh.TabIndex = 9;
            // 
            // tbxTimKiemXeMay
            // 
            this.tbxTimKiemXeMay.Location = new System.Drawing.Point(75, 251);
            this.tbxTimKiemXeMay.Name = "tbxTimKiemXeMay";
            this.tbxTimKiemXeMay.Size = new System.Drawing.Size(200, 30);
            this.tbxTimKiemXeMay.TabIndex = 17;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::Presentation.Properties.Resources.search_icon;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.Location = new System.Drawing.Point(281, 252);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(47, 31);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên xe";
            // 
            // frmXeMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1330, 662);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.tbxTimKiemXeMay);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gbDanhSachXeMay);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.gbThongTinXeMay);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXeMay";
            this.Text = "frmXeMay";
            this.Load += new System.EventHandler(this.frmXeMay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbDanhSachXeMay.ResumeLayout(false);
            this.gbThongTinXeMay.ResumeLayout(false);
            this.gbThongTinXeMay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDsoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox tbxTenXeMay;
        private System.Windows.Forms.TextBox tbxMaXeMay;
        private System.Windows.Forms.Label lblLoaiBanh;
        private System.Windows.Forms.Label lblTenXe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMaXe;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblMauSac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblPhanKhoi;
        private System.Windows.Forms.GroupBox gbDanhSachXeMay;
        private System.Windows.Forms.Label lblLoaiPhanh;
        private System.Windows.Forms.TextBox tbxPhanKhoi;
        private System.Windows.Forms.TextBox tbxMauSac;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox gbThongTinXeMay;
        private System.Windows.Forms.TextBox tbxLoaiPhanh;
        private System.Windows.Forms.TextBox tbxLoaiBanh;
        private System.Windows.Forms.NumericUpDown nUDsoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.ComboBox cbLoaiXe;
        private System.Windows.Forms.Label lblLoaiXe;
        private System.Windows.Forms.TextBox tbxGiaThanh;
        private System.Windows.Forms.Label lblGiaThanh;
        private System.Windows.Forms.Label lblVND;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.TextBox tbxTimKiemXeMay;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cBTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}