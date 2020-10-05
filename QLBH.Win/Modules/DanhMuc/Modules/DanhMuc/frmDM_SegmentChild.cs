using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc
{
    public  partial class frmDM_SegmentChild : frmDM_ListBaseNew
    {
        protected DmSegmentChildDataProvider dmSegmentChildDataProvider;

        private SegmentChildInfo segmentChildInfo;
        public SegmentChildInfo Info
        {
            get { return segmentChildInfo; }
            protected set { segmentChildInfo = value; }
        }

        public frmDM_SegmentChild()
        {
            InitializeComponent();
        }

        protected override void LoadData()
        {
            grcBase.DataSource = dmSegmentChildDataProvider.GetListSegmentChildInfor();
        }
    }
}