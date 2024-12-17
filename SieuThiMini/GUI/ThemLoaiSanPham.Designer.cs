namespace SieuThiMini.GUI
{
    partial class ThemLoaiSanPham
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
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_TenLoai = new System.Windows.Forms.TextBox();
            this.cb_MaNcc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.White;
            this.btn_Huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Huy.Location = new System.Drawing.Point(352, 156);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(100, 42);
            this.btn_Huy.TabIndex = 20;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.White;
            this.btn_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Them.Location = new System.Drawing.Point(236, 156);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(100, 42);
            this.btn_Them.TabIndex = 21;
            this.btn_Them.Text = "Lưu";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tên loại sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã nhà cung cấp:";
            // 
            // tb_TenLoai
            // 
            this.tb_TenLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenLoai.Location = new System.Drawing.Point(236, 90);
            this.tb_TenLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TenLoai.Name = "tb_TenLoai";
            this.tb_TenLoai.Size = new System.Drawing.Size(216, 30);
            this.tb_TenLoai.TabIndex = 32;
            this.tb_TenLoai.TextChanged += new System.EventHandler(this.txtTenSP_TextChanged);
            // 
            // cb_MaNcc
            // 
            this.cb_MaNcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MaNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MaNcc.FormattingEnabled = true;
            this.cb_MaNcc.Location = new System.Drawing.Point(236, 43);
            this.cb_MaNcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_MaNcc.Name = "cb_MaNcc";
            this.cb_MaNcc.Size = new System.Drawing.Size(216, 33);
            this.cb_MaNcc.TabIndex = 33;
            // 
            // ThemLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(487, 242);
            this.Controls.Add(this.cb_MaNcc);
            this.Controls.Add(this.tb_TenLoai);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemLoaiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ThemLoaiSanPham";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_TenLoai;
        private System.Windows.Forms.ComboBox cb_MaNcc;
    }
}