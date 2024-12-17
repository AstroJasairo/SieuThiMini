using SieuThiMini.DAO;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.BLL
{
    class PhanQuyenBLL
    {
        private PhanQuyenDAO DAO;
        private List<PhanQuyenDTO> listDTO;


        public PhanQuyenBLL()
        {
            this.DAO = new PhanQuyenDAO();
        }

        public List<PhanQuyenDTO> GetList()
        {
            listDTO = new List<PhanQuyenDTO>();
            listDTO = this.DAO.SelectAll();

            return listDTO;
        }

        public int Insert(PhanQuyenDTO dto)
        {
            return this.DAO.Insert(dto);
        }

        public void Update(PhanQuyenDTO dto)
        {
            this.DAO.Update(dto);
        }

        public int Delete(string dtoId)
        {
            return this.DAO.Delete(dtoId);
        }
        public List<PhanQuyenDTO> getPQByMaPQ(string ma_phan_quyen)
        {
            return this.DAO.getPQByMaPQ(ma_phan_quyen);
        }

       

        public PhanQuyenDTO getPQByNamePQ(string ten_quyen)
        {
            return this.DAO.getPQByNamePQ(ten_quyen)[0];
        }

      
    }
}
