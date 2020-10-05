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
    public partial class frmChiTiet_SegmentHang : ChiTietSegmentHangController
    {
        public frmChiTiet_SegmentHang(SegmentInfo segmentInfo)
        {
            InitializeComponent();
            //this.frmList = frm;
            dm = segmentInfo;
        }
        public frmChiTiet_SegmentHang(frmDm_SegmentHang frm)
        {
            InitializeComponent();
            this.frmList = frm;
        }

        private void frmChiTiet_SegmentHang_Load(object sender, EventArgs e)
        {
            SetFormInfo(dm.Ma,dm.Ten);
        }
    }
}