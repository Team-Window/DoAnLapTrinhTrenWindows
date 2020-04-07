using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiOto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_ThueXeDap_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_GuiXe_Click(object sender, EventArgs e)
        {
            frmGuiXe guiXe=new frmGuiXe();
            guiXe.ShowDialog(this);
        }
    }
}
