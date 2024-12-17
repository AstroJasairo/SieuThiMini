using iTextSharp.text.pdf;
using iTextSharp.text;
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
    public partial class BanHang : Form
    {
        int manv;
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        private SanPhamBLL bll = new SanPhamBLL();


        public BanHang(int maNV)
        {
            InitializeComponent();
            this.manv = maNV;
            // Thiết lập giá trị mặc định cho numericUpDown
            numericUpDown1.Value = 1;
            dt = dp.ExecuteQuery("SELECT ma_loai FROM `loai_san_pham` ORDER BY `ma_loai` ASC");
            cbloaisp.DisplayMember = "ma_loai";
            cbloaisp.DataSource = dt;
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            //Gọi Hàm GetList trong BLL để lấy danh sách
            List<SanPhamDTO> list = bll.GetList();

            //Đổ danh sách vào data của Datagridview
            dataGridViewProducts.DataSource = list;

            //Chỉnh giao diện cho bảng danh sách
            dataGridViewProducts.Columns["trangthai"].Visible = false;
            dataGridViewProducts.Columns["gianhap"].Visible = false;
            dataGridViewProducts.Columns["maLoai"].Visible = false;

            dataGridViewProducts.Columns["maSanpham"].Width = 100;
            dataGridViewProducts.Columns["tenSanpham"].Width = 250;

            dataGridViewProducts.Columns["maSanpham"].HeaderText = "Mã sản phẩm";
            dataGridViewProducts.Columns["tenSanpham"].HeaderText = "Tên sản phẩm";
            dataGridViewProducts.Columns["soLuong"].HeaderText = "Số lượng";
            dataGridViewProducts.Columns["gia"].HeaderText = "Giá";

            dataGridViewProducts.Columns["maSanpham"].ReadOnly = true;
            dataGridViewProducts.Columns["tenSanpham"].ReadOnly = true;
            dataGridViewProducts.Columns["gia"].ReadOnly = true;
            dataGridViewDonHang.Columns["thanh_tien"].ReadOnly = true;

            dataGridViewProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewProducts.Columns["tenSanpham"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Định dạng cột thành tiền và đơn giá
            dataGridViewDonHang.Columns["gia"].DefaultCellStyle.Format = "N0";
            dataGridViewDonHang.Columns["thanh_tien"].DefaultCellStyle.Format = "N0";
           
        }


        private void cbloaisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbloaisp.SelectedIndex != -1)
            {
                int maloai = int.Parse(cbloaisp.Text);

                // Thực hiện câu truy vấn để lấy danh sách mã sản phẩm thuộc nhà cung cấp
                string query = "SELECT san_pham.ma_san_pham, san_pham.ten_san_pham, san_pham.gia, so_luong FROM san_pham " +
                    
                    $"WHERE ma_loai = {maloai}";
                dt = dp.ExecuteQuery(query);

                // Xóa tất cả cột hiện tại trong DataGridView
                dataGridViewProducts.Columns.Clear();

                // Tạo cột Mã sản phẩm
                DataGridViewTextBoxColumn colMaSanPham = new DataGridViewTextBoxColumn();
                colMaSanPham.HeaderText = "Mã Sản Phẩm";
                colMaSanPham.DataPropertyName = "ma_san_pham"; // DataPropertyName
                colMaSanPham.Name = "MaSanPham";
                colMaSanPham.ReadOnly = true;
                dataGridViewProducts.Columns.Add(colMaSanPham);

                // Tạo cột Tên sản phẩm
                DataGridViewTextBoxColumn colTenSanPham = new DataGridViewTextBoxColumn();
                colTenSanPham.HeaderText = "Tên Sản Phẩm";
                colTenSanPham.DataPropertyName = "ten_san_pham"; // DataPropertyName
                colTenSanPham.Name = "TenSanPham";
                colTenSanPham.ReadOnly = true;
                dataGridViewProducts.Columns.Add(colTenSanPham);

                // Tạo cột Số lượng
                DataGridViewTextBoxColumn colSoluong = new DataGridViewTextBoxColumn();
                colSoluong.HeaderText = "Số lượng";
                colSoluong.DataPropertyName = "so_luong"; // DataPropertyName
                colSoluong.Name = "Soluong";
                colSoluong.ReadOnly = true;
                dataGridViewProducts.Columns.Add(colSoluong);

                // Tạo cột Đơn giá nhập sản phẩm
                DataGridViewTextBoxColumn colGia = new DataGridViewTextBoxColumn();
                colGia.HeaderText = "Giá";
                colGia.DataPropertyName = "gia"; // DataPropertyName
                colGia.Name = "Gia";
                colGia.ReadOnly = true;
                dataGridViewProducts.Columns.Add(colGia);

                dataGridViewProducts.DataSource = dt;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedCells.Count > 0)
            {

                int selectedRowIndex = dataGridViewProducts.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewProducts.Rows[selectedRowIndex];

                int maSanPham = Convert.ToInt32(selectedRow.Cells["MaSanPham"].Value);
                string tenSanPham = selectedRow.Cells["TenSanPham"].Value.ToString();
                int soLuongThem = Convert.ToInt32(numericUpDown1.Value);
                int gia = Convert.ToInt32(selectedRow.Cells["Gia"].Value);
                
                // Kiểm tra số lượng phải lớn hơn 0
                if (soLuongThem > 0)
                {
                    int soLuongHienTai = Convert.ToInt32(selectedRow.Cells["SoLuong"].Value);

                    // Kiểm tra xem số lượng trong kho có đủ không
                    if (soLuongHienTai >= soLuongThem)
                    {
                        // Kiểm tra xem sản phẩm đã tồn tại trong DataGridView2 chưa
                        bool productExists = false;
                        foreach (DataGridViewRow row in dataGridViewDonHang.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["ma_san_pham"].Value) == maSanPham)
                            {
                                // Nếu sản phẩm đã tồn tại, cập nhật số lượng
                                int currentQuantity = Convert.ToInt32(row.Cells["so_luong"].Value);
                                row.Cells["so_luong"].Value = currentQuantity + soLuongThem;

                                // Cập nhật tổng tiền hoặc các thông tin khác nếu cần
                                UpdateTotalAmount();

                                // Đặt giá trị của numericUpDown thành 1
                                numericUpDown1.Value = 1;

                                productExists = true;
                                break;
                            }
                        }

                        // Nếu sản phẩm chưa tồn tại, thêm dòng mới
                        if (!productExists)
                        {
                            dataGridViewDonHang.Rows.Add(maSanPham, tenSanPham, soLuongThem, gia, soLuongThem * gia);

                            // Cập nhật tổng tiền hoặc các thông tin khác nếu cần
                            UpdateTotalAmount();

                            // Đặt giá trị của numericUpDown thành 1
                            numericUpDown1.Value = 1;
                        }

                        // Trừ số lượng trong dgvSanPham
                        selectedRow.Cells["SoLuong"].Value = soLuongHienTai - soLuongThem;
                    }
                    else
                    {
                        MessageBox.Show("Số lượng sản phẩm trong kho không đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateTotalAmount()
        {
            int totalAmount = 0;

            // Lặp qua các dòng trong DataGridView2 và tính tổng tiền
            foreach (DataGridViewRow row in dataGridViewDonHang.Rows)
            {
                int thanhTien = Convert.ToInt32(row.Cells["thanh_tien"].Value);
                totalAmount += thanhTien;
            }

            // Hiển thị tổng tiền trong Label
            lblTotal.Text = $"{totalAmount:N0} VNĐ";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridViewDonHang.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dataGridViewDonHang.SelectedRows[0];

                // Lấy giá trị của cột Thành Tiền để trừ đi tổng tiền
                int thanhTien = Convert.ToInt32(selectedRow.Cells["thanh_tien"].Value);

                // Lấy giá trị của cột Mã Sản Phẩm để xác định sản phẩm cần cập nhật số lượng
                int maSanPham = Convert.ToInt32(selectedRow.Cells["ma_san_pham"].Value);

                // lấy giá trị số lượng của sản phẩm đang trong đơn hàng
                int solg = Convert.ToInt32(selectedRow.Cells["so_luong"].Value);

                // Xóa dòng được chọn
                dataGridViewDonHang.Rows.Remove(selectedRow);

                // Cập nhật lại số lượng trong bảng sản phẩm
                foreach (DataGridViewRow row in dataGridViewProducts.Rows)
                {
                    if (Convert.ToInt32(row.Cells["MaSanPham"].Value) == maSanPham)
                    {
                        // Cộng lại số lượng đã bị trừ khi sản phẩm được thêm vào đơn hàng
                        int soLuongHienTai = Convert.ToInt32(row.Cells["SoLuong"].Value);
                        row.Cells["SoLuong"].Value = soLuongHienTai + solg;
                        break;
                    }
                }

                // Cập nhật tổng tiền sau khi xóa
                UpdateTotalAmount(-thanhTien);
            }
        }

        private void UpdateTotalAmount(int adjustment)
        {
            int totalAmount = 0;

            // Lặp qua các dòng trong DataGridView2 và tính tổng tiền
            foreach (DataGridViewRow row in dataGridViewDonHang.Rows)
            {
                int thanhTien = Convert.ToInt32(row.Cells["thanh_tien"].Value);
                totalAmount += thanhTien;
            }

            // Hiển thị tổng tiền trong Label với định dạng số tiền
            lblTotal.Text = $"{totalAmount:N0} VNĐ";
        }

        private void dataGridViewDonHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu thay đổi trong cột số lượng
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewDonHang.Columns["so_luong"].Index)
            {
                // Lấy số lượng mới từ ô tương ứng
                int newQuantity = Convert.ToInt32(dataGridViewDonHang.Rows[e.RowIndex].Cells["so_luong"].Value);

                // Lấy mã sản phẩm từ ô tương ứng
                int maSanPham = Convert.ToInt32(dataGridViewDonHang.Rows[e.RowIndex].Cells["ma_san_pham"].Value);

                // Lấy số lượng hiện tại từ bảng sản phẩm
                int soLuongTrongKho = bll.CheckSoluong(maSanPham);

                // Kiểm tra xem số lượng mới có vượt quá số lượng hiện tại không
                if (soLuongTrongKho < newQuantity)
                {
                    MessageBox.Show("Số lượng sản phẩm trong kho không đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật số lượng trong bảng sản phẩm với số lượng hiện tại trong kho
                    UpdateSoLuongInProductsTable(maSanPham, previousQuantity, previousQuantity);

                    dataGridViewDonHang.Rows[e.RowIndex].Cells["so_luong"].Value = previousQuantity;

                    // Cập nhật tổng tiền và số lượng trong bảng đơn hàng
                    UpdateQuantityAndTotal();
                }
                else
                {
                    // Cập nhật số lượng trong bảng sản phẩm
                    UpdateSoLuongInProductsTable(maSanPham, previousQuantity, newQuantity);

                    // Cập nhật tổng tiền và số lượng trong bảng đơn hàng
                    UpdateQuantityAndTotal();
                }
            }
        }


        // Hàm cập nhật số lượng trong bảng sản phẩm
        private void UpdateSoLuongInProductsTable(int maSanPham, int previousQuantity, int newQuantity)
        {
            foreach (DataGridViewRow row in dataGridViewProducts.Rows)
            {
                if (Convert.ToInt32(row.Cells["MaSanPham"].Value) == maSanPham)
                {
                    int soLuongHienTai = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    row.Cells["SoLuong"].Value = soLuongHienTai + (previousQuantity - newQuantity);
                    break;
                }
            }
        }


        private void UpdateQuantityAndTotal()
        {
            // Cập nhật số lượng và tổng tiền sau mỗi lần thay đổi
            int totalAmount = 0;

            foreach (DataGridViewRow row in dataGridViewDonHang.Rows)
            {
                int soLuong = Convert.ToInt32(row.Cells["so_luong"].Value);
                int gia = Convert.ToInt32(row.Cells["gia"].Value);

                // Cập nhật số lượng
                row.Cells["thanh_tien"].Value = soLuong * gia;

                // Cập nhật tổng tiền
                totalAmount += Convert.ToInt32(row.Cells["thanh_tien"].Value);
            }

            // Hiển thị tổng tiền trong Label với định dạng số tiền
            lblTotal.Text = $"{totalAmount:N0} VNĐ";
        }


        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            HoaDonBLL hdBLL = new HoaDonBLL();
            List<HoaDonDTO> hdDTO = hdBLL.GetList();
            HoaDonDTO hdDTO_l = hdDTO[hdDTO.Count - 1];
            int mahd = hdDTO_l.maHoaDon + 1;

            int madon = 0;
            DateTime ngayxuat = DateTime.Now;
            int masp = 0, solg = 0, giasp = 0, thanhtien = 0;
            string tensp = "";
            
            // Chuyển đổi giá trị từ chuỗi sang số nguyên
            int tongtien;
            if (int.TryParse(lblTotal.Text.Replace("VNĐ", "").Replace(".", ""), out tongtien))
            {
                if (tongtien > 0)
                {
                    // Thêm hóa đơn
                    HoaDonDTO hoadon = new HoaDonDTO(madon, ngayxuat, manv, tongtien, "1");
                    HoaDonBLL bLL = new HoaDonBLL();
                    bLL.Insert(hoadon);

                    foreach (DataGridViewRow row in dataGridViewDonHang.Rows)
                    {
                        // Kiểm tra nếu dòng không phải dòng mới (có dữ liệu)
                        if (!row.IsNewRow)
                        {
                            // Lấy giá trị từ cột "Số lượng" và chuyển thành kiểu int
                            if (int.TryParse(row.Cells["so_luong"].Value.ToString(), out solg))
                            {
                                masp = Convert.ToInt32(row.Cells["ma_san_pham"].Value);
                                tensp = row.Cells["ten_san_pham"].Value.ToString();
                                solg = Convert.ToInt32(row.Cells["so_luong"].Value);
                                giasp = Convert.ToInt32(row.Cells["gia"].Value);
                                thanhtien = Convert.ToInt32(row.Cells["thanh_tien"].Value);

                                // Thêm chi tiết hóa đơn
                                CTHoaDonDTO cTHoaDon = new CTHoaDonDTO(mahd, masp, tensp, solg, giasp, thanhtien);
                                CTHoaDonBLL cTHoaDonBLL = new CTHoaDonBLL();
                                cTHoaDonBLL.Insert(cTHoaDon);

                                // cập nhật số lượng bên sản phẩm khi thanh toán
                                SanPhamBLL bllsp = new SanPhamBLL();
                                int soLuongHienTai = bllsp.CheckSoluong(masp);
                                bllsp.UpdateSoLuong(masp, soLuongHienTai - solg);
                            }
                        }
                    }
                    MessageBox.Show("Thanh toán thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Inhd(mahd, ngayxuat, tongtien, manv);
                    dataGridViewDonHang.Rows.Clear();
                    lblTotal.Text = "0 VNĐ";
                    
                }
                else
                {
                    MessageBox.Show("Vui lòng thêm sản phẩm vào đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lỗi khi chuyển đổi tổng tiền.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formDangnhap = new DangNhap();
            formDangnhap.Closed += (s, args) => this.Close();
            formDangnhap.Show();
        }

        private int previousQuantity; // Biến để lưu trữ số lượng trước khi chỉnh sửa
        private void dataGridViewDonHang_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Kiểm tra nếu đang chỉnh sửa trong cột số lượng
            if (e.ColumnIndex == dataGridViewDonHang.Columns["so_luong"].Index)
            {
                // Lấy giá trị hiện tại của ô số lượng và lưu vào biến previousQuantity
                DataGridViewCell cell = dataGridViewDonHang.Rows[e.RowIndex].Cells["so_luong"];
                previousQuantity = Convert.ToInt32(cell.Value);
            }
        }
    }
}
