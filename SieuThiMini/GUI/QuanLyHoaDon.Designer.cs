namespace SieuThiMini.GUI
{
    partial class QuanLyHoaDon
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
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.dataGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefesh
            // 
            this.btnRefesh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefesh.BackColor = System.Drawing.Color.LightPink;
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
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.LightBlue;
            this.btnKhoiPhuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.Location = new System.Drawing.Point(513, 87);
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
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Location = new System.Drawing.Point(687, 87);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(142, 43);
            this.btnXuatExcel.TabIndex = 54;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // dataGridViewHoaDon
            // 
            this.dataGridViewHoaDon.AllowUserToAddRows = false;
            this.dataGridViewHoaDon.AllowUserToDeleteRows = false;
            this.dataGridViewHoaDon.AllowUserToResizeColumns = false;
            this.dataGridViewHoaDon.AllowUserToResizeRows = false;
            this.dataGridViewHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHoaDon.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridViewHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHoaDon.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHoaDon.Location = new System.Drawing.Point(0, 154);
            this.dataGridViewHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            this.dataGridViewHoaDon.ReadOnly = true;
            this.dataGridViewHoaDon.RowHeadersVisible = false;
            this.dataGridViewHoaDon.RowHeadersWidth = 62;
            this.dataGridViewHoaDon.RowTemplate.Height = 28;
            this.dataGridViewHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHoaDon.Size = new System.Drawing.Size(1200, 579);
            this.dataGridViewHoaDon.TabIndex = 7;
            this.dataGridViewHoaDon.TabStop = false;
            this.dataGridViewHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHoaDon_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnRefesh);
            this.panel1.Controls.Add(this.btnKhoiPhuc);
            this.panel1.Controls.Add(this.lblTimKiem);
            this.panel1.Controls.Add(this.btnXuatExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 154);
            this.panel1.TabIndex = 6;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.Color.HotPink;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(346, 87);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 43);
            this.btnXoa.TabIndex = 58;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(279, 32);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(613, 30);
            this.txtTimKiem.TabIndex = 59;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 733);
            this.Controls.Add(this.dataGridViewHoaDon);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyHoaDon";
            this.Text = "QuanLyHoaDon";
            this.Load += new System.EventHandler(this.QuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.DataGridView dataGridViewHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}