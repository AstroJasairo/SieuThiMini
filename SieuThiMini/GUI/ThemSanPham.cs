using NPOI.XWPF.UserModel;
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
    public partial class ThemSanPham : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        public ThemSanPham()
        {
            InitializeComponent();
            dt = dp.ExecuteQuery("SELECT ma_ncc FROM `nha_cung_cap` ORDER BY `ma_ncc` ASC");
            cbbMaLoai.DisplayMember = "ma_ncc";
            cbbMaLoai.DataSource = dt;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int gia = 0, gianhap = 0;
            int masp = 0;
            int soluong = 0;
            String tensp = txtTenSP.Text;
            int maloai = int.Parse(cbbMaLoai.Text);
            try
            {
                gia = int.Parse(txtGia.Text);
                gianhap = int.Parse(txtGiaNhap.Text);
                if (txtGia.Text != "" && txtGiaNhap.Text != "" && tensp != "" && gia > 0 && gianhap > 0)
                {
                    SanPhamDTO sanpham = new SanPhamDTO(masp, tensp, soluong, gia, gianhap, maloai, "1");
                    SanPhamBLL bLL = new SanPhamBLL();
                    bLL.Insert(sanpham);
                    this.Close();
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Các hạn chế gồm:\n \n1. Không được bỏ trống bất cứ thông tin nào \n2. Giá bán và giá nhập phải lớn hơn 0 và là số", "Thông tin không hợp lệ, hãy kiểm tra lại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Các hạn chế gồm:\n \n1. Không được bỏ trống bất cứ thông tin nào \n2. Giá bán và giá nhập phải lớn hơn 0 và là số", "Thông tin không hợp lệ, hãy kiểm tra lại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemSanPham_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
