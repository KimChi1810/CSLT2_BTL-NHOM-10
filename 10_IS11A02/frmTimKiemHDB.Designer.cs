namespace BTN_10_SO_26
{
    partial class frmTimKiemHDB
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimLai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GridViewTim = new System.Windows.Forms.DataGridView();
            this.SoDDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNoiThat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNoiThat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskNgayGiao = new System.Windows.Forms.MaskedTextBox();
            this.mskNgayDat = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtThue = new System.Windows.Forms.TextBox();
            this.txtDatCoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoDDH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTim)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.btnThoat);
            this.splitContainer1.Panel1.Controls.Add(this.btnTimLai);
            this.splitContainer1.Panel1.Controls.Add(this.btnTimKiem);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.GridViewTim);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaNV);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaKH);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaNoiThat);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 540;
            this.splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(6, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Kích đúp chuột vào một hóa đơn để hiện thông tin chi tiết";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(452, 406);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 45;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimLai
            // 
            this.btnTimLai.Location = new System.Drawing.Point(231, 406);
            this.btnTimLai.Name = "btnTimLai";
            this.btnTimLai.Size = new System.Drawing.Size(75, 23);
            this.btnTimLai.TabIndex = 44;
            this.btnTimLai.Text = "Tìm lại";
            this.btnTimLai.UseVisualStyleBackColor = true;
            this.btnTimLai.Click += new System.EventHandler(this.btnTimLai_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(10, 406);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 43;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(150, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 31);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tìm kiếm hóa đơn bán";
            // 
            // GridViewTim
            // 
            this.GridViewTim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewTim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoDDH,
            this.MaNoiThat,
            this.MaKhach,
            this.MaNV,
            this.Thue});
            this.GridViewTim.Location = new System.Drawing.Point(50, 162);
            this.GridViewTim.Name = "GridViewTim";
            this.GridViewTim.Size = new System.Drawing.Size(444, 190);
            this.GridViewTim.TabIndex = 38;
            this.GridViewTim.DoubleClick += new System.EventHandler(this.GridViewTim_DoubleClick);
            // 
            // SoDDH
            // 
            this.SoDDH.DataPropertyName = "SoDDH";
            this.SoDDH.HeaderText = "Số ĐĐH";
            this.SoDDH.Name = "SoDDH";
            // 
            // MaNoiThat
            // 
            this.MaNoiThat.DataPropertyName = "MaNoiThat";
            this.MaNoiThat.HeaderText = "Mã nội thất";
            this.MaNoiThat.Name = "MaNoiThat";
            // 
            // MaKhach
            // 
            this.MaKhach.DataPropertyName = "MaKhach";
            this.MaKhach.HeaderText = "Mã khách hàng";
            this.MaKhach.Name = "MaKhach";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            // 
            // Thue
            // 
            this.Thue.DataPropertyName = "Thue";
            this.Thue.HeaderText = "Thuế";
            this.Thue.Name = "Thue";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(107, 122);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(126, 20);
            this.txtMaNV.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mã nhân viên";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(412, 70);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(115, 20);
            this.txtMaKH.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mã khách hàng";
            // 
            // txtMaNoiThat
            // 
            this.txtMaNoiThat.Location = new System.Drawing.Point(107, 70);
            this.txtMaNoiThat.Name = "txtMaNoiThat";
            this.txtMaNoiThat.Size = new System.Drawing.Size(126, 20);
            this.txtMaNoiThat.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã nội thất";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.mskNgayGiao);
            this.groupBox1.Controls.Add(this.mskNgayDat);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtThue);
            this.groupBox1.Controls.Add(this.txtDatCoc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSoDDH);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(23, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 411);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(96, 224);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(100, 20);
            this.txtTongTien.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 53;
            this.label10.Text = "Tổng tiền";
            // 
            // mskNgayGiao
            // 
            this.mskNgayGiao.Location = new System.Drawing.Point(96, 104);
            this.mskNgayGiao.Mask = "00/00/0000";
            this.mskNgayGiao.Name = "mskNgayGiao";
            this.mskNgayGiao.Size = new System.Drawing.Size(100, 20);
            this.mskNgayGiao.TabIndex = 46;
            this.mskNgayGiao.ValidatingType = typeof(System.DateTime);
            // 
            // mskNgayDat
            // 
            this.mskNgayDat.Location = new System.Drawing.Point(96, 67);
            this.mskNgayDat.Mask = "00/00/0000";
            this.mskNgayDat.Name = "mskNgayDat";
            this.mskNgayDat.Size = new System.Drawing.Size(100, 20);
            this.mskNgayDat.TabIndex = 45;
            this.mskNgayDat.ValidatingType = typeof(System.DateTime);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 16);
            this.label13.TabIndex = 44;
            this.label13.Text = "Ngày giao";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.TabIndex = 42;
            this.label12.Text = "Ngày đặt";
            // 
            // txtThue
            // 
            this.txtThue.Location = new System.Drawing.Point(96, 181);
            this.txtThue.Name = "txtThue";
            this.txtThue.Size = new System.Drawing.Size(100, 20);
            this.txtThue.TabIndex = 39;
            // 
            // txtDatCoc
            // 
            this.txtDatCoc.Location = new System.Drawing.Point(96, 144);
            this.txtDatCoc.Name = "txtDatCoc";
            this.txtDatCoc.Size = new System.Drawing.Size(100, 20);
            this.txtDatCoc.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "Thuế";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Đặt cọc";
            // 
            // txtSoDDH
            // 
            this.txtSoDDH.Location = new System.Drawing.Point(96, 34);
            this.txtSoDDH.Name = "txtSoDDH";
            this.txtSoDDH.Size = new System.Drawing.Size(100, 20);
            this.txtSoDDH.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Số ĐĐH";
            // 
            // frmTimKiemHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmTimKiemHDB";
            this.Text = "Tìm kiếm hóa đơn bán";
            this.Load += new System.EventHandler(this.frmTimKiemHoaDon_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewTim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView GridViewTim;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNoiThat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimLai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskNgayGiao;
        private System.Windows.Forms.MaskedTextBox mskNgayDat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtThue;
        private System.Windows.Forms.TextBox txtDatCoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoDDH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNoiThat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thue;
    }
}