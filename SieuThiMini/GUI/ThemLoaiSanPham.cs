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
    public partial class ThemLoaiSanPham : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        public ThemLoaiSanPham()
        {
            InitializeComponent();
            dt = dp.ExecuteQuery("SELECT ma_ncc FROM `nha_cung_cap` ORDER BY `ma_ncc` ASC");
            cb_MaNcc.DisplayMember = "ma_ncc";
            cb_MaNcc.DataSource = dt;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            String tenloai = tb_TenLoai.Text;
            int maloai = 0;
            int mancc;
            if (cb_MaNcc.Text != "")
            {
                mancc = int.Parse(cb_MaNcc.Text);
            }
            else
            {
                mancc = 0;
            }
            
            if (tenloai != "" && mancc > 0)
            {
                LoaiSanPhamDTO loaisanpham = new LoaiSanPhamDTO(maloai, tenloai, mancc, "1");
                LoaiSanPhamBLL bLL = new LoaiSanPhamBLL();
                bLL.Insert(loaisanpham);
                this.Close();
                MessageBox.Show("Thêm loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không được bỏ trống tên loại sản phẩm", "Thông tin không hợp lệ! Hãy kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_TenLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
