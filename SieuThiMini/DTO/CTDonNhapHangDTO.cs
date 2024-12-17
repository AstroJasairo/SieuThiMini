using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    class CTDonNhapHangDTO
    {
        public int maDonNH { get; set; }
        public int maSanpham { get; set; }
        public string tenSanpham { get; set; }
        public int soLuong { get; set; }
        public int giaSanpham { get; set; }
        public int thanhTien { get; set; }



        public CTDonNhapHangDTO(int maDonNH,int maSanpham, string tenSanpham,int soLuong,int giaSanpham,int thanhTien)
        {
            this.maDonNH = maDonNH;
            this.maSanpham = maSanpham;
            this.tenSanpham = tenSanpham;
            this.soLuong = soLuong;
            this.giaSanpham = giaSanpham;
            this.thanhTien = thanhTien;
        }
    }
}
