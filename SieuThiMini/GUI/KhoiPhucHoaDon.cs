using SieuThiMini.BLL;
using SieuThiMini.DAO;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class KhoiPhucHoaDon : Form
    {
        private HoaDonBLL bll = new HoaDonBLL();

        public KhoiPhucHoaDon()
        {
            InitializeComponent();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (dataGridViewHoaDon.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewHoaDon.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewHoaDon.Rows[selectedRowIndex];
                String mahoadon = selectedRow.Cells["maHoadon"].Value.ToString();

                HoaDonBLL bll = new HoaDonBLL();
                bll.Update(mahoadon);

                MessageBox.Show("Khôi phục hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefesh_Click(null, null);
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 hóa đơn để khôi phục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KhoiPhucHoaDon_Load(object sender, EventArgs e)
        {
            List<HoaDonDTO> list = bll.GetListDeleted();
            dataGridViewHoaDon.DataSource = list;

            dataGridViewHoaDon.Columns["trangThai"].Visible = false;

            dataGridViewHoaDon.Columns["maHoadon"].HeaderText = "Mã hóa đơn";
            dataGridViewHoaDon.Columns["maNhanvien"].HeaderText = "Mã nhân viên";
            dataGridViewHoaDon.Columns["ngayXuat"].HeaderText = "Ngày xuât";
            dataGridViewHoaDon.Columns["tongTien"].HeaderText = "Tổng tiền";
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            List<HoaDonDTO> list = bll.GetListDeleted();
            dataGridViewHoaDon.DataSource = list;
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            if(txtTimKiem.Text != "")
            {
                string timkiem = txtTimKiem.Text;
                List<HoaDonDTO> list = bll.Timkiemtrangthai0(timkiem);
                dataGridViewHoaDon.DataSource = list;
            }
            else
            {
                List<HoaDonDTO> list = bll.GetListDeleted();
                dataGridViewHoaDon.DataSource = list;
            }
        }
    }
}
