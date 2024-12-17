using SieuThiMini.DAO;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.BLL
{
    class CTHoaDonBLL
    {
        private CTHoaDonDAO DAO;
        private List<CTHoaDonDTO> listDTO;


        public CTHoaDonBLL()
        {
            this.DAO = new CTHoaDonDAO();
        }

        public List<CTHoaDonDTO> GetList()
        {
            listDTO = new List<CTHoaDonDTO>();
            listDTO = this.DAO.SelectAll();

            return listDTO;
        }

        public int Insert(CTHoaDonDTO dto)
        {
            return this.DAO.Insert(dto);
        }

        public List<CTHoaDonDTO> getCTHoaDonByMaHD(string ma_hoa_don)
        {
            return this.DAO.getCTHoaDonByMaHD(ma_hoa_don);
        }

       
    }
}
