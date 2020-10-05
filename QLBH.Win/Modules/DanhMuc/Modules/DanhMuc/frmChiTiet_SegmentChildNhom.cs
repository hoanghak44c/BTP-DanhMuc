using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_SegmentChildNhom : ChiTietSegmentChildNhomController
    {
        public frmChiTiet_SegmentChildNhom(SegmentChildInfo segmentInfo)
        {
            InitializeComponent();
            dm = segmentInfo;
        }
        public frmChiTiet_SegmentChildNhom(frmDM_SegmentChildNhom frm)
        {
            InitializeComponent();
            this.frmList = frm;
        }

        private void frmChiTiet_SegmentChildNhom_Load(object sender, EventArgs e)
        {
            SetFormInfo(dm.Ma, dm.Ten, dm.MaCha);
        }
    }
}