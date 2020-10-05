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
    public partial class frmChiTiet_SegmenLinhVuc : ChiTietSegmentLinhVucController
    {
        public frmChiTiet_SegmenLinhVuc(SegmentInfo linhVucInfo)
        {
            InitializeComponent();
            //this.frmList = frm;
            this.dm = linhVucInfo;
        }

        public frmChiTiet_SegmenLinhVuc(frmDm_SegmentLinhVuc frm)
        {
            InitializeComponent();
            this.frmList = frm;
        }

        private void frmChiTiet_SegmenLinhVuc_Load(object sender, EventArgs e)
        {
            SetFormInfo(dm.Ten, dm.Ma);
        }
    }
}