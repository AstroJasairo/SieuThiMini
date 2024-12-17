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
    public partial class KhoiPhucNhaCungCap : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        NhaCungCapBLL bll = new NhaCungCapBLL();
        public KhoiPhucNhaCungCap()
        {
            InitializeComponent();
        }

        private void KhoiPhucNhaCungCap_Load(object sender, EventArgs e)
        {
            List<NhaCungCapDTO> list = bll.GetList0();
            dataGridViewSuppliers.DataSource = list;

            dataGridViewSuppliers.Columns["trangThai"].Visible = false;

            dataGridViewSuppliers.Columns["maNhaCungCap"].HeaderText = "Mã nhà cung cấp";
            dataGridViewSuppliers.Columns["diaChi"].HeaderText = "Địa chỉ";
            dataGridViewSuppliers.Columns["tenNhaCungCap"].HeaderText = "Tên nhà cung cấp";

        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            List<NhaCungCapDTO> list = bll.GetList0();
            dataGridViewSuppliers.DataSource = list;
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewSuppliers.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewSuppliers.Rows[selectedRowIndex];
                int mancc = int.Parse(selectedRow.Cells["maNhaCungCap"].Value.ToString());

                bll.Restore(mancc);

                MessageBox.Show("Khôi phục nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefesh_Click(null, null);
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 nhà cung cấp để khôi phục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string timkiem = txtTimKiem.Text;
            List<NhaCungCapDTO> list = bll.timkiem0(timkiem);
            dataGridViewSuppliers.DataSource = list;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
