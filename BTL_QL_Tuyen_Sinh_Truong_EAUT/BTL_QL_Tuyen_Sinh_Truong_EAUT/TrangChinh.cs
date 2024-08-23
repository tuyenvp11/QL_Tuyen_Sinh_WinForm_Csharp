using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QL_Tuyen_Sinh_Truong_EAUT
{
    public partial class FormTrangChinh : Form
    {
        public FormTrangChinh()
        {
            InitializeComponent();
        }

        private void họcBạTHPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHocBaTHPT f = new FormHocBaTHPT();
            f.ShowDialog();
        }

        private void điểmThiTHPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDiemThiTHPT f = new FormDiemThiTHPT();
            f.ShowDialog();
        }

        private void thôngTinChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinChuyenNganh f = new FormThongTinChuyenNganh();
            f.ShowDialog();
        }

        private void xétTheoHọcBạToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormXetTuyenTheoHocBaTHPT f = new FormXetTuyenTheoHocBaTHPT();
            f.ShowDialog();
        }

        private void xétTheoĐiểmThiTHPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormXetTuyenTheoDiemThiTHPT f = new FormXetTuyenTheoDiemThiTHPT();
            f.ShowDialog();
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBaoCaoThongKe f=new FormBaoCaoThongKe();
            f.Show();
        }

        private void FormTrangChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
             if(e.CloseReason==CloseReason.UserClosing)
            {
                if(MessageBox.Show("Bạn muốn thoát chương trình ?","Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                
            }
        }

        private void FormTrangChinh_Load(object sender, EventArgs e)
        {

        }
    }
}
