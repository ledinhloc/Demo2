using System.Data;
using System.Data.SqlClient;
namespace Tuan1a
{
    public partial class FHocSinh : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public FHocSinh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HocSinhDao hsDao = new HocSinhDao();
            gvHSinh.DataSource = hsDao.Load();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HocSinh hocSinh = new HocSinh(txtTen.Text, txtDiaChi.Text, txtCMND.Text, dateTimePicker1.Value);
            HocSinhDao hocSinhDao = new HocSinhDao();
            hocSinhDao.them(hocSinh);
            Form1_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HocSinh hocSinh = new HocSinh(txtTen.Text, txtDiaChi.Text, txtCMND.Text, dateTimePicker1.Value);
            HocSinhDao hocSinhDao = new HocSinhDao();
            hocSinhDao.xoa(hocSinh);

            Form1_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HocSinh hocSinh = new HocSinh(txtTen.Text, txtDiaChi.Text, txtCMND.Text, dateTimePicker1.Value);
            HocSinhDao hocSinhDao = new HocSinhDao();
            hocSinhDao.sua(hocSinh);

            Form1_Load(sender, e);
        }

        private void gvHSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTen.Text = gvHSinh.CurrentRow.Cells[0].Value.ToString();
            txtDiaChi.Text = gvHSinh.CurrentRow.Cells[1].Value.ToString();
            txtCMND.Text = gvHSinh.CurrentRow.Cells[2].Value.ToString();

            //DateTime ngay = Convert.ToDateTime(gvHSinh.CurrentRow.Cells[3].Value.ToString("MM/dd/yyyy"));
            //MessageBox.Show(ngay.ToString("dd/MM/yyyy"));
            //dateTimePicker1.Value = ngay;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FGiaoVien abc = new FGiaoVien();
            abc.ShowDialog();
        }
    }
   }