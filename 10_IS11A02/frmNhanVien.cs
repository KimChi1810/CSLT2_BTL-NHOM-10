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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao;
            ThongBao = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);//
            if (ThongBao == DialogResult.OK)
            {
                string Sql = "delete from NhanVien where MaNV = N'" + txtMaNV.Text + "'";
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

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            string Sql = "Select Maca from CaLam";
            DAO.OpenConnection();
            DAO.FillDataToCombo(Sql, cmbMaCa, "Maca", "Tenca");

            Sql = "Select MaCV from CongViec";
            DAO.OpenConnection();
            DAO.FillDataToCombo(Sql, cmbMaCV, "MaCV", "TenCV");

            LoadDataToGridView();
            DAO.CloseConnection();
        }
        private void LoadDataToGridView()
        {
            string Sql = "Select * from NhanVien";
            SqlDataAdapter adapter = new SqlDataAdapter(Sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            GridViewNhanVien.DataSource = table;
        }

        private void GridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = GridViewNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            txtTenNV.Text = GridViewNhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
            txtGioiTinh.Text = GridViewNhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString();
            txtDiaChi.Text = GridViewNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            cmbMaCa.Text = GridViewNhanVien.CurrentRow.Cells["MaCa"].Value.ToString();
            cmbMaCV.Text = GridViewNhanVien.CurrentRow.Cells["MaCV"].Value.ToString();
            txtDienThoai.Text = GridViewNhanVien.CurrentRow.Cells["DienThoai"].Value.ToString();
            mskNgaySinh.Text = GridViewNhanVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txtMaNV.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = true;
            txtTenNV.Enabled = true;
            txtGioiTinh.Enabled = true;
            txtDienThoai.Enabled = true;
            txtDiaChi.Enabled = true;
            mskNgaySinh.Enabled = true;

            txtDiaChi.Text = "";
            txtGioiTinh.Text = "";
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cmbMaCa.SelectedIndex = -1;
            cmbMaCV.SelectedIndex = -1;
            txtDienThoai.Text = "";
            mskNgaySinh.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String Sql = "Update NhanVien set TenNV = N'" + txtTenNV.Text.Trim() + "',Maca=N'" + cmbMaCa.SelectedValue.ToString() + "',MaCV=N'"
            + cmbMaCV.SelectedValue.ToString() + "',Gioitinh=N'"
            + txtGioiTinh.Text.Trim() + "',Diachi='" + txtDiaChi.Text.Trim() +"',Dienthoai='" + txtDienThoai.Text.ToString() +
            "', Ngaysinh='" + DAO.ConvertDateTime(mskNgaySinh.Text) + "'where MaNV = N'" + txtMaNV.Text + "'";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = Sql;
            cmd.Connection = DAO.conn;
            int kq=(int)cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công");
                LoadDataToGridView();
            }
            else  
                MessageBox.Show("Sửa thất bại");
            DAO.CloseConnection();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã NV");
                txtMaNV.Focus();
                return;
            }
            if (txtTenNV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên NV");
                txtTenNV.Focus();
                return;
            }
            if (txtGioiTinh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giới tính");
                txtGioiTinh.Focus();
                return;
            }
            if (mskNgaySinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh");
                mskNgaySinh.Focus();
                return;
            }
            if (!DAO.IsDate(mskNgaySinh.Text))
            {
                MessageBox.Show("Nhập lại ngày sinh");
                mskNgaySinh.Text = "";
                mskNgaySinh.Focus();
                return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                txtDiaChi.Focus();
                return;
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại");
                txtDienThoai.Focus();
                return;//
            }
            if (cmbMaCa.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mã ca");
                return;
            }
            if (cmbMaCV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã CV");
                return;
            }
            string SqlCheckKey = "Select * from NhanVien where MaNV='" + txtMaNV.Text.Trim() + "'";
            DAO.OpenConnection();
            if (DAO.CheckKeyExit(SqlCheckKey))
            {
                MessageBox.Show("Mã NV đã tồn tại");
                txtMaNV.Focus();
                return;
            }
            else
            {
                string sql = "Insert into NhanVien values(N'" + txtMaNV.Text.Trim()
                    + "',N'" + txtTenNV.Text.Trim() + "',N'" + txtGioiTinh.Text.Trim()
                    + "','" + DAO.ConvertDateTime(mskNgaySinh.Text) + "',N'" + txtDienThoai.Text.Trim() + "',N'"
                    + txtDiaChi.Text.Trim() + "',N'" + cmbMaCa.SelectedValue + "',N'" + cmbMaCV.SelectedValue + "')";
                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lưu thành công");
                DAO.CloseConnection();
                LoadDataToGridView();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }
    }
}
