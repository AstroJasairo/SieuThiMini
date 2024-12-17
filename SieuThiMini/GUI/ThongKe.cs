using NPOI.XWPF.UserModel;
using SieuThiMini.BLL;
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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            ThongKeBLL thongKeBLL = new ThongKeBLL();
            tongSanPham.Text = thongKeBLL.TongSoLuongSanPham().ToString();
            tongNhaCC.Text = thongKeBLL.SoLuongNhaCC().ToString();
            tongNhanVien.Text = thongKeBLL.SoLuongNhanVien().ToString();
            tongTaiKhoan.Text = thongKeBLL.SoTaiKhoan().ToString();
            txtNam.Text = DateTime.Now.Year.ToString();
            cbbThang.Text = DateTime.Now.Month.ToString();
            btnThongKe_Click(null, null);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKeBLL thongKeBLL = new ThongKeBLL();
            int namhientai = DateTime.Now.Year;
            int thanghientai = DateTime.Now.Month;
            int selectedMonth;
            int selectedYear;
            DataTable result;


            if (string.IsNullOrEmpty(txtNam.Text.Trim()))
            {
                cbbThang.Text = thanghientai.ToString();
                selectedMonth = int.Parse(cbbThang.Text.Trim());
                txtNam.Text = namhientai.ToString();
                selectedYear = int.Parse(txtNam.Text.Trim());
            }
            else
            {
                
                try
                {
                    selectedYear = int.Parse(txtNam.Text.Trim());
                }
                catch (FormatException)
                {
                    MessageBox.Show("Số không hợp lệ");
                    cbbThang.Text = thanghientai.ToString();
                    selectedMonth = int.Parse(cbbThang.Text.Trim());
                    txtNam.Text = namhientai.ToString();
                    selectedYear = int.Parse(txtNam.Text.Trim());
                }
            }
            if (cbbThang.Text.ToString().Trim() == "None")
            {
                txtNhapHang.Text = thongKeBLL.TongChiPhiNhapHangTheoNam(selectedYear).ToString("#,##0") + " VNĐ";
                txtThuNhap.Text = thongKeBLL.TongDoanhThuHangNam(selectedYear).ToString("#,##0") + " VNĐ";

                txtDonNhap.Text = thongKeBLL.SoDonNhapHangNam(selectedYear).ToString();
                txtHoaDon.Text = thongKeBLL.SoHoaDonNam(selectedYear).ToString();

                result = thongKeBLL.TimMaNhanVienCoTongTienLonNhatTheoNam(selectedYear);


            }
            else
            {
                selectedMonth = int.Parse(cbbThang.SelectedItem.ToString());
                txtNhapHang.Text = thongKeBLL.TongChiPhiNhapHangTheoThangNam(selectedMonth, selectedYear).ToString("#,##0") + " VNĐ";
                txtThuNhap.Text = thongKeBLL.TongDoanhThuHangThangNam(selectedMonth, selectedYear).ToString("#,##0") + " VNĐ";

                txtDonNhap.Text = thongKeBLL.SoDonNhapHangThangNam(selectedMonth, selectedYear).ToString();
                txtHoaDon.Text = thongKeBLL.SoHoaDonThangNam(selectedMonth, selectedYear).ToString();

                result = thongKeBLL.TimMaNhanVienCoTongTienLonNhatTheoThangNam(selectedMonth, selectedYear);


            }
            if (result != null && result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                string maNhanVien = row["ma_nhan_vien"].ToString();
                string tenNhanVien = row["ten_nhan_vien"].ToString();
                string tongTienLonNhat = row["TongTienLonNhat"].ToString();

                // Hiển thị thông tin trên giao diện người dùng (label, textbox, v.v.)
                txtMaNV.Text = maNhanVien;
                txtTenNV.Text = tenNhanVien;

                // Định dạng số tiền
                if (decimal.TryParse(tongTienLonNhat, out decimal tongTienDecimal))
                {
                    txtTienDaBan.Text = tongTienDecimal.ToString("#,##0") + " VNĐ";
                }
                else
                {
                    txtTienDaBan.Text = tongTienLonNhat + " VNĐ";
                }
            }
            else
            {
                txtMaNV.Text = "...";
                txtTenNV.Text = "...";
                txtTienDaBan.Text = "...";
            }
        }
    }
}
