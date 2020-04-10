namespace QuanLiOto
{
    partial class frmThongKe
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
            this.pn_TongSoLuongPhuongTien = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_XeDap = new System.Windows.Forms.Panel();
            this.pn_XeMay = new System.Windows.Forms.Panel();
            this.pn_XeHoi = new System.Windows.Forms.Panel();
            this.pn_TongSoLuongPhuongTien.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_TongSoLuongPhuongTien
            // 
            this.pn_TongSoLuongPhuongTien.BackColor = System.Drawing.Color.LightCoral;
            this.pn_TongSoLuongPhuongTien.Controls.Add(this.panel1);
            this.pn_TongSoLuongPhuongTien.Location = new System.Drawing.Point(12, 12);
            this.pn_TongSoLuongPhuongTien.Name = "pn_TongSoLuongPhuongTien";
            this.pn_TongSoLuongPhuongTien.Size = new System.Drawing.Size(414, 181);
            this.pn_TongSoLuongPhuongTien.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // pn_XeDap
            // 
            this.pn_XeDap.BackColor = System.Drawing.Color.BurlyWood;
            this.pn_XeDap.Location = new System.Drawing.Point(15, 196);
            this.pn_XeDap.Name = "pn_XeDap";
            this.pn_XeDap.Size = new System.Drawing.Size(134, 100);
            this.pn_XeDap.TabIndex = 1;
            // 
            // pn_XeMay
            // 
            this.pn_XeMay.BackColor = System.Drawing.Color.YellowGreen;
            this.pn_XeMay.Location = new System.Drawing.Point(155, 196);
            this.pn_XeMay.Name = "pn_XeMay";
            this.pn_XeMay.Size = new System.Drawing.Size(138, 100);
            this.pn_XeMay.TabIndex = 2;
            // 
            // pn_XeHoi
            // 
            this.pn_XeHoi.BackColor = System.Drawing.Color.SpringGreen;
            this.pn_XeHoi.Location = new System.Drawing.Point(299, 196);
            this.pn_XeHoi.Name = "pn_XeHoi";
            this.pn_XeHoi.Size = new System.Drawing.Size(127, 100);
            this.pn_XeHoi.TabIndex = 3;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 344);
            this.Controls.Add(this.pn_XeHoi);
            this.Controls.Add(this.pn_XeMay);
            this.Controls.Add(this.pn_XeDap);
            this.Controls.Add(this.pn_TongSoLuongPhuongTien);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.pn_TongSoLuongPhuongTien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_TongSoLuongPhuongTien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn_XeDap;
        private System.Windows.Forms.Panel pn_XeMay;
        private System.Windows.Forms.Panel pn_XeHoi;
    }
}