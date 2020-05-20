namespace QuanLiOto
{
    partial class FrmDanhChoQuanLi
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
            this.lbl_DKLamViec = new System.Windows.Forms.Label();
            this.lbl_DanhChoQuanLi = new System.Windows.Forms.Label();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.lbl_ThanhToanLuong = new System.Windows.Forms.Label();
            this.lbl_BangPhanCong = new System.Windows.Forms.Label();
            this.btn_BangPhanCong = new System.Windows.Forms.Button();
            this.btn_XemLuong = new System.Windows.Forms.Button();
            this.btn_DKLichLamViec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_DKLamViec
            // 
            this.lbl_DKLamViec.AutoSize = true;
            this.lbl_DKLamViec.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DKLamViec.Location = new System.Drawing.Point(12, 88);
            this.lbl_DKLamViec.Name = "lbl_DKLamViec";
            this.lbl_DKLamViec.Size = new System.Drawing.Size(223, 26);
            this.lbl_DKLamViec.TabIndex = 3;
            this.lbl_DKLamViec.Text = "Đăng Ký Lịch Làm Việc";
            // 
            // lbl_DanhChoQuanLi
            // 
            this.lbl_DanhChoQuanLi.AutoSize = true;
            this.lbl_DanhChoQuanLi.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DanhChoQuanLi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_DanhChoQuanLi.Location = new System.Drawing.Point(208, 21);
            this.lbl_DanhChoQuanLi.Name = "lbl_DanhChoQuanLi";
            this.lbl_DanhChoQuanLi.Size = new System.Drawing.Size(202, 50);
            this.lbl_DanhChoQuanLi.TabIndex = 2;
            this.lbl_DanhChoQuanLi.Text = "Quản Lí";
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.Location = new System.Drawing.Point(253, 248);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(131, 58);
            this.btn_LogOut.TabIndex = 5;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // lbl_ThanhToanLuong
            // 
            this.lbl_ThanhToanLuong.AutoSize = true;
            this.lbl_ThanhToanLuong.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThanhToanLuong.Location = new System.Drawing.Point(281, 88);
            this.lbl_ThanhToanLuong.Name = "lbl_ThanhToanLuong";
            this.lbl_ThanhToanLuong.Size = new System.Drawing.Size(183, 26);
            this.lbl_ThanhToanLuong.TabIndex = 6;
            this.lbl_ThanhToanLuong.Text = "Thanh Toán Lương";
            // 
            // lbl_BangPhanCong
            // 
            this.lbl_BangPhanCong.AutoSize = true;
            this.lbl_BangPhanCong.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BangPhanCong.Location = new System.Drawing.Point(499, 88);
            this.lbl_BangPhanCong.Name = "lbl_BangPhanCong";
            this.lbl_BangPhanCong.Size = new System.Drawing.Size(159, 26);
            this.lbl_BangPhanCong.TabIndex = 8;
            this.lbl_BangPhanCong.Text = "Bảng Phân Công";
            // 
            // btn_BangPhanCong
            // 
            this.btn_BangPhanCong.BackgroundImage = global::QuanLiOto.Properties.Resources.phancong;
            this.btn_BangPhanCong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BangPhanCong.Location = new System.Drawing.Point(516, 133);
            this.btn_BangPhanCong.Name = "btn_BangPhanCong";
            this.btn_BangPhanCong.Size = new System.Drawing.Size(118, 44);
            this.btn_BangPhanCong.TabIndex = 9;
            this.btn_BangPhanCong.UseVisualStyleBackColor = true;
            this.btn_BangPhanCong.Click += new System.EventHandler(this.btn_BangPhanCong_Click);
            // 
            // btn_XemLuong
            // 
            this.btn_XemLuong.BackgroundImage = global::QuanLiOto.Properties.Resources.luong;
            this.btn_XemLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_XemLuong.Location = new System.Drawing.Point(307, 132);
            this.btn_XemLuong.Name = "btn_XemLuong";
            this.btn_XemLuong.Size = new System.Drawing.Size(112, 45);
            this.btn_XemLuong.TabIndex = 7;
            this.btn_XemLuong.UseVisualStyleBackColor = true;
            this.btn_XemLuong.Click += new System.EventHandler(this.btn_XemLuong_Click);
            // 
            // btn_DKLichLamViec
            // 
            this.btn_DKLichLamViec.BackgroundImage = global::QuanLiOto.Properties.Resources.dklichlamviec;
            this.btn_DKLichLamViec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DKLichLamViec.Location = new System.Drawing.Point(50, 133);
            this.btn_DKLichLamViec.Name = "btn_DKLichLamViec";
            this.btn_DKLichLamViec.Size = new System.Drawing.Size(114, 44);
            this.btn_DKLichLamViec.TabIndex = 4;
            this.btn_DKLichLamViec.UseVisualStyleBackColor = true;
            this.btn_DKLichLamViec.Click += new System.EventHandler(this.btn_DKLichLamViec_Click);
            // 
            // FrmDanhChoQuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 349);
            this.Controls.Add(this.btn_BangPhanCong);
            this.Controls.Add(this.lbl_BangPhanCong);
            this.Controls.Add(this.btn_XemLuong);
            this.Controls.Add(this.lbl_ThanhToanLuong);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_DKLichLamViec);
            this.Controls.Add(this.lbl_DKLamViec);
            this.Controls.Add(this.lbl_DanhChoQuanLi);
            this.Name = "FrmDanhChoQuanLi";
            this.Text = "FrmDanhChoQuanLi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DKLamViec;
        private System.Windows.Forms.Label lbl_DanhChoQuanLi;
        private System.Windows.Forms.Button btn_DKLichLamViec;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Label lbl_ThanhToanLuong;
        private System.Windows.Forms.Button btn_XemLuong;
        private System.Windows.Forms.Label lbl_BangPhanCong;
        private System.Windows.Forms.Button btn_BangPhanCong;
    }
}