using SieuThiMini.DAO;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.BLL
{
    class NhaCungCapBLL
    {
        private NhaCungCapDAO DAO;
        private List<NhaCungCapDTO> listDTO;


        public NhaCungCapBLL()
        {
            this.DAO = new NhaCungCapDAO();
        }

        public List<NhaCungCapDTO> GetList()
        {
            listDTO = new List<NhaCungCapDTO>();
            listDTO = this.DAO.SelectAll();

            return listDTO;
        }
        public List<NhaCungCapDTO> GetList0()
        {
            listDTO = new List<NhaCungCapDTO>();
            listDTO = this.DAO.SelectAll0();

            return listDTO;
        }
        public int Insert(NhaCungCapDTO dto)
        {
            return this.DAO.Insert(dto);
        }

        public void Update(NhaCungCapDTO dto)
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
        public List<NhaCungCapDTO> timkiem(string timkiem)
        {
            return this.DAO.timkiem(timkiem);
        }
        public List<NhaCungCapDTO> timkiem0(string timkiem)
        {
            return this.DAO.timkiem0(timkiem);
        }
        public NhaCungCapDTO geNCCByMaNCC(string ma_ncc)
        {
            return this.DAO.geNCCByMaNCC(ma_ncc)[0];
        }

        public List<NhaCungCapDTO> getNCCByNameCC(string ten_ncc)
        {
            return this.DAO.getNCCByNameCC(ten_ncc);
        }

       
    }
}
