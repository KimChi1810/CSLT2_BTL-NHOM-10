﻿namespace BTN_10_SO_26
{
    partial class frmNuocSX
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridViewNuocSX = new System.Windows.Forms.DataGridView();
            this.MaNuocSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNuocSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTennuocSX = new System.Windows.Forms.TextBox();
            this.txtManuocSX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNuocSX)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(679, 409);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(52, 23);
            this.btnThoat.TabIndex = 90;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(542, 409);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(52, 23);
            this.btnLuu.TabIndex = 89;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(391, 409);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(52, 23);
            this.btnXoa.TabIndex = 88;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(228, 409);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(52, 23);
            this.btnSua.TabIndex = 87;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(69, 409);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(52, 23);
            this.btnThem.TabIndex = 86;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridViewNuocSX
            // 
            this.dataGridViewNuocSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNuocSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNuocSX,
            this.TenNuocSX});
            this.dataGridViewNuocSX.Location = new System.Drawing.Point(308, 207);
            this.dataGridViewNuocSX.Name = "dataGridViewNuocSX";
            this.dataGridViewNuocSX.Size = new System.Drawing.Size(243, 167);
            this.dataGridViewNuocSX.TabIndex = 85;
            this.dataGridViewNuocSX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNuocSX_CellClick);
            // 
            // MaNuocSX
            // 
            this.MaNuocSX.DataPropertyName = "MaNuocSX";
            this.MaNuocSX.HeaderText = "Mã nước SX";
            this.MaNuocSX.Name = "MaNuocSX";
            // 
            // TenNuocSX
            // 
            this.TenNuocSX.DataPropertyName = "TenNuocSX";
            this.TenNuocSX.HeaderText = "Tên nước SX";
            this.TenNuocSX.Name = "TenNuocSX";
            // 
            // txtTennuocSX
            // 
            this.txtTennuocSX.Location = new System.Drawing.Point(308, 142);
            this.txtTennuocSX.Name = "txtTennuocSX";
            this.txtTennuocSX.Size = new System.Drawing.Size(252, 20);
            this.txtTennuocSX.TabIndex = 84;
            // 
            // txtManuocSX
            // 
            this.txtManuocSX.Location = new System.Drawing.Point(308, 81);
            this.txtManuocSX.Name = "txtManuocSX";
            this.txtManuocSX.Size = new System.Drawing.Size(252, 20);
            this.txtManuocSX.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 82;
            this.label3.Text = "Tên nước SX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 81;
            this.label2.Text = "Mã nước SX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(327, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 80;
            this.label1.Text = "NƯỚC SẢN XUẤT";
            // 
            // frmNuocSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewNuocSX);
            this.Controls.Add(this.txtTennuocSX);
            this.Controls.Add(this.txtManuocSX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNuocSX";
            this.Text = "frmNuocSX";
            this.Load += new System.EventHandler(this.frmNuocSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNuocSX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridViewNuocSX;
        private System.Windows.Forms.TextBox txtTennuocSX;
        private System.Windows.Forms.TextBox txtManuocSX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNuocSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNuocSX;
    }
}