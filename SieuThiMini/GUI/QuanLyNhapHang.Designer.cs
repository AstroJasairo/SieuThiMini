namespace SieuThiMini.GUI
{
    partial class QuanLyNhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridViewDonNhapHang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonNhapHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefesh
            // 
            this.btnRefesh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefesh.BackColor = System.Drawing.Color.LightPink;
            this.btnRefesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefesh.Location = new System.Drawing.Point(916, 24);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(117, 43);
            this.btnRefesh.TabIndex = 57;
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.UseVisualStyleBackColor = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(287, 33);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(600, 30);
            this.txtTimKiem.TabIndex = 52;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.LightBlue;
            this.btnKhoiPhuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhoiPhuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.Location = new System.Drawing.Point(588, 87);
            this.btnKhoiPhuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhoiPhuc.MinimumSize = new System.Drawing.Size(114, 32);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(142, 43);
            this.btnKhoiPhuc.TabIndex = 56;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(167, 35);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(97, 25);
            this.lblTimKiem.TabIndex = 51;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXuatExcel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Location = new System.Drawing.Point(752, 87);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(142, 43);
            this.btnXuatExcel.TabIndex = 54;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.BackColor = System.Drawing.Color.LightGreen;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(282, 87);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 43);
            this.btnThem.TabIndex = 53;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridViewDonNhapHang
            // 
            this.dataGridViewDonNhapHang.AllowUserToAddRows = false;
            this.dataGridViewDonNhapHang.AllowUserToDeleteRows = false;
            this.dataGridViewDonNhapHang.AllowUserToResizeColumns = false;
            this.dataGridViewDonNhapHang.AllowUserToResizeRows = false;
            this.dataGridViewDonNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDonNhapHang.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridViewDonNhapHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDonNhapHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDonNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDonNhapHang.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDonNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDonNhapHang.Location = new System.Drawing.Point(0, 154);
            this.dataGridViewDonNhapHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDonNhapHang.Name = "dataGridViewDonNhapHang";
            this.dataGridViewDonNhapHang.ReadOnly = true;
            this.dataGridViewDonNhapHang.RowHeadersVisible = false;
            this.dataGridViewDonNhapHang.RowHeadersWidth = 62;
            this.dataGridViewDonNhapHang.RowTemplate.Height = 28;
            this.dataGridViewDonNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDonNhapHang.Size = new System.Drawing.Size(1200, 579);
            this.dataGridViewDonNhapHang.TabIndex = 5;
            this.dataGridViewDonNhapHang.TabStop = false;
            this.dataGridViewDonNhapHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDonNhapHang_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnRefesh);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnKhoiPhuc);
            this.panel1.Controls.Add(this.lblTimKiem);
            this.panel1.Controls.Add(this.btnXuatExcel);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 154);
            this.panel1.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.Color.HotPink;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(425, 87);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 43);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // QuanLyNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 733);
            this.Controls.Add(this.dataGridViewDonNhapHang);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyNhapHang";
            this.Text = "QuanLyNhapHang";
            this.Load += new System.EventHandler(this.QuanLyNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonNhapHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridViewDonNhapHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
    }
}