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
    public partial class KhoiPhucTaiKhoan : Form
    {
        private TaiKhoanBLL bll = new TaiKhoanBLL();
        public KhoiPhucTaiKhoan()
        {
            InitializeComponent();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            String timkiem = txtTimKiem.Text;
            List<TaiKhoanDTO> list = bll.timkiem0(timkiem);
            dataGridViewTaiKhoan.DataSource = list;
        }

        private void KhoiPhucTaiKhoan_Load(object sender, EventArgs e)
        {

            List<TaiKhoanDTO> list = bll.GetList0();
            dataGridViewTaiKhoan.DataSource = list;

            dataGridViewTaiKhoan.Columns["maTaiKhoan"].HeaderText = "Mã tài khoản";
            dataGridViewTaiKhoan.Columns["tenTaiKhoan"].HeaderText = "Tên tài khoản";
            dataGridViewTaiKhoan.Columns["matKhau"].HeaderText = "Mật khẩu";
            dataGridViewTaiKhoan.Columns["maQuyen"].HeaderText = "Phân quyền";
            dataGridViewTaiKhoan.Columns["trangthai"].Visible = false;
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (dataGridViewTaiKhoan.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewTaiKhoan.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewTaiKhoan.Rows[selectedRowIndex];
                int matk = int.Parse(selectedRow.Cells["maTaiKhoan"].Value.ToString());

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
            List<TaiKhoanDTO> list = bll.GetList0();
            dataGridViewTaiKhoan.DataSource = list;
        }
    }
}
