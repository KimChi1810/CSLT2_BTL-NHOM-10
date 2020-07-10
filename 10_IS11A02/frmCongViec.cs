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
    public partial class frmCongViec : Form
    {
        public frmCongViec()
        {
            InitializeComponent();
        }

        public void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "Select * from CongViec";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable CongViec = new DataTable();
                myAdapter.Fill(CongViec);
                dataGridViewCongViec.DataSource = CongViec;
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

        private void frmCongViec_Load(object sender, EventArgs e)
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
            txtMaCV.Enabled = true;
            txtTenCV.Enabled = true;
            txtMaCV.Text = "";
            txtTenCV.Text = "";
        }
        private void dataGridViewCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCV.Text = dataGridViewCongViec.CurrentRow.Cells["MaCV"].Value.ToString();
            txtTenCV.Text = dataGridViewCongViec.CurrentRow.Cells["TenCV"].Value.ToString();
            txtMaCV.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update CongViec set TenCV=N'" + txtTenCV.Text.Trim() + "'where MaCV='"
                + txtMaCV.Text + "'";
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
                string sql = "Delete from CongViec where MaCV='" + txtMaCV.Text + "'";
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
            if (txtMaCV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã công việc");
                txtMaCV.Focus();
                return;
            }
            if (txtTenCV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên công việc");
                txtTenCV.Focus();
                return;
            }
            string SqlCheckKey = "Select * from CongViec where MaCV='" + txtMaCV.Text.Trim() + "'";
            DAO.OpenConnection();
            if (DAO.CheckKeyExit(SqlCheckKey))
            {
                MessageBox.Show("Mã công việc đã tồn tại");
                txtMaCV.Focus();
                return;
            }
            else
            {
                string sql = "Insert into CongViec values('" + txtMaCV.Text.Trim() + "',N'" 
                    + txtTenCV.Text.Trim() + "')";
                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lưu thành công");
                DAO.CloseConnection();
                LoadDataToGridView();
            }

        }
    }
}
