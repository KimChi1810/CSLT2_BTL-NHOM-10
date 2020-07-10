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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
        public void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "Select * from KhachHang";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable KH = new DataTable();
                myAdapter.Fill(KH);
                dataGridViewKH.DataSource = KH;
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

        private void dataGridViewKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dataGridViewKH.CurrentRow.Cells["MaKhach"].Value.ToString();
            txtTenKH.Text = dataGridViewKH.CurrentRow.Cells["TenKhach"].Value.ToString();
            txtDiaChi.Text = dataGridViewKH.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtDienThoai.Text = dataGridViewKH.CurrentRow.Cells["DienThoai"].Value.ToString();
            txtMaKH.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = true;
            txtTenKH.Enabled = true;
            txtDienThoai.Enabled = true;
            txtDiaChi.Enabled = true;

            txtTenKH.Text = "";
            txtMaKH.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update KhachHang set TenKhach=N'" + txtTenKH.Text.Trim() +"',DiaChi=N'"+txtDiaChi.Text.Trim()+"',DienThoai=N'"+txtDienThoai.Text.Trim()+"'where MaKhach=N'" + txtMaKH.Text + "'";
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
                string sql = "Delete from KhachHang where MaKhach='" + txtMaKH.Text + "'";
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
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng");
                txtMaKH.Focus();
                return;
            }
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng");
                txtTenKH.Focus();
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
                return;
            }
            string SqlCheckKey = "Select * from KhachHang where MaKhach='" + txtMaKH.Text.Trim() + "'";
            DAO.OpenConnection();//
            if (DAO.CheckKeyExit(SqlCheckKey))
            {
                MessageBox.Show("Mã khách hàng đã tồn tại");
                txtMaKH.Focus();
                return;
            }
            else
            {
                string sql = "Insert into KhachHang values(N'" + txtMaKH.Text.Trim() + "',N'" + txtTenKH.Text.Trim() + "',N'" + txtDiaChi.Text.Trim() + "',N'" + txtDienThoai.Text.Trim() + "')";
                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.CommandText = sql;
                cmd.Connection = DAO.conn;
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

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
