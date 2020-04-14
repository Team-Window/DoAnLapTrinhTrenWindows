namespace QuanLiOto
{
    partial class frmChinhSuaDanhSachXeGui
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
            this.lbl_MaVe = new System.Windows.Forms.Label();
            this.txb_MaVe = new System.Windows.Forms.TextBox();
            this.lbl_BienSo = new System.Windows.Forms.Label();
            this.txb_BienSo = new System.Windows.Forms.TextBox();
            this.lbl_LoaiXe = new System.Windows.Forms.Label();
            this.cb_LoaiXe = new System.Windows.Forms.ComboBox();
            this.lbl_HieuXe = new System.Windows.Forms.Label();
            this.txb_HieuXe = new System.Windows.Forms.TextBox();
            this.lbl_HinhAnh = new System.Windows.Forms.Label();
            this.lbl_GioVaoBen = new System.Windows.Forms.Label();
            this.dtp_GioVaoBen = new System.Windows.Forms.DateTimePicker();
            this.lbl_NgayVaoBen = new System.Windows.Forms.Label();
            this.dtp_NgayVaoBen = new System.Windows.Forms.DateTimePicker();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.btn_Download = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            this.lbl_LoaiVe = new System.Windows.Forms.Label();
            this.cb_LoaiVe = new System.Windows.Forms.ComboBox();
            this.BtThanhToan = new System.Windows.Forms.Button();
            this.ptb_HinhAnh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MaVe
            // 
            this.lbl_MaVe.AutoSize = true;
            this.lbl_MaVe.Location = new System.Drawing.Point(22, 41);
            this.lbl_MaVe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_MaVe.Name = "lbl_MaVe";
            this.lbl_MaVe.Size = new System.Drawing.Size(65, 20);
            this.lbl_MaVe.TabIndex = 0;
            this.lbl_MaVe.Text = "Mã vé:";
            // 
            // txb_MaVe
            // 
            this.txb_MaVe.Location = new System.Drawing.Point(192, 31);
            this.txb_MaVe.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txb_MaVe.Name = "txb_MaVe";
            this.txb_MaVe.Size = new System.Drawing.Size(180, 27);
            this.txb_MaVe.TabIndex = 1;
            // 
            // lbl_BienSo
            // 
            this.lbl_BienSo.AutoSize = true;
            this.lbl_BienSo.Location = new System.Drawing.Point(22, 108);
            this.lbl_BienSo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_BienSo.Name = "lbl_BienSo";
            this.lbl_BienSo.Size = new System.Drawing.Size(79, 20);
            this.lbl_BienSo.TabIndex = 2;
            this.lbl_BienSo.Text = "Biển số:";
            // 
            // txb_BienSo
            // 
            this.txb_BienSo.Location = new System.Drawing.Point(192, 102);
            this.txb_BienSo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txb_BienSo.Name = "txb_BienSo";
            this.txb_BienSo.Size = new System.Drawing.Size(180, 27);
            this.txb_BienSo.TabIndex = 3;
            // 
            // lbl_LoaiXe
            // 
            this.lbl_LoaiXe.AutoSize = true;
            this.lbl_LoaiXe.Location = new System.Drawing.Point(22, 189);
            this.lbl_LoaiXe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_LoaiXe.Name = "lbl_LoaiXe";
            this.lbl_LoaiXe.Size = new System.Drawing.Size(76, 20);
            this.lbl_LoaiXe.TabIndex = 4;
            this.lbl_LoaiXe.Text = "Loại xe:";
            // 
            // cb_LoaiXe
            // 
            this.cb_LoaiXe.FormattingEnabled = true;
            this.cb_LoaiXe.Items.AddRange(new object[] {
            "Xe đạp",
            "Xe máy",
            "Xe hơi"});
            this.cb_LoaiXe.Location = new System.Drawing.Point(192, 178);
            this.cb_LoaiXe.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cb_LoaiXe.Name = "cb_LoaiXe";
            this.cb_LoaiXe.Size = new System.Drawing.Size(218, 28);
            this.cb_LoaiXe.TabIndex = 5;
            // 
            // lbl_HieuXe
            // 
            this.lbl_HieuXe.AutoSize = true;
            this.lbl_HieuXe.Location = new System.Drawing.Point(28, 254);
            this.lbl_HieuXe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_HieuXe.Name = "lbl_HieuXe";
            this.lbl_HieuXe.Size = new System.Drawing.Size(79, 20);
            this.lbl_HieuXe.TabIndex = 6;
            this.lbl_HieuXe.Text = "Hiệu xe:";
            // 
            // txb_HieuXe
            // 
            this.txb_HieuXe.Location = new System.Drawing.Point(192, 254);
            this.txb_HieuXe.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txb_HieuXe.Name = "txb_HieuXe";
            this.txb_HieuXe.Size = new System.Drawing.Size(180, 27);
            this.txb_HieuXe.TabIndex = 7;
            // 
            // lbl_HinhAnh
            // 
            this.lbl_HinhAnh.AutoSize = true;
            this.lbl_HinhAnh.Location = new System.Drawing.Point(638, 19);
            this.lbl_HinhAnh.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_HinhAnh.Name = "lbl_HinhAnh";
            this.lbl_HinhAnh.Size = new System.Drawing.Size(90, 20);
            this.lbl_HinhAnh.TabIndex = 9;
            this.lbl_HinhAnh.Text = "Hình ảnh:";
            // 
            // lbl_GioVaoBen
            // 
            this.lbl_GioVaoBen.AutoSize = true;
            this.lbl_GioVaoBen.Location = new System.Drawing.Point(22, 311);
            this.lbl_GioVaoBen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_GioVaoBen.Name = "lbl_GioVaoBen";
            this.lbl_GioVaoBen.Size = new System.Drawing.Size(115, 20);
            this.lbl_GioVaoBen.TabIndex = 10;
            this.lbl_GioVaoBen.Text = "Giờ vào bến:";
            // 
            // dtp_GioVaoBen
            // 
            this.dtp_GioVaoBen.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_GioVaoBen.Location = new System.Drawing.Point(192, 301);
            this.dtp_GioVaoBen.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dtp_GioVaoBen.Name = "dtp_GioVaoBen";
            this.dtp_GioVaoBen.Size = new System.Drawing.Size(180, 27);
            this.dtp_GioVaoBen.TabIndex = 11;
            // 
            // lbl_NgayVaoBen
            // 
            this.lbl_NgayVaoBen.AutoSize = true;
            this.lbl_NgayVaoBen.Location = new System.Drawing.Point(28, 369);
            this.lbl_NgayVaoBen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_NgayVaoBen.Name = "lbl_NgayVaoBen";
            this.lbl_NgayVaoBen.Size = new System.Drawing.Size(128, 20);
            this.lbl_NgayVaoBen.TabIndex = 12;
            this.lbl_NgayVaoBen.Text = "Ngày vào bến:";
            // 
            // dtp_NgayVaoBen
            // 
            this.dtp_NgayVaoBen.Location = new System.Drawing.Point(192, 369);
            this.dtp_NgayVaoBen.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dtp_NgayVaoBen.Name = "dtp_NgayVaoBen";
            this.dtp_NgayVaoBen.Size = new System.Drawing.Size(363, 27);
            this.dtp_NgayVaoBen.TabIndex = 13;
            // 
            // btn_Upload
            // 
            this.btn_Upload.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Upload.Location = new System.Drawing.Point(824, 354);
            this.btn_Upload.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(182, 35);
            this.btn_Upload.TabIndex = 14;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = false;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // btn_Download
            // 
            this.btn_Download.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Download.Location = new System.Drawing.Point(1034, 354);
            this.btn_Download.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(176, 35);
            this.btn_Download.TabIndex = 15;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = false;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Edit.Location = new System.Drawing.Point(406, 475);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(205, 51);
            this.btn_Edit.TabIndex = 16;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.SlateGray;
            this.Remove.Location = new System.Drawing.Point(676, 475);
            this.Remove.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(187, 51);
            this.Remove.TabIndex = 17;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // btn_Find
            // 
            this.btn_Find.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Find.Location = new System.Drawing.Point(386, 26);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(138, 35);
            this.btn_Find.TabIndex = 18;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // lbl_LoaiVe
            // 
            this.lbl_LoaiVe.AutoSize = true;
            this.lbl_LoaiVe.Location = new System.Drawing.Point(33, 428);
            this.lbl_LoaiVe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_LoaiVe.Name = "lbl_LoaiVe";
            this.lbl_LoaiVe.Size = new System.Drawing.Size(76, 20);
            this.lbl_LoaiVe.TabIndex = 19;
            this.lbl_LoaiVe.Text = "Loại vé:";
            // 
            // cb_LoaiVe
            // 
            this.cb_LoaiVe.FormattingEnabled = true;
            this.cb_LoaiVe.Items.AddRange(new object[] {
            "Vé giờ",
            "Vé ngày",
            "Vé tuần",
            "Vé tháng"});
            this.cb_LoaiVe.Location = new System.Drawing.Point(192, 415);
            this.cb_LoaiVe.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cb_LoaiVe.Name = "cb_LoaiVe";
            this.cb_LoaiVe.Size = new System.Drawing.Size(218, 28);
            this.cb_LoaiVe.TabIndex = 20;
            // 
            // BtThanhToan
            // 
            this.BtThanhToan.BackColor = System.Drawing.Color.SlateGray;
            this.BtThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtThanhToan.Location = new System.Drawing.Point(990, 428);
            this.BtThanhToan.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtThanhToan.Name = "BtThanhToan";
            this.BtThanhToan.Size = new System.Drawing.Size(220, 98);
            this.BtThanhToan.TabIndex = 22;
            this.BtThanhToan.Text = "THANH TOÁN";
            this.BtThanhToan.UseVisualStyleBackColor = false;
            this.BtThanhToan.Click += new System.EventHandler(this.BtThanhToan_Click);
            // 
            // ptb_HinhAnh
            // 
            this.ptb_HinhAnh.Location = new System.Drawing.Point(780, 19);
            this.ptb_HinhAnh.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ptb_HinhAnh.Name = "ptb_HinhAnh";
            this.ptb_HinhAnh.Size = new System.Drawing.Size(463, 326);
            this.ptb_HinhAnh.TabIndex = 8;
            this.ptb_HinhAnh.TabStop = false;
            // 
            // frmChinhSuaDanhSachXeGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 545);
            this.Controls.Add(this.BtThanhToan);
            this.Controls.Add(this.cb_LoaiVe);
            this.Controls.Add(this.lbl_LoaiVe);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.dtp_NgayVaoBen);
            this.Controls.Add(this.lbl_NgayVaoBen);
            this.Controls.Add(this.dtp_GioVaoBen);
            this.Controls.Add(this.lbl_GioVaoBen);
            this.Controls.Add(this.lbl_HinhAnh);
            this.Controls.Add(this.ptb_HinhAnh);
            this.Controls.Add(this.txb_HieuXe);
            this.Controls.Add(this.lbl_HieuXe);
            this.Controls.Add(this.cb_LoaiXe);
            this.Controls.Add(this.lbl_LoaiXe);
            this.Controls.Add(this.txb_BienSo);
            this.Controls.Add(this.lbl_BienSo);
            this.Controls.Add(this.txb_MaVe);
            this.Controls.Add(this.lbl_MaVe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmChinhSuaDanhSachXeGui";
            this.Text = "frmDanhSachXeGui";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MaVe;
        public System.Windows.Forms.TextBox txb_MaVe;
        private System.Windows.Forms.Label lbl_BienSo;
        public System.Windows.Forms.TextBox txb_BienSo;
        private System.Windows.Forms.Label lbl_LoaiXe;
        public System.Windows.Forms.ComboBox cb_LoaiXe;
        private System.Windows.Forms.Label lbl_HieuXe;
        public System.Windows.Forms.TextBox txb_HieuXe;
        public System.Windows.Forms.PictureBox ptb_HinhAnh;
        private System.Windows.Forms.Label lbl_HinhAnh;
        private System.Windows.Forms.Label lbl_GioVaoBen;
        public System.Windows.Forms.DateTimePicker dtp_GioVaoBen;
        private System.Windows.Forms.Label lbl_NgayVaoBen;
        public System.Windows.Forms.DateTimePicker dtp_NgayVaoBen;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Label lbl_LoaiVe;
        private System.Windows.Forms.Button BtThanhToan;
        internal System.Windows.Forms.ComboBox cb_LoaiVe;
    }
}