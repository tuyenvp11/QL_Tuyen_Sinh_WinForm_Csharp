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
    public partial class FormBaoCaoThongKe : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String str = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Ql_Truong_test;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable table1 = new DataTable();
        
       
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT Xet_Tuyen_Theo_Hoc_Ba_THPT.MaHocSinh,HoTen,Cccd,QueQuan,NamSinh,GioiTinh,Nganh_Hoc.MaNganh,Hoc_Ba_THPT.KhoiXetTuyen,ToHopMonXetTuyen,TongDiemBaMon,DiemChuanTheoHocBa FROM Xet_Tuyen_Theo_Hoc_Ba_THPT,Hoc_Ba_THPT,Nganh_Hoc WHERE Xet_Tuyen_Theo_Hoc_Ba_THPT.MaHocSinh=Hoc_Ba_THPT.MaHocSinh AND Xet_Tuyen_Theo_Hoc_Ba_THPT.MaNganh=Nganh_Hoc.MaNganh AND Xet_Tuyen_Theo_Hoc_Ba_THPT.TongDiemBaMon>=Nganh_Hoc.DiemChuanTheoHocBa";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThongKe.DataSource = table;
        }
        void loaddata1()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT Xet_Tuyen_Theo_Diem_Thi_THPT.MaThiSinh,HoTen,Cccd,QueQuan,NamSinh,GioiTinh,Nganh_Hoc.MaNganh,Diem_Thi_THPT.KhoiXetTuyen,ToHopMonXetTuyen,TongDiemBaMon,DiemChuanTheoHocBa FROM Xet_Tuyen_Theo_Diem_Thi_THPT,Diem_Thi_THPT,Nganh_Hoc WHERE Xet_Tuyen_Theo_Diem_Thi_THPT.MaThiSinh=Diem_Thi_THPT.MaThiSinh AND Xet_Tuyen_Theo_Diem_Thi_THPT.MaNganh=Nganh_Hoc.MaNganh AND Xet_Tuyen_Theo_Diem_Thi_THPT.TongDiemBaMon>=Nganh_Hoc.DiemChuanTheoDiemThi";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            dgvThongKe.DataSource = table1;
        }
        public FormBaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void FormBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDauTheoHocBaTHPT_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnDauTheoDiemThiTHPT_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata1();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormTrangChinh f = new FormTrangChinh();
            f.Show();
        }
        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            this.Hide();
                connection = new SqlConnection(str);
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter("SELECT Xet_Tuyen_Theo_Hoc_Ba_THPT.MaHocSinh,HoTen,Cccd,QueQuan,NamSinh,GioiTinh,Nganh_Hoc.MaNganh,Hoc_Ba_THPT.KhoiXetTuyen,ToHopMonXetTuyen,TongDiemBaMon,DiemChuanTheoHocBa FROM Xet_Tuyen_Theo_Hoc_Ba_THPT,Hoc_Ba_THPT,Nganh_Hoc WHERE Xet_Tuyen_Theo_Hoc_Ba_THPT.MaHocSinh=Hoc_Ba_THPT.MaHocSinh AND Xet_Tuyen_Theo_Hoc_Ba_THPT.MaNganh=Nganh_Hoc.MaNganh AND Xet_Tuyen_Theo_Hoc_Ba_THPT.TongDiemBaMon>=Nganh_Hoc.DiemChuanTheoHocBa", connection);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                dsBaoCaoHocBa rpt = new dsBaoCaoHocBa();
                rpt.SetDataSource(dt);
                FormdsBaoCaoHocBa f = new FormdsBaoCaoHocBa();
                f.crystalReportViewer1.ReportSource = rpt;
                f.ShowDialog();

        }
        private void btnDiemThi_Click(object sender, EventArgs e)
        {
            this.Hide();
            connection = new SqlConnection(str);
            connection.Open();
            SqlDataAdapter ds = new SqlDataAdapter("SELECT Xet_Tuyen_Theo_Diem_Thi_THPT.MaThiSinh,HoTen,Cccd,QueQuan,NamSinh,GioiTinh,Nganh_Hoc.MaNganh,Diem_Thi_THPT.KhoiXetTuyen,ToHopMonXetTuyen,TongDiemBaMon,DiemChuanTheoHocBa FROM Xet_Tuyen_Theo_Diem_Thi_THPT,Diem_Thi_THPT,Nganh_Hoc WHERE Xet_Tuyen_Theo_Diem_Thi_THPT.MaThiSinh=Diem_Thi_THPT.MaThiSinh AND Xet_Tuyen_Theo_Diem_Thi_THPT.MaNganh=Nganh_Hoc.MaNganh AND Xet_Tuyen_Theo_Diem_Thi_THPT.TongDiemBaMon>=Nganh_Hoc.DiemChuanTheoDiemThi", connection);
            DataTable dt = new DataTable();
            ds.Fill(dt);
            dsBaoCaoDiemThi rpt = new dsBaoCaoDiemThi();
            rpt.SetDataSource(dt);
            FormdsBaoCaoDiemThi f = new FormdsBaoCaoDiemThi();
            f.crystalReportViewer2.ReportSource = rpt;
            f.ShowDialog();
          

        }

        private void dgvThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormBaoCaoThongKe_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }


    }
}
