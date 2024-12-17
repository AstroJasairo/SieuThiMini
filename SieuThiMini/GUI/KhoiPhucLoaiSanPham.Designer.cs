namespace SieuThiMini.GUI
{
    partial class KhoiPhucLoaiSanPham
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
            this.dataGridViewLoaiSanPham = new System.Windows.Forms.DataGridView();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiSanPham)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewLoaiSanPham
            // 
            this.dataGridViewLoaiSanPham.AllowUserToAddRows = false;
            this.dataGridViewLoaiSanPham.AllowUserToDeleteRows = false;
            this.dataGridViewLoaiSanPham.AllowUserToResizeColumns = false;
            this.dataGridViewLoaiSanPham.AllowUserToResizeRows = false;
            this.dataGridViewLoaiSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLoaiSanPham.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridViewLoaiSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLoaiSanPham.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLoaiSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLoaiSanPham.Location = new System.Drawing.Point(0, 143);
            this.dataGridViewLoaiSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewLoaiSanPham.Name = "dataGridViewLoaiSanPham";
            this.dataGridViewLoaiSanPham.ReadOnly = true;
            this.dataGridViewLoaiSanPham.RowHeadersVisible = false;
            this.dataGridViewLoaiSanPham.RowHeadersWidth = 62;
            this.dataGridViewLoaiSanPham.RowTemplate.Height = 28;
            this.dataGridViewLoaiSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLoaiSanPham.Size = new System.Drawing.Size(747, 310);
            this.dataGridViewLoaiSanPham.TabIndex = 39;
            this.dataGridViewLoaiSanPham.TabStop = false;
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackColor = System.Drawing.Color.LightPink;
            this.btnRefesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefesh.Location = new System.Drawing.Point(409, 86);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(162, 50);
            this.btnRefesh.TabIndex = 3;
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.UseVisualStyleBackColor = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(108, 29);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(598, 30);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.LightPink;
            this.btnKhoiPhuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.Location = new System.Drawing.Point(182, 86);
            this.btnKhoiPhuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhoiPhuc.MinimumSize = new System.Drawing.Size(114, 32);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(176, 50);
            this.btnKhoiPhuc.TabIndex = 2;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(5, 32);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(97, 25);
            this.lblTimKiem.TabIndex = 35;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefesh);
            this.panel1.Controls.Add(this.btnKhoiPhuc);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.lblTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 143);
            this.panel1.TabIndex = 40;
            // 
            // KhoiPhucLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(747, 453);
            this.Controls.Add(this.dataGridViewLoaiSanPham);
            this.Controls.Add(this.panel1);
            this.Name = "KhoiPhucLoaiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khôi phục loại sản phẩm";
            this.Load += new System.EventHandler(this.KhoiPhucLoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiSanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLoaiSanPham;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Panel panel1;
    }
}