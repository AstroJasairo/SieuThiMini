namespace SieuThiMini.GUI
{
    partial class KhoiPhucNhanVien
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
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.AllowUserToAddRows = false;
            this.dataGridViewNhanVien.AllowUserToDeleteRows = false;
            this.dataGridViewNhanVien.AllowUserToResizeColumns = false;
            this.dataGridViewNhanVien.AllowUserToResizeRows = false;
            this.dataGridViewNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNhanVien.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNhanVien.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(0, 144);
            this.dataGridViewNhanVien.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.ReadOnly = true;
            this.dataGridViewNhanVien.RowHeadersVisible = false;
            this.dataGridViewNhanVien.RowHeadersWidth = 62;
            this.dataGridViewNhanVien.RowTemplate.Height = 28;
            this.dataGridViewNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(800, 306);
            this.dataGridViewNhanVien.TabIndex = 44;
            this.dataGridViewNhanVien.TabStop = false;
            this.dataGridViewNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhanVien_CellContentClick);
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackColor = System.Drawing.Color.LightPink;
            this.btnRefesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefesh.Location = new System.Drawing.Point(432, 74);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(161, 49);
            this.btnRefesh.TabIndex = 42;
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.UseVisualStyleBackColor = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(153, 18);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(597, 30);
            this.txtTimKiem.TabIndex = 40;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.LightPink;
            this.btnKhoiPhuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.Location = new System.Drawing.Point(205, 74);
            this.btnKhoiPhuc.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnKhoiPhuc.MinimumSize = new System.Drawing.Size(113, 32);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(176, 49);
            this.btnKhoiPhuc.TabIndex = 41;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(28, 20);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(97, 25);
            this.lblTimKiem.TabIndex = 43;
            this.lblTimKiem.Text = "Tìm kiếm:";
            this.lblTimKiem.Click += new System.EventHandler(this.lblTimKiem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefesh);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnKhoiPhuc);
            this.panel1.Controls.Add(this.lblTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 144);
            this.panel1.TabIndex = 45;
            // 
            // KhoiPhucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewNhanVien);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KhoiPhucNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khôi phục nhân viên";
            this.Load += new System.EventHandler(this.KhoiPhucNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Panel panel1;
    }
}