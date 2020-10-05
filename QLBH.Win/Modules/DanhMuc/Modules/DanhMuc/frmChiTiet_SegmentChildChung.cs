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
    public partial class frmChiTiet_SegmentChildChung : ChiTietSegmentChildChungController
    {
        public frmChiTiet_SegmentChildChung(SegmentChildInfo segmentChildInfo)
        {
            InitializeComponent();
            dm = segmentChildInfo;
        }
        public frmChiTiet_SegmentChildChung(frmDM_SegmentChildChung frm)
        {
            InitializeComponent();
            this.frmList = frm;
        }

        private void frmChiTiet_SegmentChildChung_Load(object sender, EventArgs e)
        {
            SetFormInfo(dm.Ma,dm.Ten,dm.MaCha);
        }
    }
}