using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace BTN_10_SO_26
{
    public partial class frmTimKiemSanPham : Form
    {
        public frmTimKiemSanPham()
        {
            InitializeComponent();
        }

        private void frmTimKiemSanPham_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
        private void ResetValues()
        {
            txtAnh.Text = "";
            txtDonGiaBan.Text = "0";
            txtDonGiaNhap.Text = "0";
            txtCTDonGiaNhap.Text = "0";
            txtMaLoai.Text = "";
            txtMaNuocSX.Text = "";
            txtMaChatLieu.Text = "";
            txtDonGiaNhap.Text = "";
            txtSoLuong.Text = "0";
            txtTenNT.Text = "";
            txtTenLoai.Text = "";
            txtTenNuocSX.Text = "";
            txtTenChatLieu.Text = "";
            PicAnh.Image = null;
        }

        public void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "Select MaNoiThat,a.MaLoai,TenLoai,a.MaChatLieu,TenChatLieu,a.MaNuocSX,TenNuocSX," +
                    "DonGiaNhap from DMNoiThat as a inner join TheLoai as b on a.MaLoai=b.MaLoai " +
                    "inner join ChatLieu as c on a.MaChatLieu=c.MaChatLieu inner join NuocSanXuat " +
                    "as d on a.MaNuocSX=d.MaNuocSX";
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
            ResetValues();
            LoadDataToGridView();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaLoai.Text == "") && (txtTenLoai.Text == "")&&(txtMaChatLieu.Text == "")&& (txtTenChatLieu.Text == "") && (txtMaNuocSX.Text == "") && (txtTenNuocSX.Text == "") &&
               (txtDonGiaNhap.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm");
                return;
            }
            sql = "Select MaNoiThat,a.MaLoai,TenLoai,a.MaChatLieu,TenChatLieu,a.MaNuocSX,TenNuocSX," +
                    "DonGiaNhap,MaKieu,MaMau,Anh,DonGiaBan,SoLuong,MaMau,TenNoiThat from DMNoiThat as a inner join TheLoai as b on a.MaLoai=b.MaLoai " +
                    "inner join ChatLieu as c on a.MaChatLieu=c.MaChatLieu inner join NuocSanXuat " +
                    "as d on a.MaNuocSX=d.MaNuocSX where 1=1";
            if (txtMaLoai.Text != "")
                sql = sql + " AND a.MaLoai Like N'%" + txtMaLoai.Text + "%'";
            if (txtTenLoai.Text != "")
                sql = sql + " AND TenLoai Like N'%" + txtTenLoai.Text + "%'";
            if (txtMaChatLieu.Text != "")
                sql = sql + " AND a.MaChatLieu Like N'%" + txtMaChatLieu.Text + "%'";
            if (txtTenChatLieu.Text != "")
                sql = sql + " AND TenChatLieu Like N'%" + txtTenChatLieu.Text + "%'";
            if (txtMaNuocSX.Text != "")
                sql = sql + " AND a.MaNuocSX Like N'%" + txtMaNuocSX.Text + "%'";
            if (txtTenNuocSX.Text != "")
                sql = sql + " AND TenNuocSX Like N'%" + txtTenNuocSX.Text + "%'";
            if (txtDonGiaNhap.Text != "")
                sql = sql + " AND DonGiaNhap = '" + txtDonGiaNhap.Text + "'";
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
                txtAnh.Text = GridViewTim.CurrentRow.Cells["Anh"].Value.ToString();
                txtDonGiaBan.Text = GridViewTim.CurrentRow.Cells["DonGiaBan"].Value.ToString();
                txtCTDonGiaNhap.Text = GridViewTim.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
                txtDonGiaNhap.Text = GridViewTim.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
                txtMaChatLieu.Text = GridViewTim.CurrentRow.Cells["MaChatLieu"].Value.ToString();
                txtMaLoai.Text = GridViewTim.CurrentRow.Cells["MaLoai"].Value.ToString();
                txtMaNuocSX.Text = GridViewTim.CurrentRow.Cells["MaNuocSX"].Value.ToString();
                txtSoLuong.Text = GridViewTim.CurrentRow.Cells["SoLuong"].Value.ToString();
                txtTenNT.Text = GridViewTim.CurrentRow.Cells["TenNoiThat"].Value.ToString();
                txtMaMau.Text = GridViewTim.CurrentRow.Cells["MaMau"].Value.ToString();
                txtMaKieu.Text = GridViewTim.CurrentRow.Cells["MaKieu"].Value.ToString();
                txtTenLoai.Text = GridViewTim.CurrentRow.Cells["TenLoai"].Value.ToString();
                txtTenChatLieu.Text = GridViewTim.CurrentRow.Cells["TenChatLieu"].Value.ToString();
                txtTenNuocSX.Text = GridViewTim.CurrentRow.Cells["TenNuocSX"].Value.ToString();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgopen = new OpenFileDialog();
            dlgopen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgopen.FilterIndex = 2;
            dlgopen.Title = "Chọn ảnh minh họa cho sản phẩm";
            if (dlgopen.ShowDialog() == DialogResult.OK)
            {
                PicAnh.Image = Image.FromFile(dlgopen.FileName);
                txtAnh.Text = dlgopen.FileName;
            }
        }

        private void txtDonGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
