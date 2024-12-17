using Guna.UI2.WinForms.Suite;
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
    public partial class QuanLyNhanVien : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        private NhanVienBLL bll = new NhanVienBLL();
        public QuanLyNhanVien()
        {
            InitializeComponent();
            dt = dp.ExecuteQuery("SELECT ma_tai_khoan FROM `tai_khoan` ORDER BY `ma_tai_khoan` ASC");
            comboBox1.DisplayMember = "ma_tai_khoan";
            comboBox1.DataSource = dt;
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            List<NhanVienDTO> list = bll.GetList();
            dataGridViewNhanVien.DataSource = list;

            dataGridViewNhanVien.Columns["trangThai"].Visible = false;

            dataGridViewNhanVien.Columns["maNhanvien"].HeaderText = "Mã nhân viên";
            dataGridViewNhanVien.Columns["tenNhanvien"].HeaderText = "Tên nhân viên";
            dataGridViewNhanVien.Columns["ngaySinh"].HeaderText = "Ngày sinh";
            dataGridViewNhanVien.Columns["sdt"].HeaderText = "Số điện thoại";
            dataGridViewNhanVien.Columns["mail"].HeaderText = "Mail";
            dataGridViewNhanVien.Columns["maTaikhoan"].HeaderText = "Mã tài khoản";

            var datagridviewArgs = new DataGridViewCellEventArgs(0, 0);
            dataGridViewNhanVien_CellClick(null, datagridviewArgs);

        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtSDT.Enabled = false;
            txtMail.Enabled = false;
            comboBox1.Enabled = false;
            dateTimePicker1.Enabled = false;

            btnHuy.Visible = false;
            btnLuu.Visible = false;

            if (e.RowIndex == -1) return;

            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewNhanVien.Rows[e.RowIndex];

            txtMaNV.Text = Convert.ToString(row.Cells["maNhanvien"].Value);
            txtTenNV.Text = Convert.ToString(row.Cells["tenNhanvien"].Value);
            dateTimePicker1.Text = Convert.ToString(row.Cells["ngaySinh"].Value);
            txtSDT.Text = Convert.ToString(row.Cells["sdt"].Value);
            txtMail.Text = Convert.ToString(row.Cells["mail"].Value);
            comboBox1.Text = Convert.ToString(row.Cells["maTaikhoan"].Value);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemNhanVien tl = new ThemNhanVien();
            tl.ShowDialog();
            dataGridViewNhanVien.DataSource = bll.GetList();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            KhoiPhucNhanVien kp = new KhoiPhucNhanVien();
            kp.ShowDialog();
            dataGridViewNhanVien.DataSource = bll.GetList();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            dataGridViewNhanVien.DataSource = bll.GetList();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtMaNV.Text =="")
            {
                MessageBox.Show("Hãy chọn 1 nhân viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtTenNV.Enabled = true;
                txtSDT.Enabled = true;
                txtMail.Enabled = true;
                comboBox1.Enabled = true;
                dateTimePicker1.Enabled = true;

                btnHuy.Visible = true;
                btnLuu.Visible = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            int index = dataGridViewNhanVien.SelectedRows[0].Index;
            var datagridviewArgs = new DataGridViewCellEventArgs(0, index);
            dataGridViewNhanVien_CellClick(null, datagridviewArgs);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            String timkiem = txtTimKiem.Text;
            List<NhanVienDTO> list = bll.Timkiem(timkiem);
            dataGridViewNhanVien.DataSource = list;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaNV.Text!="" && comboBox1.Text=="0")
            {
                int manv = int.Parse(txtMaNV.Text.ToString());

                NhanVienBLL bLL = new NhanVienBLL();
                List<NhanVienDTO> list = bLL.getNVByMaNV(manv);

                bll.Delete(manv);

                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnRefesh_Click(null, null);
                var datagridviewArgs = new DataGridViewCellEventArgs(0, 0);
                dataGridViewNhanVien_CellClick(null, datagridviewArgs);
            }
            else if(txtMaNV.Text=="")
            {
                MessageBox.Show("Hãy chọn 1 nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(comboBox1.Text!="0")
            {
                MessageBox.Show("Nhân viên vẫn còn tài khoản đang sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int matk;
            int manhanvien = int.Parse(txtMaNV.Text);
            String tennhanvien = txtTenNV.Text;
            DateTime ngaysinh = DateTime.Parse(dateTimePicker1.Text.ToString());
            String sdt = txtSDT.Text;
            String mail = txtMail.Text;

            if(comboBox1.Text !="")
            {
                matk=int.Parse(comboBox1.Text);
            }
            else
            {
                matk = 0;
            }
            
            if(manhanvien != 0)
            {
                if(tennhanvien !="")
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
                                bLL.Update(nhanvien);

                                btnHuy_Click(null, null);

                                MessageBox.Show("Sửa thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                btnRefesh_Click(null, null);
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
    }
}
