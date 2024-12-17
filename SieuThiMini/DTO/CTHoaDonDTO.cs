using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    class CTHoaDonDTO
    {
        public int maHoadon { get; set; }
        public int maSanpham { get; set; }
        public string tenSanpham { get; set; }
        public int soLuong { get; set; }
        public int giaSanpham { get; set; }
        public int thanhTien { get; set; }



        public CTHoaDonDTO(int maHoadon, int maSanpham,string tenSanpham,int soLuong,int giaSanpham, int thanhTien)
        {
            this.maHoadon = maHoadon;
            this.tenSanpham = tenSanpham;
            this.maSanpham = maSanpham;
            this.soLuong = soLuong;
            this.giaSanpham = giaSanpham;
            this.thanhTien = thanhTien;
        }
    }
}
