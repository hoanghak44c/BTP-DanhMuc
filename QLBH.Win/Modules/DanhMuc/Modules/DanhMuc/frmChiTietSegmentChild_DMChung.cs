using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTietSegmentChild_DMChung : frmChiTietSegment_DMChung
    {
        public frmChiTietSegmentChild_DMChung()
        {
            InitializeComponent();
        }

        private void frmChiTietSegmentChild_DMChung_Load(object sender, EventArgs e)
        {
            try
            {
                if (!DesignMode) LoadData();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }
    }
}