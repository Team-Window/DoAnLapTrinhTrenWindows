namespace QuanLiOto
{
    partial class FrmDangKyLichLamViec
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
            this.lbl_NgayDK = new System.Windows.Forms.Label();
            this.lbl_Ca = new System.Windows.Forms.Label();
            this.txb_ID = new System.Windows.Forms.TextBox();
            this.txb_FirstName = new System.Windows.Forms.TextBox();
            this.txb_LastName = new System.Windows.Forms.TextBox();
            this.dtp_NgayDK = new System.Windows.Forms.DateTimePicker();
            this.cb_Ca = new System.Windows.Forms.ComboBox();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.lbl_Huy = new System.Windows.Forms.Button();
            this.dtgv_DKLichLamViec = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DKLichLamViec)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(12, 20);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(21, 13);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID:";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(15, 54);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(60, 13);
            this.lbl_FirstName.TabIndex = 1;
            this.lbl_FirstName.Text = "First Name:";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(15, 92);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(61, 13);
            this.lbl_LastName.TabIndex = 2;
            this.lbl_LastName.Text = "Last Name:";
            // 
            // lbl_NgayDK
            // 
            this.lbl_NgayDK.AutoSize = true;
            this.lbl_NgayDK.Location = new System.Drawing.Point(15, 126);
            this.lbl_NgayDK.Name = "lbl_NgayDK";
            this.lbl_NgayDK.Size = new System.Drawing.Size(79, 13);
            this.lbl_NgayDK.TabIndex = 3;
            this.lbl_NgayDK.Text = "Ngày Đăng Ký:";
            // 
            // lbl_Ca
            // 
            this.lbl_Ca.AutoSize = true;
            this.lbl_Ca.Location = new System.Drawing.Point(15, 167);
            this.lbl_Ca.Name = "lbl_Ca";
            this.lbl_Ca.Size = new System.Drawing.Size(23, 13);
            this.lbl_Ca.TabIndex = 4;
            this.lbl_Ca.Text = "Ca:";
            // 
            // txb_ID
            // 
            this.txb_ID.Location = new System.Drawing.Point(127, 20);
            this.txb_ID.Name = "txb_ID";
            this.txb_ID.Size = new System.Drawing.Size(100, 20);
            this.txb_ID.TabIndex = 5;
            // 
            // txb_FirstName
            // 
            this.txb_FirstName.Location = new System.Drawing.Point(127, 54);
            this.txb_FirstName.Name = "txb_FirstName";
            this.txb_FirstName.Size = new System.Drawing.Size(100, 20);
            this.txb_FirstName.TabIndex = 6;
            // 
            // txb_LastName
            // 
            this.txb_LastName.Location = new System.Drawing.Point(127, 92);
            this.txb_LastName.Name = "txb_LastName";
            this.txb_LastName.Size = new System.Drawing.Size(100, 20);
            this.txb_LastName.TabIndex = 7;
            // 
            // dtp_NgayDK
            // 
            this.dtp_NgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayDK.Location = new System.Drawing.Point(127, 120);
            this.dtp_NgayDK.Name = "dtp_NgayDK";
            this.dtp_NgayDK.Size = new System.Drawing.Size(100, 20);
            this.dtp_NgayDK.TabIndex = 8;
            // 
            // cb_Ca
            // 
            this.cb_Ca.FormattingEnabled = true;
            this.cb_Ca.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_Ca.Location = new System.Drawing.Point(127, 158);
            this.cb_Ca.Name = "cb_Ca";
            this.cb_Ca.Size = new System.Drawing.Size(100, 21);
            this.cb_Ca.TabIndex = 9;
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Location = new System.Drawing.Point(18, 192);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(111, 35);
            this.btn_DangKy.TabIndex = 10;
            this.btn_DangKy.Text = "Đăng Ký";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // lbl_Huy
            // 
            this.lbl_Huy.Location = new System.Drawing.Point(147, 192);
            this.lbl_Huy.Name = "lbl_Huy";
            this.lbl_Huy.Size = new System.Drawing.Size(99, 35);
            this.lbl_Huy.TabIndex = 11;
            this.lbl_Huy.Text = "Hủy";
            this.lbl_Huy.UseVisualStyleBackColor = true;
            this.lbl_Huy.Click += new System.EventHandler(this.lbl_Huy_Click);
            // 
            // dtgv_DKLichLamViec
            // 
            this.dtgv_DKLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DKLichLamViec.Location = new System.Drawing.Point(267, 1);
            this.dtgv_DKLichLamViec.Name = "dtgv_DKLichLamViec";
            this.dtgv_DKLichLamViec.Size = new System.Drawing.Size(459, 244);
            this.dtgv_DKLichLamViec.TabIndex = 12;
            this.dtgv_DKLichLamViec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_DKLichLamViec_CellClick);
            // 
            // FrmDangKyLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 248);
            this.Controls.Add(this.dtgv_DKLichLamViec);
            this.Controls.Add(this.lbl_Huy);
            this.Controls.Add(this.btn_DangKy);
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
            this.Name = "FrmDangKyLichLamViec";
            this.Text = "FrmDangKyLichLamViec";
            this.Load += new System.EventHandler(this.FrmDangKyLichLamViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DKLichLamViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_NgayDK;
        private System.Windows.Forms.Label lbl_Ca;
        private System.Windows.Forms.DateTimePicker dtp_NgayDK;
        private System.Windows.Forms.ComboBox cb_Ca;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.Button lbl_Huy;
        public System.Windows.Forms.TextBox txb_ID;
        public System.Windows.Forms.TextBox txb_FirstName;
        public System.Windows.Forms.TextBox txb_LastName;
        private System.Windows.Forms.DataGridView dtgv_DKLichLamViec;
    }
}