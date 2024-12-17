using SieuThiMini.BLL;
using SieuThiMini.DAO;
using System;

using System.Data;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

using System.Windows.Forms;


using iTextSharpFont = iTextSharp.text.Font;
using iTextSharpBaseFont = iTextSharp.text.pdf.BaseFont;





namespace SieuThiMini.GUI
{
    public partial class ChiTietDonNhapHang : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        private int importID, mancc, emloyeeID;
        private decimal total;
        private DateTime date;


        public ChiTietDonNhapHang(int importID,int mancc, DateTime date, int emloyeeID, decimal total)
        {
            InitializeComponent();
            this.importID = importID;
            this.mancc = mancc;
            this.emloyeeID = emloyeeID;
            this.total = total;
            this.date = date;

            label6.Text = "Mã đơn nhập hàng: " + importID;
            label5.Text = "Mã nhà cung cấp: " + mancc;
            label3.Text = "Ngày nhập: " + date;
            label2.Text = "Tổng tiền: " + total;

            // Gọi hàm để lấy tên nhân viên
            string employeeName = GetEmployeeName(emloyeeID);
            label4.Text = "Nhân viên: " + emloyeeID+ " - " + employeeName;

        }
        private string GetEmployeeName(int employeeID)
        {
            // Thực hiện truy vấn để lấy tên nhân viên từ mã nhân viên
            string query = $"SELECT ten_nhan_vien FROM nhan_vien WHERE ma_nhan_vien = {employeeID}";

            DataTable resultTable = dp.ExecuteQuery(query);

            if (resultTable.Rows.Count > 0)
            {
                // Lấy tên nhân viên từ cột "ten_nhan_vien" của dòng đầu tiên (nếu có)
                string employeeName = resultTable.Rows[0]["ten_nhan_vien"].ToString();
                return employeeName;
            }

            // Trong trường hợp không tìm thấy tên nhân viên, trả về một giá trị mặc định hoặc chuỗi trống tùy theo nhu cầu của bạn.
            return "Không xác định";
        }

