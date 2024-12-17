using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    class LoaiSanPhamDTO
    {
        public int maLoai { get; set; }
        public string tenLoai { get; set; }

        public int maNcc { get;  set; }
      
        public string trangThai { get; set; }

        public LoaiSanPhamDTO(int maLoai,string tenLoai,int maNcc, string trangThai)
        {
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
            this.maNcc = maNcc;
            this.trangThai = trangThai;
        }
    }
}
