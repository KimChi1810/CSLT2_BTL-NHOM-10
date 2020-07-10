namespace BTN_10_SO_26
{
    partial class frmChatLieu
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
            this.dataGridViewChatlieu = new System.Windows.Forms.DataGridView();
            this.txtTenchatlieu = new System.Windows.Forms.TextBox();
            this.txtMachatlieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaChatLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChatLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChatlieu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(679, 409);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(52, 23);
            this.btnThoat.TabIndex = 68;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(542, 409);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(52, 23);
            this.btnLuu.TabIndex = 67;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(391, 409);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(52, 23);
            this.btnXoa.TabIndex = 66;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(228, 409);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(52, 23);
            this.btnSua.TabIndex = 65;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(69, 409);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(52, 23);
            this.btnThem.TabIndex = 64;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridViewChatlieu
            // 
            this.dataGridViewChatlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChatlieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChatLieu,
            this.TenChatLieu});
            this.dataGridViewChatlieu.Location = new System.Drawing.Point(308, 207);
            this.dataGridViewChatlieu.Name = "dataGridViewChatlieu";
            this.dataGridViewChatlieu.Size = new System.Drawing.Size(243, 167);
            this.dataGridViewChatlieu.TabIndex = 63;
            this.dataGridViewChatlieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChatlieu_CellClick);
            // 
            // txtTenchatlieu
            // 
            this.txtTenchatlieu.Location = new System.Drawing.Point(308, 142);
            this.txtTenchatlieu.Name = "txtTenchatlieu";
            this.txtTenchatlieu.Size = new System.Drawing.Size(252, 20);
            this.txtTenchatlieu.TabIndex = 62;
            // 
            // txtMachatlieu
            // 
            this.txtMachatlieu.Location = new System.Drawing.Point(308, 81);
            this.txtMachatlieu.Name = "txtMachatlieu";
            this.txtMachatlieu.Size = new System.Drawing.Size(252, 20);
            this.txtMachatlieu.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Tên chất liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Mã chất liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(327, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 58;
            this.label1.Text = "CHẤT LIỆU";
            // 
            // MaChatLieu
            // 
            this.MaChatLieu.DataPropertyName = "MaChatLieu";
            this.MaChatLieu.HeaderText = "Mã chất liệu";
            this.MaChatLieu.Name = "MaChatLieu";
            // 
            // TenChatLieu
            // 
            this.TenChatLieu.DataPropertyName = "TenChatLieu";
            this.TenChatLieu.HeaderText = "Tên chất liệu";
            this.TenChatLieu.Name = "TenChatLieu";
            // 
            // frmChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewChatlieu);
            this.Controls.Add(this.txtTenchatlieu);
            this.Controls.Add(this.txtMachatlieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChatLieu";
            this.Text = "frmChatLieu";
            this.Load += new System.EventHandler(this.frmChatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChatlieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridViewChatlieu;
        private System.Windows.Forms.TextBox txtTenchatlieu;
        private System.Windows.Forms.TextBox txtMachatlieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChatLieu;
    }
}