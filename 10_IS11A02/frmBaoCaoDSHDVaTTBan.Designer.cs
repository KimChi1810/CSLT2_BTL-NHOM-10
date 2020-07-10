namespace BTN_10_SO_26
{
    partial class frmBaoCaoDSHDVaTTBan
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBaoCaoLai = new System.Windows.Forms.Button();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.txtTenNoiThat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMaNoiThat = new System.Windows.Forms.ComboBox();
            this.GridViewBCDSHDVaTTBan = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaNoiThat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNoiThat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBCDSHDVaTTBan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(636, 398);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(74, 23);
            this.btnThoat.TabIndex = 36;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBaoCaoLai
            // 
            this.btnBaoCaoLai.Location = new System.Drawing.Point(470, 398);
            this.btnBaoCaoLai.Name = "btnBaoCaoLai";
            this.btnBaoCaoLai.Size = new System.Drawing.Size(71, 23);
            this.btnBaoCaoLai.TabIndex = 35;
            this.btnBaoCaoLai.Text = "Báo cáo lại";
            this.btnBaoCaoLai.UseVisualStyleBackColor = true;
            this.btnBaoCaoLai.Click += new System.EventHandler(this.btnBaoCaoLai_Click);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Location = new System.Drawing.Point(288, 398);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(77, 23);
            this.btnInBaoCao.TabIndex = 34;
            this.btnInBaoCao.Text = "In báo cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(111, 398);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(69, 23);
            this.btnBaoCao.TabIndex = 33;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // txtTenNoiThat
            // 
            this.txtTenNoiThat.Location = new System.Drawing.Point(565, 78);
            this.txtTenNoiThat.Name = "txtTenNoiThat";
            this.txtTenNoiThat.Size = new System.Drawing.Size(169, 20);
            this.txtTenNoiThat.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tên nội thất";
            // 
            // cmbMaNoiThat
            // 
            this.cmbMaNoiThat.FormattingEnabled = true;
            this.cmbMaNoiThat.Location = new System.Drawing.Point(174, 79);
            this.cmbMaNoiThat.Name = "cmbMaNoiThat";
            this.cmbMaNoiThat.Size = new System.Drawing.Size(169, 21);
            this.cmbMaNoiThat.TabIndex = 30;
            this.cmbMaNoiThat.TextChanged += new System.EventHandler(this.cmbMaNoiThat_TextChanged);
            // 
            // GridViewBCDSHDVaTTBan
            // 
            this.GridViewBCDSHDVaTTBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewBCDSHDVaTTBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNoiThat,
            this.TenNoiThat,
            this.SoLuong,
            this.DonGiaBan,
            this.GiamGia,
            this.ThanhTien,
            this.TongTien});
            this.GridViewBCDSHDVaTTBan.Location = new System.Drawing.Point(95, 137);
            this.GridViewBCDSHDVaTTBan.Name = "GridViewBCDSHDVaTTBan";
            this.GridViewBCDSHDVaTTBan.Size = new System.Drawing.Size(639, 223);
            this.GridViewBCDSHDVaTTBan.TabIndex = 29;
            this.GridViewBCDSHDVaTTBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewBCDSHDVaTTBan_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mã nội thất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(90, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Báo cáo danh sách hóa đơn và tổng tiền bán hàng";
            // 
            // MaNoiThat
            // 
            this.MaNoiThat.DataPropertyName = "MaNoiThat";
            this.MaNoiThat.HeaderText = "Mã nội thất";
            this.MaNoiThat.Name = "MaNoiThat";
            // 
            // TenNoiThat
            // 
            this.TenNoiThat.DataPropertyName = "TenNoiThat";
            this.TenNoiThat.HeaderText = "Tên nội thất";
            this.TenNoiThat.Name = "TenNoiThat";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            this.DonGiaBan.HeaderText = "Đơn giá bán";
            this.DonGiaBan.Name = "DonGiaBan";
            // 
            // GiamGia
            // 
            this.GiamGia.DataPropertyName = "GiamGia";
            this.GiamGia.HeaderText = "Giảm giá";
            this.GiamGia.Name = "GiamGia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // frmBaoCaoDSHDVaTTBan
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
            this.Controls.Add(this.GridViewBCDSHDVaTTBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBaoCaoDSHDVaTTBan";
            this.Text = "Báo cáo danh sách hóa đơn và tổng tiền bán hàng";
            this.Load += new System.EventHandler(this.frmBaoCaoDSHDVaTTBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBCDSHDVaTTBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBaoCaoLai;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.TextBox txtTenNoiThat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMaNoiThat;
        private System.Windows.Forms.DataGridView GridViewBCDSHDVaTTBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNoiThat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNoiThat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}