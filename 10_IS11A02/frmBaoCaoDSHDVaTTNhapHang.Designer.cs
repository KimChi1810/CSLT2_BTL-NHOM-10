namespace BTN_10_SO_26
{
    partial class frmBaoCaoDSHDVaTTNhapHang
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBaoCaoLai = new System.Windows.Forms.Button();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.GridViewBCDSHDVaTTNhap = new System.Windows.Forms.DataGridView();
            this.MaNoiThat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNoiThat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBCDSHDVaTTNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(636, 402);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(74, 23);
            this.btnThoat.TabIndex = 46;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBaoCaoLai
            // 
            this.btnBaoCaoLai.Location = new System.Drawing.Point(470, 402);
            this.btnBaoCaoLai.Name = "btnBaoCaoLai";
            this.btnBaoCaoLai.Size = new System.Drawing.Size(71, 23);
            this.btnBaoCaoLai.TabIndex = 45;
            this.btnBaoCaoLai.Text = "Báo cáo lại";
            this.btnBaoCaoLai.UseVisualStyleBackColor = true;
            this.btnBaoCaoLai.Click += new System.EventHandler(this.btnBaoCaoLai_Click);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Location = new System.Drawing.Point(288, 402);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(77, 23);
            this.btnInBaoCao.TabIndex = 44;
            this.btnInBaoCao.Text = "In báo cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(111, 402);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(69, 23);
            this.btnBaoCao.TabIndex = 43;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(174, 120);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(169, 20);
            this.txtTenNV.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Tên NV";
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(174, 83);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(169, 21);
            this.cmbMaNV.TabIndex = 40;
            this.cmbMaNV.TextChanged += new System.EventHandler(this.cmbMaNV_TextChanged);
            // 
            // GridViewBCDSHDVaTTNhap
            // 
            this.GridViewBCDSHDVaTTNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewBCDSHDVaTTNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNoiThat,
            this.TenNoiThat,
            this.MaNV,
            this.TenNV,
            this.NgayNhap,
            this.SoLuong,
            this.GiamGia,
            this.ThanhTien,
            this.TongTien});
            this.GridViewBCDSHDVaTTNhap.Location = new System.Drawing.Point(81, 173);
            this.GridViewBCDSHDVaTTNhap.Name = "GridViewBCDSHDVaTTNhap";
            this.GridViewBCDSHDVaTTNhap.Size = new System.Drawing.Size(639, 192);
            this.GridViewBCDSHDVaTTNhap.TabIndex = 39;
            this.GridViewBCDSHDVaTTNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewBCDSHDVaTTNhap_CellClick);
            // 
            // MaNoiThat
            // 
            this.MaNoiThat.DataPropertyName = "MaNoiThat";
            this.MaNoiThat.HeaderText = "Mã nội thất";
            this.MaNoiThat.Name = "MaNoiThat";
            // 
            // TenNoiThat
            // 
            this.TenNoiThat.DataPropertyName = "TenNoiThat";
            this.TenNoiThat.HeaderText = "Tên nội thất";
            this.TenNoiThat.Name = "TenNoiThat";
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
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // GiamGia
            // 
            this.GiamGia.DataPropertyName = "GiamGia";
            this.GiamGia.HeaderText = "Giảm giá";
            this.GiamGia.Name = "GiamGia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mã NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(90, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 31);
            this.label1.TabIndex = 37;
            this.label1.Text = "Báo cáo danh sách hóa đơn và tổng tiền nhập hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Quý";
            // 
            // txtQuy
            // 
            this.txtQuy.Location = new System.Drawing.Point(527, 82);
            this.txtQuy.Name = "txtQuy";
            this.txtQuy.Size = new System.Drawing.Size(169, 20);
            this.txtQuy.TabIndex = 48;
            this.txtQuy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuy_KeyPress);
            // 
            // frmBaoCaoDSHDVaTTNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtQuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBaoCaoLai);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMaNV);
            this.Controls.Add(this.GridViewBCDSHDVaTTNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBaoCaoDSHDVaTTNhapHang";
            this.Text = "Báo cáo danh sách hóa đơn và tổng tiền nhập hàng";
            this.Load += new System.EventHandler(this.frmBaoCaoDSHDVaTTNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBCDSHDVaTTNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBaoCaoLai;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private System.Windows.Forms.DataGridView GridViewBCDSHDVaTTNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNoiThat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNoiThat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuy;
    }
}