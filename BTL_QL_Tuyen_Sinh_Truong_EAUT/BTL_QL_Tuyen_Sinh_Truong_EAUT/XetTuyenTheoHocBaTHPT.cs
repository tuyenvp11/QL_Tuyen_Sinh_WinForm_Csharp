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
    public partial class FormXetTuyenTheoHocBaTHPT : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String str = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Ql_Truong_test;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT Xet_Tuyen_Theo_Hoc_Ba_THPT.MaHocSinh,HoTen,Cccd,QueQuan,NamSinh,GioiTinh,Nganh_Hoc.MaNganh,Hoc_Ba_THPT.KhoiXetTuyen,ToHopMonXetTuyen,TongDiemBaMon,DiemChuanTheoHocBa FROM Xet_Tuyen_Theo_Hoc_Ba_THPT,Hoc_Ba_THPT,Nganh_Hoc WHERE Xet_Tuyen_Theo_Hoc_Ba_THPT.MaHocSinh=Hoc_Ba_THPT.MaHocSinh AND Xet_Tuyen_Theo_Hoc_Ba_THPT.MaNganh=Nganh_Hoc.MaNganh";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvXetTuyenTheoHocBaTHPT.DataSource = table;
        }
        public FormXetTuyenTheoHocBaTHPT()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormTrangChinh f = new FormTrangChinh();
            f.Show();
        }

        private void FormXetTuyenTheoHocBaTHPT_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgvXetTuyenTheoHocBaTHPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
