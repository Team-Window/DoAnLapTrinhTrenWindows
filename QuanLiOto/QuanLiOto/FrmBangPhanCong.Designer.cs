namespace QuanLiOto
{
    partial class FrmBangPhanCong
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
            this.lbl_BangPhanCong = new System.Windows.Forms.Label();
            this.dtgv_BangPhanCong = new System.Windows.Forms.DataGridView();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_NgayDK = new System.Windows.Forms.Label();
            this.lbl_Ca = new System.Windows.Forms.Label();
            this.txb_ID = new System.Windows.Forms.TextBox();
            this.txb_FirstName = new System.Windows.Forms.TextBox();
            this.txb_LastName = new System.Windows.Forms.TextBox();
            this.dtp_NgayDK = new System.Windows.Forms.DateTimePicker();
            this.cb_Ca = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_ChinhSua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_TaoMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BangPhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_BangPhanCong
            // 
            this.lbl_BangPhanCong.AutoSize = true;
            this.lbl_BangPhanCong.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BangPhanCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_BangPhanCong.Location = new System.Drawing.Point(119, 9);
            this.lbl_BangPhanCong.Name = "lbl_BangPhanCong";
            this.lbl_BangPhanCong.Size = new System.Drawing.Size(403, 50);
            this.lbl_BangPhanCong.TabIndex = 1;
            this.lbl_BangPhanCong.Text = "Bảng Phân Công";
            // 
            // dtgv_BangPhanCong
            // 
            this.dtgv_BangPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_BangPhanCong.Location = new System.Drawing.Point(272, 62);
            this.dtgv_BangPhanCong.Name = "dtgv_BangPhanCong";
            this.dtgv_BangPhanCong.Size = new System.Drawing.Size(421, 186);
            this.dtgv_BangPhanCong.TabIndex = 2;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(13, 78);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(21, 13);
            this.lbl_ID.TabIndex = 3;
            this.lbl_ID.Text = "ID:";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(16, 118);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(60, 13);
            this.lbl_FirstName.TabIndex = 4;
            this.lbl_FirstName.Text = "First Name:";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(16, 154);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(61, 13);
            this.lbl_LastName.TabIndex = 5;
            this.lbl_LastName.Text = "Last Name:";
            // 
            // lbl_NgayDK
            // 
            this.lbl_NgayDK.AutoSize = true;
            this.lbl_NgayDK.Location = new System.Drawing.Point(16, 190);
            this.lbl_NgayDK.Name = "lbl_NgayDK";
            this.lbl_NgayDK.Size = new System.Drawing.Size(79, 13);
            this.lbl_NgayDK.TabIndex = 6;
            this.lbl_NgayDK.Text = "Ngày Đăng Ký:";
            // 
            // lbl_Ca
            // 
            this.lbl_Ca.AutoSize = true;
            this.lbl_Ca.Location = new System.Drawing.Point(16, 227);
            this.lbl_Ca.Name = "lbl_Ca";
            this.lbl_Ca.Size = new System.Drawing.Size(23, 13);
            this.lbl_Ca.TabIndex = 7;
            this.lbl_Ca.Text = "Ca:";
            // 
            // txb_ID
            // 
            this.txb_ID.Location = new System.Drawing.Point(119, 78);
            this.txb_ID.Name = "txb_ID";
            this.txb_ID.Size = new System.Drawing.Size(74, 20);
            this.txb_ID.TabIndex = 8;
            // 
            // txb_FirstName
            // 
            this.txb_FirstName.Location = new System.Drawing.Point(119, 118);
            this.txb_FirstName.Name = "txb_FirstName";
            this.txb_FirstName.Size = new System.Drawing.Size(115, 20);
            this.txb_FirstName.TabIndex = 9;
            // 
            // txb_LastName
            // 
            this.txb_LastName.Location = new System.Drawing.Point(119, 154);
            this.txb_LastName.Name = "txb_LastName";
            this.txb_LastName.Size = new System.Drawing.Size(115, 20);
            this.txb_LastName.TabIndex = 10;
            // 
            // dtp_NgayDK
            // 
            this.dtp_NgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayDK.Location = new System.Drawing.Point(119, 190);
            this.dtp_NgayDK.Name = "dtp_NgayDK";
            this.dtp_NgayDK.Size = new System.Drawing.Size(115, 20);
            this.dtp_NgayDK.TabIndex = 11;
            // 
            // cb_Ca
            // 
            this.cb_Ca.FormattingEnabled = true;
            this.cb_Ca.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_Ca.Location = new System.Drawing.Point(119, 227);
            this.cb_Ca.Name = "cb_Ca";
            this.cb_Ca.Size = new System.Drawing.Size(115, 21);
            this.cb_Ca.TabIndex = 12;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(35, 263);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(119, 36);
            this.btn_Them.TabIndex = 13;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_ChinhSua
            // 
            this.btn_ChinhSua.Location = new System.Drawing.Point(201, 263);
            this.btn_ChinhSua.Name = "btn_ChinhSua";
            this.btn_ChinhSua.Size = new System.Drawing.Size(135, 36);
            this.btn_ChinhSua.TabIndex = 14;
            this.btn_ChinhSua.Text = "Chỉnh Sửa";
            this.btn_ChinhSua.UseVisualStyleBackColor = true;
            this.btn_ChinhSua.Click += new System.EventHandler(this.btn_ChinhSua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(371, 263);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(118, 36);
            this.btn_Xoa.TabIndex = 15;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_TaoMoi
            // 
            this.btn_TaoMoi.Location = new System.Drawing.Point(529, 263);
            this.btn_TaoMoi.Name = "btn_TaoMoi";
            this.btn_TaoMoi.Size = new System.Drawing.Size(107, 36);
            this.btn_TaoMoi.TabIndex = 16;
            this.btn_TaoMoi.Text = "Tạo Mới";
            this.btn_TaoMoi.UseVisualStyleBackColor = true;
            this.btn_TaoMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
            // 
            // FrmBangPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 311);
            this.Controls.Add(this.btn_TaoMoi);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_ChinhSua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.cb_Ca);
            this.Controls.Add(this.dtp_NgayDK);
            this.Controls.Add(this.txb_LastName);
            this.Controls.Add(this.txb_FirstName);
            this.Controls.Add(this.txb_ID);
            this.Controls.Add(this.lbl_Ca);
            this.Controls.Add(this.lbl_NgayDK);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.dtgv_BangPhanCong);
            this.Controls.Add(this.lbl_BangPhanCong);
            this.Name = "FrmBangPhanCong";
            this.Text = "FrmBangPhanCong";
            this.Load += new System.EventHandler(this.FrmBangPhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BangPhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_BangPhanCong;
        private System.Windows.Forms.DataGridView dtgv_BangPhanCong;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_NgayDK;
        private System.Windows.Forms.Label lbl_Ca;
        private System.Windows.Forms.TextBox txb_ID;
        private System.Windows.Forms.TextBox txb_FirstName;
        private System.Windows.Forms.TextBox txb_LastName;
        private System.Windows.Forms.DateTimePicker dtp_NgayDK;
        private System.Windows.Forms.ComboBox cb_Ca;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_ChinhSua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_TaoMoi;
    }
}