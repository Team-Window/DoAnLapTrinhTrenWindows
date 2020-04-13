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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.doAnLapTrinhTrenWIndowsDataSet = new QuanLiOto.DoAnLapTrinhTrenWIndowsDataSet();
            this.thongKeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongKeTableAdapter = new QuanLiOto.DoAnLapTrinhTrenWIndowsDataSetTableAdapters.ThongKeTableAdapter();
            this.thongKeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnLapTrinhTrenWIndowsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1065, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1078, 340);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
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
            this.DataGridView1.DataSource = this.thongKeBindingSource1;
            this.DataGridView1.Location = new System.Drawing.Point(0, 11);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(1066, 293);
            this.DataGridView1.TabIndex = 0;
            // 
            // doAnLapTrinhTrenWIndowsDataSet
            // 
            this.doAnLapTrinhTrenWIndowsDataSet.DataSetName = "DoAnLapTrinhTrenWIndowsDataSet";
            this.doAnLapTrinhTrenWIndowsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongKeTableAdapter
            // 
            this.thongKeTableAdapter.ClearBeforeFill = true;
            // 
            // thongKeBindingSource1
            // 
            this.thongKeBindingSource1.DataMember = "ThongKe";
            this.thongKeBindingSource1.DataSource = this.doAnLapTrinhTrenWIndowsDataSet;
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
            // frmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 576);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThongKeDoanhThu";
            this.Text = "frmThongKeDoanhThu";
            this.Load += new System.EventHandler(this.frmThongKeDoanhThu_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnLapTrinhTrenWIndowsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.BindingSource thongKeBindingSource1;
    }
}