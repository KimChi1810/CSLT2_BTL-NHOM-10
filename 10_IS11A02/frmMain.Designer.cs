namespace BTN_10_SO_26
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNoiThat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTheLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKieuDang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMauSac = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChatLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCongViec = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCaLam = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNuocSanXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDonDatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiemSP = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiemHĐB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSSPBanDuocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSHĐVaTTNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSHĐvaTTBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc,
            this.mnuHoaDon,
            this.mnuTimKiem,
            this.mnuBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNoiThat,
            this.mnuTheLoai,
            this.mnuKieuDang,
            this.mnuMauSac,
            this.mnuChatLieu,
            this.mnuNhaCungCap,
            this.mnuKhachHang,
            this.mnuNhanVien,
            this.mnuCongViec,
            this.mnuCaLam,
            this.mnuNuocSanXuat});
            this.mnuDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(78, 21);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuNoiThat
            // 
            this.mnuNoiThat.Name = "mnuNoiThat";
            this.mnuNoiThat.Size = new System.Drawing.Size(160, 22);
            this.mnuNoiThat.Text = "Nội thất";
            this.mnuNoiThat.Click += new System.EventHandler(this.mnuNoiThat_ToolStripMenuItem_Click);
            // 
            // mnuTheLoai
            // 
            this.mnuTheLoai.Name = "mnuTheLoai";
            this.mnuTheLoai.Size = new System.Drawing.Size(160, 22);
            this.mnuTheLoai.Text = "Thể loại";
            this.mnuTheLoai.Click += new System.EventHandler(this.mnuTheLoai_ToolStripMenuItem_Click);
            // 
            // mnuKieuDang
            // 
            this.mnuKieuDang.Name = "mnuKieuDang";
            this.mnuKieuDang.Size = new System.Drawing.Size(160, 22);
            this.mnuKieuDang.Text = "Kiểu dáng";
            this.mnuKieuDang.Click += new System.EventHandler(this.mnuKieuDang_ToolStripMenuItem_Click);
            // 
            // mnuMauSac
            // 
            this.mnuMauSac.Name = "mnuMauSac";
            this.mnuMauSac.Size = new System.Drawing.Size(160, 22);
            this.mnuMauSac.Text = "Màu sắc ";
            this.mnuMauSac.Click += new System.EventHandler(this.mnuMauSac_ToolStripMenuItem_Click);
            // 
            // mnuChatLieu
            // 
            this.mnuChatLieu.Name = "mnuChatLieu";
            this.mnuChatLieu.Size = new System.Drawing.Size(160, 22);
            this.mnuChatLieu.Text = "Chất liệu";
            this.mnuChatLieu.Click += new System.EventHandler(this.mnuChatLieu_ToolStripMenuItem_Click);
            // 
            // mnuNhaCungCap
            // 
            this.mnuNhaCungCap.Name = "mnuNhaCungCap";
            this.mnuNhaCungCap.Size = new System.Drawing.Size(160, 22);
            this.mnuNhaCungCap.Text = "Nhà cung cấp";
            this.mnuNhaCungCap.Click += new System.EventHandler(this.mnuNhaCungCap_ToolStripMenuItem_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(160, 22);
            this.mnuKhachHang.Text = "Khách hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_ToolStripMenuItem_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(160, 22);
            this.mnuNhanVien.Text = "Nhân viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_ToolStripMenuItem_Click);
            // 
            // mnuCongViec
            // 
            this.mnuCongViec.Name = "mnuCongViec";
            this.mnuCongViec.Size = new System.Drawing.Size(160, 22);
            this.mnuCongViec.Text = "Công việc";
            this.mnuCongViec.Click += new System.EventHandler(this.mnuCongViec_ToolStripMenuItem_Click);
            // 
            // mnuCaLam
            // 
            this.mnuCaLam.Name = "mnuCaLam";
            this.mnuCaLam.Size = new System.Drawing.Size(160, 22);
            this.mnuCaLam.Text = "Ca làm";
            this.mnuCaLam.Click += new System.EventHandler(this.mnuCaLam_ToolStripMenuItem1_Click);
            // 
            // mnuNuocSanXuat
            // 
            this.mnuNuocSanXuat.Name = "mnuNuocSanXuat";
            this.mnuNuocSanXuat.Size = new System.Drawing.Size(160, 22);
            this.mnuNuocSanXuat.Text = "Nước sản xuất";
            this.mnuNuocSanXuat.Click += new System.EventHandler(this.mnuNuocSanXuat_ToolStripMenuItem_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoaDonNhap,
            this.mnuHoaDonDatHang});
            this.mnuHoaDon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(71, 21);
            this.mnuHoaDon.Text = "Hóa đơn";
            // 
            // mnuHoaDonNhap
            // 
            this.mnuHoaDonNhap.Name = "mnuHoaDonNhap";
            this.mnuHoaDonNhap.Size = new System.Drawing.Size(193, 22);
            this.mnuHoaDonNhap.Text = "Hóa đơn nhập hàng";
            this.mnuHoaDonNhap.Click += new System.EventHandler(this.mnuHoaĐonNhap_ToolStripMenuItem_Click);
            // 
            // mnuHoaDonDatHang
            // 
            this.mnuHoaDonDatHang.Name = "mnuHoaDonDatHang";
            this.mnuHoaDonDatHang.Size = new System.Drawing.Size(193, 22);
            this.mnuHoaDonDatHang.Text = "Hóa đơn đặt hàng";
            this.mnuHoaDonDatHang.Click += new System.EventHandler(this.mnuHoaDonDatHang_ToolStripMenuItem_Click);
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTimKiemSP,
            this.mnuTimKiemHĐB});
            this.mnuTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(72, 21);
            this.mnuTimKiem.Text = "Tìm kiếm";
            // 
            // mnuTimKiemSP
            // 
            this.mnuTimKiemSP.Name = "mnuTimKiemSP";
            this.mnuTimKiemSP.Size = new System.Drawing.Size(207, 22);
            this.mnuTimKiemSP.Text = "Tìm kiếm sản phẩm";
            this.mnuTimKiemSP.Click += new System.EventHandler(this.mnuTimKiemSP_Click);
            // 
            // mnuTimKiemHĐB
            // 
            this.mnuTimKiemHĐB.Name = "mnuTimKiemHĐB";
            this.mnuTimKiemHĐB.Size = new System.Drawing.Size(207, 22);
            this.mnuTimKiemHĐB.Text = "Tìm kiếm hóa đơn bán";
            this.mnuTimKiemHĐB.Click += new System.EventHandler(this.mnuTimKiemHDB_Click);
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDSSPBanDuocToolStripMenuItem,
            this.mnuDSHĐVaTTNhap,
            this.mnuDSHĐvaTTBan,
            this.mnuDSNhaCungCap});
            this.mnuBaoCao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(67, 21);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuDSSPBanDuocToolStripMenuItem
            // 
            this.mnuDSSPBanDuocToolStripMenuItem.Name = "mnuDSSPBanDuocToolStripMenuItem";
            this.mnuDSSPBanDuocToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.mnuDSSPBanDuocToolStripMenuItem.Text = "Danh sách các sản phẩm bán được";
            this.mnuDSSPBanDuocToolStripMenuItem.Click += new System.EventHandler(this.mnuDSSPBanDuocToolStripMenuItem_Click);
            // 
            // mnuDSHĐVaTTNhap
            // 
            this.mnuDSHĐVaTTNhap.Name = "mnuDSHĐVaTTNhap";
            this.mnuDSHĐVaTTNhap.Size = new System.Drawing.Size(328, 22);
            this.mnuDSHĐVaTTNhap.Text = "Danh sách hoá đơn và tổng tiền nhập hàng";
            this.mnuDSHĐVaTTNhap.Click += new System.EventHandler(this.mnuDSHĐVaTTNhap_Click);
            // 
            // mnuDSHĐvaTTBan
            // 
            this.mnuDSHĐvaTTBan.Name = "mnuDSHĐvaTTBan";
            this.mnuDSHĐvaTTBan.Size = new System.Drawing.Size(328, 22);
            this.mnuDSHĐvaTTBan.Text = "Danh sách hoá đơn và tổng tiền bán hàng";
            this.mnuDSHĐvaTTBan.Click += new System.EventHandler(this.mnuDSHĐvaTTBan_Click);
            // 
            // mnuDSNhaCungCap
            // 
            this.mnuDSNhaCungCap.Name = "mnuDSNhaCungCap";
            this.mnuDSNhaCungCap.Size = new System.Drawing.Size(328, 22);
            this.mnuDSNhaCungCap.Text = "Danh sách họ tên của các nhà cung cấp";
            this.mnuDSNhaCungCap.Click += new System.EventHandler(this.mnuDSNhaCungCap_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThoat.Location = new System.Drawing.Point(590, 367);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::BTN_10_SO_26.Properties.Resources.Nội_thất1;
            this.ClientSize = new System.Drawing.Size(699, 410);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Chương trình quản lý cửa hàng nội thất";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDonNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDonDatHang;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiemSP;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiemHĐB;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuDSSPBanDuocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDSHĐVaTTNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDSHĐvaTTBan;
        private System.Windows.Forms.ToolStripMenuItem mnuDSNhaCungCap;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuNoiThat;
        private System.Windows.Forms.ToolStripMenuItem mnuTheLoai;
        private System.Windows.Forms.ToolStripMenuItem mnuKieuDang;
        private System.Windows.Forms.ToolStripMenuItem mnuMauSac;
        private System.Windows.Forms.ToolStripMenuItem mnuChatLieu;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuCongViec;
        private System.Windows.Forms.ToolStripMenuItem mnuCaLam;
        private System.Windows.Forms.ToolStripMenuItem mnuNuocSanXuat;
        private System.Windows.Forms.Button btnThoat;
    }
}