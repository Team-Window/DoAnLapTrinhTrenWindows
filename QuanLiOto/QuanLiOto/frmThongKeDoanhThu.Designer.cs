namespace QuanLiOto
{
    partial class frmThongKeDoanhThu
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonCheck = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.doAnLapTrinhTrenWIndowsDataSet = new QuanLiOto.DoAnLapTrinhTrenWIndowsDataSet();
            this.thongKeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongKeTableAdapter = new QuanLiOto.DoAnLapTrinhTrenWIndowsDataSetTableAdapters.ThongKeTableAdapter();
            this.maveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biensoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaixeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hieuxeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhanhDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.giovaobenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayvaobenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giorabenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayrabenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_TongDoanhThu = new System.Windows.Forms.Label();
            this.RadioBtXehoi = new System.Windows.Forms.RadioButton();
            this.RadioBtXemay = new System.Windows.Forms.RadioButton();
            this.RadioBtXedap = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnLapTrinhTrenWIndowsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioBtXehoi);
            this.groupBox1.Controls.Add(this.RadioBtXemay);
            this.groupBox1.Controls.Add(this.RadioBtXedap);
            this.groupBox1.Controls.Add(this.ButtonCheck);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1128, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(0, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1128, 328);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(284, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 135);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(329, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Doanh thu ngày:";
            // 
            // ButtonCheck
            // 
            this.ButtonCheck.BackColor = System.Drawing.Color.Black;
            this.ButtonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCheck.ForeColor = System.Drawing.Color.Red;
            this.ButtonCheck.Location = new System.Drawing.Point(937, 42);
            this.ButtonCheck.Name = "ButtonCheck";
            this.ButtonCheck.Size = new System.Drawing.Size(157, 69);
            this.ButtonCheck.TabIndex = 3;
            this.ButtonCheck.Text = "CHECK";
            this.ButtonCheck.UseVisualStyleBackColor = false;
            this.ButtonCheck.Click += new System.EventHandler(this.ButtonCheck_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maveDataGridViewTextBoxColumn,
            this.biensoDataGridViewTextBoxColumn,
            this.loaixeDataGridViewTextBoxColumn,
            this.hieuxeDataGridViewTextBoxColumn,
            this.hinhanhDataGridViewImageColumn,
            this.giovaobenDataGridViewTextBoxColumn,
            this.ngayvaobenDataGridViewTextBoxColumn,
            this.giorabenDataGridViewTextBoxColumn,
            this.ngayrabenDataGridViewTextBoxColumn,
            this.tongtienDataGridViewTextBoxColumn,
            this.loaiveDataGridViewTextBoxColumn});
            this.DataGridView1.DataSource = this.thongKeBindingSource;
            this.DataGridView1.Location = new System.Drawing.Point(12, 21);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(1116, 294);
            this.DataGridView1.TabIndex = 0;
            // 
            // doAnLapTrinhTrenWIndowsDataSet
            // 
            this.doAnLapTrinhTrenWIndowsDataSet.DataSetName = "DoAnLapTrinhTrenWIndowsDataSet";
            this.doAnLapTrinhTrenWIndowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongKeBindingSource
            // 
            this.thongKeBindingSource.DataMember = "ThongKe";
            this.thongKeBindingSource.DataSource = this.doAnLapTrinhTrenWIndowsDataSet;
            // 
            // thongKeTableAdapter
            // 
            this.thongKeTableAdapter.ClearBeforeFill = true;
            // 
            // maveDataGridViewTextBoxColumn
            // 
            this.maveDataGridViewTextBoxColumn.DataPropertyName = "mave";
            this.maveDataGridViewTextBoxColumn.HeaderText = "mave";
            this.maveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maveDataGridViewTextBoxColumn.Name = "maveDataGridViewTextBoxColumn";
            this.maveDataGridViewTextBoxColumn.Width = 125;
            // 
            // biensoDataGridViewTextBoxColumn
            // 
            this.biensoDataGridViewTextBoxColumn.DataPropertyName = "bienso";
            this.biensoDataGridViewTextBoxColumn.HeaderText = "bienso";
            this.biensoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.biensoDataGridViewTextBoxColumn.Name = "biensoDataGridViewTextBoxColumn";
            this.biensoDataGridViewTextBoxColumn.Width = 125;
            // 
            // loaixeDataGridViewTextBoxColumn
            // 
            this.loaixeDataGridViewTextBoxColumn.DataPropertyName = "loaixe";
            this.loaixeDataGridViewTextBoxColumn.HeaderText = "loaixe";
            this.loaixeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaixeDataGridViewTextBoxColumn.Name = "loaixeDataGridViewTextBoxColumn";
            this.loaixeDataGridViewTextBoxColumn.Width = 125;
            // 
            // hieuxeDataGridViewTextBoxColumn
            // 
            this.hieuxeDataGridViewTextBoxColumn.DataPropertyName = "hieuxe";
            this.hieuxeDataGridViewTextBoxColumn.HeaderText = "hieuxe";
            this.hieuxeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hieuxeDataGridViewTextBoxColumn.Name = "hieuxeDataGridViewTextBoxColumn";
            this.hieuxeDataGridViewTextBoxColumn.Width = 125;
            // 
            // hinhanhDataGridViewImageColumn
            // 
            this.hinhanhDataGridViewImageColumn.DataPropertyName = "hinhanh";
            this.hinhanhDataGridViewImageColumn.HeaderText = "hinhanh";
            this.hinhanhDataGridViewImageColumn.MinimumWidth = 6;
            this.hinhanhDataGridViewImageColumn.Name = "hinhanhDataGridViewImageColumn";
            this.hinhanhDataGridViewImageColumn.Width = 125;
            // 
            // giovaobenDataGridViewTextBoxColumn
            // 
            this.giovaobenDataGridViewTextBoxColumn.DataPropertyName = "giovaoben";
            this.giovaobenDataGridViewTextBoxColumn.HeaderText = "giovaoben";
            this.giovaobenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giovaobenDataGridViewTextBoxColumn.Name = "giovaobenDataGridViewTextBoxColumn";
            this.giovaobenDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayvaobenDataGridViewTextBoxColumn
            // 
            this.ngayvaobenDataGridViewTextBoxColumn.DataPropertyName = "ngayvaoben";
            this.ngayvaobenDataGridViewTextBoxColumn.HeaderText = "ngayvaoben";
            this.ngayvaobenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayvaobenDataGridViewTextBoxColumn.Name = "ngayvaobenDataGridViewTextBoxColumn";
            this.ngayvaobenDataGridViewTextBoxColumn.Width = 125;
            // 
            // giorabenDataGridViewTextBoxColumn
            // 
            this.giorabenDataGridViewTextBoxColumn.DataPropertyName = "gioraben";
            this.giorabenDataGridViewTextBoxColumn.HeaderText = "gioraben";
            this.giorabenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giorabenDataGridViewTextBoxColumn.Name = "giorabenDataGridViewTextBoxColumn";
            this.giorabenDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayrabenDataGridViewTextBoxColumn
            // 
            this.ngayrabenDataGridViewTextBoxColumn.DataPropertyName = "ngayraben";
            this.ngayrabenDataGridViewTextBoxColumn.HeaderText = "ngayraben";
            this.ngayrabenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayrabenDataGridViewTextBoxColumn.Name = "ngayrabenDataGridViewTextBoxColumn";
            this.ngayrabenDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongtienDataGridViewTextBoxColumn
            // 
            this.tongtienDataGridViewTextBoxColumn.DataPropertyName = "tongtien";
            this.tongtienDataGridViewTextBoxColumn.HeaderText = "tongtien";
            this.tongtienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongtienDataGridViewTextBoxColumn.Name = "tongtienDataGridViewTextBoxColumn";
            this.tongtienDataGridViewTextBoxColumn.Width = 125;
            // 
            // loaiveDataGridViewTextBoxColumn
            // 
            this.loaiveDataGridViewTextBoxColumn.DataPropertyName = "loaive";
            this.loaiveDataGridViewTextBoxColumn.HeaderText = "loaive";
            this.loaiveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiveDataGridViewTextBoxColumn.Name = "loaiveDataGridViewTextBoxColumn";
            this.loaiveDataGridViewTextBoxColumn.Width = 125;
            // 
            // lb_TongDoanhThu
            // 
            this.lb_TongDoanhThu.BackColor = System.Drawing.Color.Red;
            this.lb_TongDoanhThu.Location = new System.Drawing.Point(829, 490);
            this.lb_TongDoanhThu.Name = "lb_TongDoanhThu";
            this.lb_TongDoanhThu.Size = new System.Drawing.Size(299, 61);
            this.lb_TongDoanhThu.TabIndex = 2;
            this.lb_TongDoanhThu.Text = "label2";
            // 
            // RadioBtXehoi
            // 
            this.RadioBtXehoi.AutoSize = true;
            this.RadioBtXehoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtXehoi.Location = new System.Drawing.Point(26, 117);
            this.RadioBtXehoi.Name = "RadioBtXehoi";
            this.RadioBtXehoi.Size = new System.Drawing.Size(95, 29);
            this.RadioBtXehoi.TabIndex = 4;
            this.RadioBtXehoi.TabStop = true;
            this.RadioBtXehoi.Text = "Xe hơi";
            this.RadioBtXehoi.UseVisualStyleBackColor = true;
            // 
            // RadioBtXemay
            // 
            this.RadioBtXemay.AutoSize = true;
            this.RadioBtXemay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtXemay.Location = new System.Drawing.Point(26, 69);
            this.RadioBtXemay.Name = "RadioBtXemay";
            this.RadioBtXemay.Size = new System.Drawing.Size(106, 29);
            this.RadioBtXemay.TabIndex = 5;
            this.RadioBtXemay.TabStop = true;
            this.RadioBtXemay.Text = "Xe máy";
            this.RadioBtXemay.UseVisualStyleBackColor = true;
            // 
            // RadioBtXedap
            // 
            this.RadioBtXedap.AutoSize = true;
            this.RadioBtXedap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtXedap.Location = new System.Drawing.Point(26, 21);
            this.RadioBtXedap.Name = "RadioBtXedap";
            this.RadioBtXedap.Size = new System.Drawing.Size(102, 29);
            this.RadioBtXedap.TabIndex = 6;
            this.RadioBtXedap.TabStop = true;
            this.RadioBtXedap.Text = "Xe đạp";
            this.RadioBtXedap.UseVisualStyleBackColor = true;
            // 
            // frmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 600);
            this.Controls.Add(this.lb_TongDoanhThu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThongKeDoanhThu";
            this.Text = "frmThongKeDoanhThu";
            this.Load += new System.EventHandler(this.frmThongKeDoanhThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnLapTrinhTrenWIndowsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonCheck;
        private System.Windows.Forms.DataGridView DataGridView1;
        private DoAnLapTrinhTrenWIndowsDataSet doAnLapTrinhTrenWIndowsDataSet;
        private System.Windows.Forms.BindingSource thongKeBindingSource;
        private DoAnLapTrinhTrenWIndowsDataSetTableAdapters.ThongKeTableAdapter thongKeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biensoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaixeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hieuxeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn hinhanhDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giovaobenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayvaobenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giorabenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayrabenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton RadioBtXehoi;
        private System.Windows.Forms.RadioButton RadioBtXemay;
        private System.Windows.Forms.RadioButton RadioBtXedap;
        private System.Windows.Forms.Label lb_TongDoanhThu;
    }
}