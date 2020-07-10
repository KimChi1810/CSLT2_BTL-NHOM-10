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
    public partial class frmCaLam : Form
    {
        public frmCaLam()
        {
            InitializeComponent();
        }

        private void frmCaLam_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
        public void LoadDataToGridView()
        {
            //Mở kết nối
            try
            {
                DAO.OpenConnection();
                string sql = "Select * from Calam";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable MauSac = new DataTable();
                myAdapter.Fill(MauSac);
                dataGridViewCalam.DataSource = MauSac;
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
        private void dataGridViewCalam_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaca.Text = dataGridViewCalam.CurrentRow.Cells["MaCa"].Value.ToString();
            txtTenca.Text = dataGridViewCalam.CurrentRow.Cells["TenCa"].Value.ToString();
            txtMaca.Enabled = false;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaca.Enabled = true;
            txtTenca.Enabled = true;

            txtTenca.Text = "";
            txtMaca.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update CaLam set TenCa=N'" + txtTenca.Text.Trim() + "'where MaCa=N'" + txtMaca.Text + "'";
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
                string sql = "Delete from CaLam where MaCa='" + txtMaca.Text + "'";
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
            if (txtMaca.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã ca làm");
                txtMaca.Focus();
                return;
            }
            if (txtTenca.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên ca làm");
                txtTenca.Focus();
                return;
            }

            string SqlCheckKey = "Select * from CaLam where MaCa='" + txtMaca.Text.Trim() + "'";
            DAO.OpenConnection();
            if (DAO.CheckKeyExit(SqlCheckKey))
            {
                MessageBox.Show("Mã ca làm đã tồn tại");
                txtMaca.Focus();
                return;
            }
            else
            {
                string sql = "Insert into CaLam values('" + txtMaca.Text.Trim() + "',N'"
                    + txtTenca.Text.Trim() + "')";
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
