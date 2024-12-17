using SieuThiMini.DTO;

using System.Collections.Generic;
using System.Data;

namespace SieuThiMini.DAO
{
    class TaiKhoanDAO: DataConection
    {
		public TaiKhoanDAO() { }
		public  List<TaiKhoanDTO> SelectAll()
		{
			List<TaiKhoanDTO> dtoList = new List<TaiKhoanDTO>();
			

			string queryStr = "select * from tai_khoan where ma_tai_khoan != 0 and trang_thai = 1";
			
			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];

				
				int maTaiKhoan = int.Parse(datarow.ItemArray[0].ToString());
				string tenTaiKhoan = datarow.ItemArray[1].ToString();
				string matKhau = datarow.ItemArray[2].ToString();
				int maQuyen = int.Parse(datarow.ItemArray[3].ToString());
				string trangthai = datarow.ItemArray[4].ToString();

				TaiKhoanDTO dto = new TaiKhoanDTO(maTaiKhoan, tenTaiKhoan, matKhau, maQuyen, trangthai);
				dtoList.Add(dto);
			}

			return dtoList;
		}
        public List<TaiKhoanDTO> SelectAllTrangThai0()
        {
            List<TaiKhoanDTO> dtoList = new List<TaiKhoanDTO>();


            string queryStr = "select * from tai_khoan where ma_tai_khoan != 0 and trang_thai = 0";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];


                int maTaiKhoan = int.Parse(datarow.ItemArray[0].ToString());
                string tenTaiKhoan = datarow.ItemArray[1].ToString();
                string matKhau = datarow.ItemArray[2].ToString();
                int maQuyen = int.Parse(datarow.ItemArray[3].ToString());
                string trangthai = datarow.ItemArray[4].ToString();

                TaiKhoanDTO dto = new TaiKhoanDTO(maTaiKhoan, tenTaiKhoan, matKhau, maQuyen, trangthai);
                dtoList.Add(dto);
            }

            return dtoList;
        }

        public int Insert(TaiKhoanDTO target)
		{
			Moketnoi();
			string insertStr = $"insert into tai_khoan values ('', '{target.tenTaikhoan}', '{target.matKhau}', " + $"'{target.maQuyen}', '1')";
			return DataProvider.Instance.ExecuteNonQuery(insertStr);
		}

		public void Update(TaiKhoanDTO target)
		{
			Moketnoi();
			string updateStr = "update tai_khoan set ";
			updateStr += $"ten_tai_khoan = '{target.tenTaikhoan}', ";
			updateStr += $"mat_khau = '{target.matKhau}', ";
			updateStr += $"phan_quyen = '{target.maQuyen}', ";
			updateStr += $"trang_thai = '{target.trangThai}' ";
			updateStr += $"where ma_tai_khoan='{target.maTaikhoan}'";

			DataProvider.Instance.ExecuteNonQuery(updateStr);
		}

		public int Delete(int id)
		{
			Moketnoi();
			string deleteStr = $"update tai_khoan set trang_thai='0' where ma_tai_khoan = '{id}'";

			return DataProvider.Instance.ExecuteNonQuery(deleteStr);
		}

        public int Restore(int id)
        {
            Moketnoi();
            string updateStr = $"update tai_khoan set trang_thai='1' where ma_tai_khoan = '{id}'";
            return DataProvider.Instance.ExecuteNonQuery(updateStr);
        }

        public List<TaiKhoanDTO> getTKByMaTK(int ma_tai_khoan) { 
			List<TaiKhoanDTO> dtoList = new List<TaiKhoanDTO>();


			string queryStr = $"select * from tai_khoan where ma_tai_khoan='{ma_tai_khoan}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maTaiKhoan = int.Parse(datarow.ItemArray[0].ToString());
				string tenTaiKhoan = datarow.ItemArray[1].ToString();
				string matKhau = datarow.ItemArray[2].ToString();
				int maQuyen = int.Parse(datarow.ItemArray[3].ToString());
				string trangthai = datarow.ItemArray[4].ToString();

				TaiKhoanDTO dto = new TaiKhoanDTO(maTaiKhoan, tenTaiKhoan, matKhau, maQuyen, trangthai);
				dtoList.Add(dto);
			}

			return dtoList;
		}

		public List<TaiKhoanDTO> getTKByQuyen(string ma_quyen)
		{
			List<TaiKhoanDTO> dtoList = new List<TaiKhoanDTO>();


			string queryStr = $"select * from tai_khoan where phan_quyen='{ma_quyen}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maTaiKhoan = int.Parse(datarow.ItemArray[0].ToString());
				string tenTaiKhoan = datarow.ItemArray[1].ToString();
				string matKhau = datarow.ItemArray[2].ToString();
				int maQuyen = int.Parse(datarow.ItemArray[3].ToString());
				string trangthai = datarow.ItemArray[4].ToString();

				TaiKhoanDTO dto = new TaiKhoanDTO(maTaiKhoan, tenTaiKhoan, matKhau, maQuyen, trangthai);
				dtoList.Add(dto);
			}

			return dtoList;
		}
        public List<TaiKhoanDTO> timkiem(string timkiem)
        {
            List<TaiKhoanDTO> dtoList = new List<TaiKhoanDTO>();


            string queryStr = $"select * from tai_khoan where ten_tai_khoan like '%{timkiem}%' and trang_thai = 1 and ma_tai_khoan != 0 or ma_tai_khoan='{timkiem}' and trang_thai = 1 and ma_tai_khoan != 0";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];


                int maTaiKhoan = int.Parse(datarow.ItemArray[0].ToString());
                string tenTaiKhoan = datarow.ItemArray[1].ToString();
                string matKhau = datarow.ItemArray[2].ToString();
                int maQuyen = int.Parse(datarow.ItemArray[3].ToString());
                string trangthai = datarow.ItemArray[4].ToString();

                TaiKhoanDTO dto = new TaiKhoanDTO(maTaiKhoan, tenTaiKhoan, matKhau, maQuyen, trangthai);
                dtoList.Add(dto);
            }

            return dtoList;
        }
        public List<TaiKhoanDTO> timkiem0(string timkiem)
        {
            List<TaiKhoanDTO> dtoList = new List<TaiKhoanDTO>();


            string queryStr = $"select * from tai_khoan where ten_tai_khoan like '%{timkiem}%' and trang_thai = 0 and ma_tai_khoan != 0 or ma_tai_khoan='{timkiem}' and trang_thai = 0 and ma_tai_khoan != 0";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];


                int maTaiKhoan = int.Parse(datarow.ItemArray[0].ToString());
                string tenTaiKhoan = datarow.ItemArray[1].ToString();
                string matKhau = datarow.ItemArray[2].ToString();
                int maQuyen = int.Parse(datarow.ItemArray[3].ToString());
                string trangthai = datarow.ItemArray[4].ToString();

                TaiKhoanDTO dto = new TaiKhoanDTO(maTaiKhoan, tenTaiKhoan, matKhau, maQuyen, trangthai);
                dtoList.Add(dto);
            }

            return dtoList;
        }
        public List<TaiKhoanDTO> getTKByNameTK(string ten_tai_khoan)
		{
			List<TaiKhoanDTO> dtoList = new List<TaiKhoanDTO>();


			string queryStr = $"select * from tai_khoan where ten_tai_khoan like '%{ten_tai_khoan}%'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maTaiKhoan = int.Parse(datarow.ItemArray[0].ToString());
				string tenTaiKhoan = datarow.ItemArray[1].ToString();
				string matKhau = datarow.ItemArray[2].ToString();
				int maQuyen = int.Parse(datarow.ItemArray[3].ToString());
				string trangthai = datarow.ItemArray[4].ToString();

				TaiKhoanDTO dto = new TaiKhoanDTO(maTaiKhoan, tenTaiKhoan, matKhau, maQuyen, trangthai);
				dtoList.Add(dto);
			}

			return dtoList;
		}

		public List<TaiKhoanDTO> SignIn(string ten_tai_khoan,string password)
		{
			List<TaiKhoanDTO> dtoList = new List<TaiKhoanDTO>();


			string queryStr = $"select * from tai_khoan where ten_tai_khoan='{ten_tai_khoan}' and mat_khau='{password}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maTaiKhoan = int.Parse(datarow.ItemArray[0].ToString());
				string tenTaiKhoan = datarow.ItemArray[1].ToString();
				string matKhau = datarow.ItemArray[2].ToString();
				int maQuyen = int.Parse(datarow.ItemArray[3].ToString());
				string trangthai = datarow.ItemArray[4].ToString();

				TaiKhoanDTO dto = new TaiKhoanDTO(maTaiKhoan, tenTaiKhoan, matKhau, maQuyen, trangthai);
				dtoList.Add(dto);
			}

			return dtoList;
		}

	}
}
