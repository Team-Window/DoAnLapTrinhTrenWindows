namespace QuanLiOto
{
    partial class MainForm
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
            this.lbl_TieuDe = new System.Windows.Forms.Label();
            this.lbl_XeThue = new System.Windows.Forms.Label();
            this.lbl_GuiXe = new System.Windows.Forms.Label();
            this.btn_XeThue = new System.Windows.Forms.Button();
            this.btn_GuiXe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_TieuDe
            // 
            this.lbl_TieuDe.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe.Location = new System.Drawing.Point(0, -1);
            this.lbl_TieuDe.Name = "lbl_TieuDe";
            this.lbl_TieuDe.Size = new System.Drawing.Size(742, 98);
            this.lbl_TieuDe.TabIndex = 0;
            this.lbl_TieuDe.Text = "Phần mềm quản lý hệ thống chăm sóc và gởi xe khép kín";
            this.lbl_TieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_XeThue
            // 
            this.lbl_XeThue.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_XeThue.Location = new System.Drawing.Point(295, 97);
            this.lbl_XeThue.Name = "lbl_XeThue";
            this.lbl_XeThue.Size = new System.Drawing.Size(157, 77);
            this.lbl_XeThue.TabIndex = 1;
            this.lbl_XeThue.Text = "Xe thuê";
            this.lbl_XeThue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GuiXe
            // 
            this.lbl_GuiXe.AutoSize = true;
            this.lbl_GuiXe.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GuiXe.Location = new System.Drawing.Point(47, 115);
            this.lbl_GuiXe.Name = "lbl_GuiXe";
            this.lbl_GuiXe.Size = new System.Drawing.Size(117, 40);
            this.lbl_GuiXe.TabIndex = 3;
            this.lbl_GuiXe.Text = "Gửi xe";
            // 
            // btn_XeThue
            // 
            this.btn_XeThue.BackgroundImage = global::QuanLiOto.Properties.Resources.tải_xuống;
            this.btn_XeThue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_XeThue.Location = new System.Drawing.Point(324, 159);
            this.btn_XeThue.Name = "btn_XeThue";
            this.btn_XeThue.Size = new System.Drawing.Size(95, 61);
            this.btn_XeThue.TabIndex = 5;
            this.btn_XeThue.UseVisualStyleBackColor = true;
            this.btn_XeThue.Click += new System.EventHandler(this.btn_XeThue_Click);
            // 
            // btn_GuiXe
            // 
            this.btn_GuiXe.BackgroundImage = global::QuanLiOto.Properties.Resources.ImageGuiXe;
            this.btn_GuiXe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_GuiXe.Location = new System.Drawing.Point(54, 167);
            this.btn_GuiXe.Name = "btn_GuiXe";
            this.btn_GuiXe.Size = new System.Drawing.Size(87, 53);
            this.btn_GuiXe.TabIndex = 4;
            this.btn_GuiXe.UseVisualStyleBackColor = true;
            this.btn_GuiXe.Click += new System.EventHandler(this.btn_GuiXe_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(741, 360);
            this.Controls.Add(this.btn_XeThue);
            this.Controls.Add(this.btn_GuiXe);
            this.Controls.Add(this.lbl_GuiXe);
            this.Controls.Add(this.lbl_XeThue);
            this.Controls.Add(this.lbl_TieuDe);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TieuDe;
        private System.Windows.Forms.Label lbl_XeThue;
        private System.Windows.Forms.Label lbl_GuiXe;
        private System.Windows.Forms.Button btn_GuiXe;
        private System.Windows.Forms.Button btn_XeThue;
    }
}

