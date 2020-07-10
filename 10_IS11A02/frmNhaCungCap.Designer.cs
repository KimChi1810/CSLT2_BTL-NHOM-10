namespace BTN_10_SO_26
{
    partial class frmNhaCungCap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridViewNhaCungCap = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lbTenNCC = new System.Windows.Forms.Label();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.lbMaNCC = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(311, 142);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(263, 20);
            this.txtDiaChi.TabIndex = 55;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(149, 146);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(48, 16);
            this.lbDiaChi.TabIndex = 54;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(679, 430);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(52, 23);
            this.btnThoat.TabIndex = 52;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(542, 430);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(52, 23);
            this.btnLuu.TabIndex = 51;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(391, 430);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(52, 23);
            this.btnXoa.TabIndex = 50;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(228, 430);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(52, 23);
            this.btnSua.TabIndex = 49;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(69, 430);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(52, 23);
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridViewNhaCungCap
            // 
            this.dataGridViewNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.DiaChi,
            this.DienThoai});
            this.dataGridViewNhaCungCap.Location = new System.Drawing.Point(140, 249);
            this.dataGridViewNhaCungCap.Name = "dataGridViewNhaCungCap";
            this.dataGridViewNhaCungCap.Size = new System.Drawing.Size(444, 150);
            this.dataGridViewNhaCungCap.TabIndex = 47;
            this.dataGridViewNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhaCungCap_CellClick);
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.Name = "MaNCC";
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên NCC";
            this.TenNCC.Name = "TenNCC";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(311, 100);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(263, 20);
            this.txtTenNCC.TabIndex = 44;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(311, 60);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(263, 20);
            this.txtMaNCC.TabIndex = 43;
            // 
            // lbTenNCC
            // 
            this.lbTenNCC.AutoSize = true;
            this.lbTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNCC.Location = new System.Drawing.Point(149, 100);
            this.lbTenNCC.Name = "lbTenNCC";
            this.lbTenNCC.Size = new System.Drawing.Size(63, 16);
            this.lbTenNCC.TabIndex = 41;
            this.lbTenNCC.Text = "Tên NCC";
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDienThoai.Location = new System.Drawing.Point(149, 190);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(67, 16);
            this.lbDienThoai.TabIndex = 40;
            this.lbDienThoai.Text = "Điện thoại";
            // 
            // lbMaNCC
            // 
            this.lbMaNCC.AutoSize = true;
            this.lbMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNCC.Location = new System.Drawing.Point(149, 61);
            this.lbMaNCC.Name = "lbMaNCC";
            this.lbMaNCC.Size = new System.Drawing.Size(58, 16);
            this.lbMaNCC.TabIndex = 38;
            this.lbMaNCC.Text = "Mã NCC";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(248, 3);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(181, 31);
            this.lable1.TabIndex = 37;
            this.lable1.Text = "Nhà cung cấp";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(311, 186);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(263, 20);
            this.txtDienThoai.TabIndex = 56;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewNhaCungCap);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.lbTenNCC);
            this.Controls.Add(this.lbDienThoai);
            this.Controls.Add(this.lbMaNCC);
            this.Controls.Add(this.lable1);
            this.Name = "frmNhaCungCap";
            this.Text = "frmNhaCungCap";
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhaCungCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridViewNhaCungCap;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label lbTenNCC;
        private System.Windows.Forms.Label lbDienThoai;
        private System.Windows.Forms.Label lbMaNCC;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
    }
}