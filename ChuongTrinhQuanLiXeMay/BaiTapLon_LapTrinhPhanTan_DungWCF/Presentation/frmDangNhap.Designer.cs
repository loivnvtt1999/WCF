namespace Presentation
{
    partial class frmDangNhap
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbThongTinDangNhap = new System.Windows.Forms.GroupBox();
            this.linklblQuenMK = new System.Windows.Forms.LinkLabel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.tbxMatKhau = new System.Windows.Forms.TextBox();
            this.tbxTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbThongTinDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Presentation.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 156);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbThongTinDangNhap
            // 
            this.gbThongTinDangNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbThongTinDangNhap.Controls.Add(this.linklblQuenMK);
            this.gbThongTinDangNhap.Controls.Add(this.btnThoat);
            this.gbThongTinDangNhap.Controls.Add(this.btnDangNhap);
            this.gbThongTinDangNhap.Controls.Add(this.tbxMatKhau);
            this.gbThongTinDangNhap.Controls.Add(this.tbxTaiKhoan);
            this.gbThongTinDangNhap.Controls.Add(this.lblMatKhau);
            this.gbThongTinDangNhap.Controls.Add(this.lblTaiKhoan);
            this.gbThongTinDangNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbThongTinDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinDangNhap.Location = new System.Drawing.Point(0, 168);
            this.gbThongTinDangNhap.Name = "gbThongTinDangNhap";
            this.gbThongTinDangNhap.Size = new System.Drawing.Size(605, 202);
            this.gbThongTinDangNhap.TabIndex = 1;
            this.gbThongTinDangNhap.TabStop = false;
            this.gbThongTinDangNhap.Text = "Thông tin đăng nhập";
            this.gbThongTinDangNhap.Enter += new System.EventHandler(this.gbThongTinDangNhap_Enter);
            // 
            // linklblQuenMK
            // 
            this.linklblQuenMK.AutoSize = true;
            this.linklblQuenMK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblQuenMK.Location = new System.Drawing.Point(249, 170);
            this.linklblQuenMK.Name = "linklblQuenMK";
            this.linklblQuenMK.Size = new System.Drawing.Size(116, 19);
            this.linklblQuenMK.TabIndex = 5;
            this.linklblQuenMK.TabStop = true;
            this.linklblQuenMK.Text = "Quên mật khẩu";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(317, 126);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 41);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDangNhap.Location = new System.Drawing.Point(144, 126);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(151, 41);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // tbxMatKhau
            // 
            this.tbxMatKhau.Location = new System.Drawing.Point(225, 81);
            this.tbxMatKhau.Name = "tbxMatKhau";
            this.tbxMatKhau.Size = new System.Drawing.Size(280, 30);
            this.tbxMatKhau.TabIndex = 2;
            this.tbxMatKhau.Text = "123";
            // 
            // tbxTaiKhoan
            // 
            this.tbxTaiKhoan.Location = new System.Drawing.Point(225, 33);
            this.tbxTaiKhoan.Name = "tbxTaiKhoan";
            this.tbxTaiKhoan.Size = new System.Drawing.Size(280, 30);
            this.tbxTaiKhoan.TabIndex = 2;
            this.tbxTaiKhoan.Text = "NV0001";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(111, 88);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(91, 23);
            this.lblMatKhau.TabIndex = 1;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(105, 40);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(95, 23);
            this.lblTaiKhoan.TabIndex = 0;
            this.lblTaiKhoan.Text = "Tài khoản";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 370);
            this.Controls.Add(this.gbThongTinDangNhap);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbThongTinDangNhap.ResumeLayout(false);
            this.gbThongTinDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbThongTinDangNhap;
        private System.Windows.Forms.LinkLabel linklblQuenMK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox tbxMatKhau;
        private System.Windows.Forms.TextBox tbxTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTaiKhoan;
    }
}