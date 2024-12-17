using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace SieuThiMini.DAO
{
    class NhanVienDAO: DataConection
    {
		public NhanVienDAO() { }
		public List<NhanVienDTO> SelectAll()
		{
			List<NhanVienDTO> dtoList = new List<NhanVienDTO>();


			string queryStr = "select nhan_vien.*,tai_khoan.phan_quyen from nhan_vien,tai_khoan where nhan_vien.tai_khoan=tai_khoan.ma_tai_khoan and nhan_vien.trang_thai!=0"; //and tai_khoan.phan_quyen!=0";
			
			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];

				
				int maNhanVien = int.Parse(datarow.ItemArray[0].ToString());
				string tenNhanVien = datarow.ItemArray[1].ToString();
				DateTime ngaySinh = (DateTime)datarow.ItemArray[2];
				
				
				string sdt = datarow.ItemArray[3].ToString();
				string mail = datarow.ItemArray[4].ToString();
				int maTaikhoan=int.Parse(datarow.ItemArray[5].ToString());
                string trangThai = datarow.ItemArray[6].ToString();
                NhanVienDTO dto = new NhanVienDTO(maNhanVien, tenNhanVien, ngaySinh, sdt, mail, maTaikhoan,trangThai);
				dtoList.Add(dto);
			}

			return dtoList;
		}

		public int Insert(NhanVienDTO target)
		{
			
			Moketnoi();
			string ngaySinh = target.ngaySinh.ToString("yyyy-MM-dd");
			string insertStr = $"insert into nhan_vien values ('', '{target.tenNhanvien}', '{ngaySinh}', " +
															$"'{target.sdt}', '{target.mail}','{target.maTaikhoan}','1')";
			return DataProvider.Instance.ExecuteNonQuery(insertStr);
		}

		public void Update(NhanVienDTO target)
		{
			Moketnoi();
			string ngaySinh = target.ngaySinh.ToString("yyyy-MM-dd");

			string updateStr = "update nhan_vien set ";
			updateStr += $"ten_nhan_vien = '{target.tenNhanvien}', ";
			updateStr += $"ngay_sinh = '{ngaySinh}', ";
			updateStr += $"sdt = '{target.sdt}', ";
			updateStr += $"mail = '{target.mail}', ";
			updateStr += $"tai_khoan = '{target.maTaikhoan}' ";
			updateStr += $"where ma_nhan_vien='{target.maNhanvien}'";

			DataProvider.Instance.ExecuteNonQuery(updateStr);
		}
        public int Delete(int id)
        {
            Moketnoi();
            string deleteStr = $"update nhan_vien set trang_thai='0' where ma_nhan_vien = '{id}'";

            return DataProvider.Instance.ExecuteNonQuery(deleteStr);
        }

        public int Restore(int id)
        {
            Moketnoi();
            string updateStr = $"update nhan_vien set trang_thai='1' where ma_nhan_vien = '{id}'";
            return DataProvider.Instance.ExecuteNonQuery(updateStr);
        }

		public List<NhanVienDTO> Timkiem(string value)
		{
			List<NhanVienDTO> dtoList = new List<NhanVienDTO>();

			string queryStr = $"select * from nhan_vien where ma_nhan_vien = '{value}' and trang_thai = 1 or ten_nhan_vien like '%{value}%' and trang_thai = 1";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);

			for(int i=0; i< result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];

				int maNhanvien = int.Parse(datarow.ItemArray[0].ToString());
                string tenNhanvien = datarow.ItemArray[1].ToString();
                DateTime ngaySinh = DateTime.Parse(datarow.ItemArray[2].ToString());
                string sdt = datarow.ItemArray[3].ToString();
                string mail = datarow.ItemArray[4].ToString();
                int taiKhoan = int.Parse(datarow.ItemArray[5].ToString());
				string trangThai = datarow.ItemArray[6].ToString();

				NhanVienDTO dto = new NhanVienDTO(maNhanvien, tenNhanvien, ngaySinh, sdt, mail, taiKhoan, trangThai);

				dtoList.Add(dto);
            }	
			return dtoList;
        }

        public List<NhanVienDTO> getNVByMaNV(int ma_nhan_vien)
		{
			List<NhanVienDTO> dtoList = new List<NhanVienDTO>();


			string queryStr = $"select * from nhan_vien where ma_nhan_vien='{ma_nhan_vien}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maNhanVien = int.Parse(datarow.ItemArray[0].ToString());
				string tenNhanVien = datarow.ItemArray[1].ToString();
				DateTime ngaySinh = (DateTime)datarow.ItemArray[2];


				string sdt = datarow.ItemArray[3].ToString();
				string mail = datarow.ItemArray[4].ToString();
				int maTaikhoan = int.Parse(datarow.ItemArray[5].ToString());
                string trangThai = datarow.ItemArray[6].ToString();
                NhanVienDTO dto = new NhanVienDTO(maNhanVien, tenNhanVien, ngaySinh, sdt, mail, maTaikhoan, trangThai);
                dtoList.Add(dto);
			}

			return dtoList;
		}

		public List<NhanVienDTO> getNVByNameNV(string ten_nhan_vien)
		{
			List<NhanVienDTO> dtoList = new List<NhanVienDTO>();


			string queryStr = $"select * from nhan_vien where ten_nhan_vien like '%{ten_nhan_vien}%'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maNhanVien = int.Parse(datarow.ItemArray[0].ToString());
				string tenNhanVien = datarow.ItemArray[1].ToString();
				DateTime ngaySinh = (DateTime)datarow.ItemArray[2];


				string sdt = datarow.ItemArray[3].ToString();
				string mail = datarow.ItemArray[4].ToString();
				int maTaikhoan = int.Parse(datarow.ItemArray[5].ToString());
                string trangThai = datarow.ItemArray[6].ToString();
                NhanVienDTO dto = new NhanVienDTO(maNhanVien, tenNhanVien, ngaySinh, sdt, mail, maTaikhoan, trangThai);
                dtoList.Add(dto);
			}

			return dtoList;
		}

		public List<NhanVienDTO> getNVByMaTK(int ma_tai_khoan)
		{
			List<NhanVienDTO> dtoList = new List<NhanVienDTO>();


			string queryStr = $"select * from nhan_vien where tai_khoan='{ma_tai_khoan}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maNhanVien = int.Parse(datarow.ItemArray[0].ToString());
				string tenNhanVien = datarow.ItemArray[1].ToString();
				DateTime ngaySinh = (DateTime)datarow.ItemArray[2];


				string sdt = datarow.ItemArray[3].ToString();
				string mail = datarow.ItemArray[4].ToString();
				int maTaikhoan = int.Parse(datarow.ItemArray[5].ToString());
                string trangThai = datarow.ItemArray[6].ToString();
                NhanVienDTO dto = new NhanVienDTO(maNhanVien, tenNhanVien, ngaySinh, sdt, mail, maTaikhoan, trangThai);
                dtoList.Add(dto);
			}

			return dtoList;
		}

		public List<NhanVienDTO> SelectAlltrangthai0()
		{
			List<NhanVienDTO> dtoList = new List<NhanVienDTO>();

            string queryStr = "select * from nhan_vien where trang_thai = 0";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];


                int maNhanVien = int.Parse(datarow.ItemArray[0].ToString());
                string tenNhanVien = datarow.ItemArray[1].ToString();
                DateTime ngaySinh = (DateTime)datarow.ItemArray[2];


                string sdt = datarow.ItemArray[3].ToString();
                string mail = datarow.ItemArray[4].ToString();
                int maTaikhoan = int.Parse(datarow.ItemArray[5].ToString());
                string trangThai = datarow.ItemArray[6].ToString();
                NhanVienDTO dto = new NhanVienDTO(maNhanVien, tenNhanVien, ngaySinh, sdt, mail, maTaikhoan, trangThai);
                dtoList.Add(dto);
            }

            return dtoList;
        }

        public List<NhanVienDTO> Timkiemtrangthai0(string value)
        {
            List<NhanVienDTO> dtoList = new List<NhanVienDTO>();


            string queryStr = $"select * from nhan_vien where ma_nhan_vien='{value}' and trang_thai = 0 or ten_nhan_vien like '%{value}%' and trang_thai = 0";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];


                int maNhanVien = int.Parse(datarow.ItemArray[0].ToString());
                string tenNhanVien = datarow.ItemArray[1].ToString();
                DateTime ngaySinh = (DateTime)datarow.ItemArray[2];


                string sdt = datarow.ItemArray[3].ToString();
                string mail = datarow.ItemArray[4].ToString();
                int maTaikhoan = int.Parse(datarow.ItemArray[5].ToString());
                string trangThai = datarow.ItemArray[6].ToString();
                NhanVienDTO dto = new NhanVienDTO(maNhanVien, tenNhanVien, ngaySinh, sdt, mail, maTaikhoan, trangThai);
                dtoList.Add(dto);
            }

            return dtoList;
        }



    }
}
