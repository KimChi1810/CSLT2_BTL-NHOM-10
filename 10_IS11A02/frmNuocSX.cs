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
    public partial class frmNuocSX : Form
    {
        public frmNuocSX()
        {
            InitializeComponent();
        }

        private void frmNuocSX_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
        public void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "Select * from NuocSanXuat";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable NuocSX = new DataTable();
                myAdapter.Fill(NuocSX);
                dataGridViewNuocSX.DataSource = NuocSX;
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

        private void dataGridViewNuocSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtManuocSX.Text = dataGridViewNuocSX.CurrentRow.Cells["MaNuocSX"].Value.ToString();
            txtTennuocSX.Text = dataGridViewNuocSX.CurrentRow.Cells["TenNuocSX"].Value.ToString();
            txtManuocSX.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtManuocSX.Enabled = true;
            txtTennuocSX.Enabled = true;
            txtManuocSX.Text = "";
            txtTennuocSX.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update NuocSanXuat set TenNuocSX=N'" + txtTennuocSX.Text.Trim() + "'where MaNuocSX=N'" + txtManuocSX.Text + "'";
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
            DialogResult ThongBao;
            ThongBao = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);//
            if (ThongBao == DialogResult.OK)
            {
                string sql = "Delete from NuocSanXuat where MaNuocSX='" + txtManuocSX.Text + "'";
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
            if (txtManuocSX.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nước SX");
                txtManuocSX.Focus();
                return;//
            }
            if (txtTennuocSX.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nước SX");
                txtTennuocSX.Focus();
                return;//
            }
            string SqlCheckKey = "Select * from NuocSanXuat where MaNuocSX='" + txtManuocSX.Text.Trim() + "'";
            DAO.OpenConnection();//
            if (DAO.CheckKeyExit(SqlCheckKey))
            {
                MessageBox.Show("Mã nước sản xuất đã tồn tại");
                txtManuocSX.Focus();
                return;
            }
            else
            {
                string sql = "Insert into NuocSanXuat values('" + txtManuocSX.Text.Trim() + "',N'" + txtTennuocSX.Text.Trim() + "')";
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
    }
}