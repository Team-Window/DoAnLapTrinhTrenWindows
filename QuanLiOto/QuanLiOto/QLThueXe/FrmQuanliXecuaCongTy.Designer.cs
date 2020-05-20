namespace QuanLiOto.QLThueXe
{
    partial class FrmQuanliXecuaCongTy
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
            this.dtv_cacxecongty = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_cacxecongty)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv_cacxecongty
            // 
            this.dtv_cacxecongty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_cacxecongty.Location = new System.Drawing.Point(13, 13);
            this.dtv_cacxecongty.Name = "dtv_cacxecongty";
            this.dtv_cacxecongty.RowHeadersWidth = 51;
            this.dtv_cacxecongty.RowTemplate.Height = 24;
            this.dtv_cacxecongty.Size = new System.Drawing.Size(783, 354);
            this.dtv_cacxecongty.TabIndex = 0;
            // 
            // FrmQuanliXecuaCongTy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtv_cacxecongty);
            this.Name = "FrmQuanliXecuaCongTy";
            this.Text = "FrmQuanliXecuaCongTy";
            this.Load += new System.EventHandler(this.FrmQuanliXecuaCongTy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_cacxecongty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtv_cacxecongty;
    }
}