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
    public partial class FormXetTuyenTheoDiemThiTHPT : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String str = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Ql_Truong_test;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT Xet_Tuyen_Theo_Diem_Thi_THPT.MaThiSinh,HoTen,Cccd,QueQuan,NamSinh,GioiTinh,Nganh_Hoc.MaNganh,Diem_Thi_THPT.KhoiXetTuyen,ToHopMonXetTuyen,TongDiemBaMon,DiemChuanTheoHocBa FROM Xet_Tuyen_Theo_Diem_Thi_THPT,Diem_Thi_THPT,Nganh_Hoc WHERE Xet_Tuyen_Theo_Diem_Thi_THPT.MaThiSinh=Diem_Thi_THPT.MaThiSinh AND Xet_Tuyen_Theo_Diem_Thi_THPT.MaNganh=Nganh_Hoc.MaNganh";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvXetTuyenTheoDiemThiTHPT.DataSource = table;
        }
        public FormXetTuyenTheoDiemThiTHPT()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormTrangChinh f=new FormTrangChinh();
            f.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormXetTuyenTheoDiemThiTHPT_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }
    }
}
