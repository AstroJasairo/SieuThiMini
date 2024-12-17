using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    class NhaCungCapDTO
    {
        public int maNhacungcap { get; set; }
        public string tenNhacungcap { get; set; }
        public string diaChi { get; set; }

        public string trangThai { get; set; }

        public NhaCungCapDTO(int maNhacungcap,string tenNhacungcap, string diaChi, string trangThai)
        {
            this.maNhacungcap = maNhacungcap;
            this.tenNhacungcap = tenNhacungcap;
            this.diaChi = diaChi;
            this.trangThai = trangThai;
        }
    }
}
