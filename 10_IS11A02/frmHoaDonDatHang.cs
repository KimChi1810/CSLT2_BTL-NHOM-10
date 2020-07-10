using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace BTN_10_SO_26
{
    public partial class frmHoaDonDatHang : Form
    {
        DataTable tblCTHDB;
        public frmHoaDonDatHang()
        {
            InitializeComponent();
        }
        public void FillDataToCombo1()
        {
            string sql = " select MaNV,TenNV from NhanVien";
            DAO.OpenConnection();
            DAO.FillDataToCombo(sql, cmbMaNV, "MaNV", "MaNV");

            sql = "select MaKhach,TenKhach from KhachHang";
            DAO.FillDataToCombo(sql, cmbMaKH, "MaKhach", "MaKhach");

            sql = "select MaNoiThat,TenNoiThat from DMNoiThat";
            DAO.FillDataToCombo(sql, cmbMaNoiThat, "MaNoiThat", "MaNoiThat");
        }
        private void frmHoaDonDatHang_Load(object sender, EventArgs e)
        {
            btnThemHD.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnIn.Enabled = false;
            txtSoDDH.ReadOnly = true;
            txtDatCoc.Enabled = true;
            txtThue.Enabled = true;
            txtTenNV.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtDienThoai.ReadOnly = true;
            txtTenNoiThat.ReadOnly = true;
            txtDonGiaBan.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtGiamGia.Text = "0";
            txtTongTien.Text = "0";
            FillDataToCombo1();
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtSoDDH.Text != "")
            {
                Load_ThongtinHD();
                Load_ThongtinNoiThat();
                btnXoa.Enabled = true;
                btnIn.Enabled = true;
            }
            Load_DataGridViewChitiet();
        }
        private void Load_DataGridViewChitiet()
        {
            string sql;
            sql = "SELECT SoDDH, a.MaNoiThat, b.TenNoiThat, a.SoLuong, b.DonGiaBan, a.GiamGia, a.ThanhTien FROM ChiTietDonDatHang AS a, DMNoiThat AS b WHERE a.MaNoiThat=b.MaNoiThat";
            tblCTHDB = DAO.GetDataToTable(sql);
            DataGridViewChitiet.DataSource = tblCTHDB;
        }
        private void Load_ThongtinHD()
        {
            string str;
            str = "Select NgayDat from DonDatHang where SoDDH = N'" + txtSoDDH.Text + "'";
            mskNgayDat.Text = DAO.ConvertDateTime(DAO.GetFieldValues(str));
            str = "Select NgayGiao from DonDatHang where SoDDH = N'" + txtSoDDH.Text + "'";
            mskNgayGiao.Text = DAO.ConvertDateTime(DAO.GetFieldValues(str));
            str = "Select DatCoc from DonDatHang where SoDDH = N'" + txtSoDDH.Text + "'";
            txtDatCoc.Text = DAO.GetFieldValues(str);
            str = "Select Thue from DonDatHang where SoDDH = N'" + txtSoDDH.Text + "'";
            txtThue.Text = DAO.GetFieldValues(str);
            str = "Select MaNV from DonDatHang where SoDDH = N'" + txtSoDDH.Text + "'";
            cmbMaNV.Text = DAO.GetFieldValues(str);
            str = "Select MaKhach from DonDatHang where SoDDH = N'" + txtSoDDH.Text + "'";
            cmbMaKH.Text = DAO.GetFieldValues(str);
            str = "Select TongTien from DonDatHang where SoDDH = N'" + txtSoDDH.Text + "'";
            txtTongTien.Text = DAO.GetFieldValues(str);
            lbBangChu.Text = "Bằng chữ: " + DAO.ChuyenSoSangChu(Double.Parse(txtTongTien.Text));
        }

        private void Load_ThongtinNoiThat()
        {
            string str;
            str = "Select MaNoiThat from ChiTietDonDatHang where SoDDH = N'" + txtSoDDH.Text + "'";
            cmbMaNoiThat.Text= DAO.GetFieldValues(str);
            str = "Select TenNoiThat from DMNoiThat as a inner join ChiTietDonDatHang as b on a.MaNoiThat=b.MaNoiThat where SoDDH = N'" + txtSoDDH.Text + "'";
            txtTenNoiThat.Text = DAO.GetFieldValues(str);
            str = "Select SoLuong from ChiTietDonDatHang where SoDDH = N'" + txtSoDDH.Text + "'";
            txtSoLuong.Text = DAO.GetFieldValues(str);
            str = "Select GiamGia from ChiTietDonDatHang where SoDDH = N'" + txtSoDDH.Text + "'";
            txtGiamGia.Text = DAO.GetFieldValues(str);
            str = "Select ThanhTien from ChiTietDonDatHang where SoDDH = N'" + txtSoDDH.Text + "'";
            txtThanhTien.Text = DAO.GetFieldValues(str);
            str = "Select DonGiaBan from ChiTietDonDatHang as a inner join DMNoiThat as b on a.MaNoiThat=b.MaNoiThat where SoDDH = N'" + txtSoDDH.Text + "'";
            txtDonGiaBan.Text = DAO.GetFieldValues(str);
        }
        private void ResetValues()
        {
            txtSoDDH.Text = "";
            mskNgayDat.Text = DateTime.Now.ToShortDateString();
            mskNgayGiao.Text = DateTime.Now.ToShortDateString();
            cmbMaNV.Text = "";
            cmbMaKH.Text = "";
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
            //txtDonGiaBan.Text = "0";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT SoDDH FROM DonDatHang WHERE SoDDH=N'" + txtSoDDH.Text + "'";
            if (!DAO.CheckKeyExit(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (cmbMaNV.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbMaNV.Focus();
                    return;
                }
                if (cmbMaKH.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbMaKH.Focus();
                    return;
                }
                if (mskNgayDat.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày đặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskNgayDat.Focus();
                    return;
                }
                if (mskNgayGiao.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày giao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskNgayGiao.Focus();
                    return;
                }
                sql = "INSERT INTO DonDatHang(SoDDH, NgayDat,NgayGiao, MaNV, MaKhach, TongTien,DatCoc,Thue)  VALUES(N'" + txtSoDDH.Text.Trim() + "','" +
                        DAO.ConvertDateTime(mskNgayDat.Text.Trim()) + "','" + DAO.ConvertDateTime(mskNgayGiao.Text.Trim()) + "',N'" + cmbMaNV.SelectedValue + "',N'" +
                        cmbMaKH.SelectedValue + "','" + txtTongTien.Text + "','" + txtDatCoc.Text + "',N'" + txtThue.Text + "')";
                DAO.RunSQL(sql);
            }
            // Lưu thông tin của các mặt hàng
            if (cmbMaNoiThat.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nội thất", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtGiamGia.Focus();
                return;
            }
            sql = "SELECT MaNoiThat FROM ChiTietDonDatHang WHERE MaNoiThat=N'" + cmbMaNoiThat.SelectedValue + "' AND SoDDH = N'" + txtSoDDH.Text.Trim() + "'";
            if (DAO.CheckKeyExit(sql))
            {
                MessageBox.Show("Mã nội thất này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValuesHang();
                cmbMaNoiThat.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(DAO.GetFieldValues("SELECT SoLuong FROM DMNoiThat WHERE MaNoiThat = N'" + cmbMaNoiThat.SelectedValue + "'"));
            if (Convert.ToDouble(txtSoLuong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }

            sql = "INSERT INTO ChiTietDonDatHang(SoDDH,MaNoiThat,SoLuong,GiamGia, ThanhTien) VALUES(N'" + txtSoDDH.Text.Trim() + "',N'" + cmbMaNoiThat.SelectedValue +
"','" + txtSoLuong.Text + "','" + txtGiamGia.Text + "','" + txtThanhTien.Text + "')";
            DAO.RunSQL(sql);
            Load_DataGridViewChitiet();
            // Cập nhật lại số lượng của mặt hàng vào bảng DMNoiThat
            SLcon = sl - Convert.ToDouble(txtSoLuong.Text);
            sql = "UPDATE DMNoiThat SET SoLuong =" + SLcon + " WHERE MaNoiThat= N'" + cmbMaNoiThat.SelectedValue + "'";
            DAO.RunSQL(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(DAO.GetFieldValues("SELECT TongTien FROM DonDatHang  WHERE SoDDH = N'" + txtSoDDH.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtThanhTien.Text);
            sql = "UPDATE DonDatHang SET TongTien =" + Tongmoi + " WHERE SoDDH = N'" + txtSoDDH.Text + "'";
            DAO.RunSQL(sql);
            txtTongTien.Text = Tongmoi.ToString();
            lbBangChu.Text = "Bằng chữ: " + DAO.ChuyenSoSangChu(Tongmoi.ToString());
            ResetValuesHang();
            btnXoa.Enabled = false;
            btnThemHD.Enabled = true;
            //btnThemHang.Enabled = true;
            btnIn.Enabled = false;
            Load_DataGridViewChitiet();
        }


        private void DelHang(string Mahoadon, string Mahang)
        {
            Double s, sl, SLcon;
            string sql;
            sql = "SELECT SoLuong FROM ChiTietDonDatHang WHERE SoDDH = N'" + Mahoadon + "' AND MaNoiThat = N'" + Mahang + "'";
            s = Convert.ToDouble(DAO.GetFieldValues(sql));
            sql = "DELETE ChitietDonDatHang WHERE SoDDH=N'" + Mahoadon + "' AND MaNoiThat = N'" + Mahang + "'";
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
            sql = "SELECT TongTien FROM DonDatHang WHERE SoDDH = N'" + Mahoadon + "'";
            Tong = Convert.ToDouble(DAO.GetFieldValues(sql));
            Tongmoi = Tong - Thanhtien;
            sql = "UPDATE DonDatHang SET TongTien =" + Tongmoi + " WHERE SoDDH = N'" + Mahoadon + "'";
            DAO.RunSQL(sql);
            txtTongTien.Text = Tongmoi.ToString();
            lbBangChu.Text = "Bằng chữ: " + DAO.ChuyenSoSangChu(Tongmoi.ToString());
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cmbTim.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbTim.Focus();
                return;
            }
            txtSoDDH.Text = cmbTim.Text;
            Load_ThongtinHD();
            Load_ThongtinNoiThat();
            Load_DataGridViewChitiet();
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnIn.Enabled = true;
            //btnThemHang.Enabled = true;
            btnThemHD.Enabled = true;
            cmbTim.SelectedIndex = -1;
        }

        private void DataGridViewChitiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbMaNoiThat.Text = DataGridViewChitiet.CurrentRow.Cells["MaNoiThat"].Value.ToString();
            txtTenNoiThat.Text = DataGridViewChitiet.CurrentRow.Cells["TenNoiThat"].Value.ToString();
            txtSoLuong.Text = DataGridViewChitiet.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtGiamGia.Text = DataGridViewChitiet.CurrentRow.Cells["GiamGia"].Value.ToString();
            txtThanhTien.Text = DataGridViewChitiet.CurrentRow.Cells["ThanhTien"].Value.ToString();
            txtDonGiaBan.Text = DataGridViewChitiet.CurrentRow.Cells["DonGiaBan"].Value.ToString();
            txtSoDDH.Text = DAO.CreateKey("SoDDH");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] Mahang = new string[20];
                string sql;
                int n = 0;
                int i;
                sql = "SELECT MaNoiThat FROM ChiTietDonDatHang WHERE SoDDH = N'" + txtSoDDH.Text + "'";
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
                    DelHang(txtSoDDH.Text, Mahang[i]);
                //Xóa hóa đơn
                sql = "DELETE DonDatHang WHERE SoDDH=N'" + txtSoDDH.Text + "'";
                DAO.RunSqlDel(sql);
                ResetValues();
                Load_DataGridViewChitiet();
                btnXoa.Enabled = false;
                btnIn.Enabled = false;
            }
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnHuyHD.Enabled = false;
            btnLuu.Enabled = false;
            //btnThemHang.Enabled = true;
            btnThemHD.Enabled = true;
            btnXoa.Enabled = true;
            txtSoDDH.Enabled = false;
        }

        private void cmbMaNV_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cmbMaNV.Text == "")
                txtTenNV.Text = "";
            // Khi kich chon Ma nhan vien thi ten nhan vien se tu dong hien ra
            str = "Select TenNV from Nhanvien where MaNV =N'" + cmbMaNV.SelectedValue + "'";
            txtTenNV.Text = DAO.GetFieldValues(str);
            str = "Select DatCoc from DonDatHang where MaNV =N'" + cmbMaNV.SelectedValue + "'";
            txtDatCoc.Text = DAO.GetFieldValues(str);
            str = "Select Thue from DonDatHang where MaNV =N'" + cmbMaNV.SelectedValue + "'";
            txtThue.Text = DAO.GetFieldValues(str);
            str = "Select NgayDat from DonDatHang where MaNV =N'" + cmbMaNV.SelectedValue + "'";
            mskNgayDat.Text = (DAO.GetFieldValues(str));
            str = "Select NgayGiao from DonDatHang where MaNV =N'" + cmbMaNV.SelectedValue + "'";
            mskNgayGiao.Text = (DAO.GetFieldValues(str));
        }

        private void cmbMaKH_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cmbMaKH.Text == "")
            {
                txtTenKH.Text = "";
                txtDiaChi.Text = "";
                txtDienThoai.Text = "";
            }
            //Khi kich chon Ma khach thi ten khach, dia chi, dien thoai se tu dong hien ra
            str = "Select TenKhach from KhachHang where MaKhach = N'" + cmbMaKH.SelectedValue + "'";
            txtTenKH.Text = DAO.GetFieldValues(str);
            str = "Select Diachi from KhachHang where MaKhach = N'" + cmbMaKH.SelectedValue + "'";
            txtDiaChi.Text = DAO.GetFieldValues(str);
            str = "Select Dienthoai from KhachHang where MaKhach= N'" + cmbMaKH.SelectedValue + "'";
            txtDienThoai.Text = DAO.GetFieldValues(str);
        }

        private void cmbMaNoiThat_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cmbMaNoiThat.Text == "")
            {
                txtTenNoiThat.Text = "";
                //txtDongiaban.Text = "";
                txtSoLuong.Text = "";
                txtGiamGia.Text = "";
                txtDonGiaBan.Text = "";
                txtThanhTien.Text = "";
            }
            // Khi kich chon Ma nội thất thi ten nội thất,DonGiaBan,... se tu dong hien ra
            str = "SELECT TenNoiThat FROM DMNoiThat WHERE MaNoiThat =N'" + cmbMaNoiThat.SelectedValue + "'";
            txtTenNoiThat.Text = DAO.GetFieldValues(str);
            str = "SELECT DonGiaBan FROM DMNoiThat WHERE MaNoiThat =N'" + cmbMaNoiThat.SelectedValue + "'";
            txtDonGiaBan.Text = DAO.GetFieldValues(str);
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuyHD.Enabled = true;
            btnThemHD.Enabled = false;
            ResetValues();
            txtSoDDH.Text = DAO.CreateKey("SoDDH");
            Load_DataGridViewChitiet();
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuyHD.Enabled = true;
            btnThemHD.Enabled = false;
            ResetValuesHang();
            //txtSoDDH.Text = DAO.CreateKey("HDB");
            Load_DataGridViewChitiet();
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
            if (txtDonGiaBan.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaBan.Text);
            tt = sl * dg - sl * dg * gg / 100;
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
            if (txtDonGiaBan.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaBan.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();

        }

        private void cmbTim_DropDown(object sender, EventArgs e)
        {
            DAO.FillDataToCombo("SELECT SoDDH FROM DonDatHang", cmbTim, "SoDDH","SoDDH");
            cmbTim.SelectedIndex = -1;

        }

        private void frmHDDat_TEST__FormClosing(object sender, FormClosingEventArgs e)
        {
            //Xóa dữ liệu trong các điều khiển trước khi đóng Form
            ResetValues();
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

        private void txtDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
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
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.SoDDH, a.NgayDat, a.NgayGiao, b.Tenkhach, b.Diachi, b.Dienthoai, a.Tongtien, c.TenNV FROM DonDatHang AS a, KhachHang AS b, NhanVien AS c WHERE a.SoDDH = N'" + txtSoDDH.Text + "' AND a.MaKhach = b.MaKhach AND a.MaNV = c.MaNV";
            tblThongtinHD = DAO.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:C9"].MergeCells = true;
            exRange.Range["C9:C9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TenNoiThat, a.SoLuong, b.DonGiaBan, a.GiamGia, a.ThanhTien " +
                  "FROM ChiTietDonDatHang AS a , DMNoiThat AS b WHERE a.SoDDH = N'" +
                  txtSoDDH.Text + "' AND a.MaNoiThat = b.MaNoiThat";
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
            sql = "select sum(TongTien) from DonDatHang WHERE SoDDH=N'" + txtSoDDH.Text + "'";
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
            sql = "Select TenNV from NhanVien as a inner join DonDatHang as b on a.MaNV=b.MaNV where SoDDH=N'" + txtSoDDH.Text.Trim() + "'";
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
            exSheet.Name = " Hóa Đơn Bán";
            exApp.Visible = true;
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            exRange.Range[" A1: C1 "].Value = " Hà Nội, ngày " + day + " tháng " + month + "năm " + year;
            exRange.Range[" A2: C2 "].MergeCells = true;
            exRange.Range[" A2: C2 "].Font.Italic = true;
            exRange.Range[" A2: C2 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" A2: C2 "].Value = " Nhân viên bán hàng ";
            exRange.Range[" A6: C6 "].MergeCells = true;
            exRange.Range[" A6: C6 "].Font.Italic = true;
            exRange.Range[" A6: C6 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" A6: C6 "].Value = " (Kí tên)";
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
    }
}