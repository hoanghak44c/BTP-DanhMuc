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
    public partial class frmDM_SegmentChildNganh : frmDM_SegmentChild
    {
        public frmDM_SegmentChildNganh()
        {
            InitializeComponent();
            dmSegmentChildDataProvider = DmNganhDataProvider.Instance;
            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void frmDM_SegmentChildNganh_OnCapNhat(object sender, EventArgs e)
        {
            if (Info != null)
            {
                isAdd = false;
                frmChiTiet_SegmentChildNganh frm = new frmChiTiet_SegmentChildNganh(Info);
                frm.ShowDialog();
            }
        }

        void frmDM_SegmentChildNganh_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Info = ((SegmentChildInfo)dgvDanhSachMatHang.GetFocusedRow());
            btnXoa.Enabled = false;
        }

        private void frmDM_SegmentChildNganh_OnGridDoubleClick(object sender, EventArgs e)
        {
            if (Info != null)
            {
                isAdd = false;
                frmChiTiet_SegmentChildNganh frm = new frmChiTiet_SegmentChildNganh(Info);
                frm.ShowDialog();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            grcBase.DataSource = dmSegmentChildDataProvider.SearchSegmentChildInfor(txtTimKiemMa.Text, txtTimKiemTen.Text);
        }
    }
}