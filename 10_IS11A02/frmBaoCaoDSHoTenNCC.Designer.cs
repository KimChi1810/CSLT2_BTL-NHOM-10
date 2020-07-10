namespace BTN_10_SO_26
{
    partial class frmBaoCaoDSHoTenNCC
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
            this.txtTenNoiThat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMaNoiThat = new System.Windows.Forms.ComboBox();
            this.GridViewBCDSHoTenNCC = new System.Windows.Forms.DataGridView();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBaoCaoLai = new System.Windows.Forms.Button();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNoiThat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBCDSHoTenNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenNoiThat
            // 
            this.txtTenNoiThat.Location = new System.Drawing.Point(189, 113);
            this.txtTenNoiThat.Name = "txtTenNoiThat";
            this.txtTenNoiThat.Size = new System.Drawing.Size(169, 20);
            this.txtTenNoiThat.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tên nội thất";
            // 
            // cmbMaNoiThat
            // 
            this.cmbMaNoiThat.FormattingEnabled = true;
            this.cmbMaNoiThat.Location = new System.Drawing.Point(189, 79);
            this.cmbMaNoiThat.Name = "cmbMaNoiThat";
            this.cmbMaNoiThat.Size = new System.Drawing.Size(169, 21);
            this.cmbMaNoiThat.TabIndex = 18;
            this.cmbMaNoiThat.TextChanged += new System.EventHandler(this.cmbMaNoiThat_TextChanged);
            // 
            // GridViewBCDSHoTenNCC
            // 
            this.GridViewBCDSHoTenNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewBCDSHoTenNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.MaNoiThat,
            this.DiaChi,
            this.DienThoai,
            this.NgayNhap});
            this.GridViewBCDSHoTenNCC.Location = new System.Drawing.Point(95, 166);
            this.GridViewBCDSHoTenNCC.Name = "GridViewBCDSHoTenNCC";
            this.GridViewBCDSHoTenNCC.Size = new System.Drawing.Size(637, 194);
            this.GridViewBCDSHoTenNCC.TabIndex = 17;
            this.GridViewBCDSHoTenNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewBCDSHoTenNCC_CellClick);
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(556, 76);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(167, 20);
            this.txtThang.TabIndex = 16;
            this.txtThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThang_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(475, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã nội thất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(157, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Báo cáo danh sách họ tên nhà cung cấp";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(644, 406);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(59, 23);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBaoCaoLai
            // 
            this.btnBaoCaoLai.Location = new System.Drawing.Point(463, 406);
            this.btnBaoCaoLai.Name = "btnBaoCaoLai";
            this.btnBaoCaoLai.Size = new System.Drawing.Size(71, 23);
            this.btnBaoCaoLai.TabIndex = 23;
            this.btnBaoCaoLai.Text = "Báo cáo lại";
            this.btnBaoCaoLai.UseVisualStyleBackColor = true;
            this.btnBaoCaoLai.Click += new System.EventHandler(this.btnBaoCaoLai_Click);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Location = new System.Drawing.Point(281, 406);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(77, 23);
            this.btnInBaoCao.TabIndex = 22;
            this.btnInBaoCao.Text = "In báo cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(104, 406);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(59, 23);
            this.btnBaoCao.TabIndex = 21;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.Name = "MaNCC";
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên nhà cung cấp";
            this.TenNCC.Name = "TenNCC";
            // 
            // MaNoiThat
            // 
            this.MaNoiThat.DataPropertyName = "MaNoiThat";
            this.MaNoiThat.HeaderText = "Mã nội thất";
            this.MaNoiThat.Name = "MaNoiThat";
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
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            // 
            // frmBaoCaoDSHoTenNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBaoCaoLai);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.txtTenNoiThat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMaNoiThat);
            this.Controls.Add(this.GridViewBCDSHoTenNCC);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBaoCaoDSHoTenNCC";
            this.Text = "Báo cáo danh sách họ tên nhà cung cấp";
            this.Load += new System.EventHandler(this.frmBaoCaoDSHoTenNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBCDSHoTenNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenNoiThat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMaNoiThat;
        private System.Windows.Forms.DataGridView GridViewBCDSHoTenNCC;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBaoCaoLai;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNoiThat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
    }
}