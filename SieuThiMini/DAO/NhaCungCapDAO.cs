using SieuThiMini.DTO;

using System.Collections.Generic;
using System.Data;


namespace SieuThiMini.DAO
{
    class NhaCungCapDAO: DataConection
    {
		public NhaCungCapDAO() { }
		public  List<NhaCungCapDTO> SelectAll()
		{
			List<NhaCungCapDTO> dtoList = new List<NhaCungCapDTO>();
			

			string queryStr = "select * from nha_cung_cap where trang_thai = 1";
			
			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];

				
				
				int maNcc = int.Parse(datarow.ItemArray[0].ToString());
				string tenNcc = datarow.ItemArray[1].ToString();
				string diaChi = datarow.ItemArray[2].ToString();
				string trangThai = datarow.ItemArray[3].ToString();
                NhaCungCapDTO dto = new NhaCungCapDTO(maNcc,tenNcc,diaChi,trangThai);
				dtoList.Add(dto);
			}

			return dtoList;
		}
        public List<NhaCungCapDTO> SelectAll0()
        {
            List<NhaCungCapDTO> dtoList = new List<NhaCungCapDTO>();


            string queryStr = "select * from nha_cung_cap where trang_thai = 0";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];



                int maNcc = int.Parse(datarow.ItemArray[0].ToString());
                string tenNcc = datarow.ItemArray[1].ToString();
                string diaChi = datarow.ItemArray[2].ToString();
                string trangThai = datarow.ItemArray[3].ToString();
                NhaCungCapDTO dto = new NhaCungCapDTO(maNcc, tenNcc, diaChi, trangThai);
                dtoList.Add(dto);
            }

            return dtoList;
        }
        public int Insert(NhaCungCapDTO target)
		{
			Moketnoi();
			string insertStr = $"insert into nha_cung_cap values ('', '{target.tenNhacungcap}', '{target.diaChi}', '1')";
															
			return DataProvider.Instance.ExecuteNonQuery(insertStr);
		}

		public void Update(NhaCungCapDTO target)
		{
			Moketnoi();
			string updateStr = "update nha_cung_cap set ";
			updateStr += $"ten_ncc = '{target.tenNhacungcap}', ";
			updateStr += $"dia_chi = '{target.diaChi}' ";
			
			updateStr += $"where ma_ncc='{target.maNhacungcap}'";

			DataProvider.Instance.ExecuteNonQuery(updateStr);
		}

		public int Delete(int id)
		{
            Moketnoi();
            string deleteStr = $"update nha_cung_cap set trang_thai='0' where ma_ncc = '{id}'";

            return DataProvider.Instance.ExecuteNonQuery(deleteStr);
        }

        public int Restore(int id)
        {
            Moketnoi();
            string updateStr = $"update nha_cung_cap set trang_thai='1' where ma_ncc = '{id}'";
            return DataProvider.Instance.ExecuteNonQuery(updateStr);
        }
        public List<NhaCungCapDTO> timkiem(string timkiem)
        {
            List<NhaCungCapDTO> dtoList = new List<NhaCungCapDTO>();


            string queryStr = $"select * from nha_cung_cap where ten_ncc like '%{timkiem}%' and trang_thai = '1' or ma_ncc = '{timkiem}' and trang_thai = '1'";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];


                int maNcc = int.Parse(datarow.ItemArray[0].ToString());
                string tenNcc = datarow.ItemArray[1].ToString();
                string diaChi = datarow.ItemArray[2].ToString();
                string trangThai = datarow.ItemArray[3].ToString();
                NhaCungCapDTO dto = new NhaCungCapDTO(maNcc, tenNcc, diaChi, trangThai);
                dtoList.Add(dto);
            }

            return dtoList;
        }
        public List<NhaCungCapDTO> timkiem0(string timkiem)
        {
            List<NhaCungCapDTO> dtoList = new List<NhaCungCapDTO>();


            string queryStr = $"select * from nha_cung_cap where ten_ncc like '%{timkiem}%' and trang_thai = '0' or ma_ncc = '{timkiem}' and trang_thai = '0'";

            DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow datarow = result.Rows[i];


                int maNcc = int.Parse(datarow.ItemArray[0].ToString());
                string tenNcc = datarow.ItemArray[1].ToString();
                string diaChi = datarow.ItemArray[2].ToString();
                string trangThai = datarow.ItemArray[3].ToString();
                NhaCungCapDTO dto = new NhaCungCapDTO(maNcc, tenNcc, diaChi, trangThai);
                dtoList.Add(dto);
            }

            return dtoList;
        }
        public List<NhaCungCapDTO> geNCCByMaNCC(string ma_ncc)
		{
			List<NhaCungCapDTO> dtoList = new List<NhaCungCapDTO>();


			string queryStr = $"select * from nha_cung_cap where ma_ncc='{ma_ncc}'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maNcc = int.Parse(datarow.ItemArray[0].ToString());
				string tenNcc = datarow.ItemArray[1].ToString();
				string diaChi = datarow.ItemArray[2].ToString();
                string trangThai = datarow.ItemArray[3].ToString();
                NhaCungCapDTO dto = new NhaCungCapDTO(maNcc, tenNcc, diaChi, trangThai);
                dtoList.Add(dto);
			}

			return dtoList;
		}

		public List<NhaCungCapDTO> getNCCByNameCC(string ten_ncc)
		{
			List<NhaCungCapDTO> dtoList = new List<NhaCungCapDTO>();


			string queryStr = $"select * from nha_cung_cap where ten_ncc like '%{ten_ncc}%'";

			DataTable result = DataProvider.Instance.ExecuteQuery(queryStr);
			for (int i = 0; i < result.Rows.Count; i++)
			{
				DataRow datarow = result.Rows[i];


				int maNcc = int.Parse(datarow.ItemArray[0].ToString());
				string tenNcc = datarow.ItemArray[1].ToString();
				string diaChi = datarow.ItemArray[2].ToString();
                string trangThai = datarow.ItemArray[3].ToString();
                NhaCungCapDTO dto = new NhaCungCapDTO(maNcc, tenNcc, diaChi, trangThai);
                dtoList.Add(dto);
			}

			return dtoList;
		}
	}
}
