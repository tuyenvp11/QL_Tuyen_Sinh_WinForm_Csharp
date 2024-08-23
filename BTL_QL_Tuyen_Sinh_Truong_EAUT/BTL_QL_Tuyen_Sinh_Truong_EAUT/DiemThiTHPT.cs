using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QL_Tuyen_Sinh_Truong_EAUT
{
    public partial class FormDiemThiTHPT : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String str = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Ql_Truong_test;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Diem_Thi_THPT";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvDiemThiTHPT.DataSource = table;
        }
        public FormDiemThiTHPT()
        {
            InitializeComponent();
        }

        private void FormDiemThiTHPT_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgvDiemThiTHPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvDiemThiTHPT.CurrentRow.Index;
            tbMaThiSinh.Text = dgvDiemThiTHPT.Rows[i].Cells[0].Value.ToString();
            tbHoTen.Text = dgvDiemThiTHPT.Rows[i].Cells[1].Value.ToString();
            tbCccd.Text = dgvDiemThiTHPT.Rows[i].Cells[2].Value.ToString();
            tbQueQuan.Text = dgvDiemThiTHPT.Rows[i].Cells[3].Value.ToString();
            dtNamSinh.Text = dgvDiemThiTHPT.Rows[i].Cells[4].Value.ToString();
            cbGioiTinh.Text = dgvDiemThiTHPT.Rows[i].Cells[5].Value.ToString();
            tbKhoiXetTuyen.Text = dgvDiemThiTHPT.Rows[i].Cells[6].Value.ToString();
            tbToHop.Text = dgvDiemThiTHPT.Rows[i].Cells[7].Value.ToString();
            tbMon1.Text = dgvDiemThiTHPT.Rows[i].Cells[8].Value.ToString();
            tbMon2.Text = dgvDiemThiTHPT.Rows[i].Cells[9].Value.ToString();
            tbMon3.Text = dgvDiemThiTHPT.Rows[i].Cells[10].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            string insertXetTuyen = "insert into Diem_Thi_THPT values(N'" + tbMaThiSinh.Text + "',N'" + tbHoTen.Text + "','" + tbCccd.Text + "',N'" + tbQueQuan.Text + "','" + dtNamSinh.Text + "',N'" + cbGioiTinh.Text + "',N'" + tbKhoiXetTuyen.Text + "',N'" + tbToHop.Text + "','" + tbMon1.Text + "','" + tbMon2.Text + "','" + tbMon3.Text + "')";
            SqlCommand commandXetTuyen = new SqlCommand(insertXetTuyen, connection);
            commandXetTuyen.Parameters.AddWithValue("MaThiSinh", tbMaThiSinh.Text);
            commandXetTuyen.Parameters.AddWithValue("HoTen", tbHoTen.Text);
            commandXetTuyen.Parameters.AddWithValue("Cccd", tbCccd.Text);
            commandXetTuyen.Parameters.AddWithValue("QueQuan", tbQueQuan.Text);
            commandXetTuyen.Parameters.AddWithValue("NamSinh", dtNamSinh.Text);
            commandXetTuyen.Parameters.AddWithValue("GioiTinh", cbGioiTinh.Text);
            commandXetTuyen.Parameters.AddWithValue("KhoiXetTuyen", tbKhoiXetTuyen.Text);
            commandXetTuyen.Parameters.AddWithValue("ToHopMonXetTuyen", tbToHop.Text);
            commandXetTuyen.Parameters.AddWithValue("DiemMon1", tbMon1.Text);
            commandXetTuyen.Parameters.AddWithValue("DiemMon2", tbMon2.Text);
            commandXetTuyen.Parameters.AddWithValue("DiemMon3", tbMon3.Text);
            commandXetTuyen.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Đã thêm dữ liệu thành công!");
            loaddata();
            tbMaThiSinh.Clear(); tbHoTen.Clear(); tbCccd.Clear(); tbQueQuan.Clear(); tbKhoiXetTuyen.Clear(); tbToHop.Clear(); tbMon1.Clear(); tbMon2.Clear(); tbMon3.Clear();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            string insertXetTuyen = "update Diem_Thi_THPT set HoTen=N'" + tbHoTen.Text + "',Cccd='" + tbCccd.Text + "',QueQuan=N'" + tbQueQuan.Text + "',NamSinh='" + dtNamSinh.Text + "',GioiTinh=N'" + cbGioiTinh.Text + "',KhoiXetTuyen=N'" + tbKhoiXetTuyen.Text + "',ToHopMonXetTuyen=N'" + tbToHop.Text + "',DiemMon1='" + tbMon1.Text + "',DiemMon2='" + tbMon2.Text + "',DiemMon3='" + tbMon3.Text + "' where MaThiSinh='" + tbMaThiSinh.Text + "'";
            SqlCommand commandXetTuyen = new SqlCommand(insertXetTuyen, connection);
            commandXetTuyen.Parameters.AddWithValue("HoTen", tbHoTen.Text);
            commandXetTuyen.Parameters.AddWithValue("Cccd", tbCccd.Text);
            commandXetTuyen.Parameters.AddWithValue("QueQuan", tbQueQuan.Text);
            commandXetTuyen.Parameters.AddWithValue("NamSinh", dtNamSinh.Text);
            commandXetTuyen.Parameters.AddWithValue("GioiTinh", cbGioiTinh.Text);
            commandXetTuyen.Parameters.AddWithValue("KhoiXetTuyen", tbKhoiXetTuyen.Text);
            commandXetTuyen.Parameters.AddWithValue("ToHopMonXetTuyen", tbToHop.Text);
            commandXetTuyen.Parameters.AddWithValue("DiemMon1", tbMon1.Text);
            commandXetTuyen.Parameters.AddWithValue("DiemMon2", tbMon2.Text);
            commandXetTuyen.Parameters.AddWithValue("DiemMon3", tbMon3.Text);
            commandXetTuyen.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Đã sửa dữ liệu thành công!");
            loaddata();
            tbMaThiSinh.Clear(); tbHoTen.Clear(); tbCccd.Clear(); tbQueQuan.Clear(); tbKhoiXetTuyen.Clear(); tbToHop.Clear(); tbMon1.Clear(); tbMon2.Clear(); tbMon3.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            string deleteXetTuyen = "DELETE FROM Xet_Tuyen_Theo_Diem_Thi_THPT WHERE MaThiSinh =N'" + tbMaThiSinh.Text + "'";
            SqlCommand commandXetTuyen = new SqlCommand(deleteXetTuyen, connection);
            commandXetTuyen.Parameters.AddWithValue("MaThiSinh", tbMaThiSinh.Text);
            commandXetTuyen.ExecuteNonQuery();
            string deleteDiemThi = "DELETE FROM Diem_Thi_THPT WHERE MaThiSinh =N'" + tbMaThiSinh.Text + "'";
            SqlCommand commandDiemThi = new SqlCommand(deleteDiemThi, connection);
            commandDiemThi.Parameters.AddWithValue("MaThiSinh", tbMaThiSinh.Text);
            commandDiemThi.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Đã xoá dữ liệu thành công!");
            loaddata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Close();
            FormTrangChinh f = new FormTrangChinh();
            f.Show();
        }
    }
}
