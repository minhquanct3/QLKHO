﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI.Hethong
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void mnKetnoi_Click(object sender, EventArgs e)
        {
            Hethong.frmURL m_URL = new frmURL();
            m_URL.ShowDialog();
        }

        private void btnok_Click(object sender, EventArgs e)
        {

        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
