using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Nghiepvu.frmNhaphang m_Nhaphang = null;
        private void mnnhaphang_Click(object sender, EventArgs e)
        {
            if (m_Nhaphang == null || m_Nhaphang.IsDisposed)
            {
                m_Nhaphang = new Nghiepvu.frmNhaphang();
                m_Nhaphang.Show();
            }
            else m_Nhaphang.Activate();
        }

        private void mndanhmuc_Click(object sender, EventArgs e)
        {

        }

        Nghiepvu.frmLapdonhang m_LHD = null;
        private void mnhoadonthuno_Click(object sender, EventArgs e)
        {
            if (m_LHD == null || m_LHD.IsDisposed)
            {
                m_LHD = new Nghiepvu.frmLapdonhang();
                m_LHD.Show();
            }
            else m_LHD.Activate();
        }        
    }
}
