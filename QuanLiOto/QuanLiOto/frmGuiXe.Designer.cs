namespace QuanLiOto
{
    partial class frmGuiXe
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
            this.lbl_HieuXe = new System.Windows.Forms.Label();
            this.lbl_HinhAnh = new System.Windows.Forms.Label();
            this.txb_HieuXe = new System.Windows.Forms.TextBox();
            this.cb_LoaiXe = new System.Windows.Forms.ComboBox();
            this.btn_VaoBen = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.dtgv_XeGui = new System.Windows.Forms.DataGridView();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.txb_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.btn_Download = new System.Windows.Forms.Button();
            this.ptb_HinhAnh = new System.Windows.Forms.PictureBox();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.lbl_LoaiVe = new System.Windows.Forms.Label();
            this.cb_LoaiVe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_XeGui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MaVe
            // 
            this.lbl_MaVe.AutoSize = true;
            this.lbl_MaVe.Location = new System.Drawing.Point(23, 48);
            this.lbl_MaVe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_MaVe.Name = "lbl_MaVe";
            this.lbl_MaVe.Size = new System.Drawing.Size(65, 20);
            this.lbl_MaVe.TabIndex = 0;
            this.lbl_MaVe.Text = "Mã vé:";
            // 
            // txb_MaVe
            // 
            this.txb_MaVe.Location = new System.Drawing.Point(197, 38);
            this.txb_MaVe.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txb_MaVe.Name = "txb_MaVe";
            this.txb_MaVe.Size = new System.Drawing.Size(202, 27);
            this.txb_MaVe.TabIndex = 1;
            // 
            // lbl_BienSo
            // 
            this.lbl_BienSo.AutoSize = true;
            this.lbl_BienSo.Location = new System.Drawing.Point(29, 105);
            this.lbl_BienSo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_BienSo.Name = "lbl_BienSo";
            this.lbl_BienSo.Size = new System.Drawing.Size(79, 20);
            this.lbl_BienSo.TabIndex = 2;
            this.lbl_BienSo.Text = "Biển số:";
            // 
            // txb_BienSo
            // 
            this.txb_BienSo.Location = new System.Drawing.Point(197, 105);
            this.txb_BienSo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txb_BienSo.Name = "txb_BienSo";
            this.txb_BienSo.Size = new System.Drawing.Size(202, 27);
            this.txb_BienSo.TabIndex = 3;
            // 
            // lbl_LoaiXe
            // 
            this.lbl_LoaiXe.AutoSize = true;
            this.lbl_LoaiXe.Location = new System.Drawing.Point(29, 178);
            this.lbl_LoaiXe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_LoaiXe.Name = "lbl_LoaiXe";
            this.lbl_LoaiXe.Size = new System.Drawing.Size(76, 20);
            this.lbl_LoaiXe.TabIndex = 4;
            this.lbl_LoaiXe.Text = "Loại xe:";
            // 
            // lbl_HieuXe
            // 
            this.lbl_HieuXe.AutoSize = true;
            this.lbl_HieuXe.Location = new System.Drawing.Point(22, 239);
            this.lbl_HieuXe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_HieuXe.Name = "lbl_HieuXe";
            this.lbl_HieuXe.Size = new System.Drawing.Size(79, 20);
            this.lbl_HieuXe.TabIndex = 5;
            this.lbl_HieuXe.Text = "Hiệu xe:";
            // 
            // lbl_HinhAnh
            // 
            this.lbl_HinhAnh.AutoSize = true;
            this.lbl_HinhAnh.Location = new System.Drawing.Point(22, 288);
            this.lbl_HinhAnh.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_HinhAnh.Name = "lbl_HinhAnh";
            this.lbl_HinhAnh.Size = new System.Drawing.Size(90, 20);
            this.lbl_HinhAnh.TabIndex = 6;
            this.lbl_HinhAnh.Text = "Hình ảnh:";
            // 
            // txb_HieuXe
            // 
            this.txb_HieuXe.Location = new System.Drawing.Point(197, 234);
            this.txb_HieuXe.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txb_HieuXe.Name = "txb_HieuXe";
            this.txb_HieuXe.Size = new System.Drawing.Size(180, 27);
            this.txb_HieuXe.TabIndex = 10;
            // 
            // cb_LoaiXe
            // 
            this.cb_LoaiXe.FormattingEnabled = true;
            this.cb_LoaiXe.Items.AddRange(new object[] {
            "Xe đạp",
            "Xe máy",
            "Xe hơi"});
            this.cb_LoaiXe.Location = new System.Drawing.Point(197, 165);
            this.cb_LoaiXe.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cb_LoaiXe.Name = "cb_LoaiXe";
            this.cb_LoaiXe.Size = new System.Drawing.Size(218, 28);
            this.cb_LoaiXe.TabIndex = 11;
            // 
            // btn_VaoBen
            // 
            this.btn_VaoBen.Location = new System.Drawing.Point(242, 648);
            this.btn_VaoBen.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_VaoBen.Name = "btn_VaoBen";
            this.btn_VaoBen.Size = new System.Drawing.Size(194, 66);
            this.btn_VaoBen.TabIndex = 15;
            this.btn_VaoBen.Text = "Vào Bến";
            this.btn_VaoBen.UseVisualStyleBackColor = true;
            this.btn_VaoBen.Click += new System.EventHandler(this.btn_VaoBen_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(447, 648);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(192, 66);
            this.btn_Xoa.TabIndex = 16;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(656, 648);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(175, 66);
            this.btn_Sua.TabIndex = 17;
            this.btn_Sua.Text = "Chỉnh sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // dtgv_XeGui
            // 
            this.dtgv_XeGui.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_XeGui.Location = new System.Drawing.Point(656, 72);
            this.dtgv_XeGui.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dtgv_XeGui.Name = "dtgv_XeGui";
            this.dtgv_XeGui.RowHeadersWidth = 51;
            this.dtgv_XeGui.Size = new System.Drawing.Size(898, 448);
            this.dtgv_XeGui.TabIndex = 18;
            this.dtgv_XeGui.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_XeGui_CellDoubleClick);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(650, 14);
            this.lbl_Search.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(385, 20);
            this.lbl_Search.TabIndex = 19;
            this.lbl_Search.Text = "Nhập giá trị mã vé hoặc biển số để tìm kiếm:";
            // 
            // txb_Search
            // 
            this.txb_Search.Location = new System.Drawing.Point(1062, 14);
            this.txb_Search.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txb_Search.Name = "txb_Search";
            this.txb_Search.Size = new System.Drawing.Size(306, 27);
            this.txb_Search.TabIndex = 20;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(1382, 11);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(138, 35);
            this.btn_Search.TabIndex = 21;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(854, 648);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(180, 66);
            this.btn_Reset.TabIndex = 22;
            this.btn_Reset.Text = "Tạo mới";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(216, 529);
            this.btn_Upload.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(177, 35);
            this.btn_Upload.TabIndex = 23;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(406, 529);
            this.btn_Download.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(177, 35);
            this.btn_Download.TabIndex = 24;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // ptb_HinhAnh
            // 
            this.ptb_HinhAnh.Location = new System.Drawing.Point(197, 288);
            this.ptb_HinhAnh.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ptb_HinhAnh.Name = "ptb_HinhAnh";
            this.ptb_HinhAnh.Size = new System.Drawing.Size(406, 232);
            this.ptb_HinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_HinhAnh.TabIndex = 14;
            this.ptb_HinhAnh.TabStop = false;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Location = new System.Drawing.Point(1062, 648);
            this.btn_ThongKe.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(175, 66);
            this.btn_ThongKe.TabIndex = 25;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // lbl_LoaiVe
            // 
            this.lbl_LoaiVe.AutoSize = true;
            this.lbl_LoaiVe.Location = new System.Drawing.Point(22, 588);
            this.lbl_LoaiVe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_LoaiVe.Name = "lbl_LoaiVe";
            this.lbl_LoaiVe.Size = new System.Drawing.Size(76, 20);
            this.lbl_LoaiVe.TabIndex = 26;
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
            this.cb_LoaiVe.Location = new System.Drawing.Point(197, 588);
            this.cb_LoaiVe.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cb_LoaiVe.Name = "cb_LoaiVe";
            this.cb_LoaiVe.Size = new System.Drawing.Size(218, 28);
            this.cb_LoaiVe.TabIndex = 27;
            // 
            // frmGuiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 719);
            this.Controls.Add(this.cb_LoaiVe);
            this.Controls.Add(this.lbl_LoaiVe);
            this.Controls.Add(this.btn_ThongKe);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txb_Search);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.dtgv_XeGui);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_VaoBen);
            this.Controls.Add(this.ptb_HinhAnh);
            this.Controls.Add(this.cb_LoaiXe);
            this.Controls.Add(this.txb_HieuXe);
            this.Controls.Add(this.lbl_HinhAnh);
            this.Controls.Add(this.lbl_HieuXe);
            this.Controls.Add(this.lbl_LoaiXe);
            this.Controls.Add(this.txb_BienSo);
            this.Controls.Add(this.lbl_BienSo);
            this.Controls.Add(this.txb_MaVe);
            this.Controls.Add(this.lbl_MaVe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmGuiXe";
            this.Text = "frmGuiXe";
            this.Load += new System.EventHandler(this.frmGuiXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_XeGui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MaVe;
        private System.Windows.Forms.TextBox txb_MaVe;
        private System.Windows.Forms.Label lbl_BienSo;
        private System.Windows.Forms.TextBox txb_BienSo;
        private System.Windows.Forms.Label lbl_LoaiXe;
        private System.Windows.Forms.Label lbl_HieuXe;
        private System.Windows.Forms.Label lbl_HinhAnh;
        private System.Windows.Forms.TextBox txb_HieuXe;
        private System.Windows.Forms.PictureBox ptb_HinhAnh;
        private System.Windows.Forms.Button btn_VaoBen;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DataGridView dtgv_XeGui;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TextBox txb_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.Label lbl_LoaiVe;
        private System.Windows.Forms.ComboBox cb_LoaiVe;
        public System.Windows.Forms.ComboBox cb_LoaiXe;
    }
}