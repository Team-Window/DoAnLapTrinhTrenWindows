namespace QuanLiOto.QLThueXe
{
    partial class FrmXecuaCongTy
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
            this.lbl_GiayPhepXe = new System.Windows.Forms.Label();
            this.cb_loaihopdong = new System.Windows.Forms.ComboBox();
            this.lbl_HieuXe = new System.Windows.Forms.Label();
            this.txb_HieuXe = new System.Windows.Forms.TextBox();
            this.btn_Download = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.txb_BienSo = new System.Windows.Forms.TextBox();
            this.cb_LoaiXe = new System.Windows.Forms.ComboBox();
            this.lbl_Anh = new System.Windows.Forms.Label();
            this.lbl_BienSo = new System.Windows.Forms.Label();
            this.lbl_LoaiXe = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.ptb_Anh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Anh)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_GiayPhepXe
            // 
            this.lbl_GiayPhepXe.AutoSize = true;
            this.lbl_GiayPhepXe.Location = new System.Drawing.Point(18, 152);
            this.lbl_GiayPhepXe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GiayPhepXe.Name = "lbl_GiayPhepXe";
            this.lbl_GiayPhepXe.Size = new System.Drawing.Size(103, 17);
            this.lbl_GiayPhepXe.TabIndex = 42;
            this.lbl_GiayPhepXe.Text = "Loại hợp đồng:";
            // 
            // cb_loaihopdong
            // 
            this.cb_loaihopdong.FormattingEnabled = true;
            this.cb_loaihopdong.Items.AddRange(new object[] {
            "Công ty"});
            this.cb_loaihopdong.Location = new System.Drawing.Point(188, 152);
            this.cb_loaihopdong.Margin = new System.Windows.Forms.Padding(4);
            this.cb_loaihopdong.Name = "cb_loaihopdong";
            this.cb_loaihopdong.Size = new System.Drawing.Size(185, 24);
            this.cb_loaihopdong.TabIndex = 41;
            // 
            // lbl_HieuXe
            // 
            this.lbl_HieuXe.AutoSize = true;
            this.lbl_HieuXe.Location = new System.Drawing.Point(14, 85);
            this.lbl_HieuXe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HieuXe.Name = "lbl_HieuXe";
            this.lbl_HieuXe.Size = new System.Drawing.Size(62, 17);
            this.lbl_HieuXe.TabIndex = 40;
            this.lbl_HieuXe.Text = "Hiệu Xe:";
            // 
            // txb_HieuXe
            // 
            this.txb_HieuXe.Location = new System.Drawing.Point(188, 85);
            this.txb_HieuXe.Margin = new System.Windows.Forms.Padding(4);
            this.txb_HieuXe.Name = "txb_HieuXe";
            this.txb_HieuXe.Size = new System.Drawing.Size(185, 22);
            this.txb_HieuXe.TabIndex = 39;
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(284, 326);
            this.btn_Download.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(91, 28);
            this.btn_Download.TabIndex = 38;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(188, 326);
            this.btn_Upload.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(88, 28);
            this.btn_Upload.TabIndex = 37;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // txb_BienSo
            // 
            this.txb_BienSo.Location = new System.Drawing.Point(188, 117);
            this.txb_BienSo.Margin = new System.Windows.Forms.Padding(4);
            this.txb_BienSo.Name = "txb_BienSo";
            this.txb_BienSo.Size = new System.Drawing.Size(185, 22);
            this.txb_BienSo.TabIndex = 35;
            // 
            // cb_LoaiXe
            // 
            this.cb_LoaiXe.FormattingEnabled = true;
            this.cb_LoaiXe.Items.AddRange(new object[] {
            "Xe đạp",
            "Xe máy",
            "Xe  hơi"});
            this.cb_LoaiXe.Location = new System.Drawing.Point(188, 45);
            this.cb_LoaiXe.Margin = new System.Windows.Forms.Padding(4);
            this.cb_LoaiXe.Name = "cb_LoaiXe";
            this.cb_LoaiXe.Size = new System.Drawing.Size(185, 24);
            this.cb_LoaiXe.TabIndex = 34;
            // 
            // lbl_Anh
            // 
            this.lbl_Anh.AutoSize = true;
            this.lbl_Anh.Location = new System.Drawing.Point(18, 184);
            this.lbl_Anh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Anh.Name = "lbl_Anh";
            this.lbl_Anh.Size = new System.Drawing.Size(37, 17);
            this.lbl_Anh.TabIndex = 33;
            this.lbl_Anh.Text = "Ảnh:";
            // 
            // lbl_BienSo
            // 
            this.lbl_BienSo.AutoSize = true;
            this.lbl_BienSo.Location = new System.Drawing.Point(18, 117);
            this.lbl_BienSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BienSo.Name = "lbl_BienSo";
            this.lbl_BienSo.Size = new System.Drawing.Size(61, 17);
            this.lbl_BienSo.TabIndex = 32;
            this.lbl_BienSo.Text = "Biển Số:";
            // 
            // lbl_LoaiXe
            // 
            this.lbl_LoaiXe.AutoSize = true;
            this.lbl_LoaiXe.Location = new System.Drawing.Point(13, 45);
            this.lbl_LoaiXe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LoaiXe.Name = "lbl_LoaiXe";
            this.lbl_LoaiXe.Size = new System.Drawing.Size(60, 17);
            this.lbl_LoaiXe.TabIndex = 31;
            this.lbl_LoaiXe.Text = "Loại Xe:";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(21, 366);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(161, 57);
            this.btn_Them.TabIndex = 43;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // ptb_Anh
            // 
            this.ptb_Anh.Location = new System.Drawing.Point(188, 184);
            this.ptb_Anh.Margin = new System.Windows.Forms.Padding(4);
            this.ptb_Anh.Name = "ptb_Anh";
            this.ptb_Anh.Size = new System.Drawing.Size(187, 134);
            this.ptb_Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Anh.TabIndex = 36;
            this.ptb_Anh.TabStop = false;
            // 
            // FrmXecuaCongTy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 584);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.lbl_GiayPhepXe);
            this.Controls.Add(this.cb_loaihopdong);
            this.Controls.Add(this.lbl_HieuXe);
            this.Controls.Add(this.txb_HieuXe);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.ptb_Anh);
            this.Controls.Add(this.txb_BienSo);
            this.Controls.Add(this.cb_LoaiXe);
            this.Controls.Add(this.lbl_Anh);
            this.Controls.Add(this.lbl_BienSo);
            this.Controls.Add(this.lbl_LoaiXe);
            this.Name = "FrmXecuaCongTy";
            this.Text = "FrmXecuaCongTy";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Anh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_GiayPhepXe;
        private System.Windows.Forms.ComboBox cb_loaihopdong;
        private System.Windows.Forms.Label lbl_HieuXe;
        private System.Windows.Forms.TextBox txb_HieuXe;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.PictureBox ptb_Anh;
        private System.Windows.Forms.TextBox txb_BienSo;
        private System.Windows.Forms.ComboBox cb_LoaiXe;
        private System.Windows.Forms.Label lbl_Anh;
        private System.Windows.Forms.Label lbl_BienSo;
        private System.Windows.Forms.Label lbl_LoaiXe;
        private System.Windows.Forms.Button btn_Them;
    }
}