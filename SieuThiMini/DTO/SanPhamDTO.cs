using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    class SanPhamDTO
    {
        public int maSanpham { get; set; }
        public string tenSanpham { get; set; }
        public int soLuong { get; set; }
        public int gia { get; set; }
        public int gianhap { get; set; }
        public int maLoai { get; set; }

        public string trangThai { get; set; }

        public SanPhamDTO(int maSanpham,string tenSanpham,int soLuong,int gia,int gianhap, int maLoai, string trangThai)
        {
            this.maSanpham = maSanpham;
            this.tenSanpham = tenSanpham;
            this.soLuong = soLuong;
            this.gia = gia;
            this.gianhap = gianhap;
            this.maLoai = maLoai;
            this.trangThai = trangThai;
        }
    }
}
