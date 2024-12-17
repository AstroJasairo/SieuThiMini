using SieuThiMini.DAO;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.BLL
{
    class TaiKhoanBLL
    {
        private TaiKhoanDAO DAO;
        private List<TaiKhoanDTO> listDTO;


        public TaiKhoanBLL()
        {
            this.DAO = new TaiKhoanDAO();
        }

        public List<TaiKhoanDTO> GetList()
        {
            listDTO = new List<TaiKhoanDTO>();
            listDTO = this.DAO.SelectAll();

            return listDTO;
        }

        public List<TaiKhoanDTO> GetList0()
        {
            listDTO = new List<TaiKhoanDTO>();
            listDTO = this.DAO.SelectAllTrangThai0();

            return listDTO;
        }

        public int Insert(TaiKhoanDTO dto)
        {
            return this.DAO.Insert(dto);
        }

        public void Update(TaiKhoanDTO dto)
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

        public List<TaiKhoanDTO> getTKByQuyen(string ma_quyen)
        {
            return this.DAO.getTKByQuyen(ma_quyen);
        }

        public TaiKhoanDTO getTKByMaTK(int ma_tai_khoan)
        {
            return this.DAO.getTKByMaTK(ma_tai_khoan)[0];
        }

        public List<TaiKhoanDTO> getTKByNameTK(string ten_tai_khoan)
        {
            return this.DAO.getTKByNameTK(ten_tai_khoan);
        }
        public List<TaiKhoanDTO> timkiem(string timkiem)
        {
            return this.DAO.timkiem(timkiem);
        }
        public List<TaiKhoanDTO> timkiem0(string timkiem)
        {
            return this.DAO.timkiem0(timkiem);
        }
        public TaiKhoanDTO SignIn(string ten_tai_khoan, string password)
        {
            return this.DAO.SignIn(ten_tai_khoan, password)[0];
        }

        public List<TaiKhoanDTO> getTKByNameTT(string trang_thai)
        {
            return this.DAO.getTKByNameTK(trang_thai);
        }
    }
}
