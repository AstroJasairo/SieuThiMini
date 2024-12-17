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
    public partial class KhoiPhucLoaiSanPham : Form
    {
        private LoaiSanPhamBLL bll = new LoaiSanPhamBLL();
        public KhoiPhucLoaiSanPham()
        {
            InitializeComponent();
        }

        private void KhoiPhucLoaiSanPham_Load(object sender, EventArgs e)
        {
            List<LoaiSanPhamDTO> list = bll.GetListtrangthai0();
            dataGridViewLoaiSanPham.DataSource = list;

            dataGridViewLoaiSanPham.Columns["trangthai"].Visible = false;

            dataGridViewLoaiSanPham.Columns["maLoai"].HeaderText = "Mã loại";
            dataGridViewLoaiSanPham.Columns["maNcc"].HeaderText = "Mã nhà cung cấp";
            dataGridViewLoaiSanPham.Columns["tenLoai"].HeaderText = "Tên loại";

        }


        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (dataGridViewLoaiSanPham.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewLoaiSanPham.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewLoaiSanPham.Rows[selectedRowIndex];
                int maloai = int.Parse(selectedRow.Cells["maLoai"].Value.ToString());

                bll.Restore(maloai);

                MessageBox.Show("Khôi phục loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefesh_Click(null, null);
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 loại sản phẩm để khôi phục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            List<LoaiSanPhamDTO> list = bll.GetListtrangthai0();
            dataGridViewLoaiSanPham.DataSource = list;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            String timkiem = txtTimKiem.Text;
            List<LoaiSanPhamDTO> list = bll.Timkiemtrangthai0(timkiem);
            dataGridViewLoaiSanPham.DataSource = list;
        }
    }
}
