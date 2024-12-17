namespace SieuThiMini.GUI
{
    partial class ThemSanPham
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbMaLoai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnLuu.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLuu.Location = new System.Drawing.Point(113, 325);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(153, 58);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnHuy.ForeColor = System.Drawing.Color.Crimson;
            this.btnHuy.Location = new System.Drawing.Point(340, 325);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(153, 58);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(54, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 26);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tên sản phẩm:";
            // 
            // cbbMaLoai
            // 
            this.cbbMaLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbbMaLoai.FormattingEnabled = true;
            this.cbbMaLoai.Location = new System.Drawing.Point(264, 97);
            this.cbbMaLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaLoai.Name = "cbbMaLoai";
            this.cbbMaLoai.Size = new System.Drawing.Size(261, 34);
            this.cbbMaLoai.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(54, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(54, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Giá nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(54, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã loại:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtTenSP.Location = new System.Drawing.Point(264, 26);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(261, 32);
            this.txtTenSP.TabIndex = 1;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtGiaNhap.Location = new System.Drawing.Point(264, 242);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(261, 32);
            this.txtGiaNhap.TabIndex = 4;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtGia.Location = new System.Drawing.Point(264, 170);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(261, 32);
            this.txtGia.TabIndex = 3;
            // 
            // ThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(579, 417);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbMaLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThemSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ThemSanPham";
            this.Load += new System.EventHandler(this.ThemSanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbMaLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtGia;
    }
}