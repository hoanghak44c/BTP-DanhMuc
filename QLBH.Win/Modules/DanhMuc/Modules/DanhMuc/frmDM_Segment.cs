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
    [DesignerCategory("")]
    public partial class frmDM_Segment : frmDM_ListBaseNew
    {
        protected DmSegmentDataProvider dmSegmentDataProvider;

        private SegmentInfo segmentInfo;
        public SegmentInfo Info
        {
            get { return segmentInfo; }
            protected set { segmentInfo = value; }
        }

        protected frmDM_Segment()
        {
            InitializeComponent();
        }

        protected override void LoadData()
        {
            SyncProvider = dmSegmentDataProvider;
            LoadSync();
            grcBase.DataSource = dmSegmentDataProvider.GetListSegmentInfor();
        }
    }
}