using iTextSharp.text.pdf;
using iTextSharp.text;
using NPOI.SS.Formula.Functions;
using SieuThiMini.BLL;
using SieuThiMini.DAO;
using System;
using System.IO;
using System.Data;

using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace SieuThiMini.GUI
{
    public partial class ChiTietHoaDon : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        private int billID, emloyeeID;
        private decimal total;
        private DateTime date;

        public ChiTietHoaDon(int billID, DateTime date, int emloyeeID, decimal total)
        {
            InitializeComponent();
            this.billID = billID;
            this.date = date;
            this.emloyeeID = emloyeeID;
            this.total = total;

            label2.Text = "Mã hóa đơn: " + billID;
            label3.Text = "Tổng tiền: " + total;
            label4.Text = "Ngày xuất: " + date;
            

            // Gọi hàm để lấy tên nhân viên
            string employeeName = GetEmployeeName(emloyeeID);
            label5.Text = "Nhân viên: " + emloyeeID + " - " + employeeName;

            ChiTietHoaDon_Load(billID);

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

        private void ChiTietHoaDon_Load(int billID)
        {
            dt = dp.ExecuteQuery($"SELECT ma_san_pham, ten_san_pham, so_luong, gia_san_pham, thanh_tien FROM chi_tiet_hoa_don WHERE ma_hoa_don = {billID}");
            dataGridViewCTHD.DataSource = dt;

            // Đặt tiêu đề cột
            dataGridViewCTHD.Columns["ma_san_pham"].HeaderText = "Mã sản phẩm";
            dataGridViewCTHD.Columns["ten_san_pham"].HeaderText = "Tên sản phẩm";
            dataGridViewCTHD.Columns["so_luong"].HeaderText = "Số lượng";
            dataGridViewCTHD.Columns["gia_san_pham"].HeaderText = "Giá sản phẩm";
            dataGridViewCTHD.Columns["thanh_tien"].HeaderText = "Thành tiền";

            // Canh chỉnh dữ liệu trong DataGridView
            dataGridViewCTHD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;   

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
                PdfPCell importIDCell = new PdfPCell(new Phrase("Mã đơn nhập hàng: " + billID, customFont));
                importIDCell.HorizontalAlignment = Element.ALIGN_LEFT; // Căn lề trái
                importIDCell.Border = PdfPCell.NO_BORDER; // Tắt khung
                infoTable.AddCell(importIDCell);


                // Thêm dòng "Ngày nhập" vào bảng
                PdfPCell dateCell = new PdfPCell(new Phrase("Ngày nhập: " + date, customFont));
                dateCell.HorizontalAlignment = Element.ALIGN_RIGHT; // Căn lề trái
                dateCell.Border = PdfPCell.NO_BORDER; // Tắt khung
                infoTable.AddCell(dateCell);

                // Thêm dòng "Tổng tiền" vào bảng
                PdfPCell totalCell = new PdfPCell(new Phrase("Tổng tiền: " + total, customFont));
                totalCell.HorizontalAlignment = Element.ALIGN_LEFT; // Căn lề phải
                totalCell.Border = PdfPCell.NO_BORDER; // Tắt khung
                infoTable.AddCell(totalCell);

                // Thêm dòng "Nhân viên" vào bảng
                string employeeName = GetEmployeeName(emloyeeID);
                PdfPCell employeeCell = new PdfPCell(new Phrase("Nhân viên: " + emloyeeID + " - " + employeeName, customFont));
                employeeCell.HorizontalAlignment = Element.ALIGN_RIGHT; // Căn lề trái
                employeeCell.Border = PdfPCell.NO_BORDER; // Tắt khung
                infoTable.AddCell(employeeCell);



                pdfDocument.Add(infoTable);

                // Tạo bảng PDF
                PdfPTable pdfTable = new PdfPTable(dataGridViewCTHD.Columns.Count);
                pdfTable.WidthPercentage = 100;

                // Đặt độ cao cố định cho các ô trong bảng (ví dụ: 30f)
                float cellHeight = 30f;

                // Thêm tiêu đề cột vào bảng PDF
                for (int i = 0; i < dataGridViewCTHD.Columns.Count; i++)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(dataGridViewCTHD.Columns[i].HeaderText, customFont));
                    headerCell.FixedHeight = cellHeight; // Đặt độ cao cố định
                    pdfTable.AddCell(headerCell);
                }

                // Thêm dòng dữ liệu vào bảng PDF
                for (int row = 0; row < dataGridViewCTHD.Rows.Count; row++)
                {
                    for (int cell = 0; cell < dataGridViewCTHD.Columns.Count; cell++)
                    {
                        if (dataGridViewCTHD[cell, row].Value != null)
                        {
                            PdfPCell dataCell = new PdfPCell(new Phrase(dataGridViewCTHD[cell, row].Value.ToString(), customFont));
                            dataCell.FixedHeight = cellHeight; // Đặt độ cao cố định
                            pdfTable.AddCell(dataCell);
                        }
                    }
                }


                // Thêm bảng PDF vào tài liệu
                pdfDocument.Add(pdfTable);
                pdfDocument.Close();

                MessageBox.Show("Xuất file thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }   
        




    }
}
