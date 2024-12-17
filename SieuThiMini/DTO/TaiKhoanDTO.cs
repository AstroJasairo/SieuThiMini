using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    class TaiKhoanDTO
    {
        public int maTaikhoan { get; set; }
        public string tenTaikhoan { get; set; }
        public string matKhau { get; set; }
        public int maQuyen { get; set; }
        public string trangThai { get; set; }


        public TaiKhoanDTO(int maTaikhoan, string tenTaikhoan, string matKhau, int maQuyen,string trangThai)
        {
            this.maTaikhoan = maTaikhoan;
            this.tenTaikhoan = tenTaikhoan;
            this.matKhau = matKhau;
            this.maQuyen = maQuyen;
            this.trangThai = trangThai;
        }
    }
}
