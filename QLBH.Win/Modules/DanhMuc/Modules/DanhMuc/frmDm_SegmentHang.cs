using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmDm_SegmentHang : frmDM_Segment
    {
        public frmDm_SegmentHang()
        {
            InitializeComponent();
            dmSegmentDataProvider = DmHangDataProvider.Instance;
            //btnThemMoi.Enabled = false;
            //btnXoa.Enabled = false;
        }

        private void frmDm_SegmentHang_OnCapNhat(object sender, EventArgs e)
        {
            if (Info != null)
            {
                isAdd = false;
                frmChiTiet_SegmentHang frm = new frmChiTiet_SegmentHang(Info);
                frm.ShowDialog();
            }
        }

        void frmDm_SegmentHang_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Info = ((SegmentInfo)dgvDanhSachMatHang.GetFocusedRow());
            btnXoa.Enabled = false;
        }

        private void frmDm_SegmentHang_OnGridDoubleClick(object sender, EventArgs e)
        {
            if (Info != null)
            {
                isAdd = false;
                frmChiTiet_SegmentHang frm = new frmChiTiet_SegmentHang(Info);
                frm.ShowDialog();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            grcBase.DataSource = dmSegmentDataProvider.SearchSegmentInfor(txtTimKiemMa.Text, txtTimKiemTen.Text);
        }
    }
}
