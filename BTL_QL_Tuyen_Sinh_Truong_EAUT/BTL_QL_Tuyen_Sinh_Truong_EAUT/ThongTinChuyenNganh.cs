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
    public partial class FormThongTinChuyenNganh : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String str = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Ql_Truong_test;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Nganh_Hoc ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThongTinChuyenNganh.DataSource = table;
        }
        public FormThongTinChuyenNganh()
        {
            InitializeComponent();
        }

        private void FormThongTinChuyenNganh_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgvThongTinChuyenNganh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvThongTinChuyenNganh.CurrentRow.Index;
            tbMaNganh.Text = dgvThongTinChuyenNganh.Rows[i].Cells[0].Value.ToString();
            tbTenNganh.Text = dgvThongTinChuyenNganh.Rows[i].Cells[1].Value.ToString();
            tbKhoiXetTuyen.Text = dgvThongTinChuyenNganh.Rows[i].Cells[2].Value.ToString();
            tbHocBa.Text = dgvThongTinChuyenNganh.Rows[i].Cells[3].Value.ToString();
            tbDiemThi.Text = dgvThongTinChuyenNganh.Rows[i].Cells[4].Value.ToString();
            tbTieuChi.Text = dgvThongTinChuyenNganh.Rows[i].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            string insertXetTuyen = "insert into Nganh_Hoc values('" + tbMaNganh.Text + "',N'" + tbTenNganh.Text + "',N'" + tbKhoiXetTuyen.Text + "','" + tbHocBa.Text + "','" + tbDiemThi.Text + "','" + tbTieuChi.Text + "')";
            SqlCommand commandXetTuyen = new SqlCommand(insertXetTuyen, connection);
            commandXetTuyen.Parameters.AddWithValue("MaNganh", tbMaNganh.Text);
            commandXetTuyen.Parameters.AddWithValue("TenNganh", tbTenNganh.Text);
            commandXetTuyen.Parameters.AddWithValue("KhoiXetTuyen", tbKhoiXetTuyen.Text);
            commandXetTuyen.Parameters.AddWithValue("DiemChuanTheoHocBa", tbHocBa.Text);
            commandXetTuyen.Parameters.AddWithValue("DiemChuanTheoDiemThi", tbDiemThi.Text);
            commandXetTuyen.Parameters.AddWithValue("TieuChi", tbTieuChi.Text);
            commandXetTuyen.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Đã thêm dữ liệu thành công!");
            loaddata();
            tbMaNganh.Clear(); tbTenNganh.Clear(); tbKhoiXetTuyen.Clear(); tbHocBa.Clear(); tbDiemThi.Clear(); tbTieuChi.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            string insertXetTuyen = "update Nganh_Hoc set TenNganh=N'" + tbTenNganh.Text + "',KhoiXetTuyen=N'" + tbKhoiXetTuyen.Text + "',DiemChuanTheoHocBa='" + tbHocBa.Text + "',DiemChuanTheoDiemThi='" + tbDiemThi.Text + "',TieuChi='" + tbTieuChi.Text + "' where MaNganh='"+tbMaNganh.Text+"'";
            SqlCommand commandXetTuyen = new SqlCommand(insertXetTuyen, connection);
            commandXetTuyen.Parameters.AddWithValue("TenNganh", tbTenNganh.Text);
            commandXetTuyen.Parameters.AddWithValue("KhoiXetTuyen", tbKhoiXetTuyen.Text);
            commandXetTuyen.Parameters.AddWithValue("DiemChuanTheoHocBa", tbHocBa.Text);
            commandXetTuyen.Parameters.AddWithValue("DiemChuanTheoDiemThi", tbDiemThi.Text);
            commandXetTuyen.Parameters.AddWithValue("TieuChi", tbTieuChi.Text);
            commandXetTuyen.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Đã sửa dữ liệu thành công!");
            loaddata();
            tbMaNganh.Clear(); tbTenNganh.Clear(); tbKhoiXetTuyen.Clear(); tbHocBa.Clear(); tbDiemThi.Clear(); tbTieuChi.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        { 
            connection = new SqlConnection(str);
            connection.Open();
            string deleteXetTuyenHocBa = "DELETE FROM Xet_Tuyen_Theo_Hoc_Ba_THPT WHERE MaNganh =N'" + tbMaNganh.Text + "'";
            SqlCommand commandXetTuyenHocBa = new SqlCommand(deleteXetTuyenHocBa, connection);
            commandXetTuyenHocBa.Parameters.AddWithValue("MaNganh", tbMaNganh.Text);
            commandXetTuyenHocBa.ExecuteNonQuery();
            string deleteXetTuyenDiemThi = "DELETE FROM Xet_Tuyen_Theo_Diem_Thi_THPT WHERE MaNganh =N'" + tbMaNganh.Text + "'";
            SqlCommand commandXetTuyenDiemThi = new SqlCommand(deleteXetTuyenDiemThi, connection);
            commandXetTuyenDiemThi.Parameters.AddWithValue("MaNganh",tbMaNganh.Text);
            commandXetTuyenDiemThi.ExecuteNonQuery();
            string deleteNganhHoc = "DELETE FROM Nganh_Hoc WHERE MaNganh =N'" + tbMaNganh.Text + "'";
            SqlCommand commandNganhHoc = new SqlCommand(deleteNganhHoc, connection);
            commandNganhHoc.Parameters.AddWithValue("MaNganh", tbMaNganh.Text);
            commandNganhHoc.ExecuteNonQuery();
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
