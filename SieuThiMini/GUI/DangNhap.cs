using MySqlX.XDevAPI.Relational;
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
    public partial class DangNhap : Form
    {
        private TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        private TaiKhoanDTO tkDTO;
        public DangNhap()
        {
            InitializeComponent();
        }
        
        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "quanly1";
            txtPassword.Text = "123456";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            try
            {
                tkDTO = tkBLL.SignIn(txtUsername.Text, txtPassword.Text);
            }
            catch
            {
                MessageBox.Show("Tài khoản không chính xác.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            MessageBox.Show("Đăng nhập thành công.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // nhân viên
            if (tkDTO.maQuyen == 3)
            {
                this.Hide();
                NhanVienBLL nvBLL = new NhanVienBLL();
                NhanVienDTO nvDTO = nvBLL.getNVByTK(int.Parse(tkDTO.maTaikhoan.ToString()));
                var formBH = new BanHang(nvDTO.maNhanvien);
                formBH.FormClosed += (s, args) => this.Close();
                formBH.Show();
            }
            // admin & quản lý
            else
            {
                this.Hide();
                NhanVienBLL nvBLL = new NhanVienBLL();
                NhanVienDTO nvDTO = nvBLL.getNVByTK(int.Parse(tkDTO.maTaikhoan.ToString()));
                var formQL = new QuanLy(nvDTO.maNhanvien);
                formQL.FormClosed += (s, args) => this.Close();
                formQL.Show();
            }

            return;
        }

        private void btnSeePass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            btnSeePass.Visible = !btnSeePass.Visible;
            btnHidePass.Visible = !btnHidePass.Visible;
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            btnSeePass.Visible = !btnSeePass.Visible;
            btnHidePass.Visible = !btnHidePass.Visible;
        }
    }
}
