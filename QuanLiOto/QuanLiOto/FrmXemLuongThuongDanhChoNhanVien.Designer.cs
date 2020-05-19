namespace QuanLiOto
{
    partial class FrmXemLuongThuongDanhChoNhanVien
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
            this.dtgv_BangLuong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DanhChoNhanVien
            // 
            this.lbl_DanhChoNhanVien.AutoSize = true;
            this.lbl_DanhChoNhanVien.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DanhChoNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_DanhChoNhanVien.Location = new System.Drawing.Point(212, 9);
            this.lbl_DanhChoNhanVien.Name = "lbl_DanhChoNhanVien";
            this.lbl_DanhChoNhanVien.Size = new System.Drawing.Size(288, 50);
            this.lbl_DanhChoNhanVien.TabIndex = 1;
            this.lbl_DanhChoNhanVien.Text = "Bảng Lương";
            // 
            // dtgv_BangLuong
            // 
            this.dtgv_BangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_BangLuong.Location = new System.Drawing.Point(-3, 73);
            this.dtgv_BangLuong.Name = "dtgv_BangLuong";
            this.dtgv_BangLuong.Size = new System.Drawing.Size(715, 225);
            this.dtgv_BangLuong.TabIndex = 2;
            // 
            // FrmXemLuongThuongDanhChoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 299);
            this.Controls.Add(this.dtgv_BangLuong);
            this.Controls.Add(this.lbl_DanhChoNhanVien);
            this.Name = "FrmXemLuongThuongDanhChoNhanVien";
            this.Text = "FrmXemLuongThuongDanhChoNhanVien";
            this.Load += new System.EventHandler(this.FrmXemLuongThuongDanhChoNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BangLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DanhChoNhanVien;
        private System.Windows.Forms.DataGridView dtgv_BangLuong;
    }
}