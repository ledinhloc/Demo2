using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan1a
{
    public partial class FGiaoVien : Form
    {
        public FGiaoVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtTen.Text, txtDiaChi.Text, txtCMND.Text, dateTimePicker1.Value);
            GiaoVienDao gvDao = new GiaoVienDao();
            gvDao.them(gv);

            FGiaoVien_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtTen.Text, txtDiaChi.Text, txtCMND.Text, dateTimePicker1.Value);
            GiaoVienDao gvDao = new GiaoVienDao();
            gvDao.sua(gv);

            FGiaoVien_Load(sender, e);
        }

        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            GiaoVienDao gvDao = new GiaoVienDao();
            gvGVien.DataSource = gvDao.Load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtTen.Text, txtDiaChi.Text, txtCMND.Text, dateTimePicker1.Value);
            GiaoVienDao gvDao = new GiaoVienDao();
            gvDao.xoa(gv);

            FGiaoVien_Load(sender, e);
        }
    }
}
