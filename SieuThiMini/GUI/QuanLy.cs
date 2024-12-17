using SieuThiMini.BLL;
using SieuThiMini.DTO;
using SixLabors.ImageSharp.ColorSpaces;
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
    public partial class QuanLy : Form
    {
        int maNV;
        private NhanVienBLL nvBLL = new NhanVienBLL();
        private NhanVienDTO nvDTO;
        private TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        private TaiKhoanDTO tkDTO;
        public QuanLy(int maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.nvDTO = nvBLL.getNVByManv(int.Parse(maNV.ToString()));
            this.tkDTO = tkBLL.getTKByMaTK(int.Parse(nvDTO.maTaikhoan.ToString()));
            this.MinimumSize = new Size(1000, 600);
        }
        private void QuanLy_Load(object sender, EventArgs e)
        {
            labelNameUser.Text = tkDTO.tenTaikhoan;
            if(tkDTO.maQuyen == 2)
            {
                panelAdmin.Visible = false;
            }
            if (tkDTO.maQuyen == 1)
            {
                panelQuanly.Visible = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formDangnhap = new DangNhap();
            formDangnhap.Closed += (s, args) => this.Close();
            formDangnhap.Show();
        }

        private Form currentFormChild;
        private Button currentButton ;

        private void openChildForm(Form childForm, Button childButton)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                currentButton.BackColor = Color.Black;
            }
            currentFormChild = childForm;
            currentButton = childButton;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void SanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLySanPham(), btnSanpham);
            title.Text = "Quản lý sản phẩm";
            btnSanpham.BackColor = Color.Gray;
        }
        private void btnLoaisanpham_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyLoaiSanPham(), btnLoaisanpham);
            title.Text = "Quản lý loại sản phẩm";
            btnLoaisanpham.BackColor = Color.Gray;
        }
        private void btnNhacungcap_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyNhaCungCap(), btnNhacungcap);
            title.Text = "Quản lý nhà cung cấp";
            btnNhacungcap.BackColor = Color.Gray;
        }
        private void btnHoadon_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyHoaDon(), btnHoadon);
            title.Text = "Quản lý hóa đơn";
            btnHoadon.BackColor = Color.Gray;
        }
        private void btnNhaphang_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyNhapHang(maNV), btnNhaphang);
            title.Text = "Quản lý nhập hàng";
            btnNhaphang.BackColor = Color.Gray;
        }
        private void btnThongke_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongKe(), btnThongke);
            title.Text = "Thống kê";
            btnThongke.BackColor = Color.Gray;
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyNhanVien(), btnNhanvien);
            title.Text = "Quản lý nhân viên";
            btnNhanvien.BackColor = Color.Gray;
        }

        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyTaiKhoan(), btnTaikhoan);
            title.Text = "Quản lý tài khoản";
            btnTaikhoan.BackColor = Color.Gray;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
