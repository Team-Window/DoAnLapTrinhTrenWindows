namespace QuanLiOto
{
    partial class FrmThanhToanLuong
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
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_NgayLamViec = new System.Windows.Forms.Label();
            this.lbl_SoGioLamVIec = new System.Windows.Forms.Label();
            this.lbl_Luong = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.txb_ID = new System.Windows.Forms.TextBox();
            this.txb_FirstName = new System.Windows.Forms.TextBox();
            this.txb_LastName = new System.Windows.Forms.TextBox();
            this.dtp_NgayLamViec = new System.Windows.Forms.DateTimePicker();
            this.txb_SoGioLamViec = new System.Windows.Forms.TextBox();
            this.txb_Luong = new System.Windows.Forms.TextBox();
            this.dtgv_ThanhToanLuong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ThanhToanLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(13, 23);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(21, 13);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID:";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(16, 65);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(60, 13);
            this.lbl_FirstName.TabIndex = 1;
            this.lbl_FirstName.Text = "First Name:";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(16, 103);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(61, 13);
            this.lbl_LastName.TabIndex = 2;
            this.lbl_LastName.Text = "Last Name:";
            // 
            // lbl_NgayLamViec
            // 
            this.lbl_NgayLamViec.AutoSize = true;
            this.lbl_NgayLamViec.Location = new System.Drawing.Point(16, 144);
            this.lbl_NgayLamViec.Name = "lbl_NgayLamViec";
            this.lbl_NgayLamViec.Size = new System.Drawing.Size(82, 13);
            this.lbl_NgayLamViec.TabIndex = 3;
            this.lbl_NgayLamViec.Text = "Ngày Làm Việc:";
            // 
            // lbl_SoGioLamVIec
            // 
            this.lbl_SoGioLamVIec.AutoSize = true;
            this.lbl_SoGioLamVIec.Location = new System.Drawing.Point(16, 191);
            this.lbl_SoGioLamVIec.Name = "lbl_SoGioLamVIec";
            this.lbl_SoGioLamVIec.Size = new System.Drawing.Size(89, 13);
            this.lbl_SoGioLamVIec.TabIndex = 4;
            this.lbl_SoGioLamVIec.Text = "Số Giờ Làm Việc:";
            // 
            // lbl_Luong
            // 
            this.lbl_Luong.AutoSize = true;
            this.lbl_Luong.Location = new System.Drawing.Point(16, 230);
            this.lbl_Luong.Name = "lbl_Luong";
            this.lbl_Luong.Size = new System.Drawing.Size(40, 13);
            this.lbl_Luong.TabIndex = 5;
            this.lbl_Luong.Text = "Lương:";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(203, 277);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(139, 48);
            this.btn_ThanhToan.TabIndex = 6;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(378, 277);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(135, 48);
            this.btn_Huy.TabIndex = 7;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // txb_ID
            // 
            this.txb_ID.Location = new System.Drawing.Point(140, 23);
            this.txb_ID.Name = "txb_ID";
            this.txb_ID.Size = new System.Drawing.Size(80, 20);
            this.txb_ID.TabIndex = 8;
            // 
            // txb_FirstName
            // 
            this.txb_FirstName.Location = new System.Drawing.Point(140, 65);
            this.txb_FirstName.Name = "txb_FirstName";
            this.txb_FirstName.Size = new System.Drawing.Size(130, 20);
            this.txb_FirstName.TabIndex = 9;
            // 
            // txb_LastName
            // 
            this.txb_LastName.Location = new System.Drawing.Point(140, 103);
            this.txb_LastName.Name = "txb_LastName";
            this.txb_LastName.Size = new System.Drawing.Size(130, 20);
            this.txb_LastName.TabIndex = 10;
            // 
            // dtp_NgayLamViec
            // 
            this.dtp_NgayLamViec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayLamViec.Location = new System.Drawing.Point(140, 144);
            this.dtp_NgayLamViec.Name = "dtp_NgayLamViec";
            this.dtp_NgayLamViec.Size = new System.Drawing.Size(130, 20);
            this.dtp_NgayLamViec.TabIndex = 11;
            // 
            // txb_SoGioLamViec
            // 
            this.txb_SoGioLamViec.Location = new System.Drawing.Point(140, 191);
            this.txb_SoGioLamViec.Name = "txb_SoGioLamViec";
            this.txb_SoGioLamViec.Size = new System.Drawing.Size(130, 20);
            this.txb_SoGioLamViec.TabIndex = 12;
            // 
            // txb_Luong
            // 
            this.txb_Luong.Location = new System.Drawing.Point(140, 230);
            this.txb_Luong.Name = "txb_Luong";
            this.txb_Luong.Size = new System.Drawing.Size(130, 20);
            this.txb_Luong.TabIndex = 13;
            // 
            // dtgv_ThanhToanLuong
            // 
            this.dtgv_ThanhToanLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ThanhToanLuong.Location = new System.Drawing.Point(291, 23);
            this.dtgv_ThanhToanLuong.Name = "dtgv_ThanhToanLuong";
            this.dtgv_ThanhToanLuong.Size = new System.Drawing.Size(393, 227);
            this.dtgv_ThanhToanLuong.TabIndex = 14;
            this.dtgv_ThanhToanLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ThanhToanLuong_CellClick);
            // 
            // FrmThanhToanLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 344);
            this.Controls.Add(this.dtgv_ThanhToanLuong);
            this.Controls.Add(this.txb_Luong);
            this.Controls.Add(this.txb_SoGioLamViec);
            this.Controls.Add(this.dtp_NgayLamViec);
            this.Controls.Add(this.txb_LastName);
            this.Controls.Add(this.txb_FirstName);
            this.Controls.Add(this.txb_ID);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.lbl_Luong);
            this.Controls.Add(this.lbl_SoGioLamVIec);
            this.Controls.Add(this.lbl_NgayLamViec);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.lbl_ID);
            this.Name = "FrmThanhToanLuong";
            this.Text = "FrmThanhToanLuong";
            this.Load += new System.EventHandler(this.FrmThanhToanLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ThanhToanLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_NgayLamViec;
        private System.Windows.Forms.Label lbl_SoGioLamVIec;
        private System.Windows.Forms.Label lbl_Luong;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.TextBox txb_ID;
        private System.Windows.Forms.TextBox txb_FirstName;
        private System.Windows.Forms.TextBox txb_LastName;
        private System.Windows.Forms.DateTimePicker dtp_NgayLamViec;
        private System.Windows.Forms.TextBox txb_SoGioLamViec;
        private System.Windows.Forms.TextBox txb_Luong;
        private System.Windows.Forms.DataGridView dtgv_ThanhToanLuong;
    }
}