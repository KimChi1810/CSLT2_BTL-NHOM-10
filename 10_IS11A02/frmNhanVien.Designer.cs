namespace BTN_10_SO_26
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
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.GridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lbTenCV = new System.Windows.Forms.Label();
            this.lbMaCV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMaCa = new System.Windows.Forms.ComboBox();
            this.cmbMaCV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(538, 60);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 20);
            this.txtDiaChi.TabIndex = 87;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(538, 100);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(200, 20);
            this.txtDienThoai.TabIndex = 86;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 85;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 84;
            this.label2.Text = "Điện thoại";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(675, 405);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(52, 23);
            this.btnThoat.TabIndex = 83;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(538, 405);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(52, 23);
            this.btnLuu.TabIndex = 82;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(387, 405);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(52, 23);
            this.btnXoa.TabIndex = 81;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(224, 405);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(52, 23);
            this.btnSua.TabIndex = 80;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(65, 405);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(52, 23);
            this.btnThem.TabIndex = 79;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // GridViewNhanVien
            // 
            this.GridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChi,
            this.DienThoai,
            this.MaCa,
            this.MaCV});
            this.GridViewNhanVien.Location = new System.Drawing.Point(86, 219);
            this.GridViewNhanVien.Name = "GridViewNhanVien";
            this.GridViewNhanVien.Size = new System.Drawing.Size(641, 159);
            this.GridViewNhanVien.TabIndex = 78;
            this.GridViewNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewNhanVien_CellClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.Name = "TenNV";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // MaCa
            // 
            this.MaCa.DataPropertyName = "MaCa";
            this.MaCa.HeaderText = "Mã ca";
            this.MaCa.Name = "MaCa";
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Mã CV";
            this.MaCV.Name = "MaCV";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(140, 103);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(200, 20);
            this.txtTenNV.TabIndex = 77;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(140, 64);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(200, 20);
            this.txtMaNV.TabIndex = 76;
            // 
            // lbTenCV
            // 
            this.lbTenCV.AutoSize = true;
            this.lbTenCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenCV.Location = new System.Drawing.Point(63, 104);
            this.lbTenCV.Name = "lbTenCV";
            this.lbTenCV.Size = new System.Drawing.Size(54, 16);
            this.lbTenCV.TabIndex = 75;
            this.lbTenCV.Text = "Tên NV";
            // 
            // lbMaCV
            // 
            this.lbMaCV.AutoSize = true;
            this.lbMaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaCV.Location = new System.Drawing.Point(62, 64);
            this.lbMaCV.Name = "lbMaCV";
            this.lbMaCV.Size = new System.Drawing.Size(49, 16);
            this.lbMaCV.TabIndex = 74;
            this.lbMaCV.Text = "Mã NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 31);
            this.label1.TabIndex = 73;
            this.label1.Text = "Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 88;
            this.label4.Text = "Giới tính";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(140, 139);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(200, 20);
            this.txtGioiTinh.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 90;
            this.label5.Text = "Ngày sinh";
            // 
            // mskNgaySinh
            // 
            this.mskNgaySinh.Location = new System.Drawing.Point(140, 182);
            this.mskNgaySinh.Mask = "00/00/0000";
            this.mskNgaySinh.Name = "mskNgaySinh";
            this.mskNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.mskNgaySinh.TabIndex = 91;
            this.mskNgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(462, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 92;
            this.label6.Text = "Mã ca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(462, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 93;
            this.label7.Text = "Mã CV";
            // 
            // cmbMaCa
            // 
            this.cmbMaCa.FormattingEnabled = true;
            this.cmbMaCa.Location = new System.Drawing.Point(538, 139);
            this.cmbMaCa.Name = "cmbMaCa";
            this.cmbMaCa.Size = new System.Drawing.Size(200, 21);
            this.cmbMaCa.TabIndex = 94;
            // 
            // cmbMaCV
            // 
            this.cmbMaCV.FormattingEnabled = true;
            this.cmbMaCV.Location = new System.Drawing.Point(538, 178);
            this.cmbMaCV.Name = "cmbMaCV";
            this.cmbMaCV.Size = new System.Drawing.Size(200, 21);
            this.cmbMaCV.TabIndex = 95;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.cmbMaCV);
            this.Controls.Add(this.cmbMaCa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskNgaySinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.GridViewNhanVien);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lbTenCV);
            this.Controls.Add(this.lbMaCV);
            this.Controls.Add(this.label1);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView GridViewNhanVien;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lbTenCV;
        private System.Windows.Forms.Label lbMaCV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.MaskedTextBox mskNgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMaCa;
        private System.Windows.Forms.ComboBox cmbMaCV;
    }
}