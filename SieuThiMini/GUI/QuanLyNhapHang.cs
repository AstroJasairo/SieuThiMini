using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using SieuThiMini.BLL;
using SieuThiMini.DAO;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class QuanLyNhapHang : Form
    {
        private DonNhapHangBLL bll = new DonNhapHangBLL();
        int maNV;
        public QuanLyNhapHang(int maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemDonNhapHang themDonNhapHang = new ThemDonNhapHang(maNV);
            themDonNhapHang.ShowDialog();
        }

        private void QuanLyNhapHang_Load(object sender, EventArgs e)
        {
            List<DonNhapHangDTO> list = bll.GetList();
            dataGridViewDonNhapHang.DataSource = list;

            dataGridViewDonNhapHang.Columns["trangThai"].Visible = false;

            dataGridViewDonNhapHang.Columns["maDonNH"].HeaderText = "Mã đơn nhập hàng";
            dataGridViewDonNhapHang.Columns["maNhacungcap"].HeaderText = "Mã nhà cung cấp";
            dataGridViewDonNhapHang.Columns["maNhanvien"].HeaderText = "Mã nhân viên";
            dataGridViewDonNhapHang.Columns["ngayNhap"].HeaderText = "Ngày nhập";
            dataGridViewDonNhapHang.Columns["tongTien"].HeaderText = "Tổng tiền";
        }

        private void dataGridViewDonNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewDonNhapHang.Rows[e.RowIndex];
                int madonnh = Convert.ToInt32(selectedRow.Cells["maDonNH"].Value);
                int mancc = Convert.ToInt32(selectedRow.Cells["maNhacungcap"].Value);
                DateTime ngayNhap = Convert.ToDateTime(selectedRow.Cells["ngayNhap"].Value);
                int maNhanVien = Convert.ToInt32(selectedRow.Cells["maNhanvien"].Value);
                decimal tongTien = Convert.ToDecimal(selectedRow.Cells["tongTien"].Value);

                ChiTietDonNhapHang chiTietDonNhapHang = new ChiTietDonNhapHang(madonnh, mancc, ngayNhap, maNhanVien, tongTien);
                chiTietDonNhapHang.Show();
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            KhoiPhucDonNhapHang kp = new KhoiPhucDonNhapHang();
            kp.ShowDialog();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            // Tạo hộp thoại lựa chọn tệp
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Chọn nơi lưu tệp Excel";
            saveFileDialog.FileName = "exported_data.xlsx"; // Tên mặc định của tệp

            // Hiển thị hộp thoại lựa chọn tệp và kiểm tra xem người dùng đã chọn đường dẫn lưu chưa
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Tạo một tệp Excel mới
                IWorkbook workbook = new XSSFWorkbook();
                ISheet sheet = workbook.CreateSheet("Sheet1");

                // Lấy dữ liệu từ DataGridView
                DataTable dt = new DataTable();

                // Thêm các cột tiêu đề vào DataTable
                foreach (DataGridViewColumn col in dataGridViewDonNhapHang.Columns)
                {
                    dt.Columns.Add(col.HeaderText);
                }

                // Thêm dữ liệu từ DataGridView vào DataTable
                foreach (DataGridViewRow row in dataGridViewDonNhapHang.Rows)
                {
                    DataRow dataRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dataRow[cell.ColumnIndex] = cell.Value;
                    }
                    dt.Rows.Add(dataRow);
                }

                // Thêm dòng tiêu đề vào tệp Excel
                IRow headerRow = sheet.CreateRow(0);
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    headerRow.CreateCell(i).SetCellValue(dt.Columns[i].ColumnName);
                }

                // Ghi dữ liệu từ DataTable vào Excel (bắt đầu từ dòng 2)
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    IRow excelRow = sheet.CreateRow(i + 1); // +1 để bỏ qua dòng tiêu đề

                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        ICell excelCell = excelRow.CreateCell(j);
                        excelCell.SetCellValue(dt.Rows[i][j].ToString());
                    }
                }

                // Lưu tệp Excel vào đĩa tại đường dẫn được chọn
                using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    workbook.Write(stream);
                }

                MessageBox.Show("Dữ liệu đã được xuất ra tệp Excel và lưu tại đường dẫn: " + filePath);
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            List<DonNhapHangDTO> list = bll.GetList();
            dataGridViewDonNhapHang.DataSource = list;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text != "")
            {
                string timkiem = txtTimKiem.Text;
                List<DonNhapHangDTO> list = bll.Timkiem(timkiem);
                dataGridViewDonNhapHang.DataSource = list;
            }
            else
            {
                List<DonNhapHangDTO> list = bll.GetList();
                dataGridViewDonNhapHang.DataSource = list;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewDonNhapHang.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewDonNhapHang.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewDonNhapHang.Rows[selectedRowIndex];
                int mahoadon = int.Parse(selectedRow.Cells["maDonNH"].Value.ToString());

                DonNhapHangBLL bll = new DonNhapHangBLL();
                bll.Delete(mahoadon);

                MessageBox.Show("Xóa đơn nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefesh_Click(null, null);
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 đơn nhập để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
