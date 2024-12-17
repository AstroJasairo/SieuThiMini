using SieuThiMini.BLL;
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
    public partial class KhoiPhucNhanVien : Form
    {
        private NhanVienBLL bll = new NhanVienBLL();
        public KhoiPhucNhanVien()
        {
            InitializeComponent();
        }

        private void KhoiPhucNhanVien_Load(object sender, EventArgs e)
        {
            List<NhanVienDTO> list = bll.GetListtrangthai0();

            dataGridViewNhanVien.DataSource = list;

            dataGridViewNhanVien.Columns["trangthai"].Visible = false;

            dataGridViewNhanVien.Columns["maNhanvien"].HeaderText = "Mã nhân viên";
            dataGridViewNhanVien.Columns["tenNhanvien"].HeaderText = "Tên nhân viên";
            dataGridViewNhanVien.Columns["ngaySinh"].HeaderText = "Ngày sinh";
            dataGridViewNhanVien.Columns["sdt"].HeaderText = "Số điện thoại";
            dataGridViewNhanVien.Columns["mail"].HeaderText = "Mail";
            dataGridViewNhanVien.Columns["maTaikhoan"].HeaderText = "Mã tài khoản";
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (dataGridViewNhanVien.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewNhanVien.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewNhanVien.Rows[selectedRowIndex];
                int matk = int.Parse(selectedRow.Cells["maNhanvien"].Value.ToString());

                bll.Restore(matk);

                MessageBox.Show("Khôi phục nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefesh_Click(null, null);
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 nhân viên để khôi phục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            List<NhanVienDTO> list = bll.GetListtrangthai0();
            dataGridViewNhanVien.DataSource = list;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            String timkiem = txtTimKiem.Text;
            List<NhanVienDTO> list = bll.Timkiemtrangthai0(timkiem);
            dataGridViewNhanVien.DataSource = list;

        }

        private void dataGridViewNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
