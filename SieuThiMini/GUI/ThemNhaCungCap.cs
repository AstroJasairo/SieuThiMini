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
    public partial class ThemNhaCungCap : Form
    {
        public ThemNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenncc.Text) || string.IsNullOrWhiteSpace(txtDiachi.Text))
            {
                MessageBox.Show("Không được để trống tên hoặc địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int mancc = 0;
                string tenncc = txtTenncc.Text;
                string diachi = txtDiachi.Text;
                string trangthai = "1";

                NhaCungCapDTO nhaCungCap = new NhaCungCapDTO(mancc, tenncc, diachi, trangthai);
                NhaCungCapBLL bLL = new NhaCungCapBLL();
                bLL.Insert(nhaCungCap);
                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnHuy_Click(null, null);
            }
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
