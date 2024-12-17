using SieuThiMini.DAO;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini.BLL
{
    class SanPhamBLL
    {
        private SanPhamDAO DAO;
        private List<SanPhamDTO> listDTO;
      

        public SanPhamBLL()
        {
            this.DAO = new SanPhamDAO();
        }

        public List<SanPhamDTO> GetList()
        {
            listDTO = new List<SanPhamDTO>();
            listDTO = this.DAO.SelectAll();

            return listDTO;
        }
        public List<SanPhamDTO> GetListtrangthai0()
        {
            listDTO = new List<SanPhamDTO>();
            listDTO = this.DAO.SelectAlltrangthai0();

            return listDTO;
        }
        public int Insert(SanPhamDTO dto)
        {
            return this.DAO.Insert(dto);
        }

        public void Update(SanPhamDTO dto)
        {
            this.DAO.Update(dto);
        }

        public void UpdateSoLuong(int maSanpham, int soLuong)
        {

            this.DAO.UpdateSoLuong(maSanpham, soLuong);
        }

        public int CheckSoluong(int maSanpham)
        {
            return this.DAO.CheckSoLuong(maSanpham);
        }

        public void Delete(int maSanpham)
        {

            this.DAO.Delete(maSanpham);
        }
        public void Restore(int id)
        {
            this.DAO.Restore(id);
        }
        public List<SanPhamDTO> Timkiem(string value)
        {
            return this.DAO.Timkiem(value);
        }
        public List<SanPhamDTO> Timkiemtrangthai0(string value)
        {
            return this.DAO.Timkiemtrangthai0(value);
        }
        public List<SanPhamDTO> getSPByLoaiSP(int ma_loai)
        {
            return this.DAO.getSPByLoaiSP(ma_loai);
        }

        public SanPhamDTO getSPByMaSp(int ma_san_pham)
		{
            return this.DAO.getSPByMaSp(ma_san_pham)[0];
		}
	}
}
