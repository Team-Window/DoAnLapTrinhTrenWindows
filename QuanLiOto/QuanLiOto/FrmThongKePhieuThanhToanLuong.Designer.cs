namespace QuanLiOto
{
    partial class FrmThongKePhieuThanhToanLuong
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
            this.lbl_ThongKe = new System.Windows.Forms.Label();
            this.dtgv_ThongKe = new System.Windows.Forms.DataGridView();
            this.btn_Print = new System.Windows.Forms.Button();
            this.gb_ThongKe = new System.Windows.Forms.GroupBox();
            this.lbl_UseDateRange = new System.Windows.Forms.Label();
            this.lbl_BirthDateBetween = new System.Windows.Forms.Label();
            this.rdb_Yes = new System.Windows.Forms.RadioButton();
            this.rdb_No = new System.Windows.Forms.RadioButton();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.lbl_And = new System.Windows.Forms.Label();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_SaveToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ThongKe)).BeginInit();
            this.gb_ThongKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ThongKe
            // 
            this.lbl_ThongKe.AutoSize = true;
            this.lbl_ThongKe.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_ThongKe.Location = new System.Drawing.Point(31, 9);
            this.lbl_ThongKe.Name = "lbl_ThongKe";
            this.lbl_ThongKe.Size = new System.Drawing.Size(657, 48);
            this.lbl_ThongKe.TabIndex = 0;
            this.lbl_ThongKe.Text = "Bảng Thống Kê Lương Thưởng";
            // 
            // dtgv_ThongKe
            // 
            this.dtgv_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ThongKe.Location = new System.Drawing.Point(2, 156);
            this.dtgv_ThongKe.Name = "dtgv_ThongKe";
            this.dtgv_ThongKe.Size = new System.Drawing.Size(711, 231);
            this.dtgv_ThongKe.TabIndex = 1;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(131, 407);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(127, 50);
            this.btn_Print.TabIndex = 2;
            this.btn_Print.Text = "To Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // gb_ThongKe
            // 
            this.gb_ThongKe.Controls.Add(this.dtp_End);
            this.gb_ThongKe.Controls.Add(this.lbl_And);
            this.gb_ThongKe.Controls.Add(this.dtp_Start);
            this.gb_ThongKe.Controls.Add(this.rdb_No);
            this.gb_ThongKe.Controls.Add(this.rdb_Yes);
            this.gb_ThongKe.Controls.Add(this.lbl_BirthDateBetween);
            this.gb_ThongKe.Controls.Add(this.lbl_UseDateRange);
            this.gb_ThongKe.Location = new System.Drawing.Point(2, 60);
            this.gb_ThongKe.Name = "gb_ThongKe";
            this.gb_ThongKe.Size = new System.Drawing.Size(374, 90);
            this.gb_ThongKe.TabIndex = 3;
            this.gb_ThongKe.TabStop = false;
            // 
            // lbl_UseDateRange
            // 
            this.lbl_UseDateRange.AutoSize = true;
            this.lbl_UseDateRange.Location = new System.Drawing.Point(7, 20);
            this.lbl_UseDateRange.Name = "lbl_UseDateRange";
            this.lbl_UseDateRange.Size = new System.Drawing.Size(90, 13);
            this.lbl_UseDateRange.TabIndex = 0;
            this.lbl_UseDateRange.Text = "Use Date Range:";
            // 
            // lbl_BirthDateBetween
            // 
            this.lbl_BirthDateBetween.AutoSize = true;
            this.lbl_BirthDateBetween.Location = new System.Drawing.Point(10, 51);
            this.lbl_BirthDateBetween.Name = "lbl_BirthDateBetween";
            this.lbl_BirthDateBetween.Size = new System.Drawing.Size(99, 13);
            this.lbl_BirthDateBetween.TabIndex = 1;
            this.lbl_BirthDateBetween.Text = "BirthDate Between:";
            // 
            // rdb_Yes
            // 
            this.rdb_Yes.AutoSize = true;
            this.rdb_Yes.Location = new System.Drawing.Point(131, 20);
            this.rdb_Yes.Name = "rdb_Yes";
            this.rdb_Yes.Size = new System.Drawing.Size(43, 17);
            this.rdb_Yes.TabIndex = 2;
            this.rdb_Yes.TabStop = true;
            this.rdb_Yes.Text = "Yes";
            this.rdb_Yes.UseVisualStyleBackColor = true;
            // 
            // rdb_No
            // 
            this.rdb_No.AutoSize = true;
            this.rdb_No.Location = new System.Drawing.Point(217, 20);
            this.rdb_No.Name = "rdb_No";
            this.rdb_No.Size = new System.Drawing.Size(39, 17);
            this.rdb_No.TabIndex = 3;
            this.rdb_No.TabStop = true;
            this.rdb_No.Text = "No";
            this.rdb_No.UseVisualStyleBackColor = true;
            // 
            // dtp_Start
            // 
            this.dtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Start.Location = new System.Drawing.Point(116, 51);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(96, 20);
            this.dtp_Start.TabIndex = 4;
            // 
            // lbl_And
            // 
            this.lbl_And.AutoSize = true;
            this.lbl_And.Location = new System.Drawing.Point(230, 51);
            this.lbl_And.Name = "lbl_And";
            this.lbl_And.Size = new System.Drawing.Size(26, 13);
            this.lbl_And.TabIndex = 5;
            this.lbl_And.Text = "And";
            // 
            // dtp_End
            // 
            this.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_End.Location = new System.Drawing.Point(262, 51);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(95, 20);
            this.dtp_End.TabIndex = 6;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(430, 89);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(113, 42);
            this.btn_Check.TabIndex = 4;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // btn_SaveToExcel
            // 
            this.btn_SaveToExcel.Location = new System.Drawing.Point(360, 407);
            this.btn_SaveToExcel.Name = "btn_SaveToExcel";
            this.btn_SaveToExcel.Size = new System.Drawing.Size(139, 50);
            this.btn_SaveToExcel.TabIndex = 5;
            this.btn_SaveToExcel.Text = "Save To Excel File";
            this.btn_SaveToExcel.UseVisualStyleBackColor = true;
            this.btn_SaveToExcel.Click += new System.EventHandler(this.btn_SaveToExcel_Click);
            // 
            // FrmThongKePhieuThanhToanLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 469);
            this.Controls.Add(this.btn_SaveToExcel);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.gb_ThongKe);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.dtgv_ThongKe);
            this.Controls.Add(this.lbl_ThongKe);
            this.Name = "FrmThongKePhieuThanhToanLuong";
            this.Text = "FrmThongKePhieuThanhToanLuong";
            this.Load += new System.EventHandler(this.FrmThongKePhieuThanhToanLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ThongKe)).EndInit();
            this.gb_ThongKe.ResumeLayout(false);
            this.gb_ThongKe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ThongKe;
        private System.Windows.Forms.DataGridView dtgv_ThongKe;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.GroupBox gb_ThongKe;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.Label lbl_And;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.RadioButton rdb_No;
        private System.Windows.Forms.RadioButton rdb_Yes;
        private System.Windows.Forms.Label lbl_BirthDateBetween;
        private System.Windows.Forms.Label lbl_UseDateRange;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_SaveToExcel;
    }
}