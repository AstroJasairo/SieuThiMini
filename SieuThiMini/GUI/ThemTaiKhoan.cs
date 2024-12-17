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
    public partial class ThemTaiKhoan : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        public ThemTaiKhoan()
        {
            InitializeComponent();
            dt = dp.ExecuteQuery("SELECT ma_quyen FROM `phan_quyen` WHERE ma_quyen > 0");
            comboBoxPhanQuyen.DisplayMember = "ma_quyen";
            comboBoxPhanQuyen.DataSource = dt;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int maTK = 0;   

            String tenTaiKhoan = txtTenTaiKhoan.Text;
            String matKhau = txtMatKhau.Text;
            int phanQuyen = int.Parse(comboBoxPhanQuyen.Text);

            if (tenTaiKhoan != "" && matKhau != "" && phanQuyen > 0)
            {
                TaiKhoanDTO taikhoan = new TaiKhoanDTO(maTK, tenTaiKhoan, matKhau, phanQuyen, "1");
                TaiKhoanBLL bLL = new TaiKhoanBLL();
                bLL.Insert(taikhoan);
                this.Close();
                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không được bỏ trống bất cứ ô nào", "Thông tin không hợp lệ, hãy kiểm tra lại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
