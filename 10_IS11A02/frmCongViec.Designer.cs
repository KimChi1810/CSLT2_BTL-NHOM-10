namespace BTN_10_SO_26
{
    partial class frmCongViec
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
            this.lbMaCV = new System.Windows.Forms.Label();
            this.lbTenCV = new System.Windows.Forms.Label();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.dataGridViewCongViec = new System.Windows.Forms.DataGridView();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCongViec)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Công việc";
            // 
            // lbMaCV
            // 
            this.lbMaCV.AutoSize = true;
            this.lbMaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaCV.Location = new System.Drawing.Point(122, 80);
            this.lbMaCV.Name = "lbMaCV";
            this.lbMaCV.Size = new System.Drawing.Size(48, 16);
            this.lbMaCV.TabIndex = 1;
            this.lbMaCV.Text = "Mã CV";
            // 
            // lbTenCV
            // 
            this.lbTenCV.AutoSize = true;
            this.lbTenCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenCV.Location = new System.Drawing.Point(122, 157);
            this.lbTenCV.Name = "lbTenCV";
            this.lbTenCV.Size = new System.Drawing.Size(53, 16);
            this.lbTenCV.TabIndex = 2;
            this.lbTenCV.Text = "Tên CV";
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(253, 80);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(274, 20);
            this.txtMaCV.TabIndex = 3;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(253, 150);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(274, 20);
            this.txtTenCV.TabIndex = 4;
            // 
            // dataGridViewCongViec
            // 
            this.dataGridViewCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCV,
            this.TenCV});
            this.dataGridViewCongViec.Location = new System.Drawing.Point(253, 205);
            this.dataGridViewCongViec.Name = "dataGridViewCongViec";
            this.dataGridViewCongViec.Size = new System.Drawing.Size(274, 150);
            this.dataGridViewCongViec.TabIndex = 5;
            this.dataGridViewCongViec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCongViec_CellClick);
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Mã CV";
            this.MaCV.Name = "MaCV";
            // 
            // TenCV
            // 
            this.TenCV.DataPropertyName = "TenCV";
            this.TenCV.HeaderText = "Tên CV";
            this.TenCV.Name = "TenCV";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(660, 396);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(52, 23);
            this.btnThoat.TabIndex = 57;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(523, 396);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(52, 23);
            this.btnLuu.TabIndex = 56;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(372, 396);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(52, 23);
            this.btnXoa.TabIndex = 55;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(209, 396);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(52, 23);
            this.btnSua.TabIndex = 54;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(50, 396);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(52, 23);
            this.btnThem.TabIndex = 53;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewCongViec);
            this.Controls.Add(this.txtTenCV);
            this.Controls.Add(this.txtMaCV);
            this.Controls.Add(this.lbTenCV);
            this.Controls.Add(this.lbMaCV);
            this.Controls.Add(this.label1);
            this.Name = "frmCongViec";
            this.Text = "frmCongViec";
            this.Load += new System.EventHandler(this.frmCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCongViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaCV;
        private System.Windows.Forms.Label lbTenCV;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.DataGridView dataGridViewCongViec;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
    }
}