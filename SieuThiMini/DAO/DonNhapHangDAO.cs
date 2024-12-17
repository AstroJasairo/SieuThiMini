using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace SieuThiMini.DAO
{
    class DonNhapHangDAO: DataConection
    {
		public DonNhapHangDAO() { }
		public List<DonNhapHangDTO> SelectAll()
		{
			List<DonNhapHangDTO> dtoList = new List<DonNhapHangDTO>();
			

			string queryStr = "select * from don_nhap_hang where trang_thai='1'";
			
			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];

				
				int maDonNhap= int.Parse(datarow.ItemArray[0].ToString());
				int maNcc = int.Parse(datarow.ItemArray[1].ToString());
				int maNv = int.Parse(datarow.ItemArray[2].ToString());
				DateTime ngayDat = (DateTime)datarow.ItemArray[3];		
				int tongTienNhap= int.Parse(datarow.ItemArray[4].ToString());
				String trangThai = datarow.ItemArray[5].ToString();
				DonNhapHangDTO dto = new DonNhapHangDTO(maDonNhap, maNcc, maNv, ngayDat, tongTienNhap,trangThai);
				dtoList.Add(dto);
			}

			return dtoList;
		}

        public List<DonNhapHangDTO> SelectAlltrangthai0()
        {
            List<DonNhapHangDTO> dtoList = new List<DonNhapHangDTO>();


            string queryStr = "select * from don_nhap_hang where trang_thai = 0";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];

                int maDonNhap = int.Parse(datarow.ItemArray[0].ToString());
                int maNcc = int.Parse(datarow.ItemArray[1].ToString());
                int maNv = int.Parse(datarow.ItemArray[2].ToString());
                DateTime ngayDat = (DateTime)datarow.ItemArray[3];
                int tongTienNhap = int.Parse(datarow.ItemArray[4].ToString());
                String trangThai = datarow.ItemArray[5].ToString();
                DonNhapHangDTO dto = new DonNhapHangDTO(maDonNhap, maNcc, maNv, ngayDat, tongTienNhap, trangThai);
                dtoList.Add(dto);
            }

            return dtoList;
        }

        public int Insert(DonNhapHangDTO target)
		{
			string ngayNhap = target.ngayNhap.ToString("yyyy-MM-dd");
			Moketnoi();
			string insertStr = $"insert into don_nhap_hang values ('', '{target.maNhacungcap}', '{target.maNhanvien}' ,'{ngayNhap}', " +
															$"'{target.tongTien}','1')";

			return DataProvider.Instance.ExecuteNonQuery(insertStr);
		}

		public int Delete(int id)
		{
			Moketnoi();
			string deleteStr = $"update don_nhap_hang set trang_thai='0' where ma_don_nh = '{id}'";

			return DataProvider.Instance.ExecuteNonQuery(deleteStr);
		}
		public List<DonNhapHangDTO> getDNHByMaDNH(string ma_don_nh)
		{
			List<DonNhapHangDTO> dtoList = new List<DonNhapHangDTO>();


			string queryStr = $"select * from don_nhap_hang where ma_don_nh='{ma_don_nh}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


                int maDonNhap = int.Parse(datarow.ItemArray[0].ToString());
                int maNcc = int.Parse(datarow.ItemArray[1].ToString());
                int maNv = int.Parse(datarow.ItemArray[2].ToString());
                DateTime ngayDat = (DateTime)datarow.ItemArray[3];
                int tongTienNhap = int.Parse(datarow.ItemArray[4].ToString());
                String trangThai = datarow.ItemArray[5].ToString();
                DonNhapHangDTO dto = new DonNhapHangDTO(maDonNhap, maNcc, maNv, ngayDat, tongTienNhap, trangThai);
                dtoList.Add(dto);
			}

			return dtoList;
		}
        public int Restore(string madonnhap)
        {
            Moketnoi();
            string updateStr = $"update don_nhap_hang set trang_thai='1' where ma_don_nh = '{madonnhap}'";
            return DataProvider.Instance.ExecuteNonQuery(updateStr);
        }

        public List<DonNhapHangDTO> Timkiemtrangthai0(string value)
        {
            List<DonNhapHangDTO> dtoList = new List<DonNhapHangDTO>();


            string queryStr = $"select * from don_nhap_hang where ma_don_nh='{value}' and trang_thai = 0 ";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];


                int maDonNhap = int.Parse(datarow.ItemArray[0].ToString());
                int maNcc = int.Parse(datarow.ItemArray[1].ToString());
                int maNv = int.Parse(datarow.ItemArray[2].ToString());
                DateTime ngayDat = (DateTime)datarow.ItemArray[3];
                int tongTienNhap = int.Parse(datarow.ItemArray[4].ToString());
                String trangThai = datarow.ItemArray[5].ToString();
                DonNhapHangDTO dto = new DonNhapHangDTO(maDonNhap, maNcc, maNv, ngayDat, tongTienNhap, trangThai);
                dtoList.Add(dto);
            }

            return dtoList;
        }

        public List<DonNhapHangDTO> Timkiem(string value)
        {
            List<DonNhapHangDTO> dtoList = new List<DonNhapHangDTO>();


            string queryStr = $"select * from don_nhap_hang where ma_don_nh='{value}' and trang_thai = 1 ";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];



                int maDonNhap = int.Parse(datarow.ItemArray[0].ToString());
                int maNcc = int.Parse(datarow.ItemArray[1].ToString());
                int maNv = int.Parse(datarow.ItemArray[2].ToString());
                DateTime ngayDat = (DateTime)datarow.ItemArray[3];
                int tongTienNhap = int.Parse(datarow.ItemArray[4].ToString());
                String trangThai = datarow.ItemArray[5].ToString();
                DonNhapHangDTO dto = new DonNhapHangDTO(maDonNhap, maNcc, maNv, ngayDat, tongTienNhap, trangThai);
                dtoList.Add(dto);
            }

            return dtoList;
        }
    }
}
