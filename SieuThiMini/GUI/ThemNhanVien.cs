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
    public partial class ThemNhanVien : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        public ThemNhanVien()
        {
            InitializeComponent();
            dt = dp.ExecuteQuery("SELECT ma_tai_khoan FROM `tai_khoan` ORDER BY `ma_tai_khoan` ASC");
            comboBox1.DisplayMember = "ma_tai_khoan";
            comboBox1.DataSource = dt;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            int matk;
            int manhanvien = 1;
            String tennhanvien = txtTenNV.Text;
            DateTime ngaysinh = DateTime.Parse(dateTimePicker1.Text.ToString());
            String sdt = txtSDT.Text;
            String mail = txtMail.Text;
            if (comboBox1.Text != "")
            {
                matk=int.Parse(comboBox1.Text);
            }
            else
            {
                matk = 0;
            }

            if (manhanvien != 0)
            {
                if (tennhanvien != "")
                {
                    TimeSpan timeSpan = DateTime.Today - dateTimePicker1.Value.Date;
                    if (timeSpan.Days <= 18)
                    {
                        MessageBox.Show("Lỗi: Tuổi của bạn phải lớn hơn 18.");
                    }
                    else if (dateTimePicker1.Value.Date > DateTime.Today)
                    {
                        MessageBox.Show("Lỗi: Ngày sinh không thể sau ngày hiện tại.");
                    }
                    else
                    {
                        if (txtSDT.Text.Length == 10 && Int64.TryParse(txtSDT.Text, out _))
                        {
                            if (txtMail.Text.EndsWith("@gmail.com"))
                            {
                                NhanVienDTO nhanvien = new NhanVienDTO(manhanvien, tennhanvien, ngaysinh, sdt, mail, matk, "1");
                                NhanVienBLL bLL = new NhanVienBLL();
                                bLL.Insert(nhanvien);
                                this.Close();
                                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Lỗi: Email phải có đuôi '@gmail.com'.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lỗi: Số điện thoại phải có đủ 10 chữ số.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi: Chưa có tên nhân viên");
                }
            }
            else
            {
                MessageBox.Show("Lỗi: Chưa có mã nhân viên");
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
