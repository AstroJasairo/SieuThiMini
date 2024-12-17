using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace SieuThiMini.DAO
{
    class SanPhamDAO: DataConection
    {

		public SanPhamDAO() { }
		public  List<SanPhamDTO> SelectAll()
		{
			List<SanPhamDTO> dtoList = new List<SanPhamDTO>();
			

			string queryStr = "select * from san_pham where trang_thai = 1";
			
			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];

				
				int maSanpham = int.Parse(datarow.ItemArray[0].ToString());
				string tenSanpham = datarow.ItemArray[1].ToString();
				int soLuong = int.Parse(datarow.ItemArray[2].ToString());
				int gia = int.Parse(datarow.ItemArray[3].ToString());
                int gianhap = int.Parse(datarow.ItemArray[4].ToString());
                int maLoai = int.Parse(datarow.ItemArray[5].ToString());
                string trangThai = datarow.ItemArray[6].ToString();
                SanPhamDTO dto = new SanPhamDTO(maSanpham,tenSanpham,soLuong,gia,gianhap,maLoai,trangThai);
                dtoList.Add(dto);
            }
            return dtoList;
        }
        public List<SanPhamDTO> SelectAlltrangthai0()
        {
            List<SanPhamDTO> dtoList = new List<SanPhamDTO>();


            string queryStr = "select * from san_pham where trang_thai = 0";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];


                int maSanpham = int.Parse(datarow.ItemArray[0].ToString());
                string tenSanpham = datarow.ItemArray[1].ToString();
                int soLuong = int.Parse(datarow.ItemArray[2].ToString());
                int gia = int.Parse(datarow.ItemArray[3].ToString());
                int gianhap = int.Parse(datarow.ItemArray[4].ToString());
                int maLoai = int.Parse(datarow.ItemArray[5].ToString());
                string trangThai = datarow.ItemArray[6].ToString();
                SanPhamDTO dto = new SanPhamDTO(maSanpham, tenSanpham, soLuong, gia, gianhap, maLoai, trangThai);
                dtoList.Add(dto);
            }
            return dtoList;
        }
        public int Insert(SanPhamDTO target)
        {
            Moketnoi();
			string insertStr = $"insert into san_pham values ('', '{target.tenSanpham}', '{target.soLuong}', " +
															$"'{target.gia}','{target.gianhap}', '{target.maLoai}','1')";
			return DataProvider.Instance.ExecuteNonQuery(insertStr);
		}

		public  void Update(SanPhamDTO target)
		{
			Moketnoi();
			string updateStr = "update san_pham set ";
			updateStr += $"ten_san_pham = '{target.tenSanpham}', ";
			updateStr += $"so_luong = '{target.soLuong}', ";
			updateStr += $"gia = '{target.gia}', ";
            updateStr += $"gia_nhap = '{target.gianhap}', ";
            updateStr += $"ma_loai = '{target.maLoai}' ";
			updateStr += $"where ma_san_pham='{target.maSanpham}'";

			DataProvider.Instance.ExecuteNonQuery(updateStr);
		}

		public void UpdateSoLuong(int maSanpham,int soLuong)
		{
			Moketnoi();
			string updateStr = "update san_pham set ";
			updateStr += $"so_luong = '{soLuong}' ";
			updateStr += $"where ma_san_pham='{maSanpham}'";

			DataProvider.Instance.ExecuteNonQuery(updateStr);
		}

        public int CheckSoLuong(int maSanPham)
        {
            string checkQuery = $"SELECT so_luong FROM san_pham WHERE ma_san_pham = '{maSanPham}'";

            // Thực hiện truy vấn để kiểm tra số lượng
            object result = DataProvider.Instance.ExecuteScalar(checkQuery);

            // Kiểm tra giá trị trả về từ truy vấn
            if (result != null && result != DBNull.Value)
            {
                int soLuong = Convert.ToInt32(result);
                if (soLuong > 0)
                {
                    // Số lượng lớn hơn 0, trả về giá trị số lượng
                    return soLuong;
                }
            }

            // Trả về -1 nếu có lỗi trong quá trình kiểm tra hoặc số lượng không lớn hơn 0
            return -1;
        }


        public int Delete(int id)
        {
            Moketnoi();
            string deleteStr = $"update san_pham set trang_thai='0' where ma_san_pham = '{id}'";

            return DataProvider.Instance.ExecuteNonQuery(deleteStr);
        }

        public int Restore(int id)
        {
            Moketnoi();
            string updateStr = $"update san_pham set trang_thai='1' where ma_san_pham = '{id}'";
            return DataProvider.Instance.ExecuteNonQuery(updateStr);
        }
        public List<SanPhamDTO> Timkiem(string value)
        {
            List<SanPhamDTO> dtoList = new List<SanPhamDTO>();


            string queryStr = $"select * from san_pham where ma_san_pham='{value}' and trang_thai = 1 or ten_san_pham like '%{value}%' and trang_thai = 1";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];


                int maSanpham = int.Parse(datarow.ItemArray[0].ToString());
                string tenSanpham = datarow.ItemArray[1].ToString();
                int soLuong = int.Parse(datarow.ItemArray[2].ToString());
                int gia = int.Parse(datarow.ItemArray[3].ToString());
                int gianhap = int.Parse(datarow.ItemArray[4].ToString());
                int maLoai = int.Parse(datarow.ItemArray[5].ToString());
                string trangThai = datarow.ItemArray[6].ToString();
                SanPhamDTO dto = new SanPhamDTO(maSanpham, tenSanpham, soLuong, gia, gianhap, maLoai, trangThai);
                dtoList.Add(dto);
            }

            return dtoList;
        }
        public List<SanPhamDTO> Timkiemtrangthai0(string value)
        {
            List<SanPhamDTO> dtoList = new List<SanPhamDTO>();


            string queryStr = $"select * from san_pham where ma_san_pham='{value}' and trang_thai = 0 or ten_san_pham like '%{value}%' and trang_thai = 0";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];


                int maSanpham = int.Parse(datarow.ItemArray[0].ToString());
                string tenSanpham = datarow.ItemArray[1].ToString();
                int soLuong = int.Parse(datarow.ItemArray[2].ToString());
                int gia = int.Parse(datarow.ItemArray[3].ToString());
                int gianhap = int.Parse(datarow.ItemArray[4].ToString());
                int maLoai = int.Parse(datarow.ItemArray[5].ToString());
                string trangThai = datarow.ItemArray[6].ToString();
                SanPhamDTO dto = new SanPhamDTO(maSanpham, tenSanpham, soLuong, gia, gianhap, maLoai, trangThai);
                dtoList.Add(dto);
            }

            return dtoList;
        }
        public List<SanPhamDTO> getSPByLoaiSP(int ma_loai)
		{
			List<SanPhamDTO> dtoList = new List<SanPhamDTO>();


			string queryStr = $"select * from san_pham where ma_loai='{ma_loai}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maSanpham = int.Parse(datarow.ItemArray[0].ToString());
				string tenSanpham = datarow.ItemArray[1].ToString();
				int soLuong = int.Parse(datarow.ItemArray[2].ToString());
				int gia = int.Parse(datarow.ItemArray[3].ToString());
                int gianhap = int.Parse(datarow.ItemArray[4].ToString());
                int maLoai = int.Parse(datarow.ItemArray[5].ToString());
                string trangThai = datarow.ItemArray[6].ToString();
                SanPhamDTO dto = new SanPhamDTO(maSanpham, tenSanpham, soLuong, gia, gianhap, maLoai, trangThai);
                dtoList.Add(dto);
			}

			return dtoList;
		}

		public List<SanPhamDTO> getSPByMaSp(int ma_san_pham)
		{
			List<SanPhamDTO> dtoList = new List<SanPhamDTO>();


			string queryStr = $"select * from san_pham where ma_san_pham='{ma_san_pham}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maSanpham = int.Parse(datarow.ItemArray[0].ToString());
				string tenSanpham = datarow.ItemArray[1].ToString();
				int soLuong = int.Parse(datarow.ItemArray[2].ToString());
				int gia = int.Parse(datarow.ItemArray[3].ToString());
                int gianhap = int.Parse(datarow.ItemArray[3].ToString());
                int maLoai = int.Parse(datarow.ItemArray[4].ToString());
                string trangThai = datarow.ItemArray[6].ToString();
                SanPhamDTO dto = new SanPhamDTO(maSanpham, tenSanpham, soLuong, gia, gianhap, maLoai, trangThai);
                dtoList.Add(dto);
			}

			return dtoList;
		}

	}
}
