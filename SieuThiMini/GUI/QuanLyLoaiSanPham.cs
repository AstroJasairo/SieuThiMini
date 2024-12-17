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
    public partial class QuanLyLoaiSanPham : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        private LoaiSanPhamBLL bll = new LoaiSanPhamBLL();
        public QuanLyLoaiSanPham()
        {
            InitializeComponent();
            dt = dp.ExecuteQuery("SELECT ma_ncc FROM `nha_cung_cap` ORDER BY `ma_ncc` ASC");
            cbbMaNcc.DisplayMember = "ma_ncc";
            cbbMaNcc.DataSource = dt;
        }

        private void QuanLyLoaiSanPham_Load(object sender, EventArgs e)
        {
            List<LoaiSanPhamDTO> list = bll.GetList();
            dataGridViewLoaiSanPham.DataSource = list;

            dataGridViewLoaiSanPham.Columns["trangThai"].Visible = false;

            dataGridViewLoaiSanPham.Columns["maLoai"].HeaderText = "Mã loại";
            dataGridViewLoaiSanPham.Columns["maNcc"].HeaderText = "Mã nhà cung cấp";
            dataGridViewLoaiSanPham.Columns["tenLoai"].HeaderText = "Tên loại";

            var datagridviewArgs = new DataGridViewCellEventArgs(0, 0);
            CellClick(null, datagridviewArgs);
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoaiSp.Enabled = false;
            txtTenLoaiSp.Enabled = false;
            cbbMaNcc.Enabled = false;
            btnHuy.Visible = false;
            btnLuu.Visible = false;

            if (e.RowIndex == -1) return;

            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewLoaiSanPham.Rows[e.RowIndex];

            txtMaLoaiSp.Text = Convert.ToString(row.Cells["maLoai"].Value);
            cbbMaNcc.Text = Convert.ToString(row.Cells["maNcc"].Value);
            txtTenLoaiSp.Text = Convert.ToString(row.Cells["tenLoai"].Value);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemLoaiSanPham tl = new ThemLoaiSanPham();
            tl.ShowDialog();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            dataGridViewLoaiSanPham.DataSource = bll.GetList();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtMaLoaiSp.Text == "")
            {
                MessageBox.Show("Hãy chọn 1 sản phẩm để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtTenLoaiSp.Enabled = true;
                cbbMaNcc.Enabled = true;
                btnHuy.Visible = true;
                btnLuu.Visible = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            int index = dataGridViewLoaiSanPham.SelectedRows[0].Index;
            var datagridviewArgs = new DataGridViewCellEventArgs(0, index);
            CellClick(null, datagridviewArgs);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            String timkiem = txtTimKiem.Text;
            List<LoaiSanPhamDTO> list = bll.Timkiem(timkiem);
            dataGridViewLoaiSanPham.DataSource = list;
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            KhoiPhucLoaiSanPham kp = new KhoiPhucLoaiSanPham();
            kp.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiSp.Text != "")
            {
                int maloai = int.Parse(txtMaLoaiSp.Text.ToString());

                //Lấy danh sách SẢN PHẨM thuộc loại sản phẩm đang được chọn
                SanPhamBLL bLL = new SanPhamBLL();
                List<SanPhamDTO> list = bLL.getSPByLoaiSP(maloai);
                
                
                if (list.Count != 0) //Nếu danh sách khác rỗng => vẫn tồn tại sản phẩm thuộc về loại này
                {
                    MessageBox.Show("Không xóa được vì vẫn còn sản phẩm thuộc về loại sản phẩm này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    bll.Delete(maloai);

                    MessageBox.Show("xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnRefesh_Click(null, null);
                    var datagridviewArgs = new DataGridViewCellEventArgs(0, 0);
                    CellClick(null, datagridviewArgs);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 loại sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int mancc = int.Parse(cbbMaNcc.Text); ;
            String tenloai = txtTenLoaiSp.Text;
            int maloai = int.Parse(txtMaLoaiSp.Text);

            if (tenloai != "")
            {
                LoaiSanPhamDTO loaisanpham = new LoaiSanPhamDTO(maloai, tenloai, mancc, "1");
                LoaiSanPhamBLL bLL = new LoaiSanPhamBLL();
                bLL.Update(loaisanpham);

                MessageBox.Show("Sửa thông tin loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnHuy_Click(null, null);
                btnRefesh_Click(null, null);
            }
            else
            {
                MessageBox.Show("Không được bỏ trống tên loại sản phẩm", "Thông tin không hợp lệ! Hãy kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
