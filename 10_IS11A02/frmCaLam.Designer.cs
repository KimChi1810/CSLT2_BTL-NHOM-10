namespace BTN_10_SO_26
{
    partial class frmCaLam
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
            this.txtMaca = new System.Windows.Forms.TextBox();
            this.txtTenca = new System.Windows.Forms.TextBox();
            this.dataGridViewCalam = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.MaCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CA LÀM ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã ca ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên ca ";
            // 
            // txtMaca
            // 
            this.txtMaca.Location = new System.Drawing.Point(320, 71);
            this.txtMaca.Name = "txtMaca";
            this.txtMaca.Size = new System.Drawing.Size(252, 20);
            this.txtMaca.TabIndex = 3;
            // 
            // txtTenca
            // 
            this.txtTenca.Location = new System.Drawing.Point(320, 132);
            this.txtTenca.Name = "txtTenca";
            this.txtTenca.Size = new System.Drawing.Size(252, 20);
            this.txtTenca.TabIndex = 4;
            // 
            // dataGridViewCalam
            // 
            this.dataGridViewCalam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCa,
            this.TenCa});
            this.dataGridViewCalam.Location = new System.Drawing.Point(320, 197);
            this.dataGridViewCalam.Name = "dataGridViewCalam";
            this.dataGridViewCalam.Size = new System.Drawing.Size(243, 167);
            this.dataGridViewCalam.TabIndex = 5;
            this.dataGridViewCalam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCalam_CellClick_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(691, 399);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(52, 23);
            this.btnThoat.TabIndex = 57;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(554, 399);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(52, 23);
            this.btnLuu.TabIndex = 56;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(403, 399);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(52, 23);
            this.btnXoa.TabIndex = 55;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(240, 399);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(52, 23);
            this.btnSua.TabIndex = 54;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(81, 399);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(52, 23);
            this.btnThem.TabIndex = 53;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // MaCa
            // 
            this.MaCa.DataPropertyName = "MaCa";
            this.MaCa.HeaderText = "Mã ca";
            this.MaCa.Name = "MaCa";
            // 
            // TenCa
            // 
            this.TenCa.DataPropertyName = "TenCa";
            this.TenCa.HeaderText = "Tên ca";
            this.TenCa.Name = "TenCa";
            // 
            // frmCaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewCalam);
            this.Controls.Add(this.txtTenca);
            this.Controls.Add(this.txtMaca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCaLam";
            this.Text = "frmCaLam";
            this.Load += new System.EventHandler(this.frmCaLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaca;
        private System.Windows.Forms.TextBox txtTenca;
        private System.Windows.Forms.DataGridView dataGridViewCalam;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}