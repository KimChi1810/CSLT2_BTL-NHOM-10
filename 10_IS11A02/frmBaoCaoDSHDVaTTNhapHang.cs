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
    public partial class frmBaoCaoDSHDVaTTNhapHang : Form
    {
        public frmBaoCaoDSHDVaTTNhapHang()
        {
            InitializeComponent();
        }
        public void FillDataToCombo1()
        {
            string sql = "select MaNV,TenNV from NhanVien";
            DAO.FillDataToCombo(sql, cmbMaNV, "MaNV", "MaNV");
            cmbMaNV.SelectedIndex = -1;
        }

        public void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "Select b.MaNoiThat,TenNoiThat,c.MaNV,TenNV,NgayNhap,b.SoLuong,GiamGia,ThanhTien,TongTien from DMNoiThat as a inner join ChiTietHoaDonNhap as b on a.MaNoiThat=b.MaNoiThat inner join HoaDonNhap as c on b.SoHDN=c.SoHDN inner join NhanVien as d on d.MaNV=c.MaNV";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable table = new DataTable();
                myAdapter.Fill(table);
                GridViewBCDSHDVaTTNhap.DataSource = table;
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
        private void frmBaoCaoDSHDVaTTNhapHang_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
            FillDataToCombo1();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void txtQuy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void cmbMaNV_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cmbMaNV.Text == "")
                txtTenNV.Text = "";
            str = "Select TenNV from NhanVien where MaNV =N'" + cmbMaNV.SelectedValue + "'";
            txtTenNV.Text = DAO.GetFieldValues(str);
        }

        private void btnBaoCaoLai_Click(object sender, EventArgs e)
        {
            txtQuy.Enabled = true;
            txtTenNV.Enabled = true;

            txtQuy.Text = "";
            txtTenNV.Text = "";
            cmbMaNV.SelectedIndex = -1;
            LoadDataToGridView();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            string sql;
            if (cmbMaNV.Text == "" || txtQuy.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ mã nhân viên và quý", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuy.Focus();
                return;
            }
            sql = "Select b.MaNoiThat,TenNoiThat,c.MaNV,TenNV,NgayNhap,b.SoLuong,GiamGia,ThanhTien,sum(TongTien) from DMNoiThat as a " +
                "inner join ChiTietHoaDonNhap as b on a.MaNoiThat=b.MaNoiThat inner join HoaDonNhap as c on b.SoHDN=c.SoHDN  " +
                "inner join NhanVien as d on d.MaNV=c.MaNV  where c.MaNV=N'" + cmbMaNV.SelectedValue + "'AND (Datepart(QUARTER, NgayNhap))='" + txtQuy.Text + "'group by b.MaNoiThat,TenNoiThat,c.MaNV,TenNV,NgayNhap,b.SoLuong,GiamGia,ThanhTien";
            SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable(); 
            myAdapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi nào thỏa mãn điều kiện", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có " + table.Rows.Count + " bản ghi thỏa mãn điều kiện", "Thông báo",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            GridViewBCDSHDVaTTNhap.DataSource = table;
        }

        private void GridViewBCDSHDVaTTNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbMaNV.Text = GridViewBCDSHDVaTTNhap.CurrentRow.Cells["MaNV"].Value.ToString();
             txtQuy.Text = GridViewBCDSHDVaTTNhap.CurrentRow.Cells["NgayNhap"].Value.ToString();
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongTinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            //Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range[" A1: B3 "].Font.Size = 10;
            exRange.Range[" A1: B3 "].Font.Name = " Times new roman";
            exRange.Range[" A1: B3 "].Font.Bold = true;
            exRange.Range[" A1: B3 "].Font.ColorIndex = 5;
            exRange.Range[" A1: A1 "].ColumnWidth = 7;
            exRange.Range[" B1: B1 "].ColumnWidth = 15;
            exRange.Range[" A1: B1 "].MergeCells = true;
            exRange.Range[" A1: B1 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" A1: B1"].Value = " Cửa hàng nội thất";
            exRange.Range[" A2: B2 "].MergeCells = true;
            exRange.Range[" A2: B2 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" A2: B2"].Value = " Hai Bà Trưng - Hà Nội ";
            exRange.Range[" A3: B3 "].MergeCells = true;
            exRange.Range[" A3: B3 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" A3: B3 "].Value = " Điện thoại: (023)3756222 ";
            exRange.Range[" D2: F2 "].Font.Size = 16;
            exRange.Range[" D2: F2 "].Font.Name = " Times new roman";
            exRange.Range[" D2: F2 "].Font.Bold = true;
            exRange.Range[" D2: F2 "].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range[" D2: F2 "].MergeCells = true;
            exRange.Range[" D2: F2 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" D2: F2 "].Value = " Danh Sách Hóa Đơn Nhập";

            DataTable tblThongtinNV;
            sql = "SELECT b.TenNV, b.Diachi, b.Dienthoai FROM HoaDonNhap AS a, NhanVien AS b WHERE a.MaNV = N'" + cmbMaNV.SelectedValue.ToString() + "' AND a.MaNV = b.MaNV";
            tblThongtinNV = DAO.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Nhân viên:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinNV.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Địa chỉ:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinNV.Rows[0][1].ToString();
            exRange.Range["B8:B8"].Value = "Điện thoại:";
            exRange.Range["C8:C8"].MergeCells = true;
            exRange.Range["C8:C8"].Value = tblThongtinNV.Rows[0][2].ToString();

            //Lấy thông tin các mặt hàng
            sql = "Select b.SoHDN,TenNoiThat,b.SoLuong,(Datepart(QUARTER, NgayNhap)),GiamGia,DonGiaNhap,ThanhTien from DMNoiThat as a " +
                "inner join ChiTietHoaDonNhap as b on a.MaNoiThat=b.MaNoiThat inner join HoaDonNhap as c on b.SoHDN=c.SoHDN  " +
                "inner join NhanVien as d on d.MaNV=c.MaNV  where c.MaNV=N'" + cmbMaNV.SelectedValue + "'AND (Datepart(QUARTER, NgayNhap))='" + txtQuy.Text + "'";
            tblThongTinHang = DAO.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range[" A11: H11 "].Font.Bold = true;
            exRange.Range[" A11: H11 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" C11: H11 "].ColumnWidth = 12;
            exRange.Range[" A11: A11 "].Value = " STT ";
            exRange.Range[" B11: B11 "].Value = " Mã hóa đơn ";
            exRange.Range[" C11: C11 "].Value = " Tên hàng ";
            exRange.Range[" D11: D11 "].Value = " Số lượng ";
            exRange.Range[" E11: E11 "].Value = " Qúy nhập ";
            exRange.Range[" F11: F11 "].Value = " Giảm Giá ";
            exRange.Range[" G11: G11 "].Value = " Đơn Giá ";
            exRange.Range[" H11: H11 "].Value = " Thành tiền ";
            for (hang = 0; hang <= tblThongTinHang.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongTinHang.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = tblThongTinHang.Rows[hang][cot].ToString();
                exSheet.Cells[2][hang + 12] = "'" + tblThongTinHang.Rows[hang][0].ToString();
            }
            sql = "select sum(TongTien) from HoaDonNhap where MaNV=N'" + cmbMaNV.Text + "'";
            DataTable tblBC;
            tblBC = DAO.GetDataToTable(sql);
            exRange = exSheet.Cells[cot][hang + 17];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 17];
            exRange.Font.Bold = true;
            exRange.Value2 = tblBC.Rows[0][0].ToString();
            exRange = exSheet.Cells[1][hang + 18]; //Ô A1 
            exRange.Range[" C1: H1 "].MergeCells = true;
            exRange.Range[" C1: H1 "].Font.Bold = true;
            exRange.Range[" C1: H1 "].Font.Italic = true;
            exRange.Range[" C1: H1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range[" C1: H1"].Value = "Bằng chữ: " + DAO.ChuyenSoSangChu(Double.Parse(tblBC.Rows[0][0].ToString()));
            exRange = exSheet.Cells[4][hang + 20];
            exRange.Range[" C1: E1 "].MergeCells = true;
            exRange.Range[" C1: E1 "].Font.Italic = true;
            exRange.Range[" C1: E1 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            exRange.Range[" C1: E1 "].Value = " Hà Nội, ngày " + day + " tháng " + month + "năm " + year;
            exRange.Range[" C2: E2 "].MergeCells = true;
            exRange.Range[" C2: E2 "].Font.Italic = true;
            exRange.Range[" C2: E2 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" C2: E2 "].Value = " Nhân viên lập báo cáo ";
            exRange.Range[" C3: E3 "].MergeCells = true;
            exRange.Range[" C3: E3 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" C3: E3 "].Value = " (Kí, Ghi rõ họ tên)";
            exSheet.Name = " Hóa Đơn Nhập";
            exApp.Visible = true;
        }
    }
}
