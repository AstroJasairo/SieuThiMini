using SieuThiMini.DTO;

using System.Collections.Generic;
using System.Data;


namespace SieuThiMini.DAO
{
    class LoaiSanPhamDAO: DataConection
    {
		public LoaiSanPhamDAO() { }
		public  List<LoaiSanPhamDTO> SelectAll()
		{
			List<LoaiSanPhamDTO> dtoList = new List<LoaiSanPhamDTO>();
			

			string queryStr = "select * from loai_san_pham where trang_thai = 1";
			
			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];

				
				
				int maLoai = int.Parse(datarow.ItemArray[0].ToString());
				string tenLoai = datarow.ItemArray[1].ToString();
				int maNcc= int.Parse(datarow.ItemArray[2].ToString());
                string trangThai = datarow.ItemArray[3].ToString();
                LoaiSanPhamDTO dto = new LoaiSanPhamDTO(maLoai,tenLoai,maNcc,trangThai);
				dtoList.Add(dto);
			}

			return dtoList;
		}
        public List<LoaiSanPhamDTO> SelectAlltrangthai0()
        {
            List<LoaiSanPhamDTO> dtoList = new List<LoaiSanPhamDTO>();


            string queryStr = "select * from loai_san_pham where trang_thai = 0";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];



                int maLoai = int.Parse(datarow.ItemArray[0].ToString());
                string tenLoai = datarow.ItemArray[1].ToString();
                int maNcc = int.Parse(datarow.ItemArray[2].ToString());
                string trangThai = datarow.ItemArray[3].ToString();
                LoaiSanPhamDTO dto = new LoaiSanPhamDTO(maLoai, tenLoai, maNcc, trangThai);
                dtoList.Add(dto);
            }

            return dtoList;
        }
        public int Insert(LoaiSanPhamDTO target)
		{
			Moketnoi();
			string insertStr = $"insert into loai_san_pham values ('', '{target.tenLoai}','{target.maNcc}','1') ";
															
			return DataProvider.Instance.ExecuteNonQuery(insertStr);
		}

		public void Update(LoaiSanPhamDTO target)
		{
			Moketnoi();
			string updateStr = "update loai_san_pham set ";
			updateStr += $"ten_loai = '{target.tenLoai}', ";
			updateStr += $"ma_ncc = '{target.maNcc}' ";
			updateStr += $"where ma_loai='{target.maLoai}'";


			DataProvider.Instance.ExecuteNonQuery(updateStr);
		}

		public int Delete(int id)
		{
            Moketnoi();
            string deleteStr = $"update loai_san_pham set trang_thai='0' where ma_loai = '{id}'";

            return DataProvider.Instance.ExecuteNonQuery(deleteStr);
        }

        public int Restore(int id)
        {
            Moketnoi();
            string updateStr = $"update loai_san_pham set trang_thai='1' where ma_loai = '{id}'";
            return DataProvider.Instance.ExecuteNonQuery(updateStr);
        }

        public List<LoaiSanPhamDTO> Timkiem(string value)
        {
            List<LoaiSanPhamDTO> dtoList = new List<LoaiSanPhamDTO>();


            string queryStr = $"select * from loai_san_pham where ma_loai='{value}' and trang_thai = 1 or ten_loai like '%{value}%' and trang_thai = 1";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];


                int maLoai = int.Parse(datarow.ItemArray[0].ToString());
                string tenLoai = datarow.ItemArray[1].ToString();
                int maNcc = int.Parse(datarow.ItemArray[2].ToString());
                string trangThai = datarow.ItemArray[3].ToString();
                LoaiSanPhamDTO dto = new LoaiSanPhamDTO(maLoai, tenLoai, maNcc, trangThai);
                dtoList.Add(dto);
            }

            return dtoList;
        }
        public List<LoaiSanPhamDTO> Timkiemtrangthai0(string value)
        {
            List<LoaiSanPhamDTO> dtoList = new List<LoaiSanPhamDTO>();


            string queryStr = $"select * from loai_san_pham where ma_loai='{value}' and trang_thai = 0 or ten_loai like '%{value}%' and trang_thai = 0";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];


                int maLoai = int.Parse(datarow.ItemArray[0].ToString());
                string tenLoai = datarow.ItemArray[1].ToString();
                int maNcc = int.Parse(datarow.ItemArray[2].ToString());
                string trangThai = datarow.ItemArray[3].ToString();
                LoaiSanPhamDTO dto = new LoaiSanPhamDTO(maLoai, tenLoai, maNcc, trangThai);
                dtoList.Add(dto);
            }

            return dtoList;
        }
        public List<LoaiSanPhamDTO> getLoaiSPByNCC(int ma_ncc)
		{
			List<LoaiSanPhamDTO> dtoList = new List<LoaiSanPhamDTO>();


			string queryStr = $"select * from loai_san_pham where ma_ncc='{ma_ncc}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maLoai = int.Parse(datarow.ItemArray[0].ToString());
				string tenLoai = datarow.ItemArray[1].ToString();
				int maNcc = int.Parse(datarow.ItemArray[2].ToString());
                string trangThai = datarow.ItemArray[3].ToString();
                LoaiSanPhamDTO dto = new LoaiSanPhamDTO(maLoai, tenLoai, maNcc, trangThai);
                dtoList.Add(dto);
			}

			return dtoList;
		}

		public List<LoaiSanPhamDTO> getLoaiSPByMaLoai(int ma_loai)
		{
			List<LoaiSanPhamDTO> dtoList = new List<LoaiSanPhamDTO>();


			string queryStr = $"select * from loai_san_pham where ma_loai='{ma_loai}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maLoai = int.Parse(datarow.ItemArray[0].ToString());
				string tenLoai = datarow.ItemArray[1].ToString();
				int maNcc = int.Parse(datarow.ItemArray[2].ToString());
                string trangThai = datarow.ItemArray[3].ToString();
                LoaiSanPhamDTO dto = new LoaiSanPhamDTO(maLoai, tenLoai, maNcc, trangThai);
                dtoList.Add(dto);
			}

			return dtoList;
		}

	}
}
