namespace QuanLiOto
{
    partial class Log_in
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
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_NewUsers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Login.Location = new System.Drawing.Point(76, 40);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(92, 30);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "Login";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(12, 110);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(63, 13);
            this.lbl_UserName.TabIndex = 1;
            this.lbl_UserName.Text = "User Name:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(12, 153);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(56, 13);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password:";
            // 
            // txb_UserName
            // 
            this.txb_UserName.Location = new System.Drawing.Point(81, 110);
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(162, 20);
            this.txb_UserName.TabIndex = 3;
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(81, 153);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(162, 20);
            this.txb_Password.TabIndex = 4;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Login.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_Login.Location = new System.Drawing.Point(136, 196);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(94, 41);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Cancel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Cancel.Location = new System.Drawing.Point(15, 196);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(91, 41);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_NewUsers
            // 
            this.lbl_NewUsers.AutoSize = true;
            this.lbl_NewUsers.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewUsers.Location = new System.Drawing.Point(12, 250);
            this.lbl_NewUsers.Name = "lbl_NewUsers";
            this.lbl_NewUsers.Size = new System.Drawing.Size(81, 19);
            this.lbl_NewUsers.TabIndex = 9;
            this.lbl_NewUsers.Text = "New User?";
            this.lbl_NewUsers.Click += new System.EventHandler(this.lbl_NewUsers_Click);
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 272);
            this.Controls.Add(this.lbl_NewUsers);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_UserName);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.lbl_Login);
            this.Name = "Log_in";
            this.Text = "Log_in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_NewUsers;
    }
}