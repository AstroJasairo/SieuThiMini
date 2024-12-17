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
    public partial class QuanLyHoaDon : Form
    {
        private HoaDonBLL bll = new HoaDonBLL();
        public QuanLyHoaDon()
        {
            InitializeComponent();
        }


        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            KhoiPhucHoaDon kp = new KhoiPhucHoaDon();
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
                foreach (DataGridViewColumn col in dataGridViewHoaDon.Columns)
                {
                    dt.Columns.Add(col.HeaderText);
                }

                // Thêm dữ liệu từ DataGridView vào DataTable
                foreach (DataGridViewRow row in dataGridViewHoaDon.Rows)
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

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            List<HoaDonDTO> list = bll.GetList();
            dataGridViewHoaDon.DataSource = list;

            dataGridViewHoaDon.Columns["trangThai"].Visible = false;

            dataGridViewHoaDon.Columns["maHoadon"].HeaderText = "Mã hóa đơn";
            dataGridViewHoaDon.Columns["maNhanvien"].HeaderText = "Mã nhân viên";
            dataGridViewHoaDon.Columns["ngayXuat"].HeaderText = "Ngày xuât";
            dataGridViewHoaDon.Columns["tongTien"].HeaderText = "Tổng tiền";
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            List<HoaDonDTO> list = bll.GetList();
            dataGridViewHoaDon.DataSource = list;
        }

        private void dataGridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewHoaDon.Rows[e.RowIndex];
                int mahd = Convert.ToInt32(selectedRow.Cells["maHoaDon"].Value);
                DateTime ngayxuat = Convert.ToDateTime(selectedRow.Cells["ngayXuat"].Value);
                int maNhanVien = Convert.ToInt32(selectedRow.Cells["maNhanvien"].Value);
                decimal tongTien = Convert.ToDecimal(selectedRow.Cells["tongTien"].Value);

                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(mahd, ngayxuat, maNhanVien, tongTien);
                chiTietHoaDon.Show();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewHoaDon.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewHoaDon.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewHoaDon.Rows[selectedRowIndex];
                int mahoadon = int.Parse(selectedRow.Cells["maHoadon"].Value.ToString());

                HoaDonBLL bll = new HoaDonBLL();
                bll.Delete(mahoadon);

                MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRefesh_Click(null, null);
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 hóa đơn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text != "")
            {
                string timkiem = txtTimKiem.Text;
                List<HoaDonDTO> list = bll.Timkiem(timkiem);
                dataGridViewHoaDon.DataSource = list;
            }
            else
            {
                List<HoaDonDTO> list = bll.GetList();
                dataGridViewHoaDon.DataSource = list;
            }
        }
    }
}
