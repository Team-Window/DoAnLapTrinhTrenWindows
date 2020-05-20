namespace QuanLiOto.QLThueXe
{
    partial class FormThongKeXeChoThue
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
            this.btn_SaveToExcelFile = new System.Windows.Forms.Button();
            this.dtv_Doanhthu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Check = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_BirthDateBetween = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rdb_No = new System.Windows.Forms.RadioButton();
            this.lbl_UseDateRange = new System.Windows.Forms.Label();
            this.rdb_Yes = new System.Windows.Forms.RadioButton();
            this.rdb_Chothue = new System.Windows.Forms.RadioButton();
            this.rdb_Thue = new System.Windows.Forms.RadioButton();
            this.rdb_All = new System.Windows.Forms.RadioButton();
            this.lb_TongDoanhThu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Doanhthu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SaveToExcelFile
            // 
            this.btn_SaveToExcelFile.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_SaveToExcelFile.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveToExcelFile.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_SaveToExcelFile.Location = new System.Drawing.Point(9, 478);
            this.btn_SaveToExcelFile.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SaveToExcelFile.Name = "btn_SaveToExcelFile";
            this.btn_SaveToExcelFile.Size = new System.Drawing.Size(272, 50);
            this.btn_SaveToExcelFile.TabIndex = 11;
            this.btn_SaveToExcelFile.Text = "Save To Excel File";
            this.btn_SaveToExcelFile.UseVisualStyleBackColor = false;
            this.btn_SaveToExcelFile.Click += new System.EventHandler(this.btn_SaveToExcelFile_Click);
            // 
            // dtv_Doanhthu
            // 
            this.dtv_Doanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_Doanhthu.Location = new System.Drawing.Point(9, 159);
            this.dtv_Doanhthu.Margin = new System.Windows.Forms.Padding(4);
            this.dtv_Doanhthu.Name = "dtv_Doanhthu";
            this.dtv_Doanhthu.RowHeadersWidth = 51;
            this.dtv_Doanhthu.Size = new System.Drawing.Size(957, 311);
            this.dtv_Doanhthu.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Check);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.rdb_Chothue);
            this.groupBox1.Controls.Add(this.rdb_Thue);
            this.groupBox1.Controls.Add(this.rdb_All);
            this.groupBox1.Location = new System.Drawing.Point(9, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(957, 124);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(823, 37);
            this.btn_Check.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(100, 53);
            this.btn_Check.TabIndex = 4;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbl_BirthDateBetween);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.rdb_No);
            this.groupBox2.Controls.Add(this.lbl_UseDateRange);
            this.groupBox2.Controls.Add(this.rdb_Yes);
            this.groupBox2.Location = new System.Drawing.Point(291, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(497, 94);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(344, 53);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(116, 22);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "And";
            // 
            // lbl_BirthDateBetween
            // 
            this.lbl_BirthDateBetween.AutoSize = true;
            this.lbl_BirthDateBetween.Location = new System.Drawing.Point(13, 60);
            this.lbl_BirthDateBetween.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BirthDateBetween.Name = "lbl_BirthDateBetween";
            this.lbl_BirthDateBetween.Size = new System.Drawing.Size(142, 17);
            this.lbl_BirthDateBetween.TabIndex = 4;
            this.lbl_BirthDateBetween.Text = "Ngày trả xe: Between";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 53);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // rdb_No
            // 
            this.rdb_No.AutoSize = true;
            this.rdb_No.Location = new System.Drawing.Point(255, 25);
            this.rdb_No.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_No.Name = "rdb_No";
            this.rdb_No.Size = new System.Drawing.Size(47, 21);
            this.rdb_No.TabIndex = 2;
            this.rdb_No.TabStop = true;
            this.rdb_No.Text = "No";
            this.rdb_No.UseVisualStyleBackColor = true;
            this.rdb_No.CheckedChanged += new System.EventHandler(this.rdb_No_CheckedChanged);
            // 
            // lbl_UseDateRange
            // 
            this.lbl_UseDateRange.AutoSize = true;
            this.lbl_UseDateRange.Location = new System.Drawing.Point(9, 25);
            this.lbl_UseDateRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UseDateRange.Name = "lbl_UseDateRange";
            this.lbl_UseDateRange.Size = new System.Drawing.Size(117, 17);
            this.lbl_UseDateRange.TabIndex = 1;
            this.lbl_UseDateRange.Text = "Use Date Range:";
            // 
            // rdb_Yes
            // 
            this.rdb_Yes.AutoSize = true;
            this.rdb_Yes.Location = new System.Drawing.Point(168, 25);
            this.rdb_Yes.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_Yes.Name = "rdb_Yes";
            this.rdb_Yes.Size = new System.Drawing.Size(53, 21);
            this.rdb_Yes.TabIndex = 0;
            this.rdb_Yes.TabStop = true;
            this.rdb_Yes.Text = "Yes";
            this.rdb_Yes.UseVisualStyleBackColor = true;
            this.rdb_Yes.CheckedChanged += new System.EventHandler(this.rdb_Yes_CheckedChanged);
            // 
            // rdb_Chothue
            // 
            this.rdb_Chothue.AutoSize = true;
            this.rdb_Chothue.Location = new System.Drawing.Point(173, 55);
            this.rdb_Chothue.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_Chothue.Name = "rdb_Chothue";
            this.rdb_Chothue.Size = new System.Drawing.Size(109, 21);
            this.rdb_Chothue.TabIndex = 2;
            this.rdb_Chothue.TabStop = true;
            this.rdb_Chothue.Text = "Công ty thuê";
            this.rdb_Chothue.UseVisualStyleBackColor = true;
            // 
            // rdb_Thue
            // 
            this.rdb_Thue.AutoSize = true;
            this.rdb_Thue.Location = new System.Drawing.Point(64, 55);
            this.rdb_Thue.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_Thue.Name = "rdb_Thue";
            this.rdb_Thue.Size = new System.Drawing.Size(101, 21);
            this.rdb_Thue.TabIndex = 1;
            this.rdb_Thue.TabStop = true;
            this.rdb_Thue.Text = "Khách thuê";
            this.rdb_Thue.UseVisualStyleBackColor = true;
            // 
            // rdb_All
            // 
            this.rdb_All.AutoSize = true;
            this.rdb_All.Location = new System.Drawing.Point(12, 55);
            this.rdb_All.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_All.Name = "rdb_All";
            this.rdb_All.Size = new System.Drawing.Size(44, 21);
            this.rdb_All.TabIndex = 0;
            this.rdb_All.TabStop = true;
            this.rdb_All.Text = "All";
            this.rdb_All.UseVisualStyleBackColor = true;
            // 
            // lb_TongDoanhThu
            // 
            this.lb_TongDoanhThu.BackColor = System.Drawing.Color.Red;
            this.lb_TongDoanhThu.Location = new System.Drawing.Point(761, 474);
            this.lb_TongDoanhThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TongDoanhThu.Name = "lb_TongDoanhThu";
            this.lb_TongDoanhThu.Size = new System.Drawing.Size(205, 78);
            this.lb_TongDoanhThu.TabIndex = 12;
            this.lb_TongDoanhThu.Text = "Tổng Tiền";
            // 
            // FormThongKeXeChoThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 610);
            this.Controls.Add(this.lb_TongDoanhThu);
            this.Controls.Add(this.btn_SaveToExcelFile);
            this.Controls.Add(this.dtv_Doanhthu);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormThongKeXeChoThue";
            this.Text = "FormThongKeXeChoThue";
            this.Load += new System.EventHandler(this.FormThongKeXeChoThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_Doanhthu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveToExcelFile;
        private System.Windows.Forms.DataGridView dtv_Doanhthu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_BirthDateBetween;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rdb_No;
        private System.Windows.Forms.Label lbl_UseDateRange;
        private System.Windows.Forms.RadioButton rdb_Yes;
        private System.Windows.Forms.RadioButton rdb_Chothue;
        private System.Windows.Forms.RadioButton rdb_Thue;
        private System.Windows.Forms.RadioButton rdb_All;
        private System.Windows.Forms.Label lb_TongDoanhThu;
    }
}