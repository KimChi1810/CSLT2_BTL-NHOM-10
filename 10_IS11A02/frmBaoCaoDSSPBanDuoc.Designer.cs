namespace BTN_10_SO_26
{
    partial class frmBaoCaoDSSPBanDuoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.GridViewBCSP = new System.Windows.Forms.DataGridView();
            this.MaNoiThat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNoiThat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.btnBaoCaoLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbMaKH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBCSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo danh sách sản phẩm bán được";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tháng";
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(557, 67);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(167, 20);
            this.txtThang.TabIndex = 4;
            this.txtThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThang_KeyPress);
            // 
            // GridViewBCSP
            // 
            this.GridViewBCSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewBCSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNoiThat,
            this.TenNoiThat,
            this.MaKhach,
            this.NgayGiao,
            this.SoLuong});
            this.GridViewBCSP.Location = new System.Drawing.Point(137, 150);
            this.GridViewBCSP.Name = "GridViewBCSP";
            this.GridViewBCSP.Size = new System.Drawing.Size(543, 224);
            this.GridViewBCSP.TabIndex = 5;
            this.GridViewBCSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewBCSP_CellClick);
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
            // MaKhach
            // 
            this.MaKhach.DataPropertyName = "MaKhach";
            this.MaKhach.HeaderText = "Mã khách hàng";
            this.MaKhach.Name = "MaKhach";
            // 
            // NgayGiao
            // 
            this.NgayGiao.DataPropertyName = "NgayGiao";
            this.NgayGiao.HeaderText = "Ngày giao hàng";
            this.NgayGiao.Name = "NgayGiao";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng bán";
            this.SoLuong.Name = "SoLuong";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(105, 411);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(59, 23);
            this.btnBaoCao.TabIndex = 6;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Location = new System.Drawing.Point(282, 411);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(77, 23);
            this.btnInBaoCao.TabIndex = 7;
            this.btnInBaoCao.Text = "In báo cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // btnBaoCaoLai
            // 
            this.btnBaoCaoLai.Location = new System.Drawing.Point(464, 411);
            this.btnBaoCaoLai.Name = "btnBaoCaoLai";
            this.btnBaoCaoLai.Size = new System.Drawing.Size(71, 23);
            this.btnBaoCaoLai.TabIndex = 8;
            this.btnBaoCaoLai.Text = "Báo cáo lại";
            this.btnBaoCaoLai.UseVisualStyleBackColor = true;
            this.btnBaoCaoLai.Click += new System.EventHandler(this.btnBaoCaoLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(645, 411);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(59, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.FormattingEnabled = true;
            this.cmbMaKH.Location = new System.Drawing.Point(190, 70);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(169, 21);
            this.cmbMaKH.TabIndex = 10;
            this.cmbMaKH.TextChanged += new System.EventHandler(this.cmbMaKH_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tên khách hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(190, 104);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(169, 20);
            this.txtTenKH.TabIndex = 12;
            // 
            // frmBaoCaoDSSPBanDuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMaKH);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBaoCaoLai);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.GridViewBCSP);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBaoCaoDSSPBanDuoc";
            this.Text = "Báo cáo danh sách sản phẩm bán được";
            this.Load += new System.EventHandler(this.frmBaoCaoDSSPBanDuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewBCSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.DataGridView GridViewBCSP;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Button btnBaoCaoLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbMaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNoiThat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNoiThat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}