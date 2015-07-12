using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUL;

namespace GUI.Nghiepvu
{
    public partial class frmLapdonhang : Form
    {
        public frmLapdonhang()
        {
            InitializeComponent();
        }

        DataTable dtKH = null;
        Business BUL = new Business();

        private void rdbThuno_CheckedChanged(object sender, EventArgs e)
        {
            btnxuatphieu.Text = "Xuất phiếu bán hàng";
        }
        
        private void LoadKH()
        {
            if (BUL.Connect())
            {
                dtKH = new DataTable();
                dtKH = BUL.ExecuteCommandSelect("SELECT ID,cus.Hoten,cus.Diachi,cus.Ngaysinh,cus.SDT,cus.DD,cus.Fax,cus.Mail FROM tblCustomer cus WHERE cus.[Status]=1");
                cbotenKH.DataSource = dtKH;
                cbotenKH.DisplayMember = "Hoten";
                cbotenKH.ValueMember = "ID";
                cbotenKH.SelectedIndex = 0;
                BUL.close();
            }
        }

        private void frmLaphoadon_Load(object sender, EventArgs e)
        {
            LoadKH();
        }

        private void txtMaKH_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMaKH.Text.Trim())==false)
                MessageBox.Show("Kiem tra");
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            
        }

        private void rdbdonhangchiphi_CheckedChanged(object sender, EventArgs e)
        {
            btnxuatphieu.Text = "Xuất phiếu chi phí";
        }

        private void cbotenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show ("abc");
        }        
    }
}
