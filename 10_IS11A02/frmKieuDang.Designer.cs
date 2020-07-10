namespace BTN_10_SO_26
{
    partial class frmKieuDang
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
            this.dataGridViewKieudang = new System.Windows.Forms.DataGridView();
            this.txtTenkieu = new System.Windows.Forms.TextBox();
            this.txtMakieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaKieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKieudang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(679, 409);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(52, 23);
            this.btnThoat.TabIndex = 112;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(542, 409);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(52, 23);
            this.btnLuu.TabIndex = 111;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(391, 409);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(52, 23);
            this.btnXoa.TabIndex = 110;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(228, 409);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(52, 23);
            this.btnSua.TabIndex = 109;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(69, 409);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(52, 23);
            this.btnThem.TabIndex = 108;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridViewKieudang
            // 
            this.dataGridViewKieudang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKieudang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKieu,
            this.TenKieu});
            this.dataGridViewKieudang.Location = new System.Drawing.Point(308, 207);
            this.dataGridViewKieudang.Name = "dataGridViewKieudang";
            this.dataGridViewKieudang.Size = new System.Drawing.Size(243, 167);
            this.dataGridViewKieudang.TabIndex = 107;
            this.dataGridViewKieudang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKieudang_CellClick_1);
            // 
            // txtTenkieu
            // 
            this.txtTenkieu.Location = new System.Drawing.Point(308, 142);
            this.txtTenkieu.Name = "txtTenkieu";
            this.txtTenkieu.Size = new System.Drawing.Size(252, 20);
            this.txtTenkieu.TabIndex = 106;
            // 
            // txtMakieu
            // 
            this.txtMakieu.Location = new System.Drawing.Point(308, 81);
            this.txtMakieu.Name = "txtMakieu";
            this.txtMakieu.Size = new System.Drawing.Size(252, 20);
            this.txtMakieu.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 104;
            this.label3.Text = "Tên kiểu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 103;
            this.label2.Text = "Mã kiểu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(327, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 102;
            this.label1.Text = "KIỂU DÁNG";
            // 
            // MaKieu
            // 
            this.MaKieu.DataPropertyName = "MaKieu";
            this.MaKieu.HeaderText = "Mã kiểu";
            this.MaKieu.Name = "MaKieu";
            // 
            // TenKieu
            // 
            this.TenKieu.DataPropertyName = "TenKieu";
            this.TenKieu.HeaderText = "Tên kiểu";
            this.TenKieu.Name = "TenKieu";
            // 
            // frmKieuDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewKieudang);
            this.Controls.Add(this.txtTenkieu);
            this.Controls.Add(this.txtMakieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKieuDang";
            this.Text = "frmKieuDang";
            this.Load += new System.EventHandler(this.frmKieuDang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKieudang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridViewKieudang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKieu;
        private System.Windows.Forms.TextBox txtTenkieu;
        private System.Windows.Forms.TextBox txtMakieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}