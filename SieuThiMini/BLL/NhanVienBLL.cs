using SieuThiMini.DAO;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.BLL
{
    class NhanVienBLL
    {
        private NhanVienDAO DAO;
        private List<NhanVienDTO> listDTO;
      

        public NhanVienBLL()
        {
            this.DAO = new NhanVienDAO();
        }

        public List<NhanVienDTO> GetList()
        {
            listDTO = new List<NhanVienDTO>();
            listDTO = this.DAO.SelectAll();

            return listDTO;
        }

        public int Insert(NhanVienDTO dto)
        {
            return this.DAO.Insert(dto);
        }

        public void Update(NhanVienDTO dto)
        {
            this.DAO.Update(dto);
        }

        public int Delete(int dtoId)
        {
            return this.DAO.Delete(dtoId);
        }

        public void Restore(int id)
        {
            this.DAO.Restore(id);
        }

        public List<NhanVienDTO> Timkiem(string value)
        {
            return this.DAO.Timkiem(value);
        }

        public List<NhanVienDTO> getNVByMaNV(int ma_nhan_vien)
        {
            return this.DAO.getNVByMaNV(ma_nhan_vien);
		}
        public NhanVienDTO getNVByManv(int ma_nhan_vien)
        {
            return this.DAO.getNVByMaNV(ma_nhan_vien)[0];
        }
        public NhanVienDTO getNVByTK(int ma_tai_khoan)
        {
            return this.DAO.getNVByMaTK(ma_tai_khoan)[0];
        }
        public List<NhanVienDTO> getNVBytk(int ma_tai_khoan)
        {
            return this.DAO.getNVByMaTK(ma_tai_khoan);
        }
        public List<NhanVienDTO> getNVByNameNV(string ten_nhan_vien)
        {
            return this.DAO.getNVByNameNV(ten_nhan_vien);
		}

        public List<NhanVienDTO> GetListtrangthai0()
        {
            listDTO = new List<NhanVienDTO>();
            listDTO = this.DAO.SelectAlltrangthai0();

            return listDTO;
        }

        public List<NhanVienDTO> Timkiemtrangthai0(string value)
        {
            return this.DAO.Timkiemtrangthai0(value);
        }


    }
}
