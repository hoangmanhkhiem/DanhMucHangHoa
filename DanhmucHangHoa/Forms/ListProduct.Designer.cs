namespace ThuHanh4.Forms
{
    partial class ListProduct
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelFill = new System.Windows.Forms.Panel();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.guna2Panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.GridViewHangHoa = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cmbChatLieu = new System.Windows.Forms.ComboBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(912, 62);
            this.panelTop.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(350, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "HÀNG HÓA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelBottom.Controls.Add(this.btnThoat);
            this.panelBottom.Controls.Add(this.btnXoa);
            this.panelBottom.Controls.Add(this.btnSua);
            this.panelBottom.Controls.Add(this.btnThem);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 604);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(912, 50);
            this.panelBottom.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(673, 5);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(115, 35);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(462, 5);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 35);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(252, 5);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 35);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(45, 5);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelFill
            // 
            this.panelFill.BackColor = System.Drawing.Color.Gray;
            this.panelFill.Controls.Add(this.btnChonAnh);
            this.panelFill.Controls.Add(this.picImage);
            this.panelFill.Controls.Add(this.guna2Panel1);
            this.panelFill.Controls.Add(this.panel1);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 62);
            this.panelFill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(912, 542);
            this.panelFill.TabIndex = 2;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChonAnh.ForeColor = System.Drawing.Color.Black;
            this.btnChonAnh.Location = new System.Drawing.Point(419, 126);
            this.btnChonAnh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(92, 36);
            this.btnChonAnh.TabIndex = 5;
            this.btnChonAnh.Text = "Ảnh";
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picImage.Location = new System.Drawing.Point(535, 19);
            this.picImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(289, 248);
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnHuy);
            this.guna2Panel1.Controls.Add(this.GridViewHangHoa);
            this.guna2Panel1.Controls.Add(this.btnLuu);
            this.guna2Panel1.Controls.Add(this.cmbChatLieu);
            this.guna2Panel1.Controls.Add(this.txtGiaNhap);
            this.guna2Panel1.Controls.Add(this.txtGiaban);
            this.guna2Panel1.Controls.Add(this.txtSoLuong);
            this.guna2Panel1.Controls.Add(this.txtTenHang);
            this.guna2Panel1.Controls.Add(this.txtMaHang);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(912, 542);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(302, 254);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(164, 33);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // GridViewHangHoa
            // 
            this.GridViewHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewHangHoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridViewHangHoa.Location = new System.Drawing.Point(0, 292);
            this.GridViewHangHoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridViewHangHoa.Name = "GridViewHangHoa";
            this.GridViewHangHoa.RowHeadersWidth = 62;
            this.GridViewHangHoa.RowTemplate.Height = 28;
            this.GridViewHangHoa.Size = new System.Drawing.Size(912, 250);
            this.GridViewHangHoa.TabIndex = 0;
            this.GridViewHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewHangHoa_CellClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(88, 254);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(156, 33);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cmbChatLieu
            // 
            this.cmbChatLieu.FormattingEnabled = true;
            this.cmbChatLieu.Location = new System.Drawing.Point(160, 100);
            this.cmbChatLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChatLieu.Name = "cmbChatLieu";
            this.cmbChatLieu.Size = new System.Drawing.Size(195, 28);
            this.cmbChatLieu.TabIndex = 2;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(160, 184);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(195, 26);
            this.txtGiaNhap.TabIndex = 1;
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(160, 221);
            this.txtGiaban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(195, 26);
            this.txtGiaban.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(160, 140);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(195, 26);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(160, 61);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(195, 26);
            this.txtTenHang.TabIndex = 1;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(160, 21);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(195, 26);
            this.txtMaHang.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đơn giá bán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn giá nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chất liêu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 290);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 262);
            this.panel1.TabIndex = 0;
            // 
            // ListProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(912, 654);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListProduct";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục hàng hóa";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GridViewHangHoa;
        private System.Windows.Forms.Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbChatLieu;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}