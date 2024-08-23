namespace BTL_QL_Tuyen_Sinh_Truong_EAUT
{
    partial class FormXetTuyenTheoHocBaTHPT
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
            this.dgvXetTuyenTheoHocBaTHPT = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXetTuyenTheoHocBaTHPT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvXetTuyenTheoHocBaTHPT);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1496, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách";
            // 
            // dgvXetTuyenTheoHocBaTHPT
            // 
            this.dgvXetTuyenTheoHocBaTHPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXetTuyenTheoHocBaTHPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXetTuyenTheoHocBaTHPT.Location = new System.Drawing.Point(0, 21);
            this.dgvXetTuyenTheoHocBaTHPT.Name = "dgvXetTuyenTheoHocBaTHPT";
            this.dgvXetTuyenTheoHocBaTHPT.RowHeadersWidth = 51;
            this.dgvXetTuyenTheoHocBaTHPT.RowTemplate.Height = 24;
            this.dgvXetTuyenTheoHocBaTHPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXetTuyenTheoHocBaTHPT.Size = new System.Drawing.Size(1490, 314);
            this.dgvXetTuyenTheoHocBaTHPT.TabIndex = 0;
            this.dgvXetTuyenTheoHocBaTHPT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXetTuyenTheoHocBaTHPT_CellContentClick);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(640, 378);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(158, 37);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormXetTuyenTheoHocBaTHPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormXetTuyenTheoHocBaTHPT";
            this.Text = "XetTuyenTheoHocBaTHPT";
            this.Load += new System.EventHandler(this.FormXetTuyenTheoHocBaTHPT_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXetTuyenTheoHocBaTHPT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvXetTuyenTheoHocBaTHPT;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnThoat;
    }
}