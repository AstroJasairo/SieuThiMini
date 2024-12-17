using SieuThiMini.DAO;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.BLL
{
    class CTDonNhapHangBLL
    {
        private CTDonNhapHangDAO DAO;
        private List<CTDonNhapHangDTO> listDTO;


        public CTDonNhapHangBLL()
        {
            this.DAO = new CTDonNhapHangDAO();
        }

        public List<CTDonNhapHangDTO> GetList()
        {
            listDTO = new List<CTDonNhapHangDTO>();
            listDTO = this.DAO.SelectAll();

            return listDTO;
        }

        public int Insert(CTDonNhapHangDTO dto)
        {
            return this.DAO.Insert(dto);
        }

        public List<CTDonNhapHangDTO> getCTDNHByMaDNH(string ma_don_nh)
        {
            return this.DAO.getCTDNHByMaDNH(ma_don_nh);

      }

       
    }
}
