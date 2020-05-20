using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiOto.QLThueXe
{
    public partial class MainFormThueXe : Form
    {
        public MainFormThueXe()
        {
            InitializeComponent();
        }

        private void danhSáchCácXeChoThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCacXechothue frmCacXechothue = new FrmCacXechothue();
            frmCacXechothue.Show(this);
        }

        private void danhSáchHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQLDSThue frmQLDSThue = new FrmQLDSThue();
            frmQLDSThue.Show(this);
        }

        private void tạoHợpĐồngMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThemDSThue frmThemDSThue = new FrmThemDSThue();
            frmThemDSThue.Show(this);
        }

        private void thêmXeThuêCủaCôngTyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmXecuaCongTy frmXecuaCongTy = new FrmXecuaCongTy();
            frmXecuaCongTy.Show(this);
        }

        private void quảnLýCácXeCủaCôngTyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuanliXecuaCongTy frmQuanliXecuaCongTy = new FrmQuanliXecuaCongTy();
            frmQuanliXecuaCongTy.Show(this);
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKeXeChoThue formThongKeXeChoThue = new FormThongKeXeChoThue();
            formThongKeXeChoThue.Show(this);
        }
    }
}
