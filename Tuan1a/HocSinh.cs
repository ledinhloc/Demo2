using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan1a
{
    internal class HocSinh
    {
        private string ten;
        private string diaChi;
        private string cmnd;
        private DateTime ngaySinh;    
        
        public HocSinh(string ten, string diaChi, string cmnd, DateTime ngay)
        {
            this.Ten = ten;
            this.DiaChi = diaChi;
            this.cmnd = cmnd;
            this.NgaySinh = ngay;   
        }

        public string Ten { get => ten; set => ten = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
    }
}
