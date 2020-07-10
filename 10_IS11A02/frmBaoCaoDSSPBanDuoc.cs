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
    public partial class frmBaoCaoDSSPBanDuoc : Form
    {
        public frmBaoCaoDSSPBanDuoc()
        {
            InitializeComponent();
        }
        public void FillDataToCombo1()
        {
            string sql = "select MaKhach,TenKhach from KhachHang";
            DAO.FillDataToCombo(sql, cmbMaKH, "MaKhach", "MaKhach");
            cmbMaKH.SelectedIndex = -1;
        }

            public void LoadDataToGridView()
        { 
            try
            {
                DAO.OpenConnection();
                string sql = "Select b.MaNoiThat,TenNoiThat,MaKhach,NgayGiao,b.SoLuong from DMNoiThat as a inner join ChiTietDonDatHang as b on a.MaNoiThat=b.MaNoiThat inner join DonDatHang as c on b.SoDDH=c.SoDDH";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable table = new DataTable();
                myAdapter.Fill(table);
                GridViewBCSP.DataSource = table;
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
            private void btnThoat_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    this.Close();
            }
            private void GridViewBCSP_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                cmbMaKH.Text = GridViewBCSP.CurrentRow.Cells["MaKhach"].Value.ToString();
                txtThang.Text = GridViewBCSP.CurrentRow.Cells["NgayGiao"].Value.ToString();
            }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void frmBaoCaoDSSPBanDuoc_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
            FillDataToCombo1();
        }

        private void cmbMaKH_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cmbMaKH.Text == "")
                txtTenKH.Text = "";
            str = "Select TenKhach from KhachHang where MaKhach =N'" + cmbMaKH.SelectedValue + "'";
            txtTenKH.Text = DAO.GetFieldValues(str);
        }

        private void btnBaoCaoLai_Click(object sender, EventArgs e)
        {
            txtTenKH.Enabled = true;
            txtThang.Enabled = true;

            txtTenKH.Text = "";
            txtThang.Text = "";
            cmbMaKH.SelectedIndex = -1;
            LoadDataToGridView();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            string sql;
            if (cmbMaKH.Text == "" || txtThang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ mã khách hàng và tháng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtThang.Focus();
                return;
            }
            sql = "select b.MaNoiThat,TenNoiThat,MaKhach,NgayGiao,b.SoLuong from DMNoiThat as a inner join ChiTietDonDatHang as b on a.MaNoiThat=b.MaNoiThat inner join DonDatHang as c on b.SoDDH=c.SoDDH where MaKhach=N'" + cmbMaKH.SelectedValue + "'AND datepart(mm,(NgayGiao))='" + txtThang.Text + "'";
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
            GridViewBCSP.DataSource = table;
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
            DataTable tblThongtinBC, tblThongtinHang;
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
            exRange.Range["C2:E2"].Value = "SẢN PHẨM ĐÃ BÁN ĐƯỢC";
            // Biểu diễn thông tin chung của báo cáo
            sql = "SELECT b.Tenkhach, b.Diachi, b.Dienthoai FROM DonDatHang AS a, KhachHang AS b WHERE a.MaKhach = N'" + cmbMaKH.SelectedValue.ToString() + "' AND a.MaKhach = b.MaKhach";
            tblThongtinBC = DAO.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Khách hàng:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinBC.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Địa chỉ:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinBC.Rows[0][1].ToString();
            exRange.Range["B8:B8"].Value = "Điện thoại:";
            exRange.Range["C8:C8"].MergeCells = true;
            exRange.Range["C8:C8"].Value = tblThongtinBC.Rows[0][2].ToString();
            sql = "select b.MaNoiThat,TenNoiThat,Datepart(mm,NgayGiao),b.SoLuong from DMNoiThat as a inner join " +
                "ChiTietDonDatHang as b on a.MaNoiThat=b.MaNoiThat inner join DonDatHang as c on b.SoDDH=c.SoDDH where MaKHach=N'" + cmbMaKH.SelectedValue + "'AND datepart(mm,NgayGiao)='" + txtThang.Text + "'";
            tblThongtinHang = DAO.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Mã nội thất";
            exRange.Range["C11:C11"].Value = "Tên nội thất";
            exRange.Range["D11:D11"].Value = "Tháng giao";
            exRange.Range["E11:E11"].Value = "Số lượng";
            //exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang <= tblThongtinHang.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinHang.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
            }
            exRange.Range[" C16: E16 "].MergeCells = true;
            exRange.Range[" C16: E16 "].Font.Italic = true;
            exRange.Range[" C16: E16 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exSheet.Name = " Hóa Đơn Bán";
            exApp.Visible = true;
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            exRange.Range[" C16: E16 "].Value = " Hà Nội, ngày " + day + " tháng " + month + "năm " + year;
            exRange.Range[" C17: E17 "].MergeCells = true;
            exRange.Range[" C17: E17 "].Font.Italic = true;
            exRange.Range[" C17: E17 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" C17: E17 "].Value = " Nhân viên lập báo cáo ";
            exRange.Range[" C20: E20 "].MergeCells = true;
            exRange.Range[" C20: E20 "].Font.Italic = true;
            exRange.Range[" C20: E20 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" C20: E20 "].Value = " (Kí và ghi rõ họ tên)";
            exSheet.Name = " Danh sách sản phẩm ";
            exApp.Visible = true;
        }

    }
}
    
