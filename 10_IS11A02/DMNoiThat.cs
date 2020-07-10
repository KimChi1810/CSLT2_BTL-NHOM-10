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
    public partial class DMNoiThat : Form
    {
        public DMNoiThat()
        {
            InitializeComponent();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtThoiGianBaoHanh_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "Select * from DMNoiThat";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable TB = new DataTable();
                myAdapter.Fill(TB);
                GridViewDMNoiThat.DataSource = TB;
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

        private void DMNoiThat_Load(object sender, EventArgs e)
        {
            String Sql = "Select MaLoai, TenLoai from TheLoai";
            DAO.OpenConnection();
            DAO.FillDataToCombo(Sql, cmbMaLoai, "MaLoai", "TenLoai");

            Sql = "Select MaKieu, TenKieu from KieuDang";
            DAO.FillDataToCombo(Sql, cmbMaKieu, "MaKieu", "TenKieu");

            Sql = "Select MaMau, TenMau from MauSac";
            DAO.FillDataToCombo(Sql, cmbMaMau, "MaMau", "TenMau");

            Sql = "Select MaChatLieu, TenChatLieu from ChatLieu";
            DAO.FillDataToCombo(Sql, cmbMaChatLieu, "MaChatLieu", "TenChatLieu");

            Sql = "Select MaNuocSX, TenNuocSX from NuocSanXuat";
            DAO.FillDataToCombo(Sql, cmbMaNuocSX, "MaNuocSX", "TenNuocSX");

            LoadDataToGridView();
        }

        private void GridViewDMNoiThat_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            txtMaNoiThat.Text = GridViewDMNoiThat.CurrentRow.Cells["Manoithat"].Value.ToString();
            txtTenNoiThat.Text = GridViewDMNoiThat.CurrentRow.Cells["Tennoithat"].Value.ToString();
            cmbMaLoai.Text = GridViewDMNoiThat.CurrentRow.Cells["Maloai"].Value.ToString();
            cmbMaKieu.Text = GridViewDMNoiThat.CurrentRow.Cells["Makieu"].Value.ToString();
            cmbMaMau.Text = GridViewDMNoiThat.CurrentRow.Cells["Mamau"].Value.ToString();
            cmbMaChatLieu.Text = GridViewDMNoiThat.CurrentRow.Cells["Machatlieu"].Value.ToString();
            cmbMaNuocSX.Text = GridViewDMNoiThat.CurrentRow.Cells["ManuocSX"].Value.ToString();
            txtSoLuong.Text = GridViewDMNoiThat.CurrentRow.Cells["Soluong"].Value.ToString();
            txtDonGiaNhap.Text = GridViewDMNoiThat.CurrentRow.Cells["Dongianhap"].Value.ToString();
            txtDonGiaBan.Text = GridViewDMNoiThat.CurrentRow.Cells["Dongiaban"].Value.ToString();
            txtAnh.Text = GridViewDMNoiThat.CurrentRow.Cells["Anh"].Value.ToString();
            txtThoiGianBaoHanh.Text = GridViewDMNoiThat.CurrentRow.Cells["Thoigianbaohanh"].Value.ToString();
            txtMaNoiThat.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtAnh.Enabled = true;
            txtDonGiaBan.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtMaNoiThat.Enabled = true;
            txtSoLuong.Enabled = true;
            txtTenNoiThat.Enabled = true;
            txtThoiGianBaoHanh.Enabled = true;

            txtMaNoiThat.Text = "";
            txtTenNoiThat.Text = "";
            cmbMaLoai.SelectedIndex = -1;
            cmbMaKieu.SelectedIndex = -1;
            cmbMaMau.SelectedIndex = -1;
            cmbMaChatLieu.SelectedIndex = -1;
            cmbMaNuocSX.SelectedIndex = -1;
            txtSoLuong.Text = "";
            txtDonGiaNhap.Text = "";
            txtDonGiaBan.Text = "";
            txtAnh.Text = "";
            txtThoiGianBaoHanh.Text = "";
        }

        public void ResetValue()
        {
            txtMaNoiThat.Text = "";
            txtTenNoiThat.Text = "";
            cmbMaLoai.SelectedIndex = -1;
            cmbMaKieu.SelectedIndex = -1;
            cmbMaMau.SelectedIndex = -1;
            cmbMaChatLieu.SelectedIndex = -1;
            cmbMaNuocSX.SelectedIndex = -1;
            txtSoLuong.Text = "";
            txtDonGiaNhap.Text = "";
            txtDonGiaBan.Text = "";
            txtAnh.Text = "";
            txtThoiGianBaoHanh.Text = "";
            picAnh.Image = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao;
            ThongBao = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);//
            if (ThongBao == DialogResult.OK)
            {
                string Sql = "delete from DMNoiThat where MaNoiThat = N'" + txtMaNoiThat.Text + "'";
                SqlCommand cmd = new SqlCommand();
                DAO.OpenConnection();
                cmd.CommandText = Sql;
                cmd.Connection = DAO.conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                DAO.CloseConnection();
                LoadDataToGridView();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string Sql = "Update DMNoiThat set TenNoiThat = N'" + txtTenNoiThat.Text.Trim() + "',MaLoai=N'" + cmbMaLoai.SelectedValue.ToString() + "',MaKieu=N'"
            + cmbMaKieu.SelectedValue.ToString() + "',MaMau=N'" + cmbMaMau.SelectedValue.ToString() + "',MaChatLieu=N'"
            + cmbMaChatLieu.SelectedValue.ToString() + "',MaNuocSX=N'" + cmbMaNuocSX.SelectedValue.ToString() + "',SoLuong='"
            + txtSoLuong.Text.Trim() + "',DonGiaNhap='" + txtDonGiaNhap.Text.Trim() + "',DonGiaBan='" + txtDonGiaBan.Text.Trim() + "',Anh=N'"
            + txtAnh.Text.Trim() + "',ThoiGianBaoHanh='" + txtThoiGianBaoHanh.Text.Trim() + "'where MaNoiThat = N'" + txtMaNoiThat.Text + "'";

            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DAO.conn;
            cmd.CommandText = Sql;
            int KQ = (int)cmd.ExecuteNonQuery();
            if (KQ > 0)
            {
                MessageBox.Show("Sửa thành công");
                LoadDataToGridView();
            }
            else
                MessageBox.Show("Sửa thất bại");
            DAO.CloseConnection();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
                this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNoiThat.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nội thất");
                txtMaNoiThat.Focus();
                return;
            }
            if (txtTenNoiThat.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nội thất");
                txtTenNoiThat.Focus();
                return;
            }
            if (cmbMaLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn mã loại");
                return;
            }
            if (cmbMaKieu.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn mã kiểu");
                return;
            }
            if (cmbMaMau.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn mã màu");
                return;
            }
            if (cmbMaChatLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn mã chất liệu");
                return;
            }
            if (cmbMaNuocSX.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn mã nước SX");
                return;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng");
                txtSoLuong.Focus();
                return;
            }
            if (txtDonGiaNhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đơn giá nhập");
                txtDonGiaNhap.Focus();
                return;
            }
            if (txtDonGiaBan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đơn giá bán");
                txtDonGiaBan.Focus();
                return;
            }
            if (txtThoiGianBaoHanh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thời gian bảo hành");
                txtThoiGianBaoHanh.Focus();
                return;
            }
            string SQLCheckKey = "select * from DMNoithat where MaNoiThat=N'" + txtMaNoiThat.Text + "'";
            DAO.OpenConnection();
            if (DAO.CheckKeyExit(SQLCheckKey))
            {
                MessageBox.Show("Mã nội thất đã tồn tại");
                txtMaNoiThat.Focus();
                return;
            }
            else
            {
                string sql = "Insert into DMNoiThat values('" + txtMaNoiThat.Text.Trim() + "',N'"
                    + txtTenNoiThat.Text.Trim() + "',N'" + cmbMaLoai.SelectedValue.ToString() + "',N'"
                    + cmbMaKieu.SelectedValue.ToString() + "',N'" + cmbMaMau.SelectedValue.ToString() + "',N'"
                    + cmbMaChatLieu.SelectedValue.ToString() + "',N'" + cmbMaNuocSX.SelectedValue.ToString() + "','"
                    + txtSoLuong.Text + "','" + txtDonGiaNhap.Text + "','" + txtDonGiaBan.Text + "','" + txtAnh.Text + "','"
                    + txtThoiGianBaoHanh.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lưu thành công");
                DAO.CloseConnection();
                LoadDataToGridView();
            }
        }

        private void txtDonGiaNhap_TextChanged(object sender, EventArgs e)
        {
            double dgn, dgb;
            if (txtDonGiaNhap.Text == "")
                dgn = 0;
            else
                dgn = Convert.ToDouble(txtDonGiaNhap.Text);
            dgb = dgn * 1.1;
            txtDonGiaBan.Text = dgb.ToString();          
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            txtMaNoiThat.Enabled = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaNoiThat.Text == "") && (txtTenNoiThat.Text == "") && (cmbMaLoai.Text == "") && (cmbMaKieu.Text == "") && (cmbMaChatLieu.Text == "") && (cmbMaNuocSX.Text == "") && (cmbMaMau.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from DMNoiThat WHERE 1=1";
            if (txtMaNoiThat.Text != "")
                sql = sql + " AND MaNoiThat LIKE '%" + txtMaNoiThat.Text + "%'";
            if (txtTenNoiThat.Text != "")
                sql = sql + " AND TenNoiThat LIKE '%" + txtTenNoiThat.Text + "%'";
            if (cmbMaChatLieu.Text != "")
                sql = sql + " AND MaChatLieu Like '%" + cmbMaChatLieu.SelectedValue + "%'";
            if (cmbMaLoai.Text != "")
                sql = sql + " AND MaLoai Like '%" + cmbMaLoai.SelectedValue + "%'";
            if (cmbMaKieu.Text != "")
                sql = sql + " AND MaKieu Like '%" + cmbMaKieu.SelectedValue + "%'";
            if (cmbMaNuocSX.Text != "")
                sql = sql + " AND MaNuocSX Like '%" + cmbMaNuocSX.SelectedValue + "%'";
            if (cmbMaMau.Text != "")
                sql = sql + " AND MaMau Like '%" + cmbMaMau.SelectedValue + "%'";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + table.Rows.Count + " bản ghi thỏa mãn điều kiện!!!",
"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            GridViewDMNoiThat.DataSource = table;
            ResetValue();
        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
    }
}
