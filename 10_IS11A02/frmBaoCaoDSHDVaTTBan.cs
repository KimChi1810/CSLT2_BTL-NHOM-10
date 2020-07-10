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
    public partial class frmBaoCaoDSHDVaTTBan : Form
    {
        public frmBaoCaoDSHDVaTTBan()
        {
            InitializeComponent();
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
                string sql = "Select b.MaNoiThat,TenNoiThat,b.SoLuong,DonGiaBan,GiamGia,ThanhTien,Sum(TongTien) as Tongtien from" +
                    " DMNoiThat as a inner join ChiTietDonDatHang as b on a.MaNoiThat=b.MaNoiThat inner join" +
                    " DonDatHang as c on b.SoDDH=c.SoDDH group by b.MaNoiThat,TenNoiThat,b.SoLuong,DonGiaBan,GiamGia,ThanhTien";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable table = new DataTable();
                myAdapter.Fill(table);
                GridViewBCDSHDVaTTBan.DataSource = table;
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

            private void frmBaoCaoDSHDVaTTBan_Load(object sender, EventArgs e)
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

        private void GridViewBCDSHDVaTTBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbMaNoiThat.Text = GridViewBCDSHDVaTTBan.CurrentRow.Cells["MaNoiThat"].Value.ToString();
            txtTenNoiThat.Text = GridViewBCDSHDVaTTBan.CurrentRow.Cells["TenNoiThat"].Value.ToString();
        }

        private void cmbMaNoiThat_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cmbMaNoiThat.Text == "")
                txtTenNoiThat.Text = "";
            str = "Select TenNoiThat from DMNoiThat where MaNoiThat =N'" + cmbMaNoiThat.SelectedValue + "'";
            txtTenNoiThat.Text = DAO.GetFieldValues(str);
        }

        private void btnBaoCaoLai_Click(object sender, EventArgs e)
        {
            txtTenNoiThat.Enabled = true;

            txtTenNoiThat.Text = "";
            cmbMaNoiThat.SelectedIndex = -1;
            LoadDataToGridView();
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {            
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblBCDSHDB;
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
            exRange.Range[" C2: E2 "].Font.Size = 16;
            exRange.Range[" C2: E2 "].Font.Name = " Times new roman";
            exRange.Range[" C2: E2 "].Font.Bold = true;
            exRange.Range[" C2: E2 "].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range[" C2: E2 "].MergeCells = true;
            exRange.Range[" C2: E2 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" C2: E2 "].Value = " Danh Sách Hóa Đơn Bán";

            DataTable tblThongtinHang;
            sql = "SELECT a.MaNoiThat,TenNoiThat FROM ChiTietDonDatHang as a inner join DMNoiThat as b on a.MaNoiThat=b.MaNoiThat WHERE a.MaNoiThat=N'" + cmbMaNoiThat.SelectedValue + "'";
            tblThongtinHang = DAO.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hàng:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHang.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Tên hàng";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHang.Rows[0][1].ToString();

            //Lấy thông tin các mặt hàng
            sql = " Select b.SoDDH,b.SoLuong,DonGiaBan,GiamGia,ThanhTien from" +
                    " DMNoiThat as a inner join ChiTietDonDatHang as b on a.MaNoiThat=b.MaNoiThat inner join" +
                    " DonDatHang as c on b.SoDDH=c.SoDDH where b.MaNoiThat=N'" + cmbMaNoiThat.SelectedValue + "'";
            tblBCDSHDB = DAO.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range[" A11: H11 "].Font.Bold = true;
            exRange.Range[" A11: H11 "].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range[" C11: H11 "].ColumnWidth = 12;
            exRange.Range[" A11: A11 "].Value = " STT ";
            exRange.Range[" B11: B11 "].Value = " Mã hóa đơn ";
            exRange.Range[" C11: C11 "].Value = " Số lượng ";
            exRange.Range[" D11: D11 "].Value = " Đơn giá ";
            exRange.Range[" E11: E11 "].Value = " Giảm giá ";
            exRange.Range[" F11: F11 "].Value = " Thành tiền ";
            for (hang = 0; hang <= tblBCDSHDB.Rows.Count - 1; hang++)
            {
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblBCDSHDB.Columns.Count - 1; cot++)

                    exSheet.Cells[cot + 2][hang + 12] = tblBCDSHDB.Rows[hang][cot].ToString();
                exSheet.Cells[2][hang + 12] = "'" + tblBCDSHDB.Rows[hang][0].ToString();
            }
            sql = "select sum(TongTien) from DonDatHang as a inner join ChiTietDonDatHang as b on a.SoDDH=b.SoDDH where MaNoiThat='" + cmbMaNoiThat.Text + "'";
            DataTable tblBC;
            tblBC = DAO.GetDataToTable(sql);
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblBC.Rows[0][0].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range[" C1: H1 "].MergeCells = true;
            exRange.Range[" C1: H1 "].Font.Bold = true;
            exRange.Range[" C1: H1 "].Font.Italic = true;
            exRange.Range[" C1: H1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range[" C1: H1"].Value = "Bằng chữ: " + DAO.ChuyenSoSangChu(Double.Parse(tblBC.Rows[0][0].ToString()));
            exRange = exSheet.Cells[4][hang + 16];
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
            exSheet.Name = " Hóa Đơn Bán";
            exApp.Visible = true;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            string sql;
            if (cmbMaNoiThat.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã nội thất", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbMaNoiThat.Focus();
                return;
            }
            sql = "Select b.MaNoiThat,TenNoiThat,b.SoLuong,GiamGia,ThanhTien,Sum(TongTien)as Tongtien " +
                "from DMNoiThat as a inner join ChiTietDonDatHang as b on a.MaNoiThat=b.MaNoiThat inner join" +
                " DonDatHang as c on b.SoDDH=c.SoDDH where b.MaNoiThat=N'"
                + cmbMaNoiThat.SelectedValue + "' group by b.MaNoiThat,TenNoiThat,b.SoLuong,GiamGia,ThanhTien";
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
            GridViewBCDSHDVaTTBan.DataSource = table;
        }
    }
}
