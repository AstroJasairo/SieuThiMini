using SieuThiMini.BLL;
using SieuThiMini.DAO;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class QuanLySanPham : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        private SanPhamBLL bll = new SanPhamBLL();
        public QuanLySanPham()
        {
            InitializeComponent();
            dt = dp.ExecuteQuery("SELECT ma_ncc FROM `nha_cung_cap` ORDER BY `ma_ncc` ASC");
            cbbMaLoai.DisplayMember = "ma_ncc";
            cbbMaLoai.DataSource = dt;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            //Gọi Hàm GetList trong BLL để lấy danh sách
            List<SanPhamDTO> list = bll.GetList();

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

            //Chọn dòng đầu tiên
            var datagridviewArgs = new DataGridViewCellEventArgs(0, 0);
            dataGridViewProducts_CellClick(null, datagridviewArgs);
        }
        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nút hủy
            txtTenSP.Enabled = false;
            cbbMaLoai.Enabled = false;
            txtGia.Enabled = false;
            txtGiaNhap.Enabled = false;

            btnLuu.Visible = false;
            btnHuy.Visible = false;

            //Tránh lỗi khi chọn ô ngoài content như row header hay column header
            if (e.RowIndex == -1) return;

            //Row đang được chọn
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewProducts.Rows[e.RowIndex];

            //Đổ dữ liệu vào controls
            txtMaSP.Text = Convert.ToString(row.Cells["maSanpham"].Value);
            txtTenSP.Text = Convert.ToString(row.Cells["tenSanpham"].Value);
            txtSoluong.Text = Convert.ToString(row.Cells["soLuong"].Value);
            txtGia.Text = Convert.ToString(row.Cells["gia"].Value);
            txtGiaNhap.Text = Convert.ToString(row.Cells["gianhap"].Value);
            cbbMaLoai.Text = Convert.ToString(row.Cells["maLoai"].Value);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemSanPham them = new ThemSanPham();
            them.ShowDialog();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            KhoiPhucSanPham khoiphuc = new KhoiPhucSanPham();
            khoiphuc.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int masp = int.Parse(txtMaSP.Text);
            int soluong = int.Parse(txtSoluong.Text);
            if (soluong == 0)
            {
                SanPhamBLL bll = new SanPhamBLL();
                bll.Delete(masp);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefesh_Click(null, null);
            }
            else
            {
                MessageBox.Show("Không được xóa sản phẩm có số lượng lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            List<SanPhamDTO> list = bll.GetList();
            dataGridViewProducts.DataSource = list;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Hãy chọn 1 sản phẩm để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtTenSP.Enabled = true;
                cbbMaLoai.Enabled = true;
                txtGia.Enabled = true;
                txtGiaNhap.Enabled = true;

                btnLuu.Visible = true;
                btnHuy.Visible = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int maloai = int.Parse(cbbMaLoai.Text);
            int masp = int.Parse(txtMaSP.Text);
            String tensp = txtTenSP.Text;
            int soluong = int.Parse(txtSoluong.Text);
            int gia, gianhap;
            try
            {
                gia = int.Parse(txtGia.Text);
                gianhap = int.Parse(txtGiaNhap.Text);
                if (txtGia.Text != "" && txtGiaNhap.Text != "" && tensp != "" && gia > 0 && gianhap > 0)
                {
                    SanPhamDTO sanpham = new SanPhamDTO(masp, tensp, soluong, gia, gianhap, maloai, "1");
                    bll.Update(sanpham);
                    MessageBox.Show("Sửa thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnHuy_Click(null, null);
                    btnRefesh_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Các hạn chế gồm:\n \n1. Không được bỏ trống bất cứ thông tin nào \n2. Giá bán và giá nhập phải lớn hơn 0 và là số", "Thông tin không hợp lệ, hãy kiểm tra lại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Các hạn chế gồm:\n \n1. Không được bỏ trống bất cứ thông tin nào \n2. Giá bán và giá nhập phải lớn hơn 0 và là số", "Thông tin không hợp lệ, hãy kiểm tra lại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Nhấn dòng đang được chọn để hủy (các thao tác hủy đã được code sẵn trong event cellclick)
            int index = dataGridViewProducts.SelectedRows[0].Index;
            var datagridviewArgs = new DataGridViewCellEventArgs(0, index);
            dataGridViewProducts_CellClick(null, datagridviewArgs);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            String timkiem = txtTimKiem.Text;
            List<SanPhamDTO> list = bll.Timkiem(timkiem);
            dataGridViewProducts.DataSource = list;
        }
    }
}
