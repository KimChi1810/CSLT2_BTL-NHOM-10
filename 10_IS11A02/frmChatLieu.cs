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
    public partial class frmChatLieu : Form
    {
        public frmChatLieu()
        {
            InitializeComponent();
        }

        private void frmChatLieu_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
        public void LoadDataToGridView()
        {
            //Mở kết nối
            try
            {
                DAO.OpenConnection();
                string sql = "Select * from Chatlieu";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable ChatLieu = new DataTable();
                myAdapter.Fill(ChatLieu);
                dataGridViewChatlieu.DataSource = ChatLieu;
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

        private void dataGridViewChatlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMachatlieu.Text = dataGridViewChatlieu.CurrentRow.Cells["MaChatLieu"].Value.ToString();
            txtTenchatlieu.Text = dataGridViewChatlieu.CurrentRow.Cells["TenChatLieu"].Value.ToString();
            txtMachatlieu.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMachatlieu.Enabled = true;
            txtTenchatlieu.Enabled = true;

            txtTenchatlieu.Text = "";
            txtMachatlieu.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update ChatLieu set TenChatLieu=N'" + txtTenchatlieu.Text.Trim() + "'where MaChatLieu=N'" + txtMachatlieu.Text + "'";
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
                string sql = "Delete from ChatLieu where MaChatLieu='" + txtMachatlieu.Text + "'";
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
            if (txtMachatlieu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã chất liệu");
                txtMachatlieu.Focus();
                return;
            }
            if (txtTenchatlieu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu");
                txtTenchatlieu.Focus();
                return;
            }

            string SqlCheckKey = "Select * from ChatLieu where MaChatLieu='" + txtMachatlieu.Text.Trim() + "'";
            DAO.OpenConnection();
            if (DAO.CheckKeyExit(SqlCheckKey))
            {
                MessageBox.Show("Mã chất liệu đã tồn tại");
                txtMachatlieu.Focus();
                return;
            }
            else
            {
                string sql = "Insert into ChatLieu values('" + txtMachatlieu.Text.Trim() + "',N'"
                    + txtTenchatlieu.Text.Trim() + "')";
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
