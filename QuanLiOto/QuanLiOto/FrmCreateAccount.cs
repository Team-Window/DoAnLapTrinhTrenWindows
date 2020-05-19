using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiOto
{
    public partial class FrmCreateAccount : Form
    {
        public FrmCreateAccount()
        {
            InitializeComponent();
        }

        private void FrmCreateAccount_Load(object sender, EventArgs e)
        {

        }
        login log = new login();
        private void lbl_HavedAccount_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool verif()
        {
            if ((txb_FirstName.Text.Trim() == "")
                || (txb_LastName.Text.Trim() == "")
                    || (txb_Password.Text.Trim() == "")
                        || (txb_UserName.Text.Trim() == "")
                            || (cb_ChucVu.SelectedIndex == null)
                                || (ptb_Anh.Image == null))

            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Seclect Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                ptb_Anh.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string fname = txb_FirstName.Text;
            string lname = txb_LastName.Text;
            string uname = txb_UserName.Text;
            string password = txb_Password.Text;
            MemoryStream pic = new MemoryStream();
            string chucvu;
            if (cb_ChucVu.SelectedIndex == 0)
            {
                chucvu = "Nhân viên";
            }
            else
            {
                chucvu = "Quản lí";
            }
            if (verif())
            {
                ptb_Anh.Image.Save(pic, ptb_Anh.Image.RawFormat);
                if (log.insertUser(fname, lname, uname, password, pic, chucvu))
                {
                    MessageBox.Show("New Account Add", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
