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
    public partial class frmChiTiet_SegmentChildNganh : ChiTietSegmentChildNganhController
    {
        public frmChiTiet_SegmentChildNganh(SegmentChildInfo segmentChildInfo)
        {
            InitializeComponent();
            dm = segmentChildInfo;
        }
        public frmChiTiet_SegmentChildNganh(frmDM_SegmentChildNganh frm)
        {
            InitializeComponent();
            this.frmList = frm;
        }

        private void frmChiTiet_SegmentChildNganh_Load(object sender, EventArgs e)
        {
            SetFormInfo(dm.Ma,dm.Ten,dm.MaCha);
        }
    }
}