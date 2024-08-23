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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            if (txtTaiKhoan.Text == "" && txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin !");

            }
            else if (txtTaiKhoan.Text == "tuyen" && txtMatKhau.Text == "123456")
            {
                MessageBox.Show("Đăng nhập vào hệ thống !");
                this.Hide();
                FormTrangChinh f = new FormTrangChinh();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu !");
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }
        }
    }
}
