using SieuThiMini.DTO;

using System.Collections.Generic;
using System.Data;

namespace SieuThiMini.DAO
{
    class ThongKeDAO: DataConection
    {
		public ThongKeDAO() { }
		public  int TongDoanhThuCacHoaDon()
		{
			int tongDoanhthu=0;
			

			string queryStr = "SELECT SUM(tong_tien) FROM `hoa_don` WHERE trang_thai=1";
			
			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];

				
				tongDoanhthu = int.Parse(datarow.ItemArray[0].ToString());
			

				
			}

			return tongDoanhthu;
		}

		public int TongHoaDonDaThanhToan()
		{
			int tongHoaDon = 0;


			string queryStr = "SELECT COUNT(ma_hoa_don) FROM `hoa_don` WHERE trang_thai=1;";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				tongHoaDon = int.Parse(datarow.ItemArray[0].ToString());



			}

			return tongHoaDon;
		}

		public int TongChiPhiNhapHang()
		{
			int tongChiPhi = 0;


			string queryStr = "SELECT SUM(tong_tien_nhap) FROM `don_nhap_hang` WHERE trang_thai=1";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				tongChiPhi = int.Parse(datarow.ItemArray[0].ToString());



			}

			return tongChiPhi;
		}

		public int SoTaiKhoan()
		{
			int soTaikhoan = 0;


			string queryStr = "SELECT COUNT(ma_tai_khoan) FROM `tai_khoan` WHERE trang_thai = 1";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				soTaikhoan = int.Parse(datarow.ItemArray[0].ToString());



			}

			return soTaikhoan;
		}

		public int TongSoLuongSanPham()
		{
			int tongSoLuongSanPham = 0;


			string queryStr = "SELECT COUNT(ma_san_pham) FROM `san_pham` WHERE trang_thai = 1";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				tongSoLuongSanPham = int.Parse(datarow.ItemArray[0].ToString());



			}

			return tongSoLuongSanPham;
		}

        public int SoLuongNhaCC()
        {
            int soluongNhanCC = 0;


            string queryStr = "SELECT COUNT(ma_ncc) FROM `nha_cung_cap`";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];


                soluongNhanCC = int.Parse(datarow.ItemArray[0].ToString());



            }

            return soluongNhanCC;
        }

        public int SoLuongNhanVien()
		{
			int soluongNhanVien = 0;


			string queryStr = "SELECT COUNT(ma_nhan_vien) FROM `nhan_vien`";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				soluongNhanVien = int.Parse(datarow.ItemArray[0].ToString());



			}

			return soluongNhanVien;
		}

        //Số hóa đơn
        public int SoHoaDonNam(int selectedYear)
        {
            int tongDon = 0;
            string queryStr = "SELECT count(ma_hoa_don) FROM `hoa_don` WHERE trang_thai=1 AND YEAR(ngay_xuat) = " + selectedYear;
            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            if (result.Rows.Count > 0)
            {
                DataRow dataRow = result.Rows[0];
                if (!string.IsNullOrEmpty(dataRow[0].ToString()))
                {
                    tongDon = int.Parse(dataRow[0].ToString());
                }
            }

            return tongDon;
        }

        public int SoHoaDonThangNam(int selectedMonth, int selectedYear)
        {
            int tongDon = 0;
            string queryStr = "SELECT count(ma_hoa_don) FROM `hoa_don` WHERE trang_thai=1 AND MONTH(ngay_xuat) = " + selectedMonth + " AND YEAR(ngay_xuat) = " + selectedYear;
            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            if (result.Rows.Count > 0)
            {
                DataRow dataRow = result.Rows[0];
                if (!string.IsNullOrEmpty(dataRow[0].ToString()))
                {
                    tongDon = int.Parse(dataRow[0].ToString());
                }
            }

            return tongDon;
        }

        //Doanh thu
        public int TongDoanhThuHangNam(int selectedYear)
        {
            int tongDoanhthu = 0;
            string queryStr = "SELECT SUM(tong_tien) FROM `hoa_don` WHERE trang_thai=1 AND YEAR(ngay_xuat) = " + selectedYear;
            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            if (result.Rows.Count > 0)
            {
                DataRow dataRow = result.Rows[0];
                if (!string.IsNullOrEmpty(dataRow[0].ToString()))
                {
                    tongDoanhthu = int.Parse(dataRow[0].ToString());
                }
            }

            return tongDoanhthu;
        }

        public int TongDoanhThuHangThangNam(int selectedMonth, int selectedYear)
        {
            int tongDoanhthu = 0;
            string queryStr = "SELECT SUM(tong_tien) FROM `hoa_don` WHERE trang_thai=1 AND MONTH(ngay_xuat) = " + selectedMonth + " AND YEAR(ngay_xuat) = "+selectedYear;
            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            if (result.Rows.Count > 0)
            {
                DataRow dataRow = result.Rows[0];
                if (!string.IsNullOrEmpty(dataRow[0].ToString()))
                {
                    tongDoanhthu = int.Parse(dataRow[0].ToString());
                }
            }

            return tongDoanhthu;
        }

        //Số đơn nhập hàng
        public int SoDonNhapHangNam(int selectedYear)
        {
            int tongDon = 0;
            string queryStr = "SELECT count(ma_don_nh) FROM `don_nhap_hang` WHERE trang_thai=1 AND YEAR(ngay_nhap) = " + selectedYear;
            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            if (result.Rows.Count > 0)
            {
                DataRow dataRow = result.Rows[0];
                if (!string.IsNullOrEmpty(dataRow[0].ToString()))
                {
                    tongDon = int.Parse(dataRow[0].ToString());
                }
            }

            return tongDon;
        }
        public int SoDonNhapHangThangNam(int selectedMonth, int selectedYear)
        {
            int tongDon = 0;
            string queryStr = "SELECT count(ma_don_nh) FROM `don_nhap_hang` WHERE trang_thai=1 AND MONTH(ngay_nhap) = " + selectedMonth + " AND YEAR(ngay_nhap) = " + selectedYear;
            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            if (result.Rows.Count > 0)
            {
                DataRow dataRow = result.Rows[0];
                if (!string.IsNullOrEmpty(dataRow[0].ToString()))
                {
                    tongDon = int.Parse(dataRow[0].ToString());
                }
            }

            return tongDon;
        }

        //Chi phí nhập hàng
        public int TongChiPhiNhapHangTheoThangNam(int selectedMonth, int selectedYear)
        {
            int tongChiPhi = 0;

            string queryStr = "SELECT SUM(tong_tien_nhap) FROM `don_nhap_hang` WHERE trang_thai = 1 AND MONTH(ngay_nhap) = " + selectedMonth + " AND YEAR(ngay_nhap) = " + selectedYear;

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            if (result.Rows.Count > 0)
            {
                DataRow dataRow = result.Rows[0];
                if (!string.IsNullOrEmpty(dataRow[0].ToString()))
                {
                    tongChiPhi = int.Parse(dataRow[0].ToString());
                }
            }

            return tongChiPhi;
        }
        public int TongChiPhiNhapHangTheoNam(int selectedYear)
        {
            int tongChiPhi = 0;

            string queryStr = "SELECT SUM(tong_tien_nhap) FROM `don_nhap_hang` WHERE trang_thai = 1 AND YEAR(ngay_nhap) = " + selectedYear;

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            if (result.Rows.Count > 0)
            {
                DataRow dataRow = result.Rows[0];
                if (!string.IsNullOrEmpty(dataRow[0].ToString()))
                {
                    tongChiPhi = int.Parse(dataRow[0].ToString());
                }
            }

            return tongChiPhi;
        }

        public DataTable TimMaNhanVienCoTongTienLonNhatTheoThangNam(int selectedMonth, int selectedYear)
        {
            // Thực hiện truy vấn SQL để lấy dữ liệu
            string queryStr = @"
        SELECT 
            hoa_don.ma_nhan_vien, 
            nhan_vien.ten_nhan_vien, 
            SUM(hoa_don.tong_tien) AS TongTienLonNhat
        FROM 
            hoa_don
        JOIN 
            nhan_vien ON hoa_don.ma_nhan_vien = nhan_vien.ma_nhan_vien
        WHERE 
            hoa_don.trang_thai = 1 
            AND MONTH(hoa_don.ngay_xuat) = " + selectedMonth +
                    " AND YEAR(hoa_don.ngay_xuat) = " + selectedYear + @"
        GROUP BY 
            hoa_don.ma_nhan_vien
        ORDER BY 
            TongTienLonNhat DESC
        LIMIT 1";

            return DataProvider.Instance.ExecuteQuery(queryStr);
        }

        public DataTable TimMaNhanVienCoTongTienLonNhatTheoNam( int selectedYear)
        {
            // Thực hiện truy vấn SQL để lấy dữ liệu
            string queryStr = @"
        SELECT 
            hoa_don.ma_nhan_vien, 
            nhan_vien.ten_nhan_vien, 
            SUM(hoa_don.tong_tien) AS TongTienLonNhat
        FROM 
            hoa_don
        JOIN 
            nhan_vien ON hoa_don.ma_nhan_vien = nhan_vien.ma_nhan_vien
        WHERE 
            hoa_don.trang_thai = 1 
            AND YEAR(hoa_don.ngay_xuat) = " + selectedYear + @"
        GROUP BY 
            hoa_don.ma_nhan_vien
        ORDER BY 
            TongTienLonNhat DESC
        LIMIT 1";

            return DataProvider.Instance.ExecuteQuery(queryStr);
        }
    }
}
