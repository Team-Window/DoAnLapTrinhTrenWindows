﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiOto
{
    public partial class FrmXemLuongThuongDanhChoNhanVien : Form
    {
        public FrmXemLuongThuongDanhChoNhanVien()
        {
            InitializeComponent();
        }
        QLPhieuThanhToan phieuthanhtoan = new QLPhieuThanhToan();
        private void FrmXemLuongThuongDanhChoNhanVien_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM phieutraluong WHERE iduser =" + Globals.GlobalUserId);
            DataTable table = phieuthanhtoan.getPhieuThanhToan(command);
            dtgv_BangLuong.DataSource = table;
        }
    }
}
