namespace SieuThiMini.GUI
{
    partial class KhoiPhucNhaCungCap
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
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.AllowUserToAddRows = false;
            this.dataGridViewSuppliers.AllowUserToDeleteRows = false;
            this.dataGridViewSuppliers.AllowUserToResizeColumns = false;
            this.dataGridViewSuppliers.AllowUserToResizeRows = false;
            this.dataGridViewSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSuppliers.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSuppliers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(0, 142);
            this.dataGridViewSuppliers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.ReadOnly = true;
            this.dataGridViewSuppliers.RowHeadersVisible = false;
            this.dataGridViewSuppliers.RowHeadersWidth = 62;
            this.dataGridViewSuppliers.RowTemplate.Height = 28;
            this.dataGridViewSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(727, 312);
            this.dataGridViewSuppliers.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefesh);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.lblTimKiem);
            this.panel1.Controls.Add(this.btnKhoiPhuc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 142);
            this.panel1.TabIndex = 28;
            // 
            // btnRefesh
            // 
            this.btnRefesh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefesh.Location = new System.Drawing.Point(502, 21);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(100, 42);
            this.btnRefesh.TabIndex = 32;
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(234, 30);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(249, 30);
            this.txtTimKiem.TabIndex = 30;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(123, 30);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(97, 25);
            this.lblTimKiem.TabIndex = 29;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKhoiPhuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.Location = new System.Drawing.Point(297, 78);
            this.btnKhoiPhuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhoiPhuc.MinimumSize = new System.Drawing.Size(114, 32);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(130, 42);
            this.btnKhoiPhuc.TabIndex = 31;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = true;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // KhoiPhucNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(727, 454);
            this.Controls.Add(this.dataGridViewSuppliers);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KhoiPhucNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khôi phục nhà cung cấp";
            this.Load += new System.EventHandler(this.KhoiPhucNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Button btnKhoiPhuc;
    }
}