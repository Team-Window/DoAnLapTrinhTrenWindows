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
            this.lbl_ThueXe = new System.Windows.Forms.Label();
            this.lbl_GuiXe = new System.Windows.Forms.Label();
            this.btn_GuiXe = new System.Windows.Forms.Button();
            this.btn_ThueXeDap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_TieuDe
            // 
            this.lbl_TieuDe.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe.Location = new System.Drawing.Point(0, -1);
            this.lbl_TieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TieuDe.Name = "lbl_TieuDe";
            this.lbl_TieuDe.Size = new System.Drawing.Size(989, 121);
            this.lbl_TieuDe.TabIndex = 0;
            this.lbl_TieuDe.Text = "Phần mềm quản lý hệ thống chăm sóc và gởi xe khép kín";
            this.lbl_TieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ThueXe
            // 
            this.lbl_ThueXe.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThueXe.Location = new System.Drawing.Point(388, 119);
            this.lbl_ThueXe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ThueXe.Name = "lbl_ThueXe";
            this.lbl_ThueXe.Size = new System.Drawing.Size(209, 95);
            this.lbl_ThueXe.TabIndex = 1;
            this.lbl_ThueXe.Text = "Thuê xe";
            this.lbl_ThueXe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GuiXe
            // 
            this.lbl_GuiXe.AutoSize = true;
            this.lbl_GuiXe.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GuiXe.Location = new System.Drawing.Point(63, 142);
            this.lbl_GuiXe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GuiXe.Name = "lbl_GuiXe";
            this.lbl_GuiXe.Size = new System.Drawing.Size(146, 51);
            this.lbl_GuiXe.TabIndex = 3;
            this.lbl_GuiXe.Text = "Gửi xe";
            // 
            // btn_GuiXe
            // 
            this.btn_GuiXe.BackgroundImage = global::QuanLiOto.Properties.Resources.ImageGuiXe;
            this.btn_GuiXe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_GuiXe.Location = new System.Drawing.Point(84, 194);
            this.btn_GuiXe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GuiXe.Name = "btn_GuiXe";
            this.btn_GuiXe.Size = new System.Drawing.Size(116, 65);
            this.btn_GuiXe.TabIndex = 4;
            this.btn_GuiXe.UseVisualStyleBackColor = true;
            this.btn_GuiXe.Click += new System.EventHandler(this.btn_GuiXe_Click);
            // 
            // btn_ThueXeDap
            // 
            this.btn_ThueXeDap.BackgroundImage = global::QuanLiOto.Properties.Resources.ImageXeDap;
            this.btn_ThueXeDap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ThueXeDap.Location = new System.Drawing.Point(416, 197);
            this.btn_ThueXeDap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThueXeDap.Name = "btn_ThueXeDap";
            this.btn_ThueXeDap.Size = new System.Drawing.Size(85, 63);
            this.btn_ThueXeDap.TabIndex = 2;
            this.btn_ThueXeDap.UseVisualStyleBackColor = true;
            this.btn_ThueXeDap.Click += new System.EventHandler(this.btn_ThueXeDap_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(988, 443);
            this.Controls.Add(this.btn_GuiXe);
            this.Controls.Add(this.lbl_GuiXe);
            this.Controls.Add(this.btn_ThueXeDap);
            this.Controls.Add(this.lbl_ThueXe);
            this.Controls.Add(this.lbl_TieuDe);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TieuDe;
        private System.Windows.Forms.Label lbl_ThueXe;
        private System.Windows.Forms.Button btn_ThueXeDap;
        private System.Windows.Forms.Label lbl_GuiXe;
        private System.Windows.Forms.Button btn_GuiXe;
    }
}

