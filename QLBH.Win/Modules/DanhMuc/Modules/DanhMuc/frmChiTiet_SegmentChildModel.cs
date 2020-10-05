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
    public partial class frmChiTiet_SegmentChildModel : ChiTietSegmentChildModelController
    {
        public frmChiTiet_SegmentChildModel(SegmentChildInfo segmentInfo)
        {
            InitializeComponent();
            dm = segmentInfo;
        }
        public frmChiTiet_SegmentChildModel(frmDM_SegmentChildModel frm)
        {
            InitializeComponent();
            this.frmList = frm;
        }

        private void frmChiTiet_SegmentChildModel_Load(object sender, EventArgs e)
        {
            SetFormInfo(dm.Ma,dm.Ten,dm.MaCha);
        }
    }
}