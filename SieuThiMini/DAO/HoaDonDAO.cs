using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace SieuThiMini.DAO
{
    class HoaDonDAO: DataConection
    {
		public HoaDonDAO() { }
		public List<HoaDonDTO> SelectAll()
		{
			List<HoaDonDTO> dtoList = new List<HoaDonDTO>();
			

			string queryStr = "select * from hoa_don where trang_thai='1' ";
			
			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];

				
				int maHoaDon = int.Parse(datarow.ItemArray[0].ToString());
				DateTime ngayXuat = (DateTime)datarow.ItemArray[1];
				int maTaikhoan=int.Parse(datarow.ItemArray[2].ToString());
				int tongTien=int.Parse(datarow.ItemArray[3].ToString());
				string trangThai = datarow.ItemArray[4].ToString();
				HoaDonDTO dto = new HoaDonDTO(maHoaDon, ngayXuat, maTaikhoan, tongTien,trangThai);
				dtoList.Add(dto);
			}

			return dtoList;
		}

        public List<HoaDonDTO> SelectAllDeleted()
        {
            List<HoaDonDTO> dtoList = new List<HoaDonDTO>();


            string queryStr = "select * from hoa_don where trang_thai='0' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];


                int maHoaDon = int.Parse(datarow.ItemArray[0].ToString());
                DateTime ngayXuat = (DateTime)datarow.ItemArray[1];
                int maTaikhoan = int.Parse(datarow.ItemArray[2].ToString());
                int tongTien = int.Parse(datarow.ItemArray[3].ToString());
                string trangThai = datarow.ItemArray[4].ToString();
                HoaDonDTO dto = new HoaDonDTO(maHoaDon, ngayXuat, maTaikhoan, tongTien, trangThai);
                dtoList.Add(dto);
            }

            return dtoList;
        }
        public int Insert(HoaDonDTO target)
		{
			string ngayXuat = target.ngayXuat.ToString("yyyy-MM-dd");
			Moketnoi();
			string insertStr = $"insert into hoa_don values ('0', '{ngayXuat}', '{target.maNhanVien}', " +
															$"'{target.tongTien}','1')";
			return DataProvider.Instance.ExecuteNonQuery(insertStr);
		}


		public int Delete(int id)
		{
			Moketnoi();
			string deleteStr = $"update hoa_don set trang_thai='0' where ma_hoa_don = '{id}'";

			return DataProvider.Instance.ExecuteNonQuery(deleteStr);
		}

		public int Restore(string mahoadon)
		{
			Moketnoi();
			string updateStr= $"update hoa_don set trang_thai='1' where ma_hoa_don = '{mahoadon}'";
			return DataProvider.Instance.ExecuteNonQuery(updateStr);
        }

		public List<HoaDonDTO> getHDByMaHD(string ma_hoa_don)
		{
			List<HoaDonDTO> dtoList = new List<HoaDonDTO>();


			string queryStr = $"select * from hoa_don where ma_hoa_don='{ma_hoa_don}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maHoaDon = int.Parse(datarow.ItemArray[0].ToString());
				DateTime ngayXuat = (DateTime)datarow.ItemArray[1];
				int maTaikhoan = int.Parse(datarow.ItemArray[2].ToString());
				int tongTien = int.Parse(datarow.ItemArray[3].ToString());
                string trangThai = datarow.ItemArray[4].ToString();
                HoaDonDTO dto = new HoaDonDTO(maHoaDon, ngayXuat, maTaikhoan, tongTien, trangThai);
				dtoList.Add(dto);
			}

			return dtoList;
		}

        public List<HoaDonDTO> Timkiemtrangthai0(string value)
        {
            List<HoaDonDTO> dtoList = new List<HoaDonDTO>();


            string queryStr = $"select * from hoa_don where ma_hoa_don='{value}' and trang_thai = '0'";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];


                int maHoaDon = int.Parse(datarow.ItemArray[0].ToString());
                DateTime ngayXuat = (DateTime)datarow.ItemArray[1];
                int maTaikhoan = int.Parse(datarow.ItemArray[2].ToString());
                int tongTien = int.Parse(datarow.ItemArray[3].ToString());
                string trangThai = datarow.ItemArray[4].ToString();
                HoaDonDTO dto = new HoaDonDTO(maHoaDon, ngayXuat, maTaikhoan, tongTien, trangThai);
                dtoList.Add(dto);
            }

            return dtoList;
        }
        public List<HoaDonDTO> Timkiem(string value)
        {
            List<HoaDonDTO> dtoList = new List<HoaDonDTO>();


            string queryStr = $"select * from hoa_don where ma_hoa_don='{value}' and trang_thai = '1'";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];

                int maHoaDon = int.Parse(datarow.ItemArray[0].ToString());
                DateTime ngayXuat = (DateTime)datarow.ItemArray[1];
                int maTaikhoan = int.Parse(datarow.ItemArray[2].ToString());
                int tongTien = int.Parse(datarow.ItemArray[3].ToString());
                string trangThai = datarow.ItemArray[4].ToString();
                HoaDonDTO dto = new HoaDonDTO(maHoaDon, ngayXuat, maTaikhoan, tongTien, trangThai);
                dtoList.Add(dto);
            }

            return dtoList;
        }
    }
}
