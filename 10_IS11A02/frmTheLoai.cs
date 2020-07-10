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
    public partial class frmTheLoai : Form
    {
        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
        public void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "Select * from TheLoai";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable NuocSX = new DataTable();
                myAdapter.Fill(NuocSX);
                dataGridViewTheloai.DataSource = NuocSX;
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

        private void dataGridViewTheloai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMatheloai.Text = dataGridViewTheloai.CurrentRow.Cells["MaLoai"].Value.ToString();
            txtTentheloai.Text = dataGridViewTheloai.CurrentRow.Cells["TenLoai"].Value.ToString();
            txtMatheloai.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMatheloai.Enabled = true;
            txtTentheloai.Enabled = true;
            txtTentheloai.Text = "";
            txtMatheloai.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update TheLoai set TenLoai=N'" + txtTentheloai.Text.Trim() + "'where MaLoai=N'" + txtMatheloai.Text + "'";
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
                string sql = "Delete from TheLoai where MaLoai='" + txtMatheloai.Text + "'";
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
            if (txtMatheloai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhâp mã thể loại");
                txtMatheloai.Focus();
                return;//
            }
            if (txtTentheloai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhâp tên thể loại");
                txtTentheloai.Focus();
                return;//
            }
            string SqlCheckKey = "Select * from TheLoai where MaLoai='" + txtMatheloai.Text.Trim() + "'";
            DAO.OpenConnection();//
            if (DAO.CheckKeyExit(SqlCheckKey))
            {
                MessageBox.Show("Mã thể loại đã tồn tại");
                txtMatheloai.Focus();
                return;
            }
            else
            {
                string sql = "Insert into TheLoai values('" + txtMatheloai.Text.Trim() + "',N'" + txtTentheloai.Text.Trim() + "')";
                SqlCommand cmd = new SqlCommand(sql, DAO.conn);
                cmd.CommandText = sql;
                //cmd.Connection = DAO.conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lưu thành công");
                DAO.CloseConnection();
                LoadDataToGridView();

            }
        }

    }
}
