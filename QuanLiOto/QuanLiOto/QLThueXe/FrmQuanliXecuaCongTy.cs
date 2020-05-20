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
    public partial class FrmQuanliXecuaCongTy : Form
    {
        public FrmQuanliXecuaCongTy()
        {
            InitializeComponent();
        }
        QLThue qLThue = new QLThue();
        private void FrmQuanliXecuaCongTy_Load(object sender, EventArgs e)
        {
            dtv_cacxecongty.DataSource = qLThue.getXecuaCongTy();
            for(int i=0;i<dtv_cacxecongty.Rows.Count-1;i++)
            {
                string bienso="";
                try
                {
                     bienso = dtv_cacxecongty.Rows[i].Cells[2].Value.ToString();
                }
                catch
                {

                }
                
                if (qLThue.XeThueExist(bienso, "Thuê") == true)
                    {

                        dtv_cacxecongty.Rows[i].Cells[4].Value = "Đang được thuê";
                    }
                else
                    {
                        dtv_cacxecongty.Rows[i].Cells[4].Value = "Chưa được thuê";
                    }
                
            }    
            
        }
    }
}
