using SieuThiMini.DAO;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.BLL
{
    class DonNhapHangBLL
    {
        private DonNhapHangDAO DAO;
        private List<DonNhapHangDTO> listDTO;


        public DonNhapHangBLL()
        {
            this.DAO = new DonNhapHangDAO();
        }

        public List<DonNhapHangDTO> GetList()
        {
            listDTO = new List<DonNhapHangDTO>();
            listDTO = this.DAO.SelectAll();

            return listDTO;
        }
        public List<DonNhapHangDTO> GetListtrangthai0()
        {
            listDTO = new List<DonNhapHangDTO>();
            listDTO = this.DAO.SelectAlltrangthai0();

            return listDTO;
        }

        public int Insert(DonNhapHangDTO dto)
        {
            return this.DAO.Insert(dto);
        }

        public List<DonNhapHangDTO> Timkiemtrangthai0(string value)
        {
            return this.DAO.Timkiemtrangthai0(value);
        }

        public int Delete(int dtoId)
        {
            return this.DAO.Delete(dtoId);
        }

        public int Update(string mahoadon)
        {
            return this.DAO.Restore(mahoadon);
        }

        public DonNhapHangDTO getDNHByMaDNH(string ma_don_nh)
        {
            return this.DAO.getDNHByMaDNH(ma_don_nh)[0];

        }
        public List<DonNhapHangDTO> Timkiem(string value)
        {
            return this.DAO.Timkiem(value);
        }
    }
}
