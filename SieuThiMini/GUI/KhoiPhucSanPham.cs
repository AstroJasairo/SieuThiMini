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
    public partial class KhoiPhucSanPham : Form
    {
        private SanPhamBLL bll = new SanPhamBLL();
        public KhoiPhucSanPham()
        {
            InitializeComponent();
        }

        private void KhoiPhucSanPham_Load(object sender, EventArgs e)
        {
            //Gọi Hàm GetList trong BLL để lấy danh sách
            List<SanPhamDTO> list = bll.GetListtrangthai0();

            //Đổ danh sách vào data của Datagridview
            dataGridViewProducts.DataSource = list;

            //Chỉnh giao diện cho bảng danh sách
            dataGridViewProducts.Columns["trangthai"].Visible = false;

            dataGridViewProducts.Columns["maSanpham"].HeaderText = "Mã sản phẩm";
            dataGridViewProducts.Columns["tenSanpham"].HeaderText = "Tên sản phẩm";
            dataGridViewProducts.Columns["soLuong"].HeaderText = "Số lượng";
            dataGridViewProducts.Columns["gia"].HeaderText = "Giá";
            dataGridViewProducts.Columns["gianhap"].HeaderText = "Giá nhập";
            dataGridViewProducts.Columns["maLoai"].HeaderText = "Mã loại";

            dataGridViewProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewProducts.Columns["tenSanpham"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            List<SanPhamDTO> list = bll.GetListtrangthai0();
            dataGridViewProducts.DataSource = list;
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewProducts.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewProducts.Rows[selectedRowIndex];
                int masp = int.Parse(selectedRow.Cells["maSanpham"].Value.ToString());

                bll.Restore(masp);

                MessageBox.Show("Khôi phục sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefesh_Click(null, null);
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 sản phẩm để khôi phục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            String timkiem = txtTimKiem.Text;
            List<SanPhamDTO> list = bll.Timkiemtrangthai0(timkiem);
            dataGridViewProducts.DataSource = list;
        }
    }
}
