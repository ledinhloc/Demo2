using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Tuan1a
{
    internal class HocSinhDao
    {
        dbConnect db = new dbConnect();
        public void them(HocSinh hocSinh)
        {
            string sqlStr = string.Format("INSERT INTO HocSinh(Ten, Diachi, Cmnd, Ngaysinh) VALUES('{0}','{1}', '{2}', '{3}')", hocSinh.Ten, hocSinh.DiaChi, hocSinh.Cmnd, hocSinh.NgaySinh.Date.ToString("dd/MM/yyyy"));
            db.ThucThi(sqlStr);            
        }

        public void xoa(HocSinh hocSinh)
        {
            string sqlStr = string.Format("DELETE FROM HocSinh WHERE Cmnd = '{0}'", hocSinh.Cmnd);
            db.ThucThi(sqlStr);
        }
        public void sua(HocSinh hocSinh)
        {
            string sqlStr = string.Format("UPDATE HocSinh SET Ten = '{0}', DiaChi = '{1}',Ngaysinh = '{2}' WHERE Cmnd = '{3}'", hocSinh.Ten, hocSinh.DiaChi, hocSinh.NgaySinh.Date.ToString("dd/MM/yyyy"), hocSinh.Cmnd);
            db.ThucThi(sqlStr); 
        }

        public DataTable Load()
        {
            return db.Load("HocSinh");
        }
    }
}
