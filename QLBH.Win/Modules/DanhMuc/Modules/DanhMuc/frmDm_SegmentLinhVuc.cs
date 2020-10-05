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
    public partial class frmDm_SegmentLinhVuc : frmDM_Segment
    {
        public frmDm_SegmentLinhVuc()
        {
            InitializeComponent();
            dmSegmentDataProvider = DmLinhVucDataProvider.Instance;
            //btnThemMoi.Enabled = false;
            //btnXoa.Enabled = false;
        }

        protected override void LoadData()
        {
            grcBase.DataSource = DmLinhVucDataProvider.Instance.GetListSegmentInfor();
        }
        private void frmDm_SegmentChildLinhVuc_OnCapNhat(object sender, EventArgs e)
        {
            if (Info != null)
            {
                isAdd = false;
                frmChiTiet_SegmenLinhVuc frm = new frmChiTiet_SegmenLinhVuc(Info);
                frm.ShowDialog();
            }
        }

        void frmDm_SegmentLinhVuc_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Info = ((SegmentInfo)dgvDanhSachMatHang.GetFocusedRow());
            btnXoa.Enabled = false;
        }

        private void frmDm_SegmentChildLinhVuc_OnGridDoubleClick(object sender, EventArgs e)
        {
            if (Info != null)
            {
                isAdd = false;
                frmChiTiet_SegmenLinhVuc frm = new frmChiTiet_SegmenLinhVuc(Info);
                frm.ShowDialog();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            grcBase.DataSource = dmSegmentDataProvider.SearchSegmentInfor(txtTimKiemMa.Text, txtTimKiemTen.Text);
        }
    }
}