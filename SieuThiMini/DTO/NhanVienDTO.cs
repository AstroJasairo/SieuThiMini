using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    class NhanVienDTO
    {
        public int maNhanvien { get; set; }
        public string tenNhanvien { get; set; }
        public DateTime ngaySinh { get; set; }
        public string sdt { get; set; }
        public string mail { get; set; } 
        public int maTaikhoan { get; set; }
        public string trangThai { get; set; }

        public NhanVienDTO(int maNhanvien, string tenNhanvien,DateTime ngaySinh, string sdt, string mail, int maTaikhoan, string trangThai)
        {
            this.maNhanvien = maNhanvien;
            this.tenNhanvien = tenNhanvien;
            this.ngaySinh = ngaySinh;
            this.sdt = sdt;
            this.mail = mail;
            this.maTaikhoan = maTaikhoan;
            this.trangThai = trangThai;
        }
    }
}
