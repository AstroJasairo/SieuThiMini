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
    public partial class QuanLyTaiKhoan : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        private TaiKhoanBLL bll = new TaiKhoanBLL();
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            dt = dp.ExecuteQuery("SELECT ma_quyen FROM `phan_quyen` ORDER BY `ma_quyen` ASC");
            comboBoxPhanQuyen.DisplayMember = "ma_quyen";
            comboBoxPhanQuyen.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            List<TaiKhoanDTO> list = bll.GetList();
            dataGridViewTaiKhoan.DataSource = list;

            dataGridViewTaiKhoan.Columns["maTaiKhoan"].HeaderText = "Mã tài khoản";
            dataGridViewTaiKhoan.Columns["tenTaiKhoan"].HeaderText = "Tên tài khoản";
            dataGridViewTaiKhoan.Columns["matKhau"].HeaderText = "Mật khẩu";
            dataGridViewTaiKhoan.Columns["maQuyen"].HeaderText = "Phân quyền";
            dataGridViewTaiKhoan.Columns["trangthai"].Visible = false;

            var datagridviewArgs = new DataGridViewCellEventArgs(0, 0);
            CellClick(null, datagridviewArgs);
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTaiKhoan.Enabled = false;
            txtTenTaiKhoan.Enabled = false;
            txtMatKhau.Enabled = false;
            comboBoxPhanQuyen.Enabled = false;
            btnHuy.Visible = false;
            btnLuu.Visible = false;

            if (e.RowIndex == -1) return;

            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewTaiKhoan.Rows[e.RowIndex];

            txtMaTaiKhoan.Text = Convert.ToString(row.Cells["maTaiKhoan"].Value);
            txtTenTaiKhoan.Text = Convert.ToString(row.Cells["tenTaiKhoan"].Value);
            txtMatKhau.Text = Convert.ToString(row.Cells["matKhau"].Value);
            comboBoxPhanQuyen.Text = Convert.ToString(row.Cells["maQuyen"].Value);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan tl = new ThemTaiKhoan();
            tl.ShowDialog();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            dataGridViewTaiKhoan.DataSource = bll.GetList();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaTaiKhoan.Text == "")
            {
                MessageBox.Show("Hãy chọn 1 tài khoản để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtTenTaiKhoan.Enabled = true;
                txtMatKhau.Enabled = true;
                comboBoxPhanQuyen.Enabled = true;
                btnHuy.Visible = true;
                btnLuu.Visible = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            int index = dataGridViewTaiKhoan.SelectedRows[0].Index;
            var datagridviewArgs = new DataGridViewCellEventArgs(0, index);
            CellClick(null, datagridviewArgs);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            String timkiem = txtTimKiem.Text;
            List<TaiKhoanDTO> list = bll.timkiem(timkiem);
            dataGridViewTaiKhoan.DataSource = list;
        }
        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            KhoiPhucLoaiSanPham kp = new KhoiPhucLoaiSanPham();
            kp.ShowDialog();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int matk;
            String tenTaiKhoan = txtTenTaiKhoan.Text;
            String matKhau = txtMatKhau.Text;
            int maQuyen = int.Parse(comboBoxPhanQuyen.Text);
            if (txtMaTaiKhoan.Text != "")
            {
                matk = int.Parse(txtMaTaiKhoan.Text);
            }
            else
            {
                matk = 0;
            }
            if (tenTaiKhoan != "" && matk > 0)
            {
                TaiKhoanDTO taikhoan = new TaiKhoanDTO(matk, tenTaiKhoan, matKhau, maQuyen, "1");
                TaiKhoanBLL bLL = new TaiKhoanBLL();
                bLL.Update(taikhoan);

                MessageBox.Show("Sửa thông tin loại tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnHuy_Click(null, null);
                btnRefesh_Click(null, null);
            }
            else
            {
                MessageBox.Show("Không được bỏ trống bất cứ thông tin nào", "Thông tin không hợp lệ! Hãy kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (txtMaTaiKhoan.Text != "")
            {
                int maTK = int.Parse(txtMaTaiKhoan.Text.ToString());

                //Lấy danh sách Nhân viên thuộc Tài Khoản đang được chọn
                NhanVienBLL bLL = new NhanVienBLL();
                List<NhanVienDTO> list = bLL.getNVBytk(maTK);


                if (list.Count != 0) //Nếu danh sách khác rỗng => vẫn còn nhân viên đang sử dụng tk này
                {
                    MessageBox.Show("Không xóa được vì vẫn còn nhân viên sử dụng tài khoản này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    bll.Delete(maTK);

                    MessageBox.Show("xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnRefesh_Click(null, null);
                    var datagridviewArgs = new DataGridViewCellEventArgs(0, 0);
                    CellClick(null, datagridviewArgs);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 tài khoản để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lb_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefesh_Click_1(object sender, EventArgs e)
        {
            dataGridViewTaiKhoan.DataSource = bll.GetList();
        }

        private void btnKhoiPhuc_Click_1(object sender, EventArgs e)
        {
            KhoiPhucTaiKhoan kp = new KhoiPhucTaiKhoan();
            kp.ShowDialog();
        }
    }
}
