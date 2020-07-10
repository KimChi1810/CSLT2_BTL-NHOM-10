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
    public partial class frmMauSac : Form
    {
        public frmMauSac()
        {
            InitializeComponent();
        }

        private void frmMauSac_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
        public void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "Select * from MauSac";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable MauSac = new DataTable();
                myAdapter.Fill(MauSac);
                dataGridViewMausac.DataSource = MauSac;
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

        private void dataGridViewMausac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMamau.Text = dataGridViewMausac.CurrentRow.Cells["Mamau"].Value.ToString();
            txtTenmau.Text = dataGridViewMausac.CurrentRow.Cells["Tenmau"].Value.ToString();
            txtMamau.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update MauSac set TenMau=N'" + txtTenmau.Text.Trim() + "'where MaMau='"
                + txtMamau.Text + "'";
            DAO.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.conn;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao;
            ThongBao = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);//
            if (ThongBao == DialogResult.OK)
            {
                string sql = "Delete from MauSac where MaMau='" + txtMamau.Text + "'";
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMamau.Enabled = true;
            txtTenmau.Enabled = true;
            txtMamau.Text = "";
            txtTenmau.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMamau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã màu");
                txtMamau.Focus();
                return;//
            }
            if (txtTenmau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên màu");
                txtTenmau.Focus();
                return;//
            }
            string SqlCheckKey = "Select * from MauSac where MaMau='" + txtMamau.Text.Trim() + "'";
            DAO.OpenConnection();//
            if (DAO.CheckKeyExit(SqlCheckKey))
            {
                MessageBox.Show("Mã màu đã tồn tại");
                txtMamau.Focus();
                return;
            }
            else
            {
                string sql = "Insert into MauSac values('" + txtMamau.Text.Trim() + "',N'" + txtTenmau.Text.Trim() + "')";
                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.CommandText = sql;
                cmd.Connection = DAO.conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lưu thành công");
                DAO.CloseConnection();
                LoadDataToGridView();

            }
        }
    }
}
