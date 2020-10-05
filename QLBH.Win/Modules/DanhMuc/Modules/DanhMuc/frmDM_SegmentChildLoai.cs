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
    public partial class frmDM_SegmentChildLoai : frmDM_SegmentChild
    {
        public frmDM_SegmentChildLoai()
        {
            InitializeComponent();
            dmSegmentChildDataProvider = DmLoaiDataProvider.Instance;
            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void frmDM_SegmentChildLoai_OnCapNhat(object sender, EventArgs e)
        {
            if (Info != null)
            {
                isAdd = false;
                frmChiTiet_SegmentChildLoai frm = new frmChiTiet_SegmentChildLoai(Info);
                frm.ShowDialog();
            }
        }

        void frmDM_SegmentChildLoai_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Info = ((SegmentChildInfo)dgvDanhSachMatHang.GetFocusedRow());
            btnXoa.Enabled = false;
        }

        private void frmDM_SegmentChildLoai_OnGridDoubleClick(object sender, EventArgs e)
        {
            if (Info != null)
            {
                isAdd = false;
                frmChiTiet_SegmentChildLoai frm = new frmChiTiet_SegmentChildLoai(Info);
                frm.ShowDialog();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            grcBase.DataSource = dmSegmentChildDataProvider.SearchSegmentChildInfor(txtTimKiemMa.Text, txtTimKiemTen.Text);
        }
    }
}
