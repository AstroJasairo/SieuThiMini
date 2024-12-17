namespace SieuThiMini.GUI
{
    partial class QuanLyNhaCungCap
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
            this.dataGridViewNhaCungCap = new System.Windows.Forms.DataGridView();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.txtTenncc = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMancc = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhaCungCap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewNhaCungCap
            // 
            this.dataGridViewNhaCungCap.AllowUserToAddRows = false;
            this.dataGridViewNhaCungCap.AllowUserToDeleteRows = false;
            this.dataGridViewNhaCungCap.AllowUserToResizeColumns = false;
            this.dataGridViewNhaCungCap.AllowUserToResizeRows = false;
            this.dataGridViewNhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNhaCungCap.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridViewNhaCungCap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNhaCungCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNhaCungCap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNhaCungCap.Location = new System.Drawing.Point(0, 319);
            this.dataGridViewNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewNhaCungCap.Name = "dataGridViewNhaCungCap";
            this.dataGridViewNhaCungCap.ReadOnly = true;
            this.dataGridViewNhaCungCap.RowHeadersVisible = false;
            this.dataGridViewNhaCungCap.RowHeadersWidth = 62;
            this.dataGridViewNhaCungCap.RowTemplate.Height = 28;
            this.dataGridViewNhaCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNhaCungCap.Size = new System.Drawing.Size(1200, 414);
            this.dataGridViewNhaCungCap.TabIndex = 3;
            this.dataGridViewNhaCungCap.TabStop = false;
            this.dataGridViewNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhaCungCap_CellClick);
            this.dataGridViewNhaCungCap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhaCungCap_CellContentClick);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(604, 102);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(295, 30);
            this.txtDiachi.TabIndex = 2;
            this.txtDiachi.TextChanged += new System.EventHandler(this.txtDiachi_TextChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(462, 147);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 41);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(386, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "Mã nhà cung cấp:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(604, 147);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(110, 41);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(386, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 48;
            this.label5.Text = "Tên nhà cung cấp:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(386, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Địa chỉ:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefesh.BackColor = System.Drawing.Color.LightPink;
            this.btnRefesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefesh.Location = new System.Drawing.Point(932, 198);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(117, 43);
            this.btnRefesh.TabIndex = 6;
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.UseVisualStyleBackColor = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(302, 206);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(600, 30);
            this.txtTimKiem.TabIndex = 5;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.LightBlue;
            this.btnKhoiPhuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhoiPhuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.Location = new System.Drawing.Point(756, 261);
            this.btnKhoiPhuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhoiPhuc.MinimumSize = new System.Drawing.Size(114, 32);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(142, 43);
            this.btnKhoiPhuc.TabIndex = 10;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // txtTenncc
            // 
            this.txtTenncc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenncc.Location = new System.Drawing.Point(604, 63);
            this.txtTenncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenncc.Name = "txtTenncc";
            this.txtTenncc.Size = new System.Drawing.Size(295, 30);
            this.txtTenncc.TabIndex = 1;
            this.txtTenncc.TextChanged += new System.EventHandler(this.txtTenncc_TextChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(182, 208);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(97, 25);
            this.lblTimKiem.TabIndex = 51;
            this.lblTimKiem.Text = "Tìm kiếm:";
            this.lblTimKiem.Click += new System.EventHandler(this.lblTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.BackColor = System.Drawing.Color.HotPink;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(453, 261);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 43);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.BackColor = System.Drawing.Color.LightYellow;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(604, 261);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(117, 43);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.txtMancc);
            this.panel1.Controls.Add(this.txtDiachi);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnRefesh);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnKhoiPhuc);
            this.panel1.Controls.Add(this.txtTenncc);
            this.panel1.Controls.Add(this.lblTimKiem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 319);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtMancc
            // 
            this.txtMancc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMancc.Enabled = false;
            this.txtMancc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMancc.Location = new System.Drawing.Point(603, 24);
            this.txtMancc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMancc.Name = "txtMancc";
            this.txtMancc.Size = new System.Drawing.Size(120, 30);
            this.txtMancc.TabIndex = 62;
            this.txtMancc.TabStop = false;
            this.txtMancc.TextChanged += new System.EventHandler(this.txtMancc_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.BackColor = System.Drawing.Color.LightGreen;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(302, 261);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 43);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // QuanLyNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 733);
            this.Controls.Add(this.dataGridViewNhaCungCap);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyNhaCungCap";
            this.Text = "QuanLyNhaCungCap";
            this.Load += new System.EventHandler(this.QuanLyNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhaCungCap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNhaCungCap;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.TextBox txtTenncc;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMancc;
    }
}