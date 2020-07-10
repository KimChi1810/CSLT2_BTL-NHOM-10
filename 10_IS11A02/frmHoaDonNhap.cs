using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace BTN_10_SO_26
{
    public partial class frmHoaDonNhap : Form
    {
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }
        private void LoadThongTinHD()
        {
            string str;
            str = "SELECT NgayNhap FROM HoaDonNhap WHERE SoHDN = N'" + txtSoHDN.Text + "'";
            mskNgayNhap.Text = DAO.ConvertDateTime(DAO.GetFieldValues(str));
            str = "SELECT MaNV FROM HoaDonNhap WHERE SoHDN = N'" + txtSoHDN.Text + "'";
            cmbMaNV.Text = DAO.GetFieldValues(str);
            str = "SELECT MaNCC FROM HoaDonNhap WHERE SoHDN = N'" + txtSoHDN.Text + "'";
            cmbMaNCC.Text = DAO.GetFieldValues(str);
            str = "SELECT Tongtien FROM HoaDonNhap WHERE SoHDN = N'" + txtSoHDN.Text + "'";
            txtTongTien.Text = DAO.GetFieldValues(str);
            lbBangChu.Text = "Bằng chữ: " + DAO.ChuyenSoSangChu(Double.Parse(txtTongTien.Text));
        }
        private void Load_ThongtinNoiThat()
        {
            string str;
            str = "Select MaNoiThat from ChiTietHoaDonNhap where SoHDN = N'" + txtSoHDN.Text + "'";
            cmbMaNoiThat.Text = DAO.GetFieldValues(str);
            str = "Select TenNoiThat from DMNoiThat as a inner join ChiTietHoaDonNhap as b on a.MaNoiThat=b.MaNoiThat where SoHDN = N'" + txtSoHDN.Text + "'";
            txtTenNoiThat.Text = DAO.GetFieldValues(str);
            str = "Select SoLuong from ChiTietHoaDonNhap where SoHDN = N'" + txtSoHDN.Text + "'";
            txtSoLuong.Text = DAO.GetFieldValues(str);
            str = "Select GiamGia from ChiTietHoaDonNhap where SoHDN = N'" + txtSoHDN.Text + "'";
            txtGiamGia.Text = DAO.GetFieldValues(str);
            str = "Select ThanhTien from ChiTietHoaDonNhap where SoHDN = N'" + txtSoHDN.Text + "'";
            txtThanhTien.Text = DAO.GetFieldValues(str);
            str = "Select DonGiaNhap from ChiTietHoaDonNhap as a inner join DMNoiThat as b on a.MaNoiThat=b.MaNoiThat where SoHDN = N'" + txtSoHDN.Text + "'";
            txtDonGia.Text = DAO.GetFieldValues(str);
        }
        public void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "Select SoHDN,a.MaNoiThat,TenNoiThat,a.SoLuong,DonGiaNhap,GiamGia,ThanhTien from ChiTietHoaDonNhap " +
                    "as a inner join DMNoiThat as b on a.MaNoiThat=b.MaNoiThat";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable table = new DataTable();
                myAdapter.Fill(table);
                GridViewHoaDonNhap.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO.CloseConnection();
            }
        }

        private void FillDataToCombo1()
        {
            string sql = " select MaNV,TenNV from NhanVien";
            DAO.OpenConnection();
            DAO.FillDataToCombo(sql, cmbMaNV, "MaNV", "MaNV");

            sql = "select MaNCC,TenNCC from NhaCungCap";
            DAO.FillDataToCombo(sql, cmbMaNCC, "MaNCC", "MaNCC");

            sql = "select MaNoiThat,TenNoiThat from DMNoiThat";
            DAO.FillDataToCombo(sql, cmbMaNoiThat, "MaNoiThat", "MaNoiThat");
        }
        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            btnThemHD.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnIn.Enabled = false;
            txtSoHDN.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtTenNCC.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtDienThoai.ReadOnly = true;
            txtTenNoiThat.ReadOnly = true;
            txtDonGia.Enabled = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtGiamGia.Text = "0";
            txtTongTien.Text = "0";
            FillDataToCombo1();
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtSoHDN.Text != "")
            {
                LoadThongTinHD();
                Load_ThongtinNoiThat();
                btnXoa.Enabled = true;
                btnIn.Enabled = true;
            }
            LoadDataToGridView();
        }
        private void ResetValues()
        {
            txtSoHDN.Text = "";
            mskNgayNhap.Text = DateTime.Now.ToShortDateString();
            cmbMaNV.Text = "";
            cmbMaNCC.Text = "";
            txtTongTien.Text = "0";
            lbBangChu.Text = "Bằng chữ: ";
            cmbMaNoiThat.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
        }
        private void ResetValuesHang()
        {
            cmbMaNoiThat.Text = "";
            //txtTenNoiThat.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
        }

        private void GridViewHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbMaNoiThat.Text = GridViewHoaDonNhap.CurrentRow.Cells["MaNoiThat"].Value.ToString();
            txtTenNoiThat.Text = GridViewHoaDonNhap.CurrentRow.Cells["TenNoiThat"].Value.ToString();
            txtSoLuong.Text = GridViewHoaDonNhap.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtDonGia.Text = GridViewHoaDonNhap.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txtGiamGia.Text = GridViewHoaDonNhap.CurrentRow.Cells["GiamGia"].Value.ToString();
            txtThanhTien.Text = GridViewHoaDonNhap.CurrentRow.Cells["ThanhTien"].Value.ToString();
            txtSoHDN.Text = DAO.CreateKey("SoHDN");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThemHD.Enabled = false;
            ResetValues();
            txtSoHDN.Text = DAO.CreateKey("SoHDN");
            LoadDataToGridView();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcapnhat, tong, Tongmoi;
            double dg, dgn, dgb;
            sql = "SELECT SoHDN FROM HoaDonNhap WHERE SoHDN=N'" + txtSoHDN.Text + "'";
            if (!DAO.CheckKeyExit(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDN được sinh tự động do đó không có trường hợp trùng khóa             
                if (cmbMaNV.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbMaNV.Focus();
                    return;
                }
                if (cmbMaNCC.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbMaNCC.Focus();
                    return;
                }
                if (mskNgayNhap.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskNgayNhap.Focus();
                    return;
                }
                //Giá nhập trong DMNoiThat tự động cập nhật khi nhập hàng
                dg = Convert.ToDouble(txtDonGia.Text);
                dgn = Convert.ToDouble(DAO.GetFieldValues("SELECT DonGiaNhap FROM DMNoiThat WHERE MaNoiThat = N'" + cmbMaNoiThat.SelectedValue + "'"));
                if (dg != dgn)
                {
                    sql = "UPDATE DMNoiThat SET DonGiaNhap =" + dg + " WHERE MaNoiThat= N'" + cmbMaNoiThat.SelectedValue + "'";
                    DAO.RunSQL(sql);
                }
                sql = "INSERT INTO HoaDonNhap(SoHDN, NgayNhap, MaNV, MaNCC, Tongtien) VALUES (N'" + txtSoHDN.Text.Trim() + "','" + DAO.ConvertDateTime(mskNgayNhap.Text.Trim()) + "',N'"
                    + cmbMaNV.SelectedValue + "',N'" + cmbMaNCC.SelectedValue + "',N'" + txtTongTien.Text + "'" + ")";
                DAO.RunSQL(sql);
                //Giá bán trong DMNoiThat tự động cập nhật khi nhập hàng
                dgb = Convert.ToDouble(DAO.GetFieldValues("SELECT DonGiaBan FROM DMNoiThat WHERE MaNoiThat = N'" + cmbMaNoiThat.SelectedValue + "'"));
                dgb = dg * 1.1;
                sql = "UPDATE DMNoiThat SET DonGiaBan =" + dgn + " WHERE MaNoiThat= N'" + cmbMaNoiThat.SelectedValue + "'";
                DAO.RunSQL(sql);
                if (cmbMaNoiThat.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã nội thất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbMaNoiThat.Focus();
                    return;
                }
                if ((txtSoLuong.Text.Trim().Length == 0) || (txtSoLuong.Text == "0"))
                {
                    MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuong.Text = "";
                    txtSoLuong.Focus();
                    return;
                }
                if (txtGiamGia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGiamGia.Focus();
                    return;
                }
                if (txtDonGia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDonGia.Focus();
                    return;
                }
                sql = "SELECT MaNoiThat FROM ChiTietHoaDonNhap WHERE MaNoiThat=N'" + cmbMaNoiThat.SelectedValue + "' AND SoHDN = N'" + txtSoHDN.Text.Trim() + "'";
                if (DAO.CheckKeyExit(sql))
                {
                    MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetValuesHang();
                    cmbMaNoiThat.Focus();
                    return;
                }
                //số lượng ở sản phẩm tự động tăng khi nhập hàng
                sl = Convert.ToDouble(DAO.GetFieldValues("SELECT SoLuong FROM DMNoiThat WHERE MaNoiThat = N'" + cmbMaNoiThat.SelectedValue + "'"));
                sql = "INSERT INTO ChiTietHoaDonNhap(SoHDN,MaNoiThat,SoLuong,DonGia, GiamGia,ThanhTien) VALUES(N'" + txtSoHDN.Text.Trim() +
                    "',N'" + cmbMaNoiThat.SelectedValue + "'," + txtSoLuong.Text + "," + txtDonGia.Text + ","
                    + txtGiamGia.Text + "," + txtThanhTien.Text + ")";
                DAO.RunSQL(sql);
                LoadDataToGridView();
                // Cập nhật lại số lượng mới vào bảng Sản phẩm
                SLcapnhat = sl + Convert.ToDouble(txtSoLuong.Text);
                sql = "UPDATE DMNoiThat SET SoLuong =" + SLcapnhat + " WHERE MaNoiThat= N'" + cmbMaNoiThat.SelectedValue + "'";
                DAO.RunSQL(sql);
                // Cập nhật lại tổng tiền cho hóa đơn nhập
                tong = Convert.ToDouble(DAO.GetFieldValues("SELECT TongTien FROM HoaDonNhap WHERE SoHDN = N'" + txtSoHDN.Text + "'"));
                Tongmoi = tong + Convert.ToDouble(txtThanhTien.Text);
                sql = "UPDATE HoaDonNhap SET TongTien =" + Tongmoi + " WHERE SoHDN = N'" + txtSoHDN.Text + "'";
                DAO.RunSQL(sql);
                txtTongTien.Text = Tongmoi.ToString();
                lbBangChu.Text = "Bằng chữ: " + DAO.ChuyenSoSangChu(Double.Parse(Tongmoi.ToString()));
                ResetValuesHang();
                btnXoa.Enabled = false;
                btnIn.Enabled = false;
                btnThemHD.Enabled = true;
                btnHuy.Enabled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmbMaNoiThat_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cmbMaNoiThat.Text == "")
            {
                txtTenNoiThat.Text = "";
                txtSoLuong.Text = "";
                txtGiamGia.Text = "";
                txtThanhTien.Text = "";
            }
            // Khi kich chon Ma nội thất thi ten nội thất,DonGiaNhap,... se tu dong hien ra
            str = "SELECT TenNoiThat FROM DMNoiThat WHERE MaNoiThat =N'" + cmbMaNoiThat.SelectedValue + "'";
            txtTenNoiThat.Text = DAO.GetFieldValues(str);
            str = "SELECT DonGiaNhap FROM DMNoiThat WHERE MaNoiThat =N'" + cmbMaNoiThat.SelectedValue + "'";
            txtDonGia.Text = DAO.GetFieldValues(str);
            
        }

        private void cmbMaNV_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cmbMaNV.Text == "")
                txtTenNV.Text = "";
            // Khi kich chon Ma nhan vien thi ten nhan vien se tu dong hien ra
            str = "Select TenNV from Nhanvien where MaNV =N'" + cmbMaNV.SelectedValue + "'";
            txtTenNV.Text = DAO.GetFieldValues(str);
            str = "SELECT NgayNhap FROM HoaDonNhap as a inner join NhanVien as b on a.MaNV=b.MaNV WHERE b.MaNV =N'" + cmbMaNV.SelectedValue + "'";
            mskNgayNhap.Text = (DAO.GetFieldValues(str));
        }

        private void cmbMaNCC_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cmbMaNCC.Text == "")
            {
                txtTenNCC.Text = "";
                txtDiaChi.Text = "";
                txtDienThoai.Text = "";
            }
            // Khi kich chon Ma NCC thi ten nhan vien se tu dong hien ra
            str = "Select TenNCC from NhaCungCap where MaNCC =N'" + cmbMaNCC.SelectedValue + "'";
            txtTenNCC.Text = DAO.GetFieldValues(str);
            str = "Select DiaChi from NhaCungCap where MaNCC =N'" + cmbMaNCC.SelectedValue + "'";
            txtDiaChi.Text = DAO.GetFieldValues(str);
            str = "Select DienThoai from NhaCungCap where MaNCC =N'" + cmbMaNCC.SelectedValue + "'";
            txtDienThoai.Text = DAO.GetFieldValues(str);
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtThanhTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtDonGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            txtSoLuong.Enabled = true;
            txtTenNoiThat.Enabled = true;
            txtGiamGia.Enabled = true;
            txtDonGia.Enabled = true;
            txtThanhTien.Enabled = true;
            // cmbMaNoiThat.Enabled = true;
            txtThanhTien.Text = "";
            txtDonGia.Text = "";
            txtGiamGia.Text = "";
            txtTenNoiThat.Text = "";
            txtSoLuong.Text = "";
            //cmbMaNoiThat.SelectedValue = -1;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cmbTim.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbTim.Focus();
                return;
            }
            txtSoHDN.Text = cmbTim.Text;
            LoadThongTinHD();
            Load_ThongtinNoiThat();
            LoadDataToGridView();
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnIn.Enabled = true;
            //btnThemHang.Enabled = true;
            btnThemHD.Enabled = true;
            cmbTim.SelectedIndex = -1;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Cửa hàng nội thất";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Hai Bà Trưng - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)37562222";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN NHẬP";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.SoHDN, a.NgayNhap, b.TenNCC, b.Dienthoai, b.Diachi, a.Tongtien, c.TenNV FROM HoaDonNhap AS a, NhaCungCap AS b, NhanVien AS c WHERE a.SoHDN = N'" + txtSoHDN.Text + "' AND a.MaNCC = b.MaNCC AND a.MaNV = c.MaNV";
            tblThongtinHD = DAO.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Nhà cung cấp:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][2].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:C9"].MergeCells = true;
            exRange.Range["C9:C9"].Value = tblThongtinHD.Rows[0][3].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TenNoiThat, a.SoLuong, b.DonGiaNhap, a.GiamGia, a.ThanhTien " +
                  "FROM ChiTietHoaDonNhap AS a , DMNoiThat AS b WHERE a.SoHDN = N'" +
                  txtSoHDN.Text + "' AND a.MaNoiThat = b.MaNoiThat";
            tblThongtinHang = DAO.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang <= tblThongtinHang.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinHang.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
            }
            sql = "select sum(TongTien) from HoaDonNhap WHERE SoHDN=N'" + txtSoHDN.Text + "'";
            DataTable tblBC;
            tblBC = DAO.GetDataToTable(sql);
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblBC.Rows[0][0].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range[" A1: F1 "].MergeCells = true;
            exRange.Range[" A1: F1 "].Font.Bold = true;
            exRange.Range[" A1: F1 "].Font.Italic = true;
            exRange.Range[" A1: F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range[" A1: F1"].Value = "Bằng chữ: " + DAO.ChuyenSoSangChu(Double.Parse(tblBC.Rows[0][0].ToString()));
            sql = "Select TenNV from NhanVien as a inner join HoaDonNhap as b on a.MaNV=b.MaNV where SoHDN=N'" + txtSoHDN.Text.Trim() + "'";
            DataTable tblBC1;
            tblBC1 = DAO.GetDataToTable(sql);
            exRange = exSheet.Cells[cot][hang + 21];
            exRange.Font.Bold = true;
            //exRange.Value2 = tblBC1;
            exRange = exSheet.Cells[cot + 0][hang + 21];
            exRange.Font.Bold = true;
            exRange.Value2 = tblBC1.Rows[0][0].ToString();
            exRange = exSheet.Cells[1][hang + 22]; //Ô A1 
            exRange = exSheet.Cells[4][hang + 17];
            exRange.Range[" A1: C1 "].MergeCells = true;
            exRange.Range[" A1: C1 "].Font.Italic = true;
            exRange.Range[" A1: C1 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exSheet.Name = " Hóa Đơn Nhập";
            exApp.Visible = true;
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            exRange.Range[" A1: C1 "].Value = " Hà Nội, ngày " + day + " tháng " + month + "năm " + year;
            exRange.Range[" A2: C2 "].MergeCells = true;
            exRange.Range[" A2: C2 "].Font.Italic = true;
            exRange.Range[" A2: C2 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" A2: C2 "].Value = " Nhân viên nhập hàng ";
            exRange.Range[" A6: C6 "].MergeCells = true;
            exRange.Range[" A6: C6 "].Font.Italic = true;
            exRange.Range[" A6: C6 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" A6: C6 "].Value = " (Kí tên)";

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAO.OpenConnection();
                string[] Mahang = new string[20];
                string sql;
                int n = 0;
                int i;
                sql = "SELECT MaNoiThat FROM ChiTietHoaDonNhap WHERE SoHDN = N'" + txtSoHDN.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Mahang[n] = reader.GetString(0).ToString();
                    n = n + 1;
                }
                reader.Close();
                //Xóa danh sách các mặt hàng của hóa đơn
                for (i = 0; i <= n - 1; i++)
                    DelHang(txtSoHDN.Text, Mahang[i]);
                //Xóa hóa đơn
                sql = "DELETE HoaDonNhap WHERE SoHDN=N'" + txtSoHDN.Text + "'";
                DAO.RunSqlDel(sql);
                ResetValues();
                LoadDataToGridView();
                btnXoa.Enabled = false;
                btnIn.Enabled = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThemHD.Enabled = true;
            //btnThemHang.Enabled = true;
            btnXoa.Enabled = true;
            txtSoHDN.Enabled = false;
        }

        private void DelHang(string Mahoadon, string Mahang)
        {
            Double s, sl, SLcon;
            string sql;
            sql = "SELECT SoLuong FROM ChiTietHoaDonNhap WHERE SoHDN = N'" + Mahoadon + "' AND MaNoiThat = N'" + Mahang + "'";
            s = Convert.ToDouble(DAO.GetFieldValues(sql));
            sql = "DELETE ChitietHoaDonNhap WHERE SoHDN=N'" + Mahoadon + "' AND MaNoiThat = N'" + Mahang + "'";
            DAO.RunSqlDel(sql);
            // Cập nhật lại số lượng cho các mặt hàng
            sql = "SELECT SoLuong FROM DMNoiThat WHERE MaNoiThat = N'" + Mahang + "'";
            sl = Convert.ToDouble(DAO.GetFieldValues(sql));
            SLcon = sl + s;
            sql = "UPDATE DMNoiThat SET SoLuong =" + SLcon + " WHERE MaNoiThat= N'" + Mahang + "'";
            DAO.RunSQL(sql);
        }
        private void DelUpdateTongtien(string Mahoadon, double Thanhtien)
        {
            Double Tong, Tongmoi;
            string sql;
            sql = "SELECT TongTien FROM HoaDonNhap WHERE SoHDN = N'" + Mahoadon + "'";
            Tong = Convert.ToDouble(DAO.GetFieldValues(sql));
            Tongmoi = Tong - Thanhtien;
            sql = "UPDATE HoaDonNhap SET TongTien =" + Tongmoi + " WHERE SoHDN = N'" + Mahoadon + "'";
            DAO.RunSQL(sql);
            txtTongTien.Text = Tongmoi.ToString();
            lbBangChu.Text = "Bằng chữ: " + DAO.ChuyenSoSangChu(Tongmoi.ToString());
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay doi So luong, Giam gia thi Thanh tien tu dong cap nhat lai gia tri
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg + sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay doi So luong, Giam gia thi Thanh tien tu dong cap nhat lai gia tri
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }

        private void cmbTim_DropDown(object sender, EventArgs e)
        {
            DAO.FillDataToCombo("SELECT SoHDN FROM HoaDonNhap", cmbTim, "SoHDN", "SoHDN");
            cmbTim.SelectedIndex = -1;
        }

        private void frmHoaDonNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Xóa dữ liệu trong các điều khiển trước khi đóng Form
            ResetValues();
        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay doi So luong, Giam gia thi Thanh tien tu dong cap nhat lai gia tri
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg + sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }
    }
}