        private void ChiTietDonNhapHang_Load(object sender, EventArgs e)
        {
            dt = dp.ExecuteQuery($"SELECT ma_don_nh, ma_san_pham, ten_san_pham, so_luong, gia, thanh_tien FROM chi_tiet_don_nhap_hang WHERE ma_don_nh = {importID}");
            dataGridViewImportOders.DataSource = dt;

            // Đặt tiêu đề cột
            dataGridViewImportOders.Columns["ma_don_nh"].HeaderText = "Mã đơn nhập hàng";
            dataGridViewImportOders.Columns["ma_san_pham"].HeaderText = "Mã sản phẩm";
            dataGridViewImportOders.Columns["ten_san_pham"].HeaderText = "Tên sản phẩm";
            dataGridViewImportOders.Columns["so_luong"].HeaderText = "Số lượng";
            dataGridViewImportOders.Columns["thanh_tien"].HeaderText = "Thành tiền";
            dataGridViewImportOders.Columns["gia"].HeaderText = "Giá";

            // Canh chỉnh dữ liệu trong DataGridView
            dataGridViewImportOders.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files|*.pdf";
            saveFileDialog.Title = "Save to PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDocument, new FileStream(filePath, FileMode.Create));

                pdfDocument.Open();

                // Sử dụng font Unicode hỗ trợ tiếng Việt
                BaseFont bf = BaseFont.CreateFont("D:\\Downloads\\SieuThiMini\\SieuThiMini\\Resources\\arial-unicode-ms.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font customFont = new iTextSharp.text.Font(bf, 12);


                // Tiêu đề
                pdfDocument.Add(new Paragraph("Chi tiết đơn nhập hàng", new iTextSharp.text.Font(bf, 16)) { Alignment = Element.ALIGN_CENTER });

                PdfPTable infoTable = new PdfPTable(2);
                infoTable.WidthPercentage = 100;
                infoTable.SpacingBefore = 10f; // Cách lề trên
                infoTable.SpacingAfter = 10f;  // Cách lề dưới

                // Thêm dòng "Mã đơn nhập hàng" vào bảng
                PdfPCell importIDCell = new PdfPCell(new Phrase("Mã đơn nhập hàng: " + importID, customFont));
                importIDCell.HorizontalAlignment = Element.ALIGN_LEFT; // Căn lề trái
                importIDCell.Border = PdfPCell.NO_BORDER; // Tắt khung
                infoTable.AddCell(importIDCell);

                // Thêm dòng "Mã nhà cung cấp" vào bảng
                PdfPCell manccCell = new PdfPCell(new Phrase("Mã nhà cung cấp: " + mancc, customFont));
                manccCell.HorizontalAlignment = Element.ALIGN_RIGHT; // Căn lề phải
                manccCell.Border = PdfPCell.NO_BORDER; // Tắt khung
                infoTable.AddCell(manccCell);

                // Thêm dòng "Ngày nhập" vào bảng
                PdfPCell dateCell = new PdfPCell(new Phrase("Ngày nhập: " + date, customFont));
                dateCell.HorizontalAlignment = Element.ALIGN_LEFT; // Căn lề trái
                dateCell.Border = PdfPCell.NO_BORDER; // Tắt khung
                infoTable.AddCell(dateCell);

                // Thêm dòng "Tổng tiền" vào bảng
                PdfPCell totalCell = new PdfPCell(new Phrase("Tổng tiền: " + total, customFont));
                totalCell.HorizontalAlignment = Element.ALIGN_RIGHT; // Căn lề phải
                totalCell.Border = PdfPCell.NO_BORDER; // Tắt khung
                infoTable.AddCell(totalCell);

                // Thêm dòng "Nhân viên" vào bảng
                string employeeName = GetEmployeeName(emloyeeID);
                PdfPCell employeeCell = new PdfPCell(new Phrase("Nhân viên: " + emloyeeID + " - " + employeeName, customFont));
                employeeCell.HorizontalAlignment = Element.ALIGN_LEFT; // Căn lề trái
                employeeCell.Border = PdfPCell.NO_BORDER; // Tắt khung
                infoTable.AddCell(employeeCell);

                // Thêm một ô trống bên phải
                PdfPCell emptyCell = new PdfPCell();
                emptyCell.Border = PdfPCell.NO_BORDER; // Tắt khung
                infoTable.AddCell(emptyCell);
                pdfDocument.Add(infoTable);

                // Tạo bảng PDF
                PdfPTable pdfTable = new PdfPTable(dataGridViewImportOders.Columns.Count);
                pdfTable.WidthPercentage = 100;

                // Đặt độ cao cố định cho các ô trong bảng (ví dụ: 30f)
                float cellHeight = 30f;

                // Thêm tiêu đề cột vào bảng PDF
                for (int i = 0; i < dataGridViewImportOders.Columns.Count; i++)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(dataGridViewImportOders.Columns[i].HeaderText, customFont));
                    headerCell.FixedHeight = cellHeight; // Đặt độ cao cố định
                    pdfTable.AddCell(headerCell);
                }

                // Thêm dòng dữ liệu vào bảng PDF
                for (int row = 0; row < dataGridViewImportOders.Rows.Count; row++)
                {
                    for (int cell = 0; cell < dataGridViewImportOders.Columns.Count; cell++)
                    {
                        if (dataGridViewImportOders[cell, row].Value != null)
                        {
                            PdfPCell dataCell = new PdfPCell(new Phrase(dataGridViewImportOders[cell, row].Value.ToString(), customFont));
                            dataCell.FixedHeight = cellHeight; // Đặt độ cao cố định
                            pdfTable.AddCell(dataCell);
                        }
                    }
                }


                // Thêm bảng PDF vào tài liệu
                pdfDocument.Add(pdfTable);
                pdfDocument.Close();

                MessageBox.Show("Xuất file thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
