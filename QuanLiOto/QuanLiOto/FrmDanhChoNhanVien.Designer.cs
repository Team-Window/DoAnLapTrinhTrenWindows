namespace QuanLiOto
{
    partial class FrmDanhChoNhanVien
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
            this.lbl_DanhChoNhanVien = new System.Windows.Forms.Label();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.lbl_DKLamViec = new System.Windows.Forms.Label();
            this.lbl_LuongThuong = new System.Windows.Forms.Label();
            this.btn_XemLuong = new System.Windows.Forms.Button();
            this.btn_LamViec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_DanhChoNhanVien
            // 
            this.lbl_DanhChoNhanVien.AutoSize = true;
            this.lbl_DanhChoNhanVien.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DanhChoNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_DanhChoNhanVien.Location = new System.Drawing.Point(162, 9);
            this.lbl_DanhChoNhanVien.Name = "lbl_DanhChoNhanVien";
            this.lbl_DanhChoNhanVien.Size = new System.Drawing.Size(273, 50);
            this.lbl_DanhChoNhanVien.TabIndex = 0;
            this.lbl_DanhChoNhanVien.Text = "Nhân Viên";
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.Location = new System.Drawing.Point(244, 249);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(131, 58);
            this.btn_LogOut.TabIndex = 3;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // lbl_DKLamViec
            // 
            this.lbl_DKLamViec.AutoSize = true;
            this.lbl_DKLamViec.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DKLamViec.Location = new System.Drawing.Point(12, 90);
            this.lbl_DKLamViec.Name = "lbl_DKLamViec";
            this.lbl_DKLamViec.Size = new System.Drawing.Size(223, 26);
            this.lbl_DKLamViec.TabIndex = 1;
            this.lbl_DKLamViec.Text = "Đăng Ký Lịch Làm Việc";
            // 
            // lbl_LuongThuong
            // 
            this.lbl_LuongThuong.AutoSize = true;
            this.lbl_LuongThuong.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LuongThuong.Location = new System.Drawing.Point(321, 90);
            this.lbl_LuongThuong.Name = "lbl_LuongThuong";
            this.lbl_LuongThuong.Size = new System.Drawing.Size(187, 26);
            this.lbl_LuongThuong.TabIndex = 4;
            this.lbl_LuongThuong.Text = "Xem Lương Thưởng";
            // 
            // btn_XemLuong
            // 
            this.btn_XemLuong.BackgroundImage = global::QuanLiOto.Properties.Resources.luong;
            this.btn_XemLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_XemLuong.Location = new System.Drawing.Point(369, 143);
            this.btn_XemLuong.Name = "btn_XemLuong";
            this.btn_XemLuong.Size = new System.Drawing.Size(112, 45);
            this.btn_XemLuong.TabIndex = 5;
            this.btn_XemLuong.UseVisualStyleBackColor = true;
            // 
            // btn_LamViec
            // 
            this.btn_LamViec.BackgroundImage = global::QuanLiOto.Properties.Resources.lamviec;
            this.btn_LamViec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_LamViec.Location = new System.Drawing.Point(42, 143);
            this.btn_LamViec.Name = "btn_LamViec";
            this.btn_LamViec.Size = new System.Drawing.Size(118, 57);
            this.btn_LamViec.TabIndex = 2;
            this.btn_LamViec.UseVisualStyleBackColor = true;
            this.btn_LamViec.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // FrmDanhChoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 352);
            this.Controls.Add(this.btn_XemLuong);
            this.Controls.Add(this.lbl_LuongThuong);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_LamViec);
            this.Controls.Add(this.lbl_DKLamViec);
            this.Controls.Add(this.lbl_DanhChoNhanVien);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "FrmDanhChoNhanVien";
            this.Text = "FrmDanhChoNhanVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DanhChoNhanVien;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_LamViec;
        private System.Windows.Forms.Label lbl_DKLamViec;
        private System.Windows.Forms.Label lbl_LuongThuong;
        private System.Windows.Forms.Button btn_XemLuong;
    }
}