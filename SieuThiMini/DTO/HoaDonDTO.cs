using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    class HoaDonDTO
    {
        public int maHoaDon { get; set; }
        public int maNhanVien { get; set; }
        public DateTime ngayXuat { get; set; }
        public int tongTien { get; set; }
        public string trangThai { get; set; }

        public HoaDonDTO(int maHoaDon, DateTime ngayXuat, int maNhanVien,  int tongTien,string trangThai)
        {
            this.maHoaDon = maHoaDon;
            this.maNhanVien = maNhanVien;
            this.ngayXuat = ngayXuat;
            this.tongTien = tongTien;
            this.trangThai = trangThai;
            
        }
    }
}
