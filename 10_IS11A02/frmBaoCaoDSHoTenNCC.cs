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
    public partial class frmBaoCaoDSHoTenNCC : Form
    {
        public frmBaoCaoDSHoTenNCC()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDSHoTenNCC_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
            FillDataToCombo1();
        }
        public void FillDataToCombo1()
        {
            string sql = "select MaNoiThat,TenNoiThat from DMNoiThat";
            DAO.FillDataToCombo(sql, cmbMaNoiThat, "MaNoiThat", "MaNoiThat");
            cmbMaNoiThat.SelectedIndex = -1;
        }

        public void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "Select a.MaNCC,TenNCC,DiaChi,DienThoai,NgayNhap,d.MaNoiThat from NhaCungCap as a inner join HoaDonNhap as b on a.MaNCC=b.MaNCC" +
                    " inner join ChiTietHoaDonNhap as c on b.SoHDN=c.SoHDN inner join DMNoiThat as d on c.MaNoiThat=d.MaNoiThat";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable table = new DataTable();
                myAdapter.Fill(table);
                GridViewBCDSHoTenNCC.DataSource = table;
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

        private void cmbMaNoiThat_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cmbMaNoiThat.Text == "")
                txtTenNoiThat.Text = "";
            str = "Select TenNoiThat from DMNoiThat where MaNoiThat =N'" + cmbMaNoiThat.SelectedValue + "'";
            txtTenNoiThat.Text = DAO.GetFieldValues(str);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void GridViewBCDSHoTenNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbMaNoiThat.Text = GridViewBCDSHoTenNCC.CurrentRow.Cells["MaNoiThat"].Value.ToString();
            txtThang.Text = GridViewBCDSHoTenNCC.CurrentRow.Cells["NgayNhap"].Value.ToString();
        }

        private void btnBaoCaoLai_Click(object sender, EventArgs e)
        {
            txtTenNoiThat.Enabled = true;
            txtThang.Enabled = true;

            txtTenNoiThat.Text = "";
            txtThang.Text = "";
            cmbMaNoiThat.SelectedIndex = -1;
            LoadDataToGridView();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            string sql;
            if (cmbMaNoiThat.Text == "" || txtThang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ mã nội thất và tháng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtThang.Focus();
                return;
            }
            sql = "Select a.MaNCC,TenNCC,DiaChi,DienThoai,NgayNhap,d.MaNoiThat from NhaCungCap as a inner join HoaDonNhap as b on a.MaNCC=b.MaNCC" +
                    " inner join ChiTietHoaDonNhap as c on b.SoHDN=c.SoHDN inner join DMNoiThat as d on c.MaNoiThat=d.MaNoiThat where d.MaNoiThat=N'" + cmbMaNoiThat.SelectedValue + "'AND datepart(mm,(NgayNhap))='" + txtThang.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
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
            GridViewBCDSHoTenNCC.DataSource = table;
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinNCC;
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
            exRange.Range["A1:B1"].Value = "Cửa hàng quản lý nội thất";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Hai Bà Trưng - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)37562222";
            exRange.Range["C2:F2"].Font.Size = 16;
            exRange.Range["C2:F2"].Font.Name = "Times new roman";
            exRange.Range["C2:F2"].Font.Bold = true;
            exRange.Range["C2:F2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:F2"].MergeCells = true;
            exRange.Range["C2:F2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:F2"].Value = "HỌ TÊN NHÀ CUNG CẤP";

            DataTable tblThongtinHang;
            sql = "SELECT a.MaNoiThat,TenNoiThat,Datepart(mm,NgayNhap) FROM ChiTietHoaDonNhap as a inner join DMNoiThat as b on a.MaNoiThat=b.MaNoiThat inner join HoaDonNhap as c on a.SoHDN=c.SoHDN WHERE a.MaNoiThat=N'" + cmbMaNoiThat.SelectedValue + "' AND Datepart(mm,NgayNhap)='" + txtThang.Text + "'";
            tblThongtinHang = DAO.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hàng:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHang.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Tên hàng";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHang.Rows[0][1].ToString();
            exRange.Range["B8:B8"].Value = "Tháng nhập";
            exRange.Range["C8:C8"].MergeCells = true;
            exRange.Range["C8:C8"].Value = tblThongtinHang.Rows[0][2].ToString();

            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "Select a.MaNCC,TenNCC,DiaChi,DienThoai from NhaCungCap as a inner join HoaDonNhap as b on a.MaNCC=b.MaNCC" +
                    " inner join ChiTietHoaDonNhap as c on b.SoHDN=c.SoHDN inner join DMNoiThat as d on c.MaNoiThat=d.MaNoiThat where d.MaNoiThat=N'" + cmbMaNoiThat.SelectedValue + "'AND datepart(mm,(NgayNhap))='" + txtThang.Text + "'";
            tblThongtinNCC = DAO.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:G11"].Font.Bold = true;
            exRange.Range["A11:G11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Mã NCC";
            exRange.Range["C11:C11"].Value = "Tên NCC";
            exRange.Range["D11:D11"].Value = "Địa chỉ";
            exRange.Range["E11:E11"].Value = "Điện thoại";
            for (hang = 0; hang <= tblThongtinNCC.Rows.Count - 1; hang++)
            {
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinNCC.Columns.Count - 1; cot++)

                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinNCC.Rows[hang][cot].ToString();
                exSheet.Cells[2][hang + 12] = "'" + tblThongtinNCC.Rows[hang][0].ToString();
            }
            exRange = exSheet.Cells[4][hang + 15]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            exRange.Range[" A1: C1 "].Value = " Hà Nội, ngày " + day + " tháng " + month + "năm " + year;
            exRange.Range[" A2: C2 "].MergeCells = true;
            exRange.Range[" A2: C2 "].Font.Italic = true;
            exRange.Range[" A2: C2 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" A2: C2 "].Value = " Nhân viên lập báo cáo ";
            exRange.Range[" A3: C3 "].MergeCells = true;
            exRange.Range[" A3: C3 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" A3: C3 "].Value = " (Kí, Ghi rõ họ tên)";
            exSheet.Name = " Danh sách nhà cung cấp ";
            exApp.Visible = true;
            

        }
    }
}
