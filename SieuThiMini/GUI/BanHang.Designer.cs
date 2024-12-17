namespace SieuThiMini.GUI
{
    partial class BanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbloaisp = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridViewDonHang = new System.Windows.Forms.DataGridView();
            this.ma_san_pham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_san_pham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanh_tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonHang)).BeginInit();
            this.panel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 601);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridViewProducts);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(670, 507);
            this.panel4.TabIndex = 1;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AllowUserToResizeColumns = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridViewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProducts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(670, 507);
            this.dataGridViewProducts.TabIndex = 1;
            this.dataGridViewProducts.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Pink;
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(670, 94);
            this.panel3.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.Color.Crimson;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(360, 26);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 43);
            this.btnXoa.TabIndex = 56;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.Color.LightGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(216, 26);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 43);
            this.btnThem.TabIndex = 54;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cbloaisp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã loại";
            // 
            // cbloaisp
            // 
            this.cbloaisp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbloaisp.FormattingEnabled = true;
            this.cbloaisp.Location = new System.Drawing.Point(18, 23);
            this.cbloaisp.Name = "cbloaisp";
            this.cbloaisp.Size = new System.Drawing.Size(139, 28);
            this.cbloaisp.TabIndex = 0;
            this.cbloaisp.SelectedIndexChanged += new System.EventHandler(this.cbloaisp_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(500, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số lượng";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 23);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(129, 27);
            this.numericUpDown1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(686, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 601);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridViewDonHang);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 94);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(635, 381);
            this.panel7.TabIndex = 2;
            // 
            // dataGridViewDonHang
            // 
            this.dataGridViewDonHang.AllowUserToAddRows = false;
            this.dataGridViewDonHang.AllowUserToDeleteRows = false;
            this.dataGridViewDonHang.AllowUserToResizeColumns = false;
            this.dataGridViewDonHang.AllowUserToResizeRows = false;
            this.dataGridViewDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDonHang.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridViewDonHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_san_pham,
            this.ten_san_pham,
            this.so_luong,
            this.gia,
            this.thanh_tien});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDonHang.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDonHang.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDonHang.Name = "dataGridViewDonHang";
            this.dataGridViewDonHang.RowHeadersVisible = false;
            this.dataGridViewDonHang.RowHeadersWidth = 51;
            this.dataGridViewDonHang.RowTemplate.Height = 24;
            this.dataGridViewDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDonHang.Size = new System.Drawing.Size(635, 381);
            this.dataGridViewDonHang.TabIndex = 0;
            this.dataGridViewDonHang.TabStop = false;
            this.dataGridViewDonHang.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewDonHang_CellBeginEdit);
            this.dataGridViewDonHang.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDonHang_CellValueChanged);
            // 
            // ma_san_pham
            // 
            this.ma_san_pham.HeaderText = "Mã sản phẩm";
            this.ma_san_pham.MinimumWidth = 8;
            this.ma_san_pham.Name = "ma_san_pham";
            // 
            // ten_san_pham
            // 
            this.ten_san_pham.HeaderText = "Tên sản phẩm";
            this.ten_san_pham.MinimumWidth = 8;
            this.ten_san_pham.Name = "ten_san_pham";
            // 
            // so_luong
            // 
            this.so_luong.HeaderText = "Số lượng";
            this.so_luong.MinimumWidth = 8;
            this.so_luong.Name = "so_luong";
            // 
            // gia
            // 
            this.gia.HeaderText = "Đơn giá";
            this.gia.MinimumWidth = 8;
            this.gia.Name = "gia";
            // 
            // thanh_tien
            // 
            this.thanh_tien.HeaderText = "Thành tiền";
            this.thanh_tien.MinimumWidth = 8;
            this.thanh_tien.Name = "thanh_tien";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.btnThanhtoan);
            this.panel6.Controls.Add(this.groupBox3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 475);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(635, 126);
            this.panel6.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(460, 72);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 43);
            this.button1.TabIndex = 57;
            this.button1.Text = "Đăng xuất";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThanhtoan.BackColor = System.Drawing.Color.LightPink;
            this.btnThanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhtoan.Location = new System.Drawing.Point(23, 71);
            this.btnThanhtoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(151, 43);
            this.btnThanhtoan.TabIndex = 58;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.UseVisualStyleBackColor = false;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(635, 66);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tổng tiền cần thanh toán";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(18, 30);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 25);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "0 VNĐ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Pink;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(635, 94);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn hàng";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Pink;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(670, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(16, 601);
            this.panel8.TabIndex = 2;
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Name = "BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.BanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonHang)).EndInit();
            this.panel6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridViewDonHang;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbloaisp;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_san_pham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_san_pham;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanh_tien;
        private System.Windows.Forms.Button button1;
    }
}