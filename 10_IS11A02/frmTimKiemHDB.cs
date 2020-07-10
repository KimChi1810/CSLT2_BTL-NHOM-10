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

namespace BTN_10_SO_26
{
    public partial class frmTimKiemHDB : Form
    {
        public frmTimKiemHDB()
        {
            InitializeComponent();
        }
        public void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "SELECT a.SoDDH,MaNoiThat,MaKhach,MaNV " +
                    "FROM DonDatHang as a join ChiTietDonDatHang as b on a.SoDDH=b.SoDDH";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable table = new DataTable();
                myAdapter.Fill(table);
                GridViewTim.DataSource = table;
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
        private void frmTimKiemHoaDon_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
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

        private void btnTimLai_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = true;
            txtMaNoiThat.Enabled = true;
            txtMaNV.Enabled = true;

            txtMaNV.Text = "";
            txtMaNoiThat.Text = "";
            txtMaKH.Text = "";
            LoadDataToGridView();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaNoiThat.Text == "") && (txtMaNV.Text == "") && (txtMaKH.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm");
                return;
            }
            sql = "SELECT a.SoDDH,MaNoiThat,MaKhach,MaNV,NgayDat,NgayGiao,Thue,DatCoc,TongTien FROM DonDatHang as a join ChiTietDonDatHang as b on a.SoDDH=b.SoDDH WHERE 1=1";
            if (txtMaNoiThat.Text != "")
                sql = sql + " AND MaNoiThat LIKE N'%" + txtMaNoiThat.Text + "%'";
            if (txtMaNV.Text != "")
                sql = sql + " AND MaNV Like N'%" + txtMaNV.Text + "%'";
            if (txtMaKH.Text != "")
                sql = sql + " AND MaKhach Like N'%" + txtMaKH.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Có " + table.Rows.Count + " bản ghi thỏa mãn điều kiện!!!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            GridViewTim.DataSource = table;
        }

        private void GridViewTim_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                txtSoDDH.Text = GridViewTim.CurrentRow.Cells["SoDDH"].Value.ToString();
                txtMaNV.Text = GridViewTim.CurrentRow.Cells["MaNV"].Value.ToString();
                txtMaKH.Text = GridViewTim.CurrentRow.Cells["MaKhach"].Value.ToString();
                txtTongTien.Text = GridViewTim.CurrentRow.Cells["TongTien"].Value.ToString();
                mskNgayDat.Text = GridViewTim.CurrentRow.Cells["NgayDat"].Value.ToString();
                mskNgayGiao.Text = GridViewTim.CurrentRow.Cells["NgayGiao"].Value.ToString();
                txtDatCoc.Text = GridViewTim.CurrentRow.Cells["DatCoc"].Value.ToString();
                txtThue.Text = GridViewTim.CurrentRow.Cells["Thue"].Value.ToString();
                txtMaNoiThat.Text = GridViewTim.CurrentRow.Cells["MaNoiThat"].Value.ToString();
            }
        }
    }
}

