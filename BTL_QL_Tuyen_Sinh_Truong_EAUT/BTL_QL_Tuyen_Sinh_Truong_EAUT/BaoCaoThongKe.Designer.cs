namespace BTL_QL_Tuyen_Sinh_Truong_EAUT
{
    partial class FormBaoCaoThongKe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ds = new System.Windows.Forms.Label();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDauTheoHocBaTHPT = new System.Windows.Forms.Button();
            this.btnDauTheoDiemThiTHPT = new System.Windows.Forms.Button();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDiemThi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ds);
            this.groupBox1.Controls.Add(this.dgvThongKe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1342, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê";
            // 
            // ds
            // 
            this.ds.AutoSize = true;
            this.ds.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds.Location = new System.Drawing.Point(475, 58);
            this.ds.Name = "ds";
            this.ds.Size = new System.Drawing.Size(407, 32);
            this.ds.TabIndex = 1;
            this.ds.Text = "DANH SÁCH TRÚNG TUYỂN";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(0, 93);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(1342, 301);
            this.dgvThongKe.TabIndex = 0;
            this.dgvThongKe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongKe_CellContentClick);
            // 
            // btnDauTheoHocBaTHPT
            // 
            this.btnDauTheoHocBaTHPT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDauTheoHocBaTHPT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDauTheoHocBaTHPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDauTheoHocBaTHPT.Location = new System.Drawing.Point(991, 69);
            this.btnDauTheoHocBaTHPT.Name = "btnDauTheoHocBaTHPT";
            this.btnDauTheoHocBaTHPT.Size = new System.Drawing.Size(171, 32);
            this.btnDauTheoHocBaTHPT.TabIndex = 1;
            this.btnDauTheoHocBaTHPT.Text = "Đậu Theo Học Bạ ";
            this.btnDauTheoHocBaTHPT.UseVisualStyleBackColor = false;
            this.btnDauTheoHocBaTHPT.Click += new System.EventHandler(this.btnDauTheoHocBaTHPT_Click);
            // 
            // btnDauTheoDiemThiTHPT
            // 
            this.btnDauTheoDiemThiTHPT.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDauTheoDiemThiTHPT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDauTheoDiemThiTHPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDauTheoDiemThiTHPT.Location = new System.Drawing.Point(1177, 69);
            this.btnDauTheoDiemThiTHPT.Name = "btnDauTheoDiemThiTHPT";
            this.btnDauTheoDiemThiTHPT.Size = new System.Drawing.Size(171, 32);
            this.btnDauTheoDiemThiTHPT.TabIndex = 2;
            this.btnDauTheoDiemThiTHPT.Text = "Đậu Theo Điểm Thi";
            this.btnDauTheoDiemThiTHPT.UseVisualStyleBackColor = false;
            this.btnDauTheoDiemThiTHPT.Click += new System.EventHandler(this.btnDauTheoDiemThiTHPT_Click);
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnInPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieu.Location = new System.Drawing.Point(1051, 498);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(158, 48);
            this.btnInPhieu.TabIndex = 3;
            this.btnInPhieu.Text = "In Danh Sách Học Bạ";
            this.btnInPhieu.UseVisualStyleBackColor = false;
            this.btnInPhieu.Click += new System.EventHandler(this.btnInPhieu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1225, 498);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 48);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDiemThi
            // 
            this.btnDiemThi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDiemThi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDiemThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiemThi.Location = new System.Drawing.Point(863, 498);
            this.btnDiemThi.Name = "btnDiemThi";
            this.btnDiemThi.Size = new System.Drawing.Size(158, 48);
            this.btnDiemThi.TabIndex = 5;
            this.btnDiemThi.Text = "In Danh Sách Điểm Thi";
            this.btnDiemThi.UseVisualStyleBackColor = false;
            this.btnDiemThi.Click += new System.EventHandler(this.btnDiemThi_Click);
            // 
            // FormBaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 548);
            this.Controls.Add(this.btnDiemThi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnInPhieu);
            this.Controls.Add(this.btnDauTheoDiemThiTHPT);
            this.Controls.Add(this.btnDauTheoHocBaTHPT);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormBaoCaoThongKe";
            this.Text = "BaoCaoThongKe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBaoCaoThongKe_FormClosing);
            this.Load += new System.EventHandler(this.FormBaoCaoThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDauTheoHocBaTHPT;
        private System.Windows.Forms.Button btnDauTheoDiemThiTHPT;
        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label ds;
        private System.Windows.Forms.Button btnDiemThi;
    }
}