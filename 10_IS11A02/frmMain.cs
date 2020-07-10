using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTN_10_SO_26
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuNoiThat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DMNoiThat f1 = new DMNoiThat();
            f1.Show();
        }

        private void mnuTheLoai_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTheLoai f1 = new frmTheLoai();
            f1.Show();
        }

        private void mnuKieuDang_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKieuDang f1 = new frmKieuDang();
            f1.Show();
        }

        private void mnuMauSac_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMauSac f1= new frmMauSac();
            f1.Show();
        }

        private void mnuChatLieu_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChatLieu f1 = new frmChatLieu();
            f1.Show();
        }

        private void mnuNhaCungCap_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f1 = new frmNhaCungCap();
            f1.Show();
        }

        private void mnuKhachHang_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang f1 = new frmKhachHang();
            f1.Show();
        }

        private void mnuNhanVien_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien f1 = new frmNhanVien();
            f1.Show();
        }

        private void mnuCongViec_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCongViec f1 = new frmCongViec();
            f1.Show();
        }

        private void mnuNuocSanXuat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuocSX f1 = new frmNuocSX();
            f1.Show();
        }

        private void mnuCaLam_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCaLam f1 = new frmCaLam();
            f1.Show();
        }

        private void mnuHoaĐonNhap_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonNhap f1 = new frmHoaDonNhap();
            f1.Show();
        }

        private void mnuHoaDonDatHang_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonDatHang f1 = new frmHoaDonDatHang();
            f1.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void mnuTimKiemSP_Click(object sender, EventArgs e)
        {
            frmTimKiemSanPham f1 = new frmTimKiemSanPham();
            f1.Show();
        }

        private void mnuTimKiemHDB_Click(object sender, EventArgs e)
        {
            frmTimKiemHDB f1 = new frmTimKiemHDB();
            f1.Show();
        }

        private void mnuDSSPBanDuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoDSSPBanDuoc f1 = new frmBaoCaoDSSPBanDuoc();
            f1.Show();
        }

        private void mnuDSHĐVaTTNhap_Click(object sender, EventArgs e)
        {
            frmBaoCaoDSHDVaTTNhapHang f1 = new frmBaoCaoDSHDVaTTNhapHang();
            f1.Show();
        }

        private void mnuDSHĐvaTTBan_Click(object sender, EventArgs e)
        {
            frmBaoCaoDSHDVaTTBan f1 = new frmBaoCaoDSHDVaTTBan();
            f1.Show();
        }

        private void mnuDSNhaCungCap_Click(object sender, EventArgs e)
        {
            frmBaoCaoDSHoTenNCC f1 = new frmBaoCaoDSHoTenNCC();
            f1.Show();
        }
    }
}
