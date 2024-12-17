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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SieuThiMini.GUI
{
    public partial class ThemDonNhapHang : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        int maNV;
        public ThemDonNhapHang(int maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
            cbMancc.Items.Clear();
            dt = dp.ExecuteQuery("SELECT ma_ncc FROM nha_cung_cap ORDER BY ma_ncc ASC");
            cbMancc.DisplayMember = "ma_ncc";
            cbMancc.ValueMember = "ma_ncc";
            cbMancc.DataSource = dt;

        }


 

        private void cbMancc_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbMancc.SelectedIndex != -1)
            {
                int maNCC = int.Parse(cbMancc.Text);

                // Thực hiện câu truy vấn để lấy danh sách mã sản phẩm thuộc nhà cung cấp
                string query = "SELECT san_pham.ma_san_pham, san_pham.ten_san_pham, san_pham.gia_nhap FROM san_pham " +
                    "INNER JOIN loai_san_pham ON san_pham.ma_loai = loai_san_pham.ma_loai " +
                    $"WHERE loai_san_pham.ma_ncc = {maNCC}"; 

                dt = dp.ExecuteQuery(query);

                // Xóa tất cả cột hiện tại trong DataGridView
                dataGridView1.Columns.Clear();

                // Tạo cột Mã sản phẩm
                DataGridViewTextBoxColumn colMaSanPham = new DataGridViewTextBoxColumn();
                colMaSanPham.HeaderText = "Mã Sản Phẩm";
                colMaSanPham.DataPropertyName = "ma_san_pham"; // DataPropertyName
                colMaSanPham.Name = "MaSanPham";
                colMaSanPham.ReadOnly = true;
                dataGridView1.Columns.Add(colMaSanPham);

                // Tạo cột Tên sản phẩm
                DataGridViewTextBoxColumn colTenSanPham = new DataGridViewTextBoxColumn();
                colTenSanPham.HeaderText = "Tên Sản Phẩm";
                colTenSanPham.DataPropertyName = "ten_san_pham"; // DataPropertyName
                colTenSanPham.Name = "TenSanPham";
                colTenSanPham.ReadOnly = true;
                dataGridView1.Columns.Add(colTenSanPham);

                // Tạo cột Đơn giá nhập sản phẩm
                DataGridViewTextBoxColumn colGianhap = new DataGridViewTextBoxColumn();
                colGianhap.HeaderText = "Giá nhập";
                colGianhap.DataPropertyName = "gia_nhap"; // DataPropertyName
                colGianhap.Name = "Gianhap";
                colGianhap.ReadOnly = true;
                dataGridView1.Columns.Add(colGianhap);

                // Tạo cột Số lượng
                DataGridViewTextBoxColumn colSL = new DataGridViewTextBoxColumn();
                colSL.HeaderText = "Số lượng";
                colSL.Name = "Soluong";
                dataGridView1.Columns.Add(colSL);                


                dataGridView1.DataSource = dt;
            }
        }
        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DonNhapHangBLL donNhapHangBLL = new DonNhapHangBLL();
            List<DonNhapHangDTO> dnhDTO = donNhapHangBLL.GetList();
            DonNhapHangDTO dthDTO_l = dnhDTO[dnhDTO.Count - 1];
            int maDonNhap = dthDTO_l.maDonNH + 1;

            int madon = 0;
            int mancc = int.Parse(cbMancc.Text);
            DateTime date = DateTime.Now;
            int tongtiennhap = int.Parse(txtTongtiennhap.Text.Replace("VNĐ", "").Replace(".", ""));


            int masp = 0, solg = 0, giasp = 0;
            string tensp = "";

            String trangthai = "1";

            DonNhapHangDTO donNhapHang = new DonNhapHangDTO(madon, mancc, maNV, date, tongtiennhap, trangthai);
            DonNhapHangBLL bLL = new DonNhapHangBLL();
            bLL.Insert(donNhapHang);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Kiểm tra nếu dòng không phải dòng mới (có dữ liệu)
                if (!row.IsNewRow)
                {
                    if (!row.IsNewRow && row.Cells["Soluong"].Value != null)
                    {
                        // Lấy giá trị từ cột "Số lượng" và chuyển thành kiểu int
                        if (int.TryParse(row.Cells["Soluong"].Value.ToString(), out solg))
                        {
                            // Lấy giá trị từ cột "Mã Sản Phẩm" và chuyển thành kiểu int
                            masp = int.Parse(row.Cells["MaSanPham"].Value.ToString());

                            // Lấy giá trị từ cột "Tên Sản Phẩm" và chuyển thành kiểu string
                            tensp = row.Cells["TenSanPham"].Value.ToString();

                            // Lấy giá trị từ cột "Giá nhập" và chuyển thành kiểu int
                            giasp = int.Parse(row.Cells["Gianhap"].Value.ToString());

                            CTDonNhapHangDTO chiTietDonNhap = new CTDonNhapHangDTO(maDonNhap, masp, tensp, solg, giasp, solg * giasp);
                            CTDonNhapHangBLL bll = new CTDonNhapHangBLL();
                            bll.Insert(chiTietDonNhap);

                            SanPhamBLL bllsp = new SanPhamBLL();
                            int soLuongHienTai = bllsp.CheckSoluong(masp);
                            bllsp.UpdateSoLuong(masp, soLuongHienTai + solg);
                        }
                    }
                }
            }
            MessageBox.Show("Thêm đơn nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnHuy_Click(null, null);
                        
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Soluong"].Value != null)
                {
                    decimal giaNhap = Convert.ToDecimal(row.Cells["Gianhap"].Value);
                    int soLuong = row.Cells["SoLuong"].Value == null ? 0 : Convert.ToInt32(row.Cells["SoLuong"].Value);
                    decimal thanhTien = soLuong * giaNhap;
                    tongTien += thanhTien;
                    
                }
            }
            txtTongtiennhap.Text = tongTien.ToString("#,##0");
        }

    }
}
