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
    public partial class QuanLyNhaCungCap : Form
    {
        private NhaCungCapBLL bll = new NhaCungCapBLL();
        public QuanLyNhaCungCap()
        {
            InitializeComponent();
        }

        private void QuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            List<NhaCungCapDTO> list = bll.GetList();
            dataGridViewNhaCungCap.DataSource = list;

            dataGridViewNhaCungCap.Columns["tenNhaCungCap"].Width = 300;

            dataGridViewNhaCungCap.Columns["trangThai"].Visible = false;

            dataGridViewNhaCungCap.Columns["maNhaCungCap"].HeaderText = "Mã nhà cung cấp";
            dataGridViewNhaCungCap.Columns["diaChi"].HeaderText = "Địa chỉ";
            dataGridViewNhaCungCap.Columns["tenNhaCungCap"].HeaderText = "Tên nhà cung cấp";

            var datagridviewArgs = new DataGridViewCellEventArgs(0, 0);
            dataGridViewNhaCungCap_CellClick(null, datagridviewArgs);
        }

        private void dataGridViewNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnHuy.Visible = false;
            btnLuu.Visible = false;
            txtTenncc.Enabled = false;
            txtDiachi.Enabled = false;

            if (e.RowIndex == -1) return;

            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewNhaCungCap.Rows[e.RowIndex];

            txtDiachi.Text = Convert.ToString(row.Cells["diaChi"].Value);
            txtMancc.Text = Convert.ToString(row.Cells["maNhaCungCap"].Value);
            txtTenncc.Text = Convert.ToString(row.Cells["tenNhaCungCap"].Value);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (txtMancc.Text == "")
            {
                MessageBox.Show("Hãy chọn 1 sản phẩm để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnHuy.Visible = true;
                btnLuu.Visible = true;
                txtTenncc.Enabled = true;
                txtDiachi.Enabled = true;
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemNhaCungCap tl = new ThemNhaCungCap();
            tl.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMancc.Text != "")
            {
                int mancc = int.Parse(txtMancc.Text.ToString());
                LoaiSanPhamBLL lsp = new LoaiSanPhamBLL();
                List<LoaiSanPhamDTO> list = lsp.getLoaiSPByNCC(mancc);

                if (list.Count > 0) //Nếu danh sách khác rỗng => vẫn tồn tại sản phẩm thuộc về loại này
                {
                    MessageBox.Show("Không xóa được vì vẫn còn loại sản phẩm thuộc về nhà cung cấp này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    bll.Delete(mancc);

                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnRefesh_Click(null, null);
                    var datagridviewArgs = new DataGridViewCellEventArgs(0, 0);
                    dataGridViewNhaCungCap_CellClick(null, datagridviewArgs);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 nhà cung cấp để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            int index = dataGridViewNhaCungCap.SelectedRows[0].Index;
            var datagridviewArgs = new DataGridViewCellEventArgs(0, index);
            dataGridViewNhaCungCap_CellClick(null, datagridviewArgs);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int mancc = int.Parse(txtMancc.Text);
            string tenNcc = txtTenncc.Text;
            string diaChi = txtDiachi.Text;

            if (tenNcc != "" && diaChi != "")
            {
                NhaCungCapDTO nhaCungCap = new NhaCungCapDTO(mancc, tenNcc, diaChi, "1");
                NhaCungCapBLL bLL = new NhaCungCapBLL();
                bLL.Update(nhaCungCap);

                MessageBox.Show("Sửa thông tin nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnHuy_Click(null, null);
                btnRefesh_Click(null, null);
            }
            else
            {
                MessageBox.Show("Không được để trống tên hoặc địa chỉ!", "Thông tin không hợp lệ! Hãy kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            dataGridViewNhaCungCap.DataSource = bll.GetList();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            String timkiem = txtTimKiem.Text;
            List<NhaCungCapDTO> list = bll.timkiem(timkiem);
            dataGridViewNhaCungCap.DataSource = list;
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            KhoiPhucNhaCungCap kp = new KhoiPhucNhaCungCap();
            kp.ShowDialog();
        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTenncc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void txtMancc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
