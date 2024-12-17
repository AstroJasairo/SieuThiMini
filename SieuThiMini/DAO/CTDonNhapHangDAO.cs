using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace SieuThiMini.DAO
{
    class CTDonNhapHangDAO : DataConection
    {
		public List<CTDonNhapHangDTO> SelectAll()
		{
			List<CTDonNhapHangDTO> dtoList = new List<CTDonNhapHangDTO>();
			

			string queryStr = "select * from chi_tiet_don_nhap_hang";
			
			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];

				
				int maDonNH = int.Parse(datarow.ItemArray[0].ToString());
				int maSanpham = int.Parse(datarow.ItemArray[1].ToString());
				string tenSanpham = datarow.ItemArray[2].ToString();
				int soLuong = int.Parse(datarow.ItemArray[3].ToString());
				int giaSanPham = int.Parse(datarow.ItemArray[4].ToString());
				int thanhTien = int.Parse(datarow.ItemArray[5].ToString());

				CTDonNhapHangDTO dto = new CTDonNhapHangDTO(maDonNH, maSanpham, tenSanpham, soLuong,giaSanPham,thanhTien);
				dtoList.Add(dto);
			}

			return dtoList;
		}

		public int Insert(CTDonNhapHangDTO target)
		{

			Moketnoi();
			string insertStr = $"insert into chi_tiet_don_nhap_hang values ('{target.maDonNH}', '{target.maSanpham}', '{target.tenSanpham}', " +
															$"'{target.soLuong}','{target.giaSanpham}','{target.thanhTien}')";

			return DataProvider.Instance.ExecuteNonQuery(insertStr);
		}

		public List<CTDonNhapHangDTO> getCTDNHByMaDNH(string ma_don_nh)
		{
			List<CTDonNhapHangDTO> dtoList = new List<CTDonNhapHangDTO>();


			string queryStr = $"select * from chi_tiet_don_nhap_hang where ma_don_nh='{ma_don_nh}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maDonNH = int.Parse(datarow.ItemArray[0].ToString());
				int maSanpham = int.Parse(datarow.ItemArray[1].ToString());
				string tenSanpham = datarow.ItemArray[2].ToString();
				int soLuong = int.Parse(datarow.ItemArray[3].ToString());
				int giaSanPham = int.Parse(datarow.ItemArray[4].ToString());
				int thanhTien = int.Parse(datarow.ItemArray[5].ToString());

				CTDonNhapHangDTO dto = new CTDonNhapHangDTO(maDonNH, maSanpham, tenSanpham, soLuong, giaSanPham, thanhTien);
				dtoList.Add(dto);
			}

			return dtoList;
		}

	}
}
