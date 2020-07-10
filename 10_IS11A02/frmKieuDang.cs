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
    public partial class frmKieuDang : Form
    {
        public frmKieuDang()
        {
            InitializeComponent();
        }

        private void frmKieuDang_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }
        public void LoadDataToGridView()
        {
            //Mở kết nối
            try
            {
                DAO.OpenConnection();
                string sql = "Select * from KieuDang";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable KieuDang = new DataTable();
                myAdapter.Fill(KieuDang);
                dataGridViewKieudang.DataSource = KieuDang;
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
        private void dataGridViewKieudang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMakieu.Text = dataGridViewKieudang.CurrentRow.Cells["MaKieu"].Value.ToString();
            txtTenkieu.Text = dataGridViewKieudang.CurrentRow.Cells["TenKieu"].Value.ToString();
            txtMakieu.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMakieu.Enabled = true;
            txtTenkieu.Enabled = true;
            txtMakieu.Text = "";
            txtTenkieu.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update KieuDang set TenKieu=N'" + txtTenkieu.Text.Trim() + "'where MaKieu=N'"
                + txtMakieu.Text + "'";
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
                string sql = "Delete from KieuDang where MaKieu='" + txtMakieu.Text + "'";
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
            if (txtMakieu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhâp mã kiểu");
                txtMakieu.Focus();
                return;//
            }
            if (txtTenkieu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhâp tên kiểu");
                txtTenkieu.Focus();
                return;//
            }
            string SqlCheckKey = "Select * from KieuDang where MaKieu='" + txtMakieu.Text.Trim() + "'";
            DAO.OpenConnection();//
            if (DAO.CheckKeyExit(SqlCheckKey))
            {
                MessageBox.Show("Mã kiểu đã tồn tại");
                txtMakieu.Focus();
                return;
            }
            else
            {
                string sql = "Insert into KieuDang values('" + txtMakieu.Text.Trim() + "',N'" + txtTenkieu.Text.Trim() + "')";
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
