using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    class DonNhapHangDTO
    {
        public int maDonNH { get; set; }
        public int maNhacungcap { get; set; }
        public int maNhanvien {  get; set; }
        public DateTime ngayNhap { get; set; }
        public int tongTien { get; set; }
       
        public String trangThai { get; set; }

        public DonNhapHangDTO(int maDonNH, int maNhacungcap,int maNhanvien,DateTime ngayNhap,int tongTien,String trangThai)
        {
            this.maDonNH = maDonNH;
            this.maNhacungcap = maNhacungcap;
            this.maNhanvien = maNhanvien;
            this.ngayNhap = ngayNhap;
            
            this.tongTien = tongTien;
            this.trangThai = trangThai;
        }
    }
}
