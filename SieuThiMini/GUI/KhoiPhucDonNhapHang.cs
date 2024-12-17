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
    public partial class KhoiPhucDonNhapHang : Form
    {
        private DonNhapHangBLL bll = new DonNhapHangBLL();
        public KhoiPhucDonNhapHang()
        {
            InitializeComponent();
        }

        private void KhoiPhucDonNhapHang_Load(object sender, EventArgs e)
        {
            List<DonNhapHangDTO> list = bll.GetListtrangthai0();
            dataGridViewDonNH.DataSource = list;

            dataGridViewDonNH.Columns["trangthai"].Visible = false;

            dataGridViewDonNH.Columns["maDonNH"].HeaderText = "Mã đơn nhập hàng";
            dataGridViewDonNH.Columns["maNhacungcap"].HeaderText = "Mã nhà cung cấp";
            dataGridViewDonNH.Columns["maNhanvien"].HeaderText = "Mã nhân viên";
            dataGridViewDonNH.Columns["ngayNhap"].HeaderText = "Ngày nhập";
            dataGridViewDonNH.Columns["tongTien"].HeaderText = "Tổng tiền";


        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            List<DonNhapHangDTO> list = bll.GetListtrangthai0();
            dataGridViewDonNH.DataSource = list;
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (dataGridViewDonNH.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewDonNH.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewDonNH.Rows[selectedRowIndex];
                String mahoadon = selectedRow.Cells["maDonNH"].Value.ToString();

                DonNhapHangBLL bll = new DonNhapHangBLL();
                bll.Update(mahoadon);

                MessageBox.Show("Khôi phục đơn nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefesh_Click(null, null);
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 đơn nhập để khôi phục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text != "")
            {
                string timkiem = txtTimKiem.Text;
                List<DonNhapHangDTO> list = bll.Timkiemtrangthai0(timkiem);
                dataGridViewDonNH.DataSource = list;
            }
            else
            {
                List<DonNhapHangDTO> list = bll.GetListtrangthai0();
                dataGridViewDonNH.DataSource = list;
            }
        }
    }
}
