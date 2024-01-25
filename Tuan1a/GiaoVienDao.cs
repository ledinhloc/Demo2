using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan1a
{
    internal class GiaoVienDao
    {
        dbConnect db = new dbConnect();

        public void them(GiaoVien giaoVien)
        {
            string sqlStr = string.Format("INSERT INTO GiaoVien(Ten, Diachi, Cmnd, Ngaysinh) VALUES('{0}','{1}', '{2}', '{3}')", giaoVien.Ten, giaoVien.DiaChi, giaoVien.Cmnd, giaoVien.NgaySinh.Date.ToString("dd/MM/yyyy"));
            db.ThucThi(sqlStr);
           
        }

        public void xoa(GiaoVien giaoVien)
        {
            string SQL = string.Format("DELETE FROM GiaoVien WHERE Cmnd = '{0}'", giaoVien.Cmnd);
            db.ThucThi(SQL);
           
        }
        public void sua(GiaoVien giaoVien)
        {
            string SQL = string.Format("UPDATE GiaoVien SET Ten = '{0}', DiaChi = '{1}',Ngaysinh = '{2}' WHERE Cmnd = '{3}'", giaoVien.Ten, giaoVien.DiaChi, giaoVien.NgaySinh.Date.ToString("dd/MM/yyyy"), giaoVien.Cmnd);
            db.ThucThi(SQL);         
        }

        public DataTable Load()
        {
            return db.Load("GiaoVien");
        }
    }
}
