using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace SieuThiMini.DAO
{
    class CTHoaDonDAO: DataConection
    {
		public CTHoaDonDAO() { }
		public List<CTHoaDonDTO> SelectAll()
		{
			List<CTHoaDonDTO> dtoList = new List<CTHoaDonDTO>();
			

			string queryStr = "select * from chi_tiet_hoa_don";
			
			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];

				
				int maHoaDon = int.Parse(datarow.ItemArray[0].ToString());
				int maSanpham = int.Parse(datarow.ItemArray[1].ToString());
				string tenSanpham = datarow.ItemArray[2].ToString();
				int soLuong = int.Parse(datarow.ItemArray[3].ToString());
				int giaSanPham=int.Parse(datarow.ItemArray[4].ToString());
				int thanhTien=int.Parse(datarow.ItemArray[5].ToString());

				CTHoaDonDTO dto = new CTHoaDonDTO(maHoaDon, maSanpham, tenSanpham, soLuong, giaSanPham,thanhTien);
				dtoList.Add(dto);
			}

			return dtoList;
		}


		public int Insert(CTHoaDonDTO target)
		{
		
			Moketnoi();
			string insertStr = $"insert into chi_tiet_hoa_don values ('{target.maHoadon}', '{target.maSanpham}', '{target.tenSanpham}', " +
															$"'{target.soLuong}','{target.giaSanpham}','{target.thanhTien}')";

			return DataProvider.Instance.ExecuteNonQuery(insertStr);
		}

		

		public List<CTHoaDonDTO> getCTHoaDonByMaHD(string ma_hoa_don)
		{
			List<CTHoaDonDTO> dtoList = new List<CTHoaDonDTO>();


			string queryStr = $"select * from chi_tiet_hoa_don where ma_hoa_don='{ma_hoa_don}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maHoaDon = int.Parse(datarow.ItemArray[0].ToString());
				int maSanpham = int.Parse(datarow.ItemArray[1].ToString());
				string tenSanpham = datarow.ItemArray[2].ToString();
				int soLuong = int.Parse(datarow.ItemArray[3].ToString());
				int giaSanPham = int.Parse(datarow.ItemArray[4].ToString());
				int thanhTien = int.Parse(datarow.ItemArray[5].ToString());

				CTHoaDonDTO dto = new CTHoaDonDTO(maHoaDon, maSanpham, tenSanpham, soLuong, giaSanPham, thanhTien);
				dtoList.Add(dto);
			}

			return dtoList;
		}
	}
}
