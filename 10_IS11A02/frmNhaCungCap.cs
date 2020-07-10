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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        public void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "Select * from NhaCungCap";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable NCC = new DataTable();
                myAdapter.Fill(NCC);
                dataGridViewNhaCungCap.DataSource = NCC;
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

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNCC .Enabled = true;
            txtTenNCC.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;

            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
        }

        private void dataGridViewNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dataGridViewNhaCungCap.CurrentRow.Cells["MaNCC"].Value.ToString();
            txtTenNCC.Text = dataGridViewNhaCungCap.CurrentRow.Cells["TenNCC"].Value.ToString();
            txtDienThoai.Text = dataGridViewNhaCungCap.CurrentRow.Cells["DienThoai"].Value.ToString();
            txtDiaChi.Text = dataGridViewNhaCungCap.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtMaNCC.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update NhaCungCap set TenNCC=N'" + txtTenNCC.Text.Trim() 
                + "',DiaChi=N'"+txtDiaChi.Text.Trim()+"',DienThoai=N'"+txtDienThoai.Text.Trim()+"'where MaNCC='"
                + txtMaNCC.Text + "'";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
            int KQ = (int)cmd.ExecuteNonQuery();//
            if (KQ > 0)
            {
                MessageBox.Show("Sửa thành công");
                LoadDataToGridView();
            }
            else
                MessageBox.Show("Sửa thất bại");
            DAO.CloseConnection();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao;//
            ThongBao = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);//
            if (ThongBao == DialogResult.OK)
            {
                string sql = "Delete from NhaCungCap where MaNCC='" + txtMaNCC.Text + "'";
                DAO.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = DAO.conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                DAO.CloseConnection();
                LoadDataToGridView();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhà cung cấp");
                txtMaNCC.Focus();
                return;
            }
            if (txtTenNCC.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp");
                txtTenNCC.Focus();
                return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên địa chỉ");
                txtDiaChi.Focus();
                return;
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại");
                txtDienThoai.Focus();
                return;
            }
            string SqlCheckKey = "Select * from NhaCungCap where MaNCC='" + txtMaNCC.Text.Trim() + "'";
            DAO.OpenConnection();
            if (DAO.CheckKeyExit(SqlCheckKey))
            {
                MessageBox.Show("Mã nhà cung cấp đã tồn tại");
                txtMaNCC.Focus();
                return;
            }
            else
            {
                string sql = "Insert into NhaCungCap values('" + txtMaNCC.Text.Trim() + "',N'"
                    + txtTenNCC.Text.Trim() + "',N'" + txtDiaChi.Text.Trim() + "',N'"
                    + txtDienThoai.Text.Trim() + "')";
                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lưu thành công");
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
    }
}
