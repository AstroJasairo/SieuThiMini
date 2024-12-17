using SieuThiMini.DAO;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.BLL
{
    class ThongKeBLL
    {
        private ThongKeDAO DAO;
        


        public ThongKeBLL()
        {
            this.DAO = new ThongKeDAO();
        }

        public int TongDoanhThuCacHoaDon()
        {
            return this.DAO.TongDoanhThuCacHoaDon();
        }

        public int TongHoaDonDaThanhToan()
        {
            return this.DAO.TongHoaDonDaThanhToan();
        }

        public int TongChiPhiNhapHang()
        {
            return this.DAO.TongChiPhiNhapHang();
        }
        public int SoTaiKhoan()
        {
            return this.DAO.SoTaiKhoan();
        }

        public int TongSoLuongSanPham()
        {
            return this.DAO.TongSoLuongSanPham();
        }
        public int SoLuongNhaCC()
        {
            return this.DAO.SoLuongNhaCC();
        }

        public int SoLuongNhanVien()
        {
            return this.DAO.SoLuongNhanVien();
        }

        //Số hóa đơn
        public int SoHoaDonThangNam(int selectedMonth, int selectedYear)
        {
            return this.DAO.SoHoaDonThangNam(selectedMonth, selectedYear);
        }

        public int SoHoaDonNam(int selectedYear)
        {
            return this.DAO.SoHoaDonNam(selectedYear);
        }

        //Doanh thu
        public int TongDoanhThuHangNam(int selectedYear)
        {
            return this.DAO.TongDoanhThuHangNam(selectedYear);
        }

        public int TongDoanhThuHangThangNam(int selectedMonth, int selectedYear)
        {
            return this.DAO.TongDoanhThuHangThangNam(selectedMonth,selectedYear);
        }

        //Số đơn nhập hàng
        public int SoDonNhapHangThangNam(int selectedMonth, int selectedYear)
        {
            return this.DAO.SoDonNhapHangThangNam(selectedMonth, selectedYear);
        }

        public int SoDonNhapHangNam(int selectedYear)
        {
            return this.DAO.SoDonNhapHangNam(selectedYear);
        }

        //Chi phí nhập hàng
        public int TongChiPhiNhapHangTheoThangNam(int selectedMonth,int selectedYear)
        {
            return this.DAO.TongChiPhiNhapHangTheoThangNam(selectedMonth, selectedYear);
        }

        public int TongChiPhiNhapHangTheoNam(int selectedYear)
        {
            return this.DAO.TongChiPhiNhapHangTheoNam(selectedYear);
        }

       
        public DataTable TimMaNhanVienCoTongTienLonNhatTheoThangNam(int selectedMonth, int selectedYear)
        {
            return this.DAO.TimMaNhanVienCoTongTienLonNhatTheoThangNam(selectedMonth, selectedYear);
        }
        public DataTable TimMaNhanVienCoTongTienLonNhatTheoNam( int selectedYear)
        {
            return this.DAO.TimMaNhanVienCoTongTienLonNhatTheoNam( selectedYear);
        }
    }
}
