namespace Presentation
{
    partial class frmLapHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThemKhachHang = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxSoDienThoai = new System.Windows.Forms.TextBox();
            this.tbxMaKhachHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxTenKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxChucVu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTenNhanVien = new System.Windows.Forms.TextBox();
            this.tbxMaNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cBoTrangThai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxMaHoaDon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnXoaChiTiet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxThue = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxGiaBan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nUDSoLuongXe = new System.Windows.Forms.NumericUpDown();
            this.tbxMaXe = new System.Windows.Forms.TextBox();
            this.tbxTenXe = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxTienThua = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbxThanhTien = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoLuongXe)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(81, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1075, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người dùng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThemKhachHang);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbxSoDienThoai);
            this.groupBox3.Controls.Add(this.tbxMaKhachHang);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbxTenKhachHang);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(562, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 194);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khách hàng";
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.BackgroundImage = global::Presentation.Properties.Resources.add_customer;
            this.btnThemKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemKhachHang.Location = new System.Drawing.Point(423, 80);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(49, 47);
            this.btnThemKhachHang.TabIndex = 6;
            this.btnThemKhachHang.UseVisualStyleBackColor = true;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số điện thoại";
            // 
            // tbxSoDienThoai
            // 
            this.tbxSoDienThoai.Location = new System.Drawing.Point(170, 137);
            this.tbxSoDienThoai.Name = "tbxSoDienThoai";
            this.tbxSoDienThoai.Size = new System.Drawing.Size(242, 30);
            this.tbxSoDienThoai.TabIndex = 4;
            this.tbxSoDienThoai.Leave += new System.EventHandler(this.tbxSoDienThoai_Leave);
            // 
            // tbxMaKhachHang
            // 
            this.tbxMaKhachHang.Location = new System.Drawing.Point(170, 80);
            this.tbxMaKhachHang.Name = "tbxMaKhachHang";
            this.tbxMaKhachHang.Size = new System.Drawing.Size(242, 30);
            this.tbxMaKhachHang.TabIndex = 3;
            this.tbxMaKhachHang.Leave += new System.EventHandler(this.tbxMaKhachHang_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã khách hàng";
            // 
            // tbxTenKhachHang
            // 
            this.tbxTenKhachHang.Location = new System.Drawing.Point(170, 30);
            this.tbxTenKhachHang.Name = "tbxTenKhachHang";
            this.tbxTenKhachHang.Size = new System.Drawing.Size(242, 30);
            this.tbxTenKhachHang.TabIndex = 1;
            this.tbxTenKhachHang.Leave += new System.EventHandler(this.tbxTenKhachHang_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxChucVu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbxTenNhanVien);
            this.groupBox2.Controls.Add(this.tbxMaNhanVien);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(35, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 194);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            // 
            // tbxChucVu
            // 
            this.tbxChucVu.Location = new System.Drawing.Point(143, 143);
            this.tbxChucVu.Name = "tbxChucVu";
            this.tbxChucVu.Size = new System.Drawing.Size(278, 30);
            this.tbxChucVu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên nhân viên";
            // 
            // tbxTenNhanVien
            // 
            this.tbxTenNhanVien.Location = new System.Drawing.Point(143, 89);
            this.tbxTenNhanVien.Name = "tbxTenNhanVien";
            this.tbxTenNhanVien.Size = new System.Drawing.Size(278, 30);
            this.tbxTenNhanVien.TabIndex = 2;
            // 
            // tbxMaNhanVien
            // 
            this.tbxMaNhanVien.Location = new System.Drawing.Point(143, 34);
            this.tbxMaNhanVien.Name = "tbxMaNhanVien";
            this.tbxMaNhanVien.Size = new System.Drawing.Size(278, 30);
            this.tbxMaNhanVien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.cBoTrangThai);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.tbxMaHoaDon);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(542, 207);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin hóa đơn";
            // 
            // cBoTrangThai
            // 
            this.cBoTrangThai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoTrangThai.FormattingEnabled = true;
            this.cBoTrangThai.Location = new System.Drawing.Point(178, 109);
            this.cBoTrangThai.Name = "cBoTrangThai";
            this.cBoTrangThai.Size = new System.Drawing.Size(278, 30);
            this.cBoTrangThai.TabIndex = 6;
            this.cBoTrangThai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cBoTrangThai_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 22);
            this.label9.TabIndex = 5;
            this.label9.Text = "Trạng thái";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 66);
            this.dateTimePicker1.MinDate = new System.DateTime(1753, 1, 2, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(278, 30);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ngày lập";
            // 
            // tbxMaHoaDon
            // 
            this.tbxMaHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaHoaDon.Location = new System.Drawing.Point(178, 23);
            this.tbxMaHoaDon.Name = "tbxMaHoaDon";
            this.tbxMaHoaDon.Size = new System.Drawing.Size(278, 30);
            this.tbxMaHoaDon.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã hóa đơn";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Controls.Add(this.btnXoaChiTiet);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.tbxThue);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.tbxGiaBan);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.nUDSoLuongXe);
            this.groupBox5.Controls.Add(this.tbxMaXe);
            this.groupBox5.Controls.Add(this.tbxTenXe);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(575, 254);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(669, 207);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin xe";
            // 
            // btnXoaChiTiet
            // 
            this.btnXoaChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaChiTiet.Location = new System.Drawing.Point(373, 154);
            this.btnXoaChiTiet.Name = "btnXoaChiTiet";
            this.btnXoaChiTiet.Size = new System.Drawing.Size(209, 38);
            this.btnXoaChiTiet.TabIndex = 4;
            this.btnXoaChiTiet.Text = "Xóa chi tiết";
            this.btnXoaChiTiet.UseVisualStyleBackColor = true;
            this.btnXoaChiTiet.Click += new System.EventHandler(this.btnXoaChiTiet_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(139, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thêm chi tiết";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxThue
            // 
            this.tbxThue.Enabled = false;
            this.tbxThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxThue.Location = new System.Drawing.Point(451, 67);
            this.tbxThue.Name = "tbxThue";
            this.tbxThue.Size = new System.Drawing.Size(212, 30);
            this.tbxThue.TabIndex = 8;
            this.tbxThue.Text = "0.1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(392, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 22);
            this.label14.TabIndex = 7;
            this.label14.Text = "Thuế";
            // 
            // tbxGiaBan
            // 
            this.tbxGiaBan.Enabled = false;
            this.tbxGiaBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGiaBan.Location = new System.Drawing.Point(451, 23);
            this.tbxGiaBan.Name = "tbxGiaBan";
            this.tbxGiaBan.Size = new System.Drawing.Size(212, 30);
            this.tbxGiaBan.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(369, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 22);
            this.label13.TabIndex = 5;
            this.label13.Text = "Giá bán";
            // 
            // nUDSoLuongXe
            // 
            this.nUDSoLuongXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDSoLuongXe.Location = new System.Drawing.Point(115, 109);
            this.nUDSoLuongXe.Name = "nUDSoLuongXe";
            this.nUDSoLuongXe.Size = new System.Drawing.Size(120, 30);
            this.nUDSoLuongXe.TabIndex = 4;
            // 
            // tbxMaXe
            // 
            this.tbxMaXe.Enabled = false;
            this.tbxMaXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaXe.Location = new System.Drawing.Point(115, 66);
            this.tbxMaXe.Name = "tbxMaXe";
            this.tbxMaXe.Size = new System.Drawing.Size(233, 30);
            this.tbxMaXe.TabIndex = 3;
            // 
            // tbxTenXe
            // 
            this.tbxTenXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTenXe.Location = new System.Drawing.Point(115, 23);
            this.tbxTenXe.Name = "tbxTenXe";
            this.tbxTenXe.Size = new System.Drawing.Size(233, 30);
            this.tbxTenXe.TabIndex = 3;
            this.tbxTenXe.Leave += new System.EventHandler(this.tbxTenXe_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 22);
            this.label12.TabIndex = 2;
            this.label12.Text = "Số lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tên xe";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã xe";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Location = new System.Drawing.Point(12, 478);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1232, 176);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông tin chi tiết hóa đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1226, 147);
            this.dataGridView1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(26, 687);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 22);
            this.label15.TabIndex = 4;
            this.label15.Text = "Tiền khách trả";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(170, 679);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(327, 30);
            this.textBox12.TabIndex = 5;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            this.textBox12.Leave += new System.EventHandler(this.textBox12_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(572, 724);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 22);
            this.label16.TabIndex = 6;
            this.label16.Text = "Tiền trả lại";
            // 
            // tbxTienThua
            // 
            this.tbxTienThua.Enabled = false;
            this.tbxTienThua.Location = new System.Drawing.Point(714, 716);
            this.tbxTienThua.Name = "tbxTienThua";
            this.tbxTienThua.Size = new System.Drawing.Size(374, 30);
            this.tbxTienThua.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(782, 681);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 22);
            this.label17.TabIndex = 8;
            this.label17.Text = "Thành tiền";
            // 
            // tbxThanhTien
            // 
            this.tbxThanhTien.Location = new System.Drawing.Point(880, 670);
            this.tbxThanhTien.Name = "tbxThanhTien";
            this.tbxThanhTien.Size = new System.Drawing.Size(354, 30);
            this.tbxThanhTien.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(42, 724);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 39);
            this.button2.TabIndex = 10;
            this.button2.Text = "Lưu hóa đơn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmLapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1266, 801);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbxThanhTien);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbxTienThua);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLapHoaDon";
            this.Text = "frmLapHoaDon";
            this.Load += new System.EventHandler(this.frmLapHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSoLuongXe)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTenNhanVien;
        private System.Windows.Forms.TextBox tbxMaNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemKhachHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxSoDienThoai;
        private System.Windows.Forms.TextBox tbxMaKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxTenKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxChucVu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cBoTrangThai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxMaHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnXoaChiTiet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxThue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxGiaBan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nUDSoLuongXe;
        private System.Windows.Forms.TextBox tbxMaXe;
        private System.Windows.Forms.TextBox tbxTenXe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxTienThua;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbxThanhTien;
        private System.Windows.Forms.Button button2;
    }
